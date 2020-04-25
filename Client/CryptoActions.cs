using System;
using System.Text;

using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Pkcs;

namespace Client
{
    class CryptoActions
    {
        static private bool VerifyCert(X509Certificate2 certificate)
        {
            X509Chain certificateChain = new X509Chain
            {
                ChainPolicy = 
                {
                    RevocationMode = X509RevocationMode.Online,
                    VerificationFlags = X509VerificationFlags.IgnoreNotTimeValid,
                    RevocationFlag = X509RevocationFlag.ExcludeRoot
                }
            };

            certificateChain.Build(certificate);

            return (certificate.NotAfter >= DateTime.Now) && 
                   (certificate.NotBefore <= DateTime.Now);
        }

        static public X509Certificate2 GetCertificate()
        {
            var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.OpenExistingOnly | OpenFlags.ReadWrite);

            X509Certificate2Collection fcollection = store.Certificates;
            X509Certificate2Collection collection =
                X509Certificate2UI.SelectFromCollection(fcollection,
                "Certificate Select",
                "Select a certificate from the following list.",
                X509SelectionFlag.SingleSelection);
            X509Certificate2 certificate = collection[0];

            return VerifyCert(certificate) ? certificate : null;
        }

        static public byte[] Sign(string message)
        {
            var certificate = GetCertificate();

            if (certificate == null)
            {
                byte[] zero = { 0 };
                return zero;
            }

            byte[] encodedMessage = new UnicodeEncoding().GetBytes(message);
            var contentInfo = new ContentInfo(encodedMessage);
            var cms = new SignedCms(contentInfo);
            var signer = new CmsSigner(certificate);
            cms.ComputeSignature(signer, false);
            
            return cms.Encode();
        }

        static public byte[] Encrypt(byte[] data)
        {
            var certificate = GetCertificate();

            if (certificate == null)
            {
                byte[] zero = { 0 };
                return zero;
            }

            var contentInfo = new ContentInfo(data);
            var cms = new EnvelopedCms(contentInfo);
            var recipient = new CmsRecipient(SubjectIdentifierType.IssuerAndSerialNumber, certificate);
            cms.Encrypt(recipient);

            return cms.Encode();
        }

        static public byte[] GetHash(string message)
        {
            using (var hash = HashAlgorithm.Create("GOST3411"))
            {
                byte[] encodedMessage = new UTF8Encoding().GetBytes(message);
                return hash.ComputeHash(encodedMessage);   
            }
        }
    }
}

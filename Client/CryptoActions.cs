using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Pkcs;

using CryptoPro.Sharpei;

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

        static public byte[] Sign(string message)
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

            if (!VerifyCert(certificate))
            {
                byte[] zero = { 0 };
                return zero;
            }

            byte[] encodedMessage = new UTF8Encoding().GetBytes(message);
            var contentInfo = new ContentInfo(encodedMessage);
            var cms = new SignedCms(contentInfo, false);
            var signer = new CmsSigner(certificate);
            cms.ComputeSignature(signer, false);
            
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

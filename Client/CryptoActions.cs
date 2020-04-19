using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

using CryptoPro.Sharpei;

namespace Client
{
    class CryptoActions
    {
        static public void Encrypt(string message)
        {
           
        }

        static public string GetHash(string message)
        {
            using (var hash = HashAlgorithm.Create("GOST3411"))
            {
                byte[] encodedMessage = new UTF8Encoding().GetBytes(message);
                hash.ComputeHash(encodedMessage);
                var messageHash = hash.Hash;
                return messageHash.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptorDecryptor
{
    public class Cryptor
    {
        readonly string secretKey;
        readonly string publicKey;

        public Cryptor(string _secretKey, string _publicKey)
        {
            secretKey = _secretKey;
            publicKey = _publicKey;
        }

        

        public string Encryption(string text)
        {
            try
            {
                byte[] secretkeyByte = { };
                secretkeyByte = Encoding.UTF8.GetBytes(secretKey);
                byte[] publickeyByte = { };
                publickeyByte = Encoding.UTF8.GetBytes(publicKey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = Encoding.UTF8.GetBytes(text);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new ();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeyByte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    text = Convert.ToBase64String(ms.ToArray());
                }
            }
            catch (Exception)
            {
            }
            return text;
        }

        public string Decryption(string text)
        {
            try
            {
                byte[] secretkeyByte = Encoding.UTF8.GetBytes(secretKey);
                byte[] publickeyByte = Encoding.UTF8.GetBytes(publicKey);
                byte[] inputbyteArray = new byte[text.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(text.Replace(" ","+"));
                MemoryStream ms = null;
                CryptoStream cs = null;
                using (DESCryptoServiceProvider des = new())
                {
                    ms = new();
                    cs = new(ms, des.CreateDecryptor(publickeyByte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    text = encoding.GetString(ms.ToArray());
                }
            }
            catch (Exception)
            {
            }
            return text;
        }
    }
}

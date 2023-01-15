using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Encoders
{
    internal class seguridad
    {
        public string getHashMD5(string sSourceData)
        {
            byte[] tmpSource = Encoding.UTF8.GetBytes(sSourceData);

            return HashMd5(tmpSource);
        }
        public string HashMd5(byte[] tmpSource)
        {
            byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            return Convert.ToHexString(tmpHash);
        }

        public string getHashSha1(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            return HashSha1(bytes);
        }
        public string HashSha1(byte[] bytes)
        {
            byte[] hash = new SHA1Managed().ComputeHash(bytes);

            return Convert.ToHexString(hash);
        }
        
        public string getHashSha256(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            return HashSha256(bytes);
        }
        public string HashSha256(byte[] bytes)
        {
            byte[] hash = new SHA256Managed().ComputeHash(bytes);

            return Convert.ToHexString(hash);
        }
        
        public string getHashSha384(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            return HashSha384(bytes);
        }
        public string HashSha384(byte[] bytes)
        {
            byte[] hash = new SHA384Managed().ComputeHash(bytes);

            return Convert.ToHexString(hash);
        }

        public string getHashSha512(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            return HashSha512(bytes);
        }
        public string HashSha512(byte[] bytes)
        {
            byte[] hash = new SHA512Managed().ComputeHash(bytes);

            return Convert.ToHexString(hash);
        }
        public string Base64archive(Byte[] text)
        {
            return Encoding.UTF8.GetString(text);
        }
        
        public string getBase64String(string text)
        {
            byte[] bytes = Convert.FromBase64String(text);
            return Encoding.UTF8.GetString(bytes);
        }
        public string getUnicodeString(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            return Encoding.UTF8.GetString(bytes);
        }
        public string getUTF7String(string text)
        {
            byte[] bytes = Encoding.UTF7.GetBytes(text);
            return Encoding.UTF8.GetString(bytes);
        }
        public string getUTF8String(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            return Encoding.UTF8.GetString(bytes);
        }
        public string getUTF32String(string text)
        {
            byte[] bytes = Encoding.UTF32.GetBytes(text);
            return Encoding.UTF8.GetString(bytes);
        }

        public string Base64String(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(bytes);
        }
        public string UnicodeString(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            return Encoding.Unicode.GetString(bytes);
        }
        public string UTF7String(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            return Encoding.UTF7.GetString(bytes);
        }
        public string UTF8String(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            return Encoding.UTF8.GetString(bytes);
        }
        public string UTF32String(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            return Encoding.UTF32.GetString(bytes);
        }

        Random rand = new Random();

        public string encriptar(string cas, string hash)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(cas);

            MD5 md5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();

            byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(hash);

            byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            rand.NextBytes(tmpSource);

            tripleDES.Key = tmpHash;

            rand.NextBytes(tmpHash);

            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            rand.NextBytes(data);

            return Convert.ToBase64String(result);
        }
        public string desencriptar(string cas, string hash)
        {
            byte[] data = Convert.FromBase64String(cas);

            MD5 md5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();

            byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(hash);

            byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            rand.NextBytes(tmpSource);

            tripleDES.Key = tmpHash;

            rand.NextBytes(tmpHash);

            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);


            rand.NextBytes(data);

            string res = UTF8Encoding.UTF8.GetString(result);

            rand.NextBytes(result);

            return res;
        }

    }
}

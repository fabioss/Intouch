namespace BIUnit4
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    public class Cript_Decript
    {
        private static TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
        private static MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        private const string myKey = "UnitFourEver";

        public static string Cifra(string texto)
        {
            des.Key = hashmd5.ComputeHash(Encoding.ASCII.GetBytes("UnitFourEver"));
            des.Mode = CipherMode.ECB;
            ICryptoTransform transform = des.CreateEncryptor();
            byte[] bytes = Encoding.ASCII.GetBytes(texto);
            return Convert.ToBase64String(transform.TransformFinalBlock(bytes, 0, bytes.Length));
        }

        public static string DeCifra(string texto)
        {
            des.Key = hashmd5.ComputeHash(Encoding.ASCII.GetBytes("UnitFourEver"));
            des.Mode = CipherMode.ECB;
            ICryptoTransform transform = des.CreateDecryptor();
            byte[] inputBuffer = Convert.FromBase64String(texto);
            return Encoding.ASCII.GetString(transform.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
        }
    }
}


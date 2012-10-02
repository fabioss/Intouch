namespace BIUnit4
{
    using System;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;

    public class Util
    {
        public string hashAlgorithm;
        public int keySize;
        public int passwordIterations;
        public string strChave;
        public string strChaveValue;
        internal byte[] strChaveValueBytes;
        public string strText;
        internal byte[] strTextoBytes;
        public string strVetorInicial;
        internal byte[] strVetorInicialBytes;

        public string CriptografarSenha(string strTexto)
        {
            if (string.IsNullOrEmpty(this.strVetorInicial))
            {
                this.strText = strTexto;
                this.MAIN();
            }
            this.strVetorInicialBytes = Encoding.ASCII.GetBytes(this.strVetorInicial);
            this.strChaveValueBytes = Encoding.ASCII.GetBytes(this.strChaveValue);
            this.strTextoBytes = Encoding.UTF8.GetBytes(strTexto);
            byte[] bytes = new PasswordDeriveBytes(this.strChave, this.strChaveValueBytes, this.hashAlgorithm, this.passwordIterations).GetBytes(Convert.ToInt32(Math.Round((double) (Convert.ToDouble(this.keySize) / 8.0))));
            ICryptoTransform transform = new RijndaelManaged { Mode = CipherMode.CBC }.CreateEncryptor(bytes, this.strVetorInicialBytes);
            MemoryStream stream = new MemoryStream();
            CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
            stream2.Write(this.strTextoBytes, 0, this.strTextoBytes.Length);
            stream2.FlushFinalBlock();
            byte[] inArray = stream.ToArray();
            stream.Close();
            stream2.Close();
            return Convert.ToBase64String(inArray);
        }

        public string DecriptografarSenha(string strSenha)
        {
            if (string.IsNullOrEmpty(this.strVetorInicial))
            {
                this.MAIN();
            }
            this.strVetorInicialBytes = Encoding.ASCII.GetBytes(this.strVetorInicial);
            this.strChaveValueBytes = Encoding.ASCII.GetBytes(this.strChaveValue);
            byte[] buffer = Convert.FromBase64String(strSenha);
            byte[] bytes = new PasswordDeriveBytes(this.strChave, this.strChaveValueBytes, this.hashAlgorithm, this.passwordIterations).GetBytes(Convert.ToInt32(Math.Round((double) (Convert.ToDouble(this.keySize) / 8.0))));
            ICryptoTransform transform = new RijndaelManaged { Mode = CipherMode.CBC }.CreateDecryptor(bytes, this.strVetorInicialBytes);
            MemoryStream stream = new MemoryStream(buffer);
            CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
            byte[] buffer3 = new byte[buffer.Length + 1];
            int count = stream2.Read(buffer3, 0, buffer3.Length);
            stream.Close();
            stream2.Close();
            return Encoding.UTF8.GetString(buffer3, 0, count);
        }

        public string FromBase64(string base64)
        {
            if (base64 == null)
            {
                throw new ArgumentNullException("base64");
            }
            byte[] buffer = Convert.FromBase64String(base64);
            StringBuilder builder = new StringBuilder();
            foreach (byte num in buffer)
            {
                builder.Append((char) num);
            }
            return builder.ToString();
        }

        public void MAIN()
        {
            this.strChave = "Pas5pr@se";
            this.strChaveValue = "s@1tValue";
            this.hashAlgorithm = "SHA1";
            this.passwordIterations = 2;
            this.strVetorInicial = "@1B2C3D4E5F6G7H8";
            this.keySize = 0x100;
        }

        public string ToBase64(byte[] data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }
            return Convert.ToBase64String(data);
        }
    }
}


﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Lisman
{
    public static class Encrypter
    {
        static String parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        static readonly string PasswordHash = GetHashPassword();
        static readonly string SaltKey = "S@LT&KEY";
        static readonly string VIKey = "@1B2c3D4e5F6g7H8";


        /// <summary>
        /// Decifra textos codificados en el archivo externo
        /// </summary>
        /// <param name="encryptedText">Texto que sera decifrado</param>
        /// <returns>devuelve la cadena decifrada</returns>
        public static string Decrypt(string encryptedText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }

        /// <summary>
        /// Realiza un hash en una cadena de tipo SHA512
        /// </summary>
        /// <param name="originalPassword"> </param>
        /// <returns>devuelve la cadena cifrada </returns>
        public static string EncodePassword(string originalPassword)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(originalPassword);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);               
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }

        }
        public static string GetHashPassword()
        {
            string password;
            using (StreamReader sr = new StreamReader(parentDirectory + "/Resources/HashPassword.txt"))
            {
               password = sr.ReadLine();
            }
            return password;
        }
    }
}

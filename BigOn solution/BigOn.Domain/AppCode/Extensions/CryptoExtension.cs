using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BigOn.Domain.AppCode.Extensions
{
    public  static partial class Extension
    {
        const string saltkey = "code academy";
        public static string ToMd5(this string value)
        {
            byte[] buffer = Encoding.UTF8.GetBytes($"{saltkey}{value}resad");
            // var provider = MD5.Create();
            // byte[] mixedBuffer = provider.ComputeHash(buffer);
            
            var provider = new MD5CryptoServiceProvider();
             var buff = provider.ComputeHash(buffer);
            return string.Join("",buff.Select(b => b.ToString("x2")));
        }

        public static string ToSha1(this string value)
        {
            byte[] buffer = Encoding.UTF8.GetBytes($"{saltkey}{value}1resad");
            var provider = SHA1.Create();
            byte[] mixedBuffer = provider.ComputeHash(buffer);

            return string.Join("", mixedBuffer.Select(b => b.ToString("x2")));
        }
        public static string ToSha256(this string value)
        {
            byte[] buffer = Encoding.UTF8.GetBytes($"{saltkey}{value}resad1");
            var provider = SHA256.Create();
            byte[] mixedBuffer = provider.ComputeHash(buffer);

            return string.Join("", mixedBuffer.Select(b => b.ToString("x2")));
        }
        public static string Encrypt(this string value, string key)
        {

            try
            {
                using (var provider = new TripleDESCryptoServiceProvider())
                using (var md5 = new MD5CryptoServiceProvider())
                {
                    var keyBuffer = md5.ComputeHash(Encoding.UTF8.GetBytes($"#{key}!"));
                    var ivBuffer = md5.ComputeHash(Encoding.UTF8.GetBytes($"@{key}$"));

                    var transform = provider.CreateEncryptor(keyBuffer, ivBuffer);

                    using (var ms = new MemoryStream())
                    using (var cs = new CryptoStream(ms, transform, CryptoStreamMode.Write))
                    {
                        var valueBuffer = Encoding.UTF8.GetBytes(value);

                        cs.Write(valueBuffer, 0, valueBuffer.Length);
                        cs.FlushFinalBlock();

                        ms.Position = 0;
                        var result = new byte[ms.Length];

                        ms.Read(result, 0, result.Length);

                        return Convert.ToBase64String(result);
                    }
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }



        public static string Decrypt(this string value, string key)
        {
            try
            {
                using (var provider = new TripleDESCryptoServiceProvider())
                using (var md5 = new MD5CryptoServiceProvider())
                {
                    var keyBuffer = md5.ComputeHash(Encoding.UTF8.GetBytes($"#{key}!"));
                    var ivBuffer = md5.ComputeHash(Encoding.UTF8.GetBytes($"@{key}$"));

                    var transform = provider.CreateDecryptor(keyBuffer, ivBuffer);

                    using (var ms = new MemoryStream())
                    using (var cs = new CryptoStream(ms, transform, CryptoStreamMode.Write))
                    {
                        var valueBuffer = Convert.FromBase64String(value);

                        cs.Write(valueBuffer, 0, valueBuffer.Length);
                        cs.FlushFinalBlock();

                        ms.Position = 0;
                        var result = new byte[ms.Length];

                        ms.Read(result, 0, result.Length);

                        return Encoding.UTF8.GetString(result);
                    }
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}

using BigOn.Domain.AppCode.Extensions;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigOn.Domain.AppCode.Services
{
    public class CryptoService
    {
        private readonly CryptoServiceOption options;

        public CryptoService(IOptions<CryptoServiceOption> options)
        {
            this.options = options.Value;
        }
        public string Encrypt(string value,bool appliedUrlEncode = false)
        {
            return  value.Encrypt(options.SymmetricKey, appliedUrlEncode);
        }
        public string Decrypt(string value)
        {
            return value.Decrypt( options.SymmetricKey);
        }
    }
    public class CryptoServiceOption
    {
        public string SaltKey { get; set; }
        public string SymmetricKey { get; set; }    

    }
}

using System.Web.Hosting;
using System.Web.Http;
using Fanex.Letstalk.Service.Models;
using RSACryptoPad;

namespace Fanex.Letstalk.Service.Controllers
{
    public class BaseController : ApiController
    {
        private const int KeySize = 1024;

        public static string DecryptProxyCriteria(ProxyCriteria criteria)
        {
            var keyPairPath = HostingEnvironment.ApplicationPhysicalPath + @"App_Data\keypair.snk";

            return Decrypt(criteria.Parameter, keyPairPath);
        }

        public static string Decrypt(string text, string keyPairPath)
        {
            var encryptionThread = new EncryptionThread();
            return encryptionThread.DecryptString(text, KeySize, keyPairPath);
        }
    }
}
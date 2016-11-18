using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using ONEbook.NotificationService;

namespace Fanex.Letstalk.Service.Services
{
    public class LetstalkService : ILetstalkService
    {
        public bool SendMessage(string target, Dictionary<string, string> vars, List<string> attachment, List<string> inlineImages)
        {
            var environmentServers = ConfigurationManager.AppSettings["Environtment-Servers"];
            var environmentAuthKey = ConfigurationManager.AppSettings["Environtment-AuthKey"];

            var serverUrls = environmentServers.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            Notification.Initialize(serverUrls, environmentAuthKey);

            return Notification.Send(target, vars, attachment, inlineImages);
        }

        public void SendMessage(string target, Dictionary<string, string> vars, List<string> attachment, List<string> inlineImages, Notification.SendAsyncResultCallback callBack)
        {
            var environmentServers = ConfigurationManager.AppSettings["Environtment-Servers"];
            var environmentAuthKey = ConfigurationManager.AppSettings["Environtment-AuthKey"];

            var serverUrls = environmentServers.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            Notification.Initialize(serverUrls, environmentAuthKey);

            Notification.SendAsync(target, vars, attachment, inlineImages, callBack);
        }
    }
}
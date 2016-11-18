using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static ONEbook.NotificationService.Notification;

namespace Fanex.Letstalk.Service.Services
{
    public interface ILetstalkService
    {
        bool SendMessage(string target, Dictionary<string, string> vars, List<string> attachment, List<string> inlineImages);
        void SendMessage(string target, Dictionary<string, string> vars, List<string> attachment, List<string> inlineImages, SendAsyncResultCallback callBack );
    }
}
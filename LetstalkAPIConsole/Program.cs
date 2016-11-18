using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Fanex.Letstalk.Service.Core;
using Fanex.Letstalk.Service.Services;
using Newtonsoft.Json;
using ONEbook.NotificationService;
using RSACryptoPad;

namespace LetstalkAPIConsole
{
    class Program
    {
        private const int KeySize = 1024;
        static void Main(string[] args)
        {



            //using (var client = new HttpClient())
            //{
            //    var parameter = "id=54&comment=terry is testing";
            //    var content = new StringContent(parameter, Encoding.UTF8, "application/x-www-form-urlencoded");
            //    HttpResponseMessage response = client.PostAsync("http://deployment-proxy.starific.net/letstalk/api/IMMessage", content).Result;
            //    string result = response.Content.ReadAsStringAsync().Result;

            //    if (response.StatusCode == HttpStatusCode.OK)
            //    {
            //        var getResult = JsonConvert.DeserializeObject<bool>(result);
            //        if (getResult)
            //        {
            //            Console.WriteLine("Messages is sent.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(result);
            //    }

            //    Console.ReadKey();
            //}

            //var redmineIMService = new RedmineIMService(67);

            //var issue = redmineIMService.IssueWithJournals.Issue;

            //return;

            var password = Utilities.Encrypt("chuotnhat");
            Console.WriteLine(password);
            //return;

            //string uri = "http://deployment-proxy.starific.net/letstalk/api/Message";


            //var vars = new Dictionary<string, string>()
            //{
            //    {"no", "1"},
            //    {"title", "title for testing" },
            //    {"status", "status for testing"},
            //    {"systems", "systems for testing"},
            //    {"createdby", "createdby for testing"},
            //    {"assignee", "assignee for testing"},
            //    {"content", "content for testing"}
            //};

            //var param = new MessageModel()
            //{
            //    TargetName = "P1TestingTarget",
            //    Message = vars,
            //    Attachments = null,
            //    InlineImages = null
            //};

            //using (var client = new HttpClient())
            //{
            //    var encryptParam = EncryptParameters(param);
            //    var parameter = "Parameter=" + Uri.EscapeDataString(encryptParam);
            //    var content = new StringContent(parameter, Encoding.UTF8, "application/x-www-form-urlencoded");
            //    HttpResponseMessage response = client.PostAsync(uri, content).Result;
            //    string result = response.Content.ReadAsStringAsync().Result;

            //    if (response.StatusCode == HttpStatusCode.OK)
            //    {
            //        var getResult = JsonConvert.DeserializeObject<bool>(result);
            //        if (getResult)
            //        {
            //            Console.WriteLine("Messages is sent.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(result);
            //    }

            //    Console.ReadKey();
            //}

        }
        private static string EncryptParameters(object data)
        {
            var jsonData = JsonConvert.SerializeObject(data);
            var keyPath = Directory.GetCurrentDirectory() + "/App_Data/public.snk";
            var encryptionThread = new EncryptionThread();
            return encryptionThread.EncryptString(jsonData, KeySize, keyPath);
        }
    }
}

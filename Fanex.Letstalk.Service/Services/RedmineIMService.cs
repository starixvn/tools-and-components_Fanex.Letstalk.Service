using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using Fanex.Letstalk.Service.Models;
using Redmine.Net.Api;
using RestSharp;

namespace Fanex.Letstalk.Service.Services
{
    public class RedmineIMService : BaseService
    {
        private int _issueId;
        public RedmineIMService(int issueId)
        {
            _issueId = issueId;
        }

        public IssueViewModel IssueWithJournals
        {
            get
            {
                var resRequest = new RestRequest(Method.GET);
                resRequest.Resource = string.Format("issues/{0}.json?include=journals", _issueId);
                resRequest.AddHeader("Content-type", "application/json");
                var responeResult = RedmineAPI.Execute<IssueViewModel>(resRequest);

                return responeResult;
            }
        }
    }
}
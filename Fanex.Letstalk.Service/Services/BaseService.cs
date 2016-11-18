using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Fanex.Letstalk.Service.Services
{
    public class BaseService
    {
        private RedmineAPI _redmineAPI;

        public BaseService() : this(null) { }

        public BaseService(RedmineAPI redmineAPI)
        {

            _redmineAPI = redmineAPI ?? new RedmineAPI(AccountSid, SecretKey, RedmineUrl);
        }

        protected RedmineAPI RedmineAPI
        {
            get
            {
                return _redmineAPI;
            }
        }

        public string RedmineUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["Redmine-Url"];
            }
        }

        protected string AccountSid
        {
            get
            {
                return ConfigurationManager.AppSettings["Redmine-Sid"];
            }
        }

        protected string SecretKey
        {
            get
            {
                return ConfigurationManager.AppSettings["Redmine-Key"];
            }
        }
    }
}
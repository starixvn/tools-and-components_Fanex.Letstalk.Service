using System;
using System.Collections.Generic;
using Fanex.Letstalk.Service.Services;
using System.Web.Http;
using System.Text;
using Fanex.Letstalk.Service.Core;
using Fanex.Letstalk.Service.Models;
using System.IO;

namespace Fanex.Letstalk.Service.Controllers
{
    public class IMMessageController : BaseController
    {

        private readonly ILetstalkService _letstalkService;

        public IMMessageController() : this(null) { }

        public IMMessageController(ILetstalkService letstalkService)
        {
            _letstalkService = letstalkService ?? new LetstalkService();
        }

        [HttpGet]
        public void Get(int id, string comment)
        {
            var applicationPath = AppDomain.CurrentDomain.BaseDirectory;
            System.IO.File.WriteAllText(applicationPath + "testing.txt", comment);
        }

        [HttpPost]
        public bool Post([FromBody] LetstalkModel criteria)
        {

            var redmineIMService = new RedmineIMService(criteria.Id);
            var issue = redmineIMService.IssueWithJournals.Issue;
            var redmineUrl = redmineIMService.RedmineUrl;

            try
            {
                var vars = new Dictionary<string, string>();

                vars.Add("no", issue.Id.ToString());
                vars.Add("title", issue.Subject);
                vars.Add("incidentdate", issue.StartDate != null ? issue.StartDate.ToShortDateString() : "N/A");
                vars.Add("status", issue.Status.Name);
                vars.Add("systems", issue.Project.Name);
                vars.Add("createdby", issue.Author.Name);
                vars.Add("assignee", issue.Assignee != null ? issue.Assignee.Name : "N/A");
                vars.Add("content", criteria.Comment);

               return _letstalkService.SendMessage(criteria.TargetName, vars, null, null);
            }
            catch
            {
                return false;
            }
        }
    }
}

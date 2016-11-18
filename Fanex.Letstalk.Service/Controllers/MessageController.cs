using System.Web.Http;
using Fanex.Letstalk.Service.Models;
using Fanex.Letstalk.Service.Services;
using Newtonsoft.Json;

namespace Fanex.Letstalk.Service.Controllers
{
    public class MessageController : BaseController
    {
        private readonly ILetstalkService _letstalkService;

        public MessageController() : this(null) { }

        public MessageController(ILetstalkService letstalkService)
        {
            _letstalkService = letstalkService ?? new LetstalkService();
        }

        // POST api/values
        [HttpPost]
        public bool Post([FromBody]ProxyCriteria criteria)
        {
            var plainParam = DecryptProxyCriteria(criteria);

            var paramCriteria = JsonConvert.DeserializeObject<MessageModel>(plainParam);            
            var result = _letstalkService.SendMessage(paramCriteria.TargetName, paramCriteria.Message, paramCriteria.Attachments, paramCriteria.InlineImages);

            return result;
        }
    }
}

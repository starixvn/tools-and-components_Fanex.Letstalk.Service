using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetstalkAPIConsole
{
    class MessageModel
    {
        public string TargetName { get; set; }

        public Dictionary<string, string> Message { get; set; }

        public List<string> Attachments { get; set; }

        public List<string> InlineImages { get; set; }
    }
}

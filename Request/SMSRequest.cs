using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDIFS.Api.Request
{
    public class SMSMessage : DDIFSBase
    {


        public string from { get; set; }
        /// <summary>
        /// The phone number that initiated the message in E.164 format. For incoming messages, this will be the remote phone. For outgoing messages, this will be one of your Twilio phone numbers.
        /// </summary>
        public List<string> to { get; set; }
        public string text { get; set; }

        public SMSMessage()
        {
            to = new List<string>();
        }
    }
}

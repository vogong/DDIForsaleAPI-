using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDIFS.Api.Response
{
    public class SMSResponse
    {
        public bool status { get; set; }
        public string message { get; set; }
        public string code { get; set; }
    }
}

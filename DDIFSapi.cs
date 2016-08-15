using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDIFS.Api.Response;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions;
using RestSharp.Validation;


namespace DDIFS.Api
{
    public class DDIFSapi
    {
        private const string BASEURL = "https://www.didforsale.com/didforsaleapi/index.php/api/SMS/Send/";
        private RestClient _client;

        public DDIFSapi()
        {
            _client = new RestClient(BASEURL);
        }

        public string Key { get; set; }

        public virtual SMSMessage SendSmsMessage(string from, string to, string body)
        {
            if (string.IsNullOrEmpty(Key) )
                throw new Exception("NoKey");

            Require.Argument("from", from);
            Require.Argument("to", to);
            Require.Argument("body", body);
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.Resource = "/{token}";
            request.AddParameter("token", Key, ParameterType.UrlSegment);
            
            SMSMessage sms = new SMSMessage();
            sms.from = from;
            sms.to.Add(to);
            sms.text = body;
            request.AddJsonBody(sms);
            var uri = _client.BuildUri(request);
            SMSResponse resp = _client.Execute<SMSResponse>(request);
            return response;
        }
    }

}

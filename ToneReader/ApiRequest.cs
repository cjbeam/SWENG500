using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace ToneReader
{
    internal class ApiRequest
    {
        internal string UserName { private get; set; }
        internal string Password { private get; set; }
        internal string ServiceAddress { private get; set; }
        internal string ServiceVersion { private get; set; }
        internal string ContentType { private get; set; }

        internal string MakeRequest(string data)
        {
            using (var wb = new WebClient())
            {
                wb.Credentials = new NetworkCredential(UserName, Password);
                wb.Headers["Content-Type"] = ContentType;
                var queryVariables = new NameValueCollection { ["version"] = ServiceVersion };
                wb.QueryString = queryVariables;
                var text = data;
                var response = wb.UploadData(ServiceAddress, "POST", Encoding.ASCII.GetBytes(text));
                var responseJson = Encoding.ASCII.GetString(response);
                return responseJson;
            }
        }
    }
}

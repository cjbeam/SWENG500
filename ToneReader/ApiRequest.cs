using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace ToneReader
{
    public static class ApiRequest
    {

        public static string MakeRequest(string data)
        {
            using (var wb = new WebClient())
            {
                wb.Credentials = new NetworkCredential(ServiceConfiguration.UserName, ServiceConfiguration.Password);
                wb.Headers["Content-Type"] = ServiceConfiguration.ContentType;
                var queryVariables = new NameValueCollection { ["version"] = ServiceConfiguration.ServiceVersion };
                wb.QueryString = queryVariables;
                var text = data;
                var response = wb.UploadData(ServiceConfiguration.ServiceAddress, "POST", Encoding.ASCII.GetBytes(text));
                var responseJson = Encoding.ASCII.GetString(response);
                return responseJson;
            }
        }
    }
}

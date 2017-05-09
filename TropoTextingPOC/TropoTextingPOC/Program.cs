using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;
using System.Xml;
using TropoCSharp.Tropo;
using TropoCSharp.Structs;

namespace TropoTextingPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            string smsToken = "76494669545746675371426a4776735a6f5864736871694741684b4c5743475972646d5662785a6b7767475a";

            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("sendToNumber", "18034173630");
            parameters.Add("fromNumber", "18043173630");

            string channel = Channel.Text;
            parameters.Add("channel", channel);

            string network = Network.SMS;
            parameters.Add("network", network);

            // Message is sent as a query string parameter, make sure it is properly encoded.
            parameters.Add("msg", HttpUtility.UrlEncode("This is a test message from C#."));

            // Instantiate a new instance of the Tropo object.
            Tropo tropo = new Tropo();

            // Create an XML doc to hold the response from the Tropo Session API.
            XmlDocument doc = new XmlDocument();

            // Set the token to use.
            string token = channel == Channel.Text ? smsToken : "";

            // Load the XML document with the return value of the CreateSession() method call.
            doc.Load(tropo.CreateSession(token, parameters));

            // Display the results in the console.
            Console.WriteLine("Result: " + doc.SelectSingleNode("session/success").InnerText.ToUpper());
            Console.WriteLine("Token: " + doc.SelectSingleNode("session/token").InnerText);
            Console.Read();

        }


    }
}

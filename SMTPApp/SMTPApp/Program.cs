using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SMTPApp
{
    class Program
    {
        public static void SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            bool mailSent = false;
            // Get the unique identifier for this asynchronous operation.
            String token = (string)e.UserState;

            if (e.Cancelled)
            {
                Console.WriteLine("[{0}] Send canceled.", token);
            }
            if (e.Error != null)
            {
                Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
            }
            else
            {
                Console.WriteLine("Message sent.");
            }
            mailSent = true;
        }

        static void Main(string[] args)
        {
            Campaign testGordmansCampaign = new Campaign();
            testGordmansCampaign.Messages.Add("Test", new Message() { From = "me", MessageBody = "lol", MessageSubject = "hahahah" });
            
            using (SmtpClient client = new SmtpClient("haha", 25))
            {
                bool errorResponse = false;
                foreach(var recipient in testGordmansCampaign.Contacts)
                {
                    MailMessage msg = new MailMessage(new MailAddress(testGordmansCampaign.Sender), new MailAddress(recipient));
                    msg.Body = @"";
                    msg.Subject = "Gordmans - New hire(s) who need to screen for State Health Insurance";
                    try
                    {
                        foreach (var att in testGordmansCampaign.Attachments)
                            msg.Attachments.Add(new Attachment(att));
                    }
                    catch (Exception ex)
                    {
                        MailMessage failMessage = new MailMessage(new MailAddress("test@test.com"), new MailAddress("test@test.com"));
                        failMessage.Body = string.Format("{0} campaign failed to send with error: {1}", nameof(testGordmansCampaign), ex.Message);
                        failMessage.Subject = "Mail Campaign Failure";
                        client.Send(failMessage);
                        //terminate job once integrated into jobs platform.
                        errorResponse = true;
                    }
                    
                    if(!errorResponse)
                    {
                        client.SendCompleted += new SendCompletedEventHandler(SendCompleted);
                        client.Send(msg);
                    }        
                }
            }
        }
    }
}

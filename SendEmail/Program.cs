using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using DnsClient;


namespace SendEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.sending to one   
            MailAddress to = new MailAddress("santosh.guruju@icloud.com");
            MailAddress from = new MailAddress("piotr@mailtrap.io");

            MailMessage message = new MailMessage(from, to);
            message.Subject = "Good morning";
            message.Body = "Elizabeth, Harry, There are a few unpaid invoices for the Royal Wedding. Let's talk this over on Monday.;";
            message.CC.Add(new MailAddress("meghan@westminster.co.uk"));
            message.Bcc.Add(new MailAddress("charles@westminster.co.uk"));

            //2. sending with images 
            String imagePath = "bestpictureever.png";
            LinkedResource LinkedImage = new LinkedResource(@imagePath);
            LinkedImage.ContentId = "Wedding";

            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(
              $"{message} <br> <img src=cid:Wedding>", null, "text/html"
            );
            htmlView.LinkedResources.Add(LinkedImage);
            message.AlternateViews.Add(htmlView);

            //3.sending to mulltiple clients 
            SmtpClient client = new SmtpClient("smtp.server.address", 2525)
            {
                Credentials = new NetworkCredential("smtp_username", "smtp_password"),
                EnableSsl = true
            };
            // code in brackets above needed if authentication required   

            try
            {
                client.Send(message);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.ToString());
            }


            //4. Sending without your own smtp/ using DNS client

            LookupClient lookup = new LookupClient();
            IDnsQueryResponse response = lookup.Query("westminster.co.uk", QueryType.MX);


            foreach (DnsClient.Protocol.MxRecord record in response.Answers)
            {
                Console.WriteLine(ObjectDumper.Dump(record.Exchange));

                SmtpClient client = new SmtpClient(record.Exchange, 25);

                try
                {
                    client.Send(message);
                    // if we reached this point, our email was sent and we can break the loop  
                    break;
                }
                catch (SmtpException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}

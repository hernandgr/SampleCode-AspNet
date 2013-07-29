using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SendMailToFolder
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            using (SmtpClient client = new SmtpClient())
            {
                string from = "me@localhost.com";
                string to = "you@remote.com";
                string subject = "Sending to local directory";
                string body = "It works!";

                MailMessage message = new MailMessage(from, to, subject, body);

                client.Send(message);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace Support
{
    public partial class Support : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try{
                SmtpClient mailSender = new SmtpClient("smtp.gmail.com");
                mailSender.Port = 465;
                NetworkCredential c = new NetworkCredential("coldheart042@gmail.com", "T0M4H4WK");
                mailSender.Credentials = c;
                mailSender.EnableSsl = true;
                mailSender.UseDefaultCredentials = false;

                MailAddress to = new MailAddress("coldheart042@yahoo.com");
                MailAddress fr = new MailAddress(txtEmail.Text);
                MailMessage message = new MailMessage(fr,to);
                message.Subject = "Test";
                message.Body = txtQuestion.Text;
                mailSender.DeliveryMethod = SmtpDeliveryMethod.Network;
                mailSender.Send(message);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
            }
        }
    }
}
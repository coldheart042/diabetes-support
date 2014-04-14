using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace Support
{
    public partial class Support : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MailAddress r = new MailAddress("coldheart042@gmail.com");
            MailAddress t = new MailAddress(txtEmail.Text);
            MailMessage mail = new MailMessage(t,r);
            mail.Body = txtQuestion.Text;
            mail.Subject = "Diabetes App Support Question";
            try
            {
                SmtpClient sc = new SmtpClient("192.168.12.0");
                sc.Send(mail);
            }
            catch (HttpException ex)
            {
                lblError.Text = ex.ToString();
            }
        }
    }
}
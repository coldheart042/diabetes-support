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
            MailAddress r = new MailAddress("coldheart042@yahoo.com");
            MailAddress t = new MailAddress(txtEmail.Text);
            MailMessage mail = new MailMessage(t,r);
            mail.Body = "New question from: " + txtEmail.Text + " " + txtQuestion.Text;
            mail.Subject = "Diabetes App Support Question";
            try
            {
                SmtpClient sc = new SmtpClient("smtp.gmail.com");
                sc.UseDefaultCredentials = false;
                System.Net.NetworkCredential c = new System.Net.NetworkCredential("coldheart042@gmail.com", "T0M4H4WK");
                sc.Credentials = c;
                sc.Port = 587;
                sc.EnableSsl = true;
                
                sc.Send(mail);
                txtEmail.Text = "";
                txtQuestion.Text = "";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}
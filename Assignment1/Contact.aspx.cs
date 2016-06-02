using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/*
 * @Author: Alex
 */
namespace Assignment1
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "Contact Me";
        }

        /*
         * The followingcode will run when pressing the send button
         */
        protected void SendButton_Click(object sender, EventArgs e)
        {
            /*Tryed doing something like this 
             * const string fromPassword = "Password";
             * var fromAddress = "Gmail@gmail.com";
             * string body = "From: " + FirstNameTextBox.Text + LastNameTextBox.Text + "\n";
             * body += "Email: " + EmailTextBox.Text + "\n";
             * body += "Phone Number: " + ContactNumberTextBox.Text + "\n";
             * body += "Message: \n" + MessageTextBox.Text + "\n";
             * // smtp settings
             * var smtp = new System.Net.Mail.SmtpClient();
             * {
             * smtp.Host = "smtp.gmail.com";
             * smtp.Port = 587;
             * smtp.EnableSsl = true;
             * smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
             * smtp.Credentials = new NetworkCredential("fromEmail", fromPassword);
             * smtp.Timeout = 20000;
             * }
             * // Passing values to smtp object
             * smtp.Send(fromAddress, "friesen.alex95@gmail.com", subject, body);
             */

        }
    }
}
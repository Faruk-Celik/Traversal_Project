using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequest mail)
        { 
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddress = new MailboxAddress("Admin", "batuhan.devops@gmail.com");
           
            mimeMessage.From.Add(mailboxAddress);
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mail.ReceiverMail); 

            mimeMessage.To.Add(mailboxAddressTo); 

            mimeMessage.Subject=mail.Subject;

            var bodybuilder = new BodyBuilder(); 
            bodybuilder.TextBody=mail.Body; 
            mimeMessage.Body=bodybuilder.ToMessageBody();


            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("batuhan.devops@gmail.com", "o a d g h n q s l c t r r r t p");
            smtpClient.Send(mimeMessage); 
            smtpClient.Disconnect(true);
            return View();
        }
    }
}

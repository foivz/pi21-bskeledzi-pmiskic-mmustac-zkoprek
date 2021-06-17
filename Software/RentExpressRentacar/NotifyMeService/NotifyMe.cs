using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Tulpep.NotificationWindow;
using projekt;
using System.Windows.Forms;
using NUnit.Framework;
using System.Windows.Shell;
using System.Windows;
using System.Net.Mail;
using System.Net;

namespace NotifyMeService
{
    public class NotifyMe
    {
        private readonly CarRentalEntities _db;
        private readonly System.Timers.Timer _timer;
       
        public NotifyMe()
        {
            _db = new CarRentalEntities();
            _timer = new System.Timers.Timer(86400000) { AutoReset = true };
            _timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            NotifiyUser();

        }

        private void NotifiyUser()
        {
            var query = _db.Rezervacijas.ToList();
            foreach (var q in query)
            {
                DateTime dateOfTaking = (DateTime)q.datum_preuzimanja;
                DateTime dateOfCreation = (DateTime)q.createdAt;
                var dateDifference = (dateOfTaking - dateOfCreation).TotalDays;
                if(dateDifference <= 1)
                {
      
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    message.From = new MailAddress("RentExpressDoo@gmail.com");
                    message.To.Add(new MailAddress(q.email));
                    message.Subject = "Obavijest o Vasoj rezervaciji!";
                    message.Body = "Pozdrav postovani. Zelimo Vas obavijestiti da sutra preuzimate auto koje ste rezervirali.";
                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com"; 
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("RentExpressDoo@gmail.com", "rentexpress123");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                }

            }
        }
        public void Start()
        {
            _timer.Start();
        }
        public void Stop()
        {
            _timer.Stop();
        }
    }
}

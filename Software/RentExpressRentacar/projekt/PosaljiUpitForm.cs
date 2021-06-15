using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace projekt
{
    public partial class PosaljiUpitForm : Form
    {
        private readonly CarRentalEntities _db;

        public PosaljiUpitForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void posaljiButton_Click(object sender, EventArgs e)
        {
          

            using (var context = new CarRentalEntities())
            {
                Upiti noviUpit = new Upiti
                {
                    predmet = predmetTextBox.Text,
                    opis = opisRichTextBox.Text,
                    email = emailTextBox.Text
                    
                };

                context.Upitis.Add(noviUpit);
                context.SaveChanges();
            }

            
            string predmet = predmetTextBox.Text;
            string opis = opisRichTextBox.Text;
            string email = emailTextBox.Text;

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 20, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Potvrda uspješne transakcije.pdf", FileMode.Create));

            string imagepath1 = "Logo.jpeg";

            iTextSharp.text.Image jpeg = iTextSharp.text.Image.GetInstance(imagepath1);
            jpeg.SetAbsolutePosition(20, 690);
            jpeg.ScaleToFit(1200f, 80f);

            Paragraph paragraph1 = new Paragraph($"\n \n \n");

            Paragraph paragraph = new Paragraph($"\n" +
                $"      RentExpress d.o.o \n" +
                $"      Ul. Julija Merlica 9 \n" +
                $"      42000 Varazdin, Hrvatska \n" +
                $"      E-mail: info@rentexpress.hr \n" +
                $"      OIB: 38282458495 \n \n" +
                $"      PODACI O KUPCU: \n" +
                $"      Ime: {email} \n" +
                $"      Predmet: {predmet}\n \n" +
                $"      Opis: {opis}\n \n" +
                $"");

            doc.Open();
            doc.Add(paragraph1);
            doc.Add(paragraph);
            doc.Add(jpeg);
            doc.Close();

            MailMessage mail = new MailMessage("RentExpressDoo@gmail.com", emailTextBox.Text, "Novi Upit", "Upit");
            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("Potvrda uspješne transakcije.pdf");
            mail.Attachments.Add(attachment);
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("RentExpressDoo@gmail.com", "rentexpress123");
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Mail je uspješno poslan!", "Uspjeh!", MessageBoxButtons.OK);
            Close();
        }   
    }
}

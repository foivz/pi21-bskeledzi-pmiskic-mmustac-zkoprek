using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projekt.Klase;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Net.Mail;
using System.Web;

namespace projekt
{
    public partial class PodatciOKupcuForm : Form
    {
        private Kupac kupac;
        private readonly CarRentalEntities _db;
        public PodatciOKupcuForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void zavrsiRezervacijuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PodatciOKupcuForm_Load(object sender, EventArgs e)
        {

        }

        private void mailButton_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 20, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Create));
            doc.Open();
            Paragraph paragraph = new Paragraph("Podaci o plaćanju: ____");
            doc.Add(paragraph);
            doc.Close();

            MailMessage mail = new MailMessage("RentExpressDoo@gmail.com", txtEmail.Text, "Potvrda plaćanja", "Potvrda plaćanja nalazi se u privitku. Hvala Vam što ste poslovali s nama!");
            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("Test.pdf");
            mail.Attachments.Add(attachment);
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("RentExpressDoo@gmail.com", "rentexpress123");
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Mail je uspješno poslan!", "Uspjeh!", MessageBoxButtons.OK);
        }
    }
}

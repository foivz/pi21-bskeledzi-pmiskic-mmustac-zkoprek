using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace projekt
{
    public partial class OdgovoriUpitForm : Form
    {
        Upiti _upit;
        public OdgovoriUpitForm(Upiti upit)
        {
            InitializeComponent();
            _upit = upit;
        }

        private void OdgovoriUpitForm_Load(object sender, EventArgs e)
        {
            tbPredmet.Text = _upit.predmet;
            tbEmail.Text = _upit.email;
            rtbOpis.Text = _upit.opis;
            
            

        }

        private void PosaljiMail(string email, string odgovor, string predmet)
        {

            MailMessage mail = new MailMessage();
            mail.To.Add(email);
            mail.From = new MailAddress("RentExpressDoo@gmail.com");
            mail.Body = odgovor;
            mail.Subject = predmet;
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("RentExpressDoo@gmail.com", "rentexpress123");
            client.EnableSsl = true;
            
            

            
           
            try
            {
                client.Send(mail);
                MessageBox.Show("Poslano.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            
            var email = tbEmail.Text.ToString();
            var odgovor = rtbOdgovor.Text.ToString();
            var predmet = tbPredmet.Text;
            PosaljiMail(email, odgovor, predmet);
            Close();
        }
    }
}

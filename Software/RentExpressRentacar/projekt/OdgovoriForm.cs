using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace projekt
{
    public partial class OdgovoriForm : Form
    {
        Upiti _upit;
        public OdgovoriForm(Upiti upit)
        {
            InitializeComponent();
            _upit = upit;
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

        private void OdgovoriForm_Load_1(object sender, EventArgs e)
        {
            txtPredmet.Text = _upit.predmet;
            txtEmail.Text = _upit.email;
            rtbOpis.Text = _upit.opis;
        }

        private void btnOdgovori_Click_1(object sender, EventArgs e)
        {
            var email = txtEmail.Text.ToString();
            var odgovor = rtbOdgovor.Text.ToString();
            var predmet = txtPredmet.Text;
            PosaljiMail(email, odgovor, predmet);
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Net.Mail;
using System.Web;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.Drawing.Imaging;

namespace projekt
{
    public partial class PodatciOKupcuForm : Form
    {
        private readonly CarRentalEntities _db;
        private Automobil automobil { get; set; }
        private bool Ka { get; set; }
        private string kartica { get; set; }
        private Lokacija lokacija { get; set; }
        private string datum1 { get; set; }
        private string datum2 { get; set; }
        private string cijena { get; set; }

        public PodatciOKupcuForm(Automobil auto, Lokacija lok, bool k, string d1, string d2)
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            automobil = auto;
            lokacija = lok;
            Ka = k;
            datum1 = d1;
            datum2 = d2;
            imeTextBox.Text = datum1;
            prezimeTextBox.Text = datum2;
            /*string[] datumP = d1.Split('.');
            string[] datumV = d2.Split('.');
            string[] datumPr = datumP[0].Split('.');
            string[] datumVr = datumV[0].Split('.');
            double prviDatum = double.Parse(datumPr[0]);
            double drugiDatum = double.Parse(datumVr[0]);

            string[] mjesec = datumV[1].Split(' ');
            string m = mjesec[1];

            int i = 0;
            double dana = 0;

            if (drugiDatum < prviDatum)
            {
                 switch (m)
                 {
                    case "siječnja":
                        {
                            i = 31;
                            break;
                        }
                    case "veljače":
                        {
                            i = 28;
                            break;
                        }
                    case "ožujka":
                        {
                            i = 31;
                            break;
                        }
                    case "travnja":
                        {
                            i = 30;
                            break;
                        }
                    case "svibnja":
                        {
                            i = 31;
                            break;
                        }
                    case "lipnja":
                        {
                            i = 30;
                            break;
                        }
                    case "srpnja":
                        {
                            i = 31;
                            break;
                        }
                    case "kolovoza":
                        {
                            i = 31;
                            break;
                        }
                    case "rujna":
                        {
                            i = 30;
                            break;
                        }
                    case "listopada":
                        {
                            i = 31;
                            break;
                        }
                    case "studenog":
                        {
                            i = 30;
                            break;
                        }
                    case "prosinca":
                        {
                            i = 31;
                            break;
                        }
                    default: break;
                 }

                 dana = i - prviDatum;
                 dana += drugiDatum;
                
            }
            else
            {
                dana = drugiDatum - prviDatum;
            }
           
            double? cijenaAutomobila = auto.cijena;
            cijena = (cijenaAutomobila * dana).ToString();
            txtCijena.Text = cijena += " HRK";*/
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JeLiKartica()
        {
            if (Ka == true) kartica = "kartica";
            if (Ka == false)
            {
                cvvTextBox.Enabled = false;
                datumIstekaTextBox.Enabled = false;
                brojKarticeTextBox.Enabled = false;
                kartica = "gotovina";
            } 
        }

       

        private void zavrsiRezervacijuButton_Click(object sender, EventArgs e)
        {
            if (vozackaDozvolaTextBox.Text == "" || txtEmail.Text == "" || brojKarticeTextBox.Text == "" || cvvTextBox.Text == "" || datumIstekaTextBox.Text == "" || prezimeTextBox.Text == "" || imeTextBox.Text == "" || oibTextBox.Text == "")
            {
                SviPodaci.Visible = true;
                return;
            }

            JeLiKartica();

            string ime = imeTextBox.Text;
            string prezime = prezimeTextBox.Text;

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 20, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Potvrda uspješne transakcije.pdf", FileMode.Create));
            
            string imagepath1 = "Logo.jpeg";
            string imagepath2 = "qrcode.jpg";

            iTextSharp.text.Image jpeg = iTextSharp.text.Image.GetInstance(imagepath1);
            jpeg.SetAbsolutePosition(20, 690);
            jpeg.ScaleToFit(1200f, 80f);

            iTextSharp.text.Image qrcode = iTextSharp.text.Image.GetInstance(imagepath2);
            qrcode.SetAbsolutePosition(525, 705);
            qrcode.ScaleToFit(100f, 70f);

            Paragraph paragraph1 = new Paragraph($"\n \n \n");
            
            Paragraph paragraph = new Paragraph($"\n" +
                $"      RentExpress d.o.o \n" +
                $"      Ul. Julija Merlica 9 \n" +
                $"      42000 Varazdin, Hrvatska \n" +               
                $"      E-mail: info@rentexpress.hr \n" +
                $"      OIB: 38282458495 \n \n" +
                $"      PODACI O KUPCU: \n" +
                $"      Ime: {ime} \n" +
                $"      Prezime: {prezime}\n \n" +
                $"      PODACI IZNAJMLJENOM AUTOMOBILU: \n" +
                $"      Odabrani automobil: {automobil.marka}\n" +
                $"      Model automobila: {automobil.model}\n" +
                $"      Boja automobila: {automobil.boja}\n" +
                $"      Godina proizvodnje: {automobil.godina_prozivodnje}\n" +
                $"      Prijedeni kilometri: {automobil.kilometraza}\n\n" +
                $"      PODACI O PREUZIMANJU:\n" +
                $"      Lokacija preuzimanja: {lokacija.adresa}\n" +
                $"      Datum preuzimanja: {datum1}\n" +
                $"      Datum vracanja: {datum2}\n" +              
                $"      Nacin placanja: {kartica}\n\n" +
                $"      UKUPNA CIJENA: {cijena} \n\n\n" +
                $"      " +
                $"      Hvala Vam i uzivajte u voznji!" +             
                $"");

            doc.Open();
            doc.Add(paragraph1);
            doc.Add(paragraph);
            doc.Add(jpeg);
            doc.Add(qrcode);
            doc.Close();

            MailMessage mail = new MailMessage("RentExpressDoo@gmail.com", txtEmail.Text, "Potvrda plaćanja", "Potvrda plaćanja nalazi se u privitku. Hvala Vam što ste poslovali s nama!");
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

            Upiti upit = new Upiti();
            upit.email = txtEmail.Text;
            upit.predmet = "Rezervacija";
            upit.opis = automobil.marka + automobil.model;

            using (var context = new CarRentalEntities())
            {
                Upiti noviUpit = new Upiti
                {
                    predmet = "Rezervacija",
                    opis = automobil.marka + " " + automobil.model,
                    email = txtEmail.Text,
                    idPoduzeca = automobil.idPoduzeca
                };

                context.Upitis.Add(noviUpit);
                context.SaveChanges();
            }
        }

        private void PodatciOKupcuForm_Load(object sender, EventArgs e)
        {
            JeLiKartica();
        }

        private void imeTextBox_TextChanged(object sender, EventArgs e)
        {
            SviPodaci.Visible = false;           
        }


    }
}

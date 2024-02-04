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


//https://www.youtube.com/@kadiratmaca1
namespace eposta_gönderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bu kısma Gönderici Epostası ve şifresini giriyoruz doğru şekilde uyarı outlook eposta olmalı
            string GöndericiEposta = "outlook hesabı örnek gönderici@outlook.com ";
            string GöndericiEpostaSifre = "outlook hesabının şifresi ";
            //Bu kısmafa göndermek istediyimiz epostayı giriyoruz burada farketmez istediyinizi girin 
            string AlıcıEposta = "alıcının eposta adresi örnek alıcı@gmail.com";


            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(GöndericiEposta);
            mail.To.Add(AlıcıEposta);



            mail.Subject = Konu.Text;  // burası epostanın konusudur
            mail.Body = altBaslik.Text; // burası epostanın açıklamasıdır 
            //Burada Resim zip rar v.b şeyler gönderebilirsiniz burad aynı kodla birden fazlada dosya gönderbilirsiniz.
            mail.Attachments.Add(new Attachment("1.jpg"));
           // mail.Attachments.Add(new Attachment("2.zip"));



            SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com",587);
            smtp.Credentials = new System.Net.NetworkCredential(GöndericiEposta, GöndericiEpostaSifre);
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}

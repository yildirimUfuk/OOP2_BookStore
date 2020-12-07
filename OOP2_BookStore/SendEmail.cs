using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
namespace OOP2_BookStore
{
	class SendEmail
	{
		
		private static SendEmail sendEmail;

		/// <summary>
		/// contructor
		/// </summary>
		private SendEmail() { }
		/// <summary>
		/// it creates new item if item is null
		/// </summary>
		/// <returns> sendEmail </returns>
		public static SendEmail CreateSendEmail()
		{
			if (sendEmail == null)
			{
				sendEmail = new SendEmail();
			}
			return sendEmail;
		}	

		/// <summary>
		/// it sends email to given mail with given text and title
		/// </summary>
		/// <param name="kime"> to email </param>
		/// <param name="baslik"> title of new email </param>
		/// <param name="icerik"> the body of new email </param>
		public void sendmail(String kime, string baslik, string icerik)
		{
			SmtpClient sc = new SmtpClient();
			sc.Port = 587;//------------
			sc.Host = "smtp.gmail.com";//gonderen tipi
			sc.EnableSsl = true;//internet adreslerini https oldugunu soyler guvenlı ınternet protokolu
			sc.Credentials = new NetworkCredential("mailGondermeDeneme3326@gmail.com", "abuzer123");//hesaba gırıs adres ve sıfre(-------------@gmail.com)deneme amaclı acıldı
			MailMessage mesaj = new MailMessage();
			mesaj.From = new MailAddress("dc46asd46cafdz@gmail.com");
			mesaj.To.Add(kime);
			mesaj.Subject = baslik;
			mesaj.IsBodyHtml = true;
			mesaj.Body = icerik;
			sc.Send(mesaj);//gonderme
		}
	}
}
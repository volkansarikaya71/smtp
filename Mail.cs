using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BiletOtamasyonu
{
    internal class Mail
    {
        public static void epostagonder(string Msj_Atilacak_kullanici_Eposta_Adresi,int Securitykod)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("vsdeneme71@gmail.com", "ejhh jtis uklo jbqi");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            mesaj.To.Add(Msj_Atilacak_kullanici_Eposta_Adresi);
            mesaj.From = new MailAddress("vsdeneme71@gmail.com");
            mesaj.Subject = "SecurityCode";
            mesaj.Body = Securitykod.ToString();
            istemci.Send(mesaj);
        }
    }
}

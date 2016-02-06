using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EnviaMail
{
    public class EnviarMail
    {
        MailMessage correos = new MailMessage();
        SmtpClient envios = new SmtpClient();

        public bool enviarCorreo(string mensaje, string asunto, string destinatario, string ruta)
        {
            bool estado = false;
            try
            {
                correos.To.Clear();
                correos.Body = "";
                correos.Subject = "";
                correos.Body = mensaje;
                correos.Subject = asunto;
                correos.IsBodyHtml = true;
                correos.To.Add(destinatario.Trim());

                if (ruta.Equals("") == false)
                {
                    System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(ruta);
                    correos.Attachments.Add(archivo);
                }

                string emisor = "codeEnterprise30@gmail.com";
                string password = "jfnando30";
                correos.From = new MailAddress(emisor);
                envios.Credentials = new NetworkCredential(emisor, password);

                //Datos importantes no modificables para tener acceso a las cuentas

                envios.Host = "smtp.gmail.com";
                envios.Port = 587;
                envios.EnableSsl = true;

                envios.Send(correos);
                Console.WriteLine("Mensaje enviado");
                estado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("mensaje no enviado");
                estado = false;
            }
            return estado;
        }
    }
   
}

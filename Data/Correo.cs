using MailKit.Net.Smtp;
using MimeKit;
using Proyectov1.Models;
using System;

namespace Proyectov1.Data
{
    public static class Correo
    {
        public static void EmailSend(String action, Persona persona)
        {
            try
            {
                string origen = "abraham.011297@gmail.com";
                string pass = "011297japc";

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("MyGymSupport", "mygym@support.com"));
                message.To.Add(new MailboxAddress("User: " + persona.Usu.UsuName, persona.Usu.UsuCorr));
                message.Subject = "MyGYM - Alerta de Accion: " + action;
                message.Body = new TextPart("html")
                {
                    Text = "<h1>Alerta de acci&oacute;n</h1><div><p>Se llevo acabo la siguente acci&oacute;n: " + action +
                    "</p><hr /><p>Usuario: " + persona.Usu.UsuName + "</p><p>Password: " + persona.Usu.UsuPass + "<hr/> </p></div>"
                };

                SmtpClient client = new SmtpClient();
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate(origen, pass);
                client.Send(message);
                client.Disconnect(true);
            }
            catch(Exception)
            {

            }
        }
    }
}

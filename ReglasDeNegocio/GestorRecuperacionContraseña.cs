using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatosBD;
using System.Threading;

namespace ReglasDeNegocio
{
    public class GestorRecuperacionContraseña
    {

        public string GenerarToken(string correo)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var token = new string(
                Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)])
                .ToArray());
            DatosUsuarios du = new DatosUsuarios();
            du.GuardarToken(correo, token);
            return EnviarCorreo(correo, token);
        }

        private string EnviarCorreo(string correo, string token)
        {
            string salida = "";
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add(correo);
            msg.Subject = "Notificaciones XMusic";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = $"Código: {token}";
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = false;
            msg.From = new System.Net.Mail.MailAddress("dpiedrahita@ulasallista.edu.co");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("dpiedrahita@ulasallista.edu.co", "Edison2020*");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.office365.com";

            try
            {
                salida = "Se envió un código al correo electrónico";
                cliente.Send(msg);
            }
            catch (Exception)
            {
                salida = "Error al enviar código al correo electrónico";
            }

            return salida;
        }

        public void RecuperarContraseña(string correo, string contraseña, string token)
        {
            GestorEncriptacionUsuarios ge = new GestorEncriptacionUsuarios();
            string contraseñaEncriptada = ge.Encriptar(contraseña);
            DatosUsuarios du = new DatosUsuarios();
            du.RecuperarContraseña(correo, contraseñaEncriptada, token);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasDeNegocio
{
    class GestorEncriptacionUsuarios
    {
        public string Encriptar(string cadenaAEncriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaAEncriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        public string DesEncriptar(string cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaAdesencriptar);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
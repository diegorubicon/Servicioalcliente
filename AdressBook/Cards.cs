using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdressBook
{
    public class Cards
    {
        public string MakevCard(Personas.Persona p)
        {
            StringBuilder vcard = new StringBuilder();

            vcard.Append("BEGIN:VCARD" + Environment.NewLine);
            vcard.Append("VERSION:2.1" + Environment.NewLine);
            vcard.Append("N:" + p.PrimerApellido.Trim() + " " + p.SegundoApellido.Trim() + " (" + p.Direccion.Provincia.Nombre + ");" + p.Nombre.Trim() + Environment.NewLine);
            vcard.Append("FN:" + p.NombreCompleto + " (" + p.Direccion.Provincia.Nombre + ")" + Environment.NewLine);
            if (p.Telefono01.Trim() != "" && p.Telefono01.Trim() != "0000000")
            {
                vcard.Append("TEL;TYPE=HOME:" + p.Telefono01 + Environment.NewLine);
            }
            if (p.Telefono02.Trim() != "" && p.Telefono02.Trim() != "0000000")
            {
                vcard.Append("TEL;TYPE=CELL:506" + p.Telefono02.Trim() + Environment.NewLine);
            }
            if (p.Telefono03.Trim() != "" && p.Telefono03.Trim() != "0000000")
            {
                vcard.Append("TEL;TYPE=WORK:" + p.Telefono03 + Environment.NewLine);
            }
            if (p.Email.Trim() != "")
            {
                vcard.Append("EMAIL;TYPE=INTERNET:" + p.Email + Environment.NewLine);
            }
            vcard.Append("ADR:" + p.Direccion.Provincia.Nombre + Environment.NewLine);
            vcard.Append("ORG:" + p.Direccion.Provincia.Nombre + Environment.NewLine);
            vcard.Append("NOTE:Sakif" + Environment.NewLine);
            vcard.Append("END:VCARD" + Environment.NewLine);


            return vcard.ToString();
        }
        public string CSV(Personas.Persona p)
        {
            StringBuilder csv = new StringBuilder();
            string empty = "";
            string s = "\"";
            csv.Append("\"Título\";\"Nombre\";\"Segundo nombre\";\"Apellido\";\"Sufijo\";\"Cargo\";\"Compañía\";\"Cumpleaños\";\"Dirección SIP\";\"Push-to-talk\";\"Compartir vista\";\"ID de usuario\";\"Notas\";\"Móvil general\";\"Teléfono general\";\"Correo general\";\"Fax general\";\"Llamada de video general\";\"Dirección Web general\";\"Dirección VOIP general\";\"Apartado de correo general\";\"Extensión general\";\"Calle general\";\"Código postal general\";\"Ciudad general\";\"Estado/provincia general\";\"País/región general\";\"Móvil particular\";\"Fijo particular\";\"Correo particular\";\"Fax particular\";\"Llamada de video particular\";\"Dirección Web particular\";\"Dirección VOIP particular\";\"Apartado postal particular\";\"Extensión particular\";\"Calle del domicilio\";\"Código postal particular\";\"Ciudad del domicilio\";\"Estado/provincia del domicilio\";\"País/región del domicilio\";\"Móvil trabajo\";\"Fijo trabajo\";\"Correo trabajo\";\"Fax del trabajo\";\"Llamada de video del trabajo\";\"Dirección Web del trabajo\";\"Dirección VOIP del trabajo\";\"Apartado postal del trabajo\";\"Extensión del trabajo\";\"Calle del trabajo\";\"Código postal del trabajo\";\"Ciudad del trabajo\";\"Estado/provincia del trabajo\";\"País/región del trabajo\";\"\"");

            csv.Replace("Título", empty);
            csv.Replace("Segundo nombre", empty);
            csv.Replace("Nombre", p.Nombre.Trim());
            csv.Replace("Apellido", p.PrimerApellido.Trim() + " " + p.SegundoApellido.Trim() + " (" + p.Direccion.Provincia.Nombre + ")");
            csv.Replace("Sufijo", empty);
            csv.Replace("Cargo", empty);
            csv.Replace("Compañía", p.Direccion.Provincia.Nombre);
            csv.Replace("Cumpleaños", empty);
            csv.Replace("Dirección SIP", empty);
            csv.Replace("Push-to-talk", empty);
            csv.Replace("Compartir vista", empty);
            csv.Replace("ID de usuario", empty);
            csv.Replace("Notas", "Sakif");

            if (p.Telefono02.Trim() != "" && p.Telefono02.Trim() != "0000000")
                csv.Replace("Móvil general", p.Telefono02.Trim());
            else
                csv.Replace("Móvil general", empty);

            if (p.Telefono01.Trim() != "" && p.Telefono01.Trim() != "0000000")
            {
                csv.Replace("Teléfono general", p.Telefono01.Trim());
            }
            else
            {
                csv.Replace("Teléfono general", empty);
            }

            csv.Replace("Correo general", p.Email);
            csv.Replace("Fax general", p.Fax);
            csv.Replace("Llamada de video general", empty);
            csv.Replace("Dirección Web general", empty);
            csv.Replace("Dirección VOIP general", empty);
            csv.Replace("Apartado de correo general", empty);
            csv.Replace("Extensión general", empty);
            csv.Replace("Calle general", empty);
            csv.Replace("Código postal general", empty);
            csv.Replace("Ciudad general", empty);
            csv.Replace("Estado/provincia general", p.Direccion.Provincia.Nombre);
            csv.Replace("País/región general", empty);

            csv.Replace("Móvil particular", empty);
            csv.Replace("Fijo particular", empty);
            csv.Replace("Correo particular", empty);
            csv.Replace("Fax particular", empty);
            csv.Replace("Llamada de video particular", empty);
            csv.Replace("Dirección Web particular", empty);
            csv.Replace("Dirección VOIP particular", empty);
            csv.Replace("Apartado postal particular", empty);
            csv.Replace("Extensión particular", empty);
            csv.Replace("Calle del domicilio", empty);
            csv.Replace("Código postal particular", empty);
            csv.Replace("Ciudad del domicilio", empty);
            csv.Replace("Estado/provincia del domicilio", empty);
            csv.Replace("País/región del domicilio", empty);

            csv.Replace("Móvil trabajo", empty);
            if (p.Telefono03.Trim() != "" && p.Telefono03.Trim() != "0000000")
            {
                csv.Replace("Fijo trabajo", p.Telefono03.Trim());
            }
            else
            {
                csv.Replace("Fijo trabajo", empty);
            }
            csv.Replace("Correo trabajo", empty);
            csv.Replace("Fax del trabajo", empty);
            csv.Replace("Llamada de video del trabajo", empty);
            csv.Replace("Dirección Web del trabajo", empty);
            csv.Replace("Dirección VOIP del trabajo", empty);
            csv.Replace("Apartado postal del trabajo", empty);
            csv.Replace("Extensión del trabajo", empty);
            csv.Replace("Calle del trabajo", empty);
            csv.Replace("Código postal del trabajo", empty);
            csv.Replace("Ciudad del trabajo", empty);
            csv.Replace("Estado/provincia del trabajo", empty);
            csv.Replace("País/región del trabajo", empty);


            return csv.ToString();

        }
    }
}

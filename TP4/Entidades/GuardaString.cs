using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
   public static class GuardaString
    {
       public static bool Guardar(this String texto, string archivo)
       {

           try
           {
               using (StreamWriter sw = new StreamWriter(texto, true))
               {
                   sw.WriteLine(archivo);
                   sw.Close();
               }
           }
           catch (Exception e)
           {
               Console.WriteLine(e.Message);
           }

           return false;



       }
    }
}

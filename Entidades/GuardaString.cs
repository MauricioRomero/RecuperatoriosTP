using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
   static class GuardaString
    {
       public static bool Guardar(this string texto, string archivo)
       {

           try
           {
               using (StreamWriter sw = new StreamWriter("System.Environment.SpecialFolder.DesktopDirectory", true))
               {
                   sw.WriteLine(archivo);

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2018
{
    public class Leche : Producto
    {
        public enum ETipo { Entera, Descremada }
        ETipo tipo;




        public Leche(EMarca marca, string codigoDeBarra, ConsoleColor color)
            : base(codigoDeBarra, marca, color)
        {
            this.tipo = ETipo.Entera;
        }


        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigoDeBarra"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codigoDeBarra , ConsoleColor color, ETipo tipo)
            : base(codigoDeBarra, marca, color)
        {
            this.tipo = tipo;
        }
        


        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine((string)this);
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}

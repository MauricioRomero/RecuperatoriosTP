using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Entidades
{
  public  class Correo : IMostrar<List<Paquete>>
    {
        #region Atributos
        protected List<Thread> mockPaquetes;
        protected List<Paquete> paquetes;

        #endregion

        #region properties

        public List<Paquete> Paquetes { get { return this.paquetes; } set { this.paquetes = value; } }
        #endregion

        #region Metodos

        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();

        }

        public void FinEntregas()
        {
            foreach (Thread item in this.mockPaquetes)
            {
                if (item.IsAlive)
                {

                    item.Abort();
                }
            }
        }

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Paquete p in this.Paquetes)
            {
                sb.AppendLine(string.Format("{0} para {1} ({2})", p.TracingID, p.DireccionEntrega, p.Estado.ToString()));
            }
            return sb.ToString();

        }

        public static Correo operator +(Correo c, Paquete p)
        {
            
            foreach (Paquete item in c.paquetes)
            {
                
                if (!p.Equals(null) && !object.Equals(item,null))
                {
                    if (p == item)
                    {
                        throw new TrackingIDRepetidoException("Paquete repetido!!");
                    }
                    else
                    {
                        c.Paquetes.Add(p);

                        Thread t = new Thread(new ThreadStart(p.MockCicloDeVida));
                        c.mockPaquetes.Add(t);
                        t.Start();
                    }

                }
                
            }
            if (c.Paquetes.Count == 0 && !p.Equals(null))
            {
                c.Paquetes.Add(p);
                Thread t = new Thread(new ThreadStart(p.MockCicloDeVida));
                c.mockPaquetes.Add(t);
                t.Start();
             
            }
            return c;
        }
        #endregion
    }
}

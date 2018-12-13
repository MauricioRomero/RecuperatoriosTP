using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
     public class Paquete : IMostrar<Paquete>
        {
            private string direccionEntrega;
            private EEstado estado;
            private string trackingID;

            #region Props

            public string DireccionEntrega
            {
                get { return this.direccionEntrega; }
                set { direccionEntrega = value; }
            }

            public EEstado Estado
            {
                get { return this.estado; }
                set { estado = value; }
            }

            public string TracingID
            {
                get { return this.trackingID; }
                set { this.trackingID = value; }
            }




            #endregion


            #region Methods

            public void MockCicloDeVida()
            {
                Thread.Sleep(10000);
                if (this.Estado == EEstado.Entregado)
                {
                    this.Estado = EEstado.Entregado;
                    InformaEstado(this.estado, EventArgs.Empty);
                }
                if (this.Estado == EEstado.EnViaje)
                {
                    InformaEstado(this.estado, EventArgs.Empty);
                    this.Estado = EEstado.EnViaje;
                }
                if (this.Estado == EEstado.Ingresado)
                {
                    InformaEstado(this.estado,EventArgs.Empty);
                    this.Estado = EEstado.Ingresado;
                }
                try
                {
                    PaqueteDAO.Insertar(this);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }

            #region evento
            public delegate void DelegadoEstado(object o,EventArgs e);
            public event DelegadoEstado InformaEstado;
            #endregion

            public string MostrarDatos(IMostrar<Paquete> elemento)
            {
                //elemento.MostrarDatos("");
                //return this.MostrarDatos(elemento);
                return string.Format("{0} para {1}", this.trackingID, this.direccionEntrega);
            }

            public static bool operator ==(Paquete p1, Paquete p2)
            {
                if (!object.ReferenceEquals(p1, null) && !object.ReferenceEquals(p2, null))
                {

                    if (p1.TracingID == p2.TracingID)
                    {
                        return true;
                    }
                }
                return false;
            }


            public static bool operator !=(Paquete p1, Paquete p2)
            {
                return !(p1 == p2);
            }


            public Paquete(string direccionEntrega, string trakingID)
            {
                this.TracingID = trakingID;
                this.DireccionEntrega = direccionEntrega;

            }

            public override string ToString()
            {
                return String.Format("{0} para {1}", this.TracingID, this.DireccionEntrega);
            }
            #endregion


        }
        public enum EEstado
        { Ingresado, EnViaje, Entregado }
    }


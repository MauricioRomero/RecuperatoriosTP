using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MainCorreo
{
    public partial class Form1 : Form
    {
        Correo correo = new Correo();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void labelPaquete_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paquete p = new Paquete(this.textBoxDireccion.Text, this.textBoxTRackingID.Text);
            p.InformaEstado += this.paq_InformaEstado;

            try
            {
                this.correo = this.correo + p;
            }
            catch (TrackingIDRepetidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void paq_InformaEstado(object sender, EventArgs e)
        { 
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado); 
                this.Invoke( d, new object[] {sender, e} ); 
            } else
            {
                this.ActualizarEstados();
            }
        
        }

        
        private void ActualizarEstados()
        {
            this.listBox1Ingresado.Items.Clear();
            this.listBox2Enviaje.Items.Clear();
            this.listBox3Entregado.Items.Clear();
            
            foreach (Paquete item in correo.Paquetes)
	        {
		        switch (item.Estado)
                {
                    case EEstado.Ingresado:
                        this.listBox1Ingresado.Items.Add(item);
                        this.listBox1Ingresado.Show();
                        break;
                    case EEstado.EnViaje:
                        this.listBox2Enviaje.Items.Add(item);
                        this.listBox2Enviaje.Show();
                        break;
                    case EEstado.Entregado:
                        this.listBox3Entregado.Items.Add(item);
                        this.listBox3Entregado.Show();
                        break;
                    default:
                        break;
                }
	        }
            
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo); 
        }

        private void MostrarInformacion<T> (IMostrar<T> elemento)
        {
            if (!object.Equals(elemento,null))
            {
                this.richTextBox1.AppendText(elemento.ToString());
                bool r = GuardaString.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"salida.txt", elemento.ToString());
            }
        }

        private void listBox1Ingresado_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.listBox1Ingresado.Items.Count; i++)
            {
                this.listBox1Ingresado.Show();
            }
        }


        
    }
}

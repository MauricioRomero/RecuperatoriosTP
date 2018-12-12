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
namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

       
 

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double retValue = FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
            this.labelResultado.Text = "" + retValue;
            this.labelResultado.Show();
        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero();
            this.labelResultado.Text = numero1.DecimalBinario(txtNumero1.Text);
            this.labelResultado.Show();
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero n = new Numero();
            this.labelResultado.Text = n.BinarioDecimal(txtNumero1.Text);
            this.labelResultado.Show();
        }


        #region MetodosVarios

        
        private void Limpiar()
        {
            this.txtNumero1.ResetText();
            this.txtNumero2.ResetText();
            this.cmbOperador.ResetText();
            this.labelResultado.ResetText();
        
        }

        private static Double Operar(string numero1, string numero2, string operador)
        {
            Numero n1 = new Numero(numero1);
            Numero n2 = new Numero(numero2);
            return Calculadora.Operar(n1, n2, operador);
        }
        #endregion
    }
    
}

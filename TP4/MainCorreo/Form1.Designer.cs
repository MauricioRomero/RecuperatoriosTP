namespace MainCorreo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1EstadoPaquetes = new System.Windows.Forms.GroupBox();
            this.textBoxTRackingID = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelPaquete = new System.Windows.Forms.Label();
            this.listBox3Entregado = new System.Windows.Forms.ListBox();
            this.listBox2Enviaje = new System.Windows.Forms.ListBox();
            this.listBox1Ingresado = new System.Windows.Forms.ListBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1EstadoPaquetes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1EstadoPaquetes
            // 
            this.groupBox1EstadoPaquetes.Controls.Add(this.textBoxTRackingID);
            this.groupBox1EstadoPaquetes.Controls.Add(this.toolStrip1);
            this.groupBox1EstadoPaquetes.Controls.Add(this.label2);
            this.groupBox1EstadoPaquetes.Controls.Add(this.label1);
            this.groupBox1EstadoPaquetes.Controls.Add(this.btnMostrarTodos);
            this.groupBox1EstadoPaquetes.Controls.Add(this.btnAgregar);
            this.groupBox1EstadoPaquetes.Controls.Add(this.richTextBox1);
            this.groupBox1EstadoPaquetes.Controls.Add(this.labelPaquete);
            this.groupBox1EstadoPaquetes.Controls.Add(this.listBox3Entregado);
            this.groupBox1EstadoPaquetes.Controls.Add(this.listBox2Enviaje);
            this.groupBox1EstadoPaquetes.Controls.Add(this.listBox1Ingresado);
            this.groupBox1EstadoPaquetes.Location = new System.Drawing.Point(12, 12);
            this.groupBox1EstadoPaquetes.Name = "groupBox1EstadoPaquetes";
            this.groupBox1EstadoPaquetes.Size = new System.Drawing.Size(779, 245);
            this.groupBox1EstadoPaquetes.TabIndex = 0;
            this.groupBox1EstadoPaquetes.TabStop = false;
            this.groupBox1EstadoPaquetes.Text = "EstadoPaquetes";
            // 
            // textBoxTRackingID
            // 
            this.textBoxTRackingID.Location = new System.Drawing.Point(551, 199);
            this.textBoxTRackingID.Name = "textBoxTRackingID";
            this.textBoxTRackingID.Size = new System.Drawing.Size(100, 20);
            this.textBoxTRackingID.TabIndex = 12;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(773, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "TrackinID";
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(688, 216);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(85, 23);
            this.btnMostrarTodos.TabIndex = 8;
            this.btnMostrarTodos.Text = "MostrarTodos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(688, 178);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 152);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(354, 123);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // labelPaquete
            // 
            this.labelPaquete.AutoSize = true;
            this.labelPaquete.Location = new System.Drawing.Point(548, 155);
            this.labelPaquete.Name = "labelPaquete";
            this.labelPaquete.Size = new System.Drawing.Size(47, 13);
            this.labelPaquete.TabIndex = 3;
            this.labelPaquete.Text = "Paquete";
            this.labelPaquete.Click += new System.EventHandler(this.labelPaquete_Click);
            // 
            // listBox3Entregado
            // 
            this.listBox3Entregado.FormattingEnabled = true;
            this.listBox3Entregado.Location = new System.Drawing.Point(551, 51);
            this.listBox3Entregado.Name = "listBox3Entregado";
            this.listBox3Entregado.Size = new System.Drawing.Size(222, 95);
            this.listBox3Entregado.TabIndex = 2;
            // 
            // listBox2Enviaje
            // 
            this.listBox2Enviaje.FormattingEnabled = true;
            this.listBox2Enviaje.Location = new System.Drawing.Point(249, 51);
            this.listBox2Enviaje.Name = "listBox2Enviaje";
            this.listBox2Enviaje.Size = new System.Drawing.Size(232, 95);
            this.listBox2Enviaje.TabIndex = 1;
            // 
            // listBox1Ingresado
            // 
            this.listBox1Ingresado.FormattingEnabled = true;
            this.listBox1Ingresado.Location = new System.Drawing.Point(19, 51);
            this.listBox1Ingresado.Name = "listBox1Ingresado";
            this.listBox1Ingresado.Size = new System.Drawing.Size(164, 95);
            this.listBox1Ingresado.TabIndex = 0;
            this.listBox1Ingresado.SelectedIndexChanged += new System.EventHandler(this.listBox1Ingresado_SelectedIndexChanged);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(563, 263);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDireccion.TabIndex = 6;
            this.textBoxDireccion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 335);
            this.Controls.Add(this.groupBox1EstadoPaquetes);
            this.Controls.Add(this.textBoxDireccion);
            this.Name = "Form1";
            this.Text = "MauricioRomero.2D";
            this.groupBox1EstadoPaquetes.ResumeLayout(false);
            this.groupBox1EstadoPaquetes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void richTextBox1_TextChanged(object sender, System.EventArgs e)
        {
            this.richTextBox1.Show();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1EstadoPaquetes;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelPaquete;
        private System.Windows.Forms.ListBox listBox3Entregado;
        private System.Windows.Forms.ListBox listBox2Enviaje;
        private System.Windows.Forms.ListBox listBox1Ingresado;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox textBoxTRackingID;
    }
}


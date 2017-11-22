namespace consulta_nomina
{
    partial class frmbusquedaempleado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbtnid = new System.Windows.Forms.RadioButton();
            this.rbtnnombre = new System.Windows.Forms.RadioButton();
            this.rbtnapellido = new System.Windows.Forms.RadioButton();
            this.rbtncedula = new System.Windows.Forms.RadioButton();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.dgvempleado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnid
            // 
            this.rbtnid.AutoSize = true;
            this.rbtnid.Location = new System.Drawing.Point(59, 60);
            this.rbtnid.Name = "rbtnid";
            this.rbtnid.Size = new System.Drawing.Size(40, 21);
            this.rbtnid.TabIndex = 0;
            this.rbtnid.TabStop = true;
            this.rbtnid.Text = "id";
            this.rbtnid.UseVisualStyleBackColor = true;
            // 
            // rbtnnombre
            // 
            this.rbtnnombre.AutoSize = true;
            this.rbtnnombre.Location = new System.Drawing.Point(129, 60);
            this.rbtnnombre.Name = "rbtnnombre";
            this.rbtnnombre.Size = new System.Drawing.Size(79, 21);
            this.rbtnnombre.TabIndex = 1;
            this.rbtnnombre.TabStop = true;
            this.rbtnnombre.Text = "Nombre";
            this.rbtnnombre.UseVisualStyleBackColor = true;
            // 
            // rbtnapellido
            // 
            this.rbtnapellido.AutoSize = true;
            this.rbtnapellido.Location = new System.Drawing.Point(233, 60);
            this.rbtnapellido.Name = "rbtnapellido";
            this.rbtnapellido.Size = new System.Drawing.Size(79, 21);
            this.rbtnapellido.TabIndex = 2;
            this.rbtnapellido.TabStop = true;
            this.rbtnapellido.Text = "Apellido";
            this.rbtnapellido.UseVisualStyleBackColor = true;
            // 
            // rbtncedula
            // 
            this.rbtncedula.AutoSize = true;
            this.rbtncedula.Location = new System.Drawing.Point(340, 60);
            this.rbtncedula.Name = "rbtncedula";
            this.rbtncedula.Size = new System.Drawing.Size(73, 21);
            this.rbtncedula.TabIndex = 3;
            this.rbtncedula.TabStop = true;
            this.rbtncedula.Text = "Cédula";
            this.rbtncedula.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(435, 60);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(409, 22);
            this.txtbuscar.TabIndex = 4;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // bntBuscar
            // 
            this.bntBuscar.Location = new System.Drawing.Point(863, 38);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(97, 66);
            this.bntBuscar.TabIndex = 5;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(990, 38);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(71, 66);
            this.btnimprimir.TabIndex = 6;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(1090, 37);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(71, 66);
            this.btncrear.TabIndex = 7;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // dgvempleado
            // 
            this.dgvempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleado.Location = new System.Drawing.Point(12, 169);
            this.dgvempleado.Name = "dgvempleado";
            this.dgvempleado.RowTemplate.Height = 24;
            this.dgvempleado.Size = new System.Drawing.Size(1171, 431);
            this.dgvempleado.TabIndex = 8;
            this.dgvempleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleado_CellContentClick);
            this.dgvempleado.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleado_CellContentDoubleClick);
            this.dgvempleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleado_CellDoubleClick);
            // 
            // frmbusquedaempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 612);
            this.Controls.Add(this.dgvempleado);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.bntBuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.rbtncedula);
            this.Controls.Add(this.rbtnapellido);
            this.Controls.Add(this.rbtnnombre);
            this.Controls.Add(this.rbtnid);
            this.Name = "frmbusquedaempleado";
            this.Text = "Busqueda de Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnid;
        private System.Windows.Forms.RadioButton rbtnnombre;
        private System.Windows.Forms.RadioButton rbtnapellido;
        private System.Windows.Forms.RadioButton rbtncedula;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.DataGridView dgvempleado;
    }
}


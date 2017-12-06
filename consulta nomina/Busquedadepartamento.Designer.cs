namespace consulta_nomina
{
    partial class frmbusquedadepartamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnId = new System.Windows.Forms.RadioButton();
            this.rbtnCargo = new System.Windows.Forms.RadioButton();
            this.dgvdepartamento = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(180, 46);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(272, 22);
            this.txtBuscar.TabIndex = 25;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = global::consulta_nomina.Properties.Resources.icons8_print_50;
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimir.Location = new System.Drawing.Point(326, 81);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(126, 54);
            this.btnimprimir.TabIndex = 23;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // bntBuscar
            // 
            this.bntBuscar.Image = global::consulta_nomina.Properties.Resources.icons8_job_seeker_50;
            this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntBuscar.Location = new System.Drawing.Point(180, 81);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(127, 54);
            this.bntBuscar.TabIndex = 22;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnId);
            this.groupBox1.Controls.Add(this.rbtnCargo);
            this.groupBox1.Location = new System.Drawing.Point(13, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(159, 85);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por:";
            // 
            // rbtnId
            // 
            this.rbtnId.AutoSize = true;
            this.rbtnId.Location = new System.Drawing.Point(27, 23);
            this.rbtnId.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.Size = new System.Drawing.Size(42, 21);
            this.rbtnId.TabIndex = 1;
            this.rbtnId.TabStop = true;
            this.rbtnId.Text = "ID";
            this.rbtnId.UseVisualStyleBackColor = true;
            // 
            // rbtnCargo
            // 
            this.rbtnCargo.AutoSize = true;
            this.rbtnCargo.Location = new System.Drawing.Point(27, 52);
            this.rbtnCargo.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnCargo.Name = "rbtnCargo";
            this.rbtnCargo.Size = new System.Drawing.Size(119, 21);
            this.rbtnCargo.TabIndex = 2;
            this.rbtnCargo.TabStop = true;
            this.rbtnCargo.Text = "Departamento";
            this.rbtnCargo.UseVisualStyleBackColor = true;
            // 
            // dgvdepartamento
            // 
            this.dgvdepartamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdepartamento.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvdepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdepartamento.Location = new System.Drawing.Point(13, 153);
            this.dgvdepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdepartamento.Name = "dgvdepartamento";
            this.dgvdepartamento.Size = new System.Drawing.Size(439, 229);
            this.dgvdepartamento.TabIndex = 20;
            this.dgvdepartamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdepartamento_CellContentClick);
            // 
            // frmbusquedadepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 436);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.bntBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvdepartamento);
            this.Name = "frmbusquedadepartamento";
            this.Text = "Busquedadepartamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnId;
        private System.Windows.Forms.RadioButton rbtnCargo;
        private System.Windows.Forms.DataGridView dgvdepartamento;
    }
}
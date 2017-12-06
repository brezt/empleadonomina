namespace consulta_nomina
{
    partial class frmCargo
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
            this.txtdescriccion = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdescriccion
            // 
            this.txtdescriccion.Location = new System.Drawing.Point(150, 61);
            this.txtdescriccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescriccion.Name = "txtdescriccion";
            this.txtdescriccion.Size = new System.Drawing.Size(313, 22);
            this.txtdescriccion.TabIndex = 34;
            this.txtdescriccion.TextChanged += new System.EventHandler(this.txtdescriccion_TextChanged);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.AutoSize = true;
            this.txtdescripcion.Location = new System.Drawing.Point(57, 65);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(86, 17);
            this.txtdescripcion.TabIndex = 33;
            this.txtdescripcion.Text = "Descripción:";
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::consulta_nomina.Properties.Resources.icons8_cancel_50;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(399, 109);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(136, 55);
            this.btneliminar.TabIndex = 38;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = global::consulta_nomina.Properties.Resources.icons8_print_50;
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimir.Location = new System.Drawing.Point(259, 109);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(134, 55);
            this.btnimprimir.TabIndex = 37;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Image = global::consulta_nomina.Properties.Resources.icons8_save_50;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(129, 109);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(124, 55);
            this.btnguardar.TabIndex = 36;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 22);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(77, 22);
            this.txtId.TabIndex = 40;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID";
            // 
            // btncrear
            // 
            this.btncrear.Image = global::consulta_nomina.Properties.Resources.icons8_create_50;
            this.btncrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncrear.Location = new System.Drawing.Point(18, 109);
            this.btncrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(105, 55);
            this.btncrear.TabIndex = 35;
            this.btncrear.Text = "Crear";
            this.btncrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // frmCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 241);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.txtdescriccion);
            this.Controls.Add(this.txtdescripcion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCargo";
            this.Text = "frmCargo";
            this.Load += new System.EventHandler(this.frmCargo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtdescriccion;
        private System.Windows.Forms.Label txtdescripcion;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncrear;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
    }
}
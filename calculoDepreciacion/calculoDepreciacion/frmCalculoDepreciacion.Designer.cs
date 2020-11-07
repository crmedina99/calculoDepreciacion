namespace calculoDepreciacion
{
    partial class frmCalculoDepreciacion
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
            this.lblCantAnios = new System.Windows.Forms.Label();
            this.lblValActivo = new System.Windows.Forms.Label();
            this.lblVarResidual = new System.Windows.Forms.Label();
            this.txtCantAnios = new System.Windows.Forms.TextBox();
            this.txtValActivo = new System.Windows.Forms.TextBox();
            this.txtValResidual = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCantAnios
            // 
            this.lblCantAnios.AutoSize = true;
            this.lblCantAnios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantAnios.Location = new System.Drawing.Point(13, 34);
            this.lblCantAnios.Name = "lblCantAnios";
            this.lblCantAnios.Size = new System.Drawing.Size(145, 18);
            this.lblCantAnios.TabIndex = 0;
            this.lblCantAnios.Text = "Cantidad de Años:";
            // 
            // lblValActivo
            // 
            this.lblValActivo.AutoSize = true;
            this.lblValActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValActivo.Location = new System.Drawing.Point(13, 60);
            this.lblValActivo.Name = "lblValActivo";
            this.lblValActivo.Size = new System.Drawing.Size(130, 18);
            this.lblValActivo.TabIndex = 1;
            this.lblValActivo.Text = "Valor del Activo:";
            // 
            // lblVarResidual
            // 
            this.lblVarResidual.AutoSize = true;
            this.lblVarResidual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarResidual.Location = new System.Drawing.Point(13, 88);
            this.lblVarResidual.Name = "lblVarResidual";
            this.lblVarResidual.Size = new System.Drawing.Size(200, 18);
            this.lblVarResidual.TabIndex = 2;
            this.lblVarResidual.Text = "Valor Residual del Activo:";
            // 
            // txtCantAnios
            // 
            this.txtCantAnios.Location = new System.Drawing.Point(159, 34);
            this.txtCantAnios.Name = "txtCantAnios";
            this.txtCantAnios.Size = new System.Drawing.Size(62, 20);
            this.txtCantAnios.TabIndex = 3;
            // 
            // txtValActivo
            // 
            this.txtValActivo.Location = new System.Drawing.Point(144, 60);
            this.txtValActivo.Name = "txtValActivo";
            this.txtValActivo.Size = new System.Drawing.Size(62, 20);
            this.txtValActivo.TabIndex = 4;
            // 
            // txtValResidual
            // 
            this.txtValResidual.Location = new System.Drawing.Point(213, 89);
            this.txtValResidual.Name = "txtValResidual";
            this.txtValResidual.Size = new System.Drawing.Size(62, 20);
            this.txtValResidual.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(68, 129);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(173, 129);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmCalculoDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 192);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValResidual);
            this.Controls.Add(this.txtValActivo);
            this.Controls.Add(this.txtCantAnios);
            this.Controls.Add(this.lblVarResidual);
            this.Controls.Add(this.lblValActivo);
            this.Controls.Add(this.lblCantAnios);
            this.Name = "frmCalculoDepreciacion";
            this.Text = "Calculo Depreciacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantAnios;
        private System.Windows.Forms.Label lblValActivo;
        private System.Windows.Forms.Label lblVarResidual;
        private System.Windows.Forms.TextBox txtCantAnios;
        private System.Windows.Forms.TextBox txtValActivo;
        private System.Windows.Forms.TextBox txtValResidual;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBorrar;
    }
}
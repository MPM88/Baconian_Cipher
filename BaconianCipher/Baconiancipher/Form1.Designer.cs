namespace Baconiancipher
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.GBInput = new System.Windows.Forms.GroupBox();
            this.BtnPreCipher = new System.Windows.Forms.Button();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.GBInput2 = new System.Windows.Forms.GroupBox();
            this.BtnCipher = new System.Windows.Forms.Button();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.GBResult = new System.Windows.Forms.GroupBox();
            this.TxtFinalResult = new System.Windows.Forms.TextBox();
            this.lblPrecipherResult = new System.Windows.Forms.Label();
            this.TxtPrecipherResult = new System.Windows.Forms.TextBox();
            this.GBInput.SuspendLayout();
            this.GBInput2.SuspendLayout();
            this.GBResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBInput
            // 
            this.GBInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBInput.Controls.Add(this.lblInput);
            this.GBInput.Controls.Add(this.TxtInput);
            this.GBInput.Controls.Add(this.BtnPreCipher);
            this.GBInput.Controls.Add(this.lblPrecipherResult);
            this.GBInput.Controls.Add(this.TxtPrecipherResult);
            this.GBInput.Location = new System.Drawing.Point(12, 12);
            this.GBInput.Name = "GBInput";
            this.GBInput.Size = new System.Drawing.Size(695, 228);
            this.GBInput.TabIndex = 0;
            this.GBInput.TabStop = false;
            this.GBInput.Text = "Entrada";
            // 
            // BtnPreCipher
            // 
            this.BtnPreCipher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPreCipher.Location = new System.Drawing.Point(602, 29);
            this.BtnPreCipher.Name = "BtnPreCipher";
            this.BtnPreCipher.Size = new System.Drawing.Size(82, 23);
            this.BtnPreCipher.TabIndex = 2;
            this.BtnPreCipher.Text = "Pre-cifrar.";
            this.BtnPreCipher.UseVisualStyleBackColor = true;
            this.BtnPreCipher.Click += new System.EventHandler(this.BtnPreCipher_Click);
            // 
            // TxtInput
            // 
            this.TxtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtInput.Location = new System.Drawing.Point(8, 29);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(587, 20);
            this.TxtInput.TabIndex = 1;
            this.TxtInput.Text = "Xworks Blog";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(8, 16);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(72, 13);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Texto a cifrar.";
            // 
            // GBInput2
            // 
            this.GBInput2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBInput2.Controls.Add(this.BtnCipher);
            this.GBInput2.Controls.Add(this.txtInput2);
            this.GBInput2.Controls.Add(this.lblInput2);
            this.GBInput2.Location = new System.Drawing.Point(12, 246);
            this.GBInput2.Name = "GBInput2";
            this.GBInput2.Size = new System.Drawing.Size(695, 104);
            this.GBInput2.TabIndex = 1;
            this.GBInput2.TabStop = false;
            this.GBInput2.Text = "Frase de salida";
            // 
            // BtnCipher
            // 
            this.BtnCipher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCipher.Enabled = false;
            this.BtnCipher.Location = new System.Drawing.Point(602, 67);
            this.BtnCipher.Name = "BtnCipher";
            this.BtnCipher.Size = new System.Drawing.Size(82, 23);
            this.BtnCipher.TabIndex = 2;
            this.BtnCipher.Text = "Cifrar";
            this.BtnCipher.UseVisualStyleBackColor = true;
            this.BtnCipher.Click += new System.EventHandler(this.BtnCipher_Click);
            // 
            // txtInput2
            // 
            this.txtInput2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput2.Location = new System.Drawing.Point(8, 41);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(680, 20);
            this.txtInput2.TabIndex = 1;
            this.txtInput2.Text = "TodosSomosIdiotasHastaQueSeDemuestreLoContrarioooo";
            this.txtInput2.TextChanged += new System.EventHandler(this.txtInput2_TextChanged);
            // 
            // lblInput2
            // 
            this.lblInput2.AutoSize = true;
            this.lblInput2.Location = new System.Drawing.Point(8, 16);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.Size = new System.Drawing.Size(144, 13);
            this.lblInput2.TabIndex = 0;
            this.lblInput2.Text = "Texto para insertar el cifrado.";
            // 
            // GBResult
            // 
            this.GBResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBResult.Controls.Add(this.TxtFinalResult);
            this.GBResult.Location = new System.Drawing.Point(12, 356);
            this.GBResult.Name = "GBResult";
            this.GBResult.Size = new System.Drawing.Size(695, 161);
            this.GBResult.TabIndex = 2;
            this.GBResult.TabStop = false;
            this.GBResult.Text = "Resultado";
            // 
            // TxtFinalResult
            // 
            this.TxtFinalResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtFinalResult.Location = new System.Drawing.Point(3, 16);
            this.TxtFinalResult.Multiline = true;
            this.TxtFinalResult.Name = "TxtFinalResult";
            this.TxtFinalResult.Size = new System.Drawing.Size(689, 142);
            this.TxtFinalResult.TabIndex = 0;
            this.TxtFinalResult.Text = "By Xwork";
            // 
            // lblPrecipherResult
            // 
            this.lblPrecipherResult.AutoSize = true;
            this.lblPrecipherResult.Location = new System.Drawing.Point(8, 52);
            this.lblPrecipherResult.Name = "lblPrecipherResult";
            this.lblPrecipherResult.Size = new System.Drawing.Size(88, 13);
            this.lblPrecipherResult.TabIndex = 3;
            this.lblPrecipherResult.Text = "Texto Pre-cifrado";
            // 
            // TxtPrecipherResult
            // 
            this.TxtPrecipherResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrecipherResult.Enabled = false;
            this.TxtPrecipherResult.Location = new System.Drawing.Point(8, 68);
            this.TxtPrecipherResult.Multiline = true;
            this.TxtPrecipherResult.Name = "TxtPrecipherResult";
            this.TxtPrecipherResult.Size = new System.Drawing.Size(671, 154);
            this.TxtPrecipherResult.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 529);
            this.Controls.Add(this.GBResult);
            this.Controls.Add(this.GBInput2);
            this.Controls.Add(this.GBInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(730, 560);
            this.Name = "FrmMain";
            this.Text = "Baconian cipher.";
            this.GBInput.ResumeLayout(false);
            this.GBInput.PerformLayout();
            this.GBInput2.ResumeLayout(false);
            this.GBInput2.PerformLayout();
            this.GBResult.ResumeLayout(false);
            this.GBResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBInput;
        private System.Windows.Forms.Button BtnPreCipher;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.GroupBox GBInput2;
        private System.Windows.Forms.Button BtnCipher;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Label lblInput2;
        private System.Windows.Forms.GroupBox GBResult;
        private System.Windows.Forms.TextBox TxtFinalResult;
        private System.Windows.Forms.TextBox TxtPrecipherResult;
        private System.Windows.Forms.Label lblPrecipherResult;
    }
}



namespace EstudoDelegates
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lblNumero = new System.Windows.Forms.Label();
            this.txbNumeroUm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumeroDois = new System.Windows.Forms.TextBox();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubitrair = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(13, 13);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(66, 15);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número 1 :";
            // 
            // txbNumeroUm
            // 
            this.txbNumeroUm.Location = new System.Drawing.Point(95, 10);
            this.txbNumeroUm.Name = "txbNumeroUm";
            this.txbNumeroUm.Size = new System.Drawing.Size(347, 23);
            this.txbNumeroUm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 2 :";
            // 
            // txbNumeroDois
            // 
            this.txbNumeroDois.Location = new System.Drawing.Point(95, 48);
            this.txbNumeroDois.Name = "txbNumeroDois";
            this.txbNumeroDois.Size = new System.Drawing.Size(347, 23);
            this.txbNumeroDois.TabIndex = 1;
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(94, 87);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(348, 23);
            this.txbResultado.TabIndex = 3;
            this.txbResultado.TextChanged += new System.EventHandler(this.txbResultado_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultado :";
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(95, 138);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubitrair
            // 
            this.btnSubitrair.Location = new System.Drawing.Point(175, 138);
            this.btnSubitrair.Name = "btnSubitrair";
            this.btnSubitrair.Size = new System.Drawing.Size(82, 23);
            this.btnSubitrair.TabIndex = 4;
            this.btnSubitrair.Text = "Subtração";
            this.btnSubitrair.UseVisualStyleBackColor = true;
            this.btnSubitrair.Click += new System.EventHandler(this.btnSubitrair_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(263, 138);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(98, 23);
            this.btnMultiply.TabIndex = 4;
            this.btnMultiply.Text = "Multiplicação";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(367, 138);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(75, 23);
            this.btnDivisao.TabIndex = 4;
            this.btnDivisao.Text = "Divisão";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 167);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubitrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNumeroDois);
            this.Controls.Add(this.txbNumeroUm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txbNumeroUm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNumeroDois;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubitrair;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivisao;
    }
}


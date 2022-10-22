using System;

namespace Balanco
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblQtd = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtBarras = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblBarras = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.btnZerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(83, 46);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(290, 20);
            this.txtDescricao.TabIndex = 16;
            this.txtDescricao.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(387, 35);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 41);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(234, 14);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(46, 15);
            this.lblQtd.TabIndex = 13;
            this.lblQtd.Text = "Quant.:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(388, 9);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(67, 25);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "P&esquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // txtBarras
            // 
            this.txtBarras.AcceptsReturn = true;
            this.txtBarras.Location = new System.Drawing.Point(82, 11);
            this.txtBarras.Name = "txtBarras";
            this.txtBarras.Size = new System.Drawing.Size(141, 20);
            this.txtBarras.TabIndex = 1;
            this.txtBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBarras_KeyDown);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(16, 49);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(65, 15);
            this.lblDesc.TabIndex = 10;
            this.lblDesc.Text = "Descrição:";
            // 
            // lblBarras
            // 
            this.lblBarras.AutoSize = true;
            this.lblBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarras.Location = new System.Drawing.Point(6, 14);
            this.lblBarras.Name = "lblBarras";
            this.lblBarras.Size = new System.Drawing.Size(74, 15);
            this.lblBarras.TabIndex = 9;
            this.lblBarras.Text = "Cod. Barras:";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(282, 11);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(91, 20);
            this.txtQtd.TabIndex = 2;
            this.txtQtd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQtd_KeyDown);
            // 
            // btnZerar
            // 
            this.btnZerar.Location = new System.Drawing.Point(455, 9);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(19, 25);
            this.btnZerar.TabIndex = 5;
            this.btnZerar.Text = "!";
            this.btnZerar.UseVisualStyleBackColor = true;
            this.btnZerar.Click += new System.EventHandler(this.BtnZerar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(480, 83);
            this.Controls.Add(this.btnZerar);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtBarras);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblBarras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balanço Clipp 1.0.0.7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            //this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblBarras;
        public System.Windows.Forms.TextBox txtBarras;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Button btnZerar;

    }
}


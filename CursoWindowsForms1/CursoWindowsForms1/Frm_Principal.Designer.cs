﻿namespace CursoWindowsForms1
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Btn_DemostracaoKey = new System.Windows.Forms.Button();
            this.Btn_HelloWorld = new System.Windows.Forms.Button();
            this.Btn_Mascara = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Btn_ValidaCPF2 = new System.Windows.Forms.Button();
            this.Btn_ValidaSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_DemostracaoKey
            // 
            this.Btn_DemostracaoKey.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DemostracaoKey.Image")));
            this.Btn_DemostracaoKey.Location = new System.Drawing.Point(12, 12);
            this.Btn_DemostracaoKey.Name = "Btn_DemostracaoKey";
            this.Btn_DemostracaoKey.Size = new System.Drawing.Size(114, 48);
            this.Btn_DemostracaoKey.TabIndex = 0;
            this.Btn_DemostracaoKey.Text = "Demonstração Key";
            this.Btn_DemostracaoKey.UseVisualStyleBackColor = true;
            this.Btn_DemostracaoKey.Click += new System.EventHandler(this.Btn_DemostracaoKey_Click);
            // 
            // Btn_HelloWorld
            // 
            this.Btn_HelloWorld.Image = ((System.Drawing.Image)(resources.GetObject("Btn_HelloWorld.Image")));
            this.Btn_HelloWorld.Location = new System.Drawing.Point(132, 12);
            this.Btn_HelloWorld.Name = "Btn_HelloWorld";
            this.Btn_HelloWorld.Size = new System.Drawing.Size(114, 48);
            this.Btn_HelloWorld.TabIndex = 1;
            this.Btn_HelloWorld.Text = "Hello World";
            this.Btn_HelloWorld.UseVisualStyleBackColor = true;
            this.Btn_HelloWorld.Click += new System.EventHandler(this.Btn_HelloWorld_Click);
            // 
            // Btn_Mascara
            // 
            this.Btn_Mascara.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Mascara.Image")));
            this.Btn_Mascara.Location = new System.Drawing.Point(252, 12);
            this.Btn_Mascara.Name = "Btn_Mascara";
            this.Btn_Mascara.Size = new System.Drawing.Size(114, 48);
            this.Btn_Mascara.TabIndex = 2;
            this.Btn_Mascara.Text = "Máscara";
            this.Btn_Mascara.UseVisualStyleBackColor = true;
            this.Btn_Mascara.Click += new System.EventHandler(this.Btn_Mascara_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(12, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "Valida CPF";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_ValidaCPF2
            // 
            this.Btn_ValidaCPF2.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ValidaCPF2.Image")));
            this.Btn_ValidaCPF2.Location = new System.Drawing.Point(132, 66);
            this.Btn_ValidaCPF2.Name = "Btn_ValidaCPF2";
            this.Btn_ValidaCPF2.Size = new System.Drawing.Size(114, 48);
            this.Btn_ValidaCPF2.TabIndex = 4;
            this.Btn_ValidaCPF2.Text = "Valida CPF 2";
            this.Btn_ValidaCPF2.UseVisualStyleBackColor = true;
            this.Btn_ValidaCPF2.Click += new System.EventHandler(this.Btn_ValidaCPF2_Click);
            // 
            // Btn_ValidaSenha
            // 
            this.Btn_ValidaSenha.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ValidaSenha.Image")));
            this.Btn_ValidaSenha.Location = new System.Drawing.Point(252, 66);
            this.Btn_ValidaSenha.Name = "Btn_ValidaSenha";
            this.Btn_ValidaSenha.Size = new System.Drawing.Size(114, 48);
            this.Btn_ValidaSenha.TabIndex = 5;
            this.Btn_ValidaSenha.Text = "Valida Senha";
            this.Btn_ValidaSenha.UseVisualStyleBackColor = true;
            this.Btn_ValidaSenha.Click += new System.EventHandler(this.Btn_ValidaSenha_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 118);
            this.Controls.Add(this.Btn_ValidaSenha);
            this.Controls.Add(this.Btn_ValidaCPF2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Btn_Mascara);
            this.Controls.Add(this.Btn_HelloWorld);
            this.Controls.Add(this.Btn_DemostracaoKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_DemostracaoKey;
        private System.Windows.Forms.Button Btn_HelloWorld;
        private System.Windows.Forms.Button Btn_Mascara;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Btn_ValidaCPF2;
        private System.Windows.Forms.Button Btn_ValidaSenha;
    }
}
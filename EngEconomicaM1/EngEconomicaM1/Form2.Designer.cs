namespace EngEconomicaM1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioSimples = new System.Windows.Forms.RadioButton();
            this.radioComposto = new System.Windows.Forms.RadioButton();
            this.valorEmprest = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valorTaxa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioJAnual = new System.Windows.Forms.RadioButton();
            this.radioJSemestral = new System.Windows.Forms.RadioButton();
            this.radioJMensal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.valorPrazo = new System.Windows.Forms.TextBox();
            this.radioPAnos = new System.Windows.Forms.RadioButton();
            this.radioPMes = new System.Windows.Forms.RadioButton();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.btn_trash = new System.Windows.Forms.PictureBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.valorMensal = new System.Windows.Forms.TextBox();
            this.radioTotal = new System.Windows.Forms.RadioButton();
            this.radioMensal = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_trash)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo de Juros";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioSimples
            // 
            this.radioSimples.AutoSize = true;
            this.radioSimples.Location = new System.Drawing.Point(201, 72);
            this.radioSimples.Name = "radioSimples";
            this.radioSimples.Size = new System.Drawing.Size(61, 17);
            this.radioSimples.TabIndex = 2;
            this.radioSimples.TabStop = true;
            this.radioSimples.Text = "Simples";
            this.radioSimples.UseVisualStyleBackColor = true;
            // 
            // radioComposto
            // 
            this.radioComposto.AutoSize = true;
            this.radioComposto.Location = new System.Drawing.Point(201, 108);
            this.radioComposto.Name = "radioComposto";
            this.radioComposto.Size = new System.Drawing.Size(72, 17);
            this.radioComposto.TabIndex = 3;
            this.radioComposto.TabStop = true;
            this.radioComposto.Text = "Composto";
            this.radioComposto.UseVisualStyleBackColor = true;
            // 
            // valorEmprest
            // 
            this.valorEmprest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.valorEmprest.Location = new System.Drawing.Point(109, 19);
            this.valorEmprest.Name = "valorEmprest";
            this.valorEmprest.Size = new System.Drawing.Size(147, 20);
            this.valorEmprest.TabIndex = 5;
            this.valorEmprest.Text = "0\r\n";
            this.valorEmprest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorEmprest_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valorTaxa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioJAnual);
            this.groupBox1.Controls.Add(this.radioJSemestral);
            this.groupBox1.Controls.Add(this.radioJMensal);
            this.groupBox1.Location = new System.Drawing.Point(158, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 109);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taxa de Juros (i)";
            // 
            // valorTaxa
            // 
            this.valorTaxa.Location = new System.Drawing.Point(96, 75);
            this.valorTaxa.Name = "valorTaxa";
            this.valorTaxa.Size = new System.Drawing.Size(100, 20);
            this.valorTaxa.TabIndex = 4;
            this.valorTaxa.Text = "0";
            this.valorTaxa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorTaxa_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Taxa (%):";
            // 
            // radioJAnual
            // 
            this.radioJAnual.AutoSize = true;
            this.radioJAnual.Location = new System.Drawing.Point(192, 30);
            this.radioJAnual.Name = "radioJAnual";
            this.radioJAnual.Size = new System.Drawing.Size(52, 17);
            this.radioJAnual.TabIndex = 2;
            this.radioJAnual.Text = "Anual";
            this.radioJAnual.UseVisualStyleBackColor = true;
            // 
            // radioJSemestral
            // 
            this.radioJSemestral.AutoSize = true;
            this.radioJSemestral.Location = new System.Drawing.Point(96, 30);
            this.radioJSemestral.Name = "radioJSemestral";
            this.radioJSemestral.Size = new System.Drawing.Size(71, 17);
            this.radioJSemestral.TabIndex = 1;
            this.radioJSemestral.Text = "Semestral";
            this.radioJSemestral.UseVisualStyleBackColor = true;
            // 
            // radioJMensal
            // 
            this.radioJMensal.AutoSize = true;
            this.radioJMensal.Checked = true;
            this.radioJMensal.Location = new System.Drawing.Point(20, 30);
            this.radioJMensal.Name = "radioJMensal";
            this.radioJMensal.Size = new System.Drawing.Size(59, 17);
            this.radioJMensal.TabIndex = 0;
            this.radioJMensal.TabStop = true;
            this.radioJMensal.Text = "Mensal";
            this.radioJMensal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.valorPrazo);
            this.groupBox2.Controls.Add(this.radioPAnos);
            this.groupBox2.Controls.Add(this.radioPMes);
            this.groupBox2.Location = new System.Drawing.Point(427, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 109);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prazo (n)";
            // 
            // valorPrazo
            // 
            this.valorPrazo.Location = new System.Drawing.Point(43, 29);
            this.valorPrazo.Name = "valorPrazo";
            this.valorPrazo.Size = new System.Drawing.Size(115, 20);
            this.valorPrazo.TabIndex = 4;
            this.valorPrazo.Text = "0";
            this.valorPrazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorPrazo_KeyPress);
            // 
            // radioPAnos
            // 
            this.radioPAnos.AutoSize = true;
            this.radioPAnos.Location = new System.Drawing.Point(109, 78);
            this.radioPAnos.Name = "radioPAnos";
            this.radioPAnos.Size = new System.Drawing.Size(49, 17);
            this.radioPAnos.TabIndex = 2;
            this.radioPAnos.Text = "Anos";
            this.radioPAnos.UseVisualStyleBackColor = true;
            // 
            // radioPMes
            // 
            this.radioPMes.AutoSize = true;
            this.radioPMes.Checked = true;
            this.radioPMes.Location = new System.Drawing.Point(43, 76);
            this.radioPMes.Name = "radioPMes";
            this.radioPMes.Size = new System.Drawing.Size(56, 17);
            this.radioPMes.TabIndex = 0;
            this.radioPMes.TabStop = true;
            this.radioPMes.Text = "Meses";
            this.radioPMes.UseVisualStyleBackColor = true;
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(281, 276);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(136, 37);
            this.btn_Calc.TabIndex = 9;
            this.btn_Calc.Text = "Calcular";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // btn_trash
            // 
            this.btn_trash.Image = ((System.Drawing.Image)(resources.GetObject("btn_trash.Image")));
            this.btn_trash.Location = new System.Drawing.Point(442, 276);
            this.btn_trash.Name = "btn_trash";
            this.btn_trash.Size = new System.Drawing.Size(39, 37);
            this.btn_trash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_trash.TabIndex = 11;
            this.btn_trash.TabStop = false;
            this.btn_trash.Click += new System.EventHandler(this.btn_trash_Click);
            // 
            // txtResult
            // 
            this.txtResult.AcceptsReturn = true;
            this.txtResult.Location = new System.Drawing.Point(178, 329);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(433, 111);
            this.txtResult.TabIndex = 12;
            // 
            // valorMensal
            // 
            this.valorMensal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.valorMensal.Enabled = false;
            this.valorMensal.Location = new System.Drawing.Point(109, 51);
            this.valorMensal.Name = "valorMensal";
            this.valorMensal.Size = new System.Drawing.Size(147, 20);
            this.valorMensal.TabIndex = 13;
            this.valorMensal.Text = "0";
            // 
            // radioTotal
            // 
            this.radioTotal.AutoSize = true;
            this.radioTotal.Checked = true;
            this.radioTotal.Location = new System.Drawing.Point(12, 20);
            this.radioTotal.Name = "radioTotal";
            this.radioTotal.Size = new System.Drawing.Size(91, 17);
            this.radioTotal.TabIndex = 15;
            this.radioTotal.TabStop = true;
            this.radioTotal.Text = "Valor total (P):";
            this.radioTotal.UseVisualStyleBackColor = true;
            this.radioTotal.CheckedChanged += new System.EventHandler(this.radioTotal_CheckedChanged);
            // 
            // radioMensal
            // 
            this.radioMensal.AutoSize = true;
            this.radioMensal.Location = new System.Drawing.Point(12, 52);
            this.radioMensal.Name = "radioMensal";
            this.radioMensal.Size = new System.Drawing.Size(89, 17);
            this.radioMensal.TabIndex = 16;
            this.radioMensal.Text = "Valor Mensal:";
            this.radioMensal.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioMensal);
            this.groupBox3.Controls.Add(this.radioTotal);
            this.groupBox3.Controls.Add(this.valorMensal);
            this.groupBox3.Controls.Add(this.valorEmprest);
            this.groupBox3.Location = new System.Drawing.Point(323, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 83);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valores";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btn_trash);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioComposto);
            this.Controls.Add(this.radioSimples);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Juros";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_trash)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioSimples;
        private System.Windows.Forms.RadioButton radioComposto;
        private System.Windows.Forms.TextBox valorEmprest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox valorTaxa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioJAnual;
        private System.Windows.Forms.RadioButton radioJSemestral;
        private System.Windows.Forms.RadioButton radioJMensal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox valorPrazo;
        private System.Windows.Forms.RadioButton radioPAnos;
        private System.Windows.Forms.RadioButton radioPMes;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.PictureBox btn_trash;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox valorMensal;
        private System.Windows.Forms.RadioButton radioTotal;
        private System.Windows.Forms.RadioButton radioMensal;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
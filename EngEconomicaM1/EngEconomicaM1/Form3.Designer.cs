namespace EngEconomicaM1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtAmortiz = new System.Windows.Forms.TextBox();
            this.txtPrazo = new System.Windows.Forms.TextBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.radioSac = new System.Windows.Forms.RadioButton();
            this.radioPrice = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btn_Trash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Trash)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(250, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amortização Financeira";
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
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(262, 247);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(162, 39);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtAmortiz
            // 
            this.txtAmortiz.Location = new System.Drawing.Point(341, 115);
            this.txtAmortiz.Name = "txtAmortiz";
            this.txtAmortiz.Size = new System.Drawing.Size(136, 20);
            this.txtAmortiz.TabIndex = 3;
            this.txtAmortiz.Text = "0";
            // 
            // txtPrazo
            // 
            this.txtPrazo.Location = new System.Drawing.Point(341, 159);
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(136, 20);
            this.txtPrazo.TabIndex = 4;
            this.txtPrazo.Text = "0";
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(341, 203);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(136, 20);
            this.txtTaxa.TabIndex = 5;
            this.txtTaxa.Text = "0";
            // 
            // radioSac
            // 
            this.radioSac.AutoSize = true;
            this.radioSac.Checked = true;
            this.radioSac.Location = new System.Drawing.Point(341, 67);
            this.radioSac.Name = "radioSac";
            this.radioSac.Size = new System.Drawing.Size(46, 17);
            this.radioSac.TabIndex = 6;
            this.radioSac.TabStop = true;
            this.radioSac.Text = "SAC";
            this.radioSac.UseVisualStyleBackColor = true;
            // 
            // radioPrice
            // 
            this.radioPrice.AutoSize = true;
            this.radioPrice.Location = new System.Drawing.Point(428, 67);
            this.radioPrice.Name = "radioPrice";
            this.radioPrice.Size = new System.Drawing.Size(49, 17);
            this.radioPrice.TabIndex = 7;
            this.radioPrice.Text = "Price";
            this.radioPrice.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prazo (meses):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Taxa (%):";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(142, 311);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(516, 127);
            this.txtResult.TabIndex = 11;
            // 
            // btn_Trash
            // 
            this.btn_Trash.Image = ((System.Drawing.Image)(resources.GetObject("btn_Trash.Image")));
            this.btn_Trash.Location = new System.Drawing.Point(450, 247);
            this.btn_Trash.Name = "btn_Trash";
            this.btn_Trash.Size = new System.Drawing.Size(41, 39);
            this.btn_Trash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Trash.TabIndex = 12;
            this.btn_Trash.TabStop = false;
            this.btn_Trash.Click += new System.EventHandler(this.btn_Trash_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Trash);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioPrice);
            this.Controls.Add(this.radioSac);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.txtPrazo);
            this.Controls.Add(this.txtAmortiz);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amortização Financeira";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Trash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtAmortiz;
        private System.Windows.Forms.TextBox txtPrazo;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.RadioButton radioSac;
        private System.Windows.Forms.RadioButton radioPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.PictureBox btn_Trash;
    }
}
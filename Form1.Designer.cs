namespace Calculadora
{
    partial class Form1
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.buttonmorethanless = new System.Windows.Forms.Button();
            this.buttoncero = new System.Windows.Forms.Button();
            this.buttonpunto = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonBorrartodo = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonpotencia = new System.Windows.Forms.Button();
            this.buttonraiz = new System.Windows.Forms.Button();
            this.buttonmulti = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.buttonrest = new System.Windows.Forms.Button();
            this.buttonsum = new System.Windows.Forms.Button();
            this.buttonresult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtResultado.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.ForeColor = System.Drawing.Color.White;
            this.txtResultado.Location = new System.Drawing.Point(14, 14);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(5);
            this.txtResultado.MaxLength = 16;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(346, 69);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonmorethanless
            // 
            this.buttonmorethanless.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonmorethanless.ForeColor = System.Drawing.Color.Black;
            this.buttonmorethanless.Location = new System.Drawing.Point(16, 360);
            this.buttonmorethanless.Name = "buttonmorethanless";
            this.buttonmorethanless.Size = new System.Drawing.Size(49, 45);
            this.buttonmorethanless.TabIndex = 36;
            this.buttonmorethanless.Text = "+/-";
            this.buttonmorethanless.UseVisualStyleBackColor = true;
            this.buttonmorethanless.Click += new System.EventHandler(this.buttonmorethanless_Click);
            // 
            // buttoncero
            // 
            this.buttoncero.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttoncero.ForeColor = System.Drawing.Color.Black;
            this.buttoncero.Location = new System.Drawing.Point(78, 360);
            this.buttoncero.Name = "buttoncero";
            this.buttoncero.Size = new System.Drawing.Size(49, 45);
            this.buttoncero.TabIndex = 37;
            this.buttoncero.Text = "0";
            this.buttoncero.UseVisualStyleBackColor = true;
            this.buttoncero.Click += new System.EventHandler(this.agregarNumero);
            // 
            // buttonpunto
            // 
            this.buttonpunto.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonpunto.ForeColor = System.Drawing.Color.Black;
            this.buttonpunto.Location = new System.Drawing.Point(141, 360);
            this.buttonpunto.Name = "buttonpunto";
            this.buttonpunto.Size = new System.Drawing.Size(49, 45);
            this.buttonpunto.TabIndex = 38;
            this.buttonpunto.Text = ".";
            this.buttonpunto.UseVisualStyleBackColor = true;
            this.buttonpunto.Click += new System.EventHandler(this.buttonpunto_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(141, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 45);
            this.button3.TabIndex = 41;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(78, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 45);
            this.button2.TabIndex = 40;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(16, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 45);
            this.button1.TabIndex = 39;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(14, 167);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 45);
            this.button7.TabIndex = 44;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(141, 165);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 45);
            this.button9.TabIndex = 43;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(78, 166);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 45);
            this.button8.TabIndex = 42;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(141, 230);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 45);
            this.button6.TabIndex = 47;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(78, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 45);
            this.button5.TabIndex = 46;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(16, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 45);
            this.button4.TabIndex = 45;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(141, 99);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(49, 45);
            this.button10.TabIndex = 50;
            this.button10.Text = "<-";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonBorrartodo
            // 
            this.buttonBorrartodo.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBorrartodo.ForeColor = System.Drawing.Color.Black;
            this.buttonBorrartodo.Location = new System.Drawing.Point(78, 99);
            this.buttonBorrartodo.Name = "buttonBorrartodo";
            this.buttonBorrartodo.Size = new System.Drawing.Size(49, 45);
            this.buttonBorrartodo.TabIndex = 49;
            this.buttonBorrartodo.Text = "C";
            this.buttonBorrartodo.UseVisualStyleBackColor = true;
            this.buttonBorrartodo.Click += new System.EventHandler(this.buttonBorrartodo_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBorrar.ForeColor = System.Drawing.Color.Black;
            this.buttonBorrar.Location = new System.Drawing.Point(16, 99);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(49, 45);
            this.buttonBorrar.TabIndex = 48;
            this.buttonBorrar.Text = "CE";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonpotencia
            // 
            this.buttonpotencia.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonpotencia.ForeColor = System.Drawing.Color.Black;
            this.buttonpotencia.Location = new System.Drawing.Point(311, 99);
            this.buttonpotencia.Name = "buttonpotencia";
            this.buttonpotencia.Size = new System.Drawing.Size(49, 45);
            this.buttonpotencia.TabIndex = 52;
            this.buttonpotencia.Tag = "²";
            this.buttonpotencia.Text = "x²";
            this.buttonpotencia.UseVisualStyleBackColor = true;
            this.buttonpotencia.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonraiz
            // 
            this.buttonraiz.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonraiz.ForeColor = System.Drawing.Color.Black;
            this.buttonraiz.Location = new System.Drawing.Point(247, 99);
            this.buttonraiz.Name = "buttonraiz";
            this.buttonraiz.Size = new System.Drawing.Size(49, 45);
            this.buttonraiz.TabIndex = 51;
            this.buttonraiz.Tag = "√";
            this.buttonraiz.Text = "√";
            this.buttonraiz.UseVisualStyleBackColor = true;
            this.buttonraiz.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonmulti
            // 
            this.buttonmulti.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonmulti.ForeColor = System.Drawing.Color.Black;
            this.buttonmulti.Location = new System.Drawing.Point(311, 165);
            this.buttonmulti.Name = "buttonmulti";
            this.buttonmulti.Size = new System.Drawing.Size(49, 45);
            this.buttonmulti.TabIndex = 54;
            this.buttonmulti.Tag = "X";
            this.buttonmulti.Text = "X";
            this.buttonmulti.UseVisualStyleBackColor = true;
            this.buttonmulti.Click += new System.EventHandler(this.clickOperador);
            // 
            // btndividir
            // 
            this.btndividir.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndividir.ForeColor = System.Drawing.Color.Black;
            this.btndividir.Location = new System.Drawing.Point(247, 163);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(49, 45);
            this.btndividir.TabIndex = 53;
            this.btndividir.Tag = "/";
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonrest
            // 
            this.buttonrest.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonrest.ForeColor = System.Drawing.Color.Black;
            this.buttonrest.Location = new System.Drawing.Point(311, 230);
            this.buttonrest.Name = "buttonrest";
            this.buttonrest.Size = new System.Drawing.Size(49, 45);
            this.buttonrest.TabIndex = 56;
            this.buttonrest.Tag = "-";
            this.buttonrest.Text = "-";
            this.buttonrest.UseVisualStyleBackColor = true;
            this.buttonrest.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonsum
            // 
            this.buttonsum.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonsum.ForeColor = System.Drawing.Color.Black;
            this.buttonsum.Location = new System.Drawing.Point(247, 230);
            this.buttonsum.Name = "buttonsum";
            this.buttonsum.Size = new System.Drawing.Size(49, 45);
            this.buttonsum.TabIndex = 55;
            this.buttonsum.Tag = "+";
            this.buttonsum.Text = "+";
            this.buttonsum.UseVisualStyleBackColor = true;
            this.buttonsum.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonresult
            // 
            this.buttonresult.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonresult.ForeColor = System.Drawing.Color.Black;
            this.buttonresult.Location = new System.Drawing.Point(247, 296);
            this.buttonresult.Name = "buttonresult";
            this.buttonresult.Size = new System.Drawing.Size(113, 45);
            this.buttonresult.TabIndex = 57;
            this.buttonresult.Text = "=";
            this.buttonresult.UseVisualStyleBackColor = true;
            this.buttonresult.Click += new System.EventHandler(this.buttonresult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(386, 430);
            this.Controls.Add(this.buttonresult);
            this.Controls.Add(this.buttonrest);
            this.Controls.Add(this.buttonsum);
            this.Controls.Add(this.buttonmulti);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.buttonpotencia);
            this.Controls.Add(this.buttonraiz);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonBorrartodo);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonpunto);
            this.Controls.Add(this.buttoncero);
            this.Controls.Add(this.buttonmorethanless);
            this.Controls.Add(this.txtResultado);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResultado;
        private Button buttonmorethanless;
        private Button buttoncero;
        private Button buttonpunto;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button7;
        private Button button9;
        private Button button8;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button10;
        private Button buttonBorrartodo;
        private Button buttonBorrar;
        private Button buttonpotencia;
        private Button buttonraiz;
        private Button buttonmulti;
        private Button btndividir;
        private Button buttonrest;
        private Button buttonsum;
        private Button buttonresult;
    }
}
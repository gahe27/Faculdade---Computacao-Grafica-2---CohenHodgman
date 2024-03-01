namespace AlgoritmoCohenHodgman
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
            btnDesenharViewport = new Button();
            panelDesenhos = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtX1 = new TextBox();
            txtX2 = new TextBox();
            label4 = new Label();
            txtY2 = new TextBox();
            label5 = new Label();
            txtY1 = new TextBox();
            label6 = new Label();
            btnLimpar = new Button();
            label7 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            y2v2 = new TextBox();
            label9 = new Label();
            y1v1 = new TextBox();
            label10 = new Label();
            x2v2 = new TextBox();
            label11 = new Label();
            x1v1 = new TextBox();
            label12 = new Label();
            y4v4 = new TextBox();
            label13 = new Label();
            y3v3 = new TextBox();
            label14 = new Label();
            x4v4 = new TextBox();
            label15 = new Label();
            x3v3 = new TextBox();
            label16 = new Label();
            y6v6 = new TextBox();
            label17 = new Label();
            y5v5 = new TextBox();
            label18 = new Label();
            x6v6 = new TextBox();
            label19 = new Label();
            x5v5 = new TextBox();
            label20 = new Label();
            btnDesenharPolígono = new Button();
            btnLimparVertices = new Button();
            btnRecortar = new Button();
            SuspendLayout();
            // 
            // btnDesenharViewport
            // 
            btnDesenharViewport.Location = new Point(27, 117);
            btnDesenharViewport.Name = "btnDesenharViewport";
            btnDesenharViewport.Size = new Size(174, 33);
            btnDesenharViewport.TabIndex = 0;
            btnDesenharViewport.Text = "Desenhar Viewport";
            btnDesenharViewport.UseVisualStyleBackColor = true;
            btnDesenharViewport.Click += button1_Click;
            // 
            // panelDesenhos
            // 
            panelDesenhos.BackColor = SystemColors.GradientInactiveCaption;
            panelDesenhos.Location = new Point(489, 12);
            panelDesenhos.Name = "panelDesenhos";
            panelDesenhos.Size = new Size(491, 300);
            panelDesenhos.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 8);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 3;
            label2.Text = "Janela de Visualização:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 33);
            label3.Name = "label3";
            label3.Size = new Size(33, 25);
            label3.TabIndex = 5;
            label3.Text = "X1";
            // 
            // txtX1
            // 
            txtX1.Location = new Point(40, 33);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(60, 31);
            txtX1.TabIndex = 6;
            // 
            // txtX2
            // 
            txtX2.Location = new Point(140, 33);
            txtX2.Name = "txtX2";
            txtX2.Size = new Size(60, 31);
            txtX2.TabIndex = 8;
            txtX2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 33);
            label4.Name = "label4";
            label4.Size = new Size(33, 25);
            label4.TabIndex = 7;
            label4.Text = "X2";
            label4.Click += label4_Click;
            // 
            // txtY2
            // 
            txtY2.Location = new Point(140, 78);
            txtY2.Name = "txtY2";
            txtY2.Size = new Size(60, 31);
            txtY2.TabIndex = 13;
            txtY2.TextChanged += txtY2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 72);
            label5.Name = "label5";
            label5.Size = new Size(32, 25);
            label5.TabIndex = 12;
            label5.Text = "Y2";
            // 
            // txtY1
            // 
            txtY1.Location = new Point(40, 78);
            txtY1.Name = "txtY1";
            txtY1.Size = new Size(60, 31);
            txtY1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 72);
            label6.Name = "label6";
            label6.Size = new Size(32, 25);
            label6.TabIndex = 10;
            label6.Text = "Y1";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(656, 318);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(131, 33);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar Painel";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 162);
            label7.Name = "label7";
            label7.Size = new Size(211, 25);
            label7.TabIndex = 15;
            label7.Text = "Poligono a ser recortado:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 187);
            label8.Name = "label8";
            label8.Size = new Size(263, 25);
            label8.TabIndex = 16;
            label8.Text = "Selecione a quantidade vértices.";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "3", "4", "5", "6" });
            comboBox1.Location = new Point(11, 215);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(263, 33);
            comboBox1.TabIndex = 17;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // y2v2
            // 
            y2v2.Enabled = false;
            y2v2.Location = new Point(140, 315);
            y2v2.Name = "y2v2";
            y2v2.Size = new Size(60, 31);
            y2v2.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(111, 315);
            label9.Name = "label9";
            label9.Size = new Size(32, 25);
            label9.TabIndex = 24;
            label9.Text = "Y2";
            // 
            // y1v1
            // 
            y1v1.Enabled = false;
            y1v1.Location = new Point(140, 278);
            y1v1.Name = "y1v1";
            y1v1.Size = new Size(60, 31);
            y1v1.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(111, 278);
            label10.Name = "label10";
            label10.Size = new Size(32, 25);
            label10.TabIndex = 22;
            label10.Text = "Y1";
            // 
            // x2v2
            // 
            x2v2.Enabled = false;
            x2v2.Location = new Point(40, 315);
            x2v2.Name = "x2v2";
            x2v2.Size = new Size(60, 31);
            x2v2.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 315);
            label11.Name = "label11";
            label11.Size = new Size(33, 25);
            label11.TabIndex = 20;
            label11.Text = "X2";
            // 
            // x1v1
            // 
            x1v1.Enabled = false;
            x1v1.Location = new Point(40, 278);
            x1v1.Name = "x1v1";
            x1v1.Size = new Size(60, 31);
            x1v1.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 278);
            label12.Name = "label12";
            label12.Size = new Size(33, 25);
            label12.TabIndex = 18;
            label12.Text = "X1";
            // 
            // y4v4
            // 
            y4v4.Enabled = false;
            y4v4.Location = new Point(140, 388);
            y4v4.Name = "y4v4";
            y4v4.Size = new Size(60, 31);
            y4v4.TabIndex = 33;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(111, 388);
            label13.Name = "label13";
            label13.Size = new Size(32, 25);
            label13.TabIndex = 32;
            label13.Text = "Y4";
            // 
            // y3v3
            // 
            y3v3.Enabled = false;
            y3v3.Location = new Point(140, 352);
            y3v3.Name = "y3v3";
            y3v3.Size = new Size(60, 31);
            y3v3.TabIndex = 31;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(111, 352);
            label14.Name = "label14";
            label14.Size = new Size(32, 25);
            label14.TabIndex = 30;
            label14.Text = "Y3";
            // 
            // x4v4
            // 
            x4v4.Enabled = false;
            x4v4.Location = new Point(40, 388);
            x4v4.Name = "x4v4";
            x4v4.Size = new Size(60, 31);
            x4v4.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 388);
            label15.Name = "label15";
            label15.Size = new Size(33, 25);
            label15.TabIndex = 28;
            label15.Text = "X4";
            // 
            // x3v3
            // 
            x3v3.Enabled = false;
            x3v3.Location = new Point(40, 352);
            x3v3.Name = "x3v3";
            x3v3.Size = new Size(60, 31);
            x3v3.TabIndex = 27;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(11, 352);
            label16.Name = "label16";
            label16.Size = new Size(33, 25);
            label16.TabIndex = 26;
            label16.Text = "X3";
            // 
            // y6v6
            // 
            y6v6.Enabled = false;
            y6v6.Location = new Point(334, 315);
            y6v6.Name = "y6v6";
            y6v6.Size = new Size(60, 31);
            y6v6.TabIndex = 41;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(306, 315);
            label17.Name = "label17";
            label17.Size = new Size(32, 25);
            label17.TabIndex = 40;
            label17.Text = "Y6";
            // 
            // y5v5
            // 
            y5v5.Enabled = false;
            y5v5.Location = new Point(334, 278);
            y5v5.Name = "y5v5";
            y5v5.Size = new Size(60, 31);
            y5v5.TabIndex = 39;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(306, 278);
            label18.Name = "label18";
            label18.Size = new Size(32, 25);
            label18.TabIndex = 38;
            label18.Text = "Y5";
            // 
            // x6v6
            // 
            x6v6.Enabled = false;
            x6v6.Location = new Point(234, 315);
            x6v6.Name = "x6v6";
            x6v6.Size = new Size(60, 31);
            x6v6.TabIndex = 37;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(206, 315);
            label19.Name = "label19";
            label19.Size = new Size(33, 25);
            label19.TabIndex = 36;
            label19.Text = "X6";
            // 
            // x5v5
            // 
            x5v5.Enabled = false;
            x5v5.Location = new Point(234, 278);
            x5v5.Name = "x5v5";
            x5v5.Size = new Size(60, 31);
            x5v5.TabIndex = 35;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(206, 278);
            label20.Name = "label20";
            label20.Size = new Size(33, 25);
            label20.TabIndex = 34;
            label20.Text = "X5";
            // 
            // btnDesenharPolígono
            // 
            btnDesenharPolígono.Location = new Point(219, 360);
            btnDesenharPolígono.Name = "btnDesenharPolígono";
            btnDesenharPolígono.Size = new Size(174, 33);
            btnDesenharPolígono.TabIndex = 42;
            btnDesenharPolígono.Text = "Desenhar Polígono";
            btnDesenharPolígono.UseVisualStyleBackColor = true;
            btnDesenharPolígono.Click += btnDesenharPolígono_Click;
            // 
            // btnLimparVertices
            // 
            btnLimparVertices.Location = new Point(219, 398);
            btnLimparVertices.Name = "btnLimparVertices";
            btnLimparVertices.Size = new Size(131, 33);
            btnLimparVertices.TabIndex = 43;
            btnLimparVertices.Text = "Limpar";
            btnLimparVertices.UseVisualStyleBackColor = true;
            btnLimparVertices.Click += btnLimparVertices_Click;
            // 
            // btnRecortar
            // 
            btnRecortar.Location = new Point(399, 360);
            btnRecortar.Name = "btnRecortar";
            btnRecortar.Size = new Size(111, 33);
            btnRecortar.TabIndex = 44;
            btnRecortar.Text = "Recortar Polígono";
            btnRecortar.UseVisualStyleBackColor = true;
            btnRecortar.Click += btnRecortar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 450);
            Controls.Add(btnRecortar);
            Controls.Add(btnLimparVertices);
            Controls.Add(btnDesenharPolígono);
            Controls.Add(y6v6);
            Controls.Add(label17);
            Controls.Add(y5v5);
            Controls.Add(label18);
            Controls.Add(x6v6);
            Controls.Add(label19);
            Controls.Add(x5v5);
            Controls.Add(label20);
            Controls.Add(y4v4);
            Controls.Add(label13);
            Controls.Add(y3v3);
            Controls.Add(label14);
            Controls.Add(x4v4);
            Controls.Add(label15);
            Controls.Add(x3v3);
            Controls.Add(label16);
            Controls.Add(y2v2);
            Controls.Add(label9);
            Controls.Add(y1v1);
            Controls.Add(label10);
            Controls.Add(x2v2);
            Controls.Add(label11);
            Controls.Add(x1v1);
            Controls.Add(label12);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnLimpar);
            Controls.Add(txtY2);
            Controls.Add(label5);
            Controls.Add(txtY1);
            Controls.Add(label6);
            Controls.Add(txtX2);
            Controls.Add(label4);
            Controls.Add(txtX1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelDesenhos);
            Controls.Add(btnDesenharViewport);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDesenharViewport;
        private Panel panelDesenhos;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtX1;
        private TextBox txtX2;
        private Label label4;
        private TextBox txtY2;
        private Label label5;
        private TextBox txtY1;
        private Label label6;
        private Button btnLimpar;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private TextBox y2v2;
        private Label label9;
        private TextBox y1v1;
        private Label label10;
        private TextBox x2v2;
        private Label label11;
        private TextBox x1v1;
        private Label label12;
        private TextBox y4v4;
        private Label label13;
        private TextBox y3v3;
        private Label label14;
        private TextBox x4v4;
        private Label label15;
        private TextBox x3v3;
        private Label label16;
        private TextBox y6v6;
        private Label label17;
        private TextBox y5v5;
        private Label label18;
        private TextBox x6v6;
        private Label label19;
        private TextBox x5v5;
        private Label label20;
        private Button btnDesenharPolígono;
        private Button btnLimparVertices;
        private Button btnRecortar;
    }
}
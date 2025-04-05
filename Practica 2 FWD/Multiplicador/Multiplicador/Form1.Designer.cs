namespace Multiplicador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 26);
            label1.Name = "label1";
            label1.Size = new Size(248, 25);
            label1.TabIndex = 0;
            label1.Text = "Tabla De Multiplicacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 80);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(239, 50);
            label2.TabIndex = 1;
            label2.Text = "Introduce el valor\r\nque quieres multiplicar";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(566, 80);
            label3.Name = "label3";
            label3.Size = new Size(250, 50);
            label3.TabIndex = 2;
            label3.Text = "Valor maximo por\r\nel cual sera multiplicado";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(628, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 34);
            textBox2.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(381, 184);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 229);
            listBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(758, 281);
            button1.Name = "button1";
            button1.Size = new Size(141, 29);
            button1.TabIndex = 6;
            button1.Text = "Multiplicar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(758, 316);
            button2.Name = "button2";
            button2.Size = new Size(141, 29);
            button2.TabIndex = 7;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(758, 351);
            button3.Name = "button3";
            button3.Size = new Size(141, 29);
            button3.TabIndex = 8;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(177, 224, 250);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 651);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Multiplicador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}

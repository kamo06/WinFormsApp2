namespace WinFormsApp2
{
    partial class Form4
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
            label1 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 25F);
            label1.Location = new Point(52, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 46);
            label1.TabIndex = 2;
            label1.Text = "Update Items";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(185, 266);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(247, 23);
            textBox4.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 303);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 19;
            label6.Text = "ITEM STATE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 269);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 20;
            label4.Text = "ITEM PRICE";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(185, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(247, 23);
            textBox3.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 234);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 17;
            label5.Text = "ITEM COLOR";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 23);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 157);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 15;
            label3.Text = "ITEM CODE";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 23);
            textBox2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 195);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 13;
            label2.Text = "ITEM NAME";
            // 
            // button1
            // 
            button1.Location = new Point(648, 380);
            button1.Name = "button1";
            button1.Size = new Size(101, 24);
            button1.TabIndex = 12;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(491, 154);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(258, 169);
            listBox1.TabIndex = 23;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(491, 127);
            label7.Name = "label7";
            label7.Size = new Size(148, 15);
            label7.TabIndex = 24;
            label7.Text = "PLEASE SELECT ITEM CODE";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(185, 300);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 25;
            comboBox1.Text = "未選択";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(listBox1);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox4;
        private Label label6;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private ListBox listBox1;
        private Label label7;
        private ComboBox comboBox1;
    }
}
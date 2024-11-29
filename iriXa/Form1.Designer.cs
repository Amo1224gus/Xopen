namespace iriXa
{
    partial class iriXa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iriXa));
            button1 = new Button();
            richTextBox = new RichTextBox();
            button2 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            label1 = new Label();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label2 = new Label();
            button8 = new Button();
            checkBox1 = new CheckBox();
            label3 = new Label();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button9 = new Button();
            label4 = new Label();
            button17 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.WindowFrame;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 374);
            button1.Name = "button1";
            button1.Size = new Size(55, 52);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox
            // 
            richTextBox.BackColor = SystemColors.ControlText;
            richTextBox.BorderStyle = BorderStyle.None;
            richTextBox.Cursor = Cursors.IBeam;
            richTextBox.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox.ForeColor = SystemColors.MenuBar;
            richTextBox.Location = new Point(12, 12);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(748, 353);
            richTextBox.TabIndex = 1;
            richTextBox.Text = "print(\"hi\")";
            richTextBox.ZoomFactor = 1.7F;
            richTextBox.TextChanged += richTextBox_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Desktop;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(73, 371);
            button2.Name = "button2";
            button2.Size = new Size(55, 52);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 429);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 47);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Cross;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(896, -2);
            button4.Margin = new Padding(1);
            button4.Name = "button4";
            button4.Size = new Size(54, 48);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 45);
            label1.TabIndex = 0;
            label1.Text = "iriXa";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Desktop;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(897, 371);
            button3.Name = "button3";
            button3.Size = new Size(55, 52);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(766, 12);
            button5.Name = "button5";
            button5.Size = new Size(185, 31);
            button5.TabIndex = 5;
            button5.Text = "Infinity Yeild";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(766, 49);
            button6.Name = "button6";
            button6.Size = new Size(185, 31);
            button6.TabIndex = 6;
            button6.Text = "Dex Explorer";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(766, 106);
            button7.Name = "button7";
            button7.Size = new Size(185, 31);
            button7.TabIndex = 7;
            button7.Text = "Fly REBORN";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(798, 83);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 6;
            label2.Text = "Otvajni`s scripts";
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button8.ForeColor = SystemColors.Control;
            button8.Location = new Point(766, 143);
            button8.Name = "button8";
            button8.Size = new Size(185, 31);
            button8.TabIndex = 8;
            button8.Text = "Freaky👅👅👅";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.InactiveCaptionText;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox1.ForeColor = SystemColors.Control;
            checkBox1.Location = new Point(134, 378);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(99, 38);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Auto inject \r\n[BETA]";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(798, 177);
            label3.Name = "label3";
            label3.Size = new Size(107, 40);
            label3.TabIndex = 11;
            label3.Text = "Walkspeed \r\n(LOOP, SOON)";
            label3.Click += label3_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Transparent;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button10.ForeColor = SystemColors.Control;
            button10.Location = new Point(239, 395);
            button10.Name = "button10";
            button10.Size = new Size(35, 31);
            button10.TabIndex = 13;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Transparent;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button11.ForeColor = SystemColors.Control;
            button11.Location = new Point(280, 395);
            button11.Name = "button11";
            button11.Size = new Size(62, 31);
            button11.TabIndex = 14;
            button11.Text = "Script1";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Transparent;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button12.ForeColor = SystemColors.Control;
            button12.Location = new Point(348, 395);
            button12.Name = "button12";
            button12.Size = new Size(62, 31);
            button12.TabIndex = 15;
            button12.Text = "Script2";
            button12.UseVisualStyleBackColor = false;
            button12.Visible = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Transparent;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button13.ForeColor = SystemColors.Control;
            button13.Location = new Point(416, 395);
            button13.Name = "button13";
            button13.Size = new Size(62, 31);
            button13.TabIndex = 16;
            button13.Text = "Script3";
            button13.UseVisualStyleBackColor = false;
            button13.Visible = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.Transparent;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button14.ForeColor = SystemColors.Control;
            button14.Location = new Point(484, 395);
            button14.Name = "button14";
            button14.Size = new Size(62, 31);
            button14.TabIndex = 17;
            button14.Text = "Script4";
            button14.UseVisualStyleBackColor = false;
            button14.Visible = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.Transparent;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button15.ForeColor = SystemColors.Control;
            button15.Location = new Point(552, 395);
            button15.Name = "button15";
            button15.Size = new Size(62, 31);
            button15.TabIndex = 18;
            button15.Text = "Script5";
            button15.UseVisualStyleBackColor = false;
            button15.Visible = false;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.Transparent;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button16.ForeColor = SystemColors.Control;
            button16.Location = new Point(620, 395);
            button16.Name = "button16";
            button16.Size = new Size(62, 31);
            button16.TabIndex = 19;
            button16.Text = "Script6";
            button16.UseVisualStyleBackColor = false;
            button16.Visible = false;
            button16.Click += button16_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Transparent;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.ForeColor = SystemColors.Control;
            button9.Location = new Point(688, 395);
            button9.Name = "button9";
            button9.Size = new Size(62, 31);
            button9.TabIndex = 20;
            button9.Text = "Script7";
            button9.UseVisualStyleBackColor = false;
            button9.Visible = false;
            button9.Click += button9_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(239, 371);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 21;
            label4.Text = "🔽Not released 🔽\r\n";
            // 
            // button17
            // 
            button17.BackColor = SystemColors.Desktop;
            button17.FlatStyle = FlatStyle.Popup;
            button17.ForeColor = SystemColors.ButtonHighlight;
            button17.Image = (Image)resources.GetObject("button17.Image");
            button17.Location = new Point(836, 371);
            button17.Name = "button17";
            button17.Size = new Size(55, 52);
            button17.TabIndex = 22;
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // iriXa
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(951, 476);
            Controls.Add(button17);
            Controls.Add(label4);
            Controls.Add(button9);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(button8);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(richTextBox);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "iriXa";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        public RichTextBox richTextBox;
        private Button button2;
        private Panel panel1;
        private Button button3;
        private Label label1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label2;
        private Button button8;
        private CheckBox checkBox1;
        private Label label3;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button9;
        private Label label4;
        private Button button17;
    }
}

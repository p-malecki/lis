﻿namespace SE_project
{
    partial class TechnicianView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicianView));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            label1 = new Label();
            splitContainer3 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            label15 = new Label();
            label16 = new Label();
            listBox1 = new ListBox();
            tabPage2 = new TabPage();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel3 = new Panel();
            label7 = new Label();
            splitContainer2 = new SplitContainer();
            button2 = new Button();
            groupBox2 = new GroupBox();
            textBox9 = new TextBox();
            label12 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tabPage3 = new TabPage();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            this.btnLogout = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-2, -2);
            tabControl1.Margin = new Padding(4, 4, 4, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1653, 1058);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(splitContainer3);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Margin = new Padding(4, 4, 4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 4, 4, 4);
            tabPage1.Size = new Size(1645, 1015);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "badania do akceptacji";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 4);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(732, 170);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 68);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(278, 30);
            label1.TabIndex = 0;
            label1.Text = "lista zamówień do akceptacji";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(4, 4);
            splitContainer3.Margin = new Padding(4, 4, 4, 4);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(this.btnLogout);
            splitContainer3.Panel2.Controls.Add(button4);
            splitContainer3.Panel2.Controls.Add(button3);
            splitContainer3.Panel2.Controls.Add(groupBox3);
            splitContainer3.Panel2.Controls.Add(listBox1);
            splitContainer3.Size = new Size(1637, 1007);
            splitContainer3.SplitterDistance = 723;
            splitContainer3.SplitterWidth = 6;
            splitContainer3.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 166);
            flowLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(728, 843);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(640, 322);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(198, 100);
            button4.TabIndex = 4;
            button4.Text = "odrzuć";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(402, 322);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(182, 100);
            button3.TabIndex = 3;
            button3.Text = "akceptuj";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox13);
            groupBox3.Controls.Add(textBox14);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label16);
            groupBox3.Location = new Point(380, 68);
            groupBox3.Margin = new Padding(4, 4, 4, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 4, 4, 4);
            groupBox3.Size = new Size(514, 194);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "akceptacja badań";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(279, 134);
            textBox13.Margin = new Padding(4, 4, 4, 4);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(224, 35);
            textBox13.TabIndex = 10;
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(279, 70);
            textBox14.Margin = new Padding(4, 4, 4, 4);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(224, 35);
            textBox14.TabIndex = 9;
            textBox14.TextChanged += textBox14_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(50, 138);
            label15.Name = "label15";
            label15.Size = new Size(72, 30);
            label15.TabIndex = 7;
            label15.Text = "nazwa";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(50, 75);
            label16.Name = "label16";
            label16.Size = new Size(34, 30);
            label16.TabIndex = 6;
            label16.Text = "ID";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Location = new Point(4, 4);
            listBox1.Margin = new Padding(4, 4, 4, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(368, 994);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(flowLayoutPanel3);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(splitContainer2);
            tabPage2.Location = new Point(4, 39);
            tabPage2.Margin = new Padding(4, 4, 4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 4, 4, 4);
            tabPage2.Size = new Size(1645, 1015);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "badania zaakceptowane";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(0, 171);
            flowLayoutPanel3.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(728, 843);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Location = new Point(0, 4);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(728, 165);
            panel3.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(236, 68);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(284, 30);
            label7.TabIndex = 0;
            label7.Text = "lista badań zaakceptowanych";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(4, 4);
            splitContainer2.Margin = new Padding(4, 4, 4, 4);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Paint += splitContainer2_Panel1_Paint;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(button2);
            splitContainer2.Panel2.Controls.Add(groupBox2);
            splitContainer2.Panel2.Paint += splitContainer2_Panel2_Paint;
            splitContainer2.Size = new Size(1637, 1007);
            splitContainer2.SplitterDistance = 726;
            splitContainer2.SplitterWidth = 6;
            splitContainer2.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(456, 676);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(214, 84);
            button2.TabIndex = 2;
            button2.Text = "zatwierdz";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(122, 92);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(549, 474);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "wprowadzanie danych";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(332, 352);
            textBox9.Margin = new Padding(4, 4, 4, 4);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(186, 35);
            textBox9.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(50, 282);
            label12.Name = "label12";
            label12.Size = new Size(147, 30);
            label12.TabIndex = 13;
            label12.Text = "górna granica ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(332, 278);
            textBox5.Margin = new Padding(4, 4, 4, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(186, 35);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(332, 200);
            textBox6.Margin = new Padding(4, 4, 4, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(186, 35);
            textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(332, 134);
            textBox7.Margin = new Padding(4, 4, 4, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(186, 35);
            textBox7.TabIndex = 10;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(332, 70);
            textBox8.Margin = new Padding(4, 4, 4, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(186, 35);
            textBox8.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 357);
            label8.Name = "label8";
            label8.Size = new Size(84, 30);
            label8.TabIndex = 8;
            label8.Text = "wartość";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(50, 138);
            label9.Name = "label9";
            label9.Size = new Size(72, 30);
            label9.TabIndex = 7;
            label9.Text = "nazwa";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(50, 75);
            label10.Name = "label10";
            label10.Size = new Size(34, 30);
            label10.TabIndex = 6;
            label10.Text = "ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(50, 210);
            label11.Name = "label11";
            label11.Size = new Size(139, 30);
            label11.TabIndex = 5;
            label11.Text = "dolna granica";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(splitContainer1);
            tabPage3.Location = new Point(4, 39);
            tabPage3.Margin = new Padding(4, 4, 4, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 4, 4, 4);
            tabPage3.Size = new Size(1645, 1015);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "historia badań";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(4, 4);
            splitContainer1.Margin = new Padding(4, 4, 4, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel2);
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1637, 1007);
            splitContainer1.SplitterDistance = 713;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(-10, 160);
            flowLayoutPanel2.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(728, 843);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-10, 0);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(728, 165);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 30);
            label2.TabIndex = 0;
            label2.Text = "lista historii badań";
            // 
            // button1
            // 
            button1.Location = new Point(542, 555);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(214, 84);
            button1.TabIndex = 1;
            button1.Text = "zatwierdz";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(207, 126);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(549, 390);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "edycja badania";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(332, 262);
            textBox4.Margin = new Padding(4, 4, 4, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 35);
            textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(332, 194);
            textBox3.Margin = new Padding(4, 4, 4, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 35);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(332, 129);
            textBox2.Margin = new Padding(4, 4, 4, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 35);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(332, 70);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 35);
            textBox1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 267);
            label6.Name = "label6";
            label6.Size = new Size(243, 30);
            label6.TabIndex = 8;
            label6.Text = "zaaktualizowana wartość";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 129);
            label4.Name = "label4";
            label4.Size = new Size(72, 30);
            label4.TabIndex = 7;
            label4.Text = "nazwa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 70);
            label3.Name = "label3";
            label3.Size = new Size(34, 30);
            label3.TabIndex = 6;
            label3.Text = "ID";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 194);
            label5.Name = "label5";
            label5.Size = new Size(158, 30);
            label5.TabIndex = 5;
            label5.Text = "obecna wartość";
            label5.Click += label5_Click;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new Point(735, 21);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new Size(131, 40);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Wyloguj";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += this.btnLogout_Click;
            // 
            // TechnicianView
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1648, 1054);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TechnicianView";
            Text = "LIS Technik";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage3.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private Label label2;
        private GroupBox groupBox1;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private SplitContainer splitContainer2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel3;
        private Label label7;
        private GroupBox groupBox2;
        private TextBox textBox9;
        private Label label12;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel1;
        private Label label1;
        private SplitContainer splitContainer3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private ListBox listBox1;
        private GroupBox groupBox3;
        private TextBox textBox13;
        private TextBox textBox14;
        private Label label15;
        private Label label16;
        private Button button4;
        private Button button3;
        private Button btnLogout;
    }
}
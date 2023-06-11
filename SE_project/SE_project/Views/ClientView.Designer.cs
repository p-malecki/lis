﻿namespace SE_project
{
    partial class ClientView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientView));
            tabPage3 = new TabPage();
            groupBox2 = new GroupBox();
            groupBox5 = new GroupBox();
            btnNewPassword = new Button();
            label19 = new Label();
            label20 = new Label();
            txtbNewPasswordConfirm = new TextBox();
            txtbNewPassword = new TextBox();
            groupBox4 = new GroupBox();
            btnNewLogin = new Button();
            label17 = new Label();
            label18 = new Label();
            txtbNewLoginConfirm = new TextBox();
            txtbNewLogin = new TextBox();
            groupBox3 = new GroupBox();
            btnNewEmail = new Button();
            label16 = new Label();
            label15 = new Label();
            txtbNewEmailConfirm = new TextBox();
            txtbNewEmail = new TextBox();
            groupBox1 = new GroupBox();
            btnUserAccountDelete = new Button();
            btnUserLogOut = new Button();
            lbAddress = new Label();
            lbBirthdate = new Label();
            lbPesel = new Label();
            lbSurname = new Label();
            lbName = new Label();
            lbEmail = new Label();
            lbLogin = new Label();
            lbConstLogin = new Label();
            lbConstAddress = new Label();
            lbConstBirthdate = new Label();
            lbConstPesel = new Label();
            lbConstSurname = new Label();
            lbConstName = new Label();
            lbConstEmail = new Label();
            tabPage2 = new TabPage();
            label1 = new Label();
            listbxMinutes = new ListBox();
            listbxHours = new ListBox();
            lbSum = new Label();
            lbConstSum = new Label();
            btnOrder = new Button();
            monthCalendar = new MonthCalendar();
            groupBox9 = new GroupBox();
            lbPrice = new Label();
            lbUnits = new Label();
            lbCategory = new Label();
            lbConstPrice = new Label();
            lbConstUnits = new Label();
            lbConstCategory = new Label();
            lbDescription = new Label();
            groupBox8 = new GroupBox();
            lbConstSearch = new Label();
            cbCategorySort = new ComboBox();
            lbConstCategories = new Label();
            txtbSearch = new TextBox();
            chlbTestsList = new CheckedListBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox7 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            groupBox6 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbPhoneNum = new Label();
            label3 = new Label();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Location = new Point(4, 39);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(1531, 975);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Konto";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(765, 8);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(756, 952);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Zmień dane";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnNewPassword);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(label20);
            groupBox5.Controls.Add(txtbNewPasswordConfirm);
            groupBox5.Controls.Add(txtbNewPassword);
            groupBox5.Location = new Point(9, 644);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(737, 294);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Hasło";
            // 
            // btnNewPassword
            // 
            btnNewPassword.Location = new Point(309, 216);
            btnNewPassword.Margin = new Padding(3, 4, 3, 4);
            btnNewPassword.Name = "btnNewPassword";
            btnNewPassword.Size = new Size(141, 44);
            btnNewPassword.TabIndex = 2;
            btnNewPassword.Text = "Zatwierdź";
            btnNewPassword.UseVisualStyleBackColor = true;
            btnNewPassword.Click += btnNewPassword_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(96, 140);
            label19.Name = "label19";
            label19.Size = new Size(246, 36);
            label19.TabIndex = 1;
            label19.Text = "Powtórz nowe hasło";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(96, 76);
            label20.Name = "label20";
            label20.Size = new Size(150, 36);
            label20.TabIndex = 1;
            label20.Text = "Nowe hasło";
            // 
            // txtbNewPasswordConfirm
            // 
            txtbNewPasswordConfirm.Location = new Point(375, 140);
            txtbNewPasswordConfirm.Margin = new Padding(3, 4, 3, 4);
            txtbNewPasswordConfirm.Name = "txtbNewPasswordConfirm";
            txtbNewPasswordConfirm.Size = new Size(292, 35);
            txtbNewPasswordConfirm.TabIndex = 0;
            // 
            // txtbNewPassword
            // 
            txtbNewPassword.Location = new Point(375, 78);
            txtbNewPassword.Margin = new Padding(3, 4, 3, 4);
            txtbNewPassword.Name = "txtbNewPassword";
            txtbNewPassword.Size = new Size(292, 35);
            txtbNewPassword.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnNewLogin);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(txtbNewLoginConfirm);
            groupBox4.Controls.Add(txtbNewLogin);
            groupBox4.Location = new Point(9, 342);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(737, 294);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Login";
            // 
            // btnNewLogin
            // 
            btnNewLogin.Location = new Point(309, 216);
            btnNewLogin.Margin = new Padding(3, 4, 3, 4);
            btnNewLogin.Name = "btnNewLogin";
            btnNewLogin.Size = new Size(141, 44);
            btnNewLogin.TabIndex = 2;
            btnNewLogin.Text = "Zatwierdź";
            btnNewLogin.UseVisualStyleBackColor = true;
            btnNewLogin.Click += btnNewLogin_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(96, 140);
            label17.Name = "label17";
            label17.Size = new Size(241, 36);
            label17.TabIndex = 1;
            label17.Text = "Powtórz nowy login";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(96, 76);
            label18.Name = "label18";
            label18.Size = new Size(145, 36);
            label18.TabIndex = 1;
            label18.Text = "Nowy login";
            // 
            // txtbNewLoginConfirm
            // 
            txtbNewLoginConfirm.Location = new Point(375, 140);
            txtbNewLoginConfirm.Margin = new Padding(3, 4, 3, 4);
            txtbNewLoginConfirm.Name = "txtbNewLoginConfirm";
            txtbNewLoginConfirm.Size = new Size(292, 35);
            txtbNewLoginConfirm.TabIndex = 0;
            // 
            // txtbNewLogin
            // 
            txtbNewLogin.Location = new Point(375, 78);
            txtbNewLogin.Margin = new Padding(3, 4, 3, 4);
            txtbNewLogin.Name = "txtbNewLogin";
            txtbNewLogin.Size = new Size(292, 35);
            txtbNewLogin.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnNewEmail);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(txtbNewEmailConfirm);
            groupBox3.Controls.Add(txtbNewEmail);
            groupBox3.Location = new Point(9, 40);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(737, 294);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "E-mail";
            // 
            // btnNewEmail
            // 
            btnNewEmail.Location = new Point(309, 216);
            btnNewEmail.Margin = new Padding(3, 4, 3, 4);
            btnNewEmail.Name = "btnNewEmail";
            btnNewEmail.Size = new Size(141, 44);
            btnNewEmail.TabIndex = 2;
            btnNewEmail.Text = "Zatwierdź";
            btnNewEmail.UseVisualStyleBackColor = true;
            btnNewEmail.Click += btnNewEmail_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(96, 140);
            label16.Name = "label16";
            label16.Size = new Size(246, 36);
            label16.TabIndex = 1;
            label16.Text = "Powtórz nowy adres";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(96, 76);
            label15.Name = "label15";
            label15.Size = new Size(228, 36);
            label15.TabIndex = 1;
            label15.Text = "Nowy adres e-mail";
            // 
            // txtbNewEmailConfirm
            // 
            txtbNewEmailConfirm.Location = new Point(375, 140);
            txtbNewEmailConfirm.Margin = new Padding(3, 4, 3, 4);
            txtbNewEmailConfirm.Name = "txtbNewEmailConfirm";
            txtbNewEmailConfirm.Size = new Size(292, 35);
            txtbNewEmailConfirm.TabIndex = 0;
            // 
            // txtbNewEmail
            // 
            txtbNewEmail.Location = new Point(375, 78);
            txtbNewEmail.Margin = new Padding(3, 4, 3, 4);
            txtbNewEmail.Name = "txtbNewEmail";
            txtbNewEmail.Size = new Size(292, 35);
            txtbNewEmail.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbPhoneNum);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnUserAccountDelete);
            groupBox1.Controls.Add(btnUserLogOut);
            groupBox1.Controls.Add(lbAddress);
            groupBox1.Controls.Add(lbBirthdate);
            groupBox1.Controls.Add(lbPesel);
            groupBox1.Controls.Add(lbSurname);
            groupBox1.Controls.Add(lbName);
            groupBox1.Controls.Add(lbEmail);
            groupBox1.Controls.Add(lbLogin);
            groupBox1.Controls.Add(lbConstLogin);
            groupBox1.Controls.Add(lbConstAddress);
            groupBox1.Controls.Add(lbConstBirthdate);
            groupBox1.Controls.Add(lbConstPesel);
            groupBox1.Controls.Add(lbConstSurname);
            groupBox1.Controls.Add(lbConstName);
            groupBox1.Controls.Add(lbConstEmail);
            groupBox1.Location = new Point(9, 8);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(746, 952);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Twoje dane";
            // 
            // btnUserAccountDelete
            // 
            btnUserAccountDelete.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnUserAccountDelete.Location = new Point(393, 788);
            btnUserAccountDelete.Margin = new Padding(3, 4, 3, 4);
            btnUserAccountDelete.Name = "btnUserAccountDelete";
            btnUserAccountDelete.Size = new Size(264, 82);
            btnUserAccountDelete.TabIndex = 3;
            btnUserAccountDelete.Text = "Usuń konto";
            btnUserAccountDelete.UseVisualStyleBackColor = true;
            btnUserAccountDelete.Click += btnUserAccountDelete_Click;
            // 
            // btnUserLogOut
            // 
            btnUserLogOut.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnUserLogOut.Location = new Point(50, 788);
            btnUserLogOut.Margin = new Padding(3, 4, 3, 4);
            btnUserLogOut.Name = "btnUserLogOut";
            btnUserLogOut.Size = new Size(264, 82);
            btnUserLogOut.TabIndex = 2;
            btnUserLogOut.Text = "Wyloguj się";
            btnUserLogOut.UseVisualStyleBackColor = true;
            btnUserLogOut.Click += btnUserLogOut_Click;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbAddress.Location = new Point(393, 531);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(103, 36);
            lbAddress.TabIndex = 1;
            lbAddress.Text = "address";
            // 
            // lbBirthdate
            // 
            lbBirthdate.AutoSize = true;
            lbBirthdate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbBirthdate.Location = new Point(324, 461);
            lbBirthdate.Name = "lbBirthdate";
            lbBirthdate.Size = new Size(120, 36);
            lbBirthdate.TabIndex = 1;
            lbBirthdate.Text = "birthdate";
            // 
            // lbPesel
            // 
            lbPesel.AutoSize = true;
            lbPesel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbPesel.Location = new Point(173, 385);
            lbPesel.Name = "lbPesel";
            lbPesel.Size = new Size(75, 36);
            lbPesel.TabIndex = 1;
            lbPesel.Text = "pesel";
            // 
            // lbSurname
            // 
            lbSurname.AutoSize = true;
            lbSurname.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbSurname.Location = new Point(233, 313);
            lbSurname.Name = "lbSurname";
            lbSurname.Size = new Size(114, 36);
            lbSurname.TabIndex = 1;
            lbSurname.Text = "surname";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(149, 242);
            lbName.Name = "lbName";
            lbName.Size = new Size(79, 36);
            lbName.TabIndex = 1;
            lbName.Text = "name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmail.Location = new Point(180, 178);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(76, 36);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "email";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbLogin.Location = new Point(170, 112);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(72, 36);
            lbLogin.TabIndex = 1;
            lbLogin.Text = "login";
            // 
            // lbConstLogin
            // 
            lbConstLogin.AutoSize = true;
            lbConstLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbConstLogin.Location = new Point(48, 104);
            lbConstLogin.Name = "lbConstLogin";
            lbConstLogin.Size = new Size(106, 45);
            lbConstLogin.TabIndex = 0;
            lbConstLogin.Text = "Login";
            // 
            // lbConstAddress
            // 
            lbConstAddress.AutoSize = true;
            lbConstAddress.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbConstAddress.Location = new Point(48, 523);
            lbConstAddress.Name = "lbConstAddress";
            lbConstAddress.Size = new Size(323, 45);
            lbConstAddress.TabIndex = 0;
            lbConstAddress.Text = "Adres zamieszkania";
            // 
            // lbConstBirthdate
            // 
            lbConstBirthdate.AutoSize = true;
            lbConstBirthdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbConstBirthdate.Location = new Point(50, 453);
            lbConstBirthdate.Name = "lbConstBirthdate";
            lbConstBirthdate.Size = new Size(256, 45);
            lbConstBirthdate.TabIndex = 0;
            lbConstBirthdate.Text = "Data urodzenia";
            // 
            // lbConstPesel
            // 
            lbConstPesel.AutoSize = true;
            lbConstPesel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbConstPesel.Location = new Point(50, 379);
            lbConstPesel.Name = "lbConstPesel";
            lbConstPesel.Size = new Size(112, 45);
            lbConstPesel.TabIndex = 0;
            lbConstPesel.Text = "PESEL";
            // 
            // lbConstSurname
            // 
            lbConstSurname.AutoSize = true;
            lbConstSurname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbConstSurname.Location = new Point(50, 305);
            lbConstSurname.Name = "lbConstSurname";
            lbConstSurname.Size = new Size(168, 45);
            lbConstSurname.TabIndex = 0;
            lbConstSurname.Text = "Nazwisko";
            // 
            // lbConstName
            // 
            lbConstName.AutoSize = true;
            lbConstName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbConstName.Location = new Point(50, 234);
            lbConstName.Name = "lbConstName";
            lbConstName.Size = new Size(87, 45);
            lbConstName.TabIndex = 0;
            lbConstName.Text = "Imię";
            // 
            // lbConstEmail
            // 
            lbConstEmail.AutoSize = true;
            lbConstEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbConstEmail.Location = new Point(48, 172);
            lbConstEmail.Name = "lbConstEmail";
            lbConstEmail.Size = new Size(117, 45);
            lbConstEmail.TabIndex = 0;
            lbConstEmail.Text = "E-mail";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(listbxMinutes);
            tabPage2.Controls.Add(listbxHours);
            tabPage2.Controls.Add(lbSum);
            tabPage2.Controls.Add(lbConstSum);
            tabPage2.Controls.Add(btnOrder);
            tabPage2.Controls.Add(monthCalendar);
            tabPage2.Controls.Add(groupBox9);
            tabPage2.Controls.Add(groupBox8);
            tabPage2.Location = new Point(4, 39);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1531, 975);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Zamawianie";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1317, 798);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 47);
            label1.TabIndex = 11;
            label1.Text = "ZŁ";
            // 
            // listbxMinutes
            // 
            listbxMinutes.FormattingEnabled = true;
            listbxMinutes.ItemHeight = 30;
            listbxMinutes.Location = new Point(1406, 488);
            listbxMinutes.Margin = new Padding(5, 6, 5, 6);
            listbxMinutes.Name = "listbxMinutes";
            listbxMinutes.Size = new Size(76, 274);
            listbxMinutes.TabIndex = 10;
            // 
            // listbxHours
            // 
            listbxHours.FormattingEnabled = true;
            listbxHours.ItemHeight = 30;
            listbxHours.Location = new Point(1317, 488);
            listbxHours.Margin = new Padding(5, 6, 5, 6);
            listbxHours.Name = "listbxHours";
            listbxHours.Size = new Size(76, 274);
            listbxHours.TabIndex = 9;
            // 
            // lbSum
            // 
            lbSum.AutoSize = true;
            lbSum.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbSum.Location = new Point(1157, 798);
            lbSum.Margin = new Padding(5, 0, 5, 0);
            lbSum.MaximumSize = new Size(171, 60);
            lbSum.Name = "lbSum";
            lbSum.Size = new Size(85, 47);
            lbSum.TabIndex = 8;
            lbSum.Text = "sum";
            // 
            // lbConstSum
            // 
            lbConstSum.AutoSize = true;
            lbConstSum.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbConstSum.Location = new Point(1049, 798);
            lbConstSum.Margin = new Padding(5, 0, 5, 0);
            lbConstSum.Name = "lbConstSum";
            lbConstSum.Size = new Size(116, 47);
            lbConstSum.TabIndex = 7;
            lbConstSum.Text = "Suma:";
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.Location = new Point(1003, 882);
            btnOrder.Margin = new Padding(3, 4, 3, 4);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(314, 68);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "Zamów badanie";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(837, 460);
            monthCalendar.Margin = new Padding(14);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 2;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(lbPrice);
            groupBox9.Controls.Add(lbUnits);
            groupBox9.Controls.Add(lbCategory);
            groupBox9.Controls.Add(lbConstPrice);
            groupBox9.Controls.Add(lbConstUnits);
            groupBox9.Controls.Add(lbConstCategory);
            groupBox9.Controls.Add(lbDescription);
            groupBox9.Location = new Point(780, 8);
            groupBox9.Margin = new Padding(3, 4, 3, 4);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(3, 4, 3, 4);
            groupBox9.Size = new Size(741, 434);
            groupBox9.TabIndex = 1;
            groupBox9.TabStop = false;
            groupBox9.Text = "Opis badania";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrice.Location = new Point(643, 364);
            lbPrice.Margin = new Padding(5, 0, 5, 0);
            lbPrice.MaximumSize = new Size(94, 0);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(0, 32);
            lbPrice.TabIndex = 6;
            // 
            // lbUnits
            // 
            lbUnits.AutoSize = true;
            lbUnits.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbUnits.Location = new Point(442, 364);
            lbUnits.Margin = new Padding(5, 0, 5, 0);
            lbUnits.MaximumSize = new Size(137, 0);
            lbUnits.Name = "lbUnits";
            lbUnits.Size = new Size(0, 32);
            lbUnits.TabIndex = 5;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbCategory.Location = new Point(139, 364);
            lbCategory.Margin = new Padding(5, 0, 5, 0);
            lbCategory.MaximumSize = new Size(189, 0);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(0, 32);
            lbCategory.TabIndex = 4;
            // 
            // lbConstPrice
            // 
            lbConstPrice.AutoSize = true;
            lbConstPrice.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbConstPrice.Location = new Point(571, 362);
            lbConstPrice.Margin = new Padding(5, 0, 5, 0);
            lbConstPrice.Name = "lbConstPrice";
            lbConstPrice.Size = new Size(80, 36);
            lbConstPrice.TabIndex = 3;
            lbConstPrice.Text = "Cena:";
            // 
            // lbConstUnits
            // 
            lbConstUnits.AutoSize = true;
            lbConstUnits.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbConstUnits.Location = new Point(317, 362);
            lbConstUnits.Margin = new Padding(5, 0, 5, 0);
            lbConstUnits.Name = "lbConstUnits";
            lbConstUnits.Size = new Size(133, 36);
            lbConstUnits.TabIndex = 2;
            lbConstUnits.Text = "Jednostki:";
            // 
            // lbConstCategory
            // 
            lbConstCategory.AutoSize = true;
            lbConstCategory.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbConstCategory.Location = new Point(9, 362);
            lbConstCategory.Margin = new Padding(5, 0, 5, 0);
            lbConstCategory.Name = "lbConstCategory";
            lbConstCategory.Size = new Size(137, 36);
            lbConstCategory.TabIndex = 1;
            lbConstCategory.Text = "Kategoria:";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbDescription.Location = new Point(9, 40);
            lbDescription.Margin = new Padding(5, 0, 5, 0);
            lbDescription.MaximumSize = new Size(729, 340);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(0, 32);
            lbDescription.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(lbConstSearch);
            groupBox8.Controls.Add(cbCategorySort);
            groupBox8.Controls.Add(lbConstCategories);
            groupBox8.Controls.Add(txtbSearch);
            groupBox8.Controls.Add(chlbTestsList);
            groupBox8.Location = new Point(9, 8);
            groupBox8.Margin = new Padding(3, 4, 3, 4);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(3, 4, 3, 4);
            groupBox8.Size = new Size(761, 952);
            groupBox8.TabIndex = 0;
            groupBox8.TabStop = false;
            groupBox8.Text = "Lista badań";
            // 
            // lbConstSearch
            // 
            lbConstSearch.AutoSize = true;
            lbConstSearch.Location = new Point(511, 836);
            lbConstSearch.Margin = new Padding(5, 0, 5, 0);
            lbConstSearch.Name = "lbConstSearch";
            lbConstSearch.Size = new Size(71, 30);
            lbConstSearch.TabIndex = 4;
            lbConstSearch.Text = "Szukaj";
            // 
            // cbCategorySort
            // 
            cbCategorySort.FormattingEnabled = true;
            cbCategorySort.Location = new Point(63, 874);
            cbCategorySort.Margin = new Padding(5, 6, 5, 6);
            cbCategorySort.Name = "cbCategorySort";
            cbCategorySort.Size = new Size(227, 38);
            cbCategorySort.TabIndex = 3;
            cbCategorySort.SelectionChangeCommitted += cbCategorySort_SelectionChangeCommitted;
            // 
            // lbConstCategories
            // 
            lbConstCategories.AutoSize = true;
            lbConstCategories.Location = new Point(86, 828);
            lbConstCategories.Margin = new Padding(5, 0, 5, 0);
            lbConstCategories.Name = "lbConstCategories";
            lbConstCategories.Size = new Size(186, 30);
            lbConstCategories.TabIndex = 2;
            lbConstCategories.Text = "Sortuj wg kategorii";
            // 
            // txtbSearch
            // 
            txtbSearch.Location = new Point(441, 874);
            txtbSearch.Margin = new Padding(5, 6, 5, 6);
            txtbSearch.Name = "txtbSearch";
            txtbSearch.Size = new Size(215, 35);
            txtbSearch.TabIndex = 1;
            txtbSearch.TextChanged += txtbSearch_TextChanged;
            // 
            // chlbTestsList
            // 
            chlbTestsList.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            chlbTestsList.FormattingEnabled = true;
            chlbTestsList.Location = new Point(9, 40);
            chlbTestsList.Margin = new Padding(3, 4, 3, 4);
            chlbTestsList.Name = "chlbTestsList";
            chlbTestsList.Size = new Size(741, 741);
            chlbTestsList.TabIndex = 0;
            chlbTestsList.ItemCheck += chlbTestsList_ItemCheck;
            chlbTestsList.Click += chlbTestsList_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(17, 18);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1539, 1018);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox7);
            tabPage1.Controls.Add(groupBox6);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1531, 975);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Przegląd badań";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(flowLayoutPanel2);
            groupBox7.Location = new Point(768, 8);
            groupBox7.Margin = new Padding(3, 4, 3, 4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 4, 3, 4);
            groupBox7.Size = new Size(753, 952);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "Zrealizowane";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(9, 42);
            flowLayoutPanel2.Margin = new Padding(5, 6, 5, 6);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(735, 900);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(flowLayoutPanel1);
            groupBox6.Location = new Point(9, 8);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(751, 952);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "Oczekujące";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(9, 42);
            flowLayoutPanel1.Margin = new Padding(5, 6, 5, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(734, 900);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lbPhoneNum
            // 
            lbPhoneNum.AutoSize = true;
            lbPhoneNum.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbPhoneNum.Location = new Point(395, 599);
            lbPhoneNum.Name = "lbPhoneNum";
            lbPhoneNum.Size = new Size(103, 36);
            lbPhoneNum.TabIndex = 5;
            lbPhoneNum.Text = "address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 591);
            label3.Name = "label3";
            label3.Size = new Size(245, 45);
            label3.TabIndex = 4;
            label3.Text = "Num. telefonu";
            // 
            // ClientView
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1575, 1054);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ClientView";
            Text = "LIS Klient";
            tabPage3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label lbConstBirthdate;
        private Label lbConstPesel;
        private Label lbConstSurname;
        private Label lbConstName;
        private Label lbConstEmail;
        private TabPage tabPage2;
        private TabControl tabControl1;
        private Label lbConstLogin;
        private Label lbConstAddress;
        private Label lbAddress;
        private Label lbBirthdate;
        private Label lbPesel;
        private Label lbSurname;
        private Label lbName;
        private Label lbEmail;
        private Label lbLogin;
        private GroupBox groupBox3;
        private Label label16;
        private Label label15;
        private TextBox txtbNewEmail;
        private Button btnNewEmail;
        private TextBox txtbNewEmailConfirm;
        private GroupBox groupBox5;
        private Button btnNewPassword;
        private Label label19;
        private Label label20;
        private TextBox txtbNewPasswordConfirm;
        private TextBox txtbNewPassword;
        private GroupBox groupBox4;
        private Button btnNewLogin;
        private Label label17;
        private Label label18;
        private TextBox txtbNewLoginConfirm;
        private TextBox txtbNewLogin;
        private TabPage tabPage1;
        private GroupBox groupBox7;
        private GroupBox groupBox6;
        private Button btnUserAccountDelete;
        private Button btnUserLogOut;
        private GroupBox groupBox9;
        private GroupBox groupBox8;
        private Button btnOrder;
        private MonthCalendar monthCalendar;
        private CheckedListBox chlbTestsList;
        private Label lbConstSearch;
        private ComboBox cbCategorySort;
        private Label lbConstCategories;
        private TextBox txtbSearch;
        private Label lbDescription;
        private Label lbConstCategory;
        private Label lbPrice;
        private Label lbUnits;
        private Label lbCategory;
        private Label lbConstPrice;
        private Label lbConstUnits;
        private Label lbConstSum;
        private Label lbSum;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListBox listbxMinutes;
        private ListBox listbxHours;
        private Label label1;
        private Label lbPhoneNum;
        private Label label3;
    }
}
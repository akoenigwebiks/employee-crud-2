﻿namespace employee_crud
{
    partial class Dashboard
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
            label_mainTitle = new Label();
            label_firstName = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label_nat = new Label();
            textBox3 = new TextBox();
            label_lastName = new Label();
            textBox4 = new TextBox();
            label_dob = new Label();
            textBox5 = new TextBox();
            label_id = new Label();
            groupBox_gender = new GroupBox();
            radioButton_genderMale = new RadioButton();
            radioButton_genderFemale = new RadioButton();
            groupBox_status = new GroupBox();
            radioButton_status_married = new RadioButton();
            radioButton_status_single = new RadioButton();
            radioButto_status_widowed = new RadioButton();
            radioButton_status_divorced = new RadioButton();
            pictureBox_face = new PictureBox();
            button_nav_next = new Button();
            button_navs_prev = new Button();
            textBox_AddressStreetNumber = new TextBox();
            label_AddressStreetNumber = new Label();
            textBox_AddressCity = new TextBox();
            label_AddressCity = new Label();
            textBox9 = new TextBox();
            label_phone_landline = new Label();
            textBox_AddressStreetName = new TextBox();
            label_AddressStreetName = new Label();
            textBox11 = new TextBox();
            label_phone_mobile = new Label();
            groupBox_phone = new GroupBox();
            groupBox_address = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button_curd_create = new Button();
            button_crud_update = new Button();
            button_crud_remove = new Button();
            groupBox_gender.SuspendLayout();
            groupBox_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_face).BeginInit();
            groupBox_phone.SuspendLayout();
            groupBox_address.SuspendLayout();
            SuspendLayout();
            // 
            // label_mainTitle
            // 
            label_mainTitle.AutoSize = true;
            label_mainTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_mainTitle.Location = new Point(285, 9);
            label_mainTitle.Name = "label_mainTitle";
            label_mainTitle.Size = new Size(223, 32);
            label_mainTitle.TabIndex = 0;
            label_mainTitle.Text = "מערכת ניהול עובדים";
            // 
            // label_firstName
            // 
            label_firstName.AutoSize = true;
            label_firstName.Location = new Point(367, 66);
            label_firstName.Name = "label_firstName";
            label_firstName.Size = new Size(53, 15);
            label_firstName.TabIndex = 1;
            label_firstName.Text = "שם פרטי";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(340, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label_nat
            // 
            label_nat.AutoSize = true;
            label_nat.Location = new Point(207, 66);
            label_nat.Name = "label_nat";
            label_nat.Size = new Size(68, 15);
            label_nat.TabIndex = 3;
            label_nat.Text = "תעודת זהות";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(481, 84);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // label_lastName
            // 
            label_lastName.AutoSize = true;
            label_lastName.Location = new Point(498, 66);
            label_lastName.Name = "label_lastName";
            label_lastName.Size = new Size(68, 15);
            label_lastName.TabIndex = 7;
            label_lastName.Text = "שם משפחה";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(625, 84);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            // 
            // label_dob
            // 
            label_dob.AutoSize = true;
            label_dob.Location = new Point(642, 66);
            label_dob.Name = "label_dob";
            label_dob.Size = new Size(68, 15);
            label_dob.TabIndex = 5;
            label_dob.Text = "תאריך לידה";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(77, 84);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(65, 23);
            textBox5.TabIndex = 10;
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(92, 66);
            label_id.Name = "label_id";
            label_id.Size = new Size(24, 15);
            label_id.TabIndex = 9;
            label_id.Text = "קוד";
            // 
            // groupBox_gender
            // 
            groupBox_gender.Controls.Add(radioButton_genderFemale);
            groupBox_gender.Controls.Add(radioButton_genderMale);
            groupBox_gender.Location = new Point(77, 145);
            groupBox_gender.Name = "groupBox_gender";
            groupBox_gender.Size = new Size(97, 113);
            groupBox_gender.TabIndex = 11;
            groupBox_gender.TabStop = false;
            groupBox_gender.Text = "מין";
            // 
            // radioButton_genderMale
            // 
            radioButton_genderMale.AutoSize = true;
            radioButton_genderMale.Checked = true;
            radioButton_genderMale.Location = new Point(39, 33);
            radioButton_genderMale.Name = "radioButton_genderMale";
            radioButton_genderMale.Size = new Size(43, 19);
            radioButton_genderMale.TabIndex = 0;
            radioButton_genderMale.TabStop = true;
            radioButton_genderMale.Text = "זכר";
            radioButton_genderMale.UseVisualStyleBackColor = true;
            radioButton_genderMale.CheckedChanged += radioButton_genderMale_CheckedChanged;
            // 
            // radioButton_genderFemale
            // 
            radioButton_genderFemale.AutoSize = true;
            radioButton_genderFemale.Location = new Point(29, 69);
            radioButton_genderFemale.Name = "radioButton_genderFemale";
            radioButton_genderFemale.Size = new Size(53, 19);
            radioButton_genderFemale.TabIndex = 1;
            radioButton_genderFemale.Text = "נקבה";
            radioButton_genderFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox_status
            // 
            groupBox_status.Controls.Add(radioButto_status_widowed);
            groupBox_status.Controls.Add(radioButton_status_divorced);
            groupBox_status.Controls.Add(radioButton_status_married);
            groupBox_status.Controls.Add(radioButton_status_single);
            groupBox_status.Location = new Point(207, 145);
            groupBox_status.Name = "groupBox_status";
            groupBox_status.Size = new Size(115, 188);
            groupBox_status.TabIndex = 12;
            groupBox_status.TabStop = false;
            groupBox_status.Text = "מצב משפחתי";
            // 
            // radioButton_status_married
            // 
            radioButton_status_married.AutoSize = true;
            radioButton_status_married.Location = new Point(58, 69);
            radioButton_status_married.Name = "radioButton_status_married";
            radioButton_status_married.Size = new Size(45, 19);
            radioButton_status_married.TabIndex = 1;
            radioButton_status_married.Text = "נשוי";
            radioButton_status_married.UseVisualStyleBackColor = true;
            // 
            // radioButton_status_single
            // 
            radioButton_status_single.AutoSize = true;
            radioButton_status_single.Checked = true;
            radioButton_status_single.Location = new Point(57, 33);
            radioButton_status_single.Name = "radioButton_status_single";
            radioButton_status_single.Size = new Size(46, 19);
            radioButton_status_single.TabIndex = 0;
            radioButton_status_single.Text = "רווק";
            radioButton_status_single.UseVisualStyleBackColor = true;
            // 
            // radioButto_status_widowed
            // 
            radioButto_status_widowed.AutoSize = true;
            radioButto_status_widowed.Location = new Point(52, 141);
            radioButto_status_widowed.Name = "radioButto_status_widowed";
            radioButto_status_widowed.Size = new Size(51, 19);
            radioButto_status_widowed.TabIndex = 3;
            radioButto_status_widowed.Text = "אלמן";
            radioButto_status_widowed.UseVisualStyleBackColor = true;
            // 
            // radioButton_status_divorced
            // 
            radioButton_status_divorced.AutoSize = true;
            radioButton_status_divorced.Location = new Point(54, 105);
            radioButton_status_divorced.Name = "radioButton_status_divorced";
            radioButton_status_divorced.Size = new Size(49, 19);
            radioButton_status_divorced.TabIndex = 2;
            radioButton_status_divorced.Text = "גרוש";
            radioButton_status_divorced.UseVisualStyleBackColor = true;
            // 
            // pictureBox_face
            // 
            pictureBox_face.Image = Properties.Resources._default;
            pictureBox_face.Location = new Point(625, 147);
            pictureBox_face.Name = "pictureBox_face";
            pictureBox_face.Size = new Size(100, 111);
            pictureBox_face.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_face.TabIndex = 13;
            pictureBox_face.TabStop = false;
            // 
            // button_nav_next
            // 
            button_nav_next.BackColor = Color.CornflowerBlue;
            button_nav_next.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button_nav_next.ForeColor = Color.Cornsilk;
            button_nav_next.Location = new Point(200, 432);
            button_nav_next.Name = "button_nav_next";
            button_nav_next.Size = new Size(185, 61);
            button_nav_next.TabIndex = 14;
            button_nav_next.Text = "הבא";
            button_nav_next.UseVisualStyleBackColor = false;
            // 
            // button_navs_prev
            // 
            button_navs_prev.BackColor = Color.CornflowerBlue;
            button_navs_prev.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button_navs_prev.ForeColor = Color.Cornsilk;
            button_navs_prev.Location = new Point(406, 432);
            button_navs_prev.Name = "button_navs_prev";
            button_navs_prev.Size = new Size(185, 61);
            button_navs_prev.TabIndex = 15;
            button_navs_prev.Text = "הקודם";
            button_navs_prev.UseVisualStyleBackColor = false;
            // 
            // textBox_AddressStreetNumber
            // 
            textBox_AddressStreetNumber.Location = new Point(25, 101);
            textBox_AddressStreetNumber.Name = "textBox_AddressStreetNumber";
            textBox_AddressStreetNumber.Size = new Size(100, 23);
            textBox_AddressStreetNumber.TabIndex = 23;
            // 
            // label_AddressStreetNumber
            // 
            label_AddressStreetNumber.AutoSize = true;
            label_AddressStreetNumber.Location = new Point(65, 83);
            label_AddressStreetNumber.Name = "label_AddressStreetNumber";
            label_AddressStreetNumber.Size = new Size(60, 15);
            label_AddressStreetNumber.TabIndex = 22;
            label_AddressStreetNumber.Text = "מספר בית";
            // 
            // textBox_AddressCity
            // 
            textBox_AddressCity.Location = new Point(25, 159);
            textBox_AddressCity.Name = "textBox_AddressCity";
            textBox_AddressCity.Size = new Size(100, 23);
            textBox_AddressCity.TabIndex = 21;
            // 
            // label_AddressCity
            // 
            label_AddressCity.AutoSize = true;
            label_AddressCity.Location = new Point(101, 141);
            label_AddressCity.Name = "label_AddressCity";
            label_AddressCity.Size = new Size(24, 15);
            label_AddressCity.TabIndex = 20;
            label_AddressCity.Text = "עיר";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(25, 101);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 19;
            // 
            // label_phone_landline
            // 
            label_phone_landline.AutoSize = true;
            label_phone_landline.Location = new Point(96, 83);
            label_phone_landline.Name = "label_phone_landline";
            label_phone_landline.Size = new Size(26, 15);
            label_phone_landline.TabIndex = 18;
            label_phone_landline.Text = "נייח";
            label_phone_landline.Click += label4_Click;
            // 
            // textBox_AddressStreetName
            // 
            textBox_AddressStreetName.Location = new Point(25, 47);
            textBox_AddressStreetName.Name = "textBox_AddressStreetName";
            textBox_AddressStreetName.Size = new Size(100, 23);
            textBox_AddressStreetName.TabIndex = 17;
            // 
            // label_AddressStreetName
            // 
            label_AddressStreetName.AutoSize = true;
            label_AddressStreetName.Location = new Point(93, 29);
            label_AddressStreetName.Name = "label_AddressStreetName";
            label_AddressStreetName.Size = new Size(32, 15);
            label_AddressStreetName.TabIndex = 16;
            label_AddressStreetName.Text = "רחוב";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(25, 47);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 27;
            // 
            // label_phone_mobile
            // 
            label_phone_mobile.AutoSize = true;
            label_phone_mobile.Location = new Point(86, 29);
            label_phone_mobile.Name = "label_phone_mobile";
            label_phone_mobile.Size = new Size(39, 15);
            label_phone_mobile.TabIndex = 26;
            label_phone_mobile.Text = "סלולר";
            // 
            // groupBox_phone
            // 
            groupBox_phone.Controls.Add(textBox11);
            groupBox_phone.Controls.Add(label_phone_mobile);
            groupBox_phone.Controls.Add(textBox9);
            groupBox_phone.Controls.Add(label_phone_landline);
            groupBox_phone.Location = new Point(340, 145);
            groupBox_phone.Name = "groupBox_phone";
            groupBox_phone.Size = new Size(131, 145);
            groupBox_phone.TabIndex = 12;
            groupBox_phone.TabStop = false;
            groupBox_phone.Text = "טלפון";
            // 
            // groupBox_address
            // 
            groupBox_address.Controls.Add(textBox_AddressStreetName);
            groupBox_address.Controls.Add(label_AddressStreetName);
            groupBox_address.Controls.Add(textBox_AddressCity);
            groupBox_address.Controls.Add(label_AddressCity);
            groupBox_address.Controls.Add(textBox_AddressStreetNumber);
            groupBox_address.Controls.Add(label_AddressStreetNumber);
            groupBox_address.Location = new Point(481, 145);
            groupBox_address.Name = "groupBox_address";
            groupBox_address.Size = new Size(131, 209);
            groupBox_address.TabIndex = 28;
            groupBox_address.TabStop = false;
            groupBox_address.Text = "כתובת";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(406, 514);
            button1.Name = "button1";
            button1.Size = new Size(185, 61);
            button1.TabIndex = 29;
            button1.Text = "חיפוש עובד לפי תז";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(200, 514);
            button2.Name = "button2";
            button2.Size = new Size(185, 61);
            button2.TabIndex = 30;
            button2.Text = "חיפוש עובד לפי קוד";
            button2.UseVisualStyleBackColor = false;
            // 
            // button_curd_create
            // 
            button_curd_create.BackColor = Color.DarkCyan;
            button_curd_create.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button_curd_create.ForeColor = Color.Cornsilk;
            button_curd_create.Location = new Point(256, 378);
            button_curd_create.Name = "button_curd_create";
            button_curd_create.Size = new Size(87, 37);
            button_curd_create.TabIndex = 31;
            button_curd_create.Text = "חדש";
            button_curd_create.UseVisualStyleBackColor = false;
            // 
            // button_crud_update
            // 
            button_crud_update.BackColor = Color.DarkKhaki;
            button_crud_update.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button_crud_update.ForeColor = Color.Cornsilk;
            button_crud_update.Location = new Point(349, 378);
            button_crud_update.Name = "button_crud_update";
            button_crud_update.Size = new Size(87, 37);
            button_crud_update.TabIndex = 32;
            button_crud_update.Text = "עדכון";
            button_crud_update.UseVisualStyleBackColor = false;
            // 
            // button_crud_remove
            // 
            button_crud_remove.BackColor = Color.DarkRed;
            button_crud_remove.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button_crud_remove.ForeColor = Color.Cornsilk;
            button_crud_remove.Location = new Point(442, 378);
            button_crud_remove.Name = "button_crud_remove";
            button_crud_remove.Size = new Size(87, 37);
            button_crud_remove.TabIndex = 33;
            button_crud_remove.Text = "מחיקה";
            button_crud_remove.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 596);
            Controls.Add(button_crud_remove);
            Controls.Add(button_crud_update);
            Controls.Add(button_curd_create);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox_address);
            Controls.Add(groupBox_phone);
            Controls.Add(button_navs_prev);
            Controls.Add(button_nav_next);
            Controls.Add(pictureBox_face);
            Controls.Add(groupBox_status);
            Controls.Add(groupBox_gender);
            Controls.Add(textBox5);
            Controls.Add(label_id);
            Controls.Add(textBox3);
            Controls.Add(label_lastName);
            Controls.Add(textBox4);
            Controls.Add(label_dob);
            Controls.Add(textBox2);
            Controls.Add(label_nat);
            Controls.Add(textBox1);
            Controls.Add(label_firstName);
            Controls.Add(label_mainTitle);
            Name = "Dashboard";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "מערכת ניהול עובדים";
            groupBox_gender.ResumeLayout(false);
            groupBox_gender.PerformLayout();
            groupBox_status.ResumeLayout(false);
            groupBox_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_face).EndInit();
            groupBox_phone.ResumeLayout(false);
            groupBox_phone.PerformLayout();
            groupBox_address.ResumeLayout(false);
            groupBox_address.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_mainTitle;
        private Label label_firstName;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label_nat;
        private TextBox textBox3;
        private Label label_lastName;
        private TextBox textBox4;
        private Label label_dob;
        private TextBox textBox5;
        private Label label_id;
        private GroupBox groupBox_gender;
        private RadioButton radioButton_genderFemale;
        private RadioButton radioButton_genderMale;
        private GroupBox groupBox_status;
        private RadioButton radioButton_status_married;
        private RadioButton radioButton_status_single;
        private RadioButton radioButto_status_widowed;
        private RadioButton radioButton_status_divorced;
        private PictureBox pictureBox_face;
        private Button button_nav_next;
        private Button button_navs_prev;
        private TextBox textBox_AddressStreetNumber;
        private Label label_AddressStreetNumber;
        private TextBox textBox_AddressCity;
        private Label label_AddressCity;
        private TextBox textBox9;
        private Label label_phone_landline;
        private TextBox textBox_AddressStreetName;
        private Label label_AddressStreetName;
        private TextBox textBox11;
        private Label label_phone_mobile;
        private GroupBox groupBox_phone;
        private GroupBox groupBox_address;
        private Button button1;
        private Button button2;
        private Button button_curd_create;
        private Button button_crud_update;
        private Button button_crud_remove;
    }
}
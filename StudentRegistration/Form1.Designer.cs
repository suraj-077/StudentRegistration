namespace StudentRegistration
{
    partial class student_registration_form
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.TextBox();
            this.dateofbirth = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this._male_radiobutton = new System.Windows.Forms.RadioButton();
            this._female_radiobutton = new System.Windows.Forms.RadioButton();
            this._other_radiobutton = new System.Windows.Forms.RadioButton();
            this.email = new System.Windows.Forms.Label();
            this._email = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this._address = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.phone_no = new System.Windows.Forms.TextBox();
            this.rank = new System.Windows.Forms.Label();
            this.poor = new System.Windows.Forms.CheckBox();
            this.good = new System.Windows.Forms.CheckBox();
            this.excellent = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.first_name_errorprovider = new System.Windows.Forms.ErrorProvider(this.components);
            this.last_name_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.email_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.phone_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.address_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.first_name_errorprovider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_name_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.address_errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration";
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(103, 68);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(101, 20);
            this.firstname.TabIndex = 3;
            this.firstname.Text = "First Name:";
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(264, 70);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(311, 20);
            this.first_name.TabIndex = 0;
            this.first_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.first_name_KeyPress);
            this.first_name.Leave += new System.EventHandler(this.first_name_Leave);
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(101, 146);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 20);
            this.lastname.TabIndex = 5;
            this.lastname.Text = "Last Name:";
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(265, 146);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(311, 20);
            this.last_name.TabIndex = 1;
            this.last_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.last_name_KeyPress);
            this.last_name.Leave += new System.EventHandler(this.last_name_Leave);
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSize = true;
            this.dateofbirth.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dateofbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirth.Location = new System.Drawing.Point(101, 221);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(120, 20);
            this.dateofbirth.TabIndex = 7;
            this.dateofbirth.Text = "Date Of Birth:";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(97, 615);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(74, 20);
            this.gender.TabIndex = 9;
            this.gender.Text = "Gender:";
            // 
            // _male_radiobutton
            // 
            this._male_radiobutton.AutoSize = true;
            this._male_radiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._male_radiobutton.Location = new System.Drawing.Point(265, 615);
            this._male_radiobutton.Name = "_male_radiobutton";
            this._male_radiobutton.Size = new System.Drawing.Size(62, 22);
            this._male_radiobutton.TabIndex = 10;
            this._male_radiobutton.TabStop = true;
            this._male_radiobutton.Text = "Male";
            this._male_radiobutton.UseVisualStyleBackColor = true;
            // 
            // _female_radiobutton
            // 
            this._female_radiobutton.AutoSize = true;
            this._female_radiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._female_radiobutton.Location = new System.Drawing.Point(372, 615);
            this._female_radiobutton.Name = "_female_radiobutton";
            this._female_radiobutton.Size = new System.Drawing.Size(86, 24);
            this._female_radiobutton.TabIndex = 11;
            this._female_radiobutton.TabStop = true;
            this._female_radiobutton.Text = "Female";
            this._female_radiobutton.UseVisualStyleBackColor = true;
            // 
            // _other_radiobutton
            // 
            this._other_radiobutton.AutoSize = true;
            this._other_radiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._other_radiobutton.Location = new System.Drawing.Point(503, 615);
            this._other_radiobutton.Name = "_other_radiobutton";
            this._other_radiobutton.Size = new System.Drawing.Size(72, 24);
            this._other_radiobutton.TabIndex = 12;
            this._other_radiobutton.TabStop = true;
            this._other_radiobutton.Text = "Other";
            this._other_radiobutton.UseVisualStyleBackColor = true;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(103, 292);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(58, 20);
            this.email.TabIndex = 13;
            this.email.Text = "Email:";
            // 
            // _email
            // 
            this._email.Location = new System.Drawing.Point(265, 294);
            this._email.Name = "_email";
            this._email.Size = new System.Drawing.Size(311, 20);
            this._email.TabIndex = 3;
            this._email.Leave += new System.EventHandler(this._email_Leave);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(97, 449);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(80, 20);
            this.address.TabIndex = 15;
            this.address.Text = "Address:";
            // 
            // _address
            // 
            this._address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._address.Location = new System.Drawing.Point(264, 429);
            this._address.Multiline = true;
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(311, 126);
            this._address.TabIndex = 5;
            this._address.Text = "Address should be between 5 to 50 letters";
            this._address.Enter += new System.EventHandler(this._address_Enter);
            this._address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._address_KeyPress);
            this._address.Leave += new System.EventHandler(this._address_Leave);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(97, 364);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(92, 20);
            this.phone.TabIndex = 17;
            this.phone.Text = "Phone No:";
            // 
            // phone_no
            // 
            this.phone_no.Location = new System.Drawing.Point(265, 366);
            this.phone_no.MaxLength = 10;
            this.phone_no.Name = "phone_no";
            this.phone_no.Size = new System.Drawing.Size(311, 20);
            this.phone_no.TabIndex = 4;
            this.phone_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_no_KeyPress);
            this.phone_no.Leave += new System.EventHandler(this.phone_no_Leave);
            // 
            // rank
            // 
            this.rank.AutoSize = true;
            this.rank.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank.Location = new System.Drawing.Point(108, 699);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(56, 20);
            this.rank.TabIndex = 19;
            this.rank.Text = "Rank:";
            // 
            // poor
            // 
            this.poor.AutoSize = true;
            this.poor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poor.Location = new System.Drawing.Point(264, 697);
            this.poor.Name = "poor";
            this.poor.Size = new System.Drawing.Size(64, 22);
            this.poor.TabIndex = 20;
            this.poor.Text = "Poor";
            this.poor.UseVisualStyleBackColor = true;
            //this.poor.CheckedChanged += new System.EventHandler(this.poor_CheckedChanged);
            // 
            // good
            // 
            this.good.AutoSize = true;
            this.good.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.good.Location = new System.Drawing.Point(372, 697);
            this.good.Name = "good";
            this.good.Size = new System.Drawing.Size(69, 22);
            this.good.TabIndex = 21;
            this.good.Text = "Good";
            this.good.UseVisualStyleBackColor = true;
            // 
            // excellent
            // 
            this.excellent.AutoSize = true;
            this.excellent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excellent.Location = new System.Drawing.Point(480, 697);
            this.excellent.Name = "excellent";
            this.excellent.Size = new System.Drawing.Size(95, 22);
            this.excellent.TabIndex = 22;
            this.excellent.Text = "Excellent";
            this.excellent.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(349, 771);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(92, 40);
            this.submit.TabIndex = 23;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // first_name_errorprovider
            // 
            this.first_name_errorprovider.ContainerControl = this;
            // 
            // last_name_errorProvider
            // 
            this.last_name_errorProvider.ContainerControl = this;
            // 
            // email_errorProvider
            // 
            this.email_errorProvider.ContainerControl = this;
            // 
            // phone_errorProvider
            // 
            this.phone_errorProvider.ContainerControl = this;
            // 
            // address_errorProvider
            // 
            this.address_errorProvider.ContainerControl = this;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(265, 220);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(311, 20);
            this.date.TabIndex = 24;
            // 
            // student_registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(770, 803);
            this.Controls.Add(this.date);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.excellent);
            this.Controls.Add(this.good);
            this.Controls.Add(this.poor);
            this.Controls.Add(this.rank);
            this.Controls.Add(this.phone_no);
            this.Controls.Add(this.phone);
            this.Controls.Add(this._address);
            this.Controls.Add(this.address);
            this.Controls.Add(this._email);
            this.Controls.Add(this.email);
            this.Controls.Add(this._other_radiobutton);
            this.Controls.Add(this._female_radiobutton);
            this.Controls.Add(this._male_radiobutton);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "student_registration_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.first_name_errorprovider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_name_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.address_errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Label dateofbirth;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.RadioButton _male_radiobutton;
        private System.Windows.Forms.RadioButton _female_radiobutton;
        private System.Windows.Forms.RadioButton _other_radiobutton;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox _email;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox _address;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox phone_no;
        private System.Windows.Forms.Label rank;
        private System.Windows.Forms.CheckBox poor;
        private System.Windows.Forms.CheckBox good;
        private System.Windows.Forms.CheckBox excellent;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ErrorProvider first_name_errorprovider;
        private System.Windows.Forms.ErrorProvider last_name_errorProvider;
        private System.Windows.Forms.ErrorProvider email_errorProvider;
        private System.Windows.Forms.ErrorProvider phone_errorProvider;
        private System.Windows.Forms.ErrorProvider address_errorProvider;
        private System.Windows.Forms.DateTimePicker date;
    }
}


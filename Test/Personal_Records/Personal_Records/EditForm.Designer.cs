namespace Personal_Records
{
    partial class EditForm
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
            this.labelError = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxUniqueInform3 = new System.Windows.Forms.TextBox();
            this.labelUniqInform3 = new System.Windows.Forms.Label();
            this.textBoxUniqueInform2 = new System.Windows.Forms.TextBox();
            this.labelUniqInform2 = new System.Windows.Forms.Label();
            this.textBoxUniqueInform1 = new System.Windows.Forms.TextBox();
            this.labelUniqInform1 = new System.Windows.Forms.Label();
            this.comboBoxJobTitle = new System.Windows.Forms.ComboBox();
            this.labelJobTitle = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(22, 296);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 41;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(477, 332);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 40);
            this.buttonCancel.TabIndex = 40;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(352, 332);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 40);
            this.buttonSave.TabIndex = 39;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxUniqueInform3
            // 
            this.textBoxUniqueInform3.Location = new System.Drawing.Point(305, 192);
            this.textBoxUniqueInform3.Name = "textBoxUniqueInform3";
            this.textBoxUniqueInform3.Size = new System.Drawing.Size(200, 20);
            this.textBoxUniqueInform3.TabIndex = 38;
            // 
            // labelUniqInform3
            // 
            this.labelUniqInform3.AutoSize = true;
            this.labelUniqInform3.Location = new System.Drawing.Point(302, 176);
            this.labelUniqInform3.Name = "labelUniqInform3";
            this.labelUniqInform3.Size = new System.Drawing.Size(71, 13);
            this.labelUniqInform3.TabIndex = 37;
            this.labelUniqInform3.Text = "Доп информ";
            // 
            // textBoxUniqueInform2
            // 
            this.textBoxUniqueInform2.Location = new System.Drawing.Point(305, 139);
            this.textBoxUniqueInform2.Name = "textBoxUniqueInform2";
            this.textBoxUniqueInform2.Size = new System.Drawing.Size(200, 20);
            this.textBoxUniqueInform2.TabIndex = 36;
            // 
            // labelUniqInform2
            // 
            this.labelUniqInform2.AutoSize = true;
            this.labelUniqInform2.Location = new System.Drawing.Point(302, 123);
            this.labelUniqInform2.Name = "labelUniqInform2";
            this.labelUniqInform2.Size = new System.Drawing.Size(71, 13);
            this.labelUniqInform2.TabIndex = 35;
            this.labelUniqInform2.Text = "Доп информ";
            // 
            // textBoxUniqueInform1
            // 
            this.textBoxUniqueInform1.Location = new System.Drawing.Point(305, 83);
            this.textBoxUniqueInform1.Name = "textBoxUniqueInform1";
            this.textBoxUniqueInform1.Size = new System.Drawing.Size(200, 20);
            this.textBoxUniqueInform1.TabIndex = 34;
            // 
            // labelUniqInform1
            // 
            this.labelUniqInform1.AutoSize = true;
            this.labelUniqInform1.Location = new System.Drawing.Point(302, 67);
            this.labelUniqInform1.Name = "labelUniqInform1";
            this.labelUniqInform1.Size = new System.Drawing.Size(71, 13);
            this.labelUniqInform1.TabIndex = 33;
            this.labelUniqInform1.Text = "Доп информ";
            // 
            // comboBoxJobTitle
            // 
            this.comboBoxJobTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJobTitle.FormattingEnabled = true;
            this.comboBoxJobTitle.Items.AddRange(new object[] {
            "Директор",
            "Руководитель подразделения",
            "Контролер",
            "Рабочий"});
            this.comboBoxJobTitle.Location = new System.Drawing.Point(305, 30);
            this.comboBoxJobTitle.Name = "comboBoxJobTitle";
            this.comboBoxJobTitle.Size = new System.Drawing.Size(200, 21);
            this.comboBoxJobTitle.TabIndex = 32;
            this.comboBoxJobTitle.SelectedIndexChanged += new System.EventHandler(this.comboBoxJobTitle_SelectedIndexChanged);
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.Location = new System.Drawing.Point(302, 14);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(65, 13);
            this.labelJobTitle.TabIndex = 31;
            this.labelJobTitle.Text = "Должность";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(23, 245);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(200, 21);
            this.comboBoxGender.TabIndex = 30;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(20, 229);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(27, 13);
            this.labelGender.TabIndex = 29;
            this.labelGender.Text = "Пол";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(23, 192);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 28;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(20, 176);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(86, 13);
            this.labelDateOfBirth.TabIndex = 27;
            this.labelDateOfBirth.Text = "Дата рождения";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(23, 139);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 20);
            this.textBoxLastName.TabIndex = 26;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(20, 123);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(54, 13);
            this.labelLastName.TabIndex = 25;
            this.labelLastName.Text = "Отчество";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(23, 83);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(200, 20);
            this.textBoxMiddleName.TabIndex = 24;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(20, 67);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(56, 13);
            this.labelMiddleName.TabIndex = 23;
            this.labelMiddleName.Text = "Фамилия";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(23, 31);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 20);
            this.textBoxFirstName.TabIndex = 22;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(20, 15);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 21;
            this.labelFirstName.Text = "Имя";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxUniqueInform3);
            this.Controls.Add(this.labelUniqInform3);
            this.Controls.Add(this.textBoxUniqueInform2);
            this.Controls.Add(this.labelUniqInform2);
            this.Controls.Add(this.textBoxUniqueInform1);
            this.Controls.Add(this.labelUniqInform1);
            this.Controls.Add(this.comboBoxJobTitle);
            this.Controls.Add(this.labelJobTitle);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxUniqueInform3;
        private System.Windows.Forms.Label labelUniqInform3;
        private System.Windows.Forms.TextBox textBoxUniqueInform2;
        private System.Windows.Forms.Label labelUniqInform2;
        private System.Windows.Forms.TextBox textBoxUniqueInform1;
        private System.Windows.Forms.Label labelUniqInform1;
        private System.Windows.Forms.ComboBox comboBoxJobTitle;
        private System.Windows.Forms.Label labelJobTitle;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
    }
}
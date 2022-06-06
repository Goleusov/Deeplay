namespace Personal_Records
{
    partial class ChangeJobTitleForm
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
            this.textBoxUniqueInform3 = new System.Windows.Forms.TextBox();
            this.labelUniqInform3 = new System.Windows.Forms.Label();
            this.textBoxUniqueInform2 = new System.Windows.Forms.TextBox();
            this.labelUniqInform2 = new System.Windows.Forms.Label();
            this.textBoxUniqueInform1 = new System.Windows.Forms.TextBox();
            this.labelUniqInform1 = new System.Windows.Forms.Label();
            this.comboBoxJobTitle = new System.Windows.Forms.ComboBox();
            this.labelJobTitle = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUniqueInform3
            // 
            this.textBoxUniqueInform3.Location = new System.Drawing.Point(25, 204);
            this.textBoxUniqueInform3.Name = "textBoxUniqueInform3";
            this.textBoxUniqueInform3.Size = new System.Drawing.Size(200, 20);
            this.textBoxUniqueInform3.TabIndex = 25;
            // 
            // labelUniqInform3
            // 
            this.labelUniqInform3.AutoSize = true;
            this.labelUniqInform3.Location = new System.Drawing.Point(22, 188);
            this.labelUniqInform3.Name = "labelUniqInform3";
            this.labelUniqInform3.Size = new System.Drawing.Size(71, 13);
            this.labelUniqInform3.TabIndex = 24;
            this.labelUniqInform3.Text = "Доп информ";
            // 
            // textBoxUniqueInform2
            // 
            this.textBoxUniqueInform2.Location = new System.Drawing.Point(25, 151);
            this.textBoxUniqueInform2.Name = "textBoxUniqueInform2";
            this.textBoxUniqueInform2.Size = new System.Drawing.Size(200, 20);
            this.textBoxUniqueInform2.TabIndex = 23;
            // 
            // labelUniqInform2
            // 
            this.labelUniqInform2.AutoSize = true;
            this.labelUniqInform2.Location = new System.Drawing.Point(22, 135);
            this.labelUniqInform2.Name = "labelUniqInform2";
            this.labelUniqInform2.Size = new System.Drawing.Size(71, 13);
            this.labelUniqInform2.TabIndex = 22;
            this.labelUniqInform2.Text = "Доп информ";
            // 
            // textBoxUniqueInform1
            // 
            this.textBoxUniqueInform1.Location = new System.Drawing.Point(25, 95);
            this.textBoxUniqueInform1.Name = "textBoxUniqueInform1";
            this.textBoxUniqueInform1.Size = new System.Drawing.Size(200, 20);
            this.textBoxUniqueInform1.TabIndex = 21;
            // 
            // labelUniqInform1
            // 
            this.labelUniqInform1.AutoSize = true;
            this.labelUniqInform1.Location = new System.Drawing.Point(22, 79);
            this.labelUniqInform1.Name = "labelUniqInform1";
            this.labelUniqInform1.Size = new System.Drawing.Size(71, 13);
            this.labelUniqInform1.TabIndex = 20;
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
            this.comboBoxJobTitle.Location = new System.Drawing.Point(25, 42);
            this.comboBoxJobTitle.Name = "comboBoxJobTitle";
            this.comboBoxJobTitle.Size = new System.Drawing.Size(200, 21);
            this.comboBoxJobTitle.TabIndex = 19;
            this.comboBoxJobTitle.SelectedIndexChanged += new System.EventHandler(this.comboBoxJobTitle_SelectedIndexChanged);
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.Location = new System.Drawing.Point(22, 26);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(65, 13);
            this.labelJobTitle.TabIndex = 18;
            this.labelJobTitle.Text = "Должность";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(313, 284);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 40);
            this.buttonCancel.TabIndex = 42;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(188, 284);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 40);
            this.buttonSave.TabIndex = 41;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(22, 247);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 43;
            // 
            // ChangeJobTitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 351);
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
            this.Name = "ChangeJobTitleForm";
            this.Text = "Изменить должность сотрудника";
            this.Load += new System.EventHandler(this.ChangeJobTitle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUniqueInform3;
        private System.Windows.Forms.Label labelUniqInform3;
        private System.Windows.Forms.TextBox textBoxUniqueInform2;
        private System.Windows.Forms.Label labelUniqInform2;
        private System.Windows.Forms.TextBox textBoxUniqueInform1;
        private System.Windows.Forms.Label labelUniqInform1;
        private System.Windows.Forms.ComboBox comboBoxJobTitle;
        private System.Windows.Forms.Label labelJobTitle;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelError;
    }
}
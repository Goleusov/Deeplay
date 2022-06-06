namespace Personal_Records
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonResetSearch = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.groupBoxTableActions = new System.Windows.Forms.GroupBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxFound = new System.Windows.Forms.ComboBox();
            this.radioButtonSubdivision = new System.Windows.Forms.RadioButton();
            this.radioButtonJobTitle = new System.Windows.Forms.RadioButton();
            this.buttonChangeJobTitle = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxTableActions.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView.Location = new System.Drawing.Point(13, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(853, 245);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(42, 51);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 39);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(199, 51);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 39);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonResetSearch
            // 
            this.buttonResetSearch.Location = new System.Drawing.Point(67, 111);
            this.buttonResetSearch.Name = "buttonResetSearch";
            this.buttonResetSearch.Size = new System.Drawing.Size(96, 39);
            this.buttonResetSearch.TabIndex = 3;
            this.buttonResetSearch.Text = "Сбросить";
            this.buttonResetSearch.UseVisualStyleBackColor = true;
            this.buttonResetSearch.Click += new System.EventHandler(this.buttonResetSearch_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(42, 137);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(96, 39);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // groupBoxTableActions
            // 
            this.groupBoxTableActions.Controls.Add(this.buttonChangeJobTitle);
            this.groupBoxTableActions.Controls.Add(this.buttonAdd);
            this.groupBoxTableActions.Controls.Add(this.buttonEdit);
            this.groupBoxTableActions.Controls.Add(this.buttonDelete);
            this.groupBoxTableActions.Location = new System.Drawing.Point(43, 275);
            this.groupBoxTableActions.Name = "groupBoxTableActions";
            this.groupBoxTableActions.Size = new System.Drawing.Size(344, 214);
            this.groupBoxTableActions.TabIndex = 5;
            this.groupBoxTableActions.TabStop = false;
            this.groupBoxTableActions.Text = "Действия с сотрудниками";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.labelSearch);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.buttonResetSearch);
            this.groupBoxSearch.Controls.Add(this.comboBoxFound);
            this.groupBoxSearch.Controls.Add(this.radioButtonSubdivision);
            this.groupBoxSearch.Controls.Add(this.radioButtonJobTitle);
            this.groupBoxSearch.Location = new System.Drawing.Point(469, 275);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(384, 214);
            this.groupBoxSearch.TabIndex = 6;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск с критериями";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.ForeColor = System.Drawing.Color.Red;
            this.labelSearch.Location = new System.Drawing.Point(17, 173);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(0, 13);
            this.labelSearch.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(245, 111);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(96, 39);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxFound
            // 
            this.comboBoxFound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFound.FormattingEnabled = true;
            this.comboBoxFound.Location = new System.Drawing.Point(174, 34);
            this.comboBoxFound.Name = "comboBoxFound";
            this.comboBoxFound.Size = new System.Drawing.Size(184, 21);
            this.comboBoxFound.TabIndex = 4;
            this.comboBoxFound.Click += new System.EventHandler(this.comboBoxFound_Click);
            // 
            // radioButtonSubdivision
            // 
            this.radioButtonSubdivision.AutoSize = true;
            this.radioButtonSubdivision.Location = new System.Drawing.Point(20, 73);
            this.radioButtonSubdivision.Name = "radioButtonSubdivision";
            this.radioButtonSubdivision.Size = new System.Drawing.Size(105, 17);
            this.radioButtonSubdivision.TabIndex = 3;
            this.radioButtonSubdivision.TabStop = true;
            this.radioButtonSubdivision.Text = "Подразделение";
            this.radioButtonSubdivision.UseVisualStyleBackColor = true;
            this.radioButtonSubdivision.CheckedChanged += new System.EventHandler(this.radioButtonSubdivision_CheckedChangedOrCliked);
            this.radioButtonSubdivision.Click += new System.EventHandler(this.radioButtonSubdivision_CheckedChangedOrCliked);
            // 
            // radioButtonJobTitle
            // 
            this.radioButtonJobTitle.AutoSize = true;
            this.radioButtonJobTitle.Location = new System.Drawing.Point(20, 35);
            this.radioButtonJobTitle.Name = "radioButtonJobTitle";
            this.radioButtonJobTitle.Size = new System.Drawing.Size(83, 17);
            this.radioButtonJobTitle.TabIndex = 2;
            this.radioButtonJobTitle.TabStop = true;
            this.radioButtonJobTitle.Text = "Должность";
            this.radioButtonJobTitle.UseVisualStyleBackColor = true;
            this.radioButtonJobTitle.CheckedChanged += new System.EventHandler(this.radioButtonJobTitle_CheckedChangedorCliked);
            this.radioButtonJobTitle.Click += new System.EventHandler(this.radioButtonJobTitle_CheckedChangedorCliked);
            // 
            // buttonChangeJobTitle
            // 
            this.buttonChangeJobTitle.Location = new System.Drawing.Point(199, 137);
            this.buttonChangeJobTitle.Name = "buttonChangeJobTitle";
            this.buttonChangeJobTitle.Size = new System.Drawing.Size(96, 39);
            this.buttonChangeJobTitle.TabIndex = 5;
            this.buttonChangeJobTitle.Text = "Изменить должность";
            this.buttonChangeJobTitle.UseVisualStyleBackColor = true;
            this.buttonChangeJobTitle.Click += new System.EventHandler(this.buttonChangeJobTitle_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ФИО";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата рождения";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Пол";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Должность";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 160;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Уникальная информация";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 510);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxTableActions);
            this.Controls.Add(this.dataGridView);
            this.Name = "MainForm";
            this.Text = "Учет персонала";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxTableActions.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonResetSearch;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.GroupBox groupBoxTableActions;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.RadioButton radioButtonSubdivision;
        private System.Windows.Forms.RadioButton radioButtonJobTitle;
        private System.Windows.Forms.ComboBox comboBoxFound;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonChangeJobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}


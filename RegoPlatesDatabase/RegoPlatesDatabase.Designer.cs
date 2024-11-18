namespace RegoPlatesDatabase
{
    partial class RegoPlatesDatabase
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FlaggedListBox = new System.Windows.Forms.ListBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.btn_LoadData = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.btnLinearSearch = new System.Windows.Forms.Button();
            this.btnBinarySearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBRegoPlate = new System.Windows.Forms.TextBox();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTag = new System.Windows.Forms.Button();
            this.RegoPlatesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Tag = "";
            this.openFileDialog1.Title = "Open File";
            // 
            // FlaggedListBox
            // 
            this.FlaggedListBox.FormattingEnabled = true;
            this.FlaggedListBox.Location = new System.Drawing.Point(376, 103);
            this.FlaggedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.FlaggedListBox.Name = "FlaggedListBox";
            this.FlaggedListBox.Size = new System.Drawing.Size(131, 238);
            this.FlaggedListBox.TabIndex = 2;
            this.FlaggedListBox.SelectedIndexChanged += new System.EventHandler(this.Flagged_SelectedIndexChanged);
            this.FlaggedListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FlaggedList_DoubleClick);
            // 
            // btn_LoadData
            // 
            this.btn_LoadData.Location = new System.Drawing.Point(178, 344);
            this.btn_LoadData.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LoadData.Name = "btn_LoadData";
            this.btn_LoadData.Size = new System.Drawing.Size(46, 21);
            this.btn_LoadData.TabIndex = 4;
            this.btn_LoadData.Text = "Load";
            this.btn_LoadData.UseVisualStyleBackColor = true;
            this.btn_LoadData.Click += new System.EventHandler(this.btn_LoadData_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(246, 131);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 48);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(246, 235);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 48);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(246, 183);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 48);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "-";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(46, 32);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(217, 20);
            this.SearchBar.TabIndex = 8;
            this.SearchBar.Text = "Search Bar";
            // 
            // btnLinearSearch
            // 
            this.btnLinearSearch.Location = new System.Drawing.Point(46, 56);
            this.btnLinearSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnLinearSearch.Name = "btnLinearSearch";
            this.btnLinearSearch.Size = new System.Drawing.Size(96, 23);
            this.btnLinearSearch.TabIndex = 9;
            this.btnLinearSearch.Text = "Linear Search";
            this.btnLinearSearch.UseVisualStyleBackColor = true;
            this.btnLinearSearch.Click += new System.EventHandler(this.btnLinearSearch_Click);
            // 
            // btnBinarySearch
            // 
            this.btnBinarySearch.Location = new System.Drawing.Point(146, 56);
            this.btnBinarySearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnBinarySearch.Name = "btnBinarySearch";
            this.btnBinarySearch.Size = new System.Drawing.Size(96, 23);
            this.btnBinarySearch.TabIndex = 10;
            this.btnBinarySearch.Text = "Binary Search";
            this.btnBinarySearch.UseVisualStyleBackColor = true;
            this.btnBinarySearch.Click += new System.EventHandler(this.btnBinarySearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(246, 287);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(56, 48);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Clear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Flagged";
            // 
            // TBRegoPlate
            // 
            this.TBRegoPlate.Location = new System.Drawing.Point(246, 103);
            this.TBRegoPlate.Name = "TBRegoPlate";
            this.TBRegoPlate.Size = new System.Drawing.Size(58, 20);
            this.TBRegoPlate.TabIndex = 13;
            this.TBRegoPlate.TextChanged += new System.EventHandler(this.TBRegoPlates_TextChanged);
            this.TBRegoPlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(12, 5);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(49, 22);
            this.btn_OpenFile.TabIndex = 14;
            this.btn_OpenFile.Text = "Open File";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(67, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 22);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTag
            // 
            this.btnTag.Location = new System.Drawing.Point(246, 344);
            this.btnTag.Margin = new System.Windows.Forms.Padding(2);
            this.btnTag.Name = "btnTag";
            this.btnTag.Size = new System.Drawing.Size(53, 29);
            this.btnTag.TabIndex = 16;
            this.btnTag.Text = "Tag";
            this.btnTag.UseVisualStyleBackColor = true;
            this.btnTag.Click += new System.EventHandler(this.btnTag_Click);
            // 
            // RegoPlatesList
            // 
            this.RegoPlatesList.FormattingEnabled = true;
            this.RegoPlatesList.Location = new System.Drawing.Point(48, 110);
            this.RegoPlatesList.Margin = new System.Windows.Forms.Padding(2);
            this.RegoPlatesList.Name = "RegoPlatesList";
            this.RegoPlatesList.Size = new System.Drawing.Size(186, 264);
            this.RegoPlatesList.TabIndex = 17;
            this.RegoPlatesList.SelectedIndexChanged += new System.EventHandler(this.RegoPlatesList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 435);
            this.Controls.Add(this.btn_LoadData);
            this.Controls.Add(this.RegoPlatesList);
            this.Controls.Add(this.btnTag);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.TBRegoPlate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBinarySearch);
            this.Controls.Add(this.btnLinearSearch);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.FlaggedListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegoPlatesDatabase";
            this.Text = "RegoPlatesDatabase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox FlaggedListBox;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button btn_LoadData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button btnLinearSearch;
        private System.Windows.Forms.Button btnBinarySearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBRegoPlate;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTag;
        private System.Windows.Forms.ListBox RegoPlatesList;
    }
}


namespace NQH_Application.MainFormChild {
    partial class RepositoryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RepositoryLabel = new System.Windows.Forms.Label();
            this.repositoryComboBox = new CustomControls.RJControls.RJComboBox();
            this.searchTextBox = new CustomControls.RJControls.RJTextBox();
            this.searchBtn = new CustomControls.RJControls.RJButton();
            this.itemsGridView = new NQH_Application.RoundedGridView();
            this.searchIconBtn = new CustomControls.RJControls.RJButton();
            this.clearBtn = new CustomControls.RJControls.RJButton();
            this.exportedItemBtn = new CustomControls.RJControls.RJButton();
            this.deleteAllBtn = new CustomControls.RJControls.RJButton();
            this.insertBtn = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RepositoryLabel
            // 
            this.RepositoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RepositoryLabel.AutoSize = true;
            this.RepositoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.RepositoryLabel.Location = new System.Drawing.Point(32, 674);
            this.RepositoryLabel.Name = "RepositoryLabel";
            this.RepositoryLabel.Size = new System.Drawing.Size(51, 25);
            this.RepositoryLabel.TabIndex = 4;
            this.RepositoryLabel.Text = "Kho:";
            // 
            // repositoryComboBox
            // 
            this.repositoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.repositoryComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.repositoryComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.repositoryComboBox.BorderSize = 1;
            this.repositoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.repositoryComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.repositoryComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.repositoryComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.repositoryComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.repositoryComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.repositoryComboBox.Location = new System.Drawing.Point(106, 667);
            this.repositoryComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.repositoryComboBox.Name = "repositoryComboBox";
            this.repositoryComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.repositoryComboBox.Size = new System.Drawing.Size(259, 36);
            this.repositoryComboBox.TabIndex = 6;
            this.repositoryComboBox.Texts = "Tất cả";
            this.repositoryComboBox.OnSelectedIndexChanged += new System.EventHandler(this.respositoryComboBox_OnSelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.searchTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.searchTextBox.BorderRadius = 12;
            this.searchTextBox.BorderSize = 2;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTextBox.Location = new System.Drawing.Point(181, 13);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Multiline = false;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searchTextBox.PasswordChar = false;
            this.searchTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchTextBox.PlaceholderText = "";
            this.searchTextBox.Size = new System.Drawing.Size(735, 36);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.Texts = "";
            this.searchTextBox.UnderlinedStyle = false;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.searchBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 12;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(12, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(150, 37);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Tìm vật phẩm";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // itemsGridView
            // 
            this.itemsGridView.AllowUserToAddRows = false;
            this.itemsGridView.AllowUserToDeleteRows = false;
            this.itemsGridView.AllowUserToResizeColumns = false;
            this.itemsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.itemsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.itemsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.itemsGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemsGridView.BorderRadius = 7;
            this.itemsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.itemsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.itemsGridView.ColumnHeadersHeight = 50;
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.itemsGridView.EnableHeadersVisualStyles = false;
            this.itemsGridView.GridColor = System.Drawing.Color.GhostWhite;
            this.itemsGridView.Location = new System.Drawing.Point(12, 66);
            this.itemsGridView.MultiSelect = false;
            this.itemsGridView.Name = "itemsGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.itemsGridView.RowHeadersVisible = false;
            this.itemsGridView.RowHeadersWidth = 51;
            this.itemsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.itemsGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.itemsGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.itemsGridView.RowTemplate.DividerHeight = 1;
            this.itemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsGridView.Size = new System.Drawing.Size(1176, 591);
            this.itemsGridView.TabIndex = 14;
            this.itemsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsGridView_CellClick);
            this.itemsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsGridView_CellContentClick);
            this.itemsGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.itemsGridView_CellFormatting);
            // 
            // searchIconBtn
            // 
            this.searchIconBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchIconBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.searchIconBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.searchIconBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchIconBtn.BorderRadius = 18;
            this.searchIconBtn.BorderSize = 0;
            this.searchIconBtn.FlatAppearance.BorderSize = 0;
            this.searchIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchIconBtn.ForeColor = System.Drawing.Color.White;
            this.searchIconBtn.Image = global::Final_Exam.Properties.Resources.icons8_search_30;
            this.searchIconBtn.Location = new System.Drawing.Point(864, 13);
            this.searchIconBtn.Name = "searchIconBtn";
            this.searchIconBtn.Size = new System.Drawing.Size(52, 36);
            this.searchIconBtn.TabIndex = 15;
            this.searchIconBtn.TextColor = System.Drawing.Color.White;
            this.searchIconBtn.UseVisualStyleBackColor = false;
            this.searchIconBtn.Click += new System.EventHandler(this.searchIconBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.clearBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.clearBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.clearBtn.BorderRadius = 12;
            this.clearBtn.BorderSize = 0;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Image = global::Final_Exam.Properties.Resources.icons8_clear_30;
            this.clearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.Location = new System.Drawing.Point(882, 669);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(114, 37);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Làm sạch";
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearBtn.TextColor = System.Drawing.Color.White;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Visible = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exportedItemBtn
            // 
            this.exportedItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportedItemBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.exportedItemBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.exportedItemBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.exportedItemBtn.BorderRadius = 12;
            this.exportedItemBtn.BorderSize = 0;
            this.exportedItemBtn.FlatAppearance.BorderSize = 0;
            this.exportedItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportedItemBtn.ForeColor = System.Drawing.Color.White;
            this.exportedItemBtn.Image = global::Final_Exam.Properties.Resources.icons8_trash_30;
            this.exportedItemBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportedItemBtn.Location = new System.Drawing.Point(1002, 669);
            this.exportedItemBtn.Name = "exportedItemBtn";
            this.exportedItemBtn.Size = new System.Drawing.Size(186, 37);
            this.exportedItemBtn.TabIndex = 3;
            this.exportedItemBtn.Text = "Vật phẩm xuất kho";
            this.exportedItemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportedItemBtn.TextColor = System.Drawing.Color.White;
            this.exportedItemBtn.UseVisualStyleBackColor = false;
            this.exportedItemBtn.Click += new System.EventHandler(this.exportedItemBtn_Click);
            // 
            // deleteAllBtn
            // 
            this.deleteAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAllBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteAllBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteAllBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteAllBtn.BorderRadius = 12;
            this.deleteAllBtn.BorderSize = 0;
            this.deleteAllBtn.FlatAppearance.BorderSize = 0;
            this.deleteAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAllBtn.ForeColor = System.Drawing.Color.White;
            this.deleteAllBtn.Image = global::Final_Exam.Properties.Resources.icons8_remove_30;
            this.deleteAllBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteAllBtn.Location = new System.Drawing.Point(939, 12);
            this.deleteAllBtn.Name = "deleteAllBtn";
            this.deleteAllBtn.Size = new System.Drawing.Size(80, 37);
            this.deleteAllBtn.TabIndex = 3;
            this.deleteAllBtn.Text = "Xóa";
            this.deleteAllBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteAllBtn.TextColor = System.Drawing.Color.White;
            this.deleteAllBtn.UseVisualStyleBackColor = false;
            this.deleteAllBtn.Click += new System.EventHandler(this.deleteAllBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insertBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.insertBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.insertBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.insertBtn.BorderRadius = 12;
            this.insertBtn.BorderSize = 0;
            this.insertBtn.FlatAppearance.BorderSize = 0;
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.ForeColor = System.Drawing.Color.White;
            this.insertBtn.Image = global::Final_Exam.Properties.Resources.icons8_create_30;
            this.insertBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertBtn.Location = new System.Drawing.Point(1025, 12);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(163, 37);
            this.insertBtn.TabIndex = 3;
            this.insertBtn.Text = "Thêm vật phẩm";
            this.insertBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.insertBtn.TextColor = System.Drawing.Color.White;
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.createButton_Click);
            // 
            // RepositoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.searchIconBtn);
            this.Controls.Add(this.itemsGridView);
            this.Controls.Add(this.repositoryComboBox);
            this.Controls.Add(this.RepositoryLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exportedItemBtn);
            this.Controls.Add(this.deleteAllBtn);
            this.Controls.Add(this.insertBtn);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RepositoryForm";
            this.Text = "RepositoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJButton insertBtn;
        private CustomControls.RJControls.RJButton searchBtn;
        private CustomControls.RJControls.RJTextBox searchTextBox;
        private System.Windows.Forms.Label RepositoryLabel;
        private CustomControls.RJControls.RJComboBox repositoryComboBox;
        private RoundedGridView itemsGridView;
        private CustomControls.RJControls.RJButton searchIconBtn;
        private CustomControls.RJControls.RJButton exportedItemBtn;
        private CustomControls.RJControls.RJButton clearBtn;
        private CustomControls.RJControls.RJButton deleteAllBtn;
    }
}
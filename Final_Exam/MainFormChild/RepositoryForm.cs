using BUS;
using DTO;
using Final_Exam.pop_upForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace NQH_Application.MainFormChild {
    public partial class RepositoryForm : Form {
        //Property
        private DTO_Item item;
        private DTO_DetailItem detailItem;
        private DTO_Repository repository;
        private int currentIndex;
        private bool isClearBtnClicked = false;
        private List<CheckBox> checkedBoxList;


        //Constructor
        public RepositoryForm() {
            InitializeComponent();
            updateGridView();
            setComboBox();
            //Check right of account 
            checkRight();
            formatGridView();
        }


        //-------------------------Methods about handle logic view-------------------------\\
        private void checkRight() {
            if (Account.getAccount().getRole() == "User") {
                insertBtn.Visible = false;
            }
        }

        //This functions is used to show all items in all repository
        private void updateGridView() {
            BUS_DetailItem busDetailItem = new BUS_DetailItem();
            DataTable dt = busDetailItem.showTable();
            formatTable(dt);
            busDetailItem.clear();
            itemsGridView.DataSource = dt;
            clearBtn.Visible = false;
        }

        //To show all item exported
        private void exportedItemBtn_Click(object sender, EventArgs e) {
            updateGridView("Xuất kho");
            clearBtn.Visible = true;
        }

        //To Show Data of Item Grid View
        private void updateGridView(string name) {
            repository = new DTO_Repository("", name);
            item = new DTO_Item();
            detailItem = new DTO_DetailItem("", 0, DateTime.Now, "", "", item, repository);
            BUS_DetailItem busDetailItem = new BUS_DetailItem(detailItem);
            DataTable dt = busDetailItem.showItemsInRepository();
            formatTable(dt);
            itemsGridView.DataSource = dt;
            clearBtn.Visible = false;
        }

        //This function is used to list all repository options into combobox
        private void setComboBox() {
            BUS_Repository busRepository = new BUS_Repository();
            DataTable dt = busRepository.showAllRepository();
            string name;
            foreach (DataRow row in dt.Rows) {
                name = row["Name"].ToString();
                repositoryComboBox.Items.Add(name);
            }
            repositoryComboBox.Items.Add("Tất cả");
        }

        //To show assigned property in data grid view (format table) 
        private void formatTable(DataTable dt) {
            dt.Columns[0].ColumnName = "Mã định danh";
            dt.Columns[1].ColumnName = "Vật phẩm";
            dt.Columns[2].ColumnName = "Phân loại";
            dt.Columns[3].ColumnName = "Đơn vị";
            dt.Columns[4].ColumnName = "Tình trạng";
            dt.Columns[5].ColumnName = "Kho";
            dt.Columns[6].ColumnName = "Số lượng";
            dt.Columns[7].ColumnName = "Ngày nhập";
            dt.Columns[8].ColumnName = "Ghi chú";
        }
        private void formatGridView() {
            // Tạo DataGridViewCheckBoxColumn
            GridViewCheckBoxColumn checkBoxColumn = new GridViewCheckBoxColumn();
            checkBoxColumn.DataPropertyName = "IsSelected"; // Tùy chỉnh nếu cần
            checkBoxColumn.ReadOnly = false; // Cho phép chỉnh sửa
            //// Thêm cột checkbox vào DataGridView
            itemsGridView.Columns.Insert(0, checkBoxColumn);
            itemsGridView.Columns[0].Width = 40;
            itemsGridView.Columns[2].Width = 200;
            itemsGridView.Columns[3].Width = 100;
            itemsGridView.Columns[4].Width = 80;
            itemsGridView.Columns[5].Width = 130;
            itemsGridView.Columns[7].Width = 100;
        }


        //-------------------------Handle Events-------------------------\\

        //Used to display information on searchTextBox
        private void itemsGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) return;
            currentIndex = e.RowIndex;
            DataGridViewRow currentRow = itemsGridView.Rows[currentIndex];
            searchTextBox.Texts = currentRow.Cells["Vật phẩm"].Value.ToString();
        }

        //Used to get data and display on Repository Combo box
        private void respositoryComboBox_OnSelectedIndexChanged(object sender, EventArgs e) {
            string repoName = repositoryComboBox.SelectedItem.ToString();
            if (repoName == "Tất cả")
                updateGridView();
            else
                updateGridView(repoName);
            searchTextBox.Texts = "";
        }

        //Used to show all data when user press Enter
        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                e.Handled = true;
                searchButton_Click(sender, e);
                repositoryComboBox.Texts = "Tất cả";
            }
        }

        //Used to search familiar name of item in database 
        private void searchButton_Click(object sender, EventArgs e) {
            //Fields
            string itemName = searchTextBox.Texts;
            string repositoryName = repositoryComboBox.Texts;

            //DTO
            repository = new DTO_Repository("", repositoryName == "Tất cả" ? "" : repositoryName);
            item = new DTO_Item(itemName);
            detailItem = new DTO_DetailItem("", 0, DateTime.Now, "", "", item, repository);
            //BUS
            BUS_DetailItem busDetailItem = new BUS_DetailItem(detailItem);
            //Data
            DataTable dt = busDetailItem.searchItem();
            formatTable(dt);
            itemsGridView.DataSource = dt;
            clearBtn.Visible = false;
        }

        //Used to show a small creating-form for create a new item and store it in somewhere repository
        private void createButton_Click(object sender, EventArgs e) {
            Form form = new DetailItemForm(this);
            form.ShowDialog();
            updateGridView();
        }

        private void deleteAllBtn_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn xóa tất cả các vật phẩm được chọn ?", "Xác nhận xóa", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            string detailItemId = "";
            foreach (DataGridViewRow row in itemsGridView.Rows) {
                // Kiểm tra xem hàng có phải là hàng mới không (hàng mới không có dữ liệu)
                if (row.IsNewRow) continue;

                // Lấy giá trị của checkbox
                bool isChecked = Convert.ToBoolean(row.Cells[0].Value);

                if (isChecked) {
                    detailItemId = row.Cells[1].Value.ToString();
                    new BUS_DetailItem(
                        new DTO_DetailItem(
                            detailItemId,0,DateTime.Now,"","",item,repository
                            )
                        ).removeDetailItem();
                }
            }
            MessageBox.Show("Đã xóa thành công");
            updateGridView();
        }

        //Used to format all property appearing in first column
        private void itemsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex == 1) // Cột đầu tiên
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Underline);
                e.CellStyle.ForeColor = Color.Green;
            }
        }

        //Used to open detail item form through detail item id on data grid view 
        private void itemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 1 && e.RowIndex != -1) {
                //Get data from items Grid View
                DataGridViewRow currentRow = itemsGridView.Rows[e.RowIndex];
                string detailItemId = currentRow.Cells[1].Value.ToString();
                string itemName = currentRow.Cells[2].Value.ToString();
                string type = currentRow.Cells[3].Value.ToString();
                string unit = currentRow.Cells[4].Value.ToString();
                string status = currentRow.Cells[5].Value.ToString();
                string repositoryName = currentRow.Cells[6].Value.ToString();
                int quantity = int.Parse(currentRow.Cells[7].Value.ToString());
                DateTime dateImport = DateTime.Parse(currentRow.Cells[8].Value.ToString());
                string note = currentRow.Cells[9].Value.ToString();

                //Init DTO
                item = new DTO_Item("", itemName, type, unit, "", "");
                repository = new DTO_Repository(repositoryName);
                detailItem = new DTO_DetailItem(detailItemId, quantity, DateTime.Now, status, note, item, repository);

                //Open a small form to show detail information of item and something like functionality
                Form form = new DetailItemForm(this, detailItem);
                form.ShowDialog();
                updateGridView();
            }
        }

        //Used to search Item through icon
        private void searchIconBtn_Click(object sender, EventArgs e) {
            searchButton_Click(sender, e);
        }

        //Used to clear all exported item
        private void clearBtn_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa hết các lịch sử ghi lại vật phẩm đã được xuất kho không?", "Xác nhận xóa lịch sử", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes) {
                new BUS_DetailItem(detailItem).clearExportedItem();
            }
            exportedItemBtn_Click(sender, e);
        }

        //Getter
        public DTO_Item getDTO_Item() { return this.item; }
        public DTO_DetailItem getDTO_DetailItem() { return this.detailItem; }
        public DTO_Repository GetDTO_Repository() { return this.repository; }

        #region GridViewCheckBoxColumn


        [System.Drawing.ToolboxBitmap(typeof(System.Windows.Forms.DataGridViewCheckBoxColumn))]
        public class GridViewCheckBoxColumn : DataGridViewCheckBoxColumn {
            #region Constructor

            public GridViewCheckBoxColumn() {
                DatagridViewCheckBoxHeaderCell datagridViewCheckBoxHeaderCell = new DatagridViewCheckBoxHeaderCell();

                this.HeaderCell = datagridViewCheckBoxHeaderCell;
                this.Width = 10;

                //this.DataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grvList_CellFormatting);
                datagridViewCheckBoxHeaderCell.OnCheckBoxClicked += new CheckBoxClickedHandler(datagridViewCheckBoxHeaderCell_OnCheckBoxClicked);

            }

            #endregion

            #region Methods

            void datagridViewCheckBoxHeaderCell_OnCheckBoxClicked(int columnIndex, bool state) {
                DataGridView.RefreshEdit();

                foreach (DataGridViewRow row in this.DataGridView.Rows) {
                    if (!row.Cells[columnIndex].ReadOnly) {
                        row.Cells[columnIndex].Value = state;
                    }
                }
                DataGridView.RefreshEdit();
            }



            #endregion
        }

        #endregion

        #region DatagridViewCheckBoxHeaderCell

        public delegate void CheckBoxClickedHandler(int columnIndex, bool state);
        public class DataGridViewCheckBoxHeaderCellEventArgs : EventArgs {
            bool _bChecked;
            public DataGridViewCheckBoxHeaderCellEventArgs(int columnIndex, bool bChecked) {
                _bChecked = bChecked;
            }
            public bool Checked {
                get { return _bChecked; }
            }
        }
        class DatagridViewCheckBoxHeaderCell : DataGridViewColumnHeaderCell {
            Point checkBoxLocation;
            Size checkBoxSize;
            bool _checked = false;
            Point _cellLocation = new Point();
            System.Windows.Forms.VisualStyles.CheckBoxState _cbState =
            System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal;
            public event CheckBoxClickedHandler OnCheckBoxClicked;

            public DatagridViewCheckBoxHeaderCell() {
            }

            protected override void Paint(System.Drawing.Graphics graphics,
            System.Drawing.Rectangle clipBounds,
            System.Drawing.Rectangle cellBounds,
            int rowIndex,
            DataGridViewElementStates dataGridViewElementState,
            object value,
            object formattedValue,
            string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts) {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                dataGridViewElementState, value,
                formattedValue, errorText, cellStyle,
                advancedBorderStyle, paintParts);
                Point p = new Point();
                Size s = CheckBoxRenderer.GetGlyphSize(graphics,
                System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
                p.X = cellBounds.Location.X +
                (cellBounds.Width / 2) - (s.Width / 2);
                p.Y = cellBounds.Location.Y +
                (cellBounds.Height / 2) - (s.Height / 2);
                _cellLocation = cellBounds.Location;
                checkBoxLocation = p;
                checkBoxSize = s;
                if (_checked)
                    _cbState = System.Windows.Forms.VisualStyles.
                    CheckBoxState.CheckedNormal;
                else
                    _cbState = System.Windows.Forms.VisualStyles.
                    CheckBoxState.UncheckedNormal;
                CheckBoxRenderer.DrawCheckBox
                (graphics, checkBoxLocation, _cbState);
            }

            protected override void OnMouseClick(DataGridViewCellMouseEventArgs e) {
                Point p = new Point(e.X + _cellLocation.X, e.Y + _cellLocation.Y);
                if (p.X >= checkBoxLocation.X && p.X <=
                checkBoxLocation.X + checkBoxSize.Width
                && p.Y >= checkBoxLocation.Y && p.Y <=
                checkBoxLocation.Y + checkBoxSize.Height) {
                    _checked = !_checked;
                    if (OnCheckBoxClicked != null) {
                        OnCheckBoxClicked(e.ColumnIndex, _checked);
                        this.DataGridView.InvalidateCell(this);
                    }
                }
                base.OnMouseClick(e);
            }

        }

        #endregion

        #region ColumnSelection

        class DataGridViewColumnSelector {
            // the DataGridView to which the DataGridViewColumnSelector is attached
            private DataGridView mDataGridView = null;
            // a CheckedListBox containing the column header text and checkboxes
            private CheckedListBox mCheckedListBox;
            // a ToolStripDropDown object used to show the popup
            private ToolStripDropDown mPopup;

            /// <summary>
            /// The max height of the popup
            /// </summary>
            public int MaxHeight = 300;
            /// <summary>
            /// The width of the popup
            /// </summary>
            public int Width = 200;

            /// <summary>
            /// Gets or sets the DataGridView to which the DataGridViewColumnSelector is attached
            /// </summary>
            public DataGridView DataGridView {
                get { return mDataGridView; }
                set {
                    // If any, remove handler from current DataGridView 
                    if (mDataGridView != null) mDataGridView.CellMouseClick -= new DataGridViewCellMouseEventHandler(mDataGridView_CellMouseClick);
                    // Set the new DataGridView
                    mDataGridView = value;
                    // Attach CellMouseClick handler to DataGridView
                    if (mDataGridView != null) mDataGridView.CellMouseClick += new DataGridViewCellMouseEventHandler(mDataGridView_CellMouseClick);
                }
            }

            // When user right-clicks the cell origin, it clears and fill the CheckedListBox with
            // columns header text. Then it shows the popup. 
            // In this way the CheckedListBox items are always refreshed to reflect changes occurred in 
            // DataGridView columns (column additions or name changes and so on).
            void mDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
                if (e.Button == MouseButtons.Right && e.RowIndex == -1 && e.ColumnIndex == 0) {
                    mCheckedListBox.Items.Clear();
                    foreach (DataGridViewColumn c in mDataGridView.Columns) {
                        mCheckedListBox.Items.Add(c.HeaderText, c.Visible);
                    }
                    int PreferredHeight = (mCheckedListBox.Items.Count * 16) + 7;
                    mCheckedListBox.Height = (PreferredHeight < MaxHeight) ? PreferredHeight : MaxHeight;
                    mCheckedListBox.Width = this.Width;
                    mPopup.Show(mDataGridView.PointToScreen(new Point(e.X, e.Y)));
                }
            }

            // The constructor creates an instance of CheckedListBox and ToolStripDropDown.
            // the CheckedListBox is hosted by ToolStripControlHost, which in turn is
            // added to ToolStripDropDown.
            public DataGridViewColumnSelector() {
                mCheckedListBox = new CheckedListBox();
                mCheckedListBox.CheckOnClick = true;
                mCheckedListBox.ItemCheck += new ItemCheckEventHandler(mCheckedListBox_ItemCheck);

                ToolStripControlHost mControlHost = new ToolStripControlHost(mCheckedListBox);
                mControlHost.Padding = Padding.Empty;
                mControlHost.Margin = Padding.Empty;
                mControlHost.AutoSize = false;

                mPopup = new ToolStripDropDown();
                mPopup.Padding = Padding.Empty;
                mPopup.Items.Add(mControlHost);
            }

            public DataGridViewColumnSelector(DataGridView dgv)
                : this() {
                this.DataGridView = dgv;
            }

            // When user checks / unchecks a checkbox, the related column visibility is 
            // switched.
            void mCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e) {
                mDataGridView.Columns[e.Index].Visible = (e.NewValue == CheckState.Checked);
            }
        }

        #endregion

    }
}

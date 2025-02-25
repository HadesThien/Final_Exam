using BUS;
using DTO;
using NQH_Application.MainFormChild;
using System;
using System.Data;
using System.Drawing;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace Final_Exam.pop_upForm {
    public partial class DetailItemForm : Form {
        //------------------------------------Fields------------------------------------\\
        private DTO_Item item;
        private DTO_DetailItem detailItem;
        private DTO_Repository repository;
        private string state;
        private bool isCreateForm;
        //------------------------------------Constructor------------------------------------\\
        public DetailItemForm() {
            InitializeComponent();
        }

        public DetailItemForm(RepositoryForm form) {
            InitializeComponent();
            tableLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            isCreateForm = true;
            init();
        }

        public DetailItemForm(RepositoryForm form,DTO_DetailItem detailItem) {
            InitializeComponent();
            isCreateForm = false;
            tableLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            //Setting some available data
            this.detailItem = detailItem;
            this.item = detailItem.getItem();
            this.repository = detailItem.getRepository();
            
            //Init BUS Object to call
            BUS_DetailItem busDetailItem = new BUS_DetailItem(detailItem);
            DataTable dt = busDetailItem.showAll();
            //use setter to add some other data
            detailItem.setDateImport(Convert.ToDateTime(dt.Rows[0][2].ToString()));
            item.setItemId(dt.Rows[0][7].ToString());
            item.setCompany(dt.Rows[0][11].ToString());
            item.setDescription(dt.Rows[0][12].ToString());
            repository.setRepositoryId(dt.Rows[0][13].ToString());
            repository.setRepositoryName(dt.Rows[0][14].ToString());
            
            init();
        }

        //------------------------------------Handle view------------------------------------\\


        //Used to draw line rounded table layout panel 
        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e) {
            TableLayoutPanel panel = sender as TableLayoutPanel;
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
                Color.Black, 0, ButtonBorderStyle.Solid,
                Color.Black, 0, ButtonBorderStyle.Solid,
                Color.Black, 0, ButtonBorderStyle.Solid,
                Color.Black, 0, ButtonBorderStyle.Solid);
        }

        //Used to create a list of options for repository combo box
        private void setComboBox() {
            repository = new DTO_Repository();  
            BUS_Repository busRepository = new BUS_Repository(repository);
            DataTable dt = busRepository.showAllRepository();
            string name;
            foreach (DataRow row in dt.Rows) {
                name = row["Name"].ToString();
                repositoryComboBox.Items.Add(name);
            }
        }
        //------------------------------------Handle Event------------------------------------\\

        //Used to close this form when the user click cancel button
        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        //Used to set visibility of some components and change state
        private void addBtn_Click(object sender, EventArgs e) {
            setComponent(false);
            movedQuanityUpDown.Visible = true;
            quantityLabel.Visible = true;
            moveLabel.Visible = false;
            moveComboBox.Visible=false;
            MessageBox.Show($"Bạn hãy thêm số lượng vật phẩm {item.getName()} vào kho {repository.getRepositoryName()}","THÊM VẬT PHẨM",MessageBoxButtons.OK,MessageBoxIcon.Information);

            //Execute
            state = "thêm vật phẩm";

        }

        //Used to export this item at this repository
        private void exportBtn_Click(object sender, EventArgs e) {
            setComponent(false);
            movedQuanityUpDown.Visible = true;
            quantityLabel.Visible = true;
            moveLabel.Visible = false;
            moveComboBox.Visible=false;
            MessageBox.Show($"Bạn hãy nhập số lượng vật phẩm {item.getName()} để xuất kho","XUẤT KHO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //Execute
            state = "xuất kho";
        }

        //Used to move this item from this repository to the new one with the amount of items
        private void moveBtn_Click(object sender, EventArgs e) {
            setComponent(false);
            quantityLabel.Visible = true;
            movedQuanityUpDown.Visible = true;
            moveLabel.Visible = true;
            moveComboBox.Visible = true;
            MessageBox.Show($"Bạn hãy nhập số lượng vật phẩm {item.getName()} và tên kho muốn chuyển tới","CHUYỂN KHO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            //Execute 
            state = "chuyển kho";
        }

        //Used to remove this item at only this repository
        private void removeDetailItemBtn_Click(object sender, EventArgs e) { 
            setComponent(false);
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa bản ghi vật phẩm ở kho này ?","XÓA BẢN GHI",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            removeDetailItem();
        }

        //Used to remove this item at all repository like its never existed
        private void removeBtn_Click(object sender, EventArgs e) {
            setComponent(false);
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa vật phẩm ở mọi kho?","XÓA VẬT PHẨM",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            removeItem();
        }

        //Used to be like a trigger to call a right functionality. It's a save button.
        private void saveBtn_Click(object sender, EventArgs e) {
            if (saveBtn.Text == "Tạo") {
                createItem();
            }
            else {
                save();
            }

        }
        
        //Used to update information of item 
        private void updateBtn_Click(object sender, EventArgs e) {
            nameItemTextBox.Enabled = !nameItemTextBox.Enabled;
            companyTextBox.Enabled = true;
            descriptionTextBox.Enabled = true;
            unitComboBox.Enabled = true;
            typeComboBox.Enabled = true;
            statusComboBox.Enabled = true;
            setComponent(true);
            movedQuanityUpDown.Visible = false;
            quantityLabel.Visible = false;
            moveComboBox.Visible = false;
            moveLabel.Visible = false;
            state = "chỉnh sửa";
        }

        //Used to set state
        private void noteTextBox_Leave(object sender, EventArgs e) {
            if(isCreateForm) return;
            setComponent(false);
            if(detailItem == null) return;
            if (detailItem.getNote() != noteTextBox.Text)  state = "thay đổi ghi chú";
        }

        private void DetailItemForm_Click(object sender, EventArgs e) {
            setComponent(false);
        }

        private void noteTextBox_Click(object sender, EventArgs e) {
            if (isCreateForm) return;
            setComponent(false);
        }
        
        //------------------------------------Functions in need------------------------------------\\
        
        //Used to move item to a new repository
        private void moveItem() {
            int quantity = Convert.ToInt32(movedQuanityUpDown.Value);
            string repositoryName = moveComboBox.Text;
            new BUS_DetailItem(detailItem).moveItemTo(quantity,repositoryName);
        }

        //Used to change status of the item which is "Xuất kho"
        private void exportItem() {
            detailItem.setQuantity(Convert.ToInt16(movedQuanityUpDown.Value));
            new BUS_DetailItem(detailItem).exportDetailItem();
        }

        //Used to update number of items when user add item from nowhere
        private void addItem() {
            new BUS_DetailItem(detailItem).increaseItem();
        }

        //Used to remove item in this only repository
        private void removeDetailItem() {
            new BUS_DetailItem(detailItem).removeDetailItem();
            MessageBox.Show("Xóa bản ghi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            this.Close();
        }
        
        //Used to remove this item at all repository
        private void removeItem() {
            new BUS_DetailItem(detailItem).removeItem();
            MessageBox.Show("Xóa vật phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            this.Close();
        }
        
        //Used to confirm creating a new item in database and store it 
        private void createItem() {
            string nameItem= nameItemTextBox.Texts;
            string itemId = itemIdLabel.Text;
            int quantity = Convert.ToInt32(quantityNumericUpDown.Value);
            string unit = unitComboBox.Texts;
            string type = typeComboBox.Texts;
            string company = companyTextBox.Texts;
            string description = descriptionTextBox.Texts;
            string repositoryName = repositoryComboBox.Texts;
            string note = noteTextBox.Text;
            //Create Item 
            item = new DTO_Item(itemId,nameItem,type,unit,company,description);
            BUS_Item busItem = new BUS_Item(item);   
            busItem.createItem();

            //Get id from repository
            repository = new DTO_Repository("", repositoryName);
            BUS_Repository busRepository = new BUS_Repository(repository);
            string repoId = busRepository.getRepoId();
            repository.setRepositoryId(repoId);

            //Store an Item in Repository
            detailItem = new DTO_DetailItem();
            BUS_DetailItem busDetailItem = new BUS_DetailItem(detailItem);
            string detailId = busDetailItem.generateId();
            detailItem = new DTO_DetailItem(detailId,quantity,DateTime.Now,"Mới",note,item,repository);
            busDetailItem = new BUS_DetailItem(detailItem);
            busDetailItem.storeItem();
            MessageBox.Show($"Thêm thành công","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
        
        //Used to update note of item in this repository
        private void updateItemNote() {
            detailItem.setNote(noteTextBox.Text);
            new BUS_DetailItem(detailItem).updateNoteItem();
        }
        
        //Used to update information of item 
        private void updateItem() {
            new BUS_DetailItem(
                new DTO_DetailItem(
                    detailItem.getDetailItemId(),
                    detailItem.getQuantity(),
                    detailItem.getDateImport(),
                    statusComboBox.Texts,
                    noteTextBox.Text,
                    new DTO_Item(
                        itemIdLabel.Text,
                        nameItemTextBox.Texts,
                        typeComboBox.Texts,
                        unitComboBox.Texts,
                        companyTextBox.Texts,
                        descriptionTextBox.Texts
                        ),
                    repository
                    )
                ).updateItem();
        }
       
        //Used to handle a save button logic 
        private void save() {
            if (state == null) return;
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn {state}","XÁC NHẬN",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                switch (state) {
                    case "thêm vật phẩm":
                        addItem();
                        break;

                    case "xuất kho":
                        exportItem();
                        break;

                    case "chuyển kho":
                        moveItem();
                        break;
                    case "thay đổi ghi chú":
                        updateItemNote();
                        break;
                    case "chỉnh sửa":
                        updateItem();
                        break;
                }
                MessageBox.Show($"{state} thành công","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
        }


        private void setComponent(bool turn) {
            nameItemTextBox.Enabled = turn;
            companyTextBox.Enabled = turn;
            descriptionTextBox.Enabled = turn;
            typeComboBox.Enabled = turn;
            unitComboBox.Enabled = turn;
            statusComboBox.Enabled = turn;
        }
       
        //Used to initialize something in need if it's a createing form or editing form 
        private void init() {
            if (isCreateForm) {
                moveBtn.Enabled = false;
                exportBtn.Enabled = false;
                removeBtn.Enabled = false;
                removeDetailItemBtn.Enabled = false;
                addBtn.Enabled = false;
                updateBtn.Enabled = false;
                saveBtn.Text = "Tạo";
                setComboBox();
                item = new DTO_Item("");
                BUS_Item busItem = new BUS_Item(item);
                itemIdLabel.Text = busItem.generateId();
                dateImportValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
                quantityNumericUpDown.Enabled = true;
                repositoryComboBox.Enabled = true;
            }
            else {
                //Handle enability of component
                itemIdLabel.Text = item.getItemId();
                saveBtn.Text = "Lưu";
                //Load data
                setComponent(false);
                movedQuanityUpDown.Maximum = detailItem.getQuantity();
                nameItemTextBox.Texts = item.getName();
                companyTextBox.Texts = item.getCompany();
                descriptionTextBox.Texts = item.getDescription();
                typeComboBox.Texts = item.getType();
                unitComboBox.Texts = item.getUnit();
                repositoryComboBox.Texts = repository.getRepositoryName(); 
                statusComboBox.Texts = detailItem.getStatus();
                quantityNumericUpDown.Value = detailItem.getQuantity();
                noteTextBox.Text = detailItem.getNote();
                dateImportValue.Text = detailItem.getDateImport().ToString("dd/MM/yyyy");
            }
        }
    }
}

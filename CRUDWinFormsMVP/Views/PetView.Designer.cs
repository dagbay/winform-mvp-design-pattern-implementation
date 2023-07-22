
namespace CRUDWinFormsMVP.Views
{
    partial class PetView
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
            this.lblPets = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePetList = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvPets = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchPet = new System.Windows.Forms.Label();
            this.tabPagePetDetail = new System.Windows.Forms.TabPage();
            this.lblPetID = new System.Windows.Forms.Label();
            this.txtPetID = new System.Windows.Forms.TextBox();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.lblPetName = new System.Windows.Forms.Label();
            this.txtPetColour = new System.Windows.Forms.TextBox();
            this.lblPetColour = new System.Windows.Forms.Label();
            this.txtPetType = new System.Windows.Forms.TextBox();
            this.lblPetType = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).BeginInit();
            this.tabPagePetDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPets
            // 
            this.lblPets.AutoSize = true;
            this.lblPets.Location = new System.Drawing.Point(13, 9);
            this.lblPets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPets.Name = "lblPets";
            this.lblPets.Size = new System.Drawing.Size(50, 20);
            this.lblPets.TabIndex = 0;
            this.lblPets.Text = "PETS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblPets);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 38);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePetList);
            this.tabControl1.Controls.Add(this.tabPagePetDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 654);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPagePetList
            // 
            this.tabPagePetList.Controls.Add(this.btnDelete);
            this.tabPagePetList.Controls.Add(this.btnEdit);
            this.tabPagePetList.Controls.Add(this.btnNew);
            this.tabPagePetList.Controls.Add(this.dgvPets);
            this.tabPagePetList.Controls.Add(this.btnSearch);
            this.tabPagePetList.Controls.Add(this.txtSearch);
            this.tabPagePetList.Controls.Add(this.lblSearchPet);
            this.tabPagePetList.Location = new System.Drawing.Point(4, 29);
            this.tabPagePetList.Name = "tabPagePetList";
            this.tabPagePetList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetList.Size = new System.Drawing.Size(1192, 621);
            this.tabPagePetList.TabIndex = 0;
            this.tabPagePetList.Text = "Pet List";
            this.tabPagePetList.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1083, 135);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 26);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(1083, 103);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 26);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(1083, 71);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(91, 26);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // dgvPets
            // 
            this.dgvPets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPets.Location = new System.Drawing.Point(43, 71);
            this.dgvPets.Name = "dgvPets";
            this.dgvPets.Size = new System.Drawing.Size(1034, 525);
            this.dgvPets.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(676, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(43, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(627, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearchPet
            // 
            this.lblSearchPet.AutoSize = true;
            this.lblSearchPet.Location = new System.Drawing.Point(39, 16);
            this.lblSearchPet.Name = "lblSearchPet";
            this.lblSearchPet.Size = new System.Drawing.Size(92, 20);
            this.lblSearchPet.TabIndex = 0;
            this.lblSearchPet.Text = "Search Pet:";
            // 
            // tabPagePetDetail
            // 
            this.tabPagePetDetail.Controls.Add(this.btnCancel);
            this.tabPagePetDetail.Controls.Add(this.btnSave);
            this.tabPagePetDetail.Controls.Add(this.txtPetType);
            this.tabPagePetDetail.Controls.Add(this.lblPetType);
            this.tabPagePetDetail.Controls.Add(this.txtPetColour);
            this.tabPagePetDetail.Controls.Add(this.lblPetColour);
            this.tabPagePetDetail.Controls.Add(this.txtPetName);
            this.tabPagePetDetail.Controls.Add(this.lblPetName);
            this.tabPagePetDetail.Controls.Add(this.txtPetID);
            this.tabPagePetDetail.Controls.Add(this.lblPetID);
            this.tabPagePetDetail.Location = new System.Drawing.Point(4, 29);
            this.tabPagePetDetail.Name = "tabPagePetDetail";
            this.tabPagePetDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetDetail.Size = new System.Drawing.Size(1192, 621);
            this.tabPagePetDetail.TabIndex = 1;
            this.tabPagePetDetail.Text = "Pet Detail";
            this.tabPagePetDetail.UseVisualStyleBackColor = true;
            // 
            // lblPetID
            // 
            this.lblPetID.AutoSize = true;
            this.lblPetID.Location = new System.Drawing.Point(59, 45);
            this.lblPetID.Name = "lblPetID";
            this.lblPetID.Size = new System.Drawing.Size(58, 20);
            this.lblPetID.TabIndex = 0;
            this.lblPetID.Text = "Pet ID:";
            // 
            // txtPetID
            // 
            this.txtPetID.BackColor = System.Drawing.Color.White;
            this.txtPetID.Location = new System.Drawing.Point(63, 68);
            this.txtPetID.Name = "txtPetID";
            this.txtPetID.Size = new System.Drawing.Size(172, 26);
            this.txtPetID.TabIndex = 1;
            // 
            // txtPetName
            // 
            this.txtPetName.BackColor = System.Drawing.Color.White;
            this.txtPetName.Location = new System.Drawing.Point(63, 139);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(172, 26);
            this.txtPetName.TabIndex = 3;
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Location = new System.Drawing.Point(59, 116);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(83, 20);
            this.lblPetName.TabIndex = 2;
            this.lblPetName.Text = "Pet Name:";
            // 
            // txtPetColour
            // 
            this.txtPetColour.BackColor = System.Drawing.Color.White;
            this.txtPetColour.Location = new System.Drawing.Point(63, 217);
            this.txtPetColour.Name = "txtPetColour";
            this.txtPetColour.Size = new System.Drawing.Size(362, 26);
            this.txtPetColour.TabIndex = 7;
            // 
            // lblPetColour
            // 
            this.lblPetColour.AutoSize = true;
            this.lblPetColour.Location = new System.Drawing.Point(59, 194);
            this.lblPetColour.Name = "lblPetColour";
            this.lblPetColour.Size = new System.Drawing.Size(87, 20);
            this.lblPetColour.TabIndex = 6;
            this.lblPetColour.Text = "Pet Colour:";
            // 
            // txtPetType
            // 
            this.txtPetType.BackColor = System.Drawing.Color.White;
            this.txtPetType.Location = new System.Drawing.Point(253, 139);
            this.txtPetType.Name = "txtPetType";
            this.txtPetType.Size = new System.Drawing.Size(172, 26);
            this.txtPetType.TabIndex = 9;
            // 
            // lblPetType
            // 
            this.lblPetType.AutoSize = true;
            this.lblPetType.Location = new System.Drawing.Point(249, 116);
            this.lblPetType.Name = "lblPetType";
            this.lblPetType.Size = new System.Drawing.Size(75, 20);
            this.lblPetType.TabIndex = 8;
            this.lblPetType.Text = "Pet Type:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(63, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 39);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(253, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 39);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // PetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PetView";
            this.Text = "Pet View";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePetList.ResumeLayout(false);
            this.tabPagePetList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).EndInit();
            this.tabPagePetDetail.ResumeLayout(false);
            this.tabPagePetDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePetList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchPet;
        private System.Windows.Forms.TabPage tabPagePetDetail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvPets;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPetType;
        private System.Windows.Forms.Label lblPetType;
        private System.Windows.Forms.TextBox txtPetColour;
        private System.Windows.Forms.Label lblPetColour;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.TextBox txtPetID;
        private System.Windows.Forms.Label lblPetID;
    }
}
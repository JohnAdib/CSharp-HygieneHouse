namespace HygieneHouse
{
    partial class frmSupplierold
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
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.txtSTel = new System.Windows.Forms.TextBox();
            this.txtSAddress = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.lblSTel = new System.Windows.Forms.Label();
            this.lblSAddress = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.NavigationGroup = new System.Windows.Forms.GroupBox();
            this.txtRecordPosition = new System.Windows.Forms.TextBox();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.btnMovePrevious = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.grdSupplier = new System.Windows.Forms.DataGridView();
            this.uC_MainMenu1 = new HygieneHouse.UC_MainMenu();
            this.MainGroup.SuspendLayout();
            this.NavigationGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.txtSTel);
            this.MainGroup.Controls.Add(this.txtSAddress);
            this.MainGroup.Controls.Add(this.txtSName);
            this.MainGroup.Controls.Add(this.lblSTel);
            this.MainGroup.Controls.Add(this.lblSAddress);
            this.MainGroup.Controls.Add(this.lblSName);
            this.MainGroup.Font = new System.Drawing.Font("B Koodak", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainGroup.Location = new System.Drawing.Point(13, 30);
            this.MainGroup.Margin = new System.Windows.Forms.Padding(4);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(4);
            this.MainGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainGroup.Size = new System.Drawing.Size(464, 212);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            this.MainGroup.Text = "شرکت پخش";
            // 
            // txtSTel
            // 
            this.txtSTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSTel.Location = new System.Drawing.Point(139, 179);
            this.txtSTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtSTel.Name = "txtSTel";
            this.txtSTel.Size = new System.Drawing.Size(205, 28);
            this.txtSTel.TabIndex = 5;
            // 
            // txtSAddress
            // 
            this.txtSAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSAddress.Location = new System.Drawing.Point(11, 82);
            this.txtSAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtSAddress.Multiline = true;
            this.txtSAddress.Name = "txtSAddress";
            this.txtSAddress.Size = new System.Drawing.Size(333, 89);
            this.txtSAddress.TabIndex = 4;
            // 
            // txtSName
            // 
            this.txtSName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSName.Location = new System.Drawing.Point(11, 46);
            this.txtSName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(333, 28);
            this.txtSName.TabIndex = 3;
            // 
            // lblSTel
            // 
            this.lblSTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSTel.AutoSize = true;
            this.lblSTel.Location = new System.Drawing.Point(383, 186);
            this.lblSTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTel.Name = "lblSTel";
            this.lblSTel.Size = new System.Drawing.Size(54, 21);
            this.lblSTel.TabIndex = 2;
            this.lblSTel.Text = "تلفن تماس";
            this.lblSTel.Click += new System.EventHandler(this.lblSTel_Click);
            // 
            // lblSAddress
            // 
            this.lblSAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSAddress.AutoSize = true;
            this.lblSAddress.Location = new System.Drawing.Point(400, 120);
            this.lblSAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSAddress.Name = "lblSAddress";
            this.lblSAddress.Size = new System.Drawing.Size(37, 21);
            this.lblSAddress.TabIndex = 1;
            this.lblSAddress.Text = "آدرس";
            this.lblSAddress.Click += new System.EventHandler(this.lblSAddress_Click);
            // 
            // lblSName
            // 
            this.lblSName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(386, 56);
            this.lblSName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(51, 21);
            this.lblSName.TabIndex = 0;
            this.lblSName.Text = "نام شرکت";
            this.lblSName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSName.Click += new System.EventHandler(this.lblSName_Click);
            // 
            // NavigationGroup
            // 
            this.NavigationGroup.Controls.Add(this.txtRecordPosition);
            this.NavigationGroup.Controls.Add(this.btnMoveLast);
            this.NavigationGroup.Controls.Add(this.btnMoveNext);
            this.NavigationGroup.Controls.Add(this.btnMovePrevious);
            this.NavigationGroup.Controls.Add(this.btnMoveFirst);
            this.NavigationGroup.Controls.Add(this.btnDelete);
            this.NavigationGroup.Controls.Add(this.btnUpdate);
            this.NavigationGroup.Controls.Add(this.btnAdd);
            this.NavigationGroup.Controls.Add(this.btnNew);
            this.NavigationGroup.Font = new System.Drawing.Font("B Koodak", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NavigationGroup.Location = new System.Drawing.Point(13, 250);
            this.NavigationGroup.Margin = new System.Windows.Forms.Padding(4);
            this.NavigationGroup.Name = "NavigationGroup";
            this.NavigationGroup.Padding = new System.Windows.Forms.Padding(4);
            this.NavigationGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NavigationGroup.Size = new System.Drawing.Size(464, 144);
            this.NavigationGroup.TabIndex = 1;
            this.NavigationGroup.TabStop = false;
            this.NavigationGroup.Text = "امکانات";
            // 
            // txtRecordPosition
            // 
            this.txtRecordPosition.Enabled = false;
            this.txtRecordPosition.Location = new System.Drawing.Point(163, 109);
            this.txtRecordPosition.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecordPosition.Name = "txtRecordPosition";
            this.txtRecordPosition.Size = new System.Drawing.Size(132, 28);
            this.txtRecordPosition.TabIndex = 8;
            this.txtRecordPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Location = new System.Drawing.Point(384, 109);
            this.btnMoveLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(67, 28);
            this.btnMoveLast.TabIndex = 7;
            this.btnMoveLast.Text = "آخرین";
            this.btnMoveLast.UseVisualStyleBackColor = true;
            this.btnMoveLast.Click += new System.EventHandler(this.btnMoveLast_Click);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Location = new System.Drawing.Point(307, 109);
            this.btnMoveNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.Size = new System.Drawing.Size(67, 28);
            this.btnMoveNext.TabIndex = 6;
            this.btnMoveNext.Text = "بعدی";
            this.btnMoveNext.UseVisualStyleBackColor = true;
            this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.Location = new System.Drawing.Point(85, 109);
            this.btnMovePrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.Size = new System.Drawing.Size(67, 28);
            this.btnMovePrevious.TabIndex = 5;
            this.btnMovePrevious.Text = "قبلی";
            this.btnMovePrevious.UseVisualStyleBackColor = true;
            this.btnMovePrevious.Click += new System.EventHandler(this.btnMovePrevious_Click);
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Location = new System.Drawing.Point(8, 109);
            this.btnMoveFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(67, 28);
            this.btnMoveFirst.TabIndex = 4;
            this.btnMoveFirst.Text = "اولین";
            this.btnMoveFirst.UseVisualStyleBackColor = true;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(355, 56);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(240, 56);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 31);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "به روز رسانی";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(125, 56);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "اضافه کردن";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(11, 56);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(96, 31);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جدید";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // grdSupplier
            // 
            this.grdSupplier.AllowUserToAddRows = false;
            this.grdSupplier.AllowUserToDeleteRows = false;
            this.grdSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdSupplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSupplier.ColumnHeadersVisible = false;
            this.grdSupplier.Location = new System.Drawing.Point(13, 402);
            this.grdSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.grdSupplier.Name = "grdSupplier";
            this.grdSupplier.ReadOnly = true;
            this.grdSupplier.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdSupplier.Size = new System.Drawing.Size(464, 78);
            this.grdSupplier.TabIndex = 2;
            // 
            // uC_MainMenu1
            // 
            this.uC_MainMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.uC_MainMenu1.Name = "uC_MainMenu1";
            this.uC_MainMenu1.Size = new System.Drawing.Size(505, 27);
            this.uC_MainMenu1.TabIndex = 3;
            // 
            // frmSupplierold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(505, 489);
            this.Controls.Add(this.uC_MainMenu1);
            this.Controls.Add(this.grdSupplier);
            this.Controls.Add(this.MainGroup);
            this.Controls.Add(this.NavigationGroup);
            this.Font = new System.Drawing.Font("B Koodak", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSupplierold";
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "شرکت های پخش ";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.AddSupplier_Load);
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.NavigationGroup.ResumeLayout(false);
            this.NavigationGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Label lblSTel;
        private System.Windows.Forms.Label lblSAddress;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.TextBox txtSTel;
        private System.Windows.Forms.TextBox txtSAddress;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.GroupBox NavigationGroup;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnMoveLast;
        private System.Windows.Forms.Button btnMoveNext;
        private System.Windows.Forms.Button btnMovePrevious;
        private System.Windows.Forms.Button btnMoveFirst;
        private System.Windows.Forms.TextBox txtRecordPosition;
        private System.Windows.Forms.DataGridView grdSupplier;
        private UC_MainMenu uC_MainMenu1;
    }
}
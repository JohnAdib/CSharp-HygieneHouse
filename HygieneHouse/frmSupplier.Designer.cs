namespace HygieneHouse
{
    partial class frmSupplier
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
            this.SupplierTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.txtSTel = new System.Windows.Forms.TextBox();
            this.txtSAddress = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.lblSTel = new System.Windows.Forms.Label();
            this.lblSAddress = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.lstData = new System.Windows.Forms.ListView();
            this.DName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NavigationGroup = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalNumber = new System.Windows.Forms.Label();
            this.txtCurrentPosition = new System.Windows.Forms.TextBox();
            this.pnlCurrentPosition = new System.Windows.Forms.Panel();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.btnMovePrevious = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.MainGroup.SuspendLayout();
            this.NavigationGroup.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.MainGroup.Location = new System.Drawing.Point(13, 13);
            this.MainGroup.Margin = new System.Windows.Forms.Padding(4);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(4);
            this.MainGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainGroup.Size = new System.Drawing.Size(296, 205);
            this.MainGroup.TabIndex = 1;
            this.MainGroup.TabStop = false;
            this.MainGroup.Text = "شرکت های پخش دارو";
            // 
            // txtSTel
            // 
            this.txtSTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSTel.Location = new System.Drawing.Point(24, 148);
            this.txtSTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtSTel.Name = "txtSTel";
            this.txtSTel.Size = new System.Drawing.Size(205, 28);
            this.txtSTel.TabIndex = 5;
            // 
            // txtSAddress
            // 
            this.txtSAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSAddress.Location = new System.Drawing.Point(24, 70);
            this.txtSAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtSAddress.Multiline = true;
            this.txtSAddress.Name = "txtSAddress";
            this.txtSAddress.Size = new System.Drawing.Size(205, 70);
            this.txtSAddress.TabIndex = 4;
            // 
            // txtSName
            // 
            this.txtSName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSName.Location = new System.Drawing.Point(24, 34);
            this.txtSName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(205, 28);
            this.txtSName.TabIndex = 3;
            // 
            // lblSTel
            // 
            this.lblSTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSTel.AutoSize = true;
            this.lblSTel.Location = new System.Drawing.Point(237, 155);
            this.lblSTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTel.Name = "lblSTel";
            this.lblSTel.Size = new System.Drawing.Size(54, 21);
            this.lblSTel.TabIndex = 2;
            this.lblSTel.Text = "تلفن تماس";
            // 
            // lblSAddress
            // 
            this.lblSAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSAddress.AutoSize = true;
            this.lblSAddress.Location = new System.Drawing.Point(251, 94);
            this.lblSAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSAddress.Name = "lblSAddress";
            this.lblSAddress.Size = new System.Drawing.Size(37, 21);
            this.lblSAddress.TabIndex = 1;
            this.lblSAddress.Text = "آدرس";
            // 
            // lblSName
            // 
            this.lblSName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(237, 37);
            this.lblSName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(51, 21);
            this.lblSName.TabIndex = 0;
            this.lblSName.Text = "نام شرکت";
            this.lblSName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstData
            // 
            this.lstData.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lstData.BackColor = System.Drawing.SystemColors.Control;
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DName});
            this.lstData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstData.FullRowSelect = true;
            this.lstData.HideSelection = false;
            this.lstData.Location = new System.Drawing.Point(414, 12);
            this.lstData.MultiSelect = false;
            this.lstData.Name = "lstData";
            this.lstData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstData.RightToLeftLayout = true;
            this.lstData.Size = new System.Drawing.Size(134, 335);
            this.lstData.TabIndex = 9;
            this.lstData.UseCompatibleStateImageBehavior = false;
            this.lstData.View = System.Windows.Forms.View.SmallIcon;
            this.lstData.SelectedIndexChanged += new System.EventHandler(this.lstData_SelectedIndexChanged);
            // 
            // DName
            // 
            this.DName.Text = "داروهای ثبت شده";
            this.DName.Width = 129;
            // 
            // NavigationGroup
            // 
            this.NavigationGroup.Controls.Add(this.panel1);
            this.NavigationGroup.Controls.Add(this.btnMoveLast);
            this.NavigationGroup.Controls.Add(this.btnMoveNext);
            this.NavigationGroup.Controls.Add(this.btnMovePrevious);
            this.NavigationGroup.Controls.Add(this.btnMoveFirst);
            this.NavigationGroup.Controls.Add(this.btnDelete);
            this.NavigationGroup.Controls.Add(this.btnUpdate);
            this.NavigationGroup.Controls.Add(this.btnAdd);
            this.NavigationGroup.Controls.Add(this.btnNew);
            this.NavigationGroup.Font = new System.Drawing.Font("B Koodak", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NavigationGroup.Location = new System.Drawing.Point(14, 228);
            this.NavigationGroup.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NavigationGroup.Name = "NavigationGroup";
            this.NavigationGroup.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NavigationGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NavigationGroup.Size = new System.Drawing.Size(392, 119);
            this.NavigationGroup.TabIndex = 10;
            this.NavigationGroup.TabStop = false;
            this.NavigationGroup.Text = "امکانات";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalNumber);
            this.panel1.Controls.Add(this.txtCurrentPosition);
            this.panel1.Controls.Add(this.pnlCurrentPosition);
            this.panel1.Location = new System.Drawing.Point(119, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 40);
            this.panel1.TabIndex = 11;
            // 
            // lblTotalNumber
            // 
            this.lblTotalNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalNumber.Location = new System.Drawing.Point(4, 9);
            this.lblTotalNumber.Name = "lblTotalNumber";
            this.lblTotalNumber.Size = new System.Drawing.Size(48, 21);
            this.lblTotalNumber.TabIndex = 9;
            this.lblTotalNumber.Text = "از x";
            this.lblTotalNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCurrentPosition
            // 
            this.txtCurrentPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentPosition.Location = new System.Drawing.Point(60, 6);
            this.txtCurrentPosition.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCurrentPosition.Name = "txtCurrentPosition";
            this.txtCurrentPosition.Size = new System.Drawing.Size(35, 28);
            this.txtCurrentPosition.TabIndex = 8;
            this.txtCurrentPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlCurrentPosition
            // 
            this.pnlCurrentPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCurrentPosition.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCurrentPosition.Location = new System.Drawing.Point(58, 4);
            this.pnlCurrentPosition.Name = "pnlCurrentPosition";
            this.pnlCurrentPosition.Size = new System.Drawing.Size(39, 33);
            this.pnlCurrentPosition.TabIndex = 10;
            this.pnlCurrentPosition.Visible = false;
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveLast.Location = new System.Drawing.Point(275, 63);
            this.btnMoveLast.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(48, 31);
            this.btnMoveLast.TabIndex = 7;
            this.btnMoveLast.Text = "آخرین";
            this.btnMoveLast.UseVisualStyleBackColor = true;
            this.btnMoveLast.Click += new System.EventHandler(this.btnMoveLast_Click);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveNext.Location = new System.Drawing.Point(219, 63);
            this.btnMoveNext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.Size = new System.Drawing.Size(48, 31);
            this.btnMoveNext.TabIndex = 6;
            this.btnMoveNext.Text = "بعدی";
            this.btnMoveNext.UseVisualStyleBackColor = true;
            this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMovePrevious.Location = new System.Drawing.Point(63, 63);
            this.btnMovePrevious.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.Size = new System.Drawing.Size(48, 31);
            this.btnMovePrevious.TabIndex = 5;
            this.btnMovePrevious.Text = "قبلی";
            this.btnMovePrevious.UseVisualStyleBackColor = true;
            this.btnMovePrevious.Click += new System.EventHandler(this.btnMovePrevious_Click);
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveFirst.Location = new System.Drawing.Point(7, 63);
            this.btnMoveFirst.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(48, 31);
            this.btnMoveFirst.TabIndex = 4;
            this.btnMoveFirst.Text = "اولین";
            this.btnMoveFirst.UseVisualStyleBackColor = true;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(255, 22);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(131, 22);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "به روز رسانی";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(7, 22);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "اضافه کردن";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(331, 64);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(48, 29);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جدید";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 371);
            this.Controls.Add(this.NavigationGroup);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.MainGroup);
            this.Font = new System.Drawing.Font("B Koodak", 8.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSupplier";
            this.Opacity = 0.97D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اطلاعات شرکت های پخش";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.NavigationGroup.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip SupplierTip;
        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.TextBox txtSTel;
        private System.Windows.Forms.TextBox txtSAddress;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label lblSTel;
        private System.Windows.Forms.Label lblSAddress;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.ListView lstData;
        private System.Windows.Forms.ColumnHeader DName;
        private System.Windows.Forms.GroupBox NavigationGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalNumber;
        private System.Windows.Forms.TextBox txtCurrentPosition;
        private System.Windows.Forms.Panel pnlCurrentPosition;
        private System.Windows.Forms.Button btnMoveLast;
        private System.Windows.Forms.Button btnMoveNext;
        private System.Windows.Forms.Button btnMovePrevious;
        private System.Windows.Forms.Button btnMoveFirst;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
    }
}
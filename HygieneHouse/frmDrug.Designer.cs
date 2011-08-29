namespace HygieneHouse
{
    partial class frmDrug
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
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.txtDType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExpDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lstspec = new System.Windows.Forms.CheckedListBox();
            this.lsttype = new System.Windows.Forms.CheckedListBox();
            this.lstdaro = new System.Windows.Forms.CheckedListBox();
            this.txtDPrice = new System.Windows.Forms.TextBox();
            this.txtDValue = new System.Windows.Forms.TextBox();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.lblDPrice = new System.Windows.Forms.Label();
            this.lblDValue = new System.Windows.Forms.Label();
            this.lbDName = new System.Windows.Forms.Label();
            this.txtCurrentPosition = new System.Windows.Forms.TextBox();
            this.NavigationGroup = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalNumber = new System.Windows.Forms.Label();
            this.pnlCurrentPosition = new System.Windows.Forms.Panel();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.btnMovePrevious = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListView();
            this.DName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrugTip = new System.Windows.Forms.ToolTip(this.components);
            this.uC_MainMenu1 = new HygieneHouse.UC_MainMenu();
            this.MainGroup.SuspendLayout();
            this.NavigationGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.txtDType);
            this.MainGroup.Controls.Add(this.label1);
            this.MainGroup.Controls.Add(this.txtExpDate);
            this.MainGroup.Controls.Add(this.lblExpDate);
            this.MainGroup.Controls.Add(this.lstspec);
            this.MainGroup.Controls.Add(this.lsttype);
            this.MainGroup.Controls.Add(this.lstdaro);
            this.MainGroup.Controls.Add(this.txtDPrice);
            this.MainGroup.Controls.Add(this.txtDValue);
            this.MainGroup.Controls.Add(this.txtDName);
            this.MainGroup.Controls.Add(this.lblDPrice);
            this.MainGroup.Controls.Add(this.lblDValue);
            this.MainGroup.Controls.Add(this.lbDName);
            this.MainGroup.Font = new System.Drawing.Font("B Koodak", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainGroup.Location = new System.Drawing.Point(14, 36);
            this.MainGroup.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MainGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainGroup.Size = new System.Drawing.Size(392, 282);
            this.MainGroup.TabIndex = 3;
            this.MainGroup.TabStop = false;
            this.MainGroup.Text = "داروها";
            // 
            // txtDType
            // 
            this.txtDType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDType.FormattingEnabled = true;
            this.txtDType.Items.AddRange(new object[] {
            "گرم",
            "سی سی",
            "لیتر"});
            this.txtDType.Location = new System.Drawing.Point(49, 62);
            this.txtDType.Name = "txtDType";
            this.txtDType.Size = new System.Drawing.Size(150, 29);
            this.txtDType.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 12;
            // 
            // txtExpDate
            // 
            this.txtExpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExpDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtExpDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtExpDate.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtExpDate.Location = new System.Drawing.Point(207, 140);
            this.txtExpDate.MaxDate = new System.DateTime(2030, 7, 6, 0, 0, 0, 0);
            this.txtExpDate.MinDate = new System.DateTime(1990, 7, 6, 0, 0, 0, 0);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.RightToLeftLayout = true;
            this.txtExpDate.Size = new System.Drawing.Size(112, 24);
            this.txtExpDate.TabIndex = 11;
            // 
            // lblExpDate
            // 
            this.lblExpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(315, 143);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(53, 21);
            this.lblExpDate.TabIndex = 10;
            this.lblExpDate.Text = "تاریخ انقضا";
            // 
            // lstspec
            // 
            this.lstspec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstspec.CheckOnClick = true;
            this.lstspec.FormattingEnabled = true;
            this.lstspec.Items.AddRange(new object[] {
            "کنتراسپتیو",
            "مراقبت مادر و کودک"});
            this.lstspec.Location = new System.Drawing.Point(199, 208);
            this.lstspec.Name = "lstspec";
            this.lstspec.Size = new System.Drawing.Size(120, 50);
            this.lstspec.TabIndex = 9;
            // 
            // lsttype
            // 
            this.lsttype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lsttype.CheckOnClick = true;
            this.lsttype.Items.AddRange(new object[] {
            "بهداشتی",
            "درمانی",
            "ملزومات"});
            this.lsttype.Location = new System.Drawing.Point(49, 185);
            this.lsttype.Name = "lsttype";
            this.lsttype.Size = new System.Drawing.Size(144, 73);
            this.lsttype.TabIndex = 8;
            // 
            // lstdaro
            // 
            this.lstdaro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstdaro.CheckOnClick = true;
            this.lstdaro.FormattingEnabled = true;
            this.lstdaro.Items.AddRange(new object[] {
            "داروی مراکز بدون داروخانه",
            "داروی بیمه روستایی",
            "داروی خانه بهداشت"});
            this.lstdaro.Location = new System.Drawing.Point(49, 106);
            this.lstdaro.Name = "lstdaro";
            this.lstdaro.Size = new System.Drawing.Size(144, 73);
            this.lstdaro.TabIndex = 6;
            this.lstdaro.ThreeDCheckBoxes = true;
            // 
            // txtDPrice
            // 
            this.txtDPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDPrice.Location = new System.Drawing.Point(201, 103);
            this.txtDPrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDPrice.Name = "txtDPrice";
            this.txtDPrice.Size = new System.Drawing.Size(118, 28);
            this.txtDPrice.TabIndex = 5;
            // 
            // txtDValue
            // 
            this.txtDValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDValue.Location = new System.Drawing.Point(201, 63);
            this.txtDValue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDValue.Name = "txtDValue";
            this.txtDValue.Size = new System.Drawing.Size(118, 28);
            this.txtDValue.TabIndex = 4;
            // 
            // txtDName
            // 
            this.txtDName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDName.Location = new System.Drawing.Point(49, 27);
            this.txtDName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(270, 28);
            this.txtDName.TabIndex = 3;
            // 
            // lblDPrice
            // 
            this.lblDPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDPrice.AutoSize = true;
            this.lblDPrice.Location = new System.Drawing.Point(351, 106);
            this.lblDPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDPrice.Name = "lblDPrice";
            this.lblDPrice.Size = new System.Drawing.Size(31, 21);
            this.lblDPrice.TabIndex = 2;
            this.lblDPrice.Text = "قیمت";
            // 
            // lblDValue
            // 
            this.lblDValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDValue.AutoSize = true;
            this.lblDValue.Location = new System.Drawing.Point(346, 70);
            this.lblDValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDValue.Name = "lblDValue";
            this.lblDValue.Size = new System.Drawing.Size(36, 21);
            this.lblDValue.TabIndex = 1;
            this.lblDValue.Text = "توضیح";
            // 
            // lbDName
            // 
            this.lbDName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDName.AutoSize = true;
            this.lbDName.Location = new System.Drawing.Point(342, 30);
            this.lbDName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDName.Name = "lbDName";
            this.lbDName.Size = new System.Drawing.Size(40, 21);
            this.lbDName.TabIndex = 0;
            this.lbDName.Text = "نام دارو";
            this.lbDName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDName.Click += new System.EventHandler(this.lbDName_Click);
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
            this.txtCurrentPosition.MouseLeave += new System.EventHandler(this.txtCurrentPosition_MouseLeave);
            this.txtCurrentPosition.MouseHover += new System.EventHandler(this.txtCurrentPosition_MouseHover);
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
            this.NavigationGroup.Location = new System.Drawing.Point(14, 330);
            this.NavigationGroup.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NavigationGroup.Name = "NavigationGroup";
            this.NavigationGroup.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NavigationGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NavigationGroup.Size = new System.Drawing.Size(392, 119);
            this.NavigationGroup.TabIndex = 4;
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
            // lstData
            // 
            this.lstData.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lstData.BackColor = System.Drawing.SystemColors.Control;
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DName});
            this.lstData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstData.FullRowSelect = true;
            this.lstData.HideSelection = false;
            this.lstData.Location = new System.Drawing.Point(414, 33);
            this.lstData.MultiSelect = false;
            this.lstData.Name = "lstData";
            this.lstData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstData.RightToLeftLayout = true;
            this.lstData.Size = new System.Drawing.Size(173, 381);
            this.lstData.TabIndex = 8;
            this.lstData.UseCompatibleStateImageBehavior = false;
            this.lstData.View = System.Windows.Forms.View.SmallIcon;
            this.lstData.SelectedIndexChanged += new System.EventHandler(this.lstData_SelectedIndexChanged);
            // 
            // DName
            // 
            this.DName.Text = "داروهای ثبت شده";
            this.DName.Width = 129;
            // 
            // uC_MainMenu1
            // 
            this.uC_MainMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.uC_MainMenu1.Name = "uC_MainMenu1";
            this.uC_MainMenu1.Size = new System.Drawing.Size(599, 27);
            this.uC_MainMenu1.TabIndex = 9;
            // 
            // frmDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 481);
            this.Controls.Add(this.uC_MainMenu1);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.MainGroup);
            this.Controls.Add(this.NavigationGroup);
            this.Font = new System.Drawing.Font("B Koodak", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDrug";
            this.Opacity = 0.97D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اطلاعات داروها";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.AddDrug_Load);
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.NavigationGroup.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.TextBox txtDPrice;
        private System.Windows.Forms.TextBox txtDValue;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.Label lblDPrice;
        private System.Windows.Forms.Label lblDValue;
        private System.Windows.Forms.Label lbDName;
        private System.Windows.Forms.TextBox txtCurrentPosition;
        private System.Windows.Forms.GroupBox NavigationGroup;
        private System.Windows.Forms.Button btnMoveLast;
        private System.Windows.Forms.Button btnMoveNext;
        private System.Windows.Forms.Button btnMovePrevious;
        private System.Windows.Forms.Button btnMoveFirst;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.CheckedListBox lstdaro;
        private System.Windows.Forms.CheckedListBox lsttype;
        private System.Windows.Forms.CheckedListBox lstspec;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.ListView lstData;
        private System.Windows.Forms.ColumnHeader DName;
        private UC_MainMenu uC_MainMenu1;
        private System.Windows.Forms.DateTimePicker txtExpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtDType;
        private System.Windows.Forms.Label lblTotalNumber;
        private System.Windows.Forms.Panel pnlCurrentPosition;
        private System.Windows.Forms.ToolTip DrugTip;
        private System.Windows.Forms.Panel panel1;


    }
}
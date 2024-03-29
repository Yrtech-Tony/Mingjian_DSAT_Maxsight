namespace XHX.View
{
    partial class ShopSubjectType
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
            this.grcShop = new DevExpress.XtraGrid.GridControl();
            this.grvShop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcShopCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcShopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSubjectType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboSubjectTypeExam = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gcCheckUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCheckDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.grdShop = new DevExpress.XtraEditors.PanelControl();
            this.txtShopName = new DevExpress.XtraEditors.TextEdit();
            this.btnShopCode = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboProject = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblProject = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnModule = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grcShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubjectTypeExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdShop)).BeginInit();
            this.grdShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShopName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShopCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModule.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcShop
            // 
            this.grcShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcShop.Location = new System.Drawing.Point(4, 99);
            this.grcShop.MainView = this.grvShop;
            this.grcShop.Name = "grcShop";
            this.grcShop.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboSubjectTypeExam,
            this.repositoryItemDateEdit1});
            this.grcShop.Size = new System.Drawing.Size(990, 510);
            this.grcShop.TabIndex = 14;
            this.grcShop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvShop});
            // 
            // grvShop
            // 
            this.grvShop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcShopCode,
            this.gcShopName,
            this.gcSubjectType,
            this.gcCheckUserId,
            this.gcCheckDate});
            this.grvShop.GridControl = this.grcShop;
            this.grvShop.Name = "grvShop";
            this.grvShop.OptionsView.ColumnAutoWidth = false;
            this.grvShop.OptionsView.ShowGroupPanel = false;
            // 
            // gcShopCode
            // 
            this.gcShopCode.AppearanceHeader.Options.UseTextOptions = true;
            this.gcShopCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcShopCode.Caption = "经销商代码";
            this.gcShopCode.FieldName = "ShopCode";
            this.gcShopCode.Name = "gcShopCode";
            this.gcShopCode.OptionsColumn.AllowFocus = false;
            this.gcShopCode.Visible = true;
            this.gcShopCode.VisibleIndex = 0;
            this.gcShopCode.Width = 220;
            // 
            // gcShopName
            // 
            this.gcShopName.AppearanceHeader.Options.UseTextOptions = true;
            this.gcShopName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcShopName.Caption = "经销商名称";
            this.gcShopName.FieldName = "ShopName";
            this.gcShopName.Name = "gcShopName";
            this.gcShopName.OptionsColumn.AllowFocus = false;
            this.gcShopName.Visible = true;
            this.gcShopName.VisibleIndex = 1;
            this.gcShopName.Width = 345;
            // 
            // gcSubjectType
            // 
            this.gcSubjectType.AppearanceCell.Options.UseTextOptions = true;
            this.gcSubjectType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcSubjectType.AppearanceHeader.Options.UseTextOptions = true;
            this.gcSubjectType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcSubjectType.Caption = "A/B卷";
            this.gcSubjectType.ColumnEdit = this.cboSubjectTypeExam;
            this.gcSubjectType.FieldName = "ExamTypeCode";
            this.gcSubjectType.Name = "gcSubjectType";
            this.gcSubjectType.Visible = true;
            this.gcSubjectType.VisibleIndex = 2;
            this.gcSubjectType.Width = 162;
            // 
            // cboSubjectTypeExam
            // 
            this.cboSubjectTypeExam.AutoHeight = false;
            this.cboSubjectTypeExam.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSubjectTypeExam.Name = "cboSubjectTypeExam";
            // 
            // gcCheckUserId
            // 
            this.gcCheckUserId.Caption = "审核组长";
            this.gcCheckUserId.FieldName = "CheckUserId";
            this.gcCheckUserId.Name = "gcCheckUserId";
            this.gcCheckUserId.Visible = true;
            this.gcCheckUserId.VisibleIndex = 3;
            this.gcCheckUserId.Width = 100;
            // 
            // gcCheckDate
            // 
            this.gcCheckDate.Caption = "审核开始日期";
            this.gcCheckDate.ColumnEdit = this.repositoryItemDateEdit1;
            this.gcCheckDate.FieldName = "CheckDate";
            this.gcCheckDate.Name = "gcCheckDate";
            this.gcCheckDate.Visible = true;
            this.gcCheckDate.VisibleIndex = 4;
            this.gcCheckDate.Width = 150;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // grdShop
            // 
            this.grdShop.Controls.Add(this.simpleButton1);
            this.grdShop.Controls.Add(this.labelControl5);
            this.grdShop.Controls.Add(this.btnModule);
            this.grdShop.Controls.Add(this.txtShopName);
            this.grdShop.Controls.Add(this.btnShopCode);
            this.grdShop.Controls.Add(this.labelControl2);
            this.grdShop.Controls.Add(this.cboProject);
            this.grdShop.Controls.Add(this.lblProject);
            this.grdShop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdShop.Location = new System.Drawing.Point(4, 4);
            this.grdShop.Margin = new System.Windows.Forms.Padding(0);
            this.grdShop.Name = "grdShop";
            this.grdShop.Size = new System.Drawing.Size(990, 95);
            this.grdShop.TabIndex = 13;
            // 
            // txtShopName
            // 
            this.txtShopName.Enabled = false;
            this.txtShopName.Location = new System.Drawing.Point(375, 11);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(238, 21);
            this.txtShopName.TabIndex = 6;
            // 
            // btnShopCode
            // 
            this.btnShopCode.EditValue = "";
            this.btnShopCode.Location = new System.Drawing.Point(269, 11);
            this.btnShopCode.Name = "btnShopCode";
            this.btnShopCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnShopCode.Size = new System.Drawing.Size(100, 21);
            this.btnShopCode.TabIndex = 5;
            this.btnShopCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnShopCode_ButtonClick);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.Location = new System.Drawing.Point(227, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "经销商";
            // 
            // cboProject
            // 
            this.cboProject.Location = new System.Drawing.Point(63, 11);
            this.cboProject.Name = "cboProject";
            this.cboProject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProject.Size = new System.Drawing.Size(100, 21);
            this.cboProject.TabIndex = 1;
            // 
            // lblProject
            // 
            this.lblProject.Location = new System.Drawing.Point(30, 14);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(24, 14);
            this.lblProject.TabIndex = 0;
            this.lblProject.Text = "项目";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(282, 53);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(116, 36);
            this.simpleButton1.TabIndex = 110;
            this.simpleButton1.Text = "设置A/B卷";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.Location = new System.Drawing.Point(61, 66);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 109;
            this.labelControl5.Text = "模板路径";
            // 
            // btnModule
            // 
            this.btnModule.EditValue = "";
            this.btnModule.Location = new System.Drawing.Point(118, 63);
            this.btnModule.Name = "btnModule";
            this.btnModule.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnModule.Size = new System.Drawing.Size(100, 21);
            this.btnModule.TabIndex = 108;
            this.btnModule.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnModule_ButtonClick);
            // 
            // ShopSubjectType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcShop);
            this.Controls.Add(this.grdShop);
            this.Name = "ShopSubjectType";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Size = new System.Drawing.Size(998, 613);
            ((System.ComponentModel.ISupportInitialize)(this.grcShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubjectTypeExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdShop)).EndInit();
            this.grdShop.ResumeLayout(false);
            this.grdShop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShopName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShopCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModule.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcShop;
        private DevExpress.XtraGrid.Views.Grid.GridView grvShop;
        private DevExpress.XtraGrid.Columns.GridColumn gcShopCode;
        private DevExpress.XtraGrid.Columns.GridColumn gcShopName;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cboSubjectTypeExam;
        private DevExpress.XtraGrid.Columns.GridColumn gcSubjectType;
        private DevExpress.XtraEditors.PanelControl grdShop;
        private DevExpress.XtraEditors.ComboBoxEdit cboProject;
        private DevExpress.XtraEditors.LabelControl lblProject;
        private DevExpress.XtraEditors.TextEdit txtShopName;
        private DevExpress.XtraEditors.ButtonEdit btnShopCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gcCheckUserId;
        private DevExpress.XtraGrid.Columns.GridColumn gcCheckDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ButtonEdit btnModule;

    }
}
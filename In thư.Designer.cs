namespace QuanLyCoDong
{
    partial class FormInthu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.thuMoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCDDataSet = new QuanLyCoDong.QLCDDataSet();
            this.thu_MoiTableAdapter = new QuanLyCoDong.QLCDDataSetTableAdapters.Thu_MoiTableAdapter();
            this.Thu_MoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vonBieuQuyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCoDongGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnIn_Thu = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchCardNo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuMoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thu_MoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCoDongGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 45);
            this.panel1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "IN THƯ MỜI ĐẠI HỘI";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // thuMoiBindingSource
            // 
            this.thuMoiBindingSource.DataMember = "Thu_Moi";
            this.thuMoiBindingSource.DataSource = this.qLCDDataSet;
            // 
            // qLCDDataSet
            // 
            this.qLCDDataSet.DataSetName = "QLCDDataSet";
            this.qLCDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thu_MoiTableAdapter
            // 
            this.thu_MoiTableAdapter.ClearBeforeFill = true;
            // 
            // Thu_MoiBindingSource
            // 
            this.Thu_MoiBindingSource.DataMember = "Thu_Moi";
            this.Thu_MoiBindingSource.DataSource = this.qLCDDataSet;
            // 
            // cboSheet
            // 
            this.cboSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(144, 608);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(230, 29);
            this.cboSheet.TabIndex = 30;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 608);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Sheet:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrowse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(797, 562);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(35, 30);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn16.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "CNTC";
            this.dataGridViewTextBoxColumn15.HeaderText = "CNTC";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TYPE";
            this.dataGridViewTextBoxColumn14.HeaderText = "TYPE";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn13.HeaderText = "Email";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "So_Dien_Thoai";
            this.dataGridViewTextBoxColumn12.HeaderText = "So_Dien_Thoai";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Dia_Chi_Lien_He";
            this.dataGridViewTextBoxColumn11.HeaderText = "Dia_Chi_Lien_He";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Dia_Chi_Thuong_Tru";
            this.dataGridViewTextBoxColumn10.HeaderText = "Dia_Chi_Thuong_Tru";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Noi_Cap";
            this.dataGridViewTextBoxColumn9.HeaderText = "Noi_Cap";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Ngay_Cap";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ngay_Cap";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "So_CCCD";
            this.dataGridViewTextBoxColumn7.HeaderText = "So_CCCD";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // vonBieuQuyetDataGridViewTextBoxColumn
            // 
            this.vonBieuQuyetDataGridViewTextBoxColumn.DataPropertyName = "Von_Bieu_Quyet";
            this.vonBieuQuyetDataGridViewTextBoxColumn.HeaderText = "Von_Bieu_Quyet";
            this.vonBieuQuyetDataGridViewTextBoxColumn.Name = "vonBieuQuyetDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Von_Co_Phan";
            this.dataGridViewTextBoxColumn6.HeaderText = "Von_Co_Phan";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ho_Ten";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ho_Ten";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gioi_Tinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "Gioi_Tinh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaVLG";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaVLG";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ma_Co_Dong";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ma_Co_Dong";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "STT";
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // DataCoDongGridView
            // 
            this.DataCoDongGridView.AllowUserToAddRows = false;
            this.DataCoDongGridView.AllowUserToDeleteRows = false;
            this.DataCoDongGridView.AllowUserToOrderColumns = true;
            this.DataCoDongGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataCoDongGridView.AutoGenerateColumns = false;
            this.DataCoDongGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataCoDongGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataCoDongGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCoDongGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.vonBieuQuyetDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.DataCoDongGridView.DataSource = this.thuMoiBindingSource;
            this.DataCoDongGridView.Location = new System.Drawing.Point(16, 97);
            this.DataCoDongGridView.Name = "DataCoDongGridView";
            this.DataCoDongGridView.Size = new System.Drawing.Size(1008, 312);
            this.DataCoDongGridView.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Danh sách:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Chọn đường dẫn:";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFileName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(144, 562);
            this.txtFileName.Multiline = true;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(647, 30);
            this.txtFileName.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 567);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "Chọn file:";
            // 
            // btnIn_Thu
            // 
            this.btnIn_Thu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIn_Thu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.btnIn_Thu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIn_Thu.FlatAppearance.BorderSize = 0;
            this.btnIn_Thu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn_Thu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn_Thu.ForeColor = System.Drawing.Color.White;
            this.btnIn_Thu.Location = new System.Drawing.Point(864, 608);
            this.btnIn_Thu.Name = "btnIn_Thu";
            this.btnIn_Thu.Size = new System.Drawing.Size(160, 45);
            this.btnIn_Thu.TabIndex = 37;
            this.btnIn_Thu.Tag = "Sử dụng in hàng loạt thay vì in 1 hàng ";
            this.btnIn_Thu.Text = "In thư";
            this.btnIn_Thu.UseVisualStyleBackColor = false;
            this.btnIn_Thu.Click += new System.EventHandler(this.btnIn_Thu_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.BackColor = System.Drawing.Color.White;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.btnImport.Location = new System.Drawing.Point(864, 562);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(160, 39);
            this.btnImport.TabIndex = 38;
            this.btnImport.Tag = "Sử dụng in hàng loạt thay vì in 1 hàng ";
            this.btnImport.Text = " Tải lên ";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(864, 466);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 45);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Tag = "Sử dụng in hàng loạt thay vì in 1 hàng ";
            this.btnSearch.Text = "Tìm kiếm ";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Các tiêu chí tìm kiếm:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Số CCCD:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Họ và tên:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearchName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.Location = new System.Drawing.Point(144, 469);
            this.txtSearchName.Multiline = true;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(334, 30);
            this.txtSearchName.TabIndex = 52;
            // 
            // txtSearchCardNo
            // 
            this.txtSearchCardNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearchCardNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCardNo.Location = new System.Drawing.Point(602, 466);
            this.txtSearchCardNo.Multiline = true;
            this.txtSearchCardNo.Name = "txtSearchCardNo";
            this.txtSearchCardNo.Size = new System.Drawing.Size(230, 30);
            this.txtSearchCardNo.TabIndex = 53;
            this.txtSearchCardNo.TextChanged += new System.EventHandler(this.txtSearchCardNo_TextChanged);
            // 
            // FormInthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 694);
            this.Controls.Add(this.txtSearchCardNo);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnIn_Thu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataCoDongGridView);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboSheet);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormInthu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInthu";
            this.Load += new System.EventHandler(this.FormInthu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuMoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thu_MoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCoDongGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCoDongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVLGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vonCoPhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vonUyQuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCCCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiThuongTruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiLienHeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private QLCDDataSet qLCDDataSet;
        private System.Windows.Forms.BindingSource thuMoiBindingSource;
        private QLCDDataSetTableAdapters.Thu_MoiTableAdapter thu_MoiTableAdapter;
        private System.Windows.Forms.BindingSource Thu_MoiBindingSource;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn vonBieuQuyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView DataCoDongGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIn_Thu;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtSearchCardNo;
    }
}
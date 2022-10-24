namespace Buoi6
{
    partial class B1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelGender = new System.Windows.Forms.Panel();
            this.panelFL = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radM = new System.Windows.Forms.RadioButton();
            this.radFM = new System.Windows.Forms.RadioButton();
            this.cbEN = new System.Windows.Forms.CheckBox();
            this.cbFrance = new System.Windows.Forms.CheckBox();
            this.cbChinese = new System.Windows.Forms.CheckBox();
            this.cboEthnic = new System.Windows.Forms.ComboBox();
            this.lstvOutput = new System.Windows.Forms.ListView();
            this.HoTenCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGender.SuspendLayout();
            this.panelFL.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngoại ngữ ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dân tộc";
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.radFM);
            this.panelGender.Controls.Add(this.radM);
            this.panelGender.Location = new System.Drawing.Point(174, 96);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(314, 27);
            this.panelGender.TabIndex = 5;
            // 
            // panelFL
            // 
            this.panelFL.Controls.Add(this.cbChinese);
            this.panelFL.Controls.Add(this.cbFrance);
            this.panelFL.Controls.Add(this.cbEN);
            this.panelFL.Location = new System.Drawing.Point(174, 144);
            this.panelFL.Name = "panelFL";
            this.panelFL.Size = new System.Drawing.Size(314, 35);
            this.panelFL.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(174, 49);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 8;
            // 
            // radM
            // 
            this.radM.AutoSize = true;
            this.radM.Location = new System.Drawing.Point(7, 3);
            this.radM.Name = "radM";
            this.radM.Size = new System.Drawing.Size(57, 22);
            this.radM.TabIndex = 0;
            this.radM.TabStop = true;
            this.radM.Text = "Nam";
            this.radM.UseVisualStyleBackColor = true;
            // 
            // radFM
            // 
            this.radFM.AutoSize = true;
            this.radFM.Location = new System.Drawing.Point(110, 2);
            this.radFM.Name = "radFM";
            this.radFM.Size = new System.Drawing.Size(45, 22);
            this.radFM.TabIndex = 1;
            this.radFM.TabStop = true;
            this.radFM.Text = "Nữ";
            this.radFM.UseVisualStyleBackColor = true;
            // 
            // cbEN
            // 
            this.cbEN.AutoSize = true;
            this.cbEN.Location = new System.Drawing.Point(7, 5);
            this.cbEN.Name = "cbEN";
            this.cbEN.Size = new System.Drawing.Size(52, 22);
            this.cbEN.TabIndex = 0;
            this.cbEN.Text = "Anh";
            this.cbEN.UseVisualStyleBackColor = true;
            // 
            // cbFrance
            // 
            this.cbFrance.AutoSize = true;
            this.cbFrance.Location = new System.Drawing.Point(106, 5);
            this.cbFrance.Name = "cbFrance";
            this.cbFrance.Size = new System.Drawing.Size(59, 22);
            this.cbFrance.TabIndex = 1;
            this.cbFrance.Text = "Pháp";
            this.cbFrance.UseVisualStyleBackColor = true;
            // 
            // cbChinese
            // 
            this.cbChinese.AutoSize = true;
            this.cbChinese.Location = new System.Drawing.Point(212, 5);
            this.cbChinese.Name = "cbChinese";
            this.cbChinese.Size = new System.Drawing.Size(98, 22);
            this.cbChinese.TabIndex = 2;
            this.cbChinese.Text = "Ca Lỉnh Chi";
            this.cbChinese.UseVisualStyleBackColor = true;
            // 
            // cboEthnic
            // 
            this.cboEthnic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboEthnic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEthnic.FormattingEnabled = true;
            this.cboEthnic.Location = new System.Drawing.Point(174, 195);
            this.cboEthnic.Name = "cboEthnic";
            this.cboEthnic.Size = new System.Drawing.Size(121, 26);
            this.cboEthnic.TabIndex = 9;
            // 
            // lstvOutput
            // 
            this.lstvOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HoTenCol,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstvOutput.FullRowSelect = true;
            this.lstvOutput.GridLines = true;
            this.lstvOutput.Location = new System.Drawing.Point(45, 251);
            this.lstvOutput.Name = "lstvOutput";
            this.lstvOutput.Size = new System.Drawing.Size(516, 161);
            this.lstvOutput.TabIndex = 10;
            this.lstvOutput.UseCompatibleStateImageBehavior = false;
            this.lstvOutput.View = System.Windows.Forms.View.Details;
            this.lstvOutput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstvOutput_MouseDown);
            // 
            // HoTenCol
            // 
            this.HoTenCol.Text = "Họ tên";
            this.HoTenCol.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã sinh viên";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngoại ngữ";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 119;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dân tộc";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 89;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Buoi6.Properties.Resources.btnAdd;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(135, 418);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 50);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Buoi6.Properties.Resources.btnUpdate;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(334, 418);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 50);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(239, 418);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(74, 50);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Xóa";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.toolStripSeparator1,
            this.xóaToolStripMenuItem,
            this.toolStripSeparator2,
            this.sửaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(80, 82);
            this.contextMenuStrip1.Text = "bỦH";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(124, 6);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click_1);
            // 
            // B1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(594, 471);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lstvOutput);
            this.Controls.Add(this.cboEthnic);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.panelFL);
            this.Controls.Add(this.panelGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "B1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B1";
            this.Load += new System.EventHandler(this.B1_Load);
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            this.panelFL.ResumeLayout(false);
            this.panelFL.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.RadioButton radFM;
        private System.Windows.Forms.RadioButton radM;
        private System.Windows.Forms.Panel panelFL;
        private System.Windows.Forms.CheckBox cbChinese;
        private System.Windows.Forms.CheckBox cbFrance;
        private System.Windows.Forms.CheckBox cbEN;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboEthnic;
        private System.Windows.Forms.ListView lstvOutput;
        private System.Windows.Forms.ColumnHeader HoTenCol;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
    }
}
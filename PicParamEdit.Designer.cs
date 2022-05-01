
namespace PicListViewer
{
    partial class PicParamEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicParamEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.numOpacity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPicWidth = new System.Windows.Forms.NumericUpDown();
            this.numPicHeight = new System.Windows.Forms.NumericUpDown();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPicPath = new System.Windows.Forms.TextBox();
            this.btnSelectPic = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkTopMost = new System.Windows.Forms.CheckBox();
            this.chkIsToSave = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPicWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPicHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "透明度(%)";
            // 
            // numOpacity
            // 
            this.numOpacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numOpacity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOpacity.Location = new System.Drawing.Point(106, 29);
            this.numOpacity.Name = "numOpacity";
            this.numOpacity.Size = new System.Drawing.Size(339, 21);
            this.numOpacity.TabIndex = 1;
            this.numOpacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "图片宽度(px)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "图片高度(px)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "刷新间隔(s)";
            // 
            // numPicWidth
            // 
            this.numPicWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPicWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPicWidth.Location = new System.Drawing.Point(106, 65);
            this.numPicWidth.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numPicWidth.Name = "numPicWidth";
            this.numPicWidth.Size = new System.Drawing.Size(339, 21);
            this.numPicWidth.TabIndex = 2;
            // 
            // numPicHeight
            // 
            this.numPicHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPicHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPicHeight.Location = new System.Drawing.Point(106, 101);
            this.numPicHeight.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.numPicHeight.Name = "numPicHeight";
            this.numPicHeight.Size = new System.Drawing.Size(339, 21);
            this.numPicHeight.TabIndex = 3;
            // 
            // numInterval
            // 
            this.numInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numInterval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numInterval.Location = new System.Drawing.Point(106, 137);
            this.numInterval.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(339, 21);
            this.numInterval.TabIndex = 4;
            this.numInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "图片路径";
            // 
            // txtPicPath
            // 
            this.txtPicPath.Location = new System.Drawing.Point(106, 174);
            this.txtPicPath.Name = "txtPicPath";
            this.txtPicPath.ReadOnly = true;
            this.txtPicPath.Size = new System.Drawing.Size(258, 21);
            this.txtPicPath.TabIndex = 5;
            // 
            // btnSelectPic
            // 
            this.btnSelectPic.Location = new System.Drawing.Point(370, 172);
            this.btnSelectPic.Name = "btnSelectPic";
            this.btnSelectPic.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPic.TabIndex = 6;
            this.btnSelectPic.Text = "选择路径";
            this.btnSelectPic.UseVisualStyleBackColor = true;
            this.btnSelectPic.Click += new System.EventHandler(this.btnSelectPic_Click);
            // 
            // btnStart
            // 
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStart.Location = new System.Drawing.Point(350, 261);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "开始图片浏览";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(269, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkTopMost
            // 
            this.chkTopMost.AutoSize = true;
            this.chkTopMost.Location = new System.Drawing.Point(106, 212);
            this.chkTopMost.Name = "chkTopMost";
            this.chkTopMost.Size = new System.Drawing.Size(132, 16);
            this.chkTopMost.TabIndex = 7;
            this.chkTopMost.Text = "始终显示于桌面顶层";
            this.chkTopMost.UseVisualStyleBackColor = true;
            // 
            // chkIsToSave
            // 
            this.chkIsToSave.AutoSize = true;
            this.chkIsToSave.Checked = true;
            this.chkIsToSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsToSave.Location = new System.Drawing.Point(244, 212);
            this.chkIsToSave.Name = "chkIsToSave";
            this.chkIsToSave.Size = new System.Drawing.Size(96, 16);
            this.chkIsToSave.TabIndex = 8;
            this.chkIsToSave.Text = "保存当前设置";
            this.chkIsToSave.UseVisualStyleBackColor = true;
            // 
            // PicParamEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.chkIsToSave);
            this.Controls.Add(this.chkTopMost);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSelectPic);
            this.Controls.Add(this.txtPicPath);
            this.Controls.Add(this.numInterval);
            this.Controls.Add(this.numPicHeight);
            this.Controls.Add(this.numPicWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numOpacity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PicParamEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PicParamEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PicParamEdit_FormClosed);
            this.Load += new System.EventHandler(this.PicParamEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPicWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPicHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numOpacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPicWidth;
        private System.Windows.Forms.NumericUpDown numPicHeight;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPicPath;
        private System.Windows.Forms.Button btnSelectPic;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkTopMost;
        private System.Windows.Forms.CheckBox chkIsToSave;
    }
}
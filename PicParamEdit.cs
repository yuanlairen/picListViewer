using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicListViewer
{
    public partial class PicParamEdit : Form
    {
        public PicParamEdit()
        {
            InitializeComponent();
        }

        private void PicParamEdit_Load(object sender, EventArgs e)
        {
            this.cboSortBy.DataSource = UtilHelper.GetEnumDic<SortCondType>().ToArray();
            this.cboSortBy.DisplayMember = "Value";
            this.cboSortBy.ValueMember = "Key";

            var setting = SettingHelper.GetSettingConfig();
            this.numInterval.Value = setting.TimerInterval;
            this.numOpacity.Value = setting.FormOpacity;
            this.numPicWidth.Value = setting.FormWidth;
            this.numPicHeight.Value = setting.FormHeight;
            this.txtPicPath.Text = setting.ImgPath;
            this.chkTopMost.Checked = setting.TopMost;
            this.cboSortBy.SelectedValue = setting.SortBy;
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtPicPath.Text))
            {
                this.folderBrowserDialog1.SelectedPath = this.txtPicPath.Text;
            }

            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtPicPath.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(this.txtPicPath.Text))
                {
                    throw new Exception("请选择图片路径");
                }

                var setting = new SettingConfig();
                setting.FormWidth = int.Parse(decimal.Floor(this.numPicWidth.Value).ToString());
                setting.FormHeight = int.Parse(decimal.Floor(this.numPicHeight.Value).ToString());
                setting.FormOpacity = int.Parse(decimal.Floor(this.numOpacity.Value).ToString());
                setting.TimerInterval = int.Parse(decimal.Floor(this.numInterval.Value).ToString());
                setting.ImgPath = this.txtPicPath.Text;
                setting.TopMost = this.chkTopMost.Checked;
                setting.SortBy = (SortCondType)this.cboSortBy.SelectedValue;

                var child = new PicListViewer(setting, this);
                child.Show();

                if (this.chkIsToSave.Checked)
                {
                    setting.ImgPath = ConfigHelper.IsSavePath ? setting.ImgPath : string.Empty;
                    SettingHelper.SaveSettingConfig(setting);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicParamEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

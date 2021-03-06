using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicListViewer
{
    public partial class PicListViewer : Form
    {
        Image[] mImageObjs = null;
        int mCurrIndex = 0;
        string mImagePath = null;
        int mInterval = 0;
        SortCondType mSortBy = SortCondType.ByTimeAsc;

        PicParamEdit mParentForm = null;

        public PicListViewer(SettingConfig settingConfig, PicParamEdit parentForm)
        {
            InitializeComponent();

            this.TopMost = settingConfig.TopMost;
            this.mImagePath = settingConfig.ImgPath;
            this.mInterval = settingConfig.TimerInterval * 1000;
            this.mSortBy = settingConfig.SortBy;
            this.ExInitializeComponent(settingConfig.FormWidth,settingConfig.FormHeight,settingConfig.FormOpacity);

            this.mParentForm = parentForm;
            this.mParentForm.Hide();
        }

        #region 设置组件参数
        /// <summary>
        /// 组件参数初始化
        /// </summary>
        private void ExInitializeComponent(int picWidth, int picHeight, int opacity)
        {
            //窗体背景透明
            this.TransparencyKey = this.BackColor = Control.DefaultBackColor;

            //窗体大小
            this.ClientSize = new Size(picWidth, picHeight);

            //窗体透明度
            this.Opacity = (double)opacity/100;
        }

        /// <summary>
        /// 是否可以获得焦点
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                if (ConfigHelper.NOACTIVATE)
                {
                    const int WS_EX_NOACTIVATE = 0x08000000;
                    CreateParams cp = base.CreateParams;
                    cp.ExStyle |= WS_EX_NOACTIVATE;
                    return cp;
                }
                else
                {
                    return base.CreateParams;
                }
            }
        }
        #endregion

        #region 开启图集浏览
        /// <summary>
        /// 重置图集
        /// </summary>
        private void ResetPicList()
        {
            try
            {
                mImageObjs = new List<Image>().ToArray();
                this.pictureBox1.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 开始图集浏览
        /// </summary>
        private void StartViewer()
        {
            try
            {
                string[] imageNameList = null;

                if (this.mSortBy == SortCondType.ByTimeAsc)
                {
                    var query = (from f in System.IO.Directory.GetFiles(mImagePath)
                                 let fi = new FileInfo(f)
                                 orderby fi.CreationTime ascending
                                 select fi.FullName);

                    imageNameList = query.ToArray();
                }
                else if (this.mSortBy == SortCondType.ByTimeDesc)
                {
                    var query = (from f in System.IO.Directory.GetFiles(mImagePath)
                                 let fi = new FileInfo(f)
                                 orderby fi.CreationTime descending
                                 select fi.FullName);

                    imageNameList = query.ToArray();
                }
                else if (this.mSortBy == SortCondType.ByNameAsc)
                {
                    var query = (from f in System.IO.Directory.GetFiles(mImagePath)
                                 let fi = new FileInfo(f)
                                 orderby fi.Name ascending
                                 select fi.FullName);

                    imageNameList = query.ToArray();
                }
                else if (this.mSortBy == SortCondType.ByNameAsc)
                {
                    var query = (from f in System.IO.Directory.GetFiles(mImagePath)
                                 let fi = new FileInfo(f)
                                 orderby fi.Name descending
                                 select fi.FullName);

                    imageNameList = query.ToArray();
                }

                mImageObjs = imageNameList.Select(t => {
                    try
                    {
                        return Image.FromFile(t);
                    }
                    catch
                    {
                        return null;
                    }
                }).Where(t=>t!=null).ToArray();

                this.timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 定时器事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            int maxIndex = mImageObjs.Length - 1;
            if (mCurrIndex > maxIndex)
            {
                mCurrIndex = 0;
            }

            this.pictureBox1.Image = mImageObjs[mCurrIndex];
            this.pictureBox1.Tag = mCurrIndex;

            mCurrIndex += 1;

            //重新根据外部设置修改定时器间隔
            if(this.mInterval>this.timer1.Interval)
            {
                this.timer1.Stop();
                this.timer1.Interval = this.mInterval;
                this.timer1.Start();
            }
        }

        #endregion

        #region 窗体键盘事件

        /// <summary>
        /// 键盘按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicListViewer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4)
            {
                this.mParentForm.Show();
                this.Dispose();
            }
            else if(e.KeyCode == Keys.F11)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
            else if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                if (this.timer1.Enabled)
                {
                    this.timer1.Stop();
                    this.lblSuspend.Visible = true;
                }
                else
                {
                    this.timer1.Start();
                    this.lblSuspend.Visible = false;
                }
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Up || e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
            {
                if(this.timer1.Enabled)
                {
                    this.timer1.Stop();
                    this.lblSuspend.Visible = true;
                }
                if(e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
                {
                    mCurrIndex = ((int)this.pictureBox1.Tag) - 1;
                    if(mCurrIndex<0)
                    {
                        mCurrIndex = 0;
                    }
                }
                else if(e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
                {
                    mCurrIndex = ((int)this.pictureBox1.Tag) + 1;
                    if (mCurrIndex >= this.mImageObjs.Count())
                    {
                        mCurrIndex = this.mImageObjs.Count() - 1;
                    }
                }
                this.pictureBox1.Image = mImageObjs[mCurrIndex];
                this.pictureBox1.Tag = mCurrIndex;
            }
            else if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        #endregion

        #region 窗体移动事件

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int MOUSEWHEEL = 0x020A;

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ControlClick(sender as Control, e);
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void ControlClick(Control sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            }
            else
            {
                //添加双击或右击代码……
                if (e.Clicks == 2)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        this.WindowState = FormWindowState.Maximized;
                    }
                }
            }
        }

        #endregion

        #region 鼠标滚轮事件
        private void PicListViewer_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)//滚轮向上
            {
                if (this.Opacity <= 0.9)
                {
                    this.Opacity = Math.Round(this.Opacity + 0.1, 1);
                }
                else
                {
                    this.Opacity = 1.0;
                }
            }
            else
            {
                if (this.Opacity > 0.1)
                {
                    this.Opacity = Math.Round(this.Opacity - 0.1, 1);
                }
            }
        }

        #endregion

        #region 窗体load和close事件
        private void PicListViewer_Load(object sender, EventArgs e)
        {
            this.ResetPicList();
            this.StartViewer();
        }

        private void PicListViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}

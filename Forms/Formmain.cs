using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MathWorks.MATLAB.NET.Arrays;
using Traffic_competition.Forms;
using Traffic_competition.UserControls;
using Traffic_optimize_local;

namespace Traffic_competition
{
    // 定义一个枚举，表示拖动方向
    public enum MouseDirection
    {
        Herizontal,// 水平方向拖动，只改变窗体的宽度        
        Vertical,// 垂直方向拖动，只改变窗体的高度 
        Declining,// 倾斜方向，同时改变窗体的宽度和高度        
        None// 不做标志，即不拖动窗体改变大小 
    }
    public partial class Formmain : Form
    {
        bool istextfull = false;//判定输入框是否完全填写，初始值为否
        bool isMouseDown = false; //表示鼠标当前是否处于按下状态，初始值为否
        public Control activeControl = null;//表示当前活动控件
        UC_daolu uC_Daolu = new UC_daolu();//构造窗体
        UC_flow uC_Flow = new UC_flow();
        UC_baohe uC_Baohe = new UC_baohe();
        UC_result uC_Result = new UC_result();
        UC_info uC_Info = new UC_info();
        Class_Traffic traffic = new Class_Traffic();//实例化MATLAB函数

        //方案输出结果转化函数
        string Zhuanhua(string str)
        {
            str = str.Replace("1", "左");
            str = str.Replace("0", "直");
            str = str.Replace("2", "右");
            str = str.Replace("3", "直+右");
            return str;
        }

        //输入框判断函数
        private void GetControl(Control.ControlCollection ctc)
        {
            istextfull = true;
            foreach (Control ct in ctc)
            {
                if (ct is ComboBox)
                {
                    if (string.IsNullOrEmpty(ct.Text))
                    {
                        istextfull = false;
                        break;
                    }
                }
                if (ct is TextBox)
                {
                    if (string.IsNullOrEmpty(ct.Text))
                    {
                        istextfull = false;
                        break;
                    }
                }
                //C#只遍历窗体的子控件，不遍历孙控件
                //当窗体上的控件有子控件时，需要用递归的方法遍历，才能全部列出窗体上的控件
                if (ct.HasChildren)
                {
                    GetControl(ct.Controls);
                }
            }
        }

        public Formmain()
        {
            InitializeComponent();
            buttonhome.BackColor = Color.FromArgb(0, 32, 80);
            activeControl = uC_Daolu;
            uC_Daolu.Dock = DockStyle.Fill;
            panelhome.Controls.Clear();
            panelhome.Controls.Add(uC_Daolu);
        }

        #region 窗口拖动改变大小(未实现)
        MouseDirection direction = MouseDirection.None;//表示拖动的方向，起始为None，表示不拖动
        private void Formmain_MouseDown(object sender, MouseEventArgs e)
        {
            //鼠标按下 
            isMouseDown = true;
        }

        private void Formmain_MouseUp(object sender, MouseEventArgs e)
        {
            // 鼠标弹起，
            isMouseDown = false;
            //既然鼠标弹起了，那么就不能再改变窗体尺寸，拖拽方向置 none
            direction = MouseDirection.None;
        }

        private void Formmain_MouseMove(object sender, MouseEventArgs e)
        {
            //鼠标移动过程中，坐标时刻在改变 
            //当鼠标移动时横坐标距离窗体右边缘5像素以内且纵坐标距离下边缘也在5像素以内时，要将光标变为倾斜的箭头形状，同时拖拽方向direction置为MouseDirection.Declining 
            if (e.Location.X >= this.Width - 5 && e.Location.Y > this.Height - 5)
            {
                this.Cursor = Cursors.SizeNWSE;
                direction = MouseDirection.Declining;
            }
            //当鼠标移动时横坐标距离窗体右边缘5像素以内时，要将光标变为倾斜的箭头形状，同时拖拽方向direction置为MouseDirection.Herizontal
            else if (e.Location.X >= this.Width - 5)
            {
                this.Cursor = Cursors.SizeWE;
                direction = MouseDirection.Herizontal;
            }
            //同理当鼠标移动时纵坐标距离窗体下边缘5像素以内时，要将光标变为倾斜的箭头形状，同时拖拽方向direction置为MouseDirection.Vertical
            else if (e.Location.Y >= this.Height - 5)
            {
                this.Cursor = Cursors.SizeNS;
                direction = MouseDirection.Vertical;

            }
            //否则，以外的窗体区域，鼠标星座均为单向箭头（默认）             
            else
                this.Cursor = Cursors.Arrow;
            //设定好方向后，调用下面方法，改变窗体大小  
            ResizeWindow();
        }

        private void ResizeWindow()
        {
            //这个判断很重要，只有在鼠标按下时才能拖拽改变窗体大小，如果不作判断，那么鼠标弹起和按下时，窗体都可以改变 
            if (!isMouseDown)
                return;
            //MousePosition的参考点是屏幕的左上角，表示鼠标当前相对于屏幕左上角的坐标this.left和this.top的参考点也是屏幕，属性MousePosition是该程序的重点
            if (direction == MouseDirection.Declining)
            {
                //此行代码在mousemove事件中已经写过，在此再写一遍，并不多余，一定要写
                this.Cursor = Cursors.SizeNWSE;
                //下面是改变窗体宽和高的代码，不明白的可以仔细思考一下
                this.Width = MousePosition.X - this.Left;
                this.Height = MousePosition.Y - this.Top;
            }
            //以下同理
            if (direction == MouseDirection.Herizontal)
            {
                this.Cursor = Cursors.SizeWE;
                this.Width = MousePosition.X - this.Left;
            }
            else if (direction == MouseDirection.Vertical)
            {
                this.Cursor = Cursors.SizeNS;
                this.Height = MousePosition.Y - this.Top;
            }
            //即使鼠标按下，但是不在窗口右和下边缘，那么也不能改变窗口大小
            else
                this.Cursor = Cursors.Arrow;
        }
        #endregion 

        #region 最小化
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x00020000;// Winuser.h中定义
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;// 允许点击任务栏图标最小化操作
                return cp;
            }
        }
        private void Buttonmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;// 最小化
        }
        #endregion

        #region 拖动窗口，最大化，还原
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        /// <summary>
        /// 为了是主界面能够移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Paneltop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            buttonmax.Image = Properties.Resources.icons8_enlarge_32px;// 改变最大化按钮形状
            toolTipmax.SetToolTip(buttonmax, "最大化");
            SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);// 使界面能够移动

        }

        private void Labeltitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            buttonmax.Image = Properties.Resources.icons8_enlarge_32px;// 改变最大化按钮形状
            toolTipmax.SetToolTip(buttonmax, "最大化");
            SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);// 使界面能够移动
        }

        private void Buttonmax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                buttonmax.Image = Properties.Resources.icons8_enlarge_32px;
                toolTipmax.SetToolTip(buttonmax, "最大化");
                WindowState = FormWindowState.Normal;// 如果窗口已经最大化，则恢恢复为正常大小
            }
            else
            {
                MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                buttonmax.Image = Properties.Resources.icons8_compress_32px;
                toolTipmax.SetToolTip(buttonmax, "还原");
                WindowState = FormWindowState.Maximized;// 如果窗口为正常，将其最大化
            }
        }
        #endregion

        #region 关闭
        private void Buttonclose_Click(object sender, EventArgs e)
        {
            Close();// 关闭窗口
        }

        private void Buttonclose_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            if (e.Button == MouseButtons.Left && isMouseDown)
            {
                buttonclose.Image = Properties.Resources.icons8_shutdown_32px_1;// 按住，关闭按钮白色
            }
        }

        private void Buttonclose_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle rectangle = buttonclose.RectangleToScreen(buttonclose.DisplayRectangle);
            if (rectangle.Contains(MousePosition) && isMouseDown && e.Button == MouseButtons.Left)
            {
                buttonclose.Image = Properties.Resources.icons8_shutdown_32px_1;// 在图标处按住左键，关闭按钮白色
            }
            else
            {
                buttonclose.Image = Properties.Resources.icons8_shutdown_32px_3;// 否则，关闭按钮红色
            }
        }
        #endregion

        #region 子窗体显示
        private void Openchildform(Form childform)
        {
            panelmain.Controls.Clear();// 移除所有控件
            childform.TopLevel = false;// 设置为非顶级窗体
            childform.FormBorderStyle = FormBorderStyle.None;// 设置窗体为非边框样式
            childform.Dock = DockStyle.Fill;// 设置样式是否填充整个panel
            panelmain.Controls.Add(childform);// 添加窗体
            panelmain.Tag = childform;
            childform.BringToFront();
            childform.Show();// 窗体运行
        }
        #endregion

        #region 侧边栏按钮
        private void Buttonhome_Click(object sender, EventArgs e)
        {
            if (activeControl != uC_Daolu)
            {
                buttonhome.BackColor = Color.FromArgb(0, 32, 80);
                buttoninfo.BackColor = Color.FromArgb(43, 87, 154);
                activeControl = uC_Daolu;
                labelhometitle.Text = "建立道路模型";
                labelunit.Hide();
                panelhome.Controls.Clear();
                uC_Daolu.Dock = DockStyle.Fill;
                panelhome.Controls.Add(uC_Daolu);
                buttonback.Hide();
                buttonnext.Image = Properties.Resources.icons8_forward_96px;
                buttonnext.Text = "  下一步";
                uC_Info.Hide();
                paneltitle.Show();
                paneltopline.Show();
                panelhome.Show();
                panelbottom.Show();
            }
        }

        private void Buttoninfo_Click(object sender, EventArgs e)
        {
            if (activeControl != uC_Info)
            {
                buttoninfo.BackColor = Color.FromArgb(0, 32, 80);
                buttonhome.BackColor = Color.FromArgb(43, 87, 154);
                activeControl = uC_Info;
                panelhome.Controls.Clear();
                paneltitle.Hide();
                paneltopline.Hide();
                panelhome.Hide();
                panelbottom.Hide();
                uC_Info.Dock = DockStyle.Fill;
                panelmain.Controls.Add(uC_Info);
                uC_Info.BringToFront();
                uC_Info.Show();
            }
        }
        #endregion

        private void Buttonback_Click(object sender, EventArgs e)
        {
            //从结果界面返回饱和流量界面
            if (activeControl == uC_Result)
            {
                activeControl = uC_Baohe;
                labelhometitle.Text = "输入饱和流量";
                labelunit.Show();
                panelhome.Controls.Clear();
                uC_Baohe.Dock = DockStyle.Fill;
                panelhome.Controls.Add(uC_Baohe);
                buttonnext.Image = Properties.Resources.icons8_forward_96px;
                buttonnext.Text = "  求解";
            }
            //从饱和流量界面返回实际流量界面
            else if (activeControl == uC_Baohe)
            {
                activeControl = uC_Flow;
                labelhometitle.Text = "输入实际流量";
                panelhome.Controls.Clear();
                uC_Flow.Dock = DockStyle.Fill;
                panelhome.Controls.Add(uC_Flow);
                buttonnext.Text = "  下一步";
            }
            //从实际流量界面返回道路模型建立界面
            else if (activeControl == uC_Flow)
            {
                activeControl = uC_Daolu;
                labelhometitle.Text = "建立道路模型";
                labelunit.Hide();
                buttonback.Hide();
                panelhome.Controls.Clear();
                uC_Daolu.Dock = DockStyle.Fill;
                panelhome.Controls.Add(uC_Daolu);
            }
        }

        private void Buttonnext_Click(object sender, EventArgs e)
        {
            //建立道路模型后进入流量输入界面
            if (activeControl == uC_Daolu)
            {
                GetControl(uC_Daolu.Controls);
                if (istextfull)
                {
                    activeControl = uC_Flow;
                    labelhometitle.Text = "输入实际流量";
                    labelunit.Show();
                    panelhome.Controls.Clear();
                    uC_Flow.Dock = DockStyle.Fill;
                    panelhome.Controls.Add(uC_Flow);
                    buttonback.Show();
                }
                else
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "数据不能为空，请检查！";
                        tipform.ShowDialog();
                    }
                }
            }
            //流量输入后进入饱和流量界面
            else if (activeControl == uC_Flow)
            {
                GetControl(uC_Flow.Controls);
                if (istextfull)
                {
                    activeControl = uC_Baohe;
                    labelhometitle.Text = "输入饱和流量";
                    panelhome.Controls.Clear();
                    uC_Baohe.Dock = DockStyle.Fill;
                    panelhome.Controls.Add(uC_Baohe);
                    buttonnext.Text = "  求解";
                }
                else
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "数据不能为空，请检查！";
                        tipform.ShowDialog();
                    }
                }
            }
            //饱和流量输入后进行计算，在结果界面输出
            else if (activeControl == uC_Baohe)
            {
                GetControl(uC_Baohe.Controls);
                if (istextfull)
                {
                    activeControl = uC_Result;
                    labelhometitle.Hide();
                    paneltopline.Hide();
                    labelhometitle.Text = "计算结果";
                    labelhometitle.Show();
                    labelunit.Hide();
                    panelhome.Controls.Clear();
                    buttonnext.Image = Properties.Resources.icons8_reset_96px;
                    buttonnext.Text = "  重置";

                    //调用MATLAB计算
                    #region MATLAB计算
                    MWArray fwl = double.Parse(GlobalData.fwlData);
                    MWArray fwt = double.Parse(GlobalData.fwtData);
                    MWArray fsl = double.Parse(GlobalData.fslData);
                    MWArray fst = double.Parse(GlobalData.fstData);
                    MWArray fel = double.Parse(GlobalData.felData);
                    MWArray fet = double.Parse(GlobalData.fetData);
                    MWArray fnl = double.Parse(GlobalData.fnlData);
                    MWArray fnt = double.Parse(GlobalData.fntData);
                    MWArray nwl = double.Parse(GlobalData.nwlData);
                    MWArray nwt = double.Parse(GlobalData.nwtData);
                    MWArray nwr = double.Parse(GlobalData.nwrData);
                    MWArray nwtr = double.Parse(GlobalData.nwtrData);
                    MWArray nsl = double.Parse(GlobalData.nslData);
                    MWArray nst = double.Parse(GlobalData.nstData);
                    MWArray nsr = double.Parse(GlobalData.nsrData);
                    MWArray nstr = double.Parse(GlobalData.nstrData);
                    MWArray nel = double.Parse(GlobalData.nelData);
                    MWArray net = double.Parse(GlobalData.netData);
                    MWArray ner = double.Parse(GlobalData.nerData);
                    MWArray netr = double.Parse(GlobalData.netrData);
                    MWArray nnl = double.Parse(GlobalData.nnlData);
                    MWArray nnt = double.Parse(GlobalData.nntData);
                    MWArray nnr = double.Parse(GlobalData.nnrData);
                    MWArray nntr = double.Parse(GlobalData.nntrData);
                    MWArray qwl = double.Parse(GlobalData.qwlData) * GlobalData.bhkData;
                    MWArray qwt = double.Parse(GlobalData.qwtData) * GlobalData.bhkData;
                    MWArray qsl = double.Parse(GlobalData.qslData) * GlobalData.bhkData;
                    MWArray qst = double.Parse(GlobalData.qstData) * GlobalData.bhkData;
                    MWArray qel = double.Parse(GlobalData.qelData) * GlobalData.bhkData;
                    MWArray qet = double.Parse(GlobalData.qetData) * GlobalData.bhkData;
                    MWArray qnl = double.Parse(GlobalData.qnlData) * GlobalData.bhkData;
                    MWArray qnt = double.Parse(GlobalData.qntData) * GlobalData.bhkData;
                    MWArray[] result = traffic.youhua(13, fwl, fwt, fsl, fst, fel, fet, fnl, fnt, nwl, nwt, nwr, nwtr, nsl, nst, nsr, nstr, nel, net, ner, netr, nnl, nnt, nnr, nntr, qwl, qwt, qsl, qst, qel, qet, qnl, qnt);
                    MWArray gwl = result[0];
                    MWArray gwt = result[1];
                    MWArray svw = result[2];
                    MWArray gsl = result[3];
                    MWArray gst = result[4];
                    MWArray svs = result[5];
                    MWArray gel = result[6];
                    MWArray get = result[7];
                    MWArray sve = result[8];
                    MWArray gnl = result[9];
                    MWArray gnt = result[10];
                    MWArray svn = result[11];
                    MWArray fval = result[12];
                    #endregion

                    string cansolve = fval.ToString();//加入有解判断量
                    string strsvw = svw.ToString();//转换方案输出
                    string strsvs = svs.ToString();
                    string strsve = sve.ToString();
                    string strsvn = svn.ToString();
                    strsvw = Zhuanhua(strsvw);
                    strsvs = Zhuanhua(strsvs);
                    strsve = Zhuanhua(strsve);
                    strsvn = Zhuanhua(strsvn);
                    //无解情况
                    if (cansolve == "-1")
                    {
                        uC_Result.panelgreen.Hide();
                        uC_Result.panelfangan.Hide();
                        uC_Result.labelresunit.Hide();
                        uC_Result.labelresult.ForeColor = Color.Red;//改变结果显示颜色
                        uC_Result.labelresult.Font = new Font(uC_Result.labelresult.Font.Name, 20, uC_Result.labelresult.Font.Style | FontStyle.Bold);//设置字体20，加粗
                        uC_Result.labelresult.Text = "超出交叉口饱和负荷，无法求解！";
                    }
                    //最优解情况
                    else
                    {
                        uC_Result.labelresult.ForeColor = Color.FromArgb(38, 38, 38);//改变结果显示颜色
                        uC_Result.labelresult.Font = new Font(uC_Result.labelresult.Font.Name, 17, uC_Result.labelresult.Font.Style ^ FontStyle.Bold);//设置字体17，不加粗
                        uC_Result.labelresult.Text = "已求出最优解！";
                        uC_Result.labelfval.Text = fval.ToString();
                        uC_Result.labelgwl.Text = gwl.ToString();
                        uC_Result.labelgwt.Text = gwt.ToString();
                        uC_Result.labelgsl.Text = gsl.ToString();
                        uC_Result.labelgst.Text = gst.ToString();
                        uC_Result.labelgel.Text = gel.ToString();
                        uC_Result.labelget.Text = get.ToString();
                        uC_Result.labelgnl.Text = gnl.ToString();
                        uC_Result.labelgnt.Text = gnt.ToString();
                        uC_Result.labelfanganw.Text = strsvw;
                        uC_Result.labelfangans.Text = strsvs;
                        uC_Result.labelfangane.Text = strsve;
                        uC_Result.labelfangann.Text = strsvn;
                        uC_Result.labelresunit.Show();
                        uC_Result.panelgreen.Show();
                        uC_Result.panelfangan.Show();
                    }
                    uC_Result.Dock = DockStyle.Fill;
                    panelhome.Controls.Add(uC_Result);
                }
                else
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "数据不能为空，请检查！";
                        tipform.ShowDialog();
                    }
                }
            }
            //重置并回到建立模型页面
            else if (activeControl == uC_Result)
            {
                uC_Daolu = new UC_daolu();//重新构造窗体
                activeControl = uC_Daolu;
                labelhometitle.Text = "建立道路模型";
                labelunit.Hide();
                buttonback.Hide();
                panelhome.Controls.Clear();
                uC_Daolu.Dock = DockStyle.Fill;
                panelhome.Controls.Add(uC_Daolu);
                buttonnext.Image = Properties.Resources.icons8_forward_96px;
                buttonnext.Text = "  下一步";
                uC_Flow = new UC_flow();
                uC_Baohe = new UC_baohe();
                uC_Result = new UC_result();
            }
        }
    }
}
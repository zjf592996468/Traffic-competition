using System;
using System.Windows.Forms;
using Traffic_competition.Forms;

namespace Traffic_competition.UserControls
{
    public partial class UC_baohe : UserControl
    {
        public UC_baohe()
        {
            InitializeComponent();
        }

        float bhk = 1;//默认饱和流量系数为1
        //饱和流量系数检验
        private void TextBoxbhk_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxbhk.Text, out bhk))
            {
                if (bhk > 1 || bhk <= 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于0且小于等于1的数！";
                        tipform.ShowDialog();
                    }
                    textBoxbhk.Focus();
                    textBoxbhk.SelectAll();
                }
                else
                {
                    GlobalData.bhkData = bhk;
                }
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于0且小于等于1的数！";
                    tipform.ShowDialog();
                }
                textBoxbhk.Focus();
                textBoxbhk.SelectAll();
            }
        }

        #region 西进口饱和流量
        private void TextBoxqwl_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxqwl.Text, out float qwl))
            {
                if (qwl < 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于等于0的数！";
                        tipform.ShowDialog();
                    }
                    textBoxqwl.Focus();
                    textBoxqwl.SelectAll();
                }
                GlobalData.qwlData = textBoxqwl.Text;
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于等于0的数！";
                    tipform.ShowDialog();
                }
                textBoxqwl.Focus();
                textBoxqwl.SelectAll();
            }
        }

        private void TextBoxqwt_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxqwt.Text, out float qwt))
            {
                if (qwt < 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于等于0的数！";
                        tipform.ShowDialog();
                    }
                    textBoxqwt.Focus();
                    textBoxqwt.SelectAll();
                }
                GlobalData.qwtData = textBoxqwt.Text;
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于等于0的数！";
                    tipform.ShowDialog();
                }
                textBoxqwt.Focus();
                textBoxqwt.SelectAll();
            }
        }
        #endregion

        #region 南进口饱和流量
        private void TextBoxqsl_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxqsl.Text, out float qsl))
            {
                if (qsl < 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于等于0的数！";
                        tipform.ShowDialog();
                    }
                    textBoxqsl.Focus();
                    textBoxqsl.SelectAll();
                }
                GlobalData.qslData = textBoxqsl.Text;
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于等于0的数！";
                    tipform.ShowDialog();
                }
                textBoxqsl.Focus();
                textBoxqsl.SelectAll();
            }
        }

        private void TextBoxqst_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxqst.Text, out float qst))
            {
                if (qst < 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于等于0的数！";
                        tipform.ShowDialog();
                    }
                    textBoxqst.Focus();
                    textBoxqst.SelectAll();
                }
                GlobalData.qstData = textBoxqst.Text;
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于等于0的数！";
                    tipform.ShowDialog();
                }
                textBoxqst.Focus();
                textBoxqst.SelectAll();
            }
        }
        #endregion

        #region 东进口饱和流量
        private void TextBoxqel_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxqel.Text, out float qel))
            {
                if (qel < 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于等于0的数！";
                        tipform.ShowDialog();
                    }
                    textBoxqel.Focus();
                    textBoxqel.SelectAll();
                }
                GlobalData.qelData = textBoxqel.Text;
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于等于0的数！";
                    tipform.ShowDialog();
                }
                textBoxqel.Focus();
                textBoxqel.SelectAll();
            }
        }

        private void TextBoxqet_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxqet.Text, out float qet))
            {
                if (qet < 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于等于0的数！";
                        tipform.ShowDialog();
                    }
                    textBoxqet.Focus();
                    textBoxqet.SelectAll();
                }
                GlobalData.qetData = textBoxqet.Text;
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于等于0的数！";
                    tipform.ShowDialog();
                }
                textBoxqet.Focus();
                textBoxqet.SelectAll();
            }
        }
        #endregion

        #region 北进口饱和流量
        private void TextBoxqnl_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxqnl.Text, out float qnl))
            {
                if (qnl < 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于等于0的数！";
                        tipform.ShowDialog();
                    }
                    textBoxqnl.Focus();
                    textBoxqnl.SelectAll();
                }
                GlobalData.qnlData = textBoxqnl.Text;
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于等于0的数！";
                    tipform.ShowDialog();
                }
                textBoxqnl.Focus();
                textBoxqnl.SelectAll();
            }
        }

        private void TextBoxqnt_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxqnt.Text, out float qnt))
            {
                if (qnt < 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于等于0的数！";
                        tipform.ShowDialog();
                    }
                    textBoxqnt.Focus();
                    textBoxqnt.SelectAll();
                }
                GlobalData.qntData = textBoxqnt.Text;
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于等于0的数！";
                    tipform.ShowDialog();
                }
                textBoxqnt.Focus();
                textBoxqnt.SelectAll();
            }
        }
        #endregion
    }
}

using System;
using System.Windows.Forms;
using Traffic_competition.Forms;

namespace Traffic_competition.UserControls
{
    public partial class UC_flow : UserControl
    {
        public UC_flow()
        {
            InitializeComponent();
        }

        #region 西进口实际流量
        private void TextBoxfwl_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxfwl.Text, out float fwl))
            {
                if (fwl < 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于等于0的数！";
                        tipform.ShowDialog();
                    }
                    textBoxfwl.Focus();
                    textBoxfwl.SelectAll();
                }
                GlobalData.fwlData = textBoxfwl.Text;
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于等于0的数！";
                    tipform.ShowDialog();
                }
                textBoxfwl.Focus();
                textBoxfwl.SelectAll();
            }
        }

        private void TextBoxfwt_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxfwt.Text, out float fwt))
            {
                if (fwt < 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于等于0的数！";
                        tipform.ShowDialog();
                    }
                    textBoxfwt.Focus();
                    textBoxfwt.SelectAll();
                }
                GlobalData.fwtData = textBoxfwt.Text;
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于等于0的数！";
                    tipform.ShowDialog();
                }
                textBoxfwt.Focus();
                textBoxfwt.SelectAll();
            }
        }
        #endregion

        #region 南进口实际流量
        private void TextBoxfsl_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxfsl.Text, out float fsl))
            {
                if (fsl < 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于等于0的数！";
                        tipform.ShowDialog();
                    }
                    textBoxfsl.Focus();
                    textBoxfsl.SelectAll();
                }
                GlobalData.fslData = textBoxfsl.Text;
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于等于0的数！";
                    tipform.ShowDialog();
                }
                textBoxfsl.Focus();
                textBoxfsl.SelectAll();
            }
        }

        private void TextBoxfst_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxfst.Text, out float fst))
            {
                if (fst < 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于等于0的数！";
                        tipform.ShowDialog();
                    }
                    textBoxfst.Focus();
                    textBoxfst.SelectAll();
                }
                GlobalData.fstData = textBoxfst.Text;
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于等于0的数！";
                    tipform.ShowDialog();
                }
                textBoxfst.Focus();
                textBoxfst.SelectAll();
            }
        }
        #endregion

        #region 东进口实际流量
        private void TextBoxfel_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxfel.Text, out float fel))
            {
                if (fel < 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于等于0的数！";
                        tipform.ShowDialog();
                    }
                    textBoxfel.Focus();
                    textBoxfel.SelectAll();
                }
                GlobalData.felData = textBoxfel.Text;
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于等于0的数！";
                    tipform.ShowDialog();
                }
                textBoxfel.Focus();
                textBoxfel.SelectAll();
            }
        }

        private void TextBoxfet_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxfet.Text, out float fet))
            {
                if (fet < 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于等于0的数！";
                        tipform.ShowDialog();
                    }
                    textBoxfet.Focus();
                    textBoxfet.SelectAll();
                }
                GlobalData.fetData = textBoxfet.Text;
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于等于0的数！";
                    tipform.ShowDialog();
                }
                textBoxfet.Focus();
                textBoxfet.SelectAll();
            }
        }
        #endregion

        #region 北进口实际流量
        private void TextBoxfnl_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxfnl.Text, out float fnl))
            {
                if (fnl < 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于等于0的数！";
                        tipform.ShowDialog();
                    }
                    textBoxfnl.Focus();
                    textBoxfnl.SelectAll();
                }
                GlobalData.fnlData = textBoxfnl.Text;
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于等于0的数！";
                    tipform.ShowDialog();
                }
                textBoxfnl.Focus();
                textBoxfnl.SelectAll();
            }
        }

        private void TextBoxfnt_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxfnt.Text, out float fnt))
            {
                if (fnt < 0)
                {
                    using (Formtip tipform = new Formtip())
                    {
                        tipform.label1.Text = "请输入大于等于0的数！";
                        tipform.ShowDialog();
                    }
                    textBoxfnt.Focus();
                    textBoxfnt.SelectAll();
                }
                GlobalData.fntData = textBoxfnt.Text;
            }
            else
            {
                using (Formtip tipform = new Formtip())
                {
                    tipform.label1.Text = "请输入大于等于0的数！";
                    tipform.ShowDialog();
                }
                textBoxfnt.Focus();
                textBoxfnt.SelectAll();
            }
        }
        #endregion

    }
}

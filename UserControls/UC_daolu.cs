using System;
using System.Windows.Forms;

namespace Traffic_competition.UserControls
{
    public partial class UC_daolu : UserControl
    {
        public UC_daolu()
        {
            InitializeComponent();
        }

        #region 西进口车道
        private void ComboBoxw1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalData.nwlData = comboBoxw1.Text;
        }

        private void ComboBoxw2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalData.nwtData = comboBoxw2.Text;
        }

        private void ComboBoxw3_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalData.nwrData = comboBoxw3.Text;
        }

        private void ComboBoxw4_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalData.nwtrData = comboBoxw4.Text;
        }
        #endregion

        #region 南进口车道
        private void ComboBoxs1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalData.nslData = comboBoxs1.Text;
        }

        private void ComboBoxs2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalData.nstData = comboBoxs2.Text;
        }

        private void ComboBoxs3_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalData.nsrData = comboBoxs3.Text;
        }

        private void ComboBoxs4_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalData.nstrData = comboBoxs4.Text;
        }
        #endregion

        #region 东进口车道
        private void ComboBoxe1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalData.nelData = comboBoxe1.Text;
        }

        private void ComboBoxe2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalData.netData = comboBoxe2.Text;
        }

        private void ComboBoxe3_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalData.nerData = comboBoxe3.Text;
        }

        private void ComboBoxe4_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalData.netrData = comboBoxe4.Text;
        }
        #endregion

        #region 北进口车道
        private void ComboBoxn1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalData.nnlData = comboBoxn1.Text;
        }

        private void ComboBoxn2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalData.nntData = comboBoxn2.Text;
        }

        private void ComboBoxn3_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalData.nnrData = comboBoxn3.Text;
        }

        private void ComboBoxn4_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalData.nntrData = comboBoxn4.Text;
        }
        #endregion
    }
}

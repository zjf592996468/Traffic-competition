using System.Windows.Forms;

namespace Traffic_competition.UserControls
{
    public partial class UC_info : UserControl
    {
        public UC_info()
        {
            InitializeComponent();
            labelversion.Text = "版本：V" + ProductVersion;
        }

    }
}

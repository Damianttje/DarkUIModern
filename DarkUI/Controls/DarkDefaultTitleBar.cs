using DarkUI.Forms;
using System.Windows.Forms;

namespace DarkUI.Controls
{
    public partial class DarkDefaultTitleBar : UserControl
    {
        #region Constructor
        public DarkDefaultTitleBar(DarkForm form)
        {
            InitializeComponent();

            lbTitle.Text = form.Text;

            darkToolStrip1.MouseDown += form.Drag;
            btnClose.Click += form.Close_Click;
            btnMaximize.Click += form.Maximize_Click;
            btnMinimize.Click += form.Minimize_Click;
        }
        #endregion
    }
}

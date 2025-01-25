using DarkUI.Forms;
using System.Windows.Forms;

namespace DarkUI.Controls
{
    public partial class DarkDefaultTitleBar : UserControl
    {
        #region Field Region
        DarkForm _form;
        DarkTitleBarStyle _titleBarStyle;
        #endregion

        #region Constructor
        public DarkDefaultTitleBar(DarkForm form, DarkTitleBarStyle titleBarStyle)
        {
            _form = form;

            InitializeComponent();

            lbTitle.Text = "<Form Text>";

            darkToolStrip1.MouseDown += _form.Drag;
            btnClose.Click += _form.Close_Click;

            if (titleBarStyle == DarkTitleBarStyle.Standard)
            {
                btnMaximize.Click += _form.Maximize_Click;
                btnMaximize.Visible = true;

                btnMinimize.Click += _form.Minimize_Click;
                btnMinimize.Visible = true;
            }
        }
        #endregion

        #region Event Handlers

        // Set the title bar text with the form's title
        private void DarkDefaultTitleBar_Load(object sender, System.EventArgs e)
        {
            lbTitle.Text = _form.Text;
        }

        #endregion
    }
}

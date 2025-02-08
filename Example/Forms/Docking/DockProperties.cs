using DarkUI.Controls;
using DarkUI.Docking;
using DarkUI.Managers;

namespace Example
{
    public partial class DockProperties : DarkToolWindow
    {
        #region Constructor Region

        public DockProperties()
        {
            InitializeComponent();

            // Build dummy dropdown data
            cmbList.Items.Add(new DarkDropdownItem("Item1"));
            cmbList.Items.Add(new DarkDropdownItem("Item2"));
            cmbList.Items.Add(new DarkDropdownItem("Item3"));
            cmbList.Items.Add(new DarkDropdownItem("Item4"));
            cmbList.Items.Add(new DarkDropdownItem("Item5"));
            cmbList.Items.Add(new DarkDropdownItem("Item6"));

            cmbList.SelectedItemChanged += delegate { System.Console.WriteLine($"Item changed to {cmbList.SelectedItem.Text}"); };
        }

        #endregion

        #region Event Region

        private void btnShowInfo_Click(object sender, System.EventArgs e)
        {
            DarkToastManager.ShowInfo("Info", "Info toast notification. This message is bigger then the others to demonstrate the Toasts auto-sizing functionality");
        }

        private void btnShowSuccess_Click(object sender, System.EventArgs e)
        {
            DarkToastManager.ShowSuccess("Success", "Success toast notification");
        }

        private void btnShowWarning_Click(object sender, System.EventArgs e)
        {
            DarkToastManager.ShowWarning("Warning", "Warning toast notification");
        }

        private void btnShowError_Click(object sender, System.EventArgs e)
        {
            DarkToastManager.ShowError("Error", "Error toast notification. This one uses the fade-in animation", useFadeInAnim: true);
        }

        private void btnCloseAll_Click(object sender, System.EventArgs e)
        {
            DarkToastManager.CloseAllToasts();
        }

        #endregion
    }
}

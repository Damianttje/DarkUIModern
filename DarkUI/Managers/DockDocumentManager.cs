using DarkUI.Docking;
using DarkUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DarkUI.Managers
{
    internal static class DockDocumentManager
    {
        private static List<Form> _darkHostForms = [];

        // Add a DarkDockContent to a new Host Form or an existing form if the mouse is released over one
        public static void AddToHostForm(DarkDockContent content, string title)
        {
            foreach (var form in _darkHostForms.Where(f => f != null && f.IsDisposed == false))
            {
                DarkDockPanel dockPanel = null;

                for (var i = 0; i < form.Controls.Count; i++)
                {
                    if (form.Controls[i] is DarkDockPanel)
                    {
                        dockPanel = (DarkDockPanel)form.Controls[i];
                        break;
                    }
                }

                if (dockPanel == null)
                {
                    continue;
                }

                if (dockPanel.ClientRectangle.Contains(dockPanel.PointToClient(Cursor.Position)))
                {
                    dockPanel.AddContent(content);
                    return;
                }
            }

            // If no form was found, create a new one
            var hostForm = new DarkHostForm()
            {
                Text = title,
                StartPosition = FormStartPosition.Manual
            };

            hostForm.DockPanel.AddContent(content);
            _darkHostForms.Add(hostForm);

            var screenBounds = Screen.FromPoint(Cursor.Position).WorkingArea;
            hostForm.Top = Math.Max(screenBounds.Top, Math.Min(Cursor.Position.Y - hostForm.Size.Height / 2, screenBounds.Bottom - hostForm.Size.Height));
            hostForm.Left = Math.Max(screenBounds.Left, Math.Min(Cursor.Position.X - hostForm.Size.Width / 2, screenBounds.Right - hostForm.Size.Width));

            hostForm.Show();
        }

        public static void AddHost(Control control)
        {
            var parentForm = control.FindForm();
            if (parentForm != null && !_darkHostForms.Contains(parentForm))
            {
                _darkHostForms.Add(parentForm);
            }
        }

        /// <summary>
        /// Remove a form from the list of open forms
        /// </summary>
        /// <param name="form"></param>
        public static void FormClosed(DarkHostForm form)
        {
            _darkHostForms.Remove(form);
        }
    }
}

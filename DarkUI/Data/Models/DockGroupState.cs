using System.Collections.Generic;

namespace DarkUI.Data.Models
{
    public class DockGroupState
    {
        #region Property Region

        public List<string> Contents { get; set; }

        public string VisibleContent { get; set; }

        #endregion

        #region Constructor Region

        public DockGroupState()
        {
            Contents = new List<string>();
        }

        #endregion
    }
}

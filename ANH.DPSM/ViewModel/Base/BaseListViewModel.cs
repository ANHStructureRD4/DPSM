using ANH.Database;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using static ANH.DPSM.DI;

namespace ANH.DPSM
{
    /// <summary>
    /// A view model for the overview analysis list
    /// </summary>
    public class BaseListViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The analysis list items for the Side Menu
        /// </summary>
        public List<BaseListItemViewModel> Items { get; set; }


        public List<EquipmentDataModel> BaseList { get; set; }

        #endregion

        #region Constructor

        public BaseListViewModel()
        {
        }

        #endregion

    }
}

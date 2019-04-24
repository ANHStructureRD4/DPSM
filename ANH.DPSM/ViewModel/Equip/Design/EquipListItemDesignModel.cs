using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ANH.DPSM
{
    /// <summary>
    /// The design-time data for a <see cref="EquipListItemViewModel"/>
    /// </summary>
    public class EquipListItemDesignModel : EquipListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static EquipListItemDesignModel Instance => new EquipListItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public EquipListItemDesignModel()
        {
            EquipID = 0;
            EquipName = "특화임무장비명";
            IsSelected = false;
        }

        #endregion
    }
}

using System.Collections.Generic;

namespace ANH.DPSM
{
    /// <summary>
    /// The design-time data for a <see cref="EquipmentManagementViewModel"/>
    /// </summary>
    public class EquipmentManagementDesignModel : EquipmentManagementViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static EquipmentManagementDesignModel Instance => new EquipmentManagementDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public EquipmentManagementDesignModel()
        {
            //FirstName = new TextEntryViewModel { Label = "Fist Name", OriginalText = "Luke" };
            //LastName = new TextEntryViewModel { Label = "Last Name", OriginalText = "Malpass" };
            //Username = new TextEntryViewModel { Label = "Username", OriginalText = "luke" };
            //Password = new PasswordEntryViewModel { Label = "Password", FakePassword = "********" };
            //Email = new TextEntryViewModel { Label = "Email", OriginalText = "contact@angelsix.com" };
        }

        #endregion
    }
}

﻿using ANH.Core;
using System.Collections.Generic;

namespace ANH.DPSM
{
    /// <summary>
    ///  The design-time data for a <see cref="MenuViewModel"/>
    /// </summary>
    public class MenuDesignModel : MenuViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static MenuDesignModel Instance => new MenuDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MenuDesignModel()
        {
            Items = new List<MenuItemViewModel>(new[]
            {
                new MenuItemViewModel { Type = MenuItemType.Header, Text = "Design time header..."},
                new MenuItemViewModel { Text = "Menu Item 1", Icon = IconType.File},
                new MenuItemViewModel { Text = "Menu Item 2", Icon = IconType.Picture},
            });
        }

        #endregion
    }
}

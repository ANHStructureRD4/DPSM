using ANH.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ANH.DPSM.DI;

namespace ANH.DPSM
{
    /// <summary>
    /// The design-time data for a <see cref="EquipListViewModel"/>
    /// </summary>
    public class EquipListDesignModel : EquipListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static EquipListDesignModel Instance => new EquipListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public EquipListDesignModel()
        {
            EquipList = BaseListItem.GetEquipmentListsAsync().Result;

            Items = new List<EquipListItemViewModel>
            {
                new EquipListItemViewModel
                {
                    EquipID = 0,
                    EquipName = "특화임무장비1",
                    IsSelected = false
                },
                new EquipListItemViewModel
                {
                    EquipID = 0,
                    EquipName = "특화임무장비2",
                    IsSelected = true
                },
            };

            //Items = new List<BaseListItemViewModel>
            //{
            //    new BaseListItemViewModel
            //    {
            //        Name = "Unit",
            //        Contents = AnalysisContent.Unit,
            //        IsSelected = true,
            //    },
            //    new BaseListItemViewModel
            //    {
            //        Name = "Geometry",
            //        Contents = AnalysisContent.Geometry,
            //        IsSelected = false,
            //    },
            //    new BaseListItemViewModel
            //    {
            //        Name = "Loads",
            //        Contents = AnalysisContent.Loads,
            //        IsSelected = false,
            //    },
            //    new BaseListItemViewModel
            //    {
            //        Name = "Analysis",
            //        Contents = AnalysisContent.parameter,
            //        IsSelected = false,
            //    },
            //    new BaseListItemViewModel
            //    {
            //        Name = "Results",
            //        Contents = AnalysisContent.Result,
            //        IsSelected = false,
            //    },
            //};
        }
        #endregion
    }
}

using ANH.Core;
using ANH.Database;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using static ANH.DPSM.DI;

namespace ANH.DPSM
{
    /// <summary>
    /// A view model for each Equip list item in the overview Equip list
    /// </summary>
    public class EquipListItemViewModel : BaseViewModel
    {
        #region public Properties

        /// <summary>
        /// Auto increase id
        /// </summary>
        public int EquipID { get; set; }

        /// <summary>
        /// The display base name
        /// </summary>
        public string EquipName { get; set; }

        /// <summary>
        /// The base count 
        /// </summary>
        public int cnt { get; set; }

        /// <summary>
        /// True if this item is currently selected
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// The icon source of local storage
        /// </summary>
        public string IconSource { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// The command for when the Equipment name is clicked
        /// </summary>
        public ICommand EquipContentClickCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public EquipListItemViewModel()
        {
            // Create commands
            EquipContentClickCommand = new RelayParameterizedCommand(EquipContentClick);
        }
        #endregion

        #region Command Methods
        /// <summary>
        /// When the content list item is clicked, detail page is open
        /// </summary>
        /// <param name="parameter">Equipment ID</param>
        public void EquipContentClick(object parameter)
        {
            if (parameter == null)
                return;

            var baseparameter = (EquipListItemViewModel)parameter;

            var baseviewmodel = new BaseViewModel
            {
                //TitleName = analysisparameter.AnalysisName,
                //AnalysisSubListVisible = true,
                //CurrentContent = analysisparameter.Contents,
                //Items = new List<AnalysisSubListItemViewModel>
                //        {
                //            new AnalysisSubListItemViewModel
                //            {
                //                AnalysisName = analysisparameter.AnalysisName,
                //                Name = analysisparameter.AnalysisName,
                //                Contents = AnalysisContent.Unit,
                //                IsSelected = analysisparameter.Contents == AnalysisContent.Unit
                //            },
                //            new AnalysisSubListItemViewModel
                //            {
                //                AnalysisName = analysisparameter.AnalysisName,
                //                Name = "Geometry",
                //                Contents = AnalysisContent.Geometry,
                //                IsSelected = analysisparameter.Contents == AnalysisContent.Geometry
                //            },
                //            new AnalysisSubListItemViewModel
                //            {
                //                AnalysisName = analysisparameter.AnalysisName,
                //                Name = "Loads",
                //                Contents = AnalysisContent.Loads,
                //                IsSelected = analysisparameter.Contents == AnalysisContent.Loads
                //            },
                //            new AnalysisSubListItemViewModel
                //            {
                //                AnalysisName = analysisparameter.AnalysisName,
                //                Name = "Analysis",
                //                Contents = AnalysisContent.parameter,
                //                IsSelected = analysisparameter.Contents == AnalysisContent.parameter
                //            },
                //            new AnalysisSubListItemViewModel
                //            {
                //                AnalysisName = analysisparameter.AnalysisName,
                //                Name = "Result",
                //                Contents = AnalysisContent.Result,
                //                IsSelected = analysisparameter.Contents == AnalysisContent.Result
                //            },
                //        },
            };

            // Get analysis content List and data
            ViewModelApplication.GoToPage(ApplicationPage.Analysis, baseviewmodel);
        }
        #endregion

        //#region Public Helper Methods

        ///// <summary>
        ///// Creates a new <see cref="BaseListItemViewModel"/>
        ///// from this model
        ///// </summary>
        ///// <returns></returns>
        //public BaseListItemViewModel ToBaseListItemViewModel(BaseListItemDataModel dataModel)
        //{
        //    return new BaseListItemViewModel
        //    {
        //        Name = dataModel.Name,
        //        count = dataModel.count,
        //        Contents = (AnalysisContent)dataModel.Contents,
        //        IsSelected = dataModel.IsSelected,
        //        IconSource = dataModel.IconSource,

        //    };
        //}

        //#endregion

        #region Private Helper Methods

        /// <summary>
        /// Loads the settings from the local data store and binds them 
        /// to this view model
        /// </summary>
        /// <returns></returns>
        private async Task UpdateValuesFromLocalStoreAsync(IBaseListDataStore baseListDataStore)
        {
            // Get the stored credentials
            var storedBaseList = await baseListDataStore.GetEquipmentListsAsync();

            //Name = storedBaseList?.Name;
            //count = storedBaseList?.count;
            //Contents = (AnalysisContent)storedBaseList.Contents,
            //IsSelected = storedBaseList.IsSelected,
            //IconSource = storedBaseList.IconSource
        }

        #endregion
    }
}

using System;

namespace ANH.Core
{
    /// <summary>
    ///  The application state as a view model
    /// </summary>
    public class ApplicationViewModel : BaseViewModel
    {
        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.Analysis;

        /// <summary>
        /// The current library of the application
        /// </summary>
        public ApplicationPage CurrentLibrary { get; private set; } = ApplicationPage.Library;

        /// <summary>
        /// The view model to use for the current page when the CurrentPage changes
        /// NOTE: This is not a live up-to-date view model of the current page
        ///       it is simply used to set the view model of the current page
        ///       at the time it changes
        /// </summary>
        public BaseViewModel CurrentPageViewModel { get; set; }

        /// <summary>
        /// The view model to use for the current library when the CurrentLibrary changes
        /// NOTE: This is not a live up-to-date view model of the current library
        ///       it is simply used to set the view model of the current library
        ///       at the time it changes
        /// </summary>
        public BaseViewModel CurrentLibraryViewModel { get; set; }

        /// <summary>
        /// The current analysis content of the application
        /// </summary>
        public AnalysisCategory CurrentCategory { get; set; } = AnalysisCategory.PlainStrengthAnalysis;

        /// <summary>
        /// True if the side menu should be shown
        /// </summary>
        public bool SideMenuVisible { get; set; } = true;

        /// <summary>
        /// True if the side menu should be shown
        /// </summary>
        public bool LibraryWideMenuVisible { get; set; } = false;

        /// <summary>
        /// True if the side menu should be shown
        /// </summary>
        public bool AnalysisWideMenuVisible { get; set; } = false;

        /// <summary>
        /// True if the settings menu should be shown
        /// </summary>
        public bool SettingsMenuVisible { get; set; }

        /// <summary>
        /// Navigates to the specified page
        /// </summary>
        /// <param name="page"></param>
        /// <param name="viewModel">The view model, if any, to set explicitly to the new page</param>
        public void GoToPage(ApplicationPage page, BaseViewModel viewModel = null)
        {
            // Always hide settings page if we are changing pages
            SettingsMenuVisible = false;

            // set the view model
            CurrentPageViewModel = viewModel;

            // Set the current page
            CurrentPage = page;

            // Fire off a current page changed event
            OnPropertyChanged(nameof(CurrentPage));

            //OnPropertyChanged(nameof(CurrentPage));

            // Show side menu or not?
            SideMenuVisible = page == ApplicationPage.Analysis;
        }

        /// <summary>
        /// Navigates to the specified page
        /// </summary>
        /// <param name="page"></param>
        /// <param name="viewModel">The view model, if any, to set explicitly to the new page</param>
        public void GoToLibrary(ApplicationPage page, BaseViewModel viewModel = null)
        {
            // Always hide settings page if we are changing pages
            SettingsMenuVisible = false;

            // set the view model
            CurrentLibraryViewModel = viewModel;

            // Set the current page
            CurrentLibrary = page;

            // Fire off a current page changed event
            OnPropertyChanged(nameof(CurrentLibrary));

            //OnPropertyChanged(nameof(CurrentPage));

            // Show side menu or not?
            SideMenuVisible = page == ApplicationPage.Library;
        }
    }
}

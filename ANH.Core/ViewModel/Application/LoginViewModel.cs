using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ANH.Core
{
    /// <summary>
    /// The View Model for a login screen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {

        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flag indicating if the login command is running
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion

        #region Commands
        
        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// The command to register for a new account
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="window"></param>
        public LoginViewModel()
        {
            // Create commands
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await LoginAsync(parameter));
            RegisterCommand = new RelayCommand(async () => await RegisterAsync());

        }

        #endregion

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password </param>
        /// <returns></returns>
        private async Task LoginAsync(object parameter)
        {
            await RunCommandAsync(() => LoginIsRunning, async () =>
            {
                await Task.Delay(1000);

                // TODO: Remove this with real information pulled from our database in future
                IoC.Settings.Name = new TextEntryViewModel { Label = "Name", OriginalText = $"Young-Min Lee {DateTime.Now.ToLocalTime()}" };
                IoC.Settings.Username = new TextEntryViewModel { Label = "Username", OriginalText = "lee" };
                IoC.Settings.Password = new PasswordEntryViewModel { Label = "Password", FakePassword = "********" };
                IoC.Settings.Email = new TextEntryViewModel { Label = "Email", OriginalText = "youngmin.lee@anhstructure.com" };

                // Go to Chat page
                IoC.Application.GoToPage(ApplicationPage.Analysis);

                //var email = Email;

                //// IMPORTANT: Never store unsecure password in variable like this
                //var pass = (parameter as IHavePassword).SecurePassword.Unsecure();
            });

        }

        /// <summary>
        /// Takes the user to the register page 
        /// </summary>
        /// <returns></returns>
        private async Task RegisterAsync()
        {
            //  Go to register page?
            IoC.Application.GoToPage(ApplicationPage.Register);

            //((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Register;

            await Task.Delay(1);
        }

    }
}

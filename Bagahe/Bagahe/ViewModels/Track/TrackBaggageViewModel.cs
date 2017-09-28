using Acr.UserDialogs;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bagahe.Core.ViewModels.Track
{
    public class TrackBaggageViewModel : BaseViewModel
    {
        //private readonly IUserDialogs _userDialog;
        private string _bagTagNumber;
        private string _passengerName;
        /*
        public TrackBaggageViewModel(IUserDialogs userDialog)
        {
            _userDialog = userDialog;
            InitCommands();
        }
        */
        public TrackBaggageViewModel()
        {
            InitCommands();
        }
        public string BagTagNumber
        {
            get { return _bagTagNumber; }
            set { SetProperty(ref _bagTagNumber, value); }
        }

        public string PassengerName { set { _passengerName = value; } }

        public ICommand ScanBagTagCommand { protected set; get; }

        public ICommand TrackBagCommand { private set; get; }

        private void InitCommands()
        {
            ScanBagTagCommand = new Command(async () =>
            {
                //change this to a code that can scan a bag tag (or maybe install??)
                //using (_userDialog.Loading("Scanning Bag Tag #..."))
                {
                    await Task.Delay(3000).ContinueWith(_ =>
                    {
                        BagTagNumber = "123456789";
                    });
                }
            });

            TrackBagCommand = new Command(async () =>
            {
                //change this to a code that can track the bag then redirect to result view
                //using (_userDialog.Loading("Tracking Your Baggage"))
                {
                    await Task.Delay(3000).ContinueWith(_ =>
                    {
                        ShowViewModel<TrackBaggageResultViewModel>();
                    });
                }
            });
        }
    }
}

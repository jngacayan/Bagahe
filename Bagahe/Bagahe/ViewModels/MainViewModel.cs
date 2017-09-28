using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace Bagahe.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string _text;
        private IMvxCommand _showTextCommand;

        public IMvxCommand ShowTextCommand => _showTextCommand = _showTextCommand ?? new MvxCommand(DoShowTextCommand);

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }

        private void DoShowTextCommand()
        {
            Text = "Hello MvvmCross!";
        }
    }
}
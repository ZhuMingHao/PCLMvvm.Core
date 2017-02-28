using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace PCLMvvm.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private string _yourNickname = "???";

        protected override void InitFromBundle(IMvxBundle parameters)
        {
            base.InitFromBundle(parameters);
            var te = parameters.Data;
        }

        public string YourNickname
        {
            get { return _yourNickname; }
            set { _yourNickname = value; RaisePropertyChanged(() => YourNickname); RaisePropertyChanged(() => Hello); RaisePropertyChanged(() => IsVisible); }
        }

        public string Hello
        {
            get { return "Hello " + YourNickname; }
        }

        public bool IsVisible
        {
            get
            {
                return YourNickname.Length > 6 ? true : false;
            }
        }

        public ICommand ShowboutPageCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<AboutViewModel>(new { Hello, YourNickname }));
            }
        }
    }
}
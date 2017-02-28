using MvvmCross.Core.ViewModels;

namespace PCLMvvm.Core.ViewModels
{
    public class AboutViewModel : MvxViewModel
    {
        protected override void InitFromBundle(IMvxBundle parameters)
        {
            base.InitFromBundle(parameters);
            var te = parameters.Data;
        }

        public AboutViewModel()
        {
        }
    }
}
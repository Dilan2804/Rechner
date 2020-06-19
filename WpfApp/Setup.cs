using MvvmCross.ViewModels;

namespace WpfApp
{
    public class Setup : MvxApplication
    {
        public override void Initialize()
        {           
                RegisterAppStart<MainViewModel>();            
        }
    }
}

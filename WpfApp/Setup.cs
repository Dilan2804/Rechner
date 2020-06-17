using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.ViewModels;

namespace WpfApp
{
    class Setup : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            {
                RegisterAppStart<MainViewModel>();
            }
        }
    }
}

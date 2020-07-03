using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Rechner.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public class MainViewModel : MvxViewModel
    {
        Rechenautomat calc = new Rechenautomat();

        public MainViewModel()
        {
            this.CheckCommand = new MvxCommand(Check, CanCheck);
        }

        public string Title => "Rechenautomat";

        public string Name => "Max Mustermann";

        public string Calculation
        {
            get
            {
                return calc.NächsteBerechnung;
            }
        }

        private string _userInput = "";

        public string UserInput
        {
            get { return _userInput; }
            set {
                _userInput = value;
                RaisePropertyChanged(() => UserInput);
                this.CheckCommand.RaiseCanExecuteChanged();
            }
           
        }

        /**
         * Comands
         */

        #region Commands
        public MvxCommand CheckCommand { get; set; }

        public void Check()
        {
            var zahl = Convert.ToInt32(this.UserInput);

            var erg = this.calc.Prüfe(zahl);

            RaisePropertyChanged(() => Calculation);

            if (erg)
            {
                //richtig
            }
            else
            {
                //falsch
            }
        }

        

        public bool CanCheck()
        {
            return this.UserInput.Trim().Length != 0;
        }


        #endregion 




    }
}

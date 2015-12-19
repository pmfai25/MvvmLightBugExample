using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;

namespace MvvmLigthBugExposition.ViewModels
{
    public class DetailViewModel
    {
        private readonly bool field;
        public DetailViewModel()
        {
            bool variable = SomeComputation();
            UseVariableCommand = new RelayCommand(Some, () => variable);

            field = SomeComputation();
            UseFieldCommand = new RelayCommand(Some, () => field);
        }
        
        public ICommand UseVariableCommand { get; private set; }

        public ICommand UseFieldCommand { get; private set; }

        private void Some()
        {
            
        }

        private bool SomeComputation()
        {
            return true;
        }
    }
}
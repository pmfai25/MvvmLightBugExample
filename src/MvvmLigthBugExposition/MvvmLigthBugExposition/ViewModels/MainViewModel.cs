using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace MvvmLigthBugExposition.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private DetailViewModel content;

        public MainViewModel()
        {
            SetContent100PercentBugProbabilityCommand = new RelayCommand(SetContent100PercentBugProbability);
            SetContent50PercentBugProbabilityCommand = new RelayCommand(SetContent50PercentBugProbability);
        }

        public DetailViewModel Content
        {
            get { return content; }
            private set { Set(ref content, value); }
        }

        public ICommand SetContent100PercentBugProbabilityCommand { get; private set; }

        public ICommand SetContent50PercentBugProbabilityCommand { get; private set; }

        private void SetContent100PercentBugProbability()
        {
            Content = new DetailViewModel();
            GC.Collect();
        }

        private void SetContent50PercentBugProbability()
        {
            Content = new DetailViewModel();
            byte[] array = new byte[1024*1024*10];
        }
    }
}
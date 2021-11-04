using HexQuery.Commands;
using HexQuery.Store;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace HexQuery.ViewModels
{
    public class FileListViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to my application.";

        public ICommand NavigateLoginCommand { get; }

        public FileListViewModel(NavigationStore navigationStore)
        {
            NavigateLoginCommand = new NavigateCommand(navigationStore);
        }

        public FileListViewModel()
        {
        }
    }
}

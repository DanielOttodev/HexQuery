using HexQuery.Store;
using HexQuery.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HexQuery.Commands
{
    public class NavigateCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new FileListViewModel();
        }
    }
}

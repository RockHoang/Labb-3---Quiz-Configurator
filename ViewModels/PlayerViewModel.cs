using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Threading;

namespace Labb_3___Quiz_Configurator.ViewModels
{
    class PlayerViewModel : ViewModelBase
    {
        private readonly MainWindowViewModel? _mainWindowViewModel;

        private DispatcherTimer gameTimer;



        public PlayerViewModel(MainWindowViewModel? mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
        }
    }
}

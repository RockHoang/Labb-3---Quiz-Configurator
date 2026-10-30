using Labb_3___Quiz_Configurator.Commands;
using Labb_3___Quiz_Configurator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Quiz_Configurator.ViewModels
{
    class ConfigurationViewModel : ViewModelBase
    {
        private readonly MainWindowViewModel? _mainWindowViewModel;

        public RelayCommand ChangePackNameCommand { get; }
        public RelayCommand DisplayContentCommand { get; }
        public QuestionPackViewModel? ActivePack { get => _mainWindowViewModel?.ActivePack; }

        private Question _selectedQuestion;

        public Question SelectedQuestion
        {
            get => _selectedQuestion;
            set
            {
                _selectedQuestion = value;
            }
        }

        public void RaiseActivePackChanged() => RaisePropertyChange(nameof(ActivePack));

        public ConfigurationViewModel(MainWindowViewModel? mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;

            ChangePackNameCommand = new RelayCommand(ChangePackName);
            DisplayContentCommand = new RelayCommand(DisplayContent);
        }

        private void ChangePackName(object? obj)
        {
            ActivePack.Name = "New Name";
            //throw new NotImplementedException();
        }

        private void DisplayContent(object? obj)
        {
            //throw new NotImplementedException();
        }
    }
}

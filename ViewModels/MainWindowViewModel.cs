using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Labb_3___Quiz_Configurator.Models;

namespace Labb_3___Quiz_Configurator.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<QuestionPackViewModel> Packs { get; }

        private QuestionPackViewModel _activePack;

        public PlayerViewModel? PlayerViewModel { get; }

        public ConfigurationViewModel? ConfigurationViewModel { get; }


        public QuestionPackViewModel ActivePack 
        { 
            get => _activePack;
            set => SetProperty(ref _activePack, value);
              
        }

        public MainWindowViewModel()
        {
            PlayerViewModel = new PlayerViewModel(this);
            ConfigurationViewModel = new ConfigurationViewModel(this);

            var questionPack = new Models.QuestionPack("Mina frågor");
            questionPack.Questions.Add(new Question("Vad heter Sveriges huvudstad?", "Stockholm", "Oslo", "Berlin", "Paris"));
            questionPack.Questions.Add(new Question("Vad är 2+2?", "4", "8", "16", "32"));
            ActivePack = new QuestionPackViewModel(new Models.QuestionPack("Mina frågor"));
        }
    }
}

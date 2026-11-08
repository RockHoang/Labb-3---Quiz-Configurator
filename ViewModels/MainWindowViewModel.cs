using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using Labb_3___Quiz_Configurator.Commands;
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
            set {
                if (SetProperty(ref _activePack, value)) {
                    ConfigurationViewModel?.RaiseActivePackChanged();
                }
            
            } 
            
              
        }

        public RelayCommand SwitchToPlayerViewCommand { get; }
        public RelayCommand SwitchToConfigViewCommand { get; }
        public RelayCommand EnableFullScreenCommand { get; }

        public MainWindowViewModel()
        {
            PlayerViewModel = new PlayerViewModel(this);
            ConfigurationViewModel = new ConfigurationViewModel(this);

            var questionPack = new Models.QuestionPack("Mina frågor");
            questionPack.Questions.Add(new Question("Vad heter Sveriges huvudstad?", "Stockholm", "Oslo", "Berlin", "Paris"));
            questionPack.Questions.Add(new Question("Vad är 2+2?", "4", "8", "16", "32"));
            ActivePack = new QuestionPackViewModel(questionPack);
            SwitchToPlayerViewCommand = new RelayCommand(SwitchToPlayerView);
            SwitchToConfigViewCommand = new RelayCommand(SwitchToConfigView);
            EnableFullScreenCommand = new RelayCommand(EnableFullscreen);
        }
        public bool IsPlayViewVisible { get; set; } = false;
        public bool IsConfigViewVisible { get; set; } = true;

        private void SwitchToPlayerView(object? obj)
        {
            
            IsPlayViewVisible = true;
            IsConfigViewVisible = false;
            RaisePropertyChange(nameof(IsPlayViewVisible));
            RaisePropertyChange(nameof(IsConfigViewVisible));
        }

        private void SwitchToConfigView(object? obj)
        {

            IsPlayViewVisible = false;
            IsConfigViewVisible = true;
            RaisePropertyChange(nameof(IsPlayViewVisible));
            RaisePropertyChange(nameof(IsConfigViewVisible));
        }

        private void EnableFullscreen(object? obj)
        {

            if (Application.Current.MainWindow.WindowState == WindowState.Normal)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else 
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }
    }
}

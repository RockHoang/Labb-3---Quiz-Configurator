using Labb_3___Quiz_Configurator.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Labb_3___Quiz_Configurator.ViewModels
{
    internal class QuestionPackViewModel : ViewModelBase
    {
        private readonly QuestionPack _model;
        public QuestionPackViewModel(QuestionPack model)
        {
            _model = model;
            Questions = new ObservableCollection<Question>(_model.Questions);
        }
        public string Name
        {
            get { return _model.Name;}
            set 
            {
                if (_model.Name == value)
                    return;

                _model.Name = value;
                RaisePropertyChange();
            
            }
        
        }

        public Diffculty Difficulty
        {
            get { return _model.Diffculty; }
            set {
                if (_model.Diffculty == value)
                    return;
                _model.Diffculty = value;
                RaisePropertyChange();        
            }
        
        }

        //public event PropertyChangedEventHandler? PropertyChanged;

        public int TimeLimitInSeconds
        { 
            get => _model.TimeLimitInSeconds;
            set 
            {
                if (_model.TimeLimitInSeconds == value)
                    return;
                _model.TimeLimitInSeconds = value;
                RaisePropertyChange(); 

            }
        }


        public ObservableCollection<Question> Questions { get; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

internal enum Diffculty {Easy, Medium, Hard};
namespace Labb_3___Quiz_Configurator.Models
{
    internal class QuestionPack 
    {
        public QuestionPack(string name, Diffculty diffculty = Diffculty.Medium, int timeLimitInSeconds = 30)
        {
            Name = name;
            Diffculty = diffculty;
            TimeLimitInSeconds = timeLimitInSeconds;
            Questions = new List<Question>();
        }

        public string Name { get; set; }
        public Diffculty Diffculty{ get; set; }
        public int TimeLimitInSeconds { get; set; }
        public List<Question> Questions { get; set; }

    }
}

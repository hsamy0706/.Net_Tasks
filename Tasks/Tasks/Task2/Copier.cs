using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task2
{
    internal class Copier : OfficeMachine
    {
        public Copier(string modelName) : base(modelName)
        {
        }
        
        public override void Start()
        {
            Console.WriteLine("Copier is starting up...");
        }
    }
}

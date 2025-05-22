using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task2
{
    internal abstract class OfficeMachine
    {
        public string ModelName { get; private set; }
        public OfficeMachine(string modelName)
        {
            ModelName = modelName;
        }
        public void ShowModelInfo()
        {
            Console.WriteLine($"Model: {ModelName}");
        }
        public abstract void Start();
    }
}

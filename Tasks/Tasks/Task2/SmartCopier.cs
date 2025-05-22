using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task2
{
    internal class SmartCopier : OfficeMachine, IPrinter, IScanner, IFax, IMaintenance
    {
        public SmartCopier(string modelName):base(modelName)
        {

        }
        void IFax.Fax(string doc, string number)
        {
            Console.WriteLine($"SmartCopier faxing: {doc} to {number}");
        }

        public void PowerOn()
        {
            Console.WriteLine("SmartCopier is powered on.");
        }

        public void Print(string documentName)
        {
            Console.WriteLine($"SmartCopier printing: {documentName}");
        }

        public void Scan(string doc)
        {
            Console.WriteLine($"SmartCopier scan: {doc}");

        }

        public void SelfCheck()
        {
            Console.WriteLine("SmartCopier self-check in progress...");

        }

        public override void Start()
        {
            Console.WriteLine("SmartCopier is initializing...");
        }
    }
}

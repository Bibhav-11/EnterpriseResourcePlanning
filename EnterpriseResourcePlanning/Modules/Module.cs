using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterpriseResourcePlanning.Modules;

namespace EnterpriseResourcePlanning.Modules
{
    public class Module
    {
        public int ModuleID { get; set; }   
        public string? Name { get; set; }

        public Module(string name)
        {
            Name = name;
        }

        public virtual void Run()
        {
            Console.WriteLine($"Executing module {Name}");
        }

    }
}

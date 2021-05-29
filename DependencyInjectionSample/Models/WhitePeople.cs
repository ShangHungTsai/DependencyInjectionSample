using DependencyInjectionSample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Models
{
    public class WhitePeople : IPeople
    {
        public string Race() { return "白種人"; }
    }
}

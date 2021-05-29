using DependencyInjectionSample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Controllers
{
    public class Person
    {
        private readonly IPeople _people;
        private readonly IWeapon _weapon;

        public Person(IPeople p, IWeapon w)
        {
            _people = p;
            _weapon = w;
        }
        public void Introduction()
        {
            Console.WriteLine("我是" + _people.Race());
        }
        public void Kill(string name)
        {
            Console.WriteLine(_weapon.Fire() + " the Person," + name);
        }
    }
}

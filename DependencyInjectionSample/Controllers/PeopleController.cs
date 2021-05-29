using DependencyInjectionSample.Interfaces;
using DependencyInjectionSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Controllers
{
    public class People
    {
        //People物件依賴類別Gun
        private Gun _gun = new Gun();

        //透過介面取得控制反轉後的物件
        private readonly IWeapon _weapon;

        public People(IWeapon w)
        {
            _weapon = w;
        }

        //使用介面中物件的方法
        public void Kill(string name) { Console.WriteLine(_weapon.Fire() + " the Person," + name); }
    }
}

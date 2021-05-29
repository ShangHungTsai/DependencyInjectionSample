using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 此範例用Unity。
            // Unity套件是IoC容器的一個框架

            // 建立IoC容器。
            IUnityContainer container = new UnityContainer();

            // 將物件註冊在IoC容器中。
            // 依賴注入：由IOC提供Gun物件來使用
            // 把要依賴的部分通通在IOC容器裡面配置好，當日後類別要依賴物件時，透過容器給予。
            container.RegisterType<IWeapon, Gun>();
            //container.RegisterType<IWeapon, Knife>();

            container.RegisterType<IPeople, WhitePeople>();
            //container.RegisterType<IWeapon, BlackPeople>();

            // 解析IOC容器取得註冊的執行個體。
            // 讓People類別 原本依賴Gun的部分，轉而依賴IOC
            var person = container.Resolve<Person>();
            person.Introduction();
            person.Kill("Sammy");

            var people = container.Resolve<People>();
            people.Kill("Max");
            Console.ReadKey();
        }
        public interface IPeople {
            string Race();
        }
        public class WhitePeople : IPeople {
            public string Race() { return "白種人"; }
        }

        public class Person 
        {
            private readonly IPeople _people;
            private readonly IWeapon _weapon;

            public Person(IPeople p,IWeapon w) 
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
                Console.WriteLine( _weapon.Fire() + " the Person," + name); 
            }
        }

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

        public class Gun : IWeapon
        {
            public string Fire() { return "蹦蹦"; }
        }

        public class Knife : IWeapon
        {
            public string Fire() { return "砍"; }
        }

        public interface IWeapon
        {
            string Fire();
        }
    }
}

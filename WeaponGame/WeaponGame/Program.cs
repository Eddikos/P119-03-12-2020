using System;

namespace WeaponGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var gun = new Weapon();
            gun.Name = "AK47";
            gun.WeaponType = "Avtomat";
            gun.WeaponCapacity = 5;
            gun.CurrentWeaponCapacity = 5;
            gun.BulletTotal = 50;

            Console.WriteLine(gun.Name);
            Console.WriteLine(gun.WeaponCapacity);
            Console.WriteLine("My current Capacity: " + gun.Shoot());
            Console.WriteLine("My current Capacity: " + gun.Shoot());
            Console.WriteLine("My current Capacity: " + gun.Shoot());
            Console.WriteLine("My current Capacity: " + gun.Shoot());
            Console.WriteLine("My current Capacity: " + gun.Shoot());
            Console.WriteLine("My current Capacity: " + gun.Shoot());

            gun.Reload();
            Console.WriteLine(gun.CurrentWeaponCapacity);
            Console.WriteLine(gun.BulletTotal);
            Console.WriteLine("My current Capacity: " + gun.Shoot());
            Console.WriteLine("My current Capacity: " + gun.Shoot());
            Console.WriteLine("My current Capacity: " + gun.Shoot());
            gun.Reload();
            Console.WriteLine(gun.CurrentWeaponCapacity);
            Console.WriteLine(gun.BulletTotal);


            // Ternary conditional operator
            int a = 100;
            int b = 200;
            var result = (a < b) ? "a kichikdir b-den" : "b kichikdir (ya da =) a-dan";

            var result1 = "";
            if (a < b)
                result1 = "a kichikdir b-den";
            else
                result1 = "b kichikdir (ya da =) a-dan";

            // Method Overloading
            Calculate(5, 7);
            Calculate(5);




            //Weapon gun2 = new Weapon();
            //gun2.Name = "Makarov";
            //gun2.WeaponCapacity = 9;
            //gun2.BulletTotal = 200;

            //Console.WriteLine(gun2.BulletTotal);

            var eldar = new Teacher();
            eldar.Name = "Eldar";
            eldar.DailyRate = 300;
            eldar.DaysWorked = 30;
           //eldar.Salary = 100;
            Console.WriteLine(eldar.ReturnSalary());
            Console.WriteLine(eldar.PublicSalary);
        }

        class Teacher 
        { 

            public string Name { get; set; }
            public int DailyRate { get; set; }
            public int DaysWorked { get; set; }
            private int Salary { get; set; }
            public int PublicSalary { get { return Salary; } }


            public int ReturnSalary()
            {
                Salary = DaysWorked * DailyRate;
                return Salary;
            }
        }

        class Weapon
        { 
            public string Name { get; set; }
            public string WeaponType { get; set; }
            public int WeaponCapacity { get; set; }
            public int CurrentWeaponCapacity { get; set; }
            public int BulletTotal { get; set; }

            public int Shoot()
            {
                if (CurrentWeaponCapacity <= 0)
                {
                    Console.WriteLine("Weapon Capactiy is 0");
                    return 0;
                }
                else
                {
                    CurrentWeaponCapacity--;
                    return CurrentWeaponCapacity;
                }
            }

            public void Reload()
            {   
                var difference = WeaponCapacity - CurrentWeaponCapacity;
                if (difference >= BulletTotal)
                {
                    CurrentWeaponCapacity = CurrentWeaponCapacity + BulletTotal;
                    BulletTotal = 0;
                }
                else 
                {
                    BulletTotal = BulletTotal - difference;
                    CurrentWeaponCapacity = CurrentWeaponCapacity + difference;
                }
            }

        }




        public static void Calculate(int a, int b)
        {
            int c = a + b;
        }

        public static void Calculate(int a)
        {
            int c = a;
        }
    }
}

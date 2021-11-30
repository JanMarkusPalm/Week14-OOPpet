using System;

namespace ClassCat
{
    class Program
    {
        class cat
        {
            string name;
            int age;
            double weight;

            public cat(string _name) //constructor
            {
                name = _name;
                age = 0;
                weight = 0.1;
                Console.WriteLine($"Congratz. You've adopted {name}!");
            }

            public double Weight
            {
                get
                { return weight; }
            }
            
            public void ShowPetInfo()
            {
                Console.WriteLine($"name:{name}");
                Console.WriteLine($"age:{age}");
                Console.WriteLine($"fatness:{weight}");
            }
            //public void rename(string NewName)
            //{
            //    Console.WriteLine($"Enter a new namefor the cat {Name}");
            //}
            public void Eat()
            {
                weight += 0.2; //weight = weight + 0.2
                Console.WriteLine("jumyumomnomIWENOSMARWEQWYUMYDJNLT");
            }
            public void run()
            {
                weight -= 0.1;
                Console.WriteLine("huuh-haah");
            }

            //destructor V
            //~cat()
            //{
            //    Console.WriteLine($"unlucky, ur feline {name} died..");
            //}


        }
        

        static void Main(string[] args)
        {
            cat mycat = new cat("Pätt");
            mycat.ShowPetInfo();
            for (int i = 0; i < 10; i++ )
            {
                mycat.Eat();
                Console.WriteLine($"current fatness : {mycat.Weight}");
                if (mycat.Weight >= 0.7)
                {

                    while (mycat.Weight > 0.7)
                    {
                        mycat.run();
                        Console.WriteLine($"fatness after workout : {mycat.Weight}");
                    }

                }

            }
        }
    }
}

using System;
using System.Xml.Linq;

namespace MenuCard
{
    class program
    {
        static Stack<string> name = new Stack<string>();

      //push  name method
        public static void pushname()
        {
            Console.WriteLine("enter a name then push");
            string num = Console.ReadLine();
            name.Push(num);
            foreach (var item in name)
            {

                Console.WriteLine(item);
            }
        }

        //pop name method
        public static void popname()
        {
            Console.WriteLine("---Pop---");
            if (name.Count > 0)
            {
                string remove = name.Pop();
                Console.WriteLine("pop name is :" + remove);
            }
            foreach (var item in name)
            {
                Console.WriteLine(item);

            }

        }
        
        //peek name method
        public static void peekname()
        {
            Console.WriteLine("---Peek---");
            string data = name.Peek();
            Console.WriteLine(data);

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }

        }

        //display the data method
        public static void display()
        {
            Console.WriteLine("---Display---");
            if (name.Count == 0)
            {
                Console.WriteLine("Stack is empty. Nothing to display.");
            }
            else
            {
                Console.WriteLine("stack content (Top->Bottom)");
                foreach (var item in name)
                {
                    Console.WriteLine("Display name " + item);
                }
            }
        }

        //menu card method
        public static void menucard()
        {
            do
            {
                Console.WriteLine("Which Stack Operation do you want? ");
                Console.WriteLine("\n1.push" + "\n2.pop" + "\n3.peek" + "\n4.Display" + "\n5.Exit");
                int menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        pushname();
                        break;
                    case 2:
                       popname();
                        break;
                    case 3:
                        peekname();
                        break;
                    case 4:
                        display();
                        break;
                    case 5:
                        Console.WriteLine("Existing");
                        break;
                    default:
                        Console.WriteLine("invalid choice try again");
                        break;
                }
                Console.WriteLine("\ndo you want more operation or not");
            } while (Console.ReadLine().ToLower() == "y");
        }

//main method
        static void Main()
        {
  menucard();
        }
    }

}


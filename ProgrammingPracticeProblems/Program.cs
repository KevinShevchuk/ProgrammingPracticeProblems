using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPracticeProblems
{
    class Program
    {
        private static List<Type> _classList = new List<Type>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            GetClassList();
            while (true)
            {
                Console.WriteLine("Type \"dir\" to display all the available problems. Type the name to run it.");
                Console.WriteLine("Type \"exit\" to quit.");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "dir":
                        PrintDir();
                        break;
                    case "exit":
                        System.Environment.Exit(0);
                        break;
                    default:
                        FindProblem(input);
                        break;
                        
                }
            }
        }

        private static void GetClassList()
        {
            var q = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.Namespace == "PracticeProblems"
                    select t;
            _classList.AddRange(q.ToList());
        }

        private static void PrintDir()
        {
            Console.WriteLine("============Directory:============");
            foreach (Type clss in _classList)
            {
                if (clss.Name != "Program")
                {
                    Console.WriteLine(clss.Name.PadLeft(4));
                }
            }
            Console.WriteLine("==========End Directory:==========");
        }

        private static void FindProblem(string name)
        {
            var clsName = from t in _classList
                             where t.Name == name
                             select t;
            if (clsName.Count() == 0)
            {
                Console.WriteLine("No match found or no command by that name. Please try again.");
            }
            else
            {
                Console.WriteLine("============" + clsName.First().Name + "============");
                RunProblem(clsName.First());
            }
        }

        private static void RunProblem(Type t)
        {
            try
            {
                Activator.CreateInstance(t);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

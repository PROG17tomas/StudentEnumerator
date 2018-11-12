using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new StudentRepository();

            RegisterStudents(repo);

            var greetings = repo.SayGoodMorning();

            foreach (var greeting in greetings)
            {
                Console.WriteLine(greeting);
            }
        }

        private static void RegisterStudents(StudentRepository repo)
        {
            repo.Add(new Teacher("Fredrik"));


        }
    }
}

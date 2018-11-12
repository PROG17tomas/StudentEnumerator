using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnumerator
{
    public class Program
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

        public static void RegisterStudents(StudentRepository repo)
        {
            repo.Add(new Teacher("Fredrik"));
            repo.Add(new CharbelStudent());
        }
    }
}

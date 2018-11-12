using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnumerator
{
    public class StudentRepository
    {
        private List<Person> _persons = new List<Person>();

        public object GetNumberOfStudents()
        {
            return _persons.Count;
        }

        public void Add(Person person)
        {
            _persons.Add(person);
        }

        public IList<string> SayGoodMorning()
        {
            var greetings = new List<string>();
            foreach (var person in _persons)
            {
                greetings.Add(person.SayGoodmorning());
            }

            return greetings;
        }
    }
}

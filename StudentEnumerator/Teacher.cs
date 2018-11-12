using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnumerator
{
    public class Teacher : Person
    {
        private string _name;

        public Teacher(string name)
        {
            _name = name;
        }

        public override string SayGoodmorning()
        {
            return "God morgon klassen";
        }
    }
}

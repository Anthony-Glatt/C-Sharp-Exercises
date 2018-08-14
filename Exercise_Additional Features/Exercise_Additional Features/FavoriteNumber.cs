using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Additional_Features
{
    class FavoriteNumber
    {
        //3. Chain two constructors together.
        //string userName = { get;  set; }

        public FavoriteNumber(string name) : this(name, 7)
        {
        }

        public FavoriteNumber(string name, int number)
        {
            userName = name;
            userNumber = number;
        }
        public string userName {get; set;}
        public int userNumber { get; set; }

    }
}

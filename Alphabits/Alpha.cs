using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabits
{
    class Alpha
    {

        private List<char> _letters;

        public List<char> letters
        {
            get
            {
                return _letters;
            }
        }

        public void displayList()
        {
            for (var i = 0; i < listLength(); i++)
            {
                Console.Write(letters[i]);
            }
            Console.Write("\n");
        }

        public void addChar(char newChar) 
        {

            var newInt = Convert.ToInt32(newChar);

            //let the user know if they entered a number
            if (newInt < 58 && newInt > 47)
            {
                Console.WriteLine("Try a letter not a number!");
                return;
            } else if (newInt < 91 && newInt > 64)
            {
                //let the user know to only use lowercase letters
                Console.WriteLine("Use lowercase letters!");
                return;
            }


            var currentList = letters;
            var lastLetter = currentList[currentList.Count - 1];
            var lastInt = Convert.ToInt32(lastLetter);

            var diff = newInt - lastInt;

            if(diff < 0)
            {
                Console.Write("You've already entered that letter! \n");
                return;
            }

            if (diff == 0)
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("You have {0} correct letters", listLength());

                //show the current list
                displayList();

                //add the next char
                _letters.Add((char)(lastInt + 1));
            } else
            {
                Console.WriteLine("Wrong! Try again.");
            }

        }

        public int listLength()
        {
            return _letters.Count;
        }

        public Alpha()
        {
            _letters = new List<char> { 'a' };
        }
    }
}

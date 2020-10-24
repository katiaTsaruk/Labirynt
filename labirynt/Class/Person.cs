using System;
using System.Collections.Generic;
using System.Text;

namespace labirynt.Class
{
    class Person
    {
        public string personSymbol { get; private set; }
        public ConsoleColor personColor { get; private set; }
        public int personX;
        public int personY;
        public Person(string setPersonSymbol, ConsoleColor setPersonColor, int setPersonX=0, int setPersonY=0)
        {
            personSymbol = setPersonSymbol;
            personColor = setPersonColor;
            personX = setPersonX;
            personY = setPersonY;
        }
    }
}

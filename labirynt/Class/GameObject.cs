using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace labirynt.Class
{
    class GameObject
    {        
        public bool isFree { get; private set; }
        public ConsoleColor cellColor{ get; private set; }
        public int length { get; private set; }
        public int width { get; private set; }
        public GameObject(int setLength, int setWidth)
        {
            length = setLength;
            width = setWidth;
        }
        public GameObject(ConsoleColor setCellColor, bool setIsFree) 
        {           
            cellColor = setCellColor;
             isFree = setIsFree;
        }            
    }
}

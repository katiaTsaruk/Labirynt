using System;
using System.Collections.Generic;
using System.Text;

namespace labirynt.Class
{
    class Game
    {        
        GameObject size;
        GameObject[,] field;
        Person person;        
        public void Start()
        {            
            size = new GameObject(20, 20);
            field = new GameObject[size.length,size.width];
            person = new Person("@", ConsoleColor.DarkBlue);
            GenerateField();
            DrawPerson(person.personX, person.personY);                      
        }      
        public void Update()
        {
            while (IsFinish()==false)
            {
                PersonMovement();
            }
        }
        void GenerateField()
        {            
            Random r = new Random();
            GameObject cell;
            for (int y = 0; y < size.length; y++)
            {
                for (int x = 0; x < size.width; x++)
                {
                    Console.SetCursorPosition(x, y);
                    int freq = r.Next(1, 100);
                    if (freq < 30)
                    {
                        cell = new GameObject(ConsoleColor.Yellow, false);
                    }
                    else
                        cell = new GameObject(ConsoleColor.DarkGray, true);
                    field[y, x] = cell;
                    field[size.length - 1, size.width - 1] = new GameObject(ConsoleColor.Green, true);
                    field[0, 0] = new GameObject(ConsoleColor.Gray, true);
                    Console.BackgroundColor = field[y, x].cellColor;
                    Console.Write(' ');
                }
            }
            Console.ResetColor();
        }
        void DrawPerson(int x, int y)
        {            
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = person.personColor;
            Console.Write(person.personSymbol);
            Console.SetCursorPosition(0, size.length+2);
            Console.ResetColor();
        }        
        void PersonMovement()
        {
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.W)
            {
                if (IsFree(person.personX, person.personY - 1) == true)
                {
                    DeleteObject(person.personX, person.personY);
                    person.personY--;
                    DrawPerson(person.personX, person.personY);
                }

            }
            else if (key == ConsoleKey.S)
            {
                if (IsFree(person.personX, person.personY + 1) == true)
                {
                    DeleteObject(person.personX, person.personY);
                    person.personY++;
                    DrawPerson(person.personX, person.personY);
                }
            }
            else if (key == ConsoleKey.A)
            {
                if (IsFree(person.personX - 1, person.personY) == true)
                {
                    DeleteObject(person.personX, person.personY);
                    person.personX--;
                    DrawPerson(person.personX, person.personY);
                }
            }
            else if (key == ConsoleKey.D)
            {
                if (IsFree(person.personX + 1, person.personY) == true )
                {
                    DeleteObject(person.personX, person.personY);
                    person.personX++;
                    DrawPerson(person.personX, person.personY);
                }                
            }            
        }
        bool IsFree(int x, int y)
        {
            if ( x < size.width && y < size.length && x >= 0 && y>=0 && field[y, x].isFree == true)
                return true;
            else return false;
        }
        void DeleteObject(int x,int y)
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = field[y,x].cellColor;
            Console.Write(' ');
            Console.ResetColor();
        }
        bool IsFinish()
        {            
            if (person.personX == size.width - 1 && person.personY == size.length - 1 )
            {                
                Console.WriteLine("Поздравляю, ваши мучения закончились"); 
                return true;
            }                
            else
            {                
                return false;                
            }                
        }        
    }
}
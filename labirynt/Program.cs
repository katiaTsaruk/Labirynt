using labirynt.Class;
using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace labirynt
{
    class Program
    {        
        static void Main(string[] args)
        {
           Game MyGame = new Game();
            MyGame.Start();
            MyGame.Update();
        }
        
    }
}

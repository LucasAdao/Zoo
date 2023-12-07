using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.models.entities
{
    public class Macaco : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine(" A A   A A  A A  U U U U U U U  U U U U U  U U U U  A A A A   U U U U U");
            Thread.Sleep(2000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine("..");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine(@"
         ⢀⡄⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⣀⠤⠒⠉⠉⠉⠣⢄⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢀⠎⠠⠒⠒⢄⡄⠒⠒⡄⢧⠀⠀⠀⠀⠀⠀⠀
⠀⡔⡭⣝⠀⣧⣤⡄⠀⠀⣴⣦⣼⢸⡾⢿⡆⠀⠀⠀⠀
⠀⠱⣣⣇⠔⠻⠿⠳⣎⡱⠙⠾⠙⠆⣽⡫⠃⠀⠀⠀⠀
⠀⠀⠀⢫⣄⠀⢒⢀⣤⣤⣲⠂⢀⡧⠋⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢀⠝⠓⠠⢅⣒⣲⠇⠒⠉⢣⠀⠀⠀⠀⠊⠁⢆
⠀⠀⢠⠂⠀⢀⢠⠔⠒⠂⢄⠠⡀⠀⠱⡀⠀⢀⠇⢀⠎
⠀⠀⡜⠀⠀⢸⡆⠀⠀⠀⠈⣤⢳⠀⠀⢧⠔⠁⡠⠊⠀
⠀⠀⡇⠀⠀⠘⢇⡀⠀⢀⡠⠛⠚⠄⠀⢸⠔⠊⠀⠀⠀
⠀⠀⡇⠀⢀⣸⢔⠊⠣⠬⠕⡤⣸⡀⠀⢸⠀⠀⠀⠀⠀
⢠⢶⠗⠲⠚⠀⢫⢧⠀⢀⡮⡔⠁⠱⠲⢺⣶⡄⠀⠀⠀
⠘⠭⠄⢆⣆⣸⠚⠊⠀⠈⠓⠻⣁⡆⠴⠼⠨⠂⠀⠀⠀");
        }
    }
}
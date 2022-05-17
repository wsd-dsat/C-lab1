using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab{
    class Program{
        static void Main(string[] args){

            //lab1
            int a = 3680;

            int h = a /3600;
            int x = a /3600;
            int m = a - h*3600;
            int s = m%60;
            Console.WriteLine($"З початку доби пройшло {h} годин {x} хвилин {s} секунд");




        }
    }
}



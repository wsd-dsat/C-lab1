using System;
using System.Collections;
using System.IO;
namespace lab4
{
    class Program
    {
       
        static void Main(string[] args){

        
           // lab2.1
            char repeat = 'y';
            do
            {
            int a;
            Console.Write("введіть число -  ");
            a = Convert.ToInt32(Console.ReadLine());

            switch (a){
                case 1:
                Console.Write("Понеділок\n");
                break;
                case 2:
                Console.Write("Вівторок\n");
                break;
                case 3:
                Console.Write("Середа\n");
                break;
                case 4:
                Console.Write("Четвер\n");
                break;
                case 5:
                Console.Write("П'ятниця\n");
                break;
                case 6:
                Console.Write("Субота\n");
                break;
                case 7:
                Console.Write("Неділя\n");
                break;
                default:
                Console.Write(");\n");
                break;
            }
            }while ((repeat == 'y') || (repeat == 'Y'));




        }
    }
}




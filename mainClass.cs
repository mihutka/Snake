using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class mainClass
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3, '*'); /*loob uue punkti p1*/
            /*p1.x = 1;
            p1.y = 3;
            p1.sym = '*';*/
            p1.Draw(); /*tõmbab punkti*/

            Point p2 = new Point(4,5,'#');
            /*p2.x = 4;                 /*muutujad*/
           /* p2.y = 5;
            p2.sym = '#';
            p2.Draw();*/

          


            Console.ReadLine();
        }
        
    }
}

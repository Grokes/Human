using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Human human = new Human();
            Human mom = new Human();
            Human mom2 = new Human();
            Human dad = new Human();
            Human son = new Human();

            human.dad = dad;
            human.mother = mom;
            human.son = son;
            dad.son = human;
            mom.son = human;

            son.dad = human;
            son.mother = mom2;


            //Console.WriteLine(test.ToString());
            Console.WriteLine(dad.getPeopleData());


        }
    }
}
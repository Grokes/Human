using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Human
    {
        static uint allCount = 0;
        string name;
        bool sex;
        uint age;
        public Human mother;
        public Human dad;
        public Human son;

        public Human(string name = "default", bool sex = false, uint age = 0, Human mother = null, Human dad = null, Human son = null)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;

            if (mother != null && mother.age > this.age)
                this.mother = mother;
            else
                this.mother = null;

            if (dad != null && dad.age > this.age)
                this.dad = dad;
            else
                this.dad = null;

            if (son != null && son.age < this.age)
                this.son = son;
            else
                this.son = null;

            ++allCount;
        }

        public override string ToString()
        {
            string result = "Name " + name + "\nSex ";

            if (sex == false)
                result += "female";
            else
                result += "male";

            result += "\nAge " + age;

            if (mother != null)
                result += "\nMother " + mother.name;
            if (dad != null)
                result += "\nDad " + dad.name;
            if (son != null)
                result += "\nSon " + son.name;

            return result;
        }
        public static uint getPeopleCount { get { return allCount; } }

        public string getPeopleData()
        {
            string result = "";
            if (son != null)
                result += son.getPeopleData();
            result += this.ToString() + "\n\n";
            if (mother != null)
                result += mother.ToString() + "\n\n";

            return result;
        }


    }
}
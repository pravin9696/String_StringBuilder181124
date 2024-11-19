using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_StringBuilder181124.indexer_in_C_
{
    internal class IndexerDemo
    {
        public int multiplication(int m1,int m2)
        {
            Console.WriteLine("multiplication method from IndexerDemo executed");
            return m1 * m2;
        }
    }
    public class MyClass
    {
        string[] cities = new string[5];
        
        public string this[int index]
        {
            set { cities[index] = value; } //assign value to variable
            get { return cities[index]; }// retrive or read value of variable
        }
        public int sum(int a,int b)
        {
            Console.WriteLine("sum method from myclass executed");
            return a + b;
        }
    }
}

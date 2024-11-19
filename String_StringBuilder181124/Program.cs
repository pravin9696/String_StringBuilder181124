using String_StringBuilder181124.indexer_in_C_;
using System.Text;

namespace String_StringBuilder181124
{
    class AA //parent class
    {
        public void AAMethod()
            {
            }
    }
    class BB:AA  //BB is child  class & AA is parent class
    {
        public void BBMethod()
        {
        }
    }
    class CC : AA
    {
        public void CCMethod()
        {
        }
    }
    class student
    {

    }
    internal class Program
    {
        public delegate int myDelegate(int x, int y);//delgate datatype
        static void Main(string[] args)
        {
            #region Assignment Q26
            //string str="1asds6545fasfds9";
            //char[] result = new char[str.Length];
            //char[]temp=str.ToCharArray();
            //int j = 0;
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    if (temp[i]>='0'&& temp[i]<='9')//only if digit
            //    {
            //        result[j] = temp[i];
            //        j++;
            //    }
            //}
            //string finalResult =new string(result);
            //Console.WriteLine(finalResult);
            #endregion

            //StringBuilder sb = new StringBuilder("pune nagar");
            //Console.WriteLine("before append:"+sb);
            //Console.WriteLine("hash code="+sb.GetHashCode());
            //sb.AppendLine("abcdpravin");
            //Console.WriteLine("after append:" + sb);
            //Console.WriteLine("hash code=" + sb.GetHashCode());
            //Console.WriteLine(sb);
            //sb.Remove(10, 1);
            //Console.WriteLine(sb);

            //Console.WriteLine(sb.Replace("nagar1231","mh"));

            //int x=0;
            //object obj = x;// boxing auto boxing
            ////int y = obj * 100;
            //float z = (float)obj;
            //float y = z * 100;
            //Console.WriteLine(y);
            //student ss = new student();

            //object temp = ss;
            //Console.WriteLine(temp.GetType());
            //student ss1 = null;

            //int ?q = 1234567;

            //int w = q ?? 300;
            //Console.WriteLine(w);
            //BB obj2=new BB();
            //AA obj1;

            //obj1= obj2;

            //CC obj3 = new CC();

            //obj1 = obj3;

            //CC newObj =(CC) obj1;

            //int? x;
            //x = null;//

            //x = 55;



            //int yy1;
            //yy1 = x ?? 9999;//if x is null then yy1 contains 9999
            //if x is not null then yy1 contains actual value of x
            //Console.WriteLine("yy1=" + yy1);


            MyClass obj1 = new MyClass();
            obj1[2] = "nashik";
            obj1[3] = "pune";
            string str = obj1[2];
            string temp=str.ToUpper();

            Console.WriteLine(str);
            Console.WriteLine(temp);



            myDelegate delObj = new myDelegate(obj1.sum);//deligate declaration

           // int result=delObj.Invoke(111, 222);

            //Console.WriteLine(result);

            IndexerDemo idobj = new IndexerDemo();

            delObj = idobj.multiplication;
            //result = delObj.Invoke(10, 20);

            delObj += obj1.sum;
            delObj.Invoke(11, 22);

        }
    }
}

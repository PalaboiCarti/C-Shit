using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        static void stacks()
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(4);
        
            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("The number of elements in the stack is " +st.Count);
            Console.WriteLine("Does the stack contain the elements 4 "+st.Contains(4));
            Console.ReadKey();
        }
        
        static void ask()
        {
            Console.WriteLine ("Wtf do you want");
            Console.WriteLine ("Stax or Qz");
            string res = Console.ReadLine();   
            if(res == "s")
            {
                Console.WriteLine("Wow Stax");
                stacks();
            }else if(res == "q")
            {
                Console.WriteLine("Wow Queues");
            }else
            {
                Console.WriteLine("What?");
                ask();
            }
        }
        
        static void errthing()
        {
            ask();   
        }
        errthing();
    }
}

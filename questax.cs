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
            //ask user for stack size
            Stack st = new Stack();
            
            //ask user for input 
            Console.WriteLine ("Wtf do you want");
            Console.WriteLine ("push or pop");
            int num = Convert.ToInt32(Console.ReadLine());
            
            //make elif for pushing and popping num to stack
            
            st.Push(1);
            st.Push(2);
            st.Push(4);
        
            //display stack
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

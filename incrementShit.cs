using System;

public class iHateYou {
    static void incrementShit(int num){
        Console.Write("Formula: ");
        int sum = 0;
        for(int i=1; i<=num; i++){
            Console.Write(i);
            if(i < num){
                Console.Write("+");
            }
            sum = sum + i;
        }
        Console.WriteLine(" ");
        Console.WriteLine(sum);
    }    
    static void thingDoer(){
        Console.WriteLine("Give me a goddamn number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num <= 0){
            Console.WriteLine("Try again fucker");
            thingDoer();
        }else{
            incrementShit(num);
        }
    }
    public static void Main(string[] args){
        thingDoer();
    }  
}

using System;

public class iHateYou {
    
    static void printShit(int num){
         for (int i = 1; i <= num; i++){
            for(int j = 1; j <= i; j++){
                Console.Write(j);
            }
            Console.WriteLine("");
        }
    }
    
    static void thingDoer(){
        Console.WriteLine("Give me a goddamn number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num <= 0){
            Console.WriteLine("Try again fucker");
            thingDoer();
        }else{
            printShit(num);
        }
    }
    
    public static void Main(string[] args){
        thingDoer();
    }
    
}

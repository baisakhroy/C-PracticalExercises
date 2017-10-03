using System;

namespace C_PE1
{
   
    
    
   
    
    
    class Program
    {
        static void Main()
        {
            int n;
            start:
            Console.WriteLine("Make your choice: \n");
            Console.WriteLine("1.Palindromity \n2.Tom&Jerry \n3.Letters \n4.Iteration \n5.Descending \n6.Multiplier");
            n= int.Parse(Console.ReadLine());
            switch(n){
                case 1:
                    Palindrome p = new Palindrome();
                    p.Palindromeyo(323);
                    break;
                case 2: Tom_n_Jerry t = new Tom_n_Jerry();
                    break;
                    case 3: Letters l = new Letters();
                    break;
                    case 4: Iteration i = new Iteration();
                    break;
                    case 5: Descending d = new Descending();
                    break;
                    case 6: Multiplier m = new Multiplier();
                    break;
                default:Console.WriteLine("Your choice doesnt match any of the available opttions. Make a valid choice");
                        goto start;

            }
    }
}
}
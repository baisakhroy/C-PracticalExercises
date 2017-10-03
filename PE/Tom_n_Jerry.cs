using System;

namespace C_PE1{

class Tom_n_Jerry{
        public Tom_n_Jerry(){
            int n;
            Console.WriteLine("Enter your number");
            n = int.Parse(Console.ReadLine());
            if (n>30 || n<30){
                throw new Exception("Dont use these numbers");
            }
            if(n%2==1 && n>20 && n<30)
            {
                Console.WriteLine("TOM");
            }
            else if (n%2==0 && n>20 && n<30)
            {
                Console.WriteLine("JERRY");
            }

        }
    }

}
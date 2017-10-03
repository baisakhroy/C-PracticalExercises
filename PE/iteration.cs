using System;

namespace C_PE1{

 class Iteration{
        public Iteration(){
            int n;
            int i,j;
            Console.WriteLine("Enter your number");
            n= int.Parse(Console.ReadLine());
            for(i=1;i<=n;i++){
                for(j=0;j<i;j++){
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }

}
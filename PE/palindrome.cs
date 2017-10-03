using System;

namespace C_PE1{
 public class Palindrome{
        public  int Palindromeyo(int n){
            int p;
            int a,b=0;
            int sum=0;
            Console.WriteLine("Enter the number you want to check for its palindromity");
            n=int.Parse(Console.ReadLine());
            p=n;
            while(p>0){
                    a=p%10;
                    b=b*10+a;
                    p=p/10;
            }
            a=0;
            if (b==n){
                
                p=n;
                while(n>0){
                   a=n%10;
                   if (a%2==0){
                       sum=sum+a;
                   } 
                   n=n/10;
                }
                if (sum>25){
                    Console.WriteLine("{0} is palindrome and the sum of even numbers is greater than 25",p);
                }
                else{
                    Console.WriteLine("{0} is palindrome and the sum of even numbers is not greater than 25",p);
                }
                
            }
            else{
                Console.WriteLine("No");
            }
            Console.WriteLine(sum);
            return sum;
        }
        
        }
}
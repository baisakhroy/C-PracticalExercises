using System;

namespace C_PE1{

class Multiplier{
        public Multiplier(){
                string s;
                int i,n,j,l;
                Console.WriteLine("Input your string now");
                s= Console.ReadLine();
                l=s.Length;
                Console.WriteLine("Input your number here");
                n=int.Parse(Console.ReadLine());
                for(i=0;i<l-n;i++){
                Console.Write(s[i]);
                }
                for(i=0;i<n;i++){
                    for(j=l-n;j<l;j++){
                        Console.Write(s[j]);
                    }
                }
        }
    }

}
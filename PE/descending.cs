using System;

namespace C_PE1{

class Descending{
        public Descending(){
            int x,p,i,j,temp,check=0,Sum=0;
            Console.WriteLine("Type in your numerical input");
            x=int.Parse(Console.ReadLine());
            p=x;
            while(p>0){
                p=p/10;
                check++;
            }
            p=x;
            int[] a= new int[check];
            for(i=0;i<check;i++){
                    a[i]=p%10;
                    p=p/10;
            }

            for(i=0;i<check;i++){
                for(j=0;j<i;j++){
                        if(a[i]>a[j]){
                            temp=a[i];
                            a[i]=a[j];
                            a[j]=temp;
                        }
                }
            }
            foreach(int k in a){
                Console.Write(k);
            }
            Console.WriteLine();
            for(i=0;i<check;i++){
                if(a[i]%2==0){
                    Sum=Sum+a[i];
                }
            }
            Console.WriteLine("Sum of even numbers= {0}",Sum);
            if(Sum>15){
                Console.WriteLine("TRUE");
            }
            else{
                Console.WriteLine("FALSE");
            }
        }
    }

}
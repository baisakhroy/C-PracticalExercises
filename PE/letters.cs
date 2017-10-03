using System;

namespace C_PE1{

class Letters{
        public Letters(){
            string s;
            int i,l;
            Console.WriteLine("Input your string");
            s= Console.ReadLine();
            s=s.ToLower();
            l=s.Length;
            for(i=0;i<l;i++){
                if(s[i]>='a' && s[i]<='z'){
                if(s[i]=='a'||s[i]=='e'||s[i]=='i'||s[i]=='o'||s[i]=='u'){
                    Console.Write("{0}-Vowel ",s[i]);
                }
                else {
                    Console.Write("{0}-Consonant ",s[i]);
                }
                }
                else{
                    throw new Exception("Enter an alphabet please");
                }
            }
        }
    }

}
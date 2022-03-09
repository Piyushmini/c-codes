using System;

public class GFG{
	static public void Main (){
		int a,i;
	    a=Convert.ToInt32(Console.ReadLine());
	   for( i=2;i<a;i++){
	       if(a%i==0){
	           Console.WriteLine("not a prime number");
	           break;
	       }
	   }
	   if(i==a){
	       Console.WriteLine("prime number");
	   }
	}
}
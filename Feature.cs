using System;
class Review1
{
	public static void Main(String[] args)
	{
		int a= 123456;
		Review1 obj=new Review1();
		
		
		int count=obj.CountingDigits(a);
		Console.WriteLine("Task-1 Of counting digits: "+count);
		
		int[] evenArray=obj.EvenArray(a);
		int[] oddArray=obj.OddArray(a);
		int evenSize=evenArray.Length;
		int oddSize=oddArray.Length;
		Console.WriteLine("Even Array: ");
		for(int i=0;i<evenSize;i++)
		{
			Console.WriteLine(evenArray[i]+", ");
		}
		Console.WriteLine("Odd Array: ");
		for(int i=0;i<oddSize;i++)
		{
			Console.WriteLine(oddArray[i]+", ");
		}
		
	}
	public int CountingDigits(int n)
	{
		int count=0;
		while(n!=0)
		{
			n=n/10;
			count++;
		}
		return count;
	}
	public int[] EvenArray(int n)
	{
		int dummy=n;
		int c=0;
		while(dummy!=0){
			int d=dummy%10;
			if(d%2==0)
				c++;
			dummy=dummy/10;
		}
		int[] EvenArr=new int[c];
		int index=0;
		while(n!=0){
			int d=n%10;
			if(d%2==0)
			{
				EvenArr[index]=d;
				index++;
			}
			n=n/10;
		}
		return EvenArr;
	}
	public  int[] OddArray(int n)
	{
		int dummy=n;
		int c=0;
		while(dummy!=0)
		{
			int d=dummy%10;
			if(d%2!=0)
				c++;
			dummy=dummy/10;
		}
		int[] OddArr=new int[c];
		int index=0;
		while(n!=0){
			int d=n%10;
			if(d%2!=0)
			{
				OddArr[index]=d;
				index++;
			}
			n=n/10;
		}
		return OddArr;
	}
}
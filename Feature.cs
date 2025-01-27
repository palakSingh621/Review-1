using System;
class Review1
{
	public static void Main(String[] args)
	{
		int a= 123456;
		Review1 obj=new Review1();
		int count=obj.CountingDigits(a);
		Console.WriteLine("Task-1 Of counting digits: "+count);
	}
// Task-1
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
}

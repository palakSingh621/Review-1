using System;
class Review1
{
	public static void Main(String[] args)
	{
		int a= 123456;
		Review1 obj=new Review1();
		int reverse= obj.Reverse(a);
		Console.WriteLine("Task-3 Reversing the number: "+reverse);
	}
	public int Reverse(int n)
	{
		int rev=0;
		while(n!=0)
		{
			int d=n%10;
			rev=rev*10+d;
			n=n/10;
		}
		return rev;
	}
}
using System;
class Review1
{
	public static void Main(String[] args)
	{
		int a= 123456;
		Review1 obj=new Review1();
		obj.FindFactor(a);
	}
	public void FindFactor(int n)
	{
		while(n!=0){
			int d=n%10;
			int[] arr=Factor(d);
			int len=arr.Length;
			Console.WriteLine("Factors of "+d+": ");
			for(int i=0;i<len;i++)
			{
				Console.WriteLine(arr[i]+", ");
			}
			n=n/10;
		}
	}
	public int[] Factor(int n)
	{
		int count=0;
		for(int i=1;i<=n;i++)
		{
			if(n%i==0){
				count++;
			}
		}
		int[] ans=new int[count];
		int index=0;
		for(int i=1;i<=n;i++)
		{
			if(n%i==0){
				ans[index]=i;
				index++;
			}
		}
		return ans;
	}
}
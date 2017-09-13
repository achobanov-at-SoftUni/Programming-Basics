using System;

class CalculateFacturiels
{
	static void Main()
	{
		float 
			n = float.Parse(Console.ReadLine()),
			x = float.Parse(Console.ReadLine())
		;
		float result = 1f;
		for(float i = 1f; i <= n; i++)
		{
			result += Facturiel(i) / (float)Math.Pow(x, i);
		}
		Console.WriteLine("{0:F5}", result);
	}

	static float Facturiel(float number)
	{
		float result = 1;
		for(; number > 0; number--)
		{
			result *= number;
		}
		return result;
	}
}
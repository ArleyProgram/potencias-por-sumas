class Program
{
	static void Main(string[] args)
	{
		A();
	}

	static void A()
	{
		Console.WriteLine("Ingresa la base:");
		int B = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Ingresa el exponente:");
		int E = Convert.ToInt32(Console.ReadLine());

		int result = Power(B, E);
		Console.WriteLine($"El resultado de {B}^{E} es: {result}");
	}

	static int Power(int baseN, int exponente)
	{
		if (exponente == 0)
			return 1;
		if (exponente == 1)
			return baseN;
		int result = 1;
		for (int i = 0; i < exponente; i++)
		{
			result = M(result, baseN);
		}

		return result;
	}

	static int M(int M1, int M2)
	{
		int R = 0;

		for (int i = 0; i < M2; i++)
		{
			R += M1;
		}
		return R;
	}
}

using System;
using System.IO;

namespace KeyGenerator
{
	class Program
	{
		static long GCD(long a, long b)
		{
			while (b != 0)
			{
				long t = b;
				b = a % b;
				a = t;
			}

			return a;
		}

		static long LCM(long a, long b) => a * b / GCD(a, b);

		static bool IsPrime(long num)
		{
			bool isPrime = true;
			long top = (long)Math.Sqrt(num) + 1;
			for (long i = 2; i < top && isPrime; i++)
				if (num % i == 0)
					isPrime = false;

			return isPrime;
		}

		static bool IsCoprime(long a, long b) => GCD(a, b) == 1;

		static void ReadAndCheckPQ(ref long p, ref long q)
		{
			do
			{
				do
				{
					Console.Write("Enter p: ");
					p = long.Parse(Console.ReadLine());

					if (!IsPrime(p))
						Console.WriteLine("ERROR!. p is not prime number.\n");
				}
				while (!IsPrime(p));

				do
				{
					Console.Write("Enter q: ");
					q = long.Parse(Console.ReadLine());

					if (!IsPrime(q))
						Console.WriteLine("ERROR!. q is not prime number.\n");
				}
				while (!IsPrime(q));

				if (p == q)
					Console.WriteLine("ERROR! q equals p.\n");
			}
			while (p == q);
		}

		static long ModInv(long e, long ln)
		{
			long t = 0, newt = 1;
			long r = ln, newr = e;

			while (newr != 0)
			{
				long q = r / newr;
				(t, newt) = (newt, t - q * newt);
				(r, newr) = (newr, r - q * newr);
			}

			return t < 0 ? t + ln : t;
		}

		static void Main(string[] args)
		{
			// Чтение p и q, проверка их простоты и равенства
			long p = 0, q = 0;
			ReadAndCheckPQ(ref p, ref q);

			// Вычисление n и λ(n)
			long n = p * q;
			long ln = LCM(p - 1, q - 1);

			// Генерация числа e и проверка взаимной простоты с λ(n)
			Random rand = new Random();
			long e = (1 << 16) + 1;

			if (e >= ln)
			{
				e = (long)rand.Next(2, (int)ln);
				while (!IsCoprime(e, ln))
				{
					e++;
					if (e == ln)
						e = (long)rand.Next(2, (int)ln);
				}
			}

			for (; !IsCoprime(e, ln); e--);

			// Вычисление d
			long d = ModInv(e, ln);

			// Запись ключей в файл
			File.WriteAllText("PublicKey.txt", string.Format("{0} {1}", n, e));
			File.WriteAllText("PrivateKey.txt", string.Format("{0} {1}", n, d));
		}
	}
}

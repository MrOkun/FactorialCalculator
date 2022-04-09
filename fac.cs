using System;
using System.Numerics;

namespace Factorial{
	class FactorialMain{
	
		static public void Main(string[] args){
			err:

			Console.Write("Введите чило --->");
			int num;
			
			try
			{
				num = Convert.ToInt32(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Вы ввели не корректную цифру.");
				goto err;
			}
			
			BigInteger fac = 1;

			for(BigInteger i = 1; i < num+1; i++)
			{
				if(i == 1){
					fac = 1;
				}
				else{
					fac = fac*i;
				}

			}

			Console.WriteLine("Число : " + num);
			Console.WriteLine("Факториал : " + fac);
		}
	}
}

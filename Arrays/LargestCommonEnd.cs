using System;

namespace ProgrammingFundamentals
{
	class LargestCommonEnd
	{
		static void Main(string[] args)
		{
			string[] text1 = Console.ReadLine().Split(' ');
			string[] text2 = Console.ReadLine().Split(' ');
			int count = 1;
			bool hasCount = false;

			for (int i = 0; i < text1.Length; i++)
			{
				for (int j = 0; j < text2.Length; j++)
				{
					if (text1[i] == text2[j])
					{
						if (i != text1.Length - 1 && j != text2.Length - 1)
						{
							if (text1[i + 1] == text2[j + 1])
							{
								count++;
							}
						}
						hasCount = true;
					}
				}
			}
			if (hasCount == false)
			{
				Console.WriteLine("0");
			}
			else
			{
				Console.WriteLine(count);
			}
		}
	}
}
﻿using System;

class InstructionSet
{
    static void Main()
    {

        string opCode = Console.ReadLine().ToUpper();
		long result = 0;

		while (opCode != "END")
		{
			string[] codeArgs = opCode.Split(' ');

			switch (codeArgs[0])
			{
				case "INC":
					{
						int operandOne = int.Parse(codeArgs[1]);
						result = (long)operandOne + 1;
						break;
					}
				case "DEC":
					{
						int operandOne = int.Parse(codeArgs[1]);
						result = (long)operandOne - 1;
						break;
					}
				case "ADD":
					{
						int operandOne = int.Parse(codeArgs[1]);
						int operandTwo = int.Parse(codeArgs[2]);
						result = (long)operandOne + operandTwo;
						break;
					}
				case "MLA":
					{
						long operandOne = long.Parse(codeArgs[1]);
						long operandTwo = long.Parse(codeArgs[2]);
						result = operandOne * operandTwo;
						break;
					}
			}
			Console.WriteLine(result);
			opCode = Console.ReadLine();
		}
    }
}
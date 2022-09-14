using System;

class InstructionSet_broken
{
    static void Main()
    {

        string opCode = Console.ReadLine();

        while (opCode != "END") //was "end"
        {
            string[] codeArgs = opCode.Split(' ');

            long result = 0;
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        result = ++operandOne; //should use pre-incrementation
                        break;
                    }
                case "DEC":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        result = --operandOne; //same mistake as in INC
                        break;
                    }
                case "ADD":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        int operandTwo = int.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne * operandTwo;
                        break;
                        //changed variable type, removed pointless cast
                    }
            }

            Console.WriteLine(result);

            //variable was never changed → infinite loop!
            opCode = Console.ReadLine();
        }
    }
}
#pragma once
#include <iostream>
void FizzBuzz(int _Num)
{
	for (int i = 1; i < _Num + 1; i++)
	{
		std::cout << "	";

		if (i % 3 == 0 || i % 5 == 0)
		{
			if (i % 3 == 0)
			{
				std::cout << "Fizz";
			}

			if (i % 5 == 0)
			{
				std::cout << "Buzz";
			}
		}
		else
			std::cout << i;
	}
	std::cout << std::endl;

/*
	for (int i = 1; i < _Num; i++)
	{
		bool printNumber = true;
		if (i % 3 == 0)
		{
			cout << "Fizz";
			printNumber = false;
		}
		if (i % 5 == 0)
		{
			cout << "Buzz";
			printNumber = false;
		}
		if (printNumber)
		{
			cout << i;
		}
		cout << endl;
	}
*/
}
#include "pch.h"
#include "FizzBuzz.h" 
#include "Vectors.h"
#include "WordsWithFriends.h"
#include <random>
#include <iostream>
#include "WordList.h"
#include <fstream>
using namespace std;

int main()
{
	// Fizz Buzz
	//FizzBuzz(1000);

	// Vectors
	//vector<float> _VectorNumbers;
	//for (int i = 0; i < 1000; i++)
	//{
	//	_VectorNumbers.push_back(rand()% 100);
	//	cout << _VectorNumbers[i] << " ";
	//}
	//
	//cout << endl << "Sum: " << Sum(_VectorNumbers) << endl;
	//cout << "Average: " << Average(_VectorNumbers) << endl;
	//cout << "Highest: " << Highest(_VectorNumbers) << endl;
	//cout << "Second Highest: " << SecondHighest(_VectorNumbers) << endl;

	//string _Input;
	//cout << "Input: ";
	//cin >> _Input;
	//
	//if (Hannah(_Input))
	//{
	//	cout << "Its true" << endl;
	//}
	//else
	//{
	//	cout << "Its false" << endl;
	//}


	WordList _WordList("words.txt");


	Hannah(_WordList._Words);
	//Hannah({ "anna", "hannah", "banana" });

	system("pause");
	return 0;
}

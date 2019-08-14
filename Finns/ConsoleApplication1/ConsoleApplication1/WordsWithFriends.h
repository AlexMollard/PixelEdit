#pragma once
#include <string>
using namespace std;






void Hannah(std::vector<string> _input)
{
	int _trueTotal = 0;
	int _falseTotal = 0;


	for (size_t x = 0; x < _input.size(); x++)
	{
		int _inputSize = _input[x].size();
		int up = 0;
		int total = 0;

		for (int i = _inputSize - 1; i >= 0; i--)
		{
			if (_input[x][i] == _input[x][up])
				total++;

			up++;
		}

		if (total == _inputSize)
		{
			//cout << "True" << endl;
			_trueTotal++;
		}
		else
		{
			//cout << "false" << endl;
			_falseTotal++;
		}
	}

	cout << "False: " << _falseTotal << endl;
	cout << "True: " << _trueTotal << endl;
}
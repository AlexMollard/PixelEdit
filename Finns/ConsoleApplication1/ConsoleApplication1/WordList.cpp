#include "pch.h"
#include "WordList.h"
#include <string>

WordList::WordList(string FileName)
{
	ifstream _InputFile;
	_InputFile.open(FileName);

	while (!_InputFile.eof())
	{
		string _Word;
		_InputFile >> _Word;
		_Words.push_back(_Word);
	}
	_InputFile.close();
}


WordList::~WordList()
{
}

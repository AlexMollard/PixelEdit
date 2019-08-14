#pragma once
#include <vector>
#include <fstream>

using namespace std;
class WordList
{
public:
	WordList(string FileName);
	~WordList();

	std::vector<std::string> _Words;
};


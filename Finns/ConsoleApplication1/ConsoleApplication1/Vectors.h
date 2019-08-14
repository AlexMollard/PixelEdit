#pragma once
#include <iostream>
#include <vector>
using namespace std;

float Sum(vector<float> _Nums)
{
	float _Total = 0;
	for (int i = 0; i < _Nums.size(); i++)
	{
		_Total += _Nums[i];
	}
	return _Total;
}

float Average(vector<float> _Nums)
{
	float _Average = 0;
	for (int i = 0; i < _Nums.size(); i++)
	{
		_Average += _Nums[i];
	}
	return _Average / _Nums.size();
}

float Highest(vector<float> _Nums)
{
	float _Highest = _Nums[0];
	for (int i = 1; i < _Nums.size(); i++)
	{
		if (_Highest < _Nums[i])
		{
			_Highest = _Nums[i];
		}
	}
	return _Highest;
}

float SecondHighest(vector<float> _Nums)
{
	float _Highest = _Nums[0];
	float _SecondHighest = _Highest;
	for (int i = 1; i < _Nums.size(); i++)
	{
		if (_Highest < _Nums[i])
		{
			_SecondHighest = _Highest;
			_Highest = _Nums[i];
		}
		else if (_SecondHighest < _Nums[i] && _Highest != _Nums[i])
		{
			_SecondHighest = _Nums[i];
		}
	}
	return _SecondHighest;
}
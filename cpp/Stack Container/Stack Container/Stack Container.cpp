﻿#include <cmath>
#include <iostream>
#include <stack>
#include <algorithm>
#include <stdexcept>
#include <string>
using std::string;

inline size_t precedence(const char op)
{
	if (op == '+' || op == '-')
		return 1;
	if (op == '*' || op == '/')
		return 2;
	if (op == '^')
		return 3;
	throw std::runtime_error{ string{"올바르지 않은 연산자 입니다: "} + op };
}

double execute(std::stack<char>& ops, std::stack<double>& operands)
{
	double result{};
	double rhs{ operands.top() };
	operands.pop();
	double lhs{ operands.top() };
	operands.pop();

	switch (ops.top())
	{
	case '+':
		result = lhs + rhs;
		break;
	case '-':
		result = lhs - rhs;
		break;
	case '*':
		result = lhs * rhs;
		break;
	case '/':
		result = lhs / rhs;
		break;
	case '^':
		result = std::pow(lhs, rhs);
		break;
	default:
		throw std::runtime_error{ string{"올바르지 않은 연산자 입니다 : "} + ops.top() };
	}
	ops.pop();
	operands.push(result);
	return result;
}
int main()
{
	std::stack<double> operands;
	std::stack<char> operators;
	string exp;
	std::cout <<
		"An Arithmetic expression can include the operators +, -, *, /, and ^ for exponentiation."
		<< std::endl;
	try
	{
		while (true)
		{
			std::cout << "Enter an arithmetic expression and press Enter - enter an empy line to end:"
				<< std::endl;
			std::getline(std::cin, exp, '\n');
			if (exp.empty()) break;

			exp.erase(std::remove(std::begin(exp), std::end(exp), ' '), std::end(exp));

			size_t index{};

			operands.push(std::stod(exp, &index));

			while (true)
			{
				operands.push(exp[index++]);

				size_t i{};
				operands.push(std::stod(exp.substr(index), &i));
				index += 1;
				if (index == exp.length())
				{
					while (!operators.empty())
						execute(operators, operands);
					break;
				}

				while (!operators.empty() && precedence(exp[index]) <= precedence(operators.top()))
					execute(operators, operands);
			}
			std::cout << "result = " << operands.top() << std::endl;
		}
		catch (const std::exception& e)
		{
			std::cerr << e.what() << std::endl;
		}
		std::cout << "Calculator Ending.." < std::endl;
	}
}
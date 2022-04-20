#include <iostream>
#include <list>
#include <string>
#include <functional>

using std::list;
using std::string;

template<typename Iter>
void list_elements(Iter begin, Iter end)
{
	while (begin != end)
		std::cout << *begin++ << std::endl;
}

int main()
{
	std::list<string> proverbs;

	// 속담을 읽어 들이기
	std::cout << "Enter a few proverbs and enter an empty line to end:" << std::endl;
	string proverb;
	while (getline(std::cin, proverb, '\n'), !proverb.empty())
		proverbs.push_front(proverb);

	std::cout << "Go on, just one more:" << std::endl;
	getline(std::cin, proverb, '\n');
	proverbs.emplace_back(proverb);

	std::cout << "\nThe elements in the list in reverse order are:" << std::endl;
	list_elements(std::rbegin(proverbs), std::rend(proverbs));

	proverbs.sort();
	std::cout << "\nYour proverbs in ascending sequence are:" << std::endl;
	list_elements(std::begin(proverbs), std::end(proverbs));

	proverbs.sort(std::greater<>());
	std::cout << "\nYour proverbs in descending sequence:" << std::endl;
	list_elements(std::begin(proverbs), std::end(proverbs));
}
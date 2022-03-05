#include <iostream>
#include <numeric>
#include <iterator>


int main()
{
	double data[]{ 2.5, 4.5, 6.5, 5.5, 8.5 };
	std::cout << "배열 원소들:\n";
	for (auto iter = std::begin(data); iter != std::end(data); ++iter)
		std::cout << *iter << " ";
	auto total = std::accumulate(std::begin(data), std::end(data), 0.0);
	std::cout << "\n배열 원소들의 합계: " << total << std::endl;
}


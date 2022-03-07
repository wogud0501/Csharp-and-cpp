#include <iostream>
#include <algorithm>
#include <deque>
#include <string>
#include <iterator>


using std::string;

int main()
{
    std::deque<string> names;
    std::cout << "첫번째 이름은 공백으로 구분해서 넣으세요. 새 줄에서 Ctrl + Z 를 입력하여 입력을 마치세요:\n";
    std::copy(std::begin(names), std::end(names), std::ostream_iterator<string> {std::cout, " "});
    std::cout << std::endl;
}
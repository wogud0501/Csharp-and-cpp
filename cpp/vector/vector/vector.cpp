#include <iostream>
#include <string>
#include <algorithm>
#include <vector>
#include <iterator>
using std::string;
using std::vector;


int main()
{
    vector<string> words;
    words.reserve(10);
    std::cout << "단어는 공백으로 구분해서 입력하세요. 종료하려면 다음 줄에서 Ctrl + Z를 입력하세요:" << std::endl;
    std::copy(std::istream_iterator<string> {std::cin}, std::istream_iterator<string> {},
        std::back_inserter(words));

    std::cout << "정렬을 시작합니다. " << std::endl;
    bool out_of_order{ false };
    auto last = std::end(words);
    while (true)
    {
        for (auto first = std::begin(words) + 1; first != last; ++first)
        {
            if (*(first - 1) > *first)
            {
                std::swap(*first, *(first - 1));
                out_of_order = true;
            }
        }
        if (!out_of_order)
            break;
        out_of_order = false;
    }

    std::cout << "오름차순으로 정렬된 단어:" << std::endl;
    std::copy(std::begin(words), std::end(words),
        std::ostream_iterator<string> {std::cout, " "});
    std::cout << std::endl;

    vector<string> words_copy{ std::make_move_iterator(std::begin(words)),\
                              std::make_move_iterator(std::end(words)) };
    std::cout << "\nwords에서 원소들을 이동한 후에 words_copy의 내용:" << std::endl;
    std::copy(std::begin(words_copy), std::end(words_copy),
        std::ostream_iterator<string> {std::cout, " "});
    std::cout << std::endl;

    std::cout << "\nwords 백터는 원소 " << words.size() << "개를 갖고 있습니다.\n";
    if (words.front().empty())
        std::cout << "첫 번째 원소는 빈 문자열 객체 입니다." << std::endl;

    std::cout << "첫 번째 원소는 \"" << words.front() << "\"입니다." << std::endl;

}
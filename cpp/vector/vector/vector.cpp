#include <iostream>                                                        // 표쥰 스트림  
#include <string>                                                          // stirng 타입
#include <algorithm>                                                       // swap()과 copy() 함수
#include <vector>                                                          // 백터
#include <iterator>                                                       // 반복자
using std::string;
using std::vector;


int main()
{
    vector<string> words;                                                  // 정렬할 단어를 저장
    words.reserve(10);                                                     // 원소들을 위한 공간 할당
    std::cout << "단어는 공백으로 구분해서 입력하세요. 종료하려면 다음 줄에서 Ctrl + Z를 입력하세요:" << std::endl; 
    std::copy(std::istream_iterator<string> {std::cin}, std::istream_iterator<string> {},
        std::back_inserter(words));

    std::cout << "정렬을 시작합니다. " << std::endl;
    bool out_of_order{ false };                                            // 값들이 정렬되지 않았으면 true
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
        if (!out_of_order)                                                  // 정렬된 상태이면 (교환이 필요 없움.)
            break;                                                          // 완료.
        out_of_order = false;                                               // 그렇지 않으면, 다시 반복.
    }

    // 정렬된 백터를 출력
    std::cout << "오름차순으로 정렬된 단어:" << std::endl;
    std::copy(std::begin(words), std::end(words),
        std::ostream_iterator<string> {std::cout, " "});
    std::cout << std::endl;

    // words 백터에서 원소들을 이동해서 새 벡터를 생성
    vector<string> words_copy{ std::make_move_iterator(std::begin(words)),\
                              std::make_move_iterator(std::end(words)) };
    std::cout << "\nwords에서 원소들을 이동한 후에 words_copy의 내용:" << std::endl;
    std::copy(std::begin(words_copy), std::end(words_copy),
        std::ostream_iterator<string> {std::cout, " "});
    std::cout << std::endl;

    // words 백터의 원소들에 무슨 일이 일어났는지 확인.
    std::cout << "\nwords 백터는 원소 " << words.size() << "개를 갖고 있습니다.\n";
    if (words.front().empty())
        std::cout << "첫 번째 원소는 빈 문자열 객체 입니다." << std::endl;

    std::cout << "첫 번째 원소는 \"" << words.front() << "\"입니다." << std::endl;

}   
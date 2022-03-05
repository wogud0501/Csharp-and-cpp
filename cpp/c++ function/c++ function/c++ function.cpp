// 알고리즘에 함수를 전달하기
#include <iostream>                         // 표준 스트림
#include <algorithm>                        // transform()
#include <iterator>                         // 반복자
#include <functional>                       // function


class Root
{
public:
    double operator()(double x) { return std::sqrt(x); };
};


int main()
{
    double data[]{ 1.5, 2.5, 3.5, 4.5, 5.5 };

    // 함수 객체를 전달하기
    Root root;
    std::cout << "제곱근은 : " << std::endl;
}


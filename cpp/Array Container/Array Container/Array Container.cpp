#include <iostream>                                                 // 표준 스트림
#include <iomanip>                                                  // 표준 조작자
#include <array>                                                    // array<T, N>

int main()
{
    const unsigned int min_wt { 100U };                // 최소 체중 표(파운드 단위)
    const unsigned int max_wt { 250U };                // 최대 체중 표(파운드 단위) 
    const unsigned int wt_step { 10U };                // 체중 증가 단위
    const size_t wt_count{ 1 + (max_wt - min_wt) / wt_step };


    const unsigned int min_ht { 48U };                 // 최소 키 표(인치 단위)
    const unsigned int max_ht { 84U };                 // 최대 키 표(인치 단위)
    const unsigned int ht_step { 2U };                 // 키 증가 단위
    const size_t ht_count{ 1 + (max_ht) - (min_ht) / ht_step };

    const double lbs_per_kg { 2.20462 };               // 파운드(lbs)를 킬로그램(kg)로 변환 값
    const double ins_per_m { 39.3701 };                // 인치를 미터로 변환 한 값

    std::array<unsigned int, wt_count> weight_lbs;
    std::array<unsigned int, ht_count> height_ins;

    // 100 파운드부터 10파운드씩 증가하는 체중 표를 생성
    for (size_t i{}, w{ min_wt }; i < wt_count; w += wt_step, ++i)
    {
        weight_lbs.at(i) = w;
    }

    // 48인치 부터 2인치 씩 증가하는 키 표를 생성
    unsigned int h{ min_ht };
    for (auto& height : height_ins)
    {
        height = h;
        h += ht_step;
    }

    // 표 제목 출력
    std::cout << std::setw(7) << " |";
    for (const auto& w : weight_lbs)
        std::cout << std::setw(5) << w << " |";
    std::cout << std::endl;

    // 표 제목 다음에 선 출력
    for (size_t i{ 1 }; i < wt_count; ++i)
        std::cout << "--------";
    std::cout << std::endl;

    double bmi {};                               // BMI 저장용
    unsigned int feet {};                        // 출력에 쓸 전체 피트 값
    unsigned int inches {};                      // 출렉에 쓸 전체 인치 값
    const unsigned int inches_per_foot { 12U };
    for (const auto& h : height_ins)
    {
        feet = h / inches_per_foot;
        inches = h % inches_per_foot;
        std::cout << std::setw(2) << feet << "'" << std::setw(2) << inches << "\"" << "|";
        std::cout << std::fixed << std::setprecision(1);
        for (const auto& w : weight_lbs)
        {
            bmi = h / ins_per_m;
            bmi = (w / lbs_per_kg) / (bmi * bmi);
            std::cout << std::setw(2) << " " << bmi << " |";
        }
        std::cout << std::endl;
    }
    // 표 다음에 선을 출력
    for (size_t i{ 1 }; i < wt_count; ++i)
        std::cout << "---------";
    std::cout << "\nBMI 18.5~24.9는 정상 입니다." << std::endl;
}

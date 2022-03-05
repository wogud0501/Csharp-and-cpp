#include <iostream>                                                 // 표준 스트림
#include <iomanip>                                                  // 표준 조작자
#include <array>                                                    // array<T, N>

int main()
{
    const unsigned int min_wt { 100U };                // 최소 체중 표(파운드 단위)
    const unsigned int max_wt { 250U };                // 최대 체중 표(파운드 단위) 
    const unsigned int wt_step { 10U };                // 체중 증가 단위
    const size_t ht_count{ 1 + (max_wt - min_wt) / wt_step };


    const unsigned int min_ht { 48U };                 // 최소 키 표(인치 단위)
    const unsigned int max_ht { 84U };                 // 최대 키 표(인치 단위)
    const unsigned int ht_step { 2U };                 // 키 증가 단위
    const size_t ht_count{ 1 + (max_ht) - (min_ht) / ht_step };
}

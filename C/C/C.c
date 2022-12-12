// 아래의 내용을 적은 후 알고리즘을 구현하는 소스를 작성하세요.👍
// 모둠이름 : 3조
// 알고리즘 : 선택정렬
// 코드출처 : 자체 제작

#include <stdio.h>
#pragma warning(disable : 4996)
#pragma warning(disable : 6031)
#pragma warning(disable : 6271)
#pragma warning(disable : 4474)

// 김도현
int main(void) {
  int data[10] = {6, 7, 8, 4, 3, 9, 5, 2, 1, 10};
  int random;
  // 랜덤한 위치를 정의하기 위하여 random라는 새로운 변수를 제작
  for (int i = 0; i < 10; i++) {
    printf("%d ", data[i]);
    // 정렬 전 배열 출력
  }
  printf("\n");

  // 재형
  // 위의 2개의 for문이 배열의 핵심이자 엑기스임.
  for (int i = 0; i < 10;
       i++) { // 10 ~ 1 까지 마지막 대상인 1은 비교할 필요가 없으니 생략하고
    for (int j = i + 1; j < 10;
         j++) { // 선정 위치의 + 1 부터 마지막까지 비교한다.
      if (data[i] > data[j]) {
        // 오름차순이니 작은지 확인. 만약 data[i] < data[j] 라면 내림차순으로
        // 정렬되므로 현재 값에서 반대로 정렬 됨.

        // 이정우
        random = data[i];
        data[i] = data[j];
        data[j] = random;
      }
    }
  }

  // 유건호
  printf("정렬 후 순서\n");
  for (int i = 0; i < 10; i++) {
    printf("%d ", data[i]);
    // 정렬 후 배열 출력.
  }
  printf("\n");
  return 0;
}
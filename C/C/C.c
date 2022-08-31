#include <stdio.h>
#pragma warning ( disable : 4996)
#pragma warning ( disable : 6031)
	
int main(void)
{
	int year, month, leapyear, maxDay;
	printf("원하는 날짜를 입력하세요. (년 월 입력)\n");
	scanf("%d %d", &year, &month);
	switch (month) {
	case 1:
	case 3:
	case 5:
	case 7:
	case 8:
	case 10:
	case 12:
		maxDay = 31;
		printf("%d", maxDay);
			break;
	case 2:
		if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) {
			leapyear = 29;
			maxDay = 29;
			printf("%d", maxDay);
			break;
		}
		else {
			leapyear = 28;
			maxDay = 28;
			printf("%d", maxDay);
			break;
		}
	case 4:
	case 6:
	case 9:
	case 11:
		maxDay = 30;
		printf("%d", maxDay);
		break;
	}
	return 0;
}
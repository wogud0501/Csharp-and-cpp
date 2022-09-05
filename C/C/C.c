#include <stdio.h>
#pragma warning ( disable : 6031 )
#pragma warning ( disable : 6271 )
#pragma warning ( disable : 4996 )
#pragma warning ( disable : 4474 )
int main(void)

{
	int clock = 0;
	scanf("&d", clock);
	if (clock >= 0 || clock < 8) {
		printf("취침");
	}
	else if (clock >= 9 || clock < 14) {
		printf("오전 수업");
	}
	else if (clock >= 14 || clock < 18) {
		printf("오후 수업");
	}
	return 0;
}
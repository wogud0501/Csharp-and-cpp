#include <stdio.h>
#pragma warning ( disable : 6031 )
#pragma warning ( disable : 6271 )
#pragma warning ( disable : 4996 )
#pragma warning ( disable : 4474 )

int main(void) {
	int num = 5;

	for (int i = 1; i <= num; i++) {
		for (int j = 1; j <= num; j++) {
			printf("*");
		}
		printf("\n");
	}
	return 0;
}
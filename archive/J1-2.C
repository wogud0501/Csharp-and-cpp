#include <stdio.h>
#pragma warning ( disable : 6031 )
#pragma warning ( disable : 6271 )
#pragma warning ( disable : 4996 )
#pragma warning ( disable : 4474 )

int main() {
	int num = 5;
	for (int i = 0; i < num; i++) {
		for (int j = 0; j < i; j++) {
			printf(" ");
		}

		for (int j = 2 * num - 1; j > 2 * i; j--) {
			printf("*");
		}
		printf("\n");
	}
}
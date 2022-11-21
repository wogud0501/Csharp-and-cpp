#include <stdio.h>
#pragma warning(disable : 4996)
#pragma warning ( disable : 6031 )
#pragma warning ( disable : 6271 )
#pragma warning ( disable : 4474 )

int main() {
	int data[10] = { 10, 6, 7, 9, 3, 4, 2, 1, 5, 8 };
	int temp;
	for (int i = 0; i < 10; i++) {
		printf("%d ", data[i]);
	}
	printf("\n");

	for (int i = 0; i < 9; i++) {
		for (int j = i + 1; j < 10; j++) {
			if (data[i] > data[j]) {
				temp = data[i];
				data[i] = data[j];
				data[j] = a;
			}
		}
	}

	printf("정렬 후 순서\n");
	for (int i = 0; i < 10; i++) {
		printf("%d ", data[i]);
	}
	printf("\n");
	return 0;
}
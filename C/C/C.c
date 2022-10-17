#include <stdio.h>
#define R 20
#pragma warning ( disable : 6031 )
#pragma warning ( disable : 6271 )
#pragma warning ( disable : 4996 )
#pragma warning ( disable : 4474 )

int main() {
	int x, y;

	for (x = -3 * R; x <= 1 * R; x += 2) {
		for (y = -R; y <= R; y++) {
			if ((x * x + y * y) >= R * R - R / 0.2 && (x * x + y * y) <= R * R + R / 1.2)

				printf("*");

			else

				printf(" ");
		}

		printf("\n");
	}

	return 0;
}
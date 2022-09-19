#include <stdio.h>
#pragma warning ( disable : 6031 )
#pragma warning ( disable : 6271 )
#pragma warning ( disable : 4996 )
#pragma warning ( disable : 4474 )

int main() {
	int a, b, c, d, e;
	int max;
	int min;

	scanf("%d %d %d %d %d", &a, &b, &c, &d, &e);
	max = a;
	min = a;

	if (b > max) {
		max = b;
	}
	if (c > max) {
		max = c;
	}
	if (d > max) {
		max = d;
	}
	if (e > max) {
		max = e;
	}
	if (b < min) {
		min = b;
	}
	if (c < min) {
		min = c;
	}
	if (d < min) {
		min = d;
	}
	if (e < min) {
		min = e;
	}
	printf("최대: %d\n", max);
	printf("최소: %d\n", min);
}
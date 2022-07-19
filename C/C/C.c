#include <stdio.h>
#pragma warning(disable : 4996)

int main() {
	int i;
	char d[21];
	scanf("%s", &d);
	for (i = 0; d[i] != '\0'; i++);
	{
		printf("\'%c\'", d[i]);
	}
	return 0;
}
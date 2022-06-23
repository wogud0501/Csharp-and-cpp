#include <stdio.h>
#pragma warning(disable : 4996)

int main() {
    int a = 0;
    while (a < 5) {
        a = a + 1;
        printf("Hello, world!\n");
        while (a == 5)
            break;
    }
}
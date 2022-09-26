#include <stdio.h>
#pragma warning ( disable : 6031 )
#pragma warning ( disable : 6271 )
#pragma warning ( disable : 4996 )
#pragma warning ( disable : 4474 )

int main() {
for(int i=0;i<5;i++){
    for(int j=0;j<=i;j++){
	printf("*");
    }
    printf("\n");
  }
}
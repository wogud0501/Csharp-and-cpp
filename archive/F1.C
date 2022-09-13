#include <stdio.h>
#pragma warning ( disable : 6031 )
#pragma warning ( disable : 6271 )
#pragma warning ( disable : 4996 )
#pragma warning ( disable : 4474 )
 
int main (void)
{
    
    int num,sum;
    scanf("%d",&num);
    int i = 0;
    sum = 0;
    while(1){
        i++;
        sum+=i;
        if(sum>=num){break;}
    }
    printf("%d",i);
    return 0;
}
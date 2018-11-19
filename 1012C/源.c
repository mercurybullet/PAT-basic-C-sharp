#include "stdio.h"

int main()
{
    int i, x, n, k = 0, t = 0;
    int a[5] = { 0 }, flag[5] = { 0 };
    scanf("%d", &n);
    for (i = 0; i < n; ++i)
    {
        scanf("%d", &x);
        if (0 == x % 10)
        {
            flag[0] = 1;
            a[0] += x;
        }
        if ((1 == x % 5) && (0 == k))
        {
            flag[1] = 1;
            a[1] += x;
            ++k;
        }
        else if ((1 == x % 5) && (1 == k))
        {
            a[1] -= x;
            --k;
        }
        if (2 == x % 5)
        {
            flag[2] = 1;
            ++a[2];
        }
        if (3 == x % 5)
        {
            flag[3] = 1;
            a[3] += x;
            ++t;
        }
        if ((4 == x % 5) && (a[4] < x))
        {
            flag[4] = 1;
            a[4] = x;
        }
    }
    if (flag[0]) printf("%d ", a[0]); else printf("%c ", 'N');
    if (flag[1]) printf("%d ", a[1]); else printf("%c ", 'N');
    if (flag[2]) printf("%d ", a[2]); else printf("%c ", 'N');
    if (flag[3]) printf("%.1f ", (1.0 * a[3]) / t); else printf("%c ", 'N');
    if (flag[4]) printf("%d\n", a[4]); else printf("%c\n", 'N');

    return 0;
}
#include <graphics.h>
#include <conio.h>

int main()
{
    int gd = DETECT, gm;
    initgraph(&gd, &gm, (char*)"C:\\Dev-Cpp\\MinGW32\\lib");

    // Circle
    circle(100, 100, 50);

    // Triangle
    int tri[] = {
        220, 50,
        220, 150,
        320, 150,
        220, 50
    };
    drawpoly(4, tri);

    // Square
    rectangle(370, 50, 470, 150);

    // Pentagon (Original Shape)
    int pent[] = {
        50, 220,
        150, 220,
        150, 320,
        100, 380,
        50, 320,
        50, 220
    };
    drawpoly(6, pent);

    // Rectangle
    rectangle(220, 250, 470, 350);

    getch();
    closegraph();
    return 0;
}

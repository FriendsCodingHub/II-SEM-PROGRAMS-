#include <stdio.h>
#include <conio.h>
#include <graphics.h>
#include <math.h>

int main() {
    int gd = DETECT, gm;
    initgraph(&gd, &gm, (char*)"C:\\Dev-Cpp\\MinGW32\\lib");

    int x1 = 150, y1 = 150;   // base position
    int depth = 40;

    float angle;
    float rad;

    // Original cube dimensions
    int x2 = 210;   // width
    int y2 = 210;   // height

    // Draw original cube
    outtextxy(x1, y1-20 , "Original");
    bar3d(x1, y1,x2,y2, depth, 1);

    angle=180;
    

    rad = angle * M_PI / 180;

    // Apply rotation on dimensions (TRICK)
    int new_x2 = abs(x2 * cos(rad) - y2 * sin(rad));
    int new_y2 = abs(x2 * sin(rad) + y2 * cos(rad));

    // Shift position so it looks separate
    int offset = 200;

    // Draw rotated-looking cube
    outtextxy(x1 + offset, y1 - 20, "Rotated 180 Deg");
    bar3d(x1 + offset, y1,offset + new_x2,new_y2, depth, 1);

    getch();
    closegraph();
    return 0;
}

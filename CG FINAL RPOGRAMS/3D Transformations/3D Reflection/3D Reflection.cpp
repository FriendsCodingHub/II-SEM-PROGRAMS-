#include <graphics.h>
#include <conio.h>
#include <dos.h>

int main() {
    int gd = DETECT, gm;
    initgraph(&gd, &gm, (char*)"C:\\Dev-Cpp\\MinGW32\\lib");

    // Original rectangle (cube)
    int x1 = 150, y1 = 150, x2 = 220, y2 = 220;
    int depth = 40;

    // Draw ORIGINAL cube
    setcolor(WHITE);
    outtextxy(x1, y1 - 20, (char*)"Original");
    bar3d(x1, y1, x2, y2, depth, 1);

    delay(2000);

    // ---- REFLECTION about horizontal line y = 300 ----
    int y_ref = 300;

    int ry1 = 2 * y_ref - y1;
    int ry2 = 2 * y_ref - y2;

    // Fix order (important!)
    int new_y1 = (ry1 < ry2) ? ry1 : ry2;
    int new_y2 = (ry1 > ry2) ? ry1 : ry2;

    // Draw REFLECTED cube
    setcolor(YELLOW);
    outtextxy(x1, new_y1 - 20, (char*)"Reflected");
    bar3d(x1, new_y1, x2, new_y2, depth, 1);

    getch();
    closegraph();
    return 0;
}


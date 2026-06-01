#include <stdio.h>
#include <stdlib.h>

#define MAX 100

int V, E;

// Edge structure
struct Edge
{
    int u, v, weight;
};

struct Edge edges[MAX];

// Disjoint Set (Union-Find)
int parent[MAX];

// Find function
int find(int i)
{
    while(parent[i] != i)
        i = parent[i];

    return i;
}

// Union function
void unionSet(int u, int v)
{
    int rootU = find(u);
    int rootV = find(v);

    parent[rootU] = rootV;
}

// Sort edges by weight
void sortEdges()
{
    for(int i=1; i<=E-1; i++) // CHANGED
    {
        for(int j=1; j<=E-i; j++) // CHANGED
        {
            if(edges[j].weight > edges[j+1].weight)
            {
                struct Edge temp = edges[j];
                edges[j] = edges[j+1];
                edges[j+1] = temp;
            }
        }
    }
}

// Kruskal function
void kruskalMST()
{
    int totalCost = 0;

    // CHANGED: initialize parent from 1
    for(int i=1; i<=V; i++)
        parent[i] = i;

    sortEdges();

    printf("\nEdge \tWeight\n");

    // CHANGED: loop starts from 1
    for(int i=1; i<=E; i++)
    {
        int u = edges[i].u;
        int v = edges[i].v;

        if(find(u) != find(v))
        {
            printf("%d - %d \t%d\n",u, v,edges[i].weight);

            totalCost += edges[i].weight;

            unionSet(u, v);
        }
    }

    printf("Total Cost of MST = %d\n", totalCost);
}

int main()
{
    printf("Enter number of vertices: ");
    scanf("%d", &V);

    printf("Enter number of edges: ");
    scanf("%d", &E);

    printf("Enter %d edges:\n", E);

    // CHANGED: loop starts from 1
    for(int i=1; i<=E; i++)
    {
        printf("Enter edge (u v weight): ");

        scanf("%d %d %d",&edges[i].u,&edges[i].v, &edges[i].weight);
    }

    kruskalMST();

    return 0;
}



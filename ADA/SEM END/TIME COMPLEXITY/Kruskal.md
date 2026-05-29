### Algorithm Analysis

Kruskal's Algorithm consists of two major operations:

1. Sorting all edges by weight.
2. Performing Union-Find operations for MST construction.

---

### Edge Sorting Analysis

```c
for(int i=1; i<=E-1; i++)
{
    for(int j=1; j<=E-i; j++)
    {
        if(edges[j].weight > edges[j+1].weight)
        {
            swap(edges[j], edges[j+1]);
        }
    }
}
```

Outer loop runs

$$
E-1
$$

times.

Inner loop runs

$$
(E-1)+(E-2)+(E-3)+\cdots+2+1
$$

Therefore,

$$
T(E)=(E-1)+(E-2)+\cdots+2+1
$$

Using the sum of first \((E-1)\) natural numbers,

$$
T(E)=\frac{E(E-1)}{2}
$$

Expanding,

$$
T(E)=\frac{E^2-E}{2}
$$

Thus,

$$
T(E)=O(E^2)
$$

---

### Union-Find Analysis

```c
for(int i=1; i<=E; i++)
{
    if(find(u) != find(v))
    {
        unionSet(u,v);
    }
}
```

The loop runs

$$
E
$$

times.

Therefore,

$$
T(E)=O(E)
$$

---

### Total Complexity

$$
T(E)=O(E^2)+O(E)
$$

Since

$$
O(E^2) > O(E)
$$

Therefore,

$$
T(E)=O(E^2)
$$

### Derivation of Time Complexity

$$
T(E)=\frac{E(E-1)}{2}+E
$$

$$
=\frac{E^2-E}{2}+E
$$

$$
=\frac{E^2+E}{2}
$$

Ignoring constants and lower-order terms,

$$
T(E)=O(E^2)
$$

### Time Complexity

**Best Case:**

$$
O(E^2)
$$

**Average Case:**

$$
O(E^2)
$$

**Worst Case:**

$$
O(E^2)
$$

### Space Complexity

Arrays used:

```c
edges[E]
parent[V]
```

Therefore,

$$
S(V,E)=O(V+E)
$$

---

### Short ADA Exam Format

$$
T(E)=(E-1)+(E-2)+\cdots+2+1
$$

$$
T(E)=\frac{E(E-1)}{2}
$$

$$
=\frac{E^2-E}{2}
$$

$$
=O(E^2)
$$

Adding Union-Find cost,

$$
O(E^2)+O(E)
$$

$$
=O(E^2)
$$

**Best Case = O(E²)**

**Average Case = O(E²)**

**Worst Case = O(E²)**

**Time Complexity = O(E²)**

**Space Complexity = O(V+E)**
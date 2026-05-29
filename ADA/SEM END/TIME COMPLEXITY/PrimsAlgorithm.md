### Algorithm Analysis

```c
for(int count=1; count<V; count++)
{
    int u = minKey(key, mstSet);

    for(int j=1; j<=V; j++)
    {
        if(graph[u][j] != 0 &&
           !mstSet[j] &&
           graph[u][j] < key[j])
        {
            parent[j] = u;
            key[j] = graph[u][j];
        }
    }
}
```

The algorithm uses an adjacency matrix.

The outer loop runs

$$
(V-1)
$$

times.

For each iteration:

### minKey()

```c
for(int i=1; i<=V; i++)
```

runs

$$
V
$$

times.

Therefore,

$$
T_1(V)=V(V-1)
$$

$$
=O(V^2)
$$

---

### Adjacency Matrix Scan

```c
for(int j=1; j<=V; j++)
```

runs

$$
V
$$

times for every iteration of outer loop.

Therefore,

$$
T_2(V)=V(V-1)
$$

$$
=O(V^2)
$$

---

### Total Complexity

$$
T(V)=T_1(V)+T_2(V)
$$

$$
=V(V-1)+V(V-1)
$$

$$
=2V(V-1)
$$

$$
=2V^2-2V
$$

### Derivation of Time Complexity

Applying Big-O notation,

$$
T(V)=2V^2-2V
$$

Ignoring constants and lower-order terms,

$$
T(V)=O(V^2)
$$

### Time Complexity

**Best Case:**

$$
O(V^2)
$$

**Average Case:**

$$
O(V^2)
$$

**Worst Case:**

$$
O(V^2)
$$

### Space Complexity

Arrays used:

```c
parent[V]
key[V]
mstSet[V]
graph[V][V]
```

The adjacency matrix dominates.

$$
S(V)=V^2
$$

$$
S(V)=O(V^2)
$$

---

### Short ADA Exam Format

$$
T(V)=V(V-1)+V(V-1)
$$

$$
=2V(V-1)
$$

$$
=2V^2-2V
$$

$$
=O(V^2)
$$

**Best Case = O(V²)**

**Average Case = O(V²)**

**Worst Case = O(V²)**

**Time Complexity = O(V²)**

**Space Complexity = O(V²)**
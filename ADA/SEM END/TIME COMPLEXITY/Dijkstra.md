### Algorithm Analysis

```c
while(count < n - 1)
{
    u = findMin();

    for(i = 1; i <= n; i++)
    {
        if(vis[i] == 0)
        {
            if(d[u] + a[u][i] < d[i])
            {
                d[i] = d[u] + a[u][i];
            }
        }
    }
}
```

This implementation uses an **Adjacency Matrix**.

---

### findMin() Analysis

```c
for(i = 1; i <= n; i++)
{
    if(vis[i] == 0 && d[i] < mini)
    {
        ...
    }
}
```

The loop runs

$$
n
$$

times.

Therefore,

$$
T_1(n)=O(n)
$$

---

### Main Dijkstra Loop

```c
while(count < n-1)
```

runs

$$
n-1
$$

times.

For each iteration:

1. `findMin()` takes

$$
O(n)
$$

2. Relaxation loop

```c
for(i = 1; i <= n; i++)
```

takes

$$
O(n)
$$

Therefore,

$$
T(n)=(n-1)(n+n)
$$

$$
=(n-1)(2n)
$$

$$
=2n^2-2n
$$

### Derivation of Time Complexity

Applying Big-O notation,

$$
T(n)=2n^2-2n
$$

Ignoring constants and lower-order terms,

$$
T(n)=O(n^2)
$$

### Time Complexity

**Best Case:**

$$
O(n^2)
$$

**Average Case:**

$$
O(n^2)
$$

**Worst Case:**

$$
O(n^2)
$$

### Space Complexity

Arrays used:

```c
a[n][n]
d[n]
vis[n]
p[n]
```

Adjacency matrix dominates.

$$
S(n)=n^2
$$

$$
S(n)=O(n^2)
$$

---

### Short ADA Exam Format

$$
T(n)=(n-1)(n+n)
$$

$$
=(n-1)(2n)
$$

$$
=2n^2-2n
$$

$$
=O(n^2)
$$

**Best Case = O(n²)**

**Average Case = O(n²)**

**Worst Case = O(n²)**

**Time Complexity = O(n²)**

**Space Complexity = O(n²)**
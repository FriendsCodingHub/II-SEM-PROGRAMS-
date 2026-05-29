### Algorithm Analysis

```c
for(int k=1; k<=n; k++)
{
    for(int i=1; i<=n; i++)
    {
        for(int j=1; j<=n; j++)
        {
            if(a[i][j] > a[i][k] + a[k][j])
            {
                a[i][j] = a[i][k] + a[k][j];
            }
        }
    }
}
```

The outer loop runs

$$
n
$$

times.

The middle loop runs

$$
n
$$

times for each iteration of the outer loop.

The inner loop runs

$$
n
$$

times for each iteration of the middle loop.

Therefore,

$$
T(n)=n \times n \times n
$$

$$
T(n)=n^3
$$

### Derivation of Time Complexity

Applying Big-O notation,

$$
T(n)=n^3
$$

Therefore,

$$
T(n)=O(n^3)
$$

### Time Complexity

**Best Case:**

$$
O(n^3)
$$

**Average Case:**

$$
O(n^3)
$$

**Worst Case:**

$$
O(n^3)
$$

### Space Complexity

The algorithm uses an adjacency matrix.

$$
n \times n
$$

Therefore,

$$
S(n)=n^2
$$

$$
S(n)=O(n^2)
$$

---

### Short ADA Exam Format

$$
T(n)=n \times n \times n
$$

$$
=n^3
$$

$$
=O(n^3)
$$

**Best Case = O(n³)**

**Average Case = O(n³)**

**Worst Case = O(n³)**

**Time Complexity = O(n³)**

**Space Complexity = O(n²)**
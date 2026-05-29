### Algorithm Analysis

```c
for(int i = 0; i < r; i++)
{
    for(int j = 0; j < c; j++)
    {
        sum[i][j] = a[i][j] + b[i][j];
    }
}
```

Outer loop runs `r` times.

Inner loop runs `c` times for each iteration of outer loop.

Therefore,

$$
T(r,c)=r \times c
$$

$$
T(r,c)=rc
$$

### Derivation of Time Complexity

Applying Big-O notation:

$$
T(r,c)=rc
$$

Therefore,

$$
T(r,c)=O(rc)
$$

If the matrix is square, i.e.,

$$
r=c=n
$$

Then,

$$
T(n)=n \times n
$$

$$
T(n)=n^2
$$

Therefore,

$$
T(n)=O(n^2)
$$

### Time Complexity

For an \(r \times c\) matrix:

$$
O(rc)
$$

For an \(n \times n\) matrix:

$$
O(n^2)
$$

### Space Complexity

The result matrix `sum[r][c]` is used.

$$
O(rc)
$$

---

### Short ADA Exam Format

$$
T(r,c)=r \times c
$$

$$
=rc
$$

$$
=O(rc)
$$

For square matrix,

$$
T(n)=n \times n
$$

$$
=n^2
$$

$$
=O(n^2)
$$

**Time Complexity = O(rc)**

**For Square Matrix = O(n²)**

**Space Complexity = O(rc)**
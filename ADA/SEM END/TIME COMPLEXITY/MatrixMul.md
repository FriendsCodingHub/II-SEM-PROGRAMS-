### Algorithm Analysis

```c
for(int i=0;i<r1;i++)
{
    for(int j=0;j<c2;j++)
    {
        for(int k=0;k<c1;k++)
        {
            mul[i][j]+=a[i][k]*b[k][j];
        }
    }
}
```

Outer loop runs `r1` times.

Middle loop runs `c2` times for each iteration of outer loop.

Inner loop runs `c1` times for each iteration of middle loop.

Therefore,

$$
T(r1,c1,c2)=r1 \times c2 \times c1
$$

$$
T(r1,c1,c2)=r1c1c2
$$

### Derivation of Time Complexity

Applying Big-O notation:

$$
T(r1,c1,c2)=r1c1c2
$$

Therefore,

$$
T(r1,c1,c2)=O(r1c1c2)
$$

If both matrices are square matrices,

$$
r1=c1=c2=n
$$

Then,

$$
T(n)=n \times n \times n
$$

$$
T(n)=n^3
$$

Therefore,

$$
T(n)=O(n^3)
$$

### Time Complexity

For general matrices:

$$
O(r1c1c2)
$$

For square matrices:

$$
O(n^3)
$$

### Space Complexity

Result matrix contains:

$$
r1 \times c2
$$

elements.

Therefore,

$$
O(r1c2)
$$

For square matrices,

$$
O(n^2)
$$

---

### Short ADA Exam Format

$$
T(r1,c1,c2)=r1 \times c2 \times c1
$$

$$
=r1c1c2
$$

$$
=O(r1c1c2)
$$

For square matrices,

$$
T(n)=n \times n \times n
$$

$$
=n^3
$$

$$
=O(n^3)
$$

**Time Complexity = O(r1c1c2)**

**For Square Matrix = O(n³)**

**Space Complexity = O(r1c2)**
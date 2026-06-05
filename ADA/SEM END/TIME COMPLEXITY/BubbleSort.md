### Algorithm Analysis

```c
for(int i = 0; i < n - 1; i++)
{
    for(int j = 0; j < n - 1 - i; j++)
    {
        if(a[j] > a[j + 1])
        {
            swap(a[j], a[j + 1]);
        }
    }
}
```

Outer loop runs:

$$
n-1
$$

times.

Inner loop runs:

For \(i=0\)

$$
n-1
$$

times.

For \(i=1\)

$$
n-2
$$

times.

For \(i=2\)

$$
n-3
$$

times.

...

For \(i=n-2\)

$$
1
$$

time.

Therefore,

$$
T(n)=(n-1)+(n-2)+(n-3)+\cdots+2+1
$$

Using the sum of first \((n-1)\) natural numbers,

$$
T(n)=\frac{n(n-1)}{2}
$$

Expanding,

$$
T(n)=\frac{n^2-n}{2}
$$

### Derivation of Time Complexity

Applying Big-O notation:

$$
T(n)=\frac{n^2-n}{2}
$$

Ignoring constant and lower-order term \(-n\),

$$
T(n)=O(n^2)
$$

### Time Complexity

**Worst Case:** (Array in descending order)

$$
O(n^2)
$$

**Average Case:**

$$
O(n^2)
$$

**Best Case:** (Array already sorted)

Since `flag == 0`, the algorithm stops after the first pass.

Outer loop executes once and inner loop performs:

$$
n-1
$$

comparisons.

Therefore,

$$
T(n)=n-1
$$

$$
T(n)=O(n)
$$

### Space Complexity

Only variables `flag` and `temp` are used.

$$
O(1)
$$

---

### Short ADA Exam Format

#### Worst Case

$$
T(n)=(n-1)+(n-2)+\cdots+2+1
$$

$$
T(n)=\frac{n(n-1)}{2}
$$

$$
=\frac{n^2-n}{2}
$$

$$
=O(n^2)
$$

#### Best Case

$$
T(n)=n-1
$$

$$
=O(n)
$$

**Best Case = O(n)**

**Average Case = O(n²)**

**Worst Case = O(n²)**

**Time Complexity = O(n²)**

**Space Complexity = O(1)**
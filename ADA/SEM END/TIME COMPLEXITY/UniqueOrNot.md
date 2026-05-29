### Algorithm Analysis

```c
for(int i = 0; i < n; i++)
{
    for(int j = i + 1; j < n; j++)
    {
        if(a[i] == a[j])
        {
            return 0;
        }
    }
}
```

Outer loop runs `n` times.

Inner loop runs:

For `i = 0`  → `(n-1)` times

For `i = 1`  → `(n-2)` times

For `i = 2`  → `(n-3)` times

...

For `i = n-2` → `1` time

For `i = n-1` → `0` times

Therefore,

$$
T(n)=(n-1)+(n-2)+(n-3)+\cdots+2+1
$$

Using the sum of first `(n-1)` natural numbers,

$$
T(n)=\frac{(n-1)n}{2}
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

Ignoring constant $\frac{1}{2}$ and lower-order term $-n$,

$$
T(n)=O(n^2)
$$

### Time Complexity

**Worst Case:**

$$
O(n^2)
$$

**Best Case:**

If duplicate is found in the first comparison,

$$
O(1)
$$

**Average Case:**

$$
O(n^2)
$$

### Space Complexity

Only variables `i`, `j`, and `flag` are used.

$$
O(1)
$$

---

### Short ADA Exam Format

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

**Time Complexity = O(n²)**

**Space Complexity = O(1)**
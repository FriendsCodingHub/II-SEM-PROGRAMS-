### Algorithm Analysis

```c
for(int i = 1; i < n; i++)
{
    if(a[i] > max)
        max = a[i];

    if(a[i] < min)
        min = a[i];
}
```

Loop runs from `i = 1` to `i = n-1`

Number of iterations:

$$
n-1
$$

For each iteration:

- One comparison for maximum
- One comparison for minimum

Therefore,

$$
T(n)=2(n-1)
$$

Expanding,

$$
T(n)=2n-2
$$

### Derivation of Time Complexity

Applying Big-O notation:

$$
T(n)=2n-2
$$

Ignoring constant `2` and lower-order term `-2`:

$$
T(n)=O(n)
$$

### Time Complexity

$$
O(n)
$$

### Space Complexity

Only `min`, `max`, and loop variable are used.

$$
O(1)
$$

---

### Short ADA Exam Format

$$
T(n)=2(n-1)
$$

$$
=2n-2
$$

$$
=O(n)
$$

**Time Complexity = O(n)**

**Space Complexity = O(1)**
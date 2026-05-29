### Algorithm Analysis

```c
while(low <= high)
{
    mid = (low + high) / 2;

    if(a[mid] == data)
        return mid;
    else if(data < a[mid])
        high = mid - 1;
    else
        low = mid + 1;
}
```

In each iteration, the search space is reduced to half.

Initially,

$$
n
$$

elements are present.

After 1st iteration,

$$
\frac{n}{2}
$$

elements remain.

After 2nd iteration,

$$
\frac{n}{2^2}
$$

elements remain.

After 3rd iteration,

$$
\frac{n}{2^3}
$$

elements remain.

After k iterations,

$$
\frac{n}{2^k}
$$

elements remain.

For successful termination,

$$
\frac{n}{2^k}=1
$$

Taking logarithm on both sides,

$$
n=2^k
$$

$$
k=\log_2 n
$$

Therefore,

$$
T(n)=O(\log n)
$$

### Derivation of Time Complexity

$$
\frac{n}{2^k}=1
$$

$$
n=2^k
$$

$$
k=\log_2 n
$$

$$
T(n)=O(\log n)
$$

### Time Complexity

**Best Case:**

Element found at first middle position.

$$
O(1)
$$

**Average Case:**

$$
O(\log n)
$$

**Worst Case:**

$$
O(\log n)
$$

### Space Complexity

Only variables `low`, `high`, and `mid` are used.

$$
O(1)
$$

---

### Short ADA Exam Format

$$
\frac{n}{2^k}=1
$$

$$
n=2^k
$$

$$
k=\log_2 n
$$

$$
T(n)=O(\log n)
$$

**Best Case = O(1)**

**Average Case = O(log n)**

**Worst Case = O(log n)**

**Time Complexity = O(log n)**

**Space Complexity = O(1)**
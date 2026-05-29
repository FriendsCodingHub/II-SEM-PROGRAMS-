### Algorithm Analysis

```c
MergeSortAscending(a, lb, mid);
MergeSortAscending(a, mid + 1, ub);
Merge(a, lb, mid, ub);
```

The array is divided into two equal halves at each recursive call.

Therefore,

$$
T(n)=2T\left(\frac{n}{2}\right)+n
$$

where,

$$
2T\left(\frac{n}{2}\right)
$$

represents sorting two subarrays and

$$
n
$$

represents the merge operation.

### Derivation of Time Complexity

Given,

$$
T(n)=2T\left(\frac{n}{2}\right)+n
$$

Expanding,

$$
T(n)=2\left[2T\left(\frac{n}{2^2}\right)+\frac{n}{2}\right]+n
$$

$$
=2^2T\left(\frac{n}{2^2}\right)+2n
$$

Again expanding,

$$
T(n)=2^3T\left(\frac{n}{2^3}\right)+3n
$$

Continuing,

$$
T(n)=2^kT\left(\frac{n}{2^k}\right)+kn
$$

At base condition,

$$
\frac{n}{2^k}=1
$$

$$
n=2^k
$$

$$
k=\log_2 n
$$

Substituting,

$$
T(n)=2^{\log_2 n}T(1)+n\log_2 n
$$

Since,

$$
2^{\log_2 n}=n
$$

and

$$
T(1)=1
$$

Therefore,

$$
T(n)=n+n\log_2 n
$$

Ignoring lower-order term,

$$
T(n)=O(n\log n)
$$

### Time Complexity

**Best Case:**

$$
O(n\log n)
$$

**Average Case:**

$$
O(n\log n)
$$

**Worst Case:**

$$
O(n\log n)
$$

### Space Complexity

An auxiliary array is used during merging.

$$
O(n)
$$

---

### Short ADA Exam Format

$$
T(n)=2T\left(\frac{n}{2}\right)+n
$$

$$
=2^kT\left(\frac{n}{2^k}\right)+kn
$$

For,

$$
\frac{n}{2^k}=1
$$

$$
k=\log_2 n
$$

Substituting,

$$
T(n)=n+n\log_2 n
$$

$$
=O(n\log n)
$$

**Best Case = O(n log n)**

**Average Case = O(n log n)**

**Worst Case = O(n log n)**

**Time Complexity = O(n log n)**

**Space Complexity = O(n)**
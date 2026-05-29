### Algorithm Analysis

```c
int loc = Partition(a, lb, ub);

QuickSort(a, lb, loc - 1);

QuickSort(a, loc + 1, ub);
```

Quick Sort divides the array into two parts using a pivot element.

The Partition operation requires

$$
O(n)
$$

time.

Therefore,

$$
T(n)=T(k)+T(n-k-1)+n
$$

where

$$
k
$$

elements are on the left side of pivot and

$$
n-k-1
$$

elements are on the right side.

---

### Best Case Analysis

The pivot divides the array into two equal halves.

Therefore,

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

$$
=2^3T\left(\frac{n}{2^3}\right)+3n
$$

$$
\vdots
$$

$$
=2^kT\left(\frac{n}{2^k}\right)+kn
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
T(n)=n+n\log_2 n
$$

$$
T(n)=O(n\log n)
$$

---

### Average Case Analysis

On average, the pivot divides the array nearly into two equal parts.

Therefore,

$$
T(n)=2T\left(\frac{n}{2}\right)+n
$$

Expanding,

$$
T(n)=2^kT\left(\frac{n}{2^k}\right)+kn
$$

At base condition,

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
T(n)=O(n\log n)
$$

---

### Worst Case Analysis

Worst case occurs when pivot is always the first or last element.

Then,

$$
T(n)=T(n-1)+n
$$

Expanding,

$$
T(n)=T(n-2)+(n-1)+n
$$

$$
=T(n-3)+(n-2)+(n-1)+n
$$

$$
\vdots
$$

$$
=T(1)+2+3+\cdots+n
$$

Using,

$$
1+2+3+\cdots+n=\frac{n(n+1)}{2}
$$

Therefore,

$$
T(n)=\frac{n(n+1)}{2}
$$

$$
=\frac{n^2+n}{2}
$$

Ignoring lower-order terms,

$$
T(n)=O(n^2)
$$

---

### Time Complexity

$$
\text{Best Case}=O(n\log n)
$$

$$
\text{Average Case}=O(n\log n)
$$

$$
\text{Worst Case}=O(n^2)
$$

### Space Complexity

$$
O(\log n)
$$

---


#### Best Case

$$
T(n)=2T\left(\frac{n}{2}\right)+n
$$

$$
=O(n\log n)
$$

#### Average Case

$$
T(n)=2T\left(\frac{n}{2}\right)+n
$$

$$
=O(n\log n)
$$

#### Worst Case

$$
T(n)=T(n-1)+n
$$

$$
=T(1)+2+3+\cdots+n
$$

$$
=\frac{n(n+1)}{2}
$$

$$
=O(n^2)
$$

**Best Case = O(n log n)**

**Average Case = O(n log n)**

**Worst Case = O(n²)**

**Space Complexity = O(log n)**
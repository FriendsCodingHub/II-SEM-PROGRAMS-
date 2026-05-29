### Algorithm Analysis

```c
for(int i = 1; i < n; i++)
{
    temp = a[i];
    j = i - 1;

    while(j >= 0 && a[j] > temp)
    {
        a[j + 1] = a[j];
        j--;
    }

    a[j + 1] = temp;
}
```

Outer loop runs:

$$
n-1
$$

times.

In the worst case (array in descending order), the inner while loop executes:

For \(i=1\)

$$
1
$$

time.

For \(i=2\)

$$
2
$$

times.

For \(i=3\)

$$
3
$$

times.

...

For \(i=n-1\)

$$
n-1
$$

times.

Therefore,

$$
T(n)=1+2+3+\cdots+(n-1)
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

Ignoring constant \(\frac{1}{2}\) and lower-order term \(-n\),

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

The condition

```c
a[j] > temp
```

fails immediately for every iteration.

Therefore, only one comparison is made per pass.

$$
T(n)=n-1
$$

$$
T(n)=O(n)
$$

### Space Complexity

Only variables `temp` and `j` are used.

$$
O(1)
$$

---

### Short ADA Exam Format

#### Worst Case

$$
T(n)=1+2+3+\cdots+(n-1)
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
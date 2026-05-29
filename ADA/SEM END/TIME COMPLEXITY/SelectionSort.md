### Algorithm Analysis

```c
for(int i = 0; i < n - 1; i++)
{
    int min = i;

    for(int j = i + 1; j < n; j++)
    {
        if(a[j] < a[min])
        {
            min = j;
        }
    }

    if(min != i)
    {
        swap(a[i], a[min]);
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

Ignoring constant \(\frac{1}{2}\) and lower-order term \(-n\),

$$
T(n)=O(n^2)
$$

### Time Complexity

**Best Case:**

$$
O(n^2)
$$

**Average Case:**

$$
O(n^2)
$$

**Worst Case:**

$$
O(n^2)
$$

### Space Complexity

Only variables `min` and `temp` are used.

$$
O(1)
$$

---

### Short ADA Exam Format

$$
T(n)=(n-1)+(n-2)+(n-3)+\cdots+2+1
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

**Best Case = O(n²)**

**Average Case = O(n²)**

**Worst Case = O(n²)**

**Time Complexity = O(n²)**

**Space Complexity = O(1)**
### Algorithm Analysis

```c
for(int i = 0; i <= n-m; i++)
{
    for(int j = 0; j < m; j++)
    {
        if(text[i+j] != pattern[j])
        {
            break;
        }
    }

    if(j == m)
    {
        return 0;
    }
}
```

Let,

$$
n = \text{Length of Text}
$$

$$
m = \text{Length of Pattern}
$$

The outer loop runs

$$
(n-m+1)
$$

times.

For each iteration of the outer loop, the inner loop may compare up to

$$
m
$$

characters.

Therefore,

$$
T(n,m)=(n-m+1)\times m
$$

Expanding,

$$
T(n,m)=nm-m^2+m
$$

### Derivation of Time Complexity

Applying Big-O notation,

$$
T(n,m)=nm-m^2+m
$$

Ignoring lower-order terms,

$$
T(n,m)=O(nm)
$$

### Time Complexity

**Best Case:**

Pattern found at first position.

$$
O(m)
$$

**Average Case:**

$$
O(nm)
$$

**Worst Case:**

Pattern checked at every position.

$$
O(nm)
$$

### Space Complexity

Only variables `i`, `j`, `n`, and `m` are used.

$$
O(1)
$$

---

### Short ADA Exam Format

$$
T(n,m)=(n-m+1)\times m
$$

$$
=nm-m^2+m
$$

$$
=O(nm)
$$

**Best Case = O(m)**

**Average Case = O(nm)**

**Worst Case = O(nm)**

**Time Complexity = O(nm)**

**Space Complexity = O(1)**
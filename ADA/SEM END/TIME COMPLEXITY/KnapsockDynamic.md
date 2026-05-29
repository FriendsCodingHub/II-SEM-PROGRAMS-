### Algorithm Analysis

```c
for(int i = 0; i <= n; i++)
{
    for(int j = 0; j <= W; j++)
    {
        V[i][j] = ...
    }
}
```

The outer loop runs

$$
(n+1)
$$

times.

The inner loop runs

$$
(W+1)
$$

times.

Therefore,

$$
T(n,W)=(n+1)(W+1)
$$

Expanding,

$$
T(n,W)=nW+n+W+1
$$

### Derivation of Time Complexity

Applying Big-O notation,

$$
T(n,W)=nW+n+W+1
$$

Ignoring lower-order terms,

$$
T(n,W)=O(nW)
$$

---

### Selected Item Trace Analysis

```c
while(i > 0 && j > 0)
{
    ...
}
```

The loop executes at most

$$
n
$$

times.

Therefore,

$$
T(n)=O(n)
$$

Since

$$
O(nW) > O(n)
$$

the dominant term is

$$
O(nW)
$$

---

### Time Complexity

**Best Case:**

$$
O(nW)
$$

**Average Case:**

$$
O(nW)
$$

**Worst Case:**

$$
O(nW)
$$

### Space Complexity

The DP table contains

$$
(n+1)(W+1)
$$

entries.

Therefore,

$$
S(n,W)=O(nW)
$$

---

### Short ADA Exam Format

$$
T(n,W)=(n+1)(W+1)
$$

$$
=nW+n+W+1
$$

$$
=O(nW)
$$

Therefore,

$$
\text{Best Case}=O(nW)
$$

$$
\text{Average Case}=O(nW)
$$

$$
\text{Worst Case}=O(nW)
$$

$$
\text{Space Complexity}=O(nW)
$$
### Algorithm Analysis

```c
if(n==1)
{
    mov++;
    return 0;
}

Hanoi(n-1,source,destination,via);

mov++;

Hanoi(n-1,via,source,destination);
```

For `n > 1`, the function performs:

- One recursive call of size `(n-1)`
- One constant-time move operation
- Another recursive call of size `(n-1)`

Therefore,

$$
T(n)=T(n-1)+1+T(n-1)
$$

$$
T(n)=2T(n-1)+1
$$

### Derivation of Time Complexity

Expanding,

$$
T(n)=2[T(n-2)+1]+1
$$

$$
=2T(n-2)+2+1
$$

$$
=2[2T(n-3)+1]+3
$$

$$
=2^2T(n-3)+2^2-1
$$

Continuing,

$$
T(n)=2^kT(n-k)+(2^k-1)
$$

At base condition,

$$
n-k=1
$$

$$
k=n-1
$$

Substituting,

$$
T(n)=2^{n-1}T(1)+(2^{n-1}-1)
$$

Since,

$$
T(1)=1
$$

$$
T(n)=2^{n-1}+2^{n-1}-1
$$

$$
T(n)=2^n-1
$$

Ignoring lower-order term,

$$
T(n)=O(2^n)
$$

### Time Complexity

$$
O(2^n)
$$

### Space Complexity

The maximum recursion depth is `n`.

$$
O(n)
$$

---

### Short ADA Exam Format

$$
T(n)=2T(n-1)+1
$$

$$
=2^kT(n-k)+(2^k-1)
$$

For,

$$
n-k=1
$$

$$
k=n-1
$$

$$
T(n)=2^{n-1}T(1)+(2^{n-1}-1)
$$

$$
=2^n-1
$$

$$
=O(2^n)
$$

**Time Complexity = O(2ⁿ)**

**Space Complexity = O(n)**
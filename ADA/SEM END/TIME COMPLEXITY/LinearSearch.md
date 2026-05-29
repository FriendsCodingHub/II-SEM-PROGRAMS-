### Algorithm Analysis

```c
for(int i = 0; i < n; i++)
{
    if(a[i] == data)
    {
        flag = 1;
        break;
    }
}
```

The loop scans the array element by element.

In the worst case, the element is either not present or present at the last position.

Therefore,

$$
T(n)=n
$$

### Derivation of Time Complexity

Applying Big-O notation:

$$
T(n)=n
$$

Therefore,

$$
T(n)=O(n)
$$

### Time Complexity

**Best Case:**

Element found at the first position.

$$
O(1)
$$

**Average Case:**

Element found somewhere in the middle.

$$
O(n)
$$

**Worst Case:**

Element found at the last position or not found.

$$
O(n)
$$

### Space Complexity

Only variables `i`, `flag`, and `data` are used.

$$
O(1)
$$

---

### Short ADA Exam Format

$$
T(n)=n
$$

$$
=O(n)
$$

**Best Case = O(1)**

**Average Case = O(n)**

**Worst Case = O(n)**

**Time Complexity = O(n)**

**Space Complexity = O(1)**
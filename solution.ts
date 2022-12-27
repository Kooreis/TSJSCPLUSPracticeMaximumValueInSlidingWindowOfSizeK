Here is a TypeScript solution for the problem:

```typescript
class SlidingWindowMax {
    private deque: number[] = [];

    push(val: number): void {
        while (this.deque.length && this.deque[this.deque.length - 1] < val) {
            this.deque.pop();
        }
        this.deque.push(val);
    }

    max(): number {
        return this.deque[0];
    }

    pop(val: number): void {
        if (this.deque[0] === val) {
            this.deque.shift();
        }
    }
}

function maxSlidingWindow(nums: number[], k: number): number[] {
    const window = new SlidingWindowMax();
    const result: number[] = [];

    for (let i = 0; i < nums.length; i++) {
        window.push(nums[i]);
        if (i >= k - 1) {
            result.push(window.max());
            window.pop(nums[i - k + 1]);
        }
    }

    return result;
}

const nums = [1,3,-1,-3,5,3,6,7];
const k = 3;
console.log(maxSlidingWindow(nums, k));
```

This program uses a double-ended queue (deque) to keep track of the maximum value in the current sliding window. When a new number is added to the window, it removes all numbers from the end of the deque that are less than the new number, and then adds the new number to the end of the deque. This ensures that the maximum value in the window is always at the front of the deque.

When a number is removed from the window, it checks if that number is at the front of the deque, and if so, removes it. This ensures that the maximum value in the deque is always the maximum value in the current window.

The `maxSlidingWindow` function iterates over the input array, adding each number to the window and removing the number that is no longer in the window. After each addition, it adds the current maximum value to the result array. After the loop, it returns the result array.
Here is a JavaScript solution using a Deque data structure:

```javascript
class Deque {
    constructor() {
        this.items = [];
    }

    addFront(element) {
        this.items.unshift(element);
    }

    addRear(element) {
        this.items.push(element);
    }

    removeFront() {
        if(this.isEmpty())
            return "Underflow";
        return this.items.shift();
    }

    removeRear() {
        if(this.isEmpty())
            return "Underflow";
        return this.items.pop();
    }

    front() {
        if(this.isEmpty())
            return "No elements in Deque";
        return this.items[0];
    }

    rear() {
        if(this.isEmpty())
            return "No elements in Deque";
        return this.items[this.items.length - 1];
    }

    isEmpty() {
        return this.items.length == 0;
    }

    size() {
        return this.items.length;
    }
}

function maxSlidingWindow(nums, k) {
    let n = nums.length;
    if (n == 0) return [];
    if (k > n) return [];

    let res = [];
    let dq = new Deque();

    for (let i = 0; i < k; i++) {
        while (!dq.isEmpty() && nums[i] >= nums[dq.rear()]) {
            dq.removeRear();
        }
        dq.addRear(i);
    }

    for (let i = k; i < n; i++) {
        res.push(nums[dq.front()]);

        while (!dq.isEmpty() && dq.front() <= i - k) {
            dq.removeFront();
        }

        while (!dq.isEmpty() && nums[i] >= nums[dq.rear()]) {
            dq.removeRear();
        }

        dq.addRear(i);
    }

    res.push(nums[dq.front()]);
    return res;
}

console.log(maxSlidingWindow([1,3,-1,-3,5,3,6,7], 3));
```

This script creates a Deque class and a function `maxSlidingWindow` that finds the maximum value in each sliding window of size `k` in the array `nums`. The result is printed to the console.
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
}
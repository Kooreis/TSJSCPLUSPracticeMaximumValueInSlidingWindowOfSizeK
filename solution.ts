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
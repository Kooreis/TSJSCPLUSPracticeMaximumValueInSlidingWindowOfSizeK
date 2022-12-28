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
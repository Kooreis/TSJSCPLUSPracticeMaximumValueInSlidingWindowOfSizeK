```cpp
#include <iostream>
#include <deque>
#include <vector>

void printMax(std::vector<int> arr, int n, int k)
{
    std::deque<int> Qi(k);

    int i;
    for (i = 0; i < k; ++i)
    {
        while ((!Qi.empty()) && arr[i] >= arr[Qi.back()])
            Qi.pop_back();

        Qi.push_back(i);
    }

    for (; i < n; ++i)
    {
        std::cout << arr[Qi.front()] << " ";

        while ((!Qi.empty()) && Qi.front() <= i - k)
            Qi.pop_front();

        while ((!Qi.empty()) && arr[i] >= arr[Qi.back()])
            Qi.pop_back();

        Qi.push_back(i);
    }

    std::cout << arr[Qi.front()] << std::endl;
}

int main()
{
    std::vector<int> arr = {12, 1, 78, 90, 57, 89, 56};
    int k = 3;
    printMax(arr, arr.size(), k);
    return 0;
}
```
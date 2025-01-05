#include <iostream>
#include <vector>
using namespace std;

int binarySearch(const vector<int>& arr, int x) {
    int l = 0, r = arr.size() - 1;
    while (l <= r) {
        int m = l + (r - l) / 2;
        if (arr[m] == x)
            return m;
        if (arr[m] < x)
            l = m + 1;
        else
            r = m - 1;
    }
    return -1;
}
int main() {
    cout<<"Nama :Muhamad Zakiatul Akbar"<<endl;
	cout<<"NIM :241011400870"<<endl;
    vector<int> arr = {1, 3, 5, 7, 9, 11};
    int x = 7;
    int result = binarySearch(arr, x);
    if (result != -1)
        cout << "Element found at index " << result << endl;
    else
        cout << "Element not found in array" << endl;
    return 0;
}

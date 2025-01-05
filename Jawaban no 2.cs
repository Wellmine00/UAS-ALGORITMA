#include <iostream>
#include <vector>
#include <string>
using namespace std;

struct Order {
    int id;
    string pickup_location;
    string dropoff_location;
    int order_time;
};

void merge(vector<Order>& orders, int l, int m, int r) {
    int n1 = m - l + 1;
    int n2 = r - m;
    vector<Order> L(n1);
    vector<Order> R(n2);
    for (int i = 0; i < n1; i++)
        L[i] = orders[l + i];
    for (int j = 0; j < n2; j++)
        R[j] = orders[m + 1 + j];
    int i = 0, j = 0, k = l;
    while (i < n1 && j < n2) {
        if (L[i].order_time <= R[j].order_time) {
            orders[k] = L[i];
            i++;
        } else {
            orders[k] = R[j];
            j++;
        }
        k++;
    }
    while (i < n1) {
        orders[k] = L[i];
        i++;
        k++;
    }
    while (j < n2) {
        orders[k] = R[j];
        j++;
        k++;
    }
}

void mergeSort(vector<Order>& orders, int l, int r) {
    if (l >= r)
        return;
    int m = l + (r - l) / 2;
    mergeSort(orders, l, m);
    mergeSort(orders, m + 1, r);
    merge(orders, l, m, r);
}
int main() {
    cout<<"Nama:Muhamad Zakiatul Akabr"<<endl;
	cout<<"NIM :241011400870"<<endl;
    vector<Order> orders = {
        {1, "Location A", "Location B", 5},
        {2, "Location C", "Location D", 2},
        {3, "Location E", "Location F", 8},
        {4, "Location G", "Location H", 3}
    };
    mergeSort(orders, 0, orders.size() - 1);
    for (const auto& order : orders) {
        cout << "ID: " << order.id << ", Pickup: " << order.pickup_location
             << ", Dropoff: " << order.dropoff_location << ", Time: " << order.order_time << endl;
    }
    return 0;
}

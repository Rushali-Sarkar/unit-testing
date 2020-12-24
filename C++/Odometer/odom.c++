#include "odometer.h"
#include <iostream>
#include <vector>

using namespace std;

void show(vector<int> arr) {
    for (auto element: arr) 
        cout << element << endl;
    return;
}

int main(int argc, char* argv[]) {

    Odometer odometer8(4);
    int x = odometer8.getPosition(4567);
    cout << x << endl;

    return 0;
}

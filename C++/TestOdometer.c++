#include <iostream>
#include <cassert>
#include <vector>
#include "odometer.h"


using namespace std;


class TestOdometer {

    private:

        vector<Odometer> odometers;

    public:

        TestOdometer() {

            for (int size = 3; size <= 8; size++) {
                Odometer odometer(size);
                odometers.push_back(odometer);
            }
        }

       int test_getStart() {

          vector<int> start{123, 1234, 12345, 123456, 1234567, 12345678};

          for (int i = 0; i < 6; i++) 
              assert(odometers[i].getStart() == start[i]);

          return 1;
       }

       int test_getEnd() {

           vector<int> end{789, 6789, 56789, 456789, 3456789, 23456789};

           for (int i = 0; i < 6; i++)
               assert(odometers[i].getEnd() == end[i]);

           return 1;
       }

       int test_numberOfReadings() {

           vector<int> numberOfReadings{84, 126, 126, 84, 36, 9};

           for (int i = 0; i < 6; i++)
               assert(odometers[i].getNoOfReadings() == numberOfReadings[i]);

           return 1;
       }

};

int main(int argc, char* argv[]) {

    TestOdometer test;
    int isPassedStart = test.test_getStart();
    int isPassedEnd = test.test_getEnd();
    int isPassedReadings = test.test_numberOfReadings();
    
    cout << isPassedStart << endl;
    cout << isPassedEnd << endl;
    cout << isPassedReadings << endl;
  
    return 0;
}

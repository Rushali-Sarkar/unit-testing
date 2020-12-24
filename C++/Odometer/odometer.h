#include<iostream>
#include<vector>
#include<string>

using namespace std;

class Odometer {

    private:

        const string reference_digits = "0123456789";

        int start;
        int end;
        int size;
        int current_position;
        int noOfReadings;
        vector<int> readings;

    public:
        
        bool isAscending(int value){

            if (value > 0 && value < 10)
                return true;

            if ((value % 10) <= ((value / 10) % 10))
                return false;

            return isAscending(value / 10);
        }

        int getValidSize(int size) {

            if (size < 3 || size > 8) {
                cout << "Sorry invalid size entered, creating Odomter of default size" << endl;
                return 3;
            }

            return size;
        }

        int getStart() {
            return stoi(reference_digits.substr(1, size));
        }

        int getEnd() {
            return stoi(reference_digits.substr(10 - size, 9));
        }

        vector<int> getReadings(int start, int end) {
            
            vector<int> readings {start};
            for (int current_reading = start + 1; current_reading < end; current_reading++) {
               if  (isAscending(current_reading))
                   readings.push_back(current_reading);
            }
            readings.push_back(end);

            return readings;
        }

        void showAllReadings() {
            int i = 0;
            for (auto current_reading: readings) {
                if (i % 10 == 0)
                    cout << endl;
                cout << current_reading << ", ";
                i++;
            }

            cout << endl;
            return;
       }

        int getPosition(int reading) {

            for (int i = 0; i < noOfReadings; i++) {
                if (readings[i] == reading)
                    return i;
            }

            return -1;
       }

        Odometer(int value){
            size = getValidSize(value);
            start = getStart();
            end = getEnd();
            readings = getReadings(start, end);
            current_position = 0;
            noOfReadings = readings.size();
        }

        int getNext(int reading = -1, int step = 1) {
            
            step = step % noOfReadings;
            int position = reading == -1 ? current_position : getPosition(reading);

            if (position == -1)
                return -1;

            current_position = position + step;


            if (current_position >= noOfReadings)
                current_position = current_position % noOfReadings;

            return readings[current_position];
        }

        int getPrevious(int reading = -1, int step = 1) {

            step = step % noOfReadings;

            int position = reading == -1 ? current_position : getPosition(reading);

            if (position == -1)
                return -1;
            current_position = position - step;

            if (current_position < 0)
                current_position = noOfReadings + current_position;

            return readings[current_position];
        }

        int getCurrent() {
            return readings[current_position];
        }

        int getNoOfReadings() {
            return noOfReadings;
        }

        vector<int> getAllReadings() {
            return readings;
        }

        void debug() {

            cout << "Start           : " << start << endl;
            cout << "End             : " << end << endl;
            cout << "Current Reading : " << readings[current_position] << endl;
            cout << "Current Position: " << current_position << endl;
            cout << "Total Readings  : " << noOfReadings << endl;
            cout << "Size            : " << size << endl;
            cout << "All Readings    : " << endl;
            showAllReadings();
        }
        
};

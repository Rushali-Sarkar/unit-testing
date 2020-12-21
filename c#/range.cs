using System;
using System.Collections.Generic;

class Range {

    private int start;
    private int end;
    
    public Range(int limit, int begin = 1) {

       if (begin != 1) {
           start = limit;
           end = begin;
       }

       else {
           start = 1;
           end = limit;
       }
    }

    public bool Contains(int item) {
        return (item >= start) && (item < end);
    }

    public bool Overlaps(Range n) {
        return (n.start >= start) && (n.start < end);
    }

    public bool LessThan(Range n) {
        return start < n.start;
    }

    public bool GreaterThan(Range n) {
        return start > n.start;
    }

    public bool Equals(Range n) {
        return (n.start == start) && (n.end == end);
    }

    public bool IsDisjoint(Range n) {

        bool isStartBetween = (n.start >= start) && (n.start < end);
        bool isEndBetween  = (n.end > start) && (n.end <= end);

        return (!isStartBetween) && (!isEndBetween);
    }

    public bool IsSubset(Range n) {
        return (n.start >= start) && (n.end <= end);
    }

    public bool IsSuperset(Range n) {
        return (start >= n.start) && (end <= n.end);
    }

    public bool Touching(Range n) {
        return end == n.start;
    }

    public int Combine(Range n) {
        
        if (!Overlaps(n) && !Touching(Range n))
            return -1;

        start = (start < n.start) ? start: n.start;
        end = (end > n.end) ? end : n.end;
        return 0;
    }
        

    public List<int> Elements() {

        var elements = new List<int>();
        for (var each = start; each < end; each++)
            elements.Add(each);

        return elements;
    }
}


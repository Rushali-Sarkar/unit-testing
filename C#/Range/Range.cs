using System;
using System.Collections.Generic;

namespace Range
{
    public class Range
    {

        private int start;
        private int end;

        public Range(int limit, int begin = 1)
        {

            start = begin;
            end = limit;
        }

        public bool Contains(int item)
        {
            return (item >= start) && (item < end);
        }

        public bool Overlaps(Range n)
        {
            return ((n.start >= start) && (n.start < end)) || ((n.end > start) && (n.end <= end));
        }

        public bool LessThan(Range n)
        {
            return start < n.start;
        }

        public bool GreaterThan(Range n)
        {
            return start > n.start;
        }

        public bool Equals(Range n)
        {
            return (n.start == start) && (n.end == end);
        }

        public bool IsDisjoint(Range n)
        {

            bool isStartBetween = (n.start >= start) && (n.start < end);
            bool isEndBetween = (n.end > start) && (n.end <= end);

            return (!isStartBetween) && (!isEndBetween);
        }

        public bool IsSubset(Range n)
        {
            return (start >= n.start) && (end <= n.end);
        }

        public bool IsSuperset(Range n)
        {
            return (n.start >= start) && (n.end <= end);
        }

        public bool Touching(Range n)
        {
            return (end == n.start) || (start == n.end);
        }

        public int Combine(Range n)
        {

            if (!Overlaps(n) && !Touching(n) && !IsSubset(n) && !IsSuperset(n))
                return -1;

            start = (start < n.start) ? start : n.start;
            end = (end > n.end) ? end : n.end;
            return 0;
        }

    }
}


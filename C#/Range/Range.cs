﻿using System;
using System.Collections.Generic;

namespace Range
{
    public class Range
    {

        private int start;
        private int end;

        public Range(int limit)
        {

            start = 0;
            end = limit;
        }

        public Range(int begin, int limit)
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
            return ((n.start >= start) && (n.start < end)) || 
                    ((n.end > start) && (n.end <= end));
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

            if (IsDisjoint(n) && !Touching(n))
                return -1;

            start = (start < n.start) ? start : n.start;
            end = (end > n.end) ? end : n.end;
            return 0;
        }
        public List<int> Elements()
        {
            var ElementsInRange = new List<int>();
            for (var number = start; number < end; number++)
                ElementsInRange.Add(number);

            return ElementsInRange;
        }

    }
}


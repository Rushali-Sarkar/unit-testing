using System;
using System.Collections.Generic;
using Xunit;
using Range;

namespace Range.Test
{
    public class RangeTest
    {
        [Fact]
        public void TestContains()
        {
            var range1 = new Range(1, 11);
             
            Assert.True(range1.Contains(2));
            Assert.True(range1.Contains(3));
            Assert.True(range1.Contains(5));
            Assert.False(range1.Contains(14));
            Assert.False(range1.Contains(15));
            Assert.False(range1.Contains(11));

            return;

        }

        [Fact]
        public void TestOverlaps()
        {
            var range1 = new Range(5, 15);
            var range2 = new Range(10, 25);
            var range3 = new Range(15, 25);
            var range4 = new Range(20, 30);

            Assert.True(range1.Overlaps(range2));
            Assert.True(range2.Overlaps(range3));
            Assert.True(range3.Overlaps(range4));
            Assert.False(range4.Overlaps(range1));
            Assert.False(range3.Overlaps(range1));
            Assert.False(range1.Overlaps(range3));

            return;
        }

        [Fact]
        public void TestLessThan()
        {
            var range1 = new Range(1, 10);
            var range2 = new Range(10, 20);
            var range3 = new Range(20, 30);
            var range4 = new Range(30, 40);
            var range5 = new Range(40, 50);
            var range6 = new Range(50, 60);

            Assert.True(range1.LessThan(range2));
            Assert.True(range2.LessThan(range3));
            Assert.True(range3.LessThan(range4));
            Assert.False(range4.LessThan(range3));
            Assert.False(range5.LessThan(range4));
            Assert.False(range6.LessThan(range5));

            return;
        }

        [Fact]
        public void TestGreaterThan()
        {
            var range1 = new Range(5, 15);
            var range2 = new Range(15, 25);
            var range3 = new Range(25, 35);
            var range4 = new Range(35, 45);
            var range5 = new Range(45, 55);
            var range6 = new Range(55, 65);

            Assert.True(range6.GreaterThan(range5));
            Assert.True(range5.GreaterThan(range4));
            Assert.True(range4.GreaterThan(range3));
            Assert.False(range3.GreaterThan(range4));
            Assert.False(range2.GreaterThan(range3));
            Assert.False(range1.GreaterThan(range2));

            return;
        }

        [Fact]
        public void TestEquals()
        {
            var range1 = new Range(1, 10);
            var range2 = new Range(1, 10);
            var range3 = new Range(20, 30);
            var range4 = new Range(20, 30);
            var range5 = new Range(50, 60);
            var range6 = new Range(50, 60);

            Assert.True(range1.Equals(range2));
            Assert.True(range3.Equals(range4));
            Assert.True(range5.Equals(range6));
            Assert.False(range1.Equals(range3));
            Assert.False(range4.Equals(range6));
            Assert.False(range3.Equals(range5));

            return;
        }

        [Fact]
        public void TestIsDisjoint()
        {
            var range1 = new Range(5, 15);
            var range2 = new Range(10, 20);
            var range3 = new Range(15, 25);
            var range4 = new Range(20, 30);
            var range5 = new Range(25, 35);
            var range6 = new Range(30, 40);

            Assert.True(range1.IsDisjoint(range3));
            Assert.True(range2.IsDisjoint(range4));
            Assert.True(range3.IsDisjoint(range5));
            Assert.False(range3.IsDisjoint(range4));
            Assert.False(range4.IsDisjoint(range5));
            Assert.False(range5.IsDisjoint(range6));

            return;
        }

        [Fact]
        public void TestIsSubset()
        {
            var range1 = new Range(1, 20);
            var range2 = new Range(5, 15);
            var range3 = new Range(30, 50);
            var range4 = new Range(35, 45);
            var range5 = new Range(60, 80);
            var range6 = new Range(65, 75);

            Assert.True(range2.IsSubset(range1));
            Assert.True(range4.IsSubset(range3));
            Assert.True(range6.IsSubset(range5));
            Assert.False(range1.IsSubset(range3));
            Assert.False(range3.IsSubset(range5));
            Assert.False(range4.IsSubset(range6));

            return;

        }

        [Fact]
        public void TestIsSuperSet()
        {
            var range1 = new Range(1, 20);
            var range2 = new Range(5, 15);
            var range3 = new Range(30, 50);
            var range4 = new Range(35, 45);
            var range5 = new Range(60, 80);
            var range6 = new Range(65, 75);

            Assert.True(range1.IsSuperset(range2));
            Assert.True(range3.IsSuperset(range4));
            Assert.True(range5.IsSuperset(range6));
            Assert.False(range1.IsSuperset(range3));
            Assert.False(range3.IsSuperset(range5));
            Assert.False(range4.IsSuperset(range6));

            return;

        }


        [Fact]
        public void TestToucing()
        {
            var range1 = new Range(1, 10);
            var range2 = new Range(10, 20);
            var range3 = new Range(20, 30);
            var range4 = new Range(30, 40);
            var range5 = new Range(40, 50);
            var range6 = new Range(50, 60);

            Assert.True(range1.Touching(range2));
            Assert.True(range3.Touching(range4));
            Assert.True(range5.Touching(range6));
            Assert.False(range1.Touching(range3));
            Assert.False(range3.Touching(range5));
            Assert.False(range4.Touching(range6));

            return;

        }

        [Fact]
        public void TestCombine()
        {
            var range1 = new Range(1, 20);
            var range2 = new Range(5, 15);
            var range3 = new Range(15, 25);
            var range4 = new Range(20, 30);
            var range5 = new Range(40, 50);
            var range6 = new Range(35, 45);

            Assert.Equal(0, range1.Combine(range2));
            Assert.Equal(0, range2.Combine(range3));
            Assert.Equal(-1, range3.Combine(range5));
            Assert.Equal(-1, range4.Combine(range6));

            return;
        }

        [Theory]
        [InlineData(20, 30)]
        public void TestElements(int start, int end)
        {
            var ElementsInRange = new List<int>();
            for (var number = start; number < end; number++)
                ElementsInRange.Add(number);

            var range = new Range(start, end);
            Assert.Equal(ElementsInRange, range.Elements());


            var ElementsInRange1 = new List<int>() {0, 1, 2, 3, 4, 5};
            var ElementsInRange2 = new List<int>() { 20, 21, 22, 23, 24, 25, 26 };

            var range1 = new Range(6);
            var range2 = new Range(20, 27);

            Assert.Equal(ElementsInRange1, range1.Elements());
            Assert.Equal(ElementsInRange2, range2.Elements());

            return;
        }


    }
}

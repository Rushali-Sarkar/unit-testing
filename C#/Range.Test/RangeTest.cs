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
            var range1 = new Range(11, 1);
            var DoesContain1 = range1.Contains(2);
            var DoesContain2 = range1.Contains(3);
            var DoesContain3 = range1.Contains(5);
            var DoesContain4 = range1.Contains(14);
            var DoesContain5 = range1.Contains(15);
            var DoesContain6 = range1.Contains(11);

            Assert.True(DoesContain1);
            Assert.True(DoesContain2);
            Assert.True(DoesContain3);
            Assert.False(DoesContain4);
            Assert.False(DoesContain5);
            Assert.False(DoesContain6);

            return;

        }

        [Fact]
        public void TestOverlaps()
        {
            var range1 = new Range(15, 5);
            var range2 = new Range(25, 10);
            var range3 = new Range(25, 15);
            var range4 = new Range(30, 20);

            var DoesOverlap1 = range1.Overlaps(range2);
            var DoesOverlap2 = range2.Overlaps(range3);
            var DoesOverlap3 = range3.Overlaps(range4);
            var DoesOverlap4 = range4.Overlaps(range1);
            var DoesOverlap5 = range3.Overlaps(range1);
            var DoesOverlap6 = range1.Overlaps(range3);

            Assert.True(DoesOverlap1);
            Assert.True(DoesOverlap2);
            Assert.True(DoesOverlap3);
            Assert.False(DoesOverlap4);
            Assert.False(DoesOverlap5);
            Assert.False(DoesOverlap6);

            return;
        }

        [Fact]
        public void TestLessThan()
        {
            var range1 = new Range(10, 1);
            var range2 = new Range(20, 10);
            var range3 = new Range(30, 20);
            var range4 = new Range(40, 30);
            var range5 = new Range(50, 40);
            var range6 = new Range(60, 50);

            var IsLessThan1 = range1.LessThan(range2);
            var IsLessThan2 = range2.LessThan(range3);
            var IsLessThan3 = range3.LessThan(range4);
            var IsLessThan4 = range4.LessThan(range3);
            var IsLessThan5 = range5.LessThan(range4);
            var IsLessThan6 = range6.LessThan(range5);

            Assert.True(IsLessThan1);
            Assert.True(IsLessThan2);
            Assert.True(IsLessThan3);
            Assert.False(IsLessThan4);
            Assert.False(IsLessThan5);
            Assert.False(IsLessThan6);

            return;
        }

        [Fact]
        public void TestGreaterThan()
        {
            var range1 = new Range(15, 5);
            var range2 = new Range(25, 15);
            var range3 = new Range(35, 25);
            var range4 = new Range(45, 35);
            var range5 = new Range(55, 45);
            var range6 = new Range(65, 55);

            var IsGreaterThan1 = range6.GreaterThan(range5);
            var IsGreaterThan2 = range5.GreaterThan(range4);
            var IsGreaterThan3 = range4.GreaterThan(range3);
            var IsGreaterThan4 = range3.GreaterThan(range4);
            var IsGreaterThan5 = range2.GreaterThan(range3);
            var IsGreaterThan6 = range1.GreaterThan(range2);

            Assert.True(IsGreaterThan1);
            Assert.True(IsGreaterThan2);
            Assert.True(IsGreaterThan3);
            Assert.False(IsGreaterThan4);
            Assert.False(IsGreaterThan5);
            Assert.False(IsGreaterThan6);

            return;
        }

        [Fact]
        public void TestEquals()
        {
            var range1 = new Range(10, 1);
            var range2 = new Range(10, 1);
            var range3 = new Range(30, 20);
            var range4 = new Range(30, 20);
            var range5 = new Range(60, 50);
            var range6 = new Range(60, 50);

            var IsEqual1 = range1.Equals(range2);
            var IsEqual2 = range3.Equals(range4);
            var IsEqual3 = range5.Equals(range6);
            var IsEqual4 = range1.Equals(range3);
            var IsEqual5 = range4.Equals(range6);
            var IsEqual6 = range3.Equals(range5);

            Assert.True(IsEqual1);
            Assert.True(IsEqual2);
            Assert.True(IsEqual3);
            Assert.False(IsEqual4);
            Assert.False(IsEqual5);
            Assert.False(IsEqual6);

            return;
        }

        [Fact]
        public void TestIsDisjoint()
        {
            var range1 = new Range(15, 5);
            var range2 = new Range(20, 10);
            var range3 = new Range(25, 15);
            var range4 = new Range(30, 20);
            var range5 = new Range(35, 25);
            var range6 = new Range(40, 30);

            var IsDisjoint1 = range1.IsDisjoint(range3);
            var IsDisjoint2 = range2.IsDisjoint(range4);
            var IsDisjoint3 = range3.IsDisjoint(range5);
            var IsDisjoint4 = range3.IsDisjoint(range4);
            var IsDisjoint5 = range4.IsDisjoint(range5);
            var IsDisjoint6 = range5.IsDisjoint(range6);

            Assert.True(IsDisjoint1);
            Assert.True(IsDisjoint2);
            Assert.True(IsDisjoint3);
            Assert.False(IsDisjoint4);
            Assert.False(IsDisjoint5);
            Assert.False(IsDisjoint6);

            return;
        }

        [Fact]
        public void TestIsSubset()
        {
            var range1 = new Range(20, 1);
            var range2 = new Range(15, 5);
            var range3 = new Range(50, 30);
            var range4 = new Range(45, 35);
            var range5 = new Range(80, 60);
            var range6 = new Range(75, 65);

            var IsSubset1 = range2.IsSubset(range1);
            var IsSubset2 = range4.IsSubset(range3);
            var IsSubset3 = range6.IsSubset(range5);
            var IsSubset4 = range1.IsSubset(range3);
            var IsSubset5 = range3.IsSubset(range5);
            var IsSubset6 = range4.IsSubset(range6);

            Assert.True(IsSubset1);
            Assert.True(IsSubset2);
            Assert.True(IsSubset3);
            Assert.False(IsSubset4);
            Assert.False(IsSubset5);
            Assert.False(IsSubset6);

            return;

        }

        [Fact]
        public void TestIsSuperSet()
        {
            var range1 = new Range(20, 1);
            var range2 = new Range(15, 5);
            var range3 = new Range(50, 30);
            var range4 = new Range(45, 35);
            var range5 = new Range(80, 60);
            var range6 = new Range(75, 65);

            var IsSuperSet1 = range1.IsSuperset(range2);
            var IsSuperSet2 = range3.IsSuperset(range4);
            var IsSuperSet3 = range5.IsSuperset(range6);
            var IsSuperSet4 = range1.IsSuperset(range3);
            var IsSuperSet5 = range3.IsSuperset(range5);
            var IsSuperSet6 = range4.IsSuperset(range6);

            Assert.True(IsSuperSet1);
            Assert.True(IsSuperSet2);
            Assert.True(IsSuperSet3);
            Assert.False(IsSuperSet4);
            Assert.False(IsSuperSet5);
            Assert.False(IsSuperSet6);

            return;

        }


        [Fact]
        public void TestToucing()
        {
            var range1 = new Range(10, 1);
            var range2 = new Range(20, 10);
            var range3 = new Range(30, 20);
            var range4 = new Range(40, 30);
            var range5 = new Range(50, 40);
            var range6 = new Range(60, 50);

            var IsToucing1 = range1.Touching(range2);
            var IsToucing2 = range3.Touching(range4);
            var IsToucing3 = range5.Touching(range6);
            var IsToucing4 = range1.Touching(range3);
            var IsToucing5 = range3.Touching(range5);
            var IsToucing6 = range4.Touching(range6);

            Assert.True(IsToucing1);
            Assert.True(IsToucing2);
            Assert.True(IsToucing3);
            Assert.False(IsToucing4);
            Assert.False(IsToucing5);
            Assert.False(IsToucing6);

            return;

        }

        [Fact]
        public void TestCombine()
        {
            var range1 = new Range(20, 1);
            var range2 = new Range(15, 5);
            var range3 = new Range(25, 15);
            var range4 = new Range(30, 20);
            var range5 = new Range(50, 40);
            var range6 = new Range(45, 35);

            var canCombine1 = range1.Combine(range2);
            var canCombine2 = range2.Combine(range3);
            var canCombine3 = range3.Combine(range5);
            var canCombine4 = range4.Combine(range6);

            Assert.Equal(0, canCombine1);
            Assert.Equal(0, canCombine2);
            Assert.Equal(-1, canCombine3);
            Assert.Equal(-1, canCombine4);

            return;
        }

        [Theory]
        [InlineData(20, 30)]
        public void TestElements(int start, int end)
        {
            var ElementsInRange = new List<int>();
            for (var number = start; number < end; number++)
                ElementsInRange.Add(number);

            var range = new Range(end, start);
            Assert.Equal(ElementsInRange, range.Elements());
        }

    }
}

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using SDMExercises;
using Xunit;

namespace SDMTests
{
    public class UnitTest1
    {
        //Tests for grading
        
        [Theory]
        [InlineData(5,-3)]
        [InlineData(48,0)]
        [InlineData(58,2)]
        [InlineData(78,4)]
        [InlineData(83,7)]
        [InlineData(93,10)]
        [InlineData(99,12)]
        public void GradeLowBoundaryTest(int percentage, int expectedGrade)
        {
            Assert.Equal(expectedGrade, GradeConverter.ToGrade(percentage));
        }
        
        [Theory]
        [InlineData(5,-3)]
        [InlineData(49,0)]
        [InlineData(59,2)]
        [InlineData(79,4)]
        [InlineData(84,7)]
        [InlineData(94,10)]
        [InlineData(100,12)]
        public void GradeOnBoundaryTest(int percentage, int expectedGrade)
        {
            Assert.Equal(expectedGrade, GradeConverter.ToGrade(percentage));
        }
        
        [Theory]
        [InlineData(6,0)]
        [InlineData(50,2)]
        [InlineData(60,4)]
        [InlineData(80,7)]
        [InlineData(85,10)]
        [InlineData(95,12)]
        public void GradeOverBoundaryTest(int percentage, int expectedGrade)
        {
            Assert.Equal(expectedGrade, GradeConverter.ToGrade(percentage));
        }
        
        [Theory]
        [InlineData(-1)]
        [InlineData(101)]
        public void GradeInvalidArgumentTest(int percentage)
        {
            Assert.Throws<ArgumentException>(() => GradeConverter.ToGrade(percentage));
        }
        
        // Tests for teenager
        [Theory]
        [InlineData("2008-02-09")]
        [InlineData("2006-01-01")]
        [InlineData("2002-01-09")]
        public void IsTeenagerTest(string birthday)
        {
            DateTime parsed = DateTime.Parse(birthday);
            Assert.True(TeenageClass.IsTeenager(parsed), birthday);
        }

        [Theory]
        [InlineData("2008-09-24")]
        [InlineData("2000-08-08")]
        [InlineData("2002-09-24")]
        public void IsNotTeenagerTest(string birthday)
        {
            DateTime parsed = DateTime.Parse(birthday);
            Assert.False(TeenageClass.IsTeenager(parsed), birthday);
        }

        [Theory]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(14)]
        public void IntBoundaryTest(int age)
        {
            
        }
    }
}
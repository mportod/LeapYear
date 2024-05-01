using FluentAssertions;

namespace LeapYear.Tests
{
    public class LeapYearShould
    {
        private Leap leap = default!;

        [SetUp]
        public void Setup()
        {
            leap = new Leap();
        }

        [TestCase(1995)]
        [TestCase(2001)]
        [TestCase(2025)]
        public void should_return_is_not_leap_year_when_year_is_not_divisible_by_4(int year)
        {
            var result = leap.IsLeapYear(year);

            result.Should().BeFalse();
        }

        [TestCase(1996)]
        [TestCase(2024)]
        [TestCase(2028)]
        public void should_return_is_leap_year_when_year_is_divisible_by_4_and_is_not_divisible_by_100(int year)
        {
            var result = leap.IsLeapYear(year);

            result.Should().BeTrue();
        }

        [TestCase(1900)]
        [TestCase(2100)]
        [TestCase(2200)]
        public void should_return_is_not_leap_year_when_year_is_divisible_by_4_and_100(int year)
        {
            var result = leap.IsLeapYear(year);

            result.Should().BeFalse();
        }

        [TestCase(2000)]
        [TestCase(2400)]
        [TestCase(2800)]
        public void should_return_is_leap_year_when_year_is_divisible_by_400(int year)
        {
            var result = leap.IsLeapYear(year);

            result.Should().BeTrue();
        }

        [TestCase(1900)]
        [TestCase(2100)]
        [TestCase(2200)]
        public void should_return_is_not_leap_year_when_year_is_divisible_by_100_but_no_divisible_by_400(int year)
        {
            var result = leap.IsLeapYear(year);

            result.Should().BeFalse();
        }

        [Test]
        public void should_return_leap_years_between_1900_and_2000()
        {
            var result = leap.Leaps(1900, 2000);

            result.Should().BeEquivalentTo(new[] {1904, 1908, 1912, 1916, 1920, 1924, 1928, 1932, 1936, 1940, 1944, 1948, 1952, 1956, 1960, 1964, 1968, 1972, 1976, 1980, 1984, 1988, 1992, 1996, 2000});
        }
    }
}
using Xunit;

namespace AlgorithmsTests.Array.ContainsDuplicate_I
{
    public class ContainsDuplicate_I_Tests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] {1, 1, 1, 3, 3, 4, 3, 2, 4, 2}, true)]
        public void Test(int[] nums, bool expected)
        {
            // Arrange

            // Act
            bool result = Algorithms.Array_ContainsDuplicate.ContainsDuplicate_I.ContainsDuplicate(nums);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}

namespace Tests;

    public class FindMinimumInRotatedSortedArrayTest
    {
        [Fact]
        public void FindMinimumInRotatedSortedArray_ShouldReturnTheMinimumElementOfTheArray(){

            //Arrange
            var FindMinimumInRotatedSortedArray = new FindMinimumInRotatedSortedArray();
             int[] numbers = { 4, 5, 6, 7, 8, 9, 0, 1, 2 };

             //Act
             var result = FindMinimumInRotatedSortedArray.FindMinimum(numbers);

             //Assert
             Assert.Equal(0, result);
        }
    }

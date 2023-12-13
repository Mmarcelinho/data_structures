namespace Tests;

    public class BinarySearchTest
    {
        [Fact]
        public void BinarySearch_ShouldReturnIndexOfTheTargetElementOfTheArray(){

            //Arrange
            var BinarySearch = new BinarySearch();
            int[] nums = {-1,0,3,5,9,12}; 
            int target = 9;

            //Act
            var result = BinarySearch.Search(nums, target);

            //Assert
            Assert.Equal(4, result);
        }
        [Fact]
         public void BinarySearch_shouldReturnNegativeValueIfTargetIsNotInArray(){

            //Arrange
            var BinarySearch = new BinarySearch();
            int[] nums = {-1,0,3,5,9,12}; 
            int target = 14;

            //Act
            var result = BinarySearch.Search(nums, target);

            //Assert
            Assert.Equal(-1, result);
        }
    }

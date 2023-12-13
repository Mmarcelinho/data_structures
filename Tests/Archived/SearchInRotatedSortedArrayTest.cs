namespace Tests;

    public class SearchInRotatedSortedArrayTest
    {
        [Fact]
        public void SearchInRotatedSortedArray_ShouldReturnIndexOfTheTargetElementOfTheArray(){

            //Arrange
            var SearchInRotatedSortedArray = new SearchInRotatedSortedArray();
            int[] nums = {8,9,10,11,12,13,14,15,0,1,2,3,4,5,6,7}; 
            int target = 0;

            //Act
            var result = SearchInRotatedSortedArray.Search(nums, target);

            //Assert
            Assert.Equal(8, result);
        }
        [Fact]
         public void SearchInRotatedSortedArray_shouldReturnNegativeValueIfTargetIsNotInArray(){

            //Arrange
            var SearchInRotatedSortedArray = new SearchInRotatedSortedArray();
            int[] nums = {8,9,10,11,12,13,14,15,1,2,3,4,5,6,7}; 
            int target = 0;

            //Act
            var result = SearchInRotatedSortedArray.Search(nums, target);

            //Assert
            Assert.Equal(-1, result);
        }
    }

namespace Tests;

public class GroupAnagramsTest
{
  
    [Fact]
    public void GroupAnagrams_ShouldGroupCorrectly()
    {
        // Arrange
        var GroupAnagrams = new GroupAnagrams();
        string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };

        // Act
        IList<IList<string>> result = GroupAnagrams.GroupAnagramsInList(words);

        // Assert
        Assert.Equal(3, result.Count); 

        Assert.Contains(new List<string> { "eat", "tea", "ate" }, result); 
        Assert.Contains(new List<string> { "tan", "nat" }, result); 
        Assert.Contains(new List<string> { "bat" }, result); 
    }
}

using static Exercises.ReverseLinkedList;

namespace Tests
{
    public class ReverseLinkedListTest
    {
        [Fact]
        public void ReverseLinkedList_ShouldReturnAnInvertedlist()
        {
          // Arrange
        ListNode node5 = new ListNode(5);
        ListNode node4 = new ListNode(4, node5);
        ListNode node3 = new ListNode(3, node4);
        ListNode node2 = new ListNode(2, node3);
        ListNode node1 = new ListNode(1, node2);
        int[] expectedValues = { 5, 4, 3, 2, 1 };
        int currentIndex = 0;

        // Act
        var ReverseLinkedList = new ReverseLinkedList();
        ListNode result = ReverseLinkedList.ReverseList(node1);

        //Assert
        while (result != null)
        {
            Assert.Equal(expectedValues[currentIndex], result.Value);
            result = result.Next;
            currentIndex++;
        }
    }
    }
}
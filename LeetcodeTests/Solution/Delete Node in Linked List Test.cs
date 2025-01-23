using NUnit.Framework;

namespace LeetcodeTests
{
    public class Delete_Node_in_Linked_List_Test
    {

        [Theory]
        public void Test_Delete_Node_in_Linked_List()
        {
            Solution deleteLinkedList = new Solution();
            int[] items = new int[] { 4, 5, 1, 9 };
            ListNode head = items.FormListNode();
            deleteLinkedList.DeleteNode(head.next.next);

            int[] expected = new int[] { 4, 5, 9 };
            Assert.AreEqual(head.FormArray(), expected);
        }
    }
}

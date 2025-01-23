public partial class Solution
{
    public void DeleteNode(ListNode node)
    {
        while (node?.next != null)
        {
            node.val = node.next.val;

            if(node.next.next is null)
            {
                node.next = null;
            }
            node = node.next;
        }
        
    }
}
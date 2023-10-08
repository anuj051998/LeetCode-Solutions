public partial class Solution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        int index = 0;
        int length = 0;

        ListNode listNode = head;
        // find out the length of the node
        while(listNode != null)
        {
            length++;
            listNode= listNode.next;
        }
        if(length <= 1)
        {
            return head;
        }
        listNode = head;

        ListNode tempHeadNode = null;
        ListNode connectingNodeRef = null;
        while (listNode != null)
        {
            if (length - index - 1  <= k)
            {
                if (connectingNodeRef != null)
                {
                    ListNode tempNode = new ListNode(listNode.val);


                }
                connectingNodeRef ??= listNode;
            }
            listNode = listNode?.next;
            index++;
        }
        connectingNodeRef.next = null;
        return tempHeadNode;
    }
}

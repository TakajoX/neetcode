/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public bool HasCycle(ListNode head) {

        HashSet<ListNode> memory = new HashSet<ListNode>();
        
        while(head != null) {
            if(memory.Contains(head)) {
                
                return true;
            }
            memory.Add(head);
            head = head.next;
        }

        return false;
    }
}

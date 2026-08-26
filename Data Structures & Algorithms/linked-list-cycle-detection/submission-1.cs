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

        var lento = head;
        var veloce = head;
        
        while (veloce != null && veloce.next != null) {
            lento = lento.next;
            veloce = veloce.next.next;


            if(lento == veloce) {
                return true;
            }
        }

        return false;
    }
}

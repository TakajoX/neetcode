public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> uniqueNumber = new HashSet<int>();

        foreach(var item in nums) {
            if(uniqueNumber.Contains(item)) {
                return true;
            } else {
            uniqueNumber.Add(item) ;
            }
        }

        return false;
    }
}
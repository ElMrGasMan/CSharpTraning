namespace CSharpBasicTraning.EasyProblems
{
    internal class MergeLinkedLists
    {
        public static ListNode? MergeTwoLists(ListNode list1, ListNode list2) 
        {
            if (list1 == null) return list2; //If one of the lists is empty we return early the one that isn't
            else if (list2 == null) return list1;

            ListNode startNode = new(); 
            ListNode mergedList = startNode;

            while (list1 != null && list2 != null)
            {
                if (list1.Value < list2.Value)
                {
                    mergedList.Next = list1;
                    list1 = list1.Next;
                }
                else
                {
                    mergedList.Next = list2;
                    list2 = list2.Next;
                }
                mergedList = mergedList.Next;
            }

            mergedList.Next = list1 ?? list2; //Attach the remaining non-null list
            return startNode.Next; //We return the merged list
        }

        public static ListNode? MergeTwoListsRecursive(ListNode? list1, ListNode? list2) 
        {
            if (list1 == null) return list2; 
            else if (list2 == null) return list1;

            if (list1.Value < list2.Value)
            {
                MergeTwoListsRecursive(list1.Next, list2);
                return list1;
            }
            else
            {
                MergeTwoListsRecursive(list1, list2.Next);
                return list2;
            }
        }
    }

    public class ListNode 
    {
        public int Value { get; set; }
        public ListNode? Next { get; set; }

        public ListNode(int value = 0, ListNode? next = null)
        {
            Value = value;
            Next = next;
        }
    }
}

/*

Count nodes of linked list

Input:
	LinkedList: 1->2->3->4->5
Output: 
	5
Explanation: 
	Count of nodes in the linked list is 5, which is its length.


Input:
	LinkedList: 2->4->6->7->5->1->0
Output: 
	7
Explanation: 
	Count of nodes in the linked list is 7. 
	Hence, the output is 7.

*/

class Node
{
    int data;
    Node next;
    
    Node(int a){
        data = a;
        next = null;
    }
    
}

 // } Driver Code Ends
/*Complete the function below*/
/*
class Node{
    int data;
    Node next;
    Node(int a){  data = a; next = null; }
}*/

class Solution
{
    //Function to count nodes of a linked list.
    public static int getCount(Node head)
    {
        int count = 0;
        Node temp = head;
        
        while(temp != null)
        {
            count += 1;
            temp = temp.next;
        }
        
        return count;
    }
}
    

// { Driver Code Starts.
class LinkedList{
    
    public static void main(String[] args){
        Scanner sc=new Scanner(System.in);
        int t=sc.nextInt();
        while(t-->0)
        {
            int n=sc.nextInt();
            Node head = new Node(sc.nextInt());
            Node tail = head;
            for(int i=0; i<n-1; i++)
            {
                tail.next = new Node(sc.nextInt());
                tail = tail.next;
            }
            
            Solution ob = new Solution();
            System.out.println(ob.getCount(head));
        }
    }   
}
/*

Find n/k th node in Linked list

Input:
	2
	6
	1 2 3 4 5 6
	2
	5
	2 7 9 3 5
	3

Output:
	3
	7

Explanation:
	Testcase 1: 6/2th element is the 3rd(1-based indexing) element which is 3.

*/


class Node
{
    int data;
    Node next;
    
    Node(int key)
    {
        data = key;
        next = null;
    }
}

class LinkedList
{
    static Node head;
    
     public static void addToTheLast(Node node) 
	{
		if (head == null) 
		{
			head = node;
		} else 
		{
		   Node temp = head;
		   while (temp.next != null)
		   temp = temp.next;
		   temp.next = node;
		}
    }
    
     public static void main (String[] args) {
         Scanner sc = new Scanner(System.in);
		 int t=sc.nextInt();
		 
		 while(t-- > 0)
		 {
		     int n = sc.nextInt();
		     int a1 = sc.nextInt();
		     Node head = new Node(a1);
		     addToTheLast(head);
		     for(int i = 1; i < n; i++)
		     {
		         int a = sc.nextInt(); 
				 addToTheLast(new Node(a));
			 }
			 int k = sc.nextInt();
			GfG gfg = new GfG();
			System.out.println(gfg.nknode(head, k));
		     }
		 }
}// } Driver Code Ends


/*
class Node
{
    int data;
    Node next;
    
    Node(int key)
    {
        data = key;
        next = null;
    }
}
*/

class GfG
{
    public static int nknode(Node head, int k)
    {
       
       
       if(k <= 0 || head == null)
       {
           return 0;
       }
       
       Node answerNode = null;
       int n = 0;
       
       for(Node temp = head; temp != null; temp = temp.next)
       {
           if(n % k == 0)
           {
               if(answerNode == null)
               {
                   answerNode = head;
               }
               else
               {
                   answerNode = answerNode.next;
               }
           }
           
           n += 1;
       }
       
       return answerNode.data;
    }
}

/*

Delete Alternate Nodes

Input:
	LinkedList: 1->2->3->4->5->6
Output: 
	1->3->5
Explanation: 
	Deleting alternate nodes results in the linked list with elements 1->3->5.


Input:
	LinkedList: 99->59->42->20
Output: 
	99->42

*/

/*package whatever //do not write package name here */

import java.io.*;
import java.util.*;

class Node {
    int data;
    Node next;
    
    public Node(int data){
        this.data = data;
    }
}

class GFG {
    	

    
	public static void main (String[] args) {
		Scanner sc = new Scanner(System.in);
		int t = sc.nextInt();
		while(t-- > 0){
		    
		    Node head1 = null,tail1 = null;
		    
		    int n1 = sc.nextInt();
            int d1 = sc.nextInt();		    
		    head1 = new Node(d1);
		    tail1 = head1;
		    
		    while(n1-- > 1){
		        tail1.next = new Node(sc.nextInt());
		        tail1 = tail1.next;
		    }
		    
		    Solution obj = new Solution();
		    obj.deleteAlternate(head1);
		    while(head1 != null){
		        System.out.print(head1.data + " ");
		        head1 = head1.next;
		    }
		    System.out.println();
		}
	}

}

// } Driver Code Ends


/*
class Node {
    int data;
    Node next;
    
    public Node(int data){
        this.data = data;
    }
}
*/
class Solution {
    
    public void deleteAlternate (Node head){
        Node temp = head;
        
        while(temp.next != null)
        {
            if(temp.next.next != null)
            {
                temp.next = temp.next.next;
                temp = temp.next;
            }
            else
            {
                temp.next = null;
                break;
            }
        }
    }
}
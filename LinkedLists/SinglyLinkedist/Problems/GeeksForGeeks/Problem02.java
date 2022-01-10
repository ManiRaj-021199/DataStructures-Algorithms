/*

Find the Sum of Last N nodes of the Linked List

Input:
	2
	6 3
	5 9 6 3 4 10
	2 2
	1 2

Output:
	17
	3

*/

/*package whatever //do not write package name here */

import java.io.*;
import java.util.*;

class Node {
    int data;
    Node next;
    
    public Node (int data){
        this.data = data;
        this.next = null;
    }
}

class GFG {
	public static void main (String[] args) {
		Scanner sc  = new Scanner(System.in);
		int t = sc.nextInt();
		while(t-- > 0){
		    int n = sc.nextInt();
		    int k = sc.nextInt();
		    
		    Node head = new Node(sc.nextInt());
		    Node tail = head;
		    
		    for(int i=1; i<n; i++){
		        tail.next = new Node(sc.nextInt());
		        tail = tail.next;
		    }
		    
		    Solution obj = new Solution();
		    System.out.println(obj.sum(head, k));
		}
	}
}// } Driver Code Ends


/*
Node class is as follows:

class Node {
    int data;
    Node next;
    
    public Node (int data){
        this.data = data;
        this.next = null;
    }
}
*/

class Solution {
    
    //Return the sum of last k nodes
    public int sum(Node head, int k){
        Node temp = reverseLinkedList(head);
        int count = 1, ans = 0;
        
        while(k >= count)
        {
            if(temp != null)
            {
                ans += temp.data;
                count += 1;
                temp = temp.next;
            }
            else
            {
                break;
            }
        }
        
        return ans;
    }
    
    
    public Node reverseLinkedList(Node node)
    {
        Node temp = node;
        Node prev = null;
        
        while(temp != null)
        {
            node = node.next;
            temp.next = prev;
            prev = temp;
            temp = node;
        }
        
        return prev;
    }
}
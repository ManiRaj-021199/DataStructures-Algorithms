/*

	A number N is represented in Linked List such that each digit corresponds 
	to a node in linked list. You need to add 1 to it.

	Input:	LinkedList: 4->5->6
	Output: 457 

	Input:	LinkedList: 9->9->9
	Output: 1000

*/

import java.io.*;
import java.util.*;
class Node
{
    int data;
    Node next;
    
    Node(int x)
    {
        data = x;
        next = null;
    }
}
class GFG
{
    public static void printList(Node node) 
    { 
        while (node != null)
        { 
            System.out.print(node.data);
            node = node.next; 
        }  
        System.out.println();
    } 
    public static void main(String args[])throws IOException
        {
            Scanner sc = new Scanner(System.in);
            int t = sc.nextInt();
            while(t-->0)
                {
                    String s = sc.next();
                    Node head = new Node( s.charAt(0) - '0' );
                    Node tail = head;
                    for(int i=1; i<s.length(); i++)
                    {
                        tail.next = new Node( s.charAt(i) - '0' );
                        tail = tail.next;
                    }
                    Solution obj = new Solution();
                    head = obj.addOne(head);
                    printList(head); 
                }
        }
}// } Driver Code Ends


/*
class Node{
    int data;
    Node next;
    
    Node(int x){
        data = x;
        next = null;
    }
} 
*/

class Solution
{
    public static Node addOne(Node head) 
    {
        head = reverseLinkedList(head);
        Node temp = head;
        int carry = 0;
        
        while(temp != null)
        {
            if((temp.data + 1) == 10)
            {
                carry = 1;
                temp.data = 0;
                
                temp = temp.next;
            }
            else
            {
                temp.data += 1;
                carry = 0;
                break;
            }
        }
        
        head = reverseLinkedList(head);
        
        if(carry == 1)
        {
            Node newNode = new Node(carry);
            newNode.next = head;
            
            return newNode;
        }
        
        return head;
    }
    
    
    public static Node reverseLinkedList(Node head)
    {
        Node temp = head;
        Node prev = null;
        
        while(head != null)
        {
            head = head.next;
            temp.next = prev;
            prev = temp;
            temp = head;
        }
        
        return prev;
    }
}

/*

Insert in Middle of Linked List

Input:
	LinkedList = 1->2->4
	key = 3
Output:
	1 2 3 4

Input:
	LinkedList = 10->20->40->50
	key = 30
Output:
	10 20 30 40 50

*/

import java.util.*;
import java.io.*;

class Node {
    int data;
    Node next;
    
    public Node(int data){
        this.data = data;
        this.next = null;
    }
}

public class Main {
    public static void main(String[] args){
        Scanner sc = new Scanner (System.in);
        int t = sc.nextInt();
        
        while(t-->0){
            int n = sc.nextInt();   
            Node head = new Node(sc.nextInt());
            Node tail = head;
            
            for(int i=0; i<n-1; i++){
                tail.next = new Node(sc.nextInt());
                tail = tail.next;
            }
            int key = sc.nextInt();
            
            //display(head);
            Solution obj = new Solution();
            obj.insertInMid(head, key);
            display(head);
            System.out.println();
        }
    }
    
    public static void display(Node head){
        Node curr = head;
        while(curr != null){
            System.out.print(curr.data+" ");
            curr = curr.next;
        }
    }
}
// } Driver Code Ends


/*
Structure of node class is:
class Node {
    int data;
    Node next;
    
    public Node(int data){
        this.data = data;
        this.next = null;
    }
}
*/
class Solution {
    
    public Node insertInMid(Node head, int data){
        int pos = 0;
        Node temp = head;
        
        while(temp != null)
        {
            pos += 1;
            temp = temp.next;
        }
        
        if(pos % 2 == 0)
        {
            pos /= 2;
        }
        else
        {
            pos = (pos / 2) + 1;
        }
        
        
        temp = head;
        int count = 1;
        
        while(temp != null)
        {
            if(count == pos)
            {
                Node newNode = new Node(data);
                newNode.next = temp.next;
                temp.next = newNode;
                break;
            }
            
            count += 1;
            temp = temp.next;
        }
        
        return head;
    }
}
import java.util.*;
import java.lang.*;
import java.io.*;


class SinglyLinkedList
{
	Node head;      // Root Node

    // Node class
	static class Node
	{
		int data;
		Node next;

		public Node(int val)
		{
			data = val;
			next = null;
		}
	}

	public static void main(String[] args) 
	{
		SinglyLinkedList sll = new SinglyLinkedList();

		sll.head = new Node(1);
		Node second = new Node(2);
		Node third = new Node(3);
		
		sll.head.next = second;
		second.next = third;
        
        sll.reverseLinkedList();
        
        sll.printLinkedList();
	}


    // Method used to insert a value at head of the linked list
	private void insertAtHead(int val)
	{
	    System.out.println("Insert " + val + " at Head.");
	    
        Node newNode = new Node(val);
        newNode.next = head;
        head = newNode;
	}


    // Method used to insert a value at end of the linked list
	private void insertAtEnd(int val)
	{
	    System.out.println("Insert " + val + " at Tail.");
	    
	    Node temp = head;
        Node newNode = new Node(val);
        
	    if(isEmpty())
	    {
	        head = newNode;
	        return;
	    }
        
        while(temp.next != null)
        {
            temp = temp.next;
        }
        
        temp.next = newNode;
	}


    // Method used to insert a value after a given node value
    private void insertAfterGivenNodeValue(int givenValue, int val)
    {
        if(!isThere(givenValue))
        {
            System.out.println("Value " + givenValue + " not in the list");
            return;
        }
        
        Node temp = head;
        Node newNode = new Node(val);
        
        while(temp != null)
        {
            if(temp.data == givenValue)
            {
                newNode.next = temp.next;
                temp.next = newNode;
                break;
            }
            
            temp = temp.next;
        }
    }
    

    // Method used to insert a value at a given position
	private void insertAtGivenPosition(int pos, int val)
	{
	    System.out.println("Insert value " + val + " at position " + pos);
	    
        if(!(lengthOfLinkedList() >= pos))
        {
            System.out.println("Index out of range.");
            return;
        }
        
        Node newNode = new Node(val);
        Node prev = null;
        Node temp = head;
        int count = 1;
        
        while(temp != null)
        {
            if(count == pos)
            {
                break;
            }
            
            count += 1;
            prev = temp;
            temp = temp.next;
        }
        
        newNode.next = temp;
        prev.next = newNode;
	}


    // Method used to delete a head value 
	private void deleteAtHead()
	{
	    System.out.println("Delete a head value.");
	    
        head = head.next;
	}


    // Method used to delete a tail value 
	private void deleteAtEnd()
	{
	    System.out.println("Delete a tail value.");
	    
        Node temp = head;
        
        while(temp.next.next != null)
        {
            temp = temp.next;
        }
        
        temp.next = null;
	}


    // Method used to delete a given value
	private void deleteGivenValue(int val)
	{
	    System.out.println("Delete a value " + val);
	    
	    if(!isThere(val))
	    {
	        System.out.println(val + " is not in the linked list.");
	        return;
	    }
	    
	    Node temp = head;
	    
        while(temp != null)
        {
            if(temp.next.data == val)
            {
                temp.next = temp.next.next;
                return;
            }
        }
	}
	
	
    // Method used to delete a value at a given position	
	private void deleteAtGivenPosition(int pos)
	{
	    if(!(lengthOfLinkedList() >= pos))
	    {
	        System.out.println("Position out of range");
	    }
	    
	    int count = 1;
	    Node temp = head;
	    Node prev = null;
	    
	    while(temp != null)
	    {
	        if(count == pos)
	        {
	            prev.next = temp.next;
	            break;
	        }
	        
	        count += 1;
	        prev = temp;
	        temp = temp.next;
	    }
	}


    // Method to check the given value is there or not in the linked list
	private boolean isThere(int val)
	{
		Node temp = head;
		
		while(temp != null)
		{
		    if(temp.data == val)
		    {
		        return true;
		    }
		    temp = temp.next;
		}
		
		return false;
	}


    // Method to check the linked list is empty or not
	private boolean isEmpty()
	{
		if(head == null)
		{
			return true;
		}

		return false;
	}
	
	
    // Method used to print linked list size
    private int lengthOfLinkedList()
    {
        int length = 0;
        Node temp = head;
        
        while(temp != null)
        {
            length += 1;
            temp = temp.next;
        }
        
        return length;
    }
    
    
	// Method to reverse a linked list
    private void reverseLinkedList()
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
        
        head = prev;
    }


    // Method to print a linked list
	private void printLinkedList()
	{
		Node temp = head;

		System.out.print("Singly Linked List: ");

		while(temp != null)
		{
			System.out.print(temp.data + " ");
			temp = temp.next;
		}

		System.out.println();
	}
}
import java.util.*;


class SLL01SinglyLinkedListOperations
{
	Node head;

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
		SLL01SinglyLinkedListOperations sll = new SLL01SinglyLinkedListOperations();

		sll.head = new Node(1);
		Node second = new Node(2);

		sll.head.next = second;

		sll.printLinkedList();

		System.out.println(sll.isEmpty());
	}


	private void insertAtHead(int val)
	{

	}


	private void insertAtEnd(int val)
	{

	}


	private void insertAtGivenPosition(int pos, int val)
	{

	}


	private void deleteAtHead()
	{

	}


	private void deleteAtEnd()
	{

	}


	private void deleteAtGivenPosition()
	{

	}


	private boolean isThere(int val)
	{
		return true;
	}


	private boolean isEmpty()
	{
		if(head == null)
		{
			return true;
		}

		return false;
	}


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
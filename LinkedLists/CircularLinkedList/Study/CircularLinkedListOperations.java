import java.util.*;

class CircularLinkedListOperations
{
	Node lastNode;


	public CircularLinkedListOperations()
	{
		this.lastNode = null;
	}


	public static class Node
	{
		int data;
		Node next;

		public Node(int data)
		{
			this.data = data;
			this.next = null;
		}
	}


	public static void main(String[] args) 
	{
		CircularLinkedListOperations cll = new CircularLinkedListOperations();

		cll.insertAtFront(3);
		cll.insertAtFront(2);
		cll.insertAtFront(1);

		cll.insertAtEnd(5);
		cll.insertAtEnd(6);

		cll.insertAfterGivenNodeValue(77, 1928);
		cll.insertAfterGivenNodeValue(3, 44);

		cll.deleteAtHead();

		cll.deleteAtEnd();
		
		cll.deleteGivenValue(44);
		cll.deleteGivenValue(3);

		cll.printLinkedList();
	}


	public void insertAtFront(int d)
	{
		Node newNode = new Node(d);

		if(isEmpty())
		{
			lastNode = newNode;
			lastNode.next = lastNode;
		}
		else
		{
			newNode.next = lastNode.next;
			lastNode.next = newNode;
		}
	}


	public void insertAtEnd(int d)
	{
		Node newNode = new Node(d);

		if(isEmpty())
		{
			lastNode = newNode;
			lastNode.next = lastNode;
		}
		else
		{
			newNode.next = lastNode.next;
			lastNode.next = newNode;
			lastNode = newNode;
		}
	}


	public void insertAfterGivenNodeValue(int givenValue, int d)
	{
		if(!isThere(givenValue))
		{
			System.out.println(givenValue + " not in the linked list.");
			return;
		}
		else if(lastNode.data == givenValue)
		{
			insertAtEnd(d);
		}
		else
		{
			Node temp = lastNode.next;

			while(temp != lastNode)
			{
				if(temp.data == givenValue)
				{
					break;
				}

				temp = temp.next;
			}

			Node newNode = new Node(d);
			newNode.next = temp.next;
			temp.next = newNode;
		}
	}


	public void deleteAtHead()
	{
		if(isEmpty())
		{
			return;
		}
		else if(lastNode == lastNode.next)
		{
			lastNode = null;
			return;
		}
		else
		{
			Node temp = lastNode.next;
			lastNode.next = temp.next;
		}
	}


	public void deleteAtEnd()
	{
		if(isEmpty())
		{
			return;
		}
		else if(lastNode == lastNode.next)
		{
			lastNode = null;
			return;
		}
		else
		{
			Node temp = lastNode.next;
			Node prev = lastNode;

			while(temp != lastNode)
			{
				prev = temp;
				temp = temp.next;
			}

			prev.next = temp.next;
			lastNode = prev;
		}
	}


	public void deleteGivenValue(int d)
	{
		if(isEmpty())
		{
			return;
		}
		else if(lastNode == lastNode.next && lastNode.data == d)
		{
			lastNode = null;
			return;
		}
		else
		{
			Node temp = lastNode.next;
			Node prev = lastNode;

			while(temp != lastNode)
			{
				if(temp.data == d)
				{
					break;
				}

				prev = temp;
				temp = temp.next;
			}

			prev.next = temp.next;
		}
	}


	public boolean isEmpty()
	{
		if(lastNode == null)
		{
			return true;
		}

		return false;
	}


	public boolean isThere(int d)
	{
		if(isEmpty())
		{
			return false;
		}

		Node temp = lastNode.next;

		while(temp != lastNode)
		{
			if(temp.data == d)
			{
				return true;
			}

			temp = temp.next;
		}

		if(temp.data == d)
		{
			return true;
		}

		return false;
	}


	public void printLinkedList()
	{
		if(isEmpty())
		{
			System.out.println("LinkedList is Empty.");
			return;
		}

		Node temp = lastNode.next;

		while(temp != lastNode)
		{
			System.out.print(temp.data + " ");
			temp = temp.next;
		}

		System.out.println(temp.data);
	}
}
class DoublyLinkedListOperations
{
	private Node head;
	private Node tail;


	public DoublyLinkedListOperations()
	{
		head = null;
		tail = null;
	}


	static class Node
	{
		int data;
		Node prev;
		Node next;

		public Node(int data)
		{
			this.data = data;
			this.prev = null;
			this.next = null;
		}
	}


	public static void main(String[] args) 
	{
		DoublyLinkedListOperations dll = new DoublyLinkedListOperations();

		dll.insertAtHead(2);
		dll.insertAtHead(1);

		dll.insertAtEnd(3);
		dll.insertAtEnd(4);
		dll.insertAtEnd(5);
		dll.insertAtEnd(6);
		dll.insertAtEnd(7);

		dll.deleteAtHead();
		dll.deleteAtEnd();

		dll.deleteGivenValue(2);

		dll.insertAfterGivenNodeValue(4, 44);

		dll.printLinkedList();
		System.out.println();
		dll.reverseLinkedList();
		System.out.println();
	}


	private void insertAtHead(int data)
	{
		Node newNode = new Node(data);

		if(isEmpty())
		{
			head = newNode;
		}
		else
		{
			if(tail == null)
			{
				tail = head;
				tail.prev = newNode;
				newNode.next = tail;
				head = newNode;
			}
			else
			{
				newNode.next = head;
				head.prev = newNode;
				head = newNode;
			}
		}
	}


	private void insertAtEnd(int data)
	{
		Node newNode = new Node(data);

		if(isEmpty())
		{
			head = newNode;
		}
		else
		{
			if(tail == null)
			{
				newNode.prev = head;
				head.next = newNode;
				tail = newNode;
			}
			else
			{
				tail.next = newNode;
				newNode.prev = tail;
				tail = newNode;
			}
		}
	}


	private void insertAfterGivenNodeValue(int nodeVal, int data)
	{
		if(!isThere(nodeVal))
		{
			return;
		}
		else if(tail.data == nodeVal)
		{
			insertAtEnd(data);
		}

		Node temp = head;
		Node newNode = new Node(data);
		
		while(temp.data != nodeVal)
		{
			temp = temp.next;
		}

		newNode.prev = temp;
		newNode.next = temp.next;
		temp.next.prev = newNode;
		temp.next = newNode;
	}


	private void deleteAtHead()
	{
		if(lengthOfDoublyLinkedList() <= 1)
		{
			head = null;
			tail = null;
			return;
		}

		head = head.next;
		head.prev = null;
	}


	private void deleteAtEnd()
	{
		if(lengthOfDoublyLinkedList() <= 1)
		{
			head = null;
			tail = null;
			return;
		}

		tail = tail.prev;
		tail.next = null;
	}


	private void deleteGivenValue(int data)
	{
		if(!isThere(data))
		{
			return;
		}
		else if(head.data == data)
		{
			deleteAtHead();
			return;
		}
		else if(tail.data == data)
		{
			deleteAtEnd();
			return;
		}

		Node temp = head;
		Node prev = null;

		while(temp != null)
		{
			if(temp.data == data)
			{
				break;
			}

			prev = temp;
			temp = temp.next;
		}

		prev.next = temp.next;
		temp.next.prev = prev;
	}


	private int lengthOfDoublyLinkedList()
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


	private boolean isThere(int data)
	{
		Node temp = head;

		while(temp != null)
		{
			if(temp.data == data)
			{
				return true;
			}

			temp = temp.next;
		}

		return false;
	}


	private boolean isEmpty()
	{
		if(head == null)
		{
			return true;
		}

		return false;
	}


	private void reverseLinkedList()
	{
		Node temp = tail;

		while(temp != null)
		{
			System.out.print(temp.data + " ");
			temp = temp.prev;
		}
	}


	private void printLinkedList()
	{
		Node temp = head;

		while(temp != null)
		{
			System.out.print(temp.data + " ");
			temp = temp.next;
		}
	}
}
#include <bits/stdc++.h>
using namespace std;


class Node
{
public:
	int data;		// Data
	Node* next;		// Address of the Node Class
};


// Print the linked list
void PrintSinglyLinkedList(Node* head)
{
	if(head == NULL)
	{
		return;
	}

	cout << "Singly LinkedList : ";

	while(head != NULL)
	{
		cout << head -> data << " ";
		head = head -> next;
	}

	cout << endl;
	cout << endl;
}


// Add data in front of the linked list
Node* AddAtFront(Node* head, int val)
{
	cout << "INSERT " << val << " AT FRONT." << endl;

	Node* newNode = new Node();

	newNode -> data = val;
	newNode -> next = head;

	return newNode;
}


// Add data in End of the linked list
void AddAtEnd(Node* head, int val)
{
	cout << "INSERT " << val << " AT END." << endl;

	Node* lastNode;
	Node* newNode = new Node();

	newNode -> data = val;
	newNode -> next = NULL;

	if(head == NULL)
	{
		return;
	}

	while(head != NULL)
	{
		lastNode = head;
		head = head -> next;
	}

	lastNode -> next = newNode;
}


// Add data after a given Node value
void AddAfter(Node* head, int prevVal, int val)
{
	cout << "INSERT " << val << " AFTER NODE " << prevVal << "." << endl;
	if(head == NULL)
	{
		return;
	}

	bool isThere = false;
	Node* prevNode;
	Node* newNode = new Node();

	newNode -> data = val;

	while(head != NULL)
	{
		if(head -> data == prevVal)
		{
			prevNode = head;
			isThere = true;
			break;
		}

		head = head -> next;
	}

	if(isThere)
	{
		newNode -> next = prevNode -> next;
		prevNode -> next = newNode;
	}
	else
	{
		cout << "CANNOT INSERT: Given Value " << prevVal << " Not in the list\n";
	}
}


Node* DeleteFromList(Node* head, int val)
{
	cout << "Deleting " << val << ".\n";
	if(head == NULL || head -> next == NULL)
	{
		return head;
	}

	Node* currentNode = head;
	bool isThere = false;

	while(currentNode -> next != NULL)
	{
		if(currentNode -> next -> data == val)
		{
			isThere = true;
			break;
		}
		currentNode = currentNode -> next;
	}

	if(isThere)
	{
		currentNode -> next = currentNode -> next -> next;
	}
	else
	{
		cout << "CANNOT DELETE: Given Value " << val << " Not in the list\n";
	}

	return head;
}


int LengthOfTheList(Node* head)
{
	int ans = 0;

	while(head != NULL)
	{
		ans += 1;
		head = head -> next;
	}

	return ans;
}


Node* ReverseLinkedList(Node* head)
{
	Node* current = head;
	Node* prev = NULL;
	Node* next = NULL;

	while(current != NULL)
	{
		next = current -> next;
		current -> next = prev;
		prev = current;
		current = next;
	}

	return prev;
}


int main()
{
	cout << "SINGLY LINKED LIST STUDY." << endl;

	Node* head = new Node();
	Node* second = new Node();
	Node* third = new Node();

	head -> data = 1;
	head -> next = second;

	second -> data = 2;
	second -> next = third;

	third -> data = 3;
	third -> next = NULL;

	PrintSinglyLinkedList(head);

	head = AddAtFront(head, -1);
	AddAtEnd(head, 4);
	AddAfter(head, 2, 22);
	AddAfter(head, 4, 44);
	AddAfter(head, 5, 55);

	cout << "\nAfter Inserting : " << endl;
	PrintSinglyLinkedList(head);

	head = DeleteFromList(head, 1);
	head = DeleteFromList(head, 44);
	head = DeleteFromList(head, 77);

	cout << "\nAfter Deleting : " << endl;
	PrintSinglyLinkedList(head);

	cout << "Length of the Linked List: " << LengthOfTheList(head) << endl;

	head = ReverseLinkedList(head);

	cout << "\nAfter Reversing : " << endl;
	PrintSinglyLinkedList(head);
}

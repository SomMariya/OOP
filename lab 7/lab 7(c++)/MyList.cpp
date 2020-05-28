#include "Header.h"
#include <iostream>

Mylist::Mylist()
{
	 Head = NULL;
};

Mylist::~Mylist()
{
	while (Head)
	{
		Head = Head->next;
		delete Head;
	}
};

void Mylist::AddFirst(PNode NewNode)
{
	NewNode->next = Head;
	Head = NewNode;
}

void Mylist::AddAfter(PNode p, PNode NewNode)
{
	NewNode->next = p->next;
	p->next = NewNode;
}

void Mylist::AddLast(PNode NewNode)
{
	PNode current = Head;
	if (Head == NULL)
	{
		AddFirst(NewNode);
		return;
	}
	while (current->next)
	{
		current = current->next;
	}
	AddAfter(current, NewNode);
}

int Mylist::FindSymbol(char s)
{
	int counter = 0;

	PNode current = Head;
	while (current != NULL)
	{
		if (current->word == s)
		{
			counter++;
		}
		current = current->next;
	}
	return counter;
}

void Mylist::DeleteNode(PNode n)
{
	PNode current = Head;

	if (Head == n)
	{
		Head = n->next;
	}
	else
	{
		while (current && current->next != n)
		{
			current = current->next;
		}
		if (current == NULL)
		{
			return;
		}
		current->next = n->next;
	}
	delete n;
}

void Mylist::DeleteAfterHash()
{
	PNode current = Head;
	if (FindSymbol('#') != 0)
	{
		while (current->word != '#')
		{
			current = current->next;
		}
		while (current->next != NULL)
		{
			DeleteNode(current->next);
		}	
	}
}
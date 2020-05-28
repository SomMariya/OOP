#pragma once
#include <iostream>

struct Node
{
	char word;
	Node* next;
};

class Mylist
{
	typedef Node* PNode;
	PNode Head;

public:
	Mylist();
	void AddLast(PNode NewNode);
	int FindSymbol(char s);
	void DeleteAfterHash();
	~Mylist();

private:
	void AddFirst(PNode NewNode);
	void AddAfter(PNode p, PNode NewNode);
	void DeleteNode(PNode p);
};
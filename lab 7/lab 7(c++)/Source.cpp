#include <iostream>
#include "Header.h"
using namespace std;

int main()
{
	Mylist list = Mylist();
	Node node, node1, node2;
	node.word = '#';
	node1.word = '*';
	node2.word = '*';

	list.AddLast(&node);
	list.AddLast(&node1);
	list.AddLast(&node2);

	list.FindSymbol('*');
	//list.DeleteAfterHash();
	list.FindSymbol('*');
}



		




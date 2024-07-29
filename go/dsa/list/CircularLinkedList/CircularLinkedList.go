package circularlinkedlist

import "fmt"

type ListNode struct {
	Next *ListNode
	Data int
}

type CircularLinkedList struct {
	last   *ListNode
	length int
}

func NewCircularLinkedList() *CircularLinkedList {
	return &CircularLinkedList{}
}

func (cl *CircularLinkedList) Length() int {
	return cl.length
}

func (cl *CircularLinkedList) IsEmpty() bool {
	return cl.length == 0
}

func (cl *CircularLinkedList) CreateCircularLinkedList() {
	first := &ListNode{Data: 1}
	second := &ListNode{Data: 5}
	third := &ListNode{Data: 10}
	fourth := &ListNode{Data: 15}

	first.Next = second
	second.Next = third
	third.Next = fourth
	fourth.Next = first

	cl.last = fourth
	cl.length = 4
}

func (cl *CircularLinkedList) Display() {
	if cl.last == nil {
		return
	}

	first := cl.last.Next
	for first != cl.last {
		fmt.Printf("%d --> ", first.Data)
		first = first.Next
	}
	fmt.Println(first.Data)
}

func (cl *CircularLinkedList) InsertFirst(Data int) {
	temp := &ListNode{Data: Data}
	if cl.last == nil {
		cl.last = temp
		cl.last.Next = cl.last
	} else {
		temp.Next = cl.last.Next
		cl.last.Next = temp
	}
	cl.length++
}

func (cl *CircularLinkedList) InsertLast(Data int) {
	temp := &ListNode{Data: Data}
	if cl.last == nil {
		cl.last = temp
		cl.last.Next = cl.last
	} else {
		temp.Next = cl.last.Next
		cl.last.Next = temp
		cl.last = temp
	}
	cl.length++
}

func (cl *CircularLinkedList) RemoveFirst() *ListNode {
	if cl.IsEmpty() {
		panic("Circular Singly Linked List is already empty")
	}

	temp := cl.last.Next
	if cl.last.Next == cl.last {
		cl.last = nil
	} else {
		cl.last.Next = temp.Next
	}
	temp.Next = nil
	cl.length--
	return temp
}

package main

import (
	queue "dsa/queue"
)

func main() {
	queue := queue.NewQueue()
	
	queue.Enqueue(10)
	queue.Enqueue(15)
	queue.Enqueue(20)

	queue.Print()

	queue.Dequeue()
	queue.Dequeue()

	queue.Print()
}

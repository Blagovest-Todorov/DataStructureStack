using System;
using System.Collections;
using System.Collections.Generic;

namespace _02.LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //LinkedList is a data structure in C# System.Collections.Generic namespace.
            // The principle of functionnig of teh linked list structure is that each node in the
            // list has a reference to the next node ,except the tail of the list, that has no reference.
            //Generic collections provide beter safety and performance, than non-generic strongly-typed colections!
            //many generics collections type are analog of nongenereic types.
            // Linked List HasPointers to the first Element
            // special pointer points the topElement-the starting elmenet! 
            // each item has two fields --the value  and the  next ->reference-pointing the next element!
            // 

            // stack  <T> is dynamically increased ! , 
            // elements are form the same type ! 
            //basic functionallity push()-inssertes element to the stack 
            // pop() removes and returnes the top element
            // peek(); -> to see the top elements value ! but it is not removing it! 
            // Count -retunns the numeber of teh elemetns
            // clear() -removes all elements
            //Contaionts()--determindes wheather given elemetn is in  the stack ! 
            //ToArray() -converts rteh stack to an Array 
            // TrimExcess() sets teh capacity to the actual number of elements --i.e 
            // trimExcess -removes the empty capacity of the stack, 
            //it sets the capacity to the actual number of eleemnts 
            //removes the extra unused provided capacity - it frees the capacity !

            Stack<string> stack = new Stack<string>();

            stack.Push("1.Ivan");
            stack.Push("2.Ivan");
            stack.Push("3.Nikolay");
            stack.Push("4.Maria");
            stack.Push("5.George");

            Console.WriteLine("Top = {0}", stack.Peek()); //we print the top element!

            while (true)  //if there is at least element into the stack available ! 
            {
                string personName = stack.Pop();
                Console.WriteLine(personName);
            }
            //print SystemIbnvalidOperationException ->  the Stack is empty and we can not remove more elements
            // because the stack is already empty we dont have anithign to remove !
            //ran outOf MemoryException ->  out memory is full , the program is cylcing inintaely
            //if we say stack.Push();

            //Queue -has a starting and ending index ! ->  head and tail indeces ! pointing to the Head and tail
            // to the cycling queue // static queue --like an  array  with fixed size 
            //Linked queue -> its like a linked list /
            // queue -dynamically resizable array ! head index and tail index ; 
            // elements are from the same type
            // queue resize dynamically ! size is dynamically resized when needed !
            //queue doest have indexes, orerations in array are faster, 
            // queue only have a starting, head index and final end index-called- tail index! 
        }
    }
}

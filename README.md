# Linked Lists

## 2.1 Remove Duplicates: 
Remove duplicates from an unsorted Linked List

SOLUTION:
- In solution one I used a dictionary. I did iterate the linked list saving distinct element and deleting by the way the duplicates. I got a single iteration through the list. It takes O(N) time.
- In solution two I don't have a buffer but two pointers, a "current" and a "runner". O(N2)
the code is commented.

NOTE: We implement the visit with a while, common in not fixed dimension data structure as linked lists.

USEFUL LINKS:
- Linked list class and node
  - https://msdn.microsoft.com/en-us/library/he2s3bh7(v=vs.110).aspx
  - https://msdn.microsoft.com/en-us/library/ahf4c754(v=vs.110).aspx

- Other Exercises
  - https://www.geeksforgeeks.org/reverse-a-linked-list/

## 2.2 Find Kth to last: 
Write a method to find the kth to last element of a singly linked list.

EXAMPLE:

in the list "S1,S2,S3,S4,S5" the "Kth"=3(last but two) is "S3"

SOLUTION:
- Recursive approach. The method gets in input the head of the linked list, then recursively visit the all list, then when at the end, increment the static variable "Count".
- Iterative approach. I used two pointers, the runner goes ahead of "k" positions, then in a while the two pointers advance together. when "runner" is at the ens of the list, the "current" is the "kth" element to return.

## 2.3 Delete Middle Node:
Implement an algorithm to delete a node in the middle of a single linked list. Giving access only to the middle node

SOLUTION
- the solution is trivial and therefore not implemented. It's enought check previous and next of the current middle node, if both not null, delete the node.

## 2.4 Partition:
Given a linked list and a value "k", return a linked list where all the element smaller than "k" are before than "k" and all the element equal or bigger than "k" are after the smaller. No matter the order. 

EXAMPLE:

input 3->5->8->5->10->2->1 with "k"=5

output 3->1->2->5->8->5->10

SOLUTION
- Approach One(not implemented): loop the input linked list and use another two linked lists "smaller" and "equalBiger", insert in one of the two lists depending on the value of the current element. when loop finishes, merge "smaller" and "equalBiger" lists and return.
- Approach two: loop the input linked list and use another linked list. Insert at head if current element < "k" or tail if current alement >= "k".

## 2.5 Sum Lists:
Given two linked lists whre each nore contains a sigle digit and the digit are stored in reverse order, create a function that adds the two and returns the sum linked list.

EXAMPLE:

input 

7 > 1 > 6, 5 > 9 > 2

SOLUTION
- first time I add 7+5, result is 12, I write "2" as first element in the list and carry "1". The code is well commented.
 
## 2.6 Palindrome:
Implement a function to check if a linked list is palindrome

SOLUTION
- First(Implemented "//LD 2.6_1"). 
  - Just reverse the linked list and iteratively check if the original and reverded linked lists are equal.
- Second A, uses a stack, we know lenght of the list. 
  - We put half of it in a stack and then compare the second half of the list pulling each item of the stack. If we complete an iteration without finding a difference then the linked list is palindrome. 
- Second B(Implemented "//LD 2.6_2"), uses a stack, we don't know lenght of the list. It's possible to use the "fast runner/ slow runner" technique when iterate. When the fast runner reach the end of the list we know that the slow runner is at the middle.
  - In each while iteration -> check upfront fast pointer current status, if ok(fast!=0 and fast.next!=0) -> push current slow and update pointers (slow+1,fast+2)
- Third(Implemented "//LD 2.6_3"), recursive.
  - the code is commented, and I took notes in the book at page 218, 219.
  - other interesting solutions available here -> https://github.com/careercup/CtCI-6th-Edition-CSharp/blob/master/Ch%2002.%20Linked%20Lists/Q2_06_Palindrome.cs
    - This solution takes advantage of the LIFO (Last In First Out) and FIFO (First In First Out) buffers. 
      - The idea is that we fill both of the buffers with the same nodes
      - and then we take the nodes back from each and compare them. 
      - Since LIFO will return a node from the end of the list and
      - FIFO will return the node from the start, we are able to check if 
      - the Linked List is a palindrome.
	- another recursive approach (Implemented "//LD 2.6_4")
	  -  We traverse the Linked List to the end while keeping a reference of the first node.
      - Palindrome check begins when we recurse to the end of the Linked List:
      - 1) Compare the two nodes (one from start and one from the back)
      - 2) Advance the "front" node because by recursing back we get the node before "back"
      - 3) Return isPalindrome
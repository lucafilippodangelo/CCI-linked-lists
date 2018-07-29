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

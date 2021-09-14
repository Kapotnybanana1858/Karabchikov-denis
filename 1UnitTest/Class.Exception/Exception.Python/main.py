'''

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

'''
import sys

try:
    print("Enter first number")
    num1 = float(input())

    print("Enter second number")
    num2 = float(input(input))

    res = num1 / num2
except Exception as e:
    print("Error! " + str(e))


print(sys.getsizeof(int))
print(sys.getsizeof(float))

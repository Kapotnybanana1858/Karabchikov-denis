'''

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

'''
import sys

try:
    print("Введите первое число : ")
    num1 = float(input())

    print("Введите второе число: ")
    num2 = float(input())

    res = num1 / num2
    print(res)
except Exception as e:
    print("Error! " + str(e))


print("Размер int"sys.getsizeof(int()))
print("Размер Float"sys.getsizeof(float()))

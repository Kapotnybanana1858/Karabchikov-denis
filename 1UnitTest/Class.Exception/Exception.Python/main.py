'''

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

'''
print("start")
try:
   val = int(input("input number: "))
   tmp = 10 / val
   print(tmp)
except Exception as e:
   print("Error! " + str(e))
print("stop")
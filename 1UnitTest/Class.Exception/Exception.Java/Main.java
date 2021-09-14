/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
public class Main
{
	public static void main(String[] args) {
		try {

            int a = 30, b = 0;

            int c = a/b;  

            System.out.println ("Result = " + c);

        }

        catch(ArithmeticException e) {

            System.out.println ("Нельзя делить на 0!!!!");

        }
	}
}

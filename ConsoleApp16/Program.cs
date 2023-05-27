#include <iostream>

using namespace std;
#define size 5
int stack[size], top = -1;
void push(int value)
{
    if (top == size - 1)
    {
        cout << "stack overflow" << endl;
    }
    else
    {
        top++;
        stack[top] = value;
    }
}
int pop()
{
    if (top == -1)
    {
        cout << "stack undeflow" << endl;
    }
    return stack[top--];
}
int peek()
{
    return stack[top];
}
void display()
{
    if (top == -1)
    {
        cout << "stack underflow" << endl;
    }
    else
    {
        int i = top;
        while (stack[i] != NULL)
        {
            cout << stack[i] << endl;
            i--;
        }

    }
}
int main()
{
    push(5);
    push(5);
    push(5);
    push(5);
    display();
    return 0;
}
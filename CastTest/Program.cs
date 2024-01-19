// See https://aka.ms/new-console-template for more information
using CastTest;

getNum ge = new getNum();
int number = ge.getnumber();
GetChar ch = new GetChar();
CastChar cast = new CastChar();
char res = ch.getChar(555);
char character = (char)cast.getchN(number);
Console.WriteLine(" the cast char of " + number + " is " + character);

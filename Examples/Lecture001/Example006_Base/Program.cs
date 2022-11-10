using System;

int a = 203;
int b = 15;
int c = 5;
int d = 9;
int e = 116;
int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.Write(max);
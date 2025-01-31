# C64BasisRenum

I needed to be able to renumber the line numbers in my Commodore C64 Basic Programs.
So now I am working on this Util to do just that.

But it should not just renumber lines like from 10 - 1000 with a step.
I also want it to be able to handle sections or sub rutines that I would like to start at a specific number.
So like if i have this.

10 Print "Start of program"
13 Print "Bla bla bla"
20 gosub 1000 : rem go sub do work
25 end

1000 rem Sub do work
1011 i=0
1013 j=0
1020 return

It should produce this.
10 Print "Start of program"
20 Print "Bla bla bla"
30 gosub 1000 : rem go sub do work
40 end

1000 rem Sub do work
1010 i=0
1020 j=0
1030 return

And also be able to change the gosub and goto statements to have the right number.


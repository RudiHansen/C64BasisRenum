# C64BasisRenum

## Status
UPDATED: 03/02/2025\
Development done for now.\
The program works now, and all features are implemented.

## TODO

## TODO's Done
BUG     : If there is more than one goto/gosub on a line, then it does not change more than one linenumber.\
ISSUE   : Automaticly locating sub rutines it not that good at the moment.\
FEATURE : Filter options on code viewer, added DG.AdvancedDataGridView that has inbuild filter options.\
FEATURE : Som way of setting how the renumbering should work, like start line number and line number step.\

## Description
I needed to be able to renumber the line numbers in my Commodore C64 Basic Programs.\
So now I am working on this Util to do just that.

But it should not just renumber lines like from 10 - 1000 with a step.\
I also want it to be able to handle sections or sub rutines that I would like to start at a specific number.\
So like if i have this.

10 Print "Start of program"\
13 Print "Bla bla bla"\
20 gosub 1000 : rem go sub do work\
25 end

1000 rem Sub do work\
1011 i=0\
1013 j=0\
1020 return

It should produce this.\
10 Print "Start of program"\
20 Print "Bla bla bla"\
30 gosub 1000 : rem go sub do work\
40 end

1000 rem Sub do work\
1010 i=0\
1020 j=0\
1030 return

The program also handles changing goto and gosub line numbers to change to the renumbered values.\

## 💬 Feedback & Contributions  
I’d love to hear your thoughts! If you try this out, please:  
✅ Open an **issue** for suggestions, feedback, or bug reports.  
✅ Start a **GitHub Discussion** if you have questions (if enabled).  
✅ Star ⭐ the repo if you find it useful!  

Your feedback helps improve this project—don’t hesitate to share your thoughts! 🚀  





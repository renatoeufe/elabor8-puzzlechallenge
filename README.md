Puzzle challenge
Little Laura has a problem, she likes puzzles, but she gets bored easily. One day we decided to get some statistics on how far Laura gets on her puzzles.

She will receive a puzzle with N pieces and will play for M seconds. Every second she connects a new piece.

We want to know:

How many pieces of this puzzle she could not connect with any other.
How many independent groups of pieces she got connected.
You get points for each one of the responses.

Input format

When you click "Generate test file", you will get a text file with multiple lines.

The very first line contains two integers, N and M. N being the total number of pieces of the puzzle and M being the total number of seconds that Laura played for. e.g. "342 537" means that the puzzle has 342 pieces and Laura played it for 537 seconds.

Over the next lines of the file, you will get a sequence of two integers separated by a space. These integers represent the number of the pieces connected. e.g. "282 172" means that the piece 282 was connected to the piece 172. The same piece might connect with more than one part.

Like in a puzzle, you might have different groups of pieces that don't connect to each other.

Expected output

File Name:
Number of pieces not connected to any other:
Number of different groups formed:

Sample input

8 6
1 2
3 2
2 4
4 5
5 1
6 7
Sample Output

1 Alone
2 Groups
Explanation

let

1 2 3 4 5 6 7 8
the pieces of the puzzle.

1-2 3 4 5 6 7 8
There is 1 group and 6 single pieces after the first join.

1-2-3 4 5 6 7 8
There is 1 group and 6 single pieces after the second join. Because 3 -> 2 made 3 join the other group

1-2-3 5 6 7 8
  |
  4
There is 1 group and 4 single pieces after the third join.

1-2-3 6 7 8
  |
5-4
There is 1 group and 3 single pieces after the fourth join.

1-2-3 6 7 8
| |
5-4
There is 1 group and 3 single pieces after the fifth join.

1-2-3 6-7 8
| |
5-4
There are 2 group and 1 single piece after the sixty join.

1-2-3 6-7 8
| |
5-4
Since Laura got bored this is the end result. 2 grups e one single piece.

Sample code implemented in c# to read the files and give you some place to just put your logic

string filename = "Your file name";
int numberOfPiecesDisconected, numberOfGroups;
if (args.Length > 0)
{
    filename = args[0];
    Console.WriteLine(filename);
}
var fileLines = File.ReadAllLines(filename);
var numberOfPieces = int.Parse(fileLines[0].Split(' ')[0]);
var numberOfOperations = int.Parse(fileLines[0].Split(' ')[1]);
for (var i = 1; i <= numberOfOperations; i++)
{
    var item = fileLines[i];
    // The first piece from this line
    var first = int.Parse(item.Split(' ')[0]);
    // The piece it connects to in this line
    var second = int.Parse(item.Split(' ')[1]);

    // Implement here your logic...
}
                                        

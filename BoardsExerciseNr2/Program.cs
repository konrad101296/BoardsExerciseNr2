int[] board = new int [20];

for (int i = 0; i < 20; i++)
{
    Console.WriteLine("enter board number:");
    int boardNumber = int.Parse(Console.ReadLine());
    board[i] = boardNumber;
}
if (board[0]> board[19])
{
    Console.WriteLine("first element is bigger than the last one");
}
else if (board[0] < board[19])
{
    Console.WriteLine("last element is bigger than the first one");
}
else
{
    Console.WriteLine("first and the last elements are equal");
}
if (board[1] != board[18])
{
    Console.WriteLine("second element is diffrent from the penultimate");
}
else
{
    Console.WriteLine("second element is not diffrent from the penultimate");
}
foreach (var item in board)
{
    Console.WriteLine($"Elements on the board: {item}");
}
using System.Data;
using System.Timers;

namespace TicTacToe.Pages;

public partial class Home
{
    // matrix ichiga bosilga X va O larni 1 va 2 sifatida saqlay
    int[][] matrix = 
    [
        [ 0, 0, 0 ],
        [ 0, 0, 0 ],
        [ 0, 0, 0 ],
    ];

    bool computersTurn = false;
    bool isUserX = new Random().Next() % 2 == 0;
    bool isFinished => matrix.All(row => row.All(x => x != 0)) || hasWinner;

    string winner = string.Empty;
    bool hasWinner => string.IsNullOrWhiteSpace(winner) is false;

    string? TransformIntoData(int data)
    => data switch 
    {
        1 => "❌",
        2 => "⭕",
        _ => null
    };

    void CardClicked((int Row, int Column) position)
    {
        if (computersTurn is false && matrix[position.Row][position.Column] is 0)
        {
            matrix[position.Row][position.Column] = isUserX ? 1 : 2;
            CheckWinner();
            
            computersTurn = true;
            StateHasChanged();

            ComputerMoves().ConfigureAwait(false);
        }
    }

    async Task ComputerMoves()
    {
        await Task.Delay(1000);

        Console.WriteLine("Computer pressing");
        var emptyCards = new List<(int Row, int Column)>();

        for(int row = 0; row < 3; row++)
            for(int column = 0; column < 3; column++)
                if (matrix[row][column] is 0)
                    emptyCards.Add((row, column));

        if(emptyCards.Any())
        {
            var randomCard = emptyCards.OrderBy(_ => Guid.NewGuid()).First();
            matrix[randomCard.Row][randomCard.Column] = isUserX ? 2 : 1;
        }
        computersTurn = false;

        CheckWinner();

        StateHasChanged();
    }


    void CheckWinner()
    {
        for(int row = 0; row < 3; row++)
            if(matrix[row].All(x => x == 1))
                winner = "Winner is ❌";
            else if(matrix[row].All(x => x == 2))
                winner = "Winner is ⭕";

        for(int column = 0; column < 3; column++)
        {
            var columnValues = matrix.Select(row => row[column]).ToArray();

            if(columnValues.All(x => x == 1))
                winner = "Winner is ❌";
            else if(columnValues.All(x => x == 2))
                winner = "Winner is ⭕";
        }

        var leftDiagonal = matrix.Select((_, i) => matrix[i][i]).ToArray();
        if(leftDiagonal.All(x => x == 1))
            winner = "Winner is ❌";
        else if(leftDiagonal.All(x => x == 2))
            winner = "Winner is ⭕";

        var rightDiagonal = matrix.Select((_, i) => matrix[i][2-i]).ToArray();
        if(rightDiagonal.All(x => x == 1))
            winner = "Winner is ❌";
        else if(rightDiagonal.All(x => x == 2))
            winner = "Winner is ⭕";

    }
}

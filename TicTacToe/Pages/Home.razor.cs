using System.Data;
using System.Timers;

namespace TicTacToe.Pages;

public partial class Home
{
    // matrix ichiga bosilga X va O larni 1 va 2 sifatida saqlay
    int[,] matrix = new int[3,3];
    bool computersTurn = false;
    bool isUserX = new Random().Next(0, 1) == 0;

    string? TransformIntoData(int data)
    => data switch 
    {
        1 => "❌",
        2 => "⭕",
        _ => null
    };

    void CardClicked((int Row, int Column) position)
    {
        if (computersTurn is false && matrix[position.Row, position.Column] is 0)
        {
            matrix[position.Row, position.Column] = isUserX ? 1 : 2;
            computersTurn = true;

            ComputerMoves().ConfigureAwait(false);

            StateHasChanged();
            if(isGameFinished()) 
                DecideWinner();
        }
    }

    async Task ComputerMoves()
    {
        await Task.Delay(1000);

        Console.WriteLine("Computer pressing");
        var emptyCards = new List<(int Row, int Column)>();

        for(int row = 0; row < 3; row++)
            for(int column = 0; column < 3; column++)
                if (matrix[row, column] is 0)
                    emptyCards.Add((row, column));

        if(emptyCards.Any())
        {
            var randomCard = emptyCards.OrderBy(_ => Guid.NewGuid()).First();
            matrix[randomCard.Row, randomCard.Column] = isUserX ? 2 : 1;
        }
        computersTurn = false;
        StateHasChanged();

        if(isGameFinished()) 
            DecideWinner();
    }

    bool isGameFinished() 
    {
        var emptyCards = new List<(int Row, int Column)>();

        for(int row = 0; row < 3; row++)
            for(int column = 0; column < 3; column++)
                if (matrix[row, column] is 0)
                    emptyCards.Add((row, column));
        
        return emptyCards.Any() is false;
    }

    void DecideWinner()
    {
    }
}

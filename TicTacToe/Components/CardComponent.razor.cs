using Microsoft.AspNetCore.Components;

namespace TicTacToe.Components;

public partial class CardComponent
{
    [Parameter]
    public string? Data { get; set; }
    [Parameter]
    public (int Row, int Column) Position { get; set; }
    [Parameter]
    public EventCallback<(int Row, int Column)> OnClicked { get; set; }

    async Task OnCardClicked() => await OnClicked.InvokeAsync(Position);
}

using Xunit;
using Moq;
using BalanceService.Application.Commands;
using BalanceService.Domain.Interfaces;
using BalanceService.Application.Services;
using BalanceService.Domain;

public class GetConsodatedBalanceHandlerTest
{
    [Fact]
    public async Task Handle_ReturnsCorrectBalance()
    {
        // Arrange
        var mockRepo = new Mock<IEntryRepository>();
        var entries = new List<Entry>
        {
            new Entry(-100, DateTime.Now, EntryType.Debit),
            new Entry(200, DateTime.Now, EntryType.Credit),
        };
        mockRepo.Setup(repo => repo.GetEntriesAsync(It.IsAny<DateTime>())).ReturnsAsync(entries);

        var handler = new GetConsodatedBalanceHandler(mockRepo.Object);
        var command = new GetConsolidatedBalanceCommand(DateTime.Now);

        // Act
        var result = await handler.Handle(command, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(100, result.Balance);
        Assert.Equal(-100, result.TotalDebit);
        Assert.Equal(200, result.TotalCredit);
    }
}
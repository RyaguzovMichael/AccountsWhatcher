namespace AccountsWatcher.Domain.Tests;

public sealed class AccountsTests
{
    [Fact]
    public void NewAccountHasEmptySize()
    {
        // Arrange
        var account = new Account();
        
        // Act
        
        // Assert
        Assert.Equal(0D, account.Size);
    }
}
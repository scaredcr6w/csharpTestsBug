using vscode_bug;
namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(3, vscode_bug.Program.Add(1, 2));
    }
}
using Xunit;

public class AlwaysFailingTest
{
    [Fact]
    public void ThisTestWillAlwaysFail()
    {
        Assert.True(true, "Este teste foi configurado para sempre falhar.");
    }
}

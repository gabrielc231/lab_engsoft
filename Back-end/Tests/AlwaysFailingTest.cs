using Xunit;

public class AlwaysFailingTest
{
    [Fact]
    public void ThisTestWillAlwaysFail()
    {
        Assert.True(false, "Este teste foi configurado para sempre falhar.");
    }
}

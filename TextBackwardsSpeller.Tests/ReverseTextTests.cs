namespace TextBackwardsSpeller.Tests;

public class ReverseTextTests
{
    [Theory, AutoData]
    public void Constructor_HasNullGuards(GuardClauseAssertion assertion)
    {
        assertion.Verify(typeof(ReverseText).GetConstructors());
    }

    [Theory, AutoData]
    public void Constructor_ReturnsReverseText(ReverseText sut)
    {
        sut.Should().BeAssignableTo<IReverseText>();
    }

    [Theory, AutoData]
    public void Methods_HaveNullGuards(GuardClauseAssertion assertion)
    {
        assertion.Verify(typeof(ReverseText).GetMethods().Where(method => !method.IsAbstract));
    }

    [Theory, AutoData]
    public void ValueFor_ForProvidedString_ReturnsReversedString(
        ReverseText sut)
    {
        // Arrange

        // Act
        var result = sut.ValueFor("dummy String");

        // Assert
        result.Should().Be("gnirtS ymmud");
    }
}
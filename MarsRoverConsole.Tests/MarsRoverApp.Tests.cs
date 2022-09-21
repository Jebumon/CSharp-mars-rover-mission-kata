namespace MarsRoverConsole.Tests;
using FluentAssertions;
using MarsRoverConsole.MarsRoverApp;

public class MarsRoverAppTests
{
    private MarsRoverApp MarsRoverApp;

    [SetUp]
    public void Setup()
    {
        MarsRoverApp = new MarsRoverApp();
    }

    [Test]
    public void Decode_Orientation_L_should_Left()
    {
        MarsRoverApp.MarsManager("L").Should().Be("Left");
    }

    [Test]
    public void Decode_Orientation_R_should_Right()
    {
        MarsRoverApp.MarsManager("R").Should().Be("Right");
    }

    [Test]
    public void Decode_Orientation_M_should_Move()
    {
        MarsRoverApp.MarsManager("M").Should().Be("Move Forward");
    }
}
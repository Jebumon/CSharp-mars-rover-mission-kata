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
        MarsRoverApp.MarsManager("L").Should().Be("Left ");
    }

    [Test]
    public void Decode_Orientation_R_should_Right()
    {
        MarsRoverApp.MarsManager("R").Should().Be("Right ");
    }

    [Test]
    public void Decode_Orientation_M_should_Move()
    {
        MarsRoverApp.MarsManager("M").Should().Be("Move Forward ");
    }

    [Test]
    public void Decode_Orientation_null_should_UnknownCommand()
    {
        MarsRoverApp.MarsManager(" ").Should().Be("Unknown command ");
    }

    [Test]
    public void Decode_Orientation_LLR_should_LeftLeftRight()
    {
        MarsRoverApp.MarsManager("LLR").Should().Be("Left Left Right ");
    }

    [Test]
    public void Decode_Orientation_LL_should_LeftLeft()
    {
        MarsRoverApp.MarsManager("LL").Should().Be("Left Left ");
    }

    [Test]
    public void Decode_Orientation_LLL_should_LeftLeftLeft()
    {
        MarsRoverApp.MarsManager("LLL").Should().Be("Left Left Left ");
    }

    [Test]
    public void Decode_Orientation_RRR_should_RightRightRight()
    {
        MarsRoverApp.MarsManager("LLL").Should().Be("Left Left Left ");
    }

}
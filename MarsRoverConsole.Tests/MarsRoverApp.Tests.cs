namespace MarsRoverConsole.Tests;
using FluentAssertions;
using MarsRoverConsole.MarsMissionApp;

public class MarsRoverAppTests
{
    private MarsMissionAppManager MarsRoverApp;

    [SetUp]
    public void Setup()
    {
        MarsRoverApp = new MarsMissionAppManager(5,5);
    }

    [Test]
    public void Decode_Command_N_LL_should_S()
    {
        MarsRoverApp.MarsManager("N","LL").Should().Be("S");
    }

    [Test]
    public void Decode_Command_N_RR_should_S()
    {
        MarsRoverApp.MarsManager("N","RR").Should().Be("S");
    }

    [Test]
    public void Decode_Command_S_LL_should_N()
    {
        MarsRoverApp.MarsManager("S","LL").Should().Be("N");
    }

    [Test]
    public void Decode_Command_S_RR_should_N()
    {
        MarsRoverApp.MarsManager("S","RR").Should().Be("N");
    }

    [Test]
    public void DDecode_Command_N_LLR_should_W()
    {
        MarsRoverApp.MarsManager("N","LLR").Should().Be("W");
    }

    [Test]
    public void Decode_Command_E_LL_should_W()
    {
        MarsRoverApp.MarsManager("E","LL").Should().Be("W");
    }

    [Test]
    public void Decode_Command_E_RR_should_W()
    {
        MarsRoverApp.MarsManager("E","RR").Should().Be("W");
    }

    [Test]
    public void Decode_Command_W_LL_should_E()
    {
        MarsRoverApp.MarsManager("W", "LL").Should().Be("E");
    }

    [Test]
    public void Decode_Command_W_RR_should_E()
    {
        MarsRoverApp.MarsManager("W", "RR").Should().Be("E");
    }
}
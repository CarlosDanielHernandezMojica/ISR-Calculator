using System;
using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Services;
using Xunit;

namespace TecNM.Practica3.Tests;

public class CalculatorISRServiceShould
{
    [Fact]
    public void ProcessISR_WhenIncomeIs6000_Return115_1998()
    {
        //Arrange
        var expectedValue = 115.1998f;
        var person = new Person() { Income = 6000 };
        var sut = new CalculatorISRService();
        
        //Act
        var result = sut.ProcessISR(person);
        
        //Assert
        Assert.Equal(expectedValue, result.totalISR, 4);
    }
    
    [Fact]
    public void ProcessISR_WhenIncomeIs13500_Return517_46936()
    {
        //Arrange
        var expectedValue = 517.46936f;
        var person = new Person() { Income = 13500 };
        var sut = new CalculatorISRService();
        
        //Act
        var result = sut.ProcessISR(person);
        
        //Assert
        Assert.Equal(expectedValue, result.totalISR);
    }
    
    [Fact]
    public void ProcessISR_WhenIncomeIs80000_Return5416_3027()
    {
        //Arrange
        var expectedValue = 5416.3027f;
        var person = new Person() { Income = 80000 };
        var sut = new CalculatorISRService();
        
        //Act
        var result = sut.ProcessISR(person);
        
        //Assert
        Assert.Equal(expectedValue, result.totalISR, 4);
    }
    [Fact]
    public void ProcessISR_WhenIncomeIs120000_Return10005_0547()
    {
        //Arrange
        var expectedValue = 10005.0547;
        var person = new Person() { Income = 120000 };
        var sut = new CalculatorISRService();
        
        //Act
        var result = sut.ProcessISR(person);
        
        //Assert
        Assert.Equal(expectedValue, result.totalISR, 4);
    }
    
    [Fact]
    public void ProcessISR_WhenIncomeIs150000_Return15109_9600()
    {
        //Arrange
        var expectedValue = 15109.9600f;
        var person = new Person() { Income = 150000 };
        var sut = new CalculatorISRService();
        
        //Act
        var result = sut.ProcessISR(person);
        
        //Assert
        Assert.Equal(expectedValue, result.totalISR, 4);
    }
    
    [Fact]
    public void ProcessISR_WhenIncomeIs200000_Return25426_0840()
    {
        //Arrange
        var expectedValue = 25426.0840f;
        var person = new Person() { Income = 200000 };
        var sut = new CalculatorISRService();
        
        //Act
        var result = sut.ProcessISR(person);
        
        //Assert
        Assert.Equal(expectedValue, result.totalISR, 4);
    }
    
    [Fact]
    public void ProcessISR_WhenIncomeIs400000_Return69790_671()
    {
        //Arrange
        var expectedValue = 69790.671f;
        var person = new Person() { Income = 400000 };
        var sut = new CalculatorISRService();
        
        //Act
        var result = sut.ProcessISR(person);
        
        //Assert
        Assert.Equal(expectedValue, result.totalISR, 4);
    }
    
    [Fact]
    public void ProcessISR_WhenIncomeIs600000_Return122633_4450()
    {
        //Arrange
        var expectedValue = 122633.4450f;
        var person = new Person() { Income = 600000 };
        var sut = new CalculatorISRService();
        
        //Act
        var result = sut.ProcessISR(person);
        
        //Assert
        Assert.Equal(expectedValue, result.totalISR, 4);
    }
    
    [Fact]
    public void ProcessISR_WhenIncomeIs1000000_Return243142_7300()
    {
        //Arrange
        var expectedValue = 243142.7300f;
        var person = new Person() { Income = 1000000 };
        var sut = new CalculatorISRService();
        
        //Act
        var result = sut.ProcessISR(person);
        
        //Assert
        Assert.Equal(expectedValue, result.totalISR, 4);
    }
    [Fact]
    public void ProcessISR_WhenIncomeIs2000000_Return577205_125()
    {
        //Arrange
        var expectedValue = 577205.125;
        var person = new Person() { Income = 2000000 };
        var sut = new CalculatorISRService();
        
        //Act
        var result = sut.ProcessISR(person);
        
        //Assert
        Assert.Equal(expectedValue, result.totalISR, 4);
    }
    
    [Fact]
    public void ProcessISR_WhenIncomeIs4000000_Return1258173_6()
    {
        //Arrange
        var expectedValue = 1258173.6f;
        var person = new Person() { Income = 4000000 };
        var sut = new CalculatorISRService();
        
        //Act
        var result = sut.ProcessISR(person);
        
        //Assert
        Assert.Equal(expectedValue, result.totalISR, 4);
    }
}


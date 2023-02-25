using TecNM.Practica3.Core.Entities;

namespace TecNM.Practica3.Core.Services.Interfaces;

public interface ICalculatorISRService{
    CalculatorISR ProcessISR(Person person);
}
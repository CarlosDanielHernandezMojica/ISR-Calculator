using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Managers.Interfaces;
using TecNM.Practica3.Core.Services.Interfaces;

namespace TecNM.Practica3.Core.Managers;

public class CalculatorISRManager : ICalculatorISRManager
{
    private readonly ICalculatorISRService _service;

    public CalculatorISRManager(ICalculatorISRService service){
        _service = service;
    }
    public CalculatorISR GetISR(Person person)
    {
        return _service.ProcessISR(person);
    }
}
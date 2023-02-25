using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Managers;
using TecNM.Practica3.Core.Services;

namespace TecNM.Practica3.App;

public static class Program{
    public static void Main(string [] args){
        float Income;

        System.Console.WriteLine("Please enter your gross income: ");
        Single.TryParse(System.Console.ReadLine(), out Income);
        
        var person = new Person(){Income = Income};

        var service = new CalculatorISRService();
        var manager = new CalculatorISRManager(service);

        CalculatorISR isr = manager.GetISR(person);

        System.Console.WriteLine($"Your total ISR is {isr.totalISR}");
    }


}
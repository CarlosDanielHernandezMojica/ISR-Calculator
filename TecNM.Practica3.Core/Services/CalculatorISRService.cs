using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Services.Interfaces;

namespace TecNM.Practica3.Core.Services;

public class CalculatorISRService : ICalculatorISRService
{
    public CalculatorISR ProcessISR(Person person)
    {  
        var calculatorISR = new CalculatorISR();
        var grossIncome = person.Income;

        if (grossIncome >= 0.01f && grossIncome <= 7735.0f)
        {
            calculatorISR.totalISR = CalculateISR(0.01f, 1.92f, grossIncome, 0.0f);
        }
        else if (grossIncome >= 7735.01f && grossIncome <= 65651.07f)
        {
            calculatorISR.totalISR = CalculateISR(7735.01f, 6.40f, grossIncome, 148.51f);
        }
        else if (grossIncome >= 65651.08f && grossIncome <= 115375.90f)
        {
            calculatorISR.totalISR = CalculateISR(65651.08f, 10.88f, grossIncome, 3855.14f);
        }
        else if (grossIncome >= 115375.91f && grossIncome <= 134119.41f)
        {
            calculatorISR.totalISR = CalculateISR(115375.91f, 16.00f, grossIncome, 9265.20f);
        }
        else if (grossIncome >= 134119.42f && grossIncome <= 160577.65f)
        {
            calculatorISR.totalISR = CalculateISR(134119.42f, 17.92f, grossIncome, 12264.16f);
        }
        else if (grossIncome >= 160577.66f && grossIncome <= 323862.00f)
        {
            calculatorISR.totalISR = CalculateISR(160577.66f, 21.36f, grossIncome, 17005.47f);
        }
        else if (grossIncome >= 323862.01f && grossIncome <= 510451.00f)
        {
            calculatorISR.totalISR = CalculateISR(323862.01f, 23.52f, grossIncome, 51883.01f);
        }
        else if (grossIncome >= 510451.01f && grossIncome <= 974535.03f)
        {
            calculatorISR.totalISR = CalculateISR(510451.01f, 30.00f, grossIncome, 95768.74f);
        }
        else if (grossIncome >= 974535.04f && grossIncome <= 1299380.04f)
        {
            calculatorISR.totalISR = CalculateISR(974535.04f, 32.00f, grossIncome, 234993.95f);
        }
        else if (grossIncome >= 1299380.05f && grossIncome <= 3898140.12f)
        {
            calculatorISR.totalISR = CalculateISR(1299380.05f, 34.00f, grossIncome, 338994.34f);
        }
        else if (grossIncome >= 3898140.13f)
        {
            calculatorISR.totalISR = CalculateISR(3898140.13f, 35.00f, grossIncome, 1222522.76f);
        }

        

        return calculatorISR;
    }

    private float CalculateISR(float lowerLimit, float percentage, float income, float fixedFee){
        var Base = (income - lowerLimit);
        var Result = Base * (percentage / 100);
        var ISR = Result + fixedFee;
        return ISR;
    }
}
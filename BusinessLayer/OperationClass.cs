using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BusinessLayer
{
    public class OperationClass
    {
        // Design By Jean Carlos Reyes
        public decimal resultado { get; set; } = 0;
        public bool resultadoDado { get; set; } = false;
        public decimal BasicOperation(decimal numero)
        {
            switch (SingletonChar.singleton.signo)
            {
                case "+":
                    if (resultadoDado == false)
                    {
                        resultadoDado = true;
                        resultado = (SingletonChar.singleton.SaveNumber + SingletonChar.singleton.LastNumber);
                    }
                    else
                    {
                        resultado = (SingletonChar.singleton.SaveNumber + numero);
                    }
                    return resultado;
                case "-":
                    if (resultadoDado == false)
                    {
                        resultadoDado = true;
                        resultado = (SingletonChar.singleton.SaveNumber - SingletonChar.singleton.LastNumber);
                    }
                    else
                    {
                        resultado = (SingletonChar.singleton.SaveNumber - numero);
                    }
                    return resultado;
                case "×":
                    if (resultadoDado == false)
                    {
                        resultadoDado = true;
                        resultado = (SingletonChar.singleton.SaveNumber * SingletonChar.singleton.LastNumber);
                    }
                    else
                    {
                        resultado = (SingletonChar.singleton.SaveNumber * numero);
                    }
                    return resultado;

                case "÷":
                    if (resultadoDado == false)
                    {
                        resultadoDado = true;
                        resultado = (SingletonChar.singleton.SaveNumber / SingletonChar.singleton.LastNumber);
                    }
                    else
                    {
                        resultado = (SingletonChar.singleton.SaveNumber / numero);
                    }
                    return resultado;
                default:
                    return 0;
            }
        }

        public BigInteger ComplexCalc(string btn,decimal numero)
        {
            switch (btn)
            {
                case "n!":
                    BigInteger result = 1;
                    if (numero == 0)
                    {
                        return 1;
                    }
                    else
                    {
                        for (long i = 1; i < numero; i++)
                        {
                            result += result * i;
                        }
                        return result;
                    }

                case "x^2":
                    return Convert.ToInt64(Math.Pow(Convert.ToDouble(numero),2));
                default:
                    return 0;
            }
        }
        public string AdvancedOperation(decimal numero)
        {
            switch (SingletonChar.singleton.func)
            {
                case "mod":
                    if (resultadoDado == false)
                    {
                        resultadoDado = true;
                        return $"{SingletonChar.singleton.SaveNumber % SingletonChar.singleton.LastNumber}";
                    }
                    else
                    {
                        return $"{SingletonChar.singleton.SaveNumber % numero}";
                    }

                case "|x|":
                    return $"{Math.Abs(numero)}";
                case "e":
                    return $"{Math.E}";
                case "1/x":
                    return $"{1/numero}";
                case "𝝿":
                    return $"{Math.PI}";
                case "sqrt":
                    return $"{Math.Sqrt(Convert.ToDouble(numero))}";
                case "^":
                    if (resultadoDado == false)
                    {
                        resultadoDado = true;
                         
                        return $"{Math.Pow((double)SingletonChar.singleton.SaveNumber, (double)SingletonChar.singleton.LastNumber)}";
                    }
                    else
                    {
                        return $"{Math.Pow((double)SingletonChar.singleton.SaveNumber, (double)numero)}";
                    }
                case "10^x":
                    if (Math.Pow(10, (double)numero)>30)
                    {
                        return Math.Pow(10, (double)numero).ToString();
                    }
                    else
                    {
                        return Math.Pow(10, (double)numero).ToString("n0");
                    }
                case "log10":
                    return Math.Log10((double)numero).ToString();
                case "ln":
                    return Math.Log((double)numero).ToString();
                case "+/_":
                    return $"{numero*-1}";
                default:
                    return "0";
            }

        }
    }
    // Design By Jean Carlos Reyes
}
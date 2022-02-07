using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public sealed class SingletonChar
    {
        // Design By Jean Carlos
        public static SingletonChar singleton { get; } = new SingletonChar();
        public string text = "";
        public decimal LastNumber = 0;
        public decimal SaveNumber = 0;
        public string signo = "";
        public string func = "";
        public bool Btnresultado = false;
        public decimal resultado = 0;
        public bool fue1sobrex = false;
        private SingletonChar(){

}
    }
}
// Design By Jean Carlos Encarnacion

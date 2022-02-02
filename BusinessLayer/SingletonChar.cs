using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public sealed class SingletonChar
    {
        public static SingletonChar singleton { get; } = new SingletonChar();
        public string text = "";
        private SingletonChar(){

}
    }
}

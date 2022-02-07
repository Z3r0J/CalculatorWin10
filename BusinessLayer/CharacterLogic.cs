using System;

namespace BusinessLayer
{
    public class CharacterLogic
    {
        public bool PointExist(char character,string texto)
        {
            bool PointHere = false;
            foreach (char item in texto)
            {
                if (item == character)
                {
                    PointHere = true;
                }
            }
            return PointHere;
        }

        public static bool MinusExist(char character, string texto)
        {
            bool PointHere = false;
            foreach (char item in texto)
            {
                if (item == character)
                {
                    PointHere = true;
                }
            }
            return PointHere;
        }
        public string AddPoint(char character, string texto)
        {
            if (texto == "0")
            {
                if (character == '.')
                {
                    SingletonChar.singleton.text = texto;
                    SingletonChar.singleton.text += character;
                    return SingletonChar.singleton.text;
                }
                else
                {
                    SingletonChar.singleton.text = "";
                    SingletonChar.singleton.text += character;
                    return SingletonChar.singleton.text;
                }
            }
            else
            {
                SingletonChar.singleton.text = texto;
                SingletonChar.singleton.text += character;
                return SingletonChar.singleton.text;
            }
        }
            public decimal AddCharacter(char character,string texto)
        {
            if (texto == "0")
            {
                if (character == '.')
                {
                    SingletonChar.singleton.text += character;
                    return Convert.ToDecimal(SingletonChar.singleton.text);
                }
                else
                {
                    SingletonChar.singleton.text = "";
                    SingletonChar.singleton.text += character;
                    return Convert.ToDecimal(SingletonChar.singleton.text);
                }
            }
            else
            {
                SingletonChar.singleton.text += character;
                return Convert.ToDecimal(SingletonChar.singleton.text);
            }
        }
        public string CE(string texto)
        {
            if (texto=="0")
            {
                return "C";
            }
            else
            {
                return "CE";
            }
        }
    }
}

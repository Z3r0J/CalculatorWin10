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
        public string AddCharacter(char character,string texto)
        {
            if (texto == "0")
            {
                if (character == '.')
                {
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
                SingletonChar.singleton.text += character;
                return SingletonChar.singleton.text;
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

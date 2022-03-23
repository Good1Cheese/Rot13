using System.Text;

namespace Rot13
{
    public abstract class Rot13Converter
    {
        public const string ALPHABET = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public const int LETTER_OFFSET = 13;

        public string Convert(StringBuilder phrase)
        {
            for (int i = 0; i < phrase.Length; i++)
            {
                string upperedLetter = phrase[i].ToString().ToUpper();
                int letterIndex = ALPHABET.IndexOf(upperedLetter);

                if (letterIndex == -1) { continue; }

                letterIndex = GetNewLetterIndex(letterIndex);

                phrase[i] = GetNewLetterWithRightCase(letterIndex, phrase[i]);
            }

            return phrase.ToString();
        }

        protected abstract int GetNewLetterIndex(int letterIndex);

        protected char GetNewLetterWithRightCase(int letterIndex, char oldLetter)
        {
            if (char.IsUpper(oldLetter))
            {
                return ALPHABET[letterIndex];
            }

            string loweredLetter = ALPHABET[letterIndex].ToString().ToLower();
            return char.Parse(loweredLetter);
        }
    }
}
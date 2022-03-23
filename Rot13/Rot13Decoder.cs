namespace Rot13
{
    public class Rot13Decoder : Rot13Converter
    {
        protected override int GetNewLetterIndex(int letterIndex)
        {
            letterIndex -= LETTER_OFFSET;

            if (letterIndex < 0)
            {
                letterIndex += ALPHABET.Length;
            }

            return letterIndex;
        }
    }
}
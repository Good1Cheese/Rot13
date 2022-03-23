namespace Rot13
{
    public class Rot13Encoder : Rot13Converter
    {
        protected override int GetNewLetterIndex(int letterIndex)
        {
            letterIndex += LETTER_OFFSET;

            if (letterIndex >= ALPHABET.Length)
            {
                letterIndex %= ALPHABET.Length;
            }

            return letterIndex;
        }
    }
}
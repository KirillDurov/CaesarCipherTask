using System;

public class CaesarCipher
{
    //symbols of the English alphabet
    const string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    private string CodeEncode(string text, int k)
    {
        //add small letters to the alphabet
        var fullAlfabet = alfabet + alfabet.ToLower();
        var letterQty = fullAlfabet.Length;
        var retVal = "";
        for (int i = 0; i < text.Length; i++)
        {
            var c = text[i];
            var index = fullAlfabet.IndexOf(c);
            if (index < 0)
            {
                //if the symbol is not found, we add it as it is
                retVal += c.ToString();
            }
            else
            {
                var codeIndex = (letterQty + index + k) % letterQty;
                retVal += fullAlfabet[codeIndex];
            }
        }

        return retVal;
    }

    //text encryption
    public string Encrypt(string plainMessage, int key)
        => CodeEncode(plainMessage, key);

    //text decryption
    public string Decrypt(string encryptedMessage, int key)
        => CodeEncode(encryptedMessage, -key);
}

class Program
{
    static void Main(string[] args)
    {
        var cipher = new CaesarCipher();
        Console.Write("Enter Text: ");
        var message = Console.ReadLine();
        Console.Write("Enter Key: ");
        var secretKey = Convert.ToInt32(Console.ReadLine());
        var encryptedText = cipher.Encrypt(message, secretKey);
        Console.WriteLine("Encrypted Message: {0}", encryptedText);
        Console.WriteLine("Decrypted Message: {0}", cipher.Decrypt(encryptedText, secretKey));
        Console.ReadLine();
    }
}
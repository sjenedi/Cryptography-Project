using System;

/**
 * @author Sami Jenedi
 * Class Program will encrypt and decrypt integer values.
 */
public class Program
{
  public static void Main(string[] args)
  {
    int numToEncrypt;
    int numToDecrypt;
    int encryptedData;
    int decryptedData;

    // Prompt user to enter an integer to be encrypted.
    do
    {
      Console.Write("Please enter a non negative integer to encrypt: ");
      numToEncrypt = Convert.ToInt32(Console.ReadLine());
    } while (numToEncrypt < 0);
    encryptedData = ((numToEncrypt / 1000 + 7) % 10) * 10;
    encryptedData = encryptedData + ((numToEncrypt % 1000 / 100 + 7) % 10) * 1;
    encryptedData = encryptedData + ((numToEncrypt % 100 / 10 + 7) % 10) * 1000;
    encryptedData = encryptedData + ((numToEncrypt % 100 / 1 + 7) % 10) * 100;
    Console.WriteLine("Encrypted integer: {0:D4}", encryptedData);

    // Prompt user to enter an integer to be decrypted.
    do
    {
      Console.Write("Please enter a non negative integer to decrypt: ");
      numToDecrypt = Convert.ToInt32(Console.ReadLine());
    } while (numToDecrypt < 0);
    decryptedData = (( numToDecrypt / 1000 + 3) % 10) * 10;
    decryptedData = decryptedData + ((numToDecrypt % 1000 / 100 + 3) % 10) * 1;
    decryptedData = decryptedData + ((numToDecrypt % 100 / 10 + 3) % 10) * 1000;
    decryptedData = decryptedData + ((numToDecrypt % 10 / 1 + 3) % 10) * 100;
    Console.WriteLine("Decrypted integer: {0:D4}", decryptedData);
  } // end Main
} // end class

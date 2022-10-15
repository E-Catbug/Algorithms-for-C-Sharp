namespace Algorithms {

  public class Encrypter {
    public static string DecryptString(string encryptedString)
    {
            byte[] bytes = System.Convert.FromBase64String(encryptedString);
            string decrypted = System.Text.Encoding.ASCII.GetString(bytes);

            return decrypted;
     }

     public static string EncryptString(string stringToEncrypt)
     {
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(stringToEncrypt);
            string encrypted = System.Convert.ToBase64String(bytes);
            return encrypted;
     }
  }

}

using System.Text;
using System.Security.Cryptography;

namespace CriptografiaSha512
{
    public class Sha512
    {
        public string Criptografar(string valor)
        {


            // Converter a string de entrada em um array de bytes
            byte[] bytes = Encoding.UTF8.GetBytes(valor);

            // Criar uma instância de SHA-512
            using (SHA512 sha512 = SHA512.Create())
            {
                // Gerar o hash
                byte[] hashBytes = sha512.ComputeHash(bytes);

                // Converter o hash em uma string hexadecimal
                StringBuilder hashString = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashString.Append(b.ToString("x2"));
                }

                return hashString.ToString();

            }
        }

    }
}

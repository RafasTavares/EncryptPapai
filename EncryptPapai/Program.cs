using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptPapai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha desejada: ");
            var senha = Console.ReadLine();
            Console.WriteLine("Digite seu login: ");
            var usuario = Console.ReadLine();

            byte[] byteRepresentation = UnicodeEncoding.UTF8.GetBytes(senha + usuario);
            byte[] hashedTextInBytes = null;
            System.Security.Cryptography.SHA1CryptoServiceProvider mySHA1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            hashedTextInBytes = mySHA1.ComputeHash(byteRepresentation);
            var senhaCrypt = Convert.ToBase64String(hashedTextInBytes);

            Console.WriteLine("Papai, sua senha é: ");
            Console.WriteLine(senhaCrypt);
            
            Console.WriteLine("Pressione qualquer tecla para sair :*");
            Console.ReadLine();

        }
    }
}

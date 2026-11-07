namespace Projeto_Dudu;

class Program
{
    static void Main()
    {
        int opcao =-1;
        while(opcao != 0)
        {
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - listar usuários");
            Console.WriteLine("3 - buscar");
            Console.WriteLine("0 - sair");
            opcao =int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Usuarios.Cadrastar(); break;
                case 2: Usuarios.Listar(); break;
                case 3: Usuarios.buscar();break;
            }
        }
    }
}

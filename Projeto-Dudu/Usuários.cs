class Usuarios
{
    //public: outras classes podem chamar
    //static: chama-se pelo nome da classe, sem criar objeto

    public static List<string> nomes = new List<string>();
    public static List<string> logins = new List<string>();
    public static List<string> senhas = new List<string>();

    public static void Cadrastar()
    {
      Console.Write("Nome:");
      string nome = Console.ReadLine();
      Console.Write("usuario:");
      string login = Console.ReadLine();
      Console.Write("senha (minimo 4 caracteres):");
      string senha = Console.ReadLine();

      if (login == ""|| senha.Length < 4)
        {
            Console.WriteLine("dados invalidos");
        }
        else if (logins.Contains(login))
        {
            Console.WriteLine("Esse usuario ja existe!");
        }
        else
        {
            nomes.Add(nome);
            logins.Add(login);
            senhas.Add(senha);
            Console.WriteLine("usuarios cadrastado");

        }

    }

    public static void Listar()
    {
        if (nomes.Count == 0)
        {
        Console.WriteLine("nenhum usuario cadastrado");
        return;    
        }
        for ( int i = 0; i < nomes.Count; i++)
        {
            // a sneha nunca é mostrada
            Console.WriteLine((i + 1) + ". " + nomes[i] + "(" + logins[i] + ")");
        }

    }

     public static void buscar()
    {
        Console.Write("buscar por nome: ");
        string termo = Console.ReadLine().ToLower();
        bool encontrado = false;

        for (int i = 0; i < nomes.Count; i++)
        {
            if (nomes[i].ToLower().Contains(termo))
            {
                Console.WriteLine(nomes[i] + "(" + logins[i] + ")");
                encontrado = true;
            }
        }

        if(encontrado == false)
        {
            Console.WriteLine("nenhum usuario encontrado");
        }
    }

}
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
      string semha = Console.ReadLine();

    }

    public static void Listar()
    {
    }
}
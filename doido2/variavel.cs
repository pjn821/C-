// dados pessoais 
        string name;
        int idade;
        char sexo;
        string profissao;
        double salario;

        // input
        Console.WriteLine("Digite os seus dados.");

        Console.WriteLine("Name: ");
        name = Console.ReadLine();

        Console.WriteLine("Idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sexo: ");
        sexo = Console.ReadLine()[0];

        Console.WriteLine("Profissão: ");
        profissao = Console.ReadLine();

        Console.WriteLine("Salário: ");
        salario = Convert.ToDouble(Console.ReadLine());

        // saída/display
        Console.WriteLine("Olá, " + name + " . Segue abaixo os teus dados");
        Console.WriteLine("Idade: " + idade + " anos");
        Console.WriteLine("Sexo: " + sexo);
        Console.WriteLine("Profissão: " + profissao);
        Console.WriteLine("Salário: " + salario + "€");
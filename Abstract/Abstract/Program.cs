using Abstract;

internal class Program {
    private static void Main(string[] args) {

        PessoaFisica pessoaFisica;
        PessoaJuridica pessoaJuridica;

        Console.WriteLine("Qual o numero de pessoas você deseja informar?");
        int parada =  Convert.ToInt32(Console.ReadLine());
        List<Pessoa> lista = new List<Pessoa>();

        for (int i = 0; i < parada; i++) {
            Console.WriteLine("Pessoa Fisica  ou Juridica (f/j)?");
            if (Console.ReadLine() == "f") {
                Console.WriteLine("Digite o Nome!");
                string nome = Console.ReadLine().ToString();
                Console.WriteLine("Digite a Renda!");
                double renda = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite os Gastos Médicos");
                double gastosMedicos =  Convert.ToInt32(Console.ReadLine());
                Pessoa pessoaF = new PessoaFisica(nome,renda,gastosMedicos);
                lista.Add(pessoaF);
            } else {
                Console.WriteLine("Digite o Nome!");
                string nome = Console.ReadLine().ToString();
                Console.WriteLine("Digite a Renda!");
                double renda = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de funcionarios!");
                int funcionarios = Convert.ToInt32(Console.ReadLine());
                Pessoa pessoaF = new PessoaJuridica(nome, renda, funcionarios);
                lista.Add(pessoaF);
            }
        }
        foreach (var item in lista) {
            Console.WriteLine(item.ToString());

        }


    }
}
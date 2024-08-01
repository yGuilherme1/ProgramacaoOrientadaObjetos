Conta conta1 = new(1, "0001", "João Santos Silva", 8000);
ContaEstudante conta2 = new(1500, "11122233300", "IFRO", 2, "0002", "Pedro Gomes", 500);

conta1.Sacar(6000);
conta2.Sacar(500);

Console.ReadKey();
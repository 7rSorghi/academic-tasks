int[,] matriz = new int[3, 3];
        int somapc = 0;
        int produto;
        int somam = 0;
        int somadp;

        // Leitura dos elementos da matriz
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Elemento a[{i}][{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        somadp = matriz[0, 0];
        produto = matriz[0, 0];

        for (int ct = 0; ct < 3; ct++)
        {
            somapc += matriz[ct, 0]; // Soma da primeira coluna

            for (int k = 0; k < 3; k++)
            {
                somam += matriz[ct, k]; // Soma de todos os elementos
            }

            if (ct > 0)
            {
                somadp += matriz[ct, ct]; // Soma da diagonal principal
                produto *= matriz[0, ct]; // Produto da primeira linha
            }
        }

        // Impressão dos resultados
        Console.WriteLine($"\nSoma da primeira coluna: {somapc}");
        Console.WriteLine($"Produto da primeira linha: {produto}");
        Console.WriteLine($"Soma de todos os elementos: {somam}");
        Console.WriteLine($"Soma da diagonal principal: {somadp}");
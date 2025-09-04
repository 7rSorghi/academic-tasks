programa
{
	funcao inicio()
	{
		inteiro matriz[3][2]
		para(inteiro i = 0; i < 3; i++)//linha
		{
			para(inteiro j = 0; j<2; j++)//coluna
			{
				escreva("Elemento a", i, j, ":")
				leia(matriz[i][j])
			}
		}
		para(inteiro i = 0; i < 3; i++)
		{
			para(inteiro j = 0; j<2; j++)
			{
				escreva("Elemento a", i, j, ": ", matriz[i][j])
			}
		}
	}
}

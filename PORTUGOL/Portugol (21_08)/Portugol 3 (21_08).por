programa
{
	funcao inicio()
	{
		inteiro i, j, temp
		inteiro A[50]
		para (i = 0; i < 50; i++)
		{
			escreva("Digite o ", i + 1, "º número: ")
			leia(A[i])
		}

		para (i = 0; i < 49; i++)
			para (j = i + 1; j < 50; j++)
				se (A[i] > A[j])
				{
					temp = A[j]
					A[j] = A[i]
					A[i] = temp
				}

		escreva("Ordem crescente: ")
		para (i = 0; i < 50; i++)
			escreva(A[i], " ")

		escreva("\nOrdem decrescente: ")
		para (i = 49; i >= 0; i--)
			escreva(A[i], " ")
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 67; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
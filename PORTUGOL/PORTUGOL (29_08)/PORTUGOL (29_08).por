programa
{
	funcao inicio()
	{
		//Insertion Sort

		inteiro i,j,chave
		inteiro A[5] = {5, 3, 4, 1, 2}

		para (i=1;i<=4;i++)
		{
			chave = A[i]
			j = i-1
			enquanto (j>=0 e A[j] > chave)
			{
				A[j+1] = A[j]
				j = j -1
			}
			A[j+1] = chave	
		}

		escreva ("Insertion Sort: ")
		para (i = 0; i <= 4;i++)
		{
			escreva (A[i], " ")
		}
	}
}
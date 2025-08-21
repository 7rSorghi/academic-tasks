programa
{
	funcao inicio()
	{
	inteiro i,j,temp

	inteiro A[5] = {5, 3, 4,1,2}

	//bubble sort

	para (i = 0;i<=3;i++)
		para (j=i + 1;j<=4;j++)
			se (A[i]>A[j])
			{
				temp = A[j]
				A[j]=A[i]
				A[i]=temp
				}
	escreva ("bubble sort : ")
	para (i = 0;i<=4;i++)
		escreva (A[i]," ")			
					
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 290; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
programa
{
	funcao inicio()
	{
		cadeia nomes[5]
	     real notas[4], media[5], soma[5] , p100rep, p100apro
	     inteiro i , ct , rep = 0 , apro = 0

	     para (i=0;i<=4;i++)
	     {
	     	escreva("\nEscreva o ",i+1,"º nome: \n")
	     	leia(nomes[i])
	     	para (ct=0;ct<=3;ct++)
	     	{
	     		escreva ("\nEscreva a ", ct+1,"º nota:\n")
	     		leia (notas[ct])
	     		soma[i] += notas[ct]
	     		media[i] = soma[i] / 4
	     	}
	     }
	     para (i=0; i<=4; i++)
	     {
	     	se (media[i] >= 7.0)
	     	{
	     		escreva(nomes[i], " foi aprovado com media ",media[i], "\n")
	     		apro = apro+1.0
	     	}
	     	se (media[i] >= 5.0 e media[i] < 7.0) 
	     	{
	     		escreva(nomes[i], " ficou em recuperação com media ", media[i], "\n")
	     		rep = rep+1.0
	     	}	
	     	se (media[i] < 5.0)
	     	{
	     		escreva(nomes[i], " foi reprovado com media ",media[i], "\n")
	     		rep = rep+1.0
	     	}
	     }
	     p100apro = (apro/5.0)*100.0
	     p100rep = (rep/5.0)*100.0
			escreva("A porcentagem de alunos aprovados é ", p100apro, "%", "\n")
			escreva("A porcentagem de alunos reprovados ou em recuperação é ", p100rep, "%", "\n")     
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1119; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {nomes, 5, 9, 5}-{notas, 6, 11, 5}-{media, 6, 21, 5}-{soma, 6, 31, 4}-{p100rep, 6, 41, 7}-{p100apro, 6, 50, 8}-{rep, 7, 23, 3}-{apro, 7, 33, 4};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
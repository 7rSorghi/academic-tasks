programa
{
	funcao inicio()
	{
		cadeia nome[5]
		real salario[5]
		para(inteiro i =0; i<=4; i++)
		{
			escreva("\nEscreva o nome do ", i+1, "� funcion�rio: ")
			leia(nome[i])
			escreva("\nEscreva o sal�rio do ",nome[i],": ")
			leia(salario[i])
		}
		para (inteiro ct = 0; ct<=4; ct++)
		{
			se (salario[ct] >500.0)
			{
				escreva("\nO sal�rio do funcion�rio ",nome[ct]," � acima de R$500,00")				
			}
			se (salario[ct] <=500.0)
			{
				escreva("\nO sal�rio do funcion�rio ",nome[ct]," recebeu um aumento de 20% por ser menor que R$500,00. Agora seu sal�rio � R$",salario[ct]*1.20)
			}
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta se��o do arquivo guarda informa��es do Portugol Studio.
 * Voc� pode apag�-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 458; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 */
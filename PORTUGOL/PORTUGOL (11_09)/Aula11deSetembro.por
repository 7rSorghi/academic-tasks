programa
{
	funcao inicio()
	{
		
		inteiro matriz[3][3] = {{1,2,3}, {4,5,6}, {7, 8, 9}}, n = 3, soma = 0, diferenca = 0, sec = 0, pc = 0

		para (inteiro i = 0; i<3	; i++){
			escreva(matriz[i][n-1-i])
			sec +=  matriz[i][n-1-i]
			pc += matriz[i][i]

		}
		diferenca =  pc - sec
		
		escreva("\n")
		escreva("A diferença é: ", diferenca)
		escreva("\n")
		para(inteiro j = 0; j<3; j++){
			para(inteiro ct = 0; ct<3; ct++){
				soma += matriz[j][ct]
			}
			escreva(soma, "\n")
			soma = 0
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 329; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
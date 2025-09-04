programa
{
	funcao inicio()
	{
		inteiro matriz[3][3], somapc = 0, produto, somam = 0, somadp
		para(inteiro i = 0; i < 3; i++)
		{
			para(inteiro j = 0; j<3; j++)
			{
				escreva("Elemento a", i, j, ":")
				leia(matriz[i][j])
			}
		}
		somadp = matriz[0][0]
		produto = matriz[0][0]
		para(inteiro ct = 0; ct<3; ct++)
		{
			somapc += matriz[ct][0]
			para(inteiro k = 0; k<3; k++)
			{
				somam += matriz[ct][k]
			}
			se(ct>0){
			somadp += matriz[ct-1][ct]
			produto *= matriz[0][ct]
			}
		}
		escreva("\nSoma da primeira coluna: ", somapc)
		escreva("\nProduto da primeira linha: ", produto)
		escreva("\nSoma de todos os elementos: ", somam)
		escreva("\nSoma da diagonal principal: ", somadp)
	}
}

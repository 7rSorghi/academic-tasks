programa
{
	funcao inicio()
	{
		/* Faça um algoritmo/programa que leia 10 nomes a partir do teclado.
		 *  Em seguida receba um nome e verifique se ele se encontra entre os nomes inseridos no vetor
		 */
		cadeia vetor[10], nome
        	inteiro i, j
        	logico encontrado = falso

        	para(i = 0; i < 10; i++)
        	{
            	escreva("Digite o ", i + 1, "º nome: ")
            	leia(vetor[i])
        	}
		escreva("\n---------------------------------------------")
		escreva("\nEscreva o nome que deseja verificar se está na lista: ")
		leia(nome)
        	para(i = 0; i < 10; i++)
        	{
			se(nome == vetor[i])
              	{
               	encontrado = verdadeiro
        		}

        	}	
        	se (encontrado == verdadeiro)
        	{
        		escreva("\nO nome ", nome," está na lista.")
        	}
        	senao 
        	{
        		escreva("O nome ", nome, " não está na lista.")
        	}
	}
}
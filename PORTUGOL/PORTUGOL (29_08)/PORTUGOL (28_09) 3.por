programa 
{
 	funcao inicio() 
 	{
 		// Método de ordenação: Selection Sort
 		

  		inteiro i, j, min, temp
  		inteiro A[9] = {1, 2, 3, 4, 5, 6, 7, 8, 9}

 		/* 
 		para(i = 0; i <= 7; i++)
  		{
    			min = i
    			para(j = i+1; j <= 8; j++)
    			{
      			se (A[j] < A[min])
      			{
        				min = j
      			}
    			}
    			temp = A[i]
    			A[i] = A[min]
    			A[min] = temp
  		}
		*/
  		// Binario


  		inteiro comeco, fim, meio, pesq
  		logico encontrou = falso
  		comeco = 0
  		fim = 9
  		pesq = 6
  		enquanto (comeco <= fim e nao encontrou)
  		{
  			meio = (comeco + fim) /2
  			se (pesq == A[meio])
  			{
  				encontrou = verdadeiro	
  			}
  			senao se (pesq < A[meio]) {
  				fim = meio-1
  			}
  			senao {
  				comeco = meio + 1
  			}
  		}
  		escreva("Resultado da busca binária: valor ", pesq, " encontrado na posição ", meio + 1, " (índice ", meio, ") do vetor ordenado.")
  	}
}

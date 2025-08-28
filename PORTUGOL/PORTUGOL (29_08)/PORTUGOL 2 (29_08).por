programa 
{
 	funcao inicio() 
 	{
 		//Selection Sort

  		inteiro i, j, min, temp
  		inteiro A[5] = {5, 3, 4, 1, 2}

 		para(i = 0; i <= 3; i++)
  		{
    			min = i
    			para(j = i+1; j <= 4; j++)
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

  		escreva("Selection Sort:")
  		para(i = 0; i<= 4; i++)
  		{
    			escreva(A[i], " ")
  		}
  	}
}

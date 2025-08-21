programa
{
    funcao inicio()
    {
        inteiro vetor[10]
        inteiro i, j, contador
        logico repetido

        para(i = 0; i < 10; i++)
        {
            escreva("Digite o valor ", i + 1, ": ")
            leia(vetor[i])
        }

        escreva("\nRelatório de valores:")

        para(i = 0; i < 10; i++)
        {
            repetido = falso

            para(j = 0; j < i; j++)
            {
                se(vetor[i] == vetor[j])
                {
                    repetido = verdadeiro
                    pare
                }
            }

            se(repetido == falso)
            {
                contador = 0
                para(j = 0; j < 10; j++)
                {
                    se(vetor[i] == vetor[j])
                    {
                        contador = contador + 1
                    }
                }
                escreva("\nValor ", vetor[i], " apareceu ", contador, " vez(es).")
            }
        }
    }
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 984; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {vetor, 5, 16, 5}-{i, 6, 16, 1}-{j, 6, 19, 1}-{contador, 6, 22, 8}-{repetido, 7, 15, 8};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
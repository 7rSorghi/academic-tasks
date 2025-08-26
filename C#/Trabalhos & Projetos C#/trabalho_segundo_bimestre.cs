// CTII 117
// ALUNOS:
// FELIPE SORGHI DE SIQUEIRA
// ARTHUR JESUS COSTA DO NASCIMENTO



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    enum Categoria
    {
        Informatica = 1,
        Acessorios = 2,
        Papelaria = 3,
        Telefonia = 4
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // PRODUTOS FIXOS
            int codigo1 = 101, estoque1 = 12;
            int codigo2 = 102, estoque2 = 15;
            int codigo3 = 103, estoque3 = 2;
            int codigo4 = 104, estoque4 = 8;
            int codigo5 = 105, estoque5 = 4;

            string nome1 = "Teclado RGB", nome2 = "Mouse Gamer", nome3 = "Caneta Azul", nome4 = "Carregador USB-C", nome5 = "Cabo USB";

            Categoria categoria1 = Categoria.Informatica;
            Categoria categoria2 = Categoria.Informatica;
            Categoria categoria3 = Categoria.Papelaria;
            Categoria categoria4 = Categoria.Telefonia;
            Categoria categoria5 = Categoria.Acessorios;

            double preco1 = 100.00, preco2 = 80.00, preco3 = 2.50, preco4 = 60.00, preco5 = 12.00;

            // CONTROLE DE VENDAS E PROMOÇÃO
            int totalVendas = 0, totalProdutosVendidos = 0;
            double faturamentoBruto = 0, totalDescontos = 0, ultimaVenda = 0, maiorVenda = 0, menorVenda = 999999;
            int vendasComDesconto = 0;

            bool promocaoAtiva = false;
            Categoria categoriaPromo = Categoria.Informatica;
            int descontoPromo = 0;
            DateTime fimPromocao = DateTime.MinValue;

            string opcao = "";

            while (opcao != "8")
            {
                // Verificar se a promoção expirou
                if (promocaoAtiva && DateTime.Now >= fimPromocao)
                {
                    promocaoAtiva = false;
                    descontoPromo = 0;
                    Console.WriteLine("Promoção expirada automaticamente.");
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();
                }

                Console.Clear();
                Console.WriteLine("┌─────────────────────────────┐");
                Console.WriteLine("│      INFO STORE MANAGER     │");
                Console.WriteLine("├─────────────────────────────┤");
                Console.WriteLine("│ 1. Cadastrar Produto        │");
                Console.WriteLine("│ 2. Consultar Produto        │");
                Console.WriteLine("│ 3. Listar Todos os Produtos │");
                Console.WriteLine("│ 4. Realizar Venda           │");
                Console.WriteLine("│ 5. Controle de Estoque      │");
                Console.WriteLine("│ 6. Gerenciar Promoção       │");
                Console.WriteLine("│ 7. Relatórios do Dia        │");
                Console.WriteLine("│ 8. Sair                     │");
                Console.WriteLine("└─────────────────────────────┘");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                // ========== OPÇÃO 1 - Cadastrar Produto ==========
                if (opcao == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Produtos fixos já cadastrados no sistema.");
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();
                }

                // ========== OPÇÃO 2 - Consultar Produto ==========
                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.Write("Digite o código do produto: ");
                    int cod;
                    bool codValido = int.TryParse(Console.ReadLine(), out cod);
                    if (!codValido)
                    {
                        Console.WriteLine("Código inválido.");
                    }
                    else if (cod == codigo1)
                    {
                        Console.WriteLine("┌─────────────────────────────┐");
                        Console.WriteLine($"│ Código: {codigo1,-21}│");
                        Console.WriteLine($"│ Nome: {nome1,-23}│");
                        Console.WriteLine($"│ Categoria: {categoria1,-16}│");
                        Console.WriteLine($"│ Preço: R$ {preco1,-18:F2}│");
                        Console.WriteLine($"│ Estoque: {estoque1,-17}│");
                        Console.WriteLine("└─────────────────────────────┘");
                    }
                    else if (cod == codigo2)
                    {
                        Console.WriteLine("┌─────────────────────────────┐");
                        Console.WriteLine($"│ Código: {codigo2,-21}│");
                        Console.WriteLine($"│ Nome: {nome2,-23}│");
                        Console.WriteLine($"│ Categoria: {categoria2,-16}│");
                        Console.WriteLine($"│ Preço: R$ {preco2,-18:F2}│");
                        Console.WriteLine($"│ Estoque: {estoque2,-17}│");
                        Console.WriteLine("└─────────────────────────────┘");
                    }
                    else if (cod == codigo3)
                    {
                        Console.WriteLine("┌─────────────────────────────┐");
                        Console.WriteLine($"│ Código: {codigo3,-21}│");
                        Console.WriteLine($"│ Nome: {nome3,-23}│");
                        Console.WriteLine($"│ Categoria: {categoria3,-16}│");
                        Console.WriteLine($"│ Preço: R$ {preco3,-18:F2}│");
                        Console.WriteLine($"│ Estoque: {estoque3,-17}│");
                        Console.WriteLine("└─────────────────────────────┘");
                    }
                    else if (cod == codigo4)
                    {
                        Console.WriteLine("┌─────────────────────────────┐");
                        Console.WriteLine($"│ Código: {codigo4,-21}│");
                        Console.WriteLine($"│ Nome: {nome4,-23}│");
                        Console.WriteLine($"│ Categoria: {categoria4,-16}│");
                        Console.WriteLine($"│ Preço: R$ {preco4,-18:F2}│");
                        Console.WriteLine($"│ Estoque: {estoque4,-17}│");
                        Console.WriteLine("└─────────────────────────────┘");
                    }
                    else if (cod == codigo5)
                    {
                        Console.WriteLine("┌─────────────────────────────┐");
                        Console.WriteLine($"│ Código: {codigo5,-21}│");
                        Console.WriteLine($"│ Nome: {nome5,-23}│");
                        Console.WriteLine($"│ Categoria: {categoria5,-16}│");
                        Console.WriteLine($"│ Preço: R$ {preco5,-18:F2}│");
                        Console.WriteLine($"│ Estoque: {estoque5,-17}│");
                        Console.WriteLine("└─────────────────────────────┘");
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado.");
                    }
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();
                }

                // ========== OPÇÃO 3 - Listar Produtos ==========
                else if (opcao == "3")
                {
                    Console.Clear();
                    Console.WriteLine("┌──────┬──────────────────────┬─────────────┬────────────┬────────────┐");
                    Console.WriteLine("│ Cód. │ Nome                 │ Categoria   │ Preço (R$) │ Estoque    │");
                    Console.WriteLine("├──────┼──────────────────────┼─────────────┼────────────┼────────────┤");

                    Console.WriteLine($"│ {codigo1,-4} │ {nome1,-20} │ {categoria1,-11} │ {preco1,10:F2} │ {estoque1,10} │");
                    Console.WriteLine($"│ {codigo2,-4} │ {nome2,-20} │ {categoria2,-11} │ {preco2,10:F2} │ {estoque2,10} │");
                    Console.WriteLine($"│ {codigo3,-4} │ {nome3,-20} │ {categoria3,-11} │ {preco3,10:F2} │ {estoque3,10} │");
                    Console.WriteLine($"│ {codigo4,-4} │ {nome4,-20} │ {categoria4,-11} │ {preco4,10:F2} │ {estoque4,10} │");
                    Console.WriteLine($"│ {codigo5,-4} │ {nome5,-20} │ {categoria5,-11} │ {preco5,10:F2} │ {estoque5,10} │");

                    Console.WriteLine("└──────┴──────────────────────┴─────────────┴────────────┴────────────┘");
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();
                }

                // ========== OPÇÃO 4 - Realizar Venda ==========
                else if (opcao == "4")
                {
                    Console.Clear();
                    Console.WriteLine("=== REALIZAR VENDA ===");
                    Console.Write("Código do produto: ");
                    int codVenda;
                    bool codVendaValido = int.TryParse(Console.ReadLine(), out codVenda);
                    if (!codVendaValido)
                    {
                        Console.WriteLine("Código inválido.");
                        Console.WriteLine("Pressione ENTER para continuar...");
                        Console.ReadLine();
                        continue;
                    }

                    // Variáveis para achar produto
                    bool produtoEncontrado = false;
                    string nomeVenda = "";
                    Categoria categoriaVenda = 0;
                    double precoVenda = 0;
                    int estoqueVenda = 0;

                    if (codVenda == codigo1)
                    {
                        produtoEncontrado = true;
                        nomeVenda = nome1;
                        categoriaVenda = categoria1;
                        precoVenda = preco1;
                        estoqueVenda = estoque1;
                    }
                    else if (codVenda == codigo2)
                    {
                        produtoEncontrado = true;
                        nomeVenda = nome2;
                        categoriaVenda = categoria2;
                        precoVenda = preco2;
                        estoqueVenda = estoque2;
                    }
                    else if (codVenda == codigo3)
                    {
                        produtoEncontrado = true;
                        nomeVenda = nome3;
                        categoriaVenda = categoria3;
                        precoVenda = preco3;
                        estoqueVenda = estoque3;
                    }
                    else if (codVenda == codigo4)
                    {
                        produtoEncontrado = true;
                        nomeVenda = nome4;
                        categoriaVenda = categoria4;
                        precoVenda = preco4;
                        estoqueVenda = estoque4;
                    }
                    else if (codVenda == codigo5)
                    {
                        produtoEncontrado = true;
                        nomeVenda = nome5;
                        categoriaVenda = categoria5;
                        precoVenda = preco5;
                        estoqueVenda = estoque5;
                    }

                    if (!produtoEncontrado)
                    {
                        Console.WriteLine("Produto não encontrado.");
                        Console.WriteLine("Pressione ENTER para continuar...");
                        Console.ReadLine();
                        continue;
                    }

                    Console.WriteLine($"Produto encontrado: {nomeVenda}");
                    Console.WriteLine($"Categoria: {categoriaVenda}");
                    Console.WriteLine($"Preço original: R$ {precoVenda:F2}");
                    Console.WriteLine($"Estoque disponível: {estoqueVenda} unidades");

                    Console.Write("Quantidade desejada: ");
                    int qtdVenda;
                    bool qtdValida = int.TryParse(Console.ReadLine(), out qtdVenda);

                    if (!qtdValida || qtdVenda < 1 || qtdVenda > estoqueVenda)
                    {
                        Console.WriteLine("Quantidade inválida ou maior que o estoque disponível.");
                        Console.WriteLine("Pressione ENTER para continuar...");
                        Console.ReadLine();
                        continue;
                    }

                    double precoFinal = precoVenda;
                    bool descontoAplicado = false;

                    if (promocaoAtiva && categoriaVenda == categoriaPromo)
                    {
                        precoFinal = precoVenda * (1 - descontoPromo / 100.0);
                        descontoAplicado = true;
                    }

                    double valorTotal = precoFinal * qtdVenda;

                    Console.WriteLine($"Preço final unitário: R$ {precoFinal:F2}");
                    Console.WriteLine($"Valor total da venda: R$ {valorTotal:F2}");

                    Console.Write("Confirmar venda? (S/N): ");
                    string confirmaVenda = Console.ReadLine().ToUpper();

                    if (confirmaVenda == "S")
                    {
                        // Atualizar estoque
                        if (codVenda == codigo1) estoque1 -= qtdVenda;
                        else if (codVenda == codigo2) estoque2 -= qtdVenda;
                        else if (codVenda == codigo3) estoque3 -= qtdVenda;
                        else if (codVenda == codigo4) estoque4 -= qtdVenda;
                        else if (codVenda == codigo5) estoque5 -= qtdVenda;

                        // Atualizar relatórios
                        totalVendas++;
                        totalProdutosVendidos += qtdVenda;
                        faturamentoBruto += valorTotal;
                        ultimaVenda = valorTotal;

                        if (valorTotal > maiorVenda) maiorVenda = valorTotal;
                        if (valorTotal < menorVenda) menorVenda = valorTotal;
                        if (descontoAplicado) vendasComDesconto++;
                        if (descontoAplicado) totalDescontos += (precoVenda - precoFinal) * qtdVenda;

                        Console.WriteLine("Venda realizada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Venda cancelada.");
                    }
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();
                }

                // ========== OPÇÃO 5 - Controle de Estoque ==========
                else if (opcao == "5")
                {
                    string opcEstoque = "";
                    while (opcEstoque != "4")
                    {
                        Console.Clear();
                        Console.WriteLine("=== CONTROLE DE ESTOQUE ===");
                        Console.WriteLine("1. Adicionar Estoque");
                        Console.WriteLine("2. Remover Estoque");
                        Console.WriteLine("3. Verificar Estoque Baixo");
                        Console.WriteLine("4. Voltar ao Menu Principal");
                        Console.Write("Escolha uma opção: ");
                        opcEstoque = Console.ReadLine();

                        // ADICIONAR ESTOQUE
                        if (opcEstoque == "1")
                        {
                            Console.Clear();
                            Console.Write("Digite o código do produto para adicionar estoque: ");
                            int codAdd;
                            bool codAddValido = int.TryParse(Console.ReadLine(), out codAdd);

                            bool prodEncontradoAdd = false;
                            string nomeAdd = "";
                            int estoqueAtualAdd = 0;

                            if (codAdd == codigo1)
                            {
                                prodEncontradoAdd = true;
                                nomeAdd = nome1;
                                estoqueAtualAdd = estoque1;
                            }
                            else if (codAdd == codigo2)
                            {
                                prodEncontradoAdd = true;
                                nomeAdd = nome2;
                                estoqueAtualAdd = estoque2;
                            }
                            else if (codAdd == codigo3)
                            {
                                prodEncontradoAdd = true;
                                nomeAdd = nome3;
                                estoqueAtualAdd = estoque3;
                            }
                            else if (codAdd == codigo4)
                            {
                                prodEncontradoAdd = true;
                                nomeAdd = nome4;
                                estoqueAtualAdd = estoque4;
                            }
                            else if (codAdd == codigo5)
                            {
                                prodEncontradoAdd = true;
                                nomeAdd = nome5;
                                estoqueAtualAdd = estoque5;
                            }

                            if (!prodEncontradoAdd)
                            {
                                Console.WriteLine("Produto não encontrado.");
                                Console.WriteLine("Pressione ENTER para continuar...");
                                Console.ReadLine();
                                continue;
                            }

                            Console.WriteLine($"Produto: {nomeAdd}");
                            Console.WriteLine($"Estoque atual: {estoqueAtualAdd} unidades");

                            Console.Write("Quantidade a adicionar: ");
                            int qtdAdd;
                            bool qtdAddValida = int.TryParse(Console.ReadLine(), out qtdAdd);
                            if (!qtdAddValida || qtdAdd < 1)
                            {
                                Console.WriteLine("Quantidade inválida.");
                                Console.WriteLine("Pressione ENTER para continuar...");
                                Console.ReadLine();
                                continue;
                            }

                            Console.Write($"Confirmar adição de {qtdAdd} unidades? (S/N): ");
                            string confirmaAdd = Console.ReadLine().ToUpper();

                            if (confirmaAdd == "S")
                            {
                                if (codAdd == codigo1) estoque1 += qtdAdd;
                                else if (codAdd == codigo2) estoque2 += qtdAdd;
                                else if (codAdd == codigo3) estoque3 += qtdAdd;
                                else if (codAdd == codigo4) estoque4 += qtdAdd;
                                else if (codAdd == codigo5) estoque5 += qtdAdd;

                                Console.WriteLine($"Estoque atualizado! Novo saldo: {(codAdd == codigo1 ? estoque1 : codAdd == codigo2 ? estoque2 : codAdd == codigo3 ? estoque3 : codAdd == codigo4 ? estoque4 : estoque5)} unidades");
                            }
                            else
                            {
                                Console.WriteLine("Operação cancelada.");
                            }
                            Console.WriteLine("Pressione ENTER para continuar...");
                            Console.ReadLine();
                        }

                        // REMOVER ESTOQUE
                        else if (opcEstoque == "2")
                        {
                            Console.Clear();
                            Console.Write("Digite o código do produto para remover estoque: ");
                            int codRem;
                            bool codRemValido = int.TryParse(Console.ReadLine(), out codRem);

                            bool prodEncontradoRem = false;
                            string nomeRem = "";
                            int estoqueAtualRem = 0;

                            if (codRem == codigo1)
                            {
                                prodEncontradoRem = true;
                                nomeRem = nome1;
                                estoqueAtualRem = estoque1;
                            }
                            else if (codRem == codigo2)
                            {
                                prodEncontradoRem = true;
                                nomeRem = nome2;
                                estoqueAtualRem = estoque2;
                            }
                            else if (codRem == codigo3)
                            {
                                prodEncontradoRem = true;
                                nomeRem = nome3;
                                estoqueAtualRem = estoque3;
                            }
                            else if (codRem == codigo4)
                            {
                                prodEncontradoRem = true;
                                nomeRem = nome4;
                                estoqueAtualRem = estoque4;
                            }
                            else if (codRem == codigo5)
                            {
                                prodEncontradoRem = true;
                                nomeRem = nome5;
                                estoqueAtualRem = estoque5;
                            }

                            if (!prodEncontradoRem)
                            {
                                Console.WriteLine("Produto não encontrado.");
                                Console.WriteLine("Pressione ENTER para continuar...");
                                Console.ReadLine();
                                continue;
                            }

                            Console.WriteLine($"Produto: {nomeRem}");
                            Console.WriteLine($"Estoque atual: {estoqueAtualRem} unidades");

                            Console.Write("Quantidade a remover: ");
                            int qtdRem;
                            bool qtdRemValida = int.TryParse(Console.ReadLine(), out qtdRem);
                            if (!qtdRemValida || qtdRem < 1 || qtdRem > estoqueAtualRem)
                            {
                                Console.WriteLine("Quantidade inválida ou maior que o estoque disponível.");
                                Console.WriteLine("Pressione ENTER para continuar...");
                                Console.ReadLine();
                                continue;
                            }

                            Console.WriteLine("Motivo da saída:");
                            Console.WriteLine("1. Venda manual");
                            Console.WriteLine("2. Produto danificado");
                            Console.WriteLine("3. Transferência");
                            Console.WriteLine("4. Ajuste de inventário");
                            Console.Write("Escolha: ");
                            string motivoSaida = Console.ReadLine();

                            Console.Write($"Confirmar remoção de {qtdRem} unidades? (S/N): ");
                            string confirmaRem = Console.ReadLine().ToUpper();

                            if (confirmaRem == "S")
                            {
                                if (codRem == codigo1) estoque1 -= qtdRem;
                                else if (codRem == codigo2) estoque2 -= qtdRem;
                                else if (codRem == codigo3) estoque3 -= qtdRem;
                                else if (codRem == codigo4) estoque4 -= qtdRem;
                                else if (codRem == codigo5) estoque5 -= qtdRem;

                                Console.WriteLine($"Estoque atualizado! Novo saldo: {(codRem == codigo1 ? estoque1 : codRem == codigo2 ? estoque2 : codRem == codigo3 ? estoque3 : codRem == codigo4 ? estoque4 : estoque5)} unidades");
                            }
                            else
                            {
                                Console.WriteLine("Operação cancelada.");
                            }
                            Console.WriteLine("Pressione ENTER para continuar...");
                            Console.ReadLine();
                        }

                        // VERIFICAR ESTOQUE BAIXO
                        else if (opcEstoque == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("=== VERIFICAÇÃO DE ESTOQUE BAIXO ===");
                            Console.WriteLine("Verificando todos os produtos cadastrados...");
                            Console.WriteLine("ALERTA: Produtos com estoque baixo (menos de 5 unidades):");

                            int totalAlertas = 0;

                            Console.WriteLine("┌──────┬──────────────────────┬─────────────┬────────────┬────────────┐");
                            Console.WriteLine("│ Cód. │ Nome                 │ Categoria   │ Preço (R$) │ Estoque    │");
                            Console.WriteLine("├──────┼──────────────────────┼─────────────┼────────────┼────────────┤");

                            if (estoque1 < 5)
                            {
                                Console.WriteLine($"│ {codigo1,-4} │ {nome1,-20} │ {categoria1,-11} │ {preco1,10:F2} │ {estoque1,10} │");
                                totalAlertas++;
                            }
                            if (estoque2 < 5)
                            {
                                Console.WriteLine($"│ {codigo2,-4} │ {nome2,-20} │ {categoria2,-11} │ {preco2,10:F2} │ {estoque2,10} │");
                                totalAlertas++;
                            }
                            if (estoque3 < 5)
                            {
                                Console.WriteLine($"│ {codigo3,-4} │ {nome3,-20} │ {categoria3,-11} │ {preco3,10:F2} │ {estoque3,10} │");
                                totalAlertas++;
                            }
                            if (estoque4 < 5)
                            {
                                Console.WriteLine($"│ {codigo4,-4} │ {nome4,-20} │ {categoria4,-11} │ {preco4,10:F2} │ {estoque4,10} │");
                                totalAlertas++;
                            }
                            if (estoque5 < 5)
                            {
                                Console.WriteLine($"│ {codigo5,-4} │ {nome5,-20} │ {categoria5,-11} │ {preco5,10:F2} │ {estoque5,10} │");
                                totalAlertas++;
                            }

                            Console.WriteLine("└──────┴──────────────────────┴─────────────┴────────────┴────────────┘");

                            Console.WriteLine($"Total de produtos em alerta: {totalAlertas}");
                            Console.WriteLine("Pressione ENTER para continuar...");
                            Console.ReadLine();
                        }
                    }
                }

                // ========== OPÇÃO 6 - Gerenciar Promoção ==========
                else if (opcao == "6")
                {
                    string opcPromo = "";
                    while (opcPromo != "4")
                    {
                        Console.Clear();
                        Console.WriteLine("=== GERENCIAR PROMOÇÃO ===");
                        Console.WriteLine("1. Ativar Promoção");
                        Console.WriteLine("2. Consultar Promoção Ativa");
                        Console.WriteLine("3. Desativar Promoção");
                        Console.WriteLine("4. Voltar ao Menu Principal");
                        Console.Write("Escolha uma opção: ");
                        opcPromo = Console.ReadLine();

                        // ATIVAR PROMOÇÃO
                        if (opcPromo == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("=== ATIVAR PROMOÇÃO ===");
                            if (promocaoAtiva)
                            {
                                Console.WriteLine("Já existe uma promoção ativa.");
                                Console.WriteLine("Pressione ENTER para continuar...");
                                Console.ReadLine();
                                continue;
                            }

                            Console.WriteLine("Categorias para promoção:");
                            Console.WriteLine("1. Informática");
                            Console.WriteLine("2. Acessórios");
                            Console.WriteLine("3. Papelaria");
                            Console.WriteLine("4. Telefonia");
                            Console.Write("Escolha: ");
                            string catPromoStr = Console.ReadLine();

                            int catPromoInt;
                            if (!int.TryParse(catPromoStr, out catPromoInt) || catPromoInt < 1 || catPromoInt > 4)
                            {
                                Console.WriteLine("Categoria inválida.");
                                Console.WriteLine("Pressione ENTER para continuar...");
                                Console.ReadLine();
                                continue;
                            }

                            Console.Write("Desconto (% entre 5 e 50): ");
                            int desc;
                            bool descValido = int.TryParse(Console.ReadLine(), out desc);
                            if (!descValido || desc < 5 || desc > 50)
                            {
                                Console.WriteLine("Desconto inválido.");
                                Console.WriteLine("Pressione ENTER para continuar...");
                                Console.ReadLine();
                                continue;
                            }

                            Console.Write("Duração da promoção (horas entre 1 e 72): ");
                            int dur;
                            bool durValido = int.TryParse(Console.ReadLine(), out dur);
                            if (!durValido || dur < 1 || dur > 72)
                            {
                                Console.WriteLine("Duração inválida.");
                                Console.WriteLine("Pressione ENTER para continuar...");
                                Console.ReadLine();
                                continue;
                            }

                            Categoria catEscolhida = (Categoria)catPromoInt;

                            Console.Write($"Confirmar promoção de {desc}% na categoria {catEscolhida} por {dur} horas? (S/N): ");
                            string confPromo = Console.ReadLine().ToUpper();

                            if (confPromo == "S")
                            {
                                promocaoAtiva = true;
                                categoriaPromo = catEscolhida;
                                descontoPromo = desc;
                                fimPromocao = DateTime.Now.AddHours(dur);

                                Console.WriteLine("Promoção ativada com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Operação cancelada.");
                            }
                            Console.WriteLine("Pressione ENTER para continuar...");
                            Console.ReadLine();
                        }

                        // CONSULTAR PROMOÇÃO ATIVA
                        else if (opcPromo == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("=== CONSULTA DE PROMOÇÃO ATIVA ===");
                            if (promocaoAtiva)
                            {
                                TimeSpan restante = fimPromocao - DateTime.Now;
                                if (restante.TotalSeconds < 0) restante = TimeSpan.Zero;

                                Console.WriteLine("PROMOÇÃO ATIVA");
                                Console.WriteLine($"Categoria: {categoriaPromo}");
                                Console.WriteLine($"Desconto: {descontoPromo}%");
                                Console.WriteLine($"Tempo restante: {restante.Hours} horas e {restante.Minutes} minutos");
                                Console.WriteLine("Status: Ativa");
                            }
                            else
                            {
                                Console.WriteLine("Nenhuma promoção ativa.");
                            }
                            Console.WriteLine("Pressione ENTER para continuar...");
                            Console.ReadLine();
                        }

                        // DESATIVAR PROMOÇÃO
                        else if (opcPromo == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("=== DESATIVAR PROMOÇÃO ===");
                            if (!promocaoAtiva)
                            {
                                Console.WriteLine("Nenhuma promoção ativa para desativar.");
                                Console.WriteLine("Pressione ENTER para continuar...");
                                Console.ReadLine();
                                continue;
                            }

                            TimeSpan restanteDes = fimPromocao - DateTime.Now;
                            if (restanteDes.TotalSeconds < 0) restanteDes = TimeSpan.Zero;

                            Console.WriteLine("Promoção atual:");
                            Console.WriteLine($"Categoria: {categoriaPromo}");
                            Console.WriteLine($"Desconto: {descontoPromo}%");
                            Console.WriteLine($"Tempo restante: {restanteDes.Hours} horas e {restanteDes.Minutes} minutos");
                            Console.Write("Deseja realmente desativar esta promoção? (S/N): ");
                            string desativa = Console.ReadLine().ToUpper();

                            if (desativa == "S")
                            {
                                Console.WriteLine("Motivo da desativação:");
                                Console.WriteLine("1. Encerramento antecipado");
                                Console.WriteLine("2. Erro na configuração");
                                Console.WriteLine("3. Mudança de estratégia");
                                Console.WriteLine("4. Outros");
                                Console.Write("Escolha: ");
                                string motivoDes = Console.ReadLine();

                                promocaoAtiva = false;
                                descontoPromo = 0;
                                Console.WriteLine("Promoção desativada com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Operação cancelada.");
                            }
                            Console.WriteLine("Pressione ENTER para continuar...");
                            Console.ReadLine();
                        }
                    }
                }

                // ========== OPÇÃO 7 - Relatórios do Dia ==========
                else if (opcao == "7")
                {
                    string opcRel = "";
                    while (opcRel != "4")
                    {
                        Console.Clear();
                        Console.WriteLine("=== RELATÓRIOS DO DIA ===");
                        Console.WriteLine("1. Resumo de Vendas");
                        Console.WriteLine("2. Faturamento Total");
                        Console.WriteLine("3. Status do Estoque");
                        Console.WriteLine("4. Voltar ao Menu Principal");
                        Console.Write("Escolha uma opção: ");
                        opcRel = Console.ReadLine();

                        // RESUMO DE VENDAS
                        if (opcRel == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("=== RESUMO DE VENDAS DO DIA ===");
                            Console.WriteLine($"Total de vendas realizadas: {totalVendas}");
                            Console.WriteLine($"Produtos vendidos: {totalProdutosVendidos} unidades");
                            Console.WriteLine($"Vendas com desconto promocional: {vendasComDesconto}");
                            Console.WriteLine($"Desconto total concedido: R$ {totalDescontos:F2}");
                            Console.WriteLine($"Última venda: R$ {ultimaVenda:F2}");
                            Console.WriteLine($"Maior venda: R$ {maiorVenda:F2}");
                            Console.WriteLine($"Menor venda: R$ {(menorVenda == 999999 ? 0 : menorVenda):F2}");
                            Console.WriteLine("Pressione ENTER para continuar...");
                            Console.ReadLine();
                        }

                        // FATURAMENTO TOTAL
                        else if (opcRel == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("=== FATURAMENTO TOTAL DO DIA ===");
                            Console.WriteLine($"Faturamento bruto: R$ {faturamentoBruto:F2}");
                            Console.WriteLine($"Descontos aplicados: R$ {totalDescontos:F2}");
                            double faturamentoLiquido = faturamentoBruto - totalDescontos;
                            Console.WriteLine($"Faturamento líquido: R$ {faturamentoLiquido:F2}");
                            Console.WriteLine("Pressione ENTER para continuar...");
                            Console.ReadLine();
                        }

                        // STATUS DO ESTOQUE
                        else if (opcRel == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("=== STATUS ATUAL DO ESTOQUE ===");
                            Console.WriteLine("┌──────┬──────────────────────┬─────────────┬────────────┬────────────┐");
                            Console.WriteLine("│ Cód. │ Nome                 │ Categoria   │ Preço (R$) │ Estoque    │");
                            Console.WriteLine("├──────┼──────────────────────┼─────────────┼────────────┼────────────┤");
                            Console.WriteLine($"│ {codigo1,-4} │ {nome1,-20} │ {categoria1,-11} │ {preco1,10:F2} │ {estoque1,10} │");
                            Console.WriteLine($"│ {codigo2,-4} │ {nome2,-20} │ {categoria2,-11} │ {preco2,10:F2} │ {estoque2,10} │");
                            Console.WriteLine($"│ {codigo3,-4} │ {nome3,-20} │ {categoria3,-11} │ {preco3,10:F2} │ {estoque3,10} │");
                            Console.WriteLine($"│ {codigo4,-4} │ {nome4,-20} │ {categoria4,-11} │ {preco4,10:F2} │ {estoque4,10} │");
                            Console.WriteLine($"│ {codigo5,-4} │ {nome5,-20} │ {categoria5,-11} │ {preco5,10:F2} │ {estoque5,10} │");
                            Console.WriteLine("└──────┴──────────────────────┴─────────────┴────────────┴────────────┘");
                            Console.WriteLine("Pressione ENTER para continuar...");
                            Console.ReadLine();
                        }
                    }
                }
            }

            int opcao;
            do
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1 - Mostrar Produtos");
                Console.WriteLine("2 - Mostrar Estoques");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Produto 1: {nome1} | Categoria: {categoria1}");
                        Console.WriteLine($"Produto 2: {nome2} | Categoria: {categoria2}");
                        Console.WriteLine($"Produto 3: {nome3} | Categoria: {categoria3}");
                        Console.WriteLine($"Produto 4: {nome4} | Categoria: {categoria4}");
                        Console.WriteLine($"Produto 5: {nome5} | Categoria: {categoria5}");
                        break;

                    case 2:
                        Console.WriteLine($"Estoque de {nome1}: {estoque1} unidades");
                        Console.WriteLine($"Estoque de {nome2}: {estoque2} unidades");
                        Console.WriteLine($"Estoque de {nome3}: {estoque3} unidades");
                        Console.WriteLine($"Estoque de {nome4}: {estoque4} unidades");
                        Console.WriteLine($"Estoque de {nome5}: {estoque5} unidades");
                        break;

                    case 0:
                        Console.WriteLine("Saindo do menu...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (opcao != 0);

        }
    }
}

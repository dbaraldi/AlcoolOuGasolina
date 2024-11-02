decimal gasolina, etanol, razao;  

Console.Clear(); 

Console.WriteLine("--- Etanol ou gasolina? ---\n");
Console.Write("Preço do etanol (R$).....: ");
etanol = Convert.ToDecimal(Console.ReadLine());

Console.Write("Preço da gasolina (R$).....: ");
gasolina = Convert.ToDecimal(Console.ReadLine());

razao = RazaoEtanolGasolina(etanol, gasolina);

Console.WriteLine($"\nO preço do etanol corresponde a {razao:P1} do preço da gasolina.");
Console.WriteLine($"\nRecomendação: Abasteça com {(AbastecerComGasolina(razao) ? "GASOLINA" : "ETANOL")}.");


decimal RazaoEtanolGasolina(decimal valorEtanol, decimal valorGasolina)
{
    return valorEtanol / valorGasolina;
}

bool AbastecerComGasolina(decimal razao)
{
   const decimal percentualIdeal = 0.73M;
    return razao > percentualIdeal;
}
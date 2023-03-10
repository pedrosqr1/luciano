static void Main(string[] args)
{
    //Criando lista
    List<string> ListaFrutas = new List<string>;
    string entrada;

    Console.WriteLine("Entre com A Lista Conforme Manual do Sistema:");
    //Ex entrada:banana;maca;laranja;laranja"
    entrada = Console.ReadLine();

    //Pega Array de palavras separados por ';'
    string[] strArray = entrada.Split(';');

    //Para cada Palavra no array
    foreach (string str in strArray)
    {

        //Faz uma copia da string em Lower Case
        string fruta = str.ToLower();

        //Copia a primeira Letra da string em UpperCase
        string primeiraLetra = fruta.Substring(0, 1).ToUpper();

        //fruta recebe PrimeiraLetra maiúscula e restante minúsculo;
        fruta = primeiraLetra
            + fruta.Substring(1, fruta.Length - 1);

        //se a fruta ainda não existir na lista adiciona
        if (!ListaFrutas.Contains(fruta))
            ListaFrutas.Add(fruta);
    }

    Console.WriteLine("Resposta:" + Environment.NewLine);
    //Exibi Lista de Frutas
    foreach (string fruta in ListaFrutas)
        Console.WriteLine(fruta);
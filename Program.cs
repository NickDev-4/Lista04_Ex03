Console.Clear();

string resposta;

Console.WriteLine("** O FLUXOGRAMA DA ENGENHARIA **");

Console.Write("Está se movendo? (Sim ou Não): ");
resposta = Console.ReadLine();

if (resposta.ToLower() == "sim") {
    Console.Write("Deveria? (Sim ou Não): ");
    resposta = Console.ReadLine();
    resposta.ToLower();

    if (resposta.ToLower() == "sim"){
        Console.Write("ÓTIMO");
    }

    else {
        Console.Write("USE FITA ADESIVA!");
    }
}

else {
    Console.Write("Deveria? (Sim ou Não): ");
    resposta = Console.ReadLine();

    if (resposta.ToLower() == "não"){
        Console.Write("ÓTIMO");
    }

    else {
        Console.Write("USE WD-40!");
    }
}
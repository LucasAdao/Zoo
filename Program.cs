/* A quantidade de animais inseridos se deve a minha otimização de tempo pessoal, mais animais não significaria que eu sei mais, mas significaria que gastei mais tempo nesse projeto! Com isso quero certificar minhas habilidades em polimofrismo, através de um projeto pessoal!! Vou passar de nível gradualmente e fazer projetos com certa progressão!!

-------------------------- Muito agradessuaido, -----------------------------------
-------------------------- Lucas Adão Ferreira  -----------------------------------
*/
using Zoo.models.entities;

Cobra cobra = new Cobra();
Foca foca = new Foca();
Garca garca = new Garca();
Leao leo = new Leao();
Macaco maco = new Macaco();
Raposa raposa = new Raposa();
Tigre tigre = new Tigre();

Console.WriteLine("Bom dia Cidade de Morioh!! O dia está lindo, clima de 25 graus celsius, um sábado perfeito para irmos ao zoológico ver os mais diversos animais!!");
Thread.Sleep(4000);

Console.WriteLine("------------------------ Bem vindo ao ZOO Resenha garantida ---------------------------------");
Thread.Sleep(1000);
Console.WriteLine("Para começar insira seu nome:");
string name = Console.ReadLine();
Console.WriteLine($"Seja bem vindo {name}, aqui no ZOO RESENHA, vai ter uma variedade imensa de animais para você curtir seu lindo dia de sol!!");
Thread.Sleep(4000);

///Achei legal deixar esse erro porque eu fiquei feliz achando que ia rodar de primeira, já que fiz esse code sem filar, mas vou deixar para registrar onde errei!! O programa dava um loop infinito, por sempre cair no switch case com o primeiro número escolhido
// Console.WriteLine("Qual animal você quer ver?");
// Thread.Sleep(600);
// Console.WriteLine("\n 1-Cobra \n 2-Foca \n 3-Garca \n 4-Leao \n 5-Macaco \n 6-Raposa \n 7-Tigre \n 8-Sair ");
// int escolha = Convert.ToInt32(Console.ReadLine());
 bool revisitar = true;

while(revisitar == true){
    Console.WriteLine("Qual animal você quer ver?");
    Thread.Sleep(600);
    Console.WriteLine("\n 1-Cobra \n 2-Foca \n 3-Garca \n 4-Leao \n 5-Macaco \n 6-Raposa \n 7-Tigre \n 8-Sair "); int escolha = Convert.ToInt32(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            Console.WriteLine("Essa é a cobra, um animal bastante sagaz, mas não confunda sagacidade com calma e bom temperamento, ela é muito agressiva!");
            Thread.Sleep(4000);
            cobra.EmitirSom();
            break;
        case 2:
            Console.WriteLine("A foca, animal muito carinhoso e habilidoso, você pode alimenta-la e com certeza ela irá fazer uma graça!!");
            Thread.Sleep(4000);
            foca.EmitirSom();
            break;
        case 3:
            Console.WriteLine("A garça, um animal calmo, simples, e que caça com muita precisão, sem dúvidas é um animal incrível");
            Thread.Sleep(4000);
            garca.EmitirSom();
            break;
        case 4:
            Console.WriteLine("Aqui está O REIIIIIIIIII DOS ANIMAISSSS, O LEAO, E AQUI ESTÁ ELE:");
            leo.EmitirSom();
            Thread.Sleep(4000);
            break;
        case 5:
            Console.WriteLine("Ele é danado, alguns dizem que nossa especie veio da mesma que ele, apresento para vocês o macaco!!");
            Thread.Sleep(4000);
            maco.EmitirSom();
            break;
        case 6:
            Console.WriteLine("Muitos não sabem qual barulho ela faz, é muito perpicaz e sútil, com vocês a raposa");
            raposa.EmitirSom();
            Thread.Sleep(4000);
            break;
        case 7:
            Console.WriteLine("Aqui temos o Felino mais forte, mais assustador e que não anda em grupo por ter tanta confiança nos seus instintos, o tigre!!");
            Thread.Sleep(4000);
            tigre.EmitirSom();
            break;
        case 8:
            Console.WriteLine($"Obrigado por visitar o ZOO Resenha {name}, Volte sempre!!!");
            revisitar = false;
            break;    

        default:
            Console.WriteLine("Insira um válor númerico que se apresenta antes do nome do animal para ter a oportunidade de visitar algum");
            break;
    }
    Thread.Sleep(2000);
    Console.WriteLine("Digite um botão para continuar");
    Console.ReadLine();

}

Console.WriteLine("O programa chegou ao fim, até a próxima!!");
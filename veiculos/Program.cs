Carro c1 = new Carro();
c1.velocidade = 20;



Moto m1 = new Moto();
m1.velocidade = 50;


// // criar array de inteiros de tamanho 5 
// int[] notas = new int[5];
// //atribui valores ao array
// notas[0] = 90;
// notas[1] = 85;
// notas[2] = 88;
// notas[3] = 92;
// notas[4] = 95;

// //acessando e imprimindo as notas dos alunos 
// for (int i = 0; i < notas.Length; i++)
// {
//     Console.WriteLine($"Nota do Aluno {i + 1}: {notas[i]}");
// }

// cria uma lista vazia de veiculo
List<Veiculo> veiculos = new List<Veiculo>();

// adicionar veiculos
veiculos.Add(c1);
veiculos.Add(m1);



foreach(Veiculo veiculo in veiculos)
{
    Console.WriteLine("veiculo.velocidade");
    veiculo.Acelerar();
    veiculo.ExibirVelocidade();
    veiculo.Frear();
    veiculo.ExibirVelocidade();

}



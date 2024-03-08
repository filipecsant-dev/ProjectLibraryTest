// See https://aka.ms/new-console-template for more information
using Candidato.Entities;

double preco = HiperMercado.Hi.formulaMagica(200, 19);
Console.WriteLine(preco);


List<Casa> Casas = Candidato.Hi.GetData();
Casas.ForEach(x => {
    Console.WriteLine(x.rua.nome + " | " + x.totalEleitores);
});

List<Rua> ruasCandidato = Candidato.Hi.RuasVisitar(Casas);
ruasCandidato.ForEach(x =>{
    Console.WriteLine(x.nome);
});
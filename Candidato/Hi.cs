using Candidato.Entities;
using Candidato.Services;

namespace Candidato;

public static class Hi
{
    public static List<Casa> GetData()
    {
        return HiService.GetCasa();
    }

    public static List<Rua> RuasVisitar(List<Casa> casas)
    {
        try
        {
            if(casas.Count() == 0)
                return new List<Rua>();

            var ruas = HiService.GetRuasVisita(casas);
            return ruas;
        }
        catch(Exception ex)
        {
            throw new Exception("Algo ocorreu fora do esperado. Consulte a equipe responsável!");
        }
    }
}

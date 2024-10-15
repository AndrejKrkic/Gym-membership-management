using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public enum Operation
    {
        Login,
        KreirajClana,
        UcitajListuMesta,
        UcitajListuClanova,
        PretraziClanove,
        IzmeniClana,
        ObrisiClana,
        KreirajTrenera,
        UcitajListuTrenera,
        PretraziTrenere,
        IzmeniTrenera,
        ObrisiTrenera,
        UcitajListuVezbi,
        KreirajPlan,
        UcitajListuPlanova,
        UcitajListuStavkiPlanova,
        IzmeniPlan,
        PretraziPlanove
    }
}

using Verse;

namespace Skaven;

public class HediffCompProperties_Ageing : HediffCompProperties
{
    public int timetoage = 1;

    public HediffCompProperties_Ageing()
    {
        compClass = typeof(HediffComp_Ageing);
    }
}
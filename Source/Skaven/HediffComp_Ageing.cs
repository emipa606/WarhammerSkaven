using Verse;

namespace Skaven;

public class HediffComp_Ageing : HediffComp
{
    public HediffCompProperties_Ageing Props => (HediffCompProperties_Ageing)props;

    public override void CompPostPostAdd(DamageInfo? dinfo)
    {
        parent.pawn.ageTracker.DebugSetAge(3600000L);
        parent.pawn.ageTracker.DebugSetAge(3600000L);
        parent.pawn.ageTracker.DebugSetAge(3600000L);
    }
}
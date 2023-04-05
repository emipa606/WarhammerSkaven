using RimWorld;
using Verse;

namespace Skaven;

public class HediffCompProperties_SpawnOnDeath : HediffCompProperties
{
    public bool destroyBody;

    public ThingDef filth;

    public int filthCount = 4;
    public FleckDef fleck;

    public FactionDef forcedFaction;

    public ThingDef mote;

    public int moteCount = 3;

    public FloatRange moteOffsetRange = new FloatRange(0.2f, 0.4f);

    public PawnKindDef pawnKind;

    public SoundDef sound;

    public bool usePlayerFaction;

    public HediffCompProperties_SpawnOnDeath()
    {
        compClass = typeof(HediffComp_SpawnOnDeath);
    }
}
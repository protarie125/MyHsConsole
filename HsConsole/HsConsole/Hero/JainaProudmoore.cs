using HsConsole.Game.Interface;
using HsConsole.Game.Object;
using static HsConsole.Game.Enum.HsEnum;

namespace HsConsole.Hero
{
    class JainaProudmoore : HsHero
    {
        public JainaProudmoore() : base(ClassType.Mage)
        {
            HeroPowerValidTarget = EffectTarget.Character;
        }

        public override void UseHeroPower(object target = null)
        {
            if (target is ICharacter c)
            {
                if (c is Minion m)
                {
                    m.Health.Current -= 1;
                }
                else if (c is HsHero h)
                {
                    h.Health.Current -= 1;
                }
            }
        }
    }
}

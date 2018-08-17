using HsConsole.Game.Interface;
using HsConsole.Game.Numeric;
using static HsConsole.Game.Enum.HsEnum;

namespace HsConsole.Game.Object
{
    abstract class HsHero : GameObject, IPointable, ICharacter
    {
        public ClassType ClassType { get; protected set; }
        public OmcInt Attack { get; set; }
        public OmcInt Health { get; set; }
        public OmcInt Armor { get; set; }

        public HsHero() : base("new Hero")
        {
            ClassType = ClassType.None;
            Attack = new OmcInt(0);
            Health = new OmcInt(30);
            Armor = new OmcInt(0);
        }

        public HsHero(ClassType classType, int startingHealth = 30) : base(classType.ToString())
        {
            ClassType = classType;
            Attack = new OmcInt(0);
            Health = new OmcInt(startingHealth);
            Armor = new OmcInt(0);
        }

        // -> HeroPower 클래스로 옮겨
        public string HeroPowerName { get; private set; }
        public string HeroPowerTooltip { get; private set; }
        public EffectTarget HeroPowerValidTarget;
        public abstract void UseHeroPower(object target = null);

        #region IPointable
        private bool isPointable;

        public bool GetPointable()
        {
            return isPointable;
        }

        public void SetPointable(bool state)
        {
            isPointable = state;
        }
        #endregion

        public override string ToString()
        {
            return string.Format($"{ClassType} | ({Attack.Current}, {Health.Current} + {Armor.Current})");
        }
    }
}

using HsConsole.Game.Interface;
using HsConsole.Game.Numeric;
using static HsConsole.Game.Enum.HsEnum;

namespace HsConsole.Game.Object
{
    abstract class Minion : HsCard, IPointable, ICharacter
    {
        public OmcInt ManaCost { get; set; }
        public OmcInt Attack { get; set; }
        public OmcInt Health { get; set; }

        public Race Race { get; protected set; }

        public Minion(string cardName, int manaCost, int attack, int health, string toolTip = default(string), Race race = default(Race)) : base(cardName, toolTip, CardType.Minion)
        {
            ManaCost = new OmcInt(manaCost);
            Attack = new OmcInt(attack);
            Health = new OmcInt(health);

            Race = race;
        }

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
            return string.Format($"{CardName} | {ManaCost.Current}, {Attack.Current}/{Health.Current} | {ToolTip} | {Race.ToString()} | {CardType.ToString()}");
        }
    }
}

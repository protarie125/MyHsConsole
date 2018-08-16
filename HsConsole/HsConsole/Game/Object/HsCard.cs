using static HsConsole.Game.Enum.HsEnum;

namespace HsConsole.Game.Object
{
    abstract class HsCard : GameObject
    {
        public string CardName { get; private set; }
        public string ToolTip { get; private set; }
        public CardType CardType { get; private set; }

        public HsCard() : base()
        {
            CardName = string.Empty;
            ToolTip = string.Empty;
            CardType = CardType.None;
        }

        public HsCard(string cardName, string toolTip = default(string), CardType cardType = default(CardType)) : base(cardName)
        {
            CardName = cardName;
            ToolTip = toolTip;
            CardType = cardType;
        }

        public override string ToString()
        {
            return string.Format($"{CardName} | {ToolTip} | {CardType.ToString()}");
        }
    }
}

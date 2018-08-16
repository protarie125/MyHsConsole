namespace HsConsole.Game.Object
{
    class GameObject
    {
        public string ObjectName { get; protected set; }

        public GameObject()
        {
            ObjectName = "new GameObject";
        }

        public GameObject(string name)
        {
            ObjectName = name;
        }

        public override string ToString()
        {
            return ObjectName;
        }
    }
}

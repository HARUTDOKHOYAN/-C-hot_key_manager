using System.Collections.Generic;

namespace HotKeysManager
{
    interface IHotKeyCommands<T, K>
    {
        public Dictionary<HotKeyModel, ActionModel<T>> Commands { get; set; }
        public K CommandParameters { get; set; }
    }
}

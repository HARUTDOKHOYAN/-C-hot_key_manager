using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace HotKeysManager
{

    public class HomePageHotKeyScope : IHotKeyCommands<HomeActionHandler, HomeAcitonParametrs>, IHotKeyScope
    {
        public Dictionary<HotKeyModel, ActionModel<HomeActionHandler>> Commands { get; set; }
        public HomeAcitonParametrs CommandParameters { get; set; }

        public HomePageHotKeyScope(HomeAcitonParametrs _commandParameters, Dictionary<HotKeyModel, ActionModel<HomeActionHandler>> _commands)
        {
            CommandParameters = _commandParameters;
            Commands = _commands;
        }

        public bool HotKeyContain(HotKeyModel hotKeyModel)
        {
            return Commands.Keys.Any(x => x.HotKeyName == hotKeyModel.HotKeyName);
        }

        public void ExecuteHotKey(HotKeyModel hotKeyModel)
        {
            foreach (var Command in Commands)
            {
                if (HotKeyContain(Command.Key))
                {
                    Command.Value.Handler(CommandParameters , CommandParameters.Data);
                }
            }
        }
    }

    public class EditorHotKeyScope : IHotKeyCommands<EditorActionHandler, EditorCore> , IHotKeyScope
    {

        public Dictionary<HotKeyModel, ActionModel<EditorActionHandler>> Commands { get; set; }
        public EditorCore CommandParameters { get; set; }

        public EditorHotKeyScope(EditorCore _commandParameters, Dictionary<HotKeyModel, ActionModel<EditorActionHandler>> _commands)
        {
            CommandParameters = _commandParameters;
            Commands = _commands;
        }

        public bool HotKeyContain(HotKeyModel hotKeyModel)
        {
            return Commands.Keys.Any(x => x.HotKeyName == hotKeyModel.HotKeyName);
        }

        public void ExecuteHotKey(HotKeyModel hotKeyModel)
        {
            foreach (var Command in Commands)
            {
                if (HotKeyContain(Command.Key))
                {
                    Command.Value.Handler(CommandParameters);
                }
            }
        }
    }
}

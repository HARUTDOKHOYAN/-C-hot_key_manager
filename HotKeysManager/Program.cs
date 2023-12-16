using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotKeysManager
{
    class Program
    {
        static void Main()
        {

            List<int> a = new List<int> { 2, 5, 6 };
            a.Remove(9);
            //HomeScop
            var commandsHome = new Dictionary<HotKeyModel, ActionModel<HomeActionHandler>>
            {
                {new HotKeyModel{Key = "C" , Modifier  ="Control" } , new ActionModel<HomeActionHandler>(HomeActionHandler) }
            };
            var scopeHome = new HomePageHotKeyScope(new HomeAcitonParametrs(new HomeCore() , "Hi Men" ), commandsHome);
            //EditorScop
            var commandsEditor = new Dictionary<HotKeyModel, ActionModel<EditorActionHandler>>
            {
                {new HotKeyModel{Key = "C" , Modifier  ="Control" } , new ActionModel<EditorActionHandler>(EditorActionHandler) }
            };
            var scopeEditor = new EditorHotKeyScope(new EditorCore(), commandsEditor);


            var hotKeys = new HotKeyManager();

            hotKeys.RegisterHotKeyScope(scopeHome);

            hotKeys.ExecutesHotKey(new HotKeyModel { Key = "C", Modifier = "Control" });

            hotKeys.RegisterHotKeyScope(scopeEditor);

            hotKeys.ExecutesHotKey(new HotKeyModel { Key = "C", Modifier = "Control" });
        }
        static public void EditorActionHandler(EditorCore editorCoreBase)
        {

            Console.WriteLine(editorCoreBase.Data);
        }

        static public void HomeActionHandler(HomeAcitonParametrs homeCoreBase , string data)
        {
            Console.WriteLine(homeCoreBase.HomeCore.Data);
            Console.WriteLine(data);
        }
    }

}

using System.Threading.Tasks;

namespace HotKeysManager
{
    public delegate void EditorActionHandler(EditorCore editorCoreBase);
    public delegate void HomeActionHandler(HomeAcitonParametrs editorCoreBase , string data );


    public class ActionModel<T>
    {
        public ActionModel(T handler)
        {
            Handler = handler;
        }
        public T Handler;

    }
}

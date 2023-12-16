namespace HotKeysManager
{
    public class HomeAcitonParametrs
    {
        public HomeAcitonParametrs(HomeCore homeCore , string data )
        {
            HomeCore = homeCore;
            Data = data;
        }
        public HomeCore HomeCore { get; set; }
        public string Data { get; set; } 
    }
}

namespace _4RTools.Model
{
    public interface Action
    {
        void Start();
        void Stop();
        string GetConfiguration();

        string GetActionName();
    }
}

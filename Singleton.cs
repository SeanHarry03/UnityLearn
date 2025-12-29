namespace UnityLearns;

public abstract class Singleton<T> where T : class, new()
{
    private static readonly Lazy<T> _lazyInstance = new Lazy<T>(() => new T());

    public static T Instance
    {
        get { return _lazyInstance.Value; }
    }

    protected Singleton()
    {
        // 这里可以做一些初始化检测
    }
}
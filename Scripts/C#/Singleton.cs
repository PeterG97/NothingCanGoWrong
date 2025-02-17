namespace GameLogic;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public sealed class Singleton : Attribute { }

public static class SingletonManager
{
    private static readonly System.Collections.Generic.Dictionary<Type, object> _singletons = new();

    public static T GetInstance<T>() where T : new()
    {
        Type type = typeof(T);
        if (_singletons.ContainsKey(type))
        {
            return (T)_singletons[type];
        }

        if (!typeof(T).IsDefined(typeof(Singleton)))
        {
            throw new InvalidOperationException("The class is not marked as a singleton.");
        }

        object instance = Activator.CreateInstance(type);
        _singletons.Add(type, instance);
        return (T)instance;
    }

    public static void Reset<T>() where T : class
    {
        lock (_singletons)
        {
            if (_singletons.Remove(typeof(T)))
            {
                GC.Collect();
            }
        }
    }
}
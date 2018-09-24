# dotnet-extensions
.Net implementations for general purpose problems.

##### TimeProvider
To use it, is as easy as follows.
```c#
var utcNow = TimeProvider.Current.UtcNow();
```

When testing your classes, you can replace your implementation as follows:

```c#
TimeProvider.Current = new MyFakeTimeProvider();

public class MyFakeTimeProvider : TimeProvider
{
    public override DateTime UtcNow
    {
        get { return new DateTime(2018, 1, 1); }
    }
}
```

Don't forget to reset to the default implementation when the test finish:
```c#
TimeProvider.Current.ResetToDefault();
```


// @kurtdekker
//
// An ultra-basic bare-bones singleton: "There can only be one."
//	- Simply access it via .Instance static property.
//	- You cannot new another one up. You can't even new this one up.
//
// WARNING: be VERY careful about lifecycle of something like this
// in Unity! Unity runs Object constructors NOT on the main thread!
//
// For somewhat more useful constructs for a Unity context, check out these:
//	https://gist.github.com/kurtdekker/775bb97614047072f7004d6fb9ccce30
//	https://gist.github.com/kurtdekker/2f07be6f6a844cf82110fc42a774a625

public class Highlander
{
	private Highlander()
	{
		// put your initializers here
	}

	static Highlander _Instance;
	public static Highlander Instance
	{
		get
		{
			if (_Instance == null)
			{
				_Instance = new Highlander();
			}
			return _Instance;
		}
	}
}

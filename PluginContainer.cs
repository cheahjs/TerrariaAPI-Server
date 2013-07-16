using System;
public class PluginContainer : IDisposable
{
	public TerrariaPlugin Plugin
	{
		get;
		protected set;
	}
	public bool Initialized
	{
		get;
		protected set;
	}
	public bool Dll
	{
		get;
		set;
	}
    public string FilePath
    {
        get;
        set;
    }
	public PluginContainer(TerrariaPlugin plugin, bool dll, string filepath)
	{
		this.Plugin = plugin;
		this.Initialized = false;
		this.Dll = dll;
        this.FilePath = filepath;
	}
	public void Initialize()
	{
		this.Plugin.Initialize();
		this.Initialized = true;
	}
	public void DeInitialize()
	{
		this.Initialized = false;
	}
	public void Dispose()
	{
		this.Plugin.Dispose();
	}
}

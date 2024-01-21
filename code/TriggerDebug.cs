using Sandbox;

public sealed class TriggerDebug : Component, Component.ITriggerListener
{

	public void OnTriggerEnter( Collider other )
	{
		Log.Info( $"TriggerEnter in {GameObject.Name} at {Time.Now:f2}" );
	}

	public void OnTriggerExit( Collider other )
	{
		Log.Info( $"TriggerExit in {GameObject.Name} at {Time.Now:f2}" );
	}

}

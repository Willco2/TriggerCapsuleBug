using Sandbox;

public sealed class MoveDown : Component
{

	protected override void OnUpdate()
	{
		Transform.Position = Vector3.Up * float.Cos( Time.Now ) * 100;
	}

}

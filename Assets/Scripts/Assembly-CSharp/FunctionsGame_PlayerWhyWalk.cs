using UnityEngine;

public class FunctionsGame_PlayerWhyWalk : MonoBehaviour
{
	private int orderObjectsWhy;

	private int indexWhy;

	[SerializeField]
	private GameObject[] objectsWhyOrder;

	[SerializeField]
	private FunctionsGame_PlayerWhyWalk_Event[] eventFinish;

	[SerializeField]
	private Trigger_Event[] triggerWalk;

	[SerializeField]
	private Trigger_Event[] triggerBack;

	private bool fs;

	private void Start()
	{
	}

	public void PlayerWhy()
	{
	}

	public void FinishReaction()
	{
	}

	public void FinishReactionTrigger()
	{
	}

	public void WhyActivated(int _indexWhy)
	{
	}

	public void WhyDeactivated()
	{
	}

	public void Check(int _indexWhy)
	{
	}
}

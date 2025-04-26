using UnityEngine;

public class AnimatorState_Bool : StateMachineBehaviour
{
	public string[] onExitBoolOff;

	public string[] onExitBoolOn;

	public string[] onEnterBoolOff;

	public string[] onEnterBoolOn;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}
}

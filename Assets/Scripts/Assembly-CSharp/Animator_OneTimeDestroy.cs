using UnityEngine;
using UnityEngine.Events;

public class Animator_OneTimeDestroy : MonoBehaviour
{
	public AnimationClip animationTime;

	public bool destroyObject;

	public bool dontDeleteThis;

	public UnityEvent eventFinish;

	[SerializeField]
	private Component[] componentsDestroy;

	private float timeAnimation;

	private bool activeFrame;

	private bool play;

	private bool use;

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void Finish()
	{
	}

	public void AticeObject()
	{
	}

	[ContextMenu("Запустить")]
	public void ActiveObject()
	{
	}

	public void FullFinish()
	{
	}
}

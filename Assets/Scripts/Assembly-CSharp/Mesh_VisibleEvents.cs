using UnityEngine;
using UnityEngine.Events;

public class Mesh_VisibleEvents : MonoBehaviour
{
	public Renderer rend;

	public UnityEvent eventVisibleEnter;

	public UnityEvent eventVisibleExit;

	public bool oneTime;

	public bool destroyEnter;

	public float timeVisible;

	[SerializeField]
	private float timeStartActive;

	private bool enterUse;

	private bool exitUse;

	private void Start()
	{
	}

	private void Update()
	{
	}
}

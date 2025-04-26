using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Functions/Player/Need item")]
public class Player_NeedItem : MonoBehaviour
{
	public GameObject itemNeed;

	public UnityEvent eventExists;

	public UnityEvent eventMissing;

	private GameController scrgc;

	private bool itemExists;

	private bool fs;

	private void CheckItem()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}

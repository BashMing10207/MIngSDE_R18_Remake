using Kino;
using UnityEngine;
using UnityEngine.Events;

public class Location18_Mita : MonoBehaviour
{
	[SerializeField]
	private GameObject mita;

	[Header("Сюжет")]
	[SerializeField]
	private Datamosh datamoshCamera;

	[SerializeField]
	private UnityEvent eventAppear;

	private float timeAppear;

	private int timeDatamosh;

	private bool exit;

	private float speedExit;

	private void Update()
	{
	}

	[ContextMenu("Появление Миты")]
	public void AppearMita()
	{
	}

	public void ExitMita()
	{
	}

	public void DestroyThis()
	{
	}
}

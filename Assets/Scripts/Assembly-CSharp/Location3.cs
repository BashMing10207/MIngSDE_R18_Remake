using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location3 : MonoBehaviour
{
	[Header("Картриджи")]
	[SerializeField]
	private Text[] textesName;

	private bool sous;

	[Header("Любовный соус")]
	[SerializeField]
	private UnityEvent eventStartSous;

	[SerializeField]
	private UnityEvent eventStopSous;

	public void Start()
	{
	}

	public void SousUse()
	{
	}

	public void SouseActivation(bool x)
	{
	}
}

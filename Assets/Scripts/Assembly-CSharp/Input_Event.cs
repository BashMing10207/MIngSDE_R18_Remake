using UnityEngine;
using UnityEngine.Events;

public class Input_Event : MonoBehaviour
{
	public string buttonDown;

	public UnityEvent eventDown;

	[Header("Настройки")]
	public bool destroyComponentAfter;

	private void Update()
	{
	}
}

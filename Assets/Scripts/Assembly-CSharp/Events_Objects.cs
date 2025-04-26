using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

public class Events_Objects : MonoBehaviour
{
	[SerializeField]
	[Label("Событие")]
	private UnityEvent eventUse;

	[Label("Удалить")]
	[SerializeField]
	private GameObject[] objectsDestroy;

	[Label("Удалить компоненты")]
	[SerializeField]
	private Component[] componentsDestroy;

	[SerializeField]
	[Label("Включить")]
	private GameObject[] objectsActive;

	[SerializeField]
	[Label("Выключить")]
	private GameObject[] objectsDeactive;

	[SerializeField]
	[Label("Поменять позицию")]
	private Events_Objects_Reposition[] objectsRepositions;

	[Button("Активировать", EButtonEnableMode.Always)]
	public void Use()
	{
	}
}

using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class Unity_FindMeshNull : MonoBehaviour
{
	public List<GameObject> objects;

	[ContextMenu("Найти объекты без меша")]
	public void Reset()
	{
	}

	[ContextMenu("Удалить объекты")]
	public void DestroyObjects()
	{
	}

	[Button("Отключить объекты", EButtonEnableMode.Always)]
	public void ObjectsOff()
	{
	}
}

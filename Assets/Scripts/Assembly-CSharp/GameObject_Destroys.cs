using UnityEngine;

[AddComponentMenu("Functions/GameObject/Destroys")]
public class GameObject_Destroys : MonoBehaviour
{
	public bool onStart;

	public GameObject[] objects;

	public GameObject[] objectsActive;

	public GameObject[] objectsDeactive;

	public bool selfDestroy;

	private void Start()
	{
	}

	[ContextMenu("Удалить")]
	public void Destroys()
	{
	}
}

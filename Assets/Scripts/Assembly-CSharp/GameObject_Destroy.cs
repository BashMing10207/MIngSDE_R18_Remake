using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Functions/GameObject/Destroy")]
public class GameObject_Destroy : MonoBehaviour
{
	public UnityEvent eventDestroy;

	public UnityEvent eventOnDestroy;

	public float timeDestroy;

	private bool des;

	private void Update()
	{
	}

	public void destroy()
	{
	}

	private void OnDestroy()
	{
	}
}

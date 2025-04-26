using UnityEngine;

public class ObjectInteractiveGroup : MonoBehaviour
{
	[SerializeField]
	private ObjectInteractive[] interactives;

	[Header("Настройки")]
	public bool onStart;

	private void Start()
	{
	}

	public void Activation(bool x)
	{
	}

	public void ActivationAndDestroy(GameObject _object)
	{
	}
}

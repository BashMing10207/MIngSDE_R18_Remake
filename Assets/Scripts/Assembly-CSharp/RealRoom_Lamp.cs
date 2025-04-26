using UnityEngine;

public class RealRoom_Lamp : MonoBehaviour
{
	[SerializeField]
	private GameObject lightAlpha;

	[SerializeField]
	[ColorUsage(false, true)]
	private Color lightLamp;

	public void Activation(bool x)
	{
	}
}

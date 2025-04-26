using NaughtyAttributes;
using UnityEngine;

public class Game_SetFPS : MonoBehaviour
{
	[SerializeField]
	private int FPSLimit;

	[Button("Установить", EButtonEnableMode.Always)]
	private void Start()
	{
	}
}

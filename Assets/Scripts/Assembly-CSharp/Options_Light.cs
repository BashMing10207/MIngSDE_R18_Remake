using NaughtyAttributes;
using UnityEngine;

public class Options_Light : MonoBehaviour
{
	[Label("Нужно откидывать тень")]
	[SerializeField]
	private bool lockNone;

	[Label("Тени не нужны")]
	[SerializeField]
	private bool shadowOff;

	[Range(0f, 3f)]
	[Label("Уровень")]
	[SerializeField]
	private int level;

	[SerializeField]
	[Label("На максимум качество теней")]
	private bool shadowResolution;

	private void Start()
	{
	}

	public void StartSettings()
	{
	}
}

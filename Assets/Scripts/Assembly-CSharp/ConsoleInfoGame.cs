using UnityEngine;
using UnityEngine.UI;

public class ConsoleInfoGame : MonoBehaviour
{
	public bool onlyFPS;

	private Text text;

	[HideInInspector]
	public ConsoleCall cm;

	private int fpsFrame;

	private float fpsTimeUpdate;

	private string fpsText;

	private int timeReload;

	private string nameScene;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void ReloadData()
	{
	}
}

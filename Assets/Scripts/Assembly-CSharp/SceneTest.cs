using UnityEngine;

public class SceneTest : MonoBehaviour
{
	[Range(0f, 3f)]
	public float speed;

	public bool resetTime;

	private void Start()
	{
	}

	private void OnValidate()
	{
	}
}

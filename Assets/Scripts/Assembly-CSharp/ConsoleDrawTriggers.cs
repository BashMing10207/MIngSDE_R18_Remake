using UnityEngine;

public class ConsoleDrawTriggers : MonoBehaviour
{
	private Material lineMaterial;

	private Material planeMaterial;

	private static readonly int[] edges;

	public void StartComponent(Material _mtrLine, Material _mtrPlane)
	{
	}

	private void OnRenderObject()
	{
	}

	private void DrawBox(BoxCollider box)
	{
	}

	private Mesh CreateBoxMesh(BoxCollider box)
	{
		return null;
	}

	private Vector3[] GetBoxColliderCorners(BoxCollider box)
	{
		return null;
	}
}

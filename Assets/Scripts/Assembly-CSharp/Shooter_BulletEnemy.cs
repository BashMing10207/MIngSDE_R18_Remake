using UnityEngine;

public class Shooter_BulletEnemy : MonoBehaviour
{
	[SerializeField]
	private LayerMask layerWall;

	[SerializeField]
	private GameObject objectSphere;

	[SerializeField]
	private AudioClip soundExplosion;

	private float timeDestroy;

	private Vector3 direction;

	private float timeDontExplosion;

	private Transform myEnemy;

	public void StartComponent(Vector3 _pointStart, Transform _myEnemy)
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Explosion()
	{
	}
}

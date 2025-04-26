using UnityEngine;

public class MT_GameFly_Bullet : MonoBehaviour
{
	[SerializeField]
	private GameObject prefabExplode;

	public float speedBullet;

	private MT_GameFly main;

	private bool isPlayer;

	private float timeDontDestroy;

	public void StartComponent(bool _player, MT_GameFly _main, float _addSpeed)
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void Explode()
	{
	}

	private void DeleteBullet()
	{
	}
}

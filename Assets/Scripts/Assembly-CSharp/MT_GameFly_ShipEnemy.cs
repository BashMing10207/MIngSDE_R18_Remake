using UnityEngine;

public class MT_GameFly_ShipEnemy : MonoBehaviour
{
	private MT_GameFly main;

	[SerializeField]
	private int health;

	private float timeMoveX;

	private AnimationCurve animationMoveX;

	[HideInInspector]
	public float speed;

	private float limitDown;

	private int indexShot;

	private float timeShot;

	[Header("Стрельба")]
	[SerializeField]
	private GameObject prefabBullet;

	[SerializeField]
	private MT_GameFly_ShipEnemy_Shooting[] shooting;

	[SerializeField]
	private float timeRestartShot;

	private Transform ship;

	private float snaking;

	[Header("Корабль")]
	public float radiusShip;

	[SerializeField]
	private float snakingDamage;

	[SerializeField]
	private ParticleSystem particleDamage;

	[SerializeField]
	private GameObject prefabExplode;

	public void StartComponent(MT_GameFly _main, float _positionX, AnimationCurve _animationMoveX, float _speed, float _limitDown)
	{
	}

	private void Update()
	{
	}

	public void Damage(int _damage)
	{
	}

	public void DeleteShip()
	{
	}
}

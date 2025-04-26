using UnityEngine;

public class Shooter_Damager : MonoBehaviour
{
	[SerializeField]
	private Shooter_Enemy enemy;

	[SerializeField]
	private float multiple;

	[SerializeField]
	private GameObject particleDamage;

	public bool isHead;

	public bool Damage(float _damage, Vector3 _position)
	{
		return false;
	}
}

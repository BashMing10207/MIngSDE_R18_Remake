using System.Collections.Generic;
using UnityEngine;

public class Location13 : MonoBehaviour
{
	private List<GameObject> chibisrd;

	[Header("ЧибиМиты куклы")]
	[SerializeField]
	private GameObject chibiMitaRagdoll;

	[SerializeField]
	private Transform headMita;

	private bool liveChibi;

	private bool run;

	private float timeRun;

	private float timeAnimationGravity;

	[SerializeField]
	[Header("Живая Чиби")]
	private GameObject chibiMitaRun;

	[SerializeField]
	private AnimationCurve animationGravity;

	[SerializeField]
	private AudioSource audioSlapChibi;

	private void Update()
	{
	}

	public void CreateChibis()
	{
	}
}

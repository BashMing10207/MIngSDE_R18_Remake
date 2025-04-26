using System;
using System.Collections.Generic;
using UnityEngine;

public class BacteriaMain : MonoBehaviour
{
	[Serializable]
	private class BacteriaEnemy
	{
		[Range(0f, 100f)]
		public float chance;

		public GameObject bacteriaPrefab;
	}

	private Vector3 positionPlayerCenter;

	[Header("Игрок")]
	[SerializeField]
	private Transform cameraPlayer;

	[SerializeField]
	private BacteriaBody playerBactery;

	[HideInInspector]
	public Vector3 positionMouse;

	[SerializeField]
	[Header("Физика")]
	private LayerMask mouseLayer;

	private float timeLookOnMouse;

	[HideInInspector]
	public List<GameObject> obejctInWorld;

	private GameObject worldObject;

	private float timeClear;

	private float timeGenerationFood;

	[HideInInspector]
	public List<Vector3> positionsLast;

	private Vector3 positionPlayerLast;

	[Header("Мир")]
	[SerializeField]
	private GameObject[] littleFoods;

	[SerializeField]
	private BacteriaEnemy[] bacteria;

	private Vector2 screenSize;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void GenerateDistance()
	{
	}

	private void GenerationTime()
	{
	}

	private void ClearTime()
	{
	}

	private void CheckSizeScreen()
	{
	}

	private void RestartWorld()
	{
	}
}

using System;
using System.Collections.Generic;
using UnityEngine;

public class BacteriaBody : MonoBehaviour
{
	[Serializable]
	private class BodyPart
	{
		public Transform bone;

		[Range(0.1f, 1f)]
		public float sizeBone;
	}

	[Serializable]
	private class FoodInBody
	{
		public int indexPart;

		public float foodAnimation;
	}

	private BacteriaMain main;

	[SerializeField]
	private BodyPart[] bodyPart;

	private Rigidbody mainPart;

	[Header("Физика")]
	[SerializeField]
	private float forceMove;

	[SerializeField]
	private float forceRotation;

	private float moveForward;

	private float moveRotation;

	private List<FoodInBody> food;

	[Header("Поедание")]
	[SerializeField]
	private AnimationCurve animationSizePartFood;

	private float timeEyes;

	[Header("Части тела")]
	public BacteriaBodyEye[] eyes;

	public BacteriaBodyMouth[] mouth;

	private int timeLookPosition;

	private float timeLookTarget;

	private Transform lookTarget;

	[HideInInspector]
	public Vector3 positionLook;

	[SerializeField]
	[Header("Редактирование в игре")]
	private bool isEditor;

	public void StartComponent(BacteriaMain _main)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void FixedUpdate()
	{
	}

	public void MoveForward(int _move)
	{
	}

	public void MoveRotate(int _side)
	{
	}

	public void EyeLook(Vector3 _positionLook)
	{
	}

	public void Eat()
	{
	}

	[ContextMenu("Обновить бактерию")]
	public void ResetBacteria()
	{
	}

	public Vector3 GetPositionCenter()
	{
		return default(Vector3);
	}
}

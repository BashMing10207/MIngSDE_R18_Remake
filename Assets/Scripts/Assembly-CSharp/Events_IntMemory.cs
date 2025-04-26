using System;
using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Functions/Event/Event memory")]
public class Events_IntMemory : MonoBehaviour
{
	[Serializable]
	public class SerializableIntMemory
	{
		public int ifInt;

		public UnityEvent _event;
	}

	public SerializableIntMemory[] _memory;

	[Header("Information")]
	public int intMemory;

	public void CheckEvent()
	{
	}

	public void CheckEventIndex(int _index)
	{
	}

	public void Set(int x)
	{
	}

	public void SetIgnory(int x)
	{
	}

	public void Add()
	{
	}

	public void AddIgnory()
	{
	}

	public void Remove()
	{
	}

	public void RemoveIgnory()
	{
	}
}

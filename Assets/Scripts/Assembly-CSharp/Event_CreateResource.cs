using UnityEngine;

public class Event_CreateResource : MonoBehaviour
{
	public enum EventDay
	{
		halloween = 0,
		christmas = 1,
		none = 2
	}

	public EventDay eventDay;

	public bool destroyObjectAfterCreate;

	public Event_CreateResource_Object[] create;

	public Event_CreateResource_Mesh[] meshes;

	public Event_CreateResource_Materials[] materials;

	public DataValues_Material_Texture[] textures;

	public GameObject[] destroyObjects;

	public Component[] destroyComponents;

	private void Start()
	{
	}

	private void Create()
	{
	}
}

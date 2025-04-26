using UnityEngine;

public class ObjectFoot : MonoBehaviour
{
	public float inensityVolume;

	public LayerMask layerDefault;

	private TypeMaterial typeMaterialNow;

	public bool footOnlyStone;

	public FootMaterial footGround;

	public FootMaterial footSand;

	public FootMaterial footGrass;

	public FootMaterial footWood;

	public FootMaterial footIron;

	public FootMaterial footMarble;

	public FootMaterial footSnow;

	public FootMaterial footCarpet;

	public FootMaterial footWater;

	public FootMaterial footDeepWater;

	[Header("Вода")]
	public ParticleSystem particleWater;

	private int timeFootMark;

	[Header("Следы")]
	public GameObject bloodMark;

	public Sprite spriteMark;

	public float sizeMark;

	public float forwardMark;

	private bool foot;

	private bool footRun;

	private GameObject objectLastCreate;

	private Vector3 objectLastCreatePosition;

	private int lastIntStep;

	private void LateUpdate()
	{
	}

	private void FootStepLateUpdate()
	{
	}

	public void FootStep()
	{
	}

	public void FootStepRun()
	{
	}

	public int RandomCorrect(int min, int max)
	{
		return 0;
	}
}

using Coffee.UIEffects;
using UnityEngine;
using UnityEngine.UI;

public class MenuPersonage : MonoBehaviour
{
	private Menu menu;

	private bool closeAlphaDescription;

	[SerializeField]
	[Header("Интерфейс")]
	private Image imageBackground;

	[SerializeField]
	private Text textName;

	[SerializeField]
	private Text textDescription;

	[SerializeField]
	private Image iconDescription;

	[SerializeField]
	private GameObject mitaMain;

	private bool loadingNow;

	[Header("Интерфейс модели")]
	[SerializeField]
	private RectTransform circleLoad;

	[SerializeField]
	private GameObject locationDescriptionModel;

	[SerializeField]
	private GameObject locationDescriptionModelBack;

	[SerializeField]
	private Text textNamePersonage;

	[SerializeField]
	private Text textDescriptionPersonage;

	[SerializeField]
	private RectTransform contentDescription3D;

	[SerializeField]
	private UIGradient colorFramePersonage;

	private bool mitatryOpen;

	[SerializeField]
	[Header("Персонажи")]
	private PersonageResource[] resourcePlayer;

	[SerializeField]
	private PersonageResource[] resourceMita;

	private ResourceRequest asyncLoading;

	private GameObject objectPersonage;

	private float timeFix;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Close()
	{
	}

	public void BackChangePersonage()
	{
	}

	public void OpenPersonage(string _name)
	{
	}
}

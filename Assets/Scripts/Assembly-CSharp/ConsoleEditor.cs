using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleEditor : MonoBehaviour
{
	[HideInInspector]
	public bool fullInfo;

	[Header("Иерархия")]
	public GameObject[] objectsConsoleDeactive;

	public GameObject objectCaseExample;

	public RectTransform contentHierarchy;

	[HideInInspector]
	public List<ConsoleEditor_HierarchyCase> casesRoot;

	[HideInInspector]
	public GameObject obejctChangeNow;

	[Header("Объект")]
	public GameObject panelObject;

	public GameObject activeObject;

	public Text textNameObject;

	public InputField[] textesTransform;

	public GameObject imageStatic;

	[HideInInspector]
	public List<ConsoleEditor_HierarchyComponent> componentsCases;

	[Header("Компоненты")]
	public GameObject componentExample;

	public RectTransform contentComponents;

	[HideInInspector]
	public ConsoleEditor_ComponentCase_MethodCase methodInvoke;

	[HideInInspector]
	public List<GameObject> methodInputCases;

	private ParameterInfo[] parameters;

	[SerializeField]
	[Header("Метод компонента")]
	private GameObject methodInputPrefab;

	[SerializeField]
	private GameObject methodInputBooleanPrefab;

	[HideInInspector]
	public float mouseX;

	private int xPosCaseMax;

	private int xPosCase;

	private int yPosCase;

	private bool enterTransform;

	private InputField hierarchyFind;

	private void Update()
	{
	}

	public void StartEditor()
	{
	}

	public void CloseEditor()
	{
	}

	private void RestartHierarchy()
	{
	}

	public void ChangeObject(GameObject _object)
	{
	}

	private void LoadObjects()
	{
	}

	private List<ConsoleEditor_HierarchyCase> CreateSelfHierarchy(ConsoleEditor_HierarchyCase _case)
	{
		return null;
	}

	private void ClearHierarchy()
	{
	}

	private void ClearHierarchyCases()
	{
	}

	private void ClearHierarchyCasesIn(List<ConsoleEditor_HierarchyCase> _casesMe)
	{
	}

	public void HierarchyUpdate()
	{
	}

	private void HierarchyCreateCases(List<ConsoleEditor_HierarchyCase> _casesMe)
	{
	}

	public void HierarchyCreateCasesSearch(List<ConsoleEditor_HierarchyCase> _casesMe)
	{
	}

	public void CloseAllCasesIn(List<ConsoleEditor_HierarchyCase> _casesMe)
	{
	}

	public void CloseAllCases()
	{
	}

	public void ButtonActiveObject()
	{
	}

	public void ButtonDestroyObject()
	{
	}

	public void ButtonFullInfo()
	{
	}

	public void ButtonCloseMethod()
	{
	}

	public void ButtonInvokeMethod()
	{
	}

	public void StartTransformEnter()
	{
	}

	public void ApplyTransform()
	{
	}

	public void MethodOpen(MethodInfo _method, ConsoleEditor_ComponentCase_MethodCase _methodInvoke)
	{
	}

	private void OnGUI()
	{
	}
}

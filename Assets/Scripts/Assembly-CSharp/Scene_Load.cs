using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[AddComponentMenu("Functions/Scene/Scene load async")]
public class Scene_Load : MonoBehaviour
{
	[SerializeField]
	private UnityEvent eventLoadFinish;

	[SerializeField]
	private string nameSceneLoad;

	[SerializeField]
	private string nameSceneUnload;

	[SerializeField]
	private bool nextOnReadyProgress;

	[SerializeField]
	private LoadSceneMode modeLoad;

	[SerializeField]
	[Header("Сохранение")]
	private GameObject objectSaveInterface;

	[SerializeField]
	private string nameSceneContinue;

	[SerializeField]
	private int stringFileNamePart;

	[SerializeField]
	private string fileSave;

	[SerializeField]
	[Header("Дополнительные сохранения")]
	private string[] nameLevelSaves;

	private bool loadPause;

	private bool loadFinish;

	private AsyncOperation asyncLoad;

	private bool loading;

	private void Update()
	{
	}

	[ContextMenu("Начать загрузку сцены")]
	public void StartLoad()
	{
	}

	public void GoScene()
	{
	}

	private void GoSceneAfterPause()
	{
	}

	public void UnloadScene(string _nameScene)
	{
	}

	public void SaveGame()
	{
	}

	public void SilentSave(int _levelSave)
	{
	}
}

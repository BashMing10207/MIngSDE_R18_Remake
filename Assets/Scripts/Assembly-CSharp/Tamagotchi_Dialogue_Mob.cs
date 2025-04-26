using UnityEngine;
using UnityEngine.Events;

public class Tamagotchi_Dialogue_Mob : MonoBehaviour
{
	[Header("Персона")]
	public Tamagotchi_Dialogue tamagochiDialogue;

	public AudioClip[] sounds;

	public int nameString;

	public string dialogueFile;

	[Header("Диалог")]
	public Tamagotchi_Dialogue_Mob copyPerson;

	public Tamagotchi_Dialogue_Events[] dialogue;

	public UnityEvent eventStop;

	public Tamagotchi_Dialogue_Mob nextDialogue;

	public void StartDialogue()
	{
	}

	public void StopDialogue()
	{
	}
}

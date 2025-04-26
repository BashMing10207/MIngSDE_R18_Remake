using System;
using UnityEngine;

[Serializable]
public class Location7_GameDance_Music
{
	public float speedAnimationMita;

	public float minusTimeClick;

	public float jumpSlow;

	public AudioClip music;

	public AudioClip musicLoop;

	public AudioClip soundTapNo;

	public ParticleSystem particleMenu;

	public Color colorMusic;

	public int indexText;

	public Location7_GameDance_Music_Note[] notes;

	public AnimationCurve animationNotePlayer;

	public AnimationCurve animationNoteMita;

	public float addTimeForMita;
}

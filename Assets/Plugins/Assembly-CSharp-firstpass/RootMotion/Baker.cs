using System;
using UnityEngine;
using UnityEngine.Playables;

namespace RootMotion
{
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		public enum Mode
		{
			AnimationClips = 0,
			AnimationStates = 1,
			PlayableDirector = 2,
			Realtime = 3
		}

		[Range(1f, 90f)]
		[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
		public int frameRate;

		[Tooltip("Maximum allowed error for keyframe reduction.")]
		[Range(0f, 0.1f)]
		public float keyReductionError;

		[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
		public Mode mode;

		[Tooltip("AnimationClips to bake.")]
		public AnimationClip[] animationClips;

		[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select 'Find Animation States' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
		public string[] animationStates;

		[Tooltip("Sets the baked animation clip to loop time and matches the last frame keys with the first. Note that when overwriting a previously baked clip, AnimationClipSettings will be copied from the existing clip.")]
		public bool loop;

		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder;

		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
		public string appendName;

		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName;

		[HideInInspector]
		public Animator animator;

		[HideInInspector]
		public PlayableDirector director;

		public bool isBaking { get; private set; }

		public float bakingProgress { get; private set; }

		protected float clipLength { get; private set; }

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		protected abstract Transform GetCharacterRoot();

		protected abstract void OnStartBaking();

		protected abstract void OnSetLoopFrame(float time);

		protected abstract void OnSetCurves(ref AnimationClip clip);

		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		public void BakeClip()
		{
		}

		public void StartBaking()
		{
		}

		public void StopBaking()
		{
		}
	}
}

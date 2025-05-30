using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace RootMotion.FinalIK
{
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	public class InteractionSystem : MonoBehaviour
	{
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[FormerlySerializedAs("collider")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[Header("Triggering")]
		public Collider characterCollider;

		[FormerlySerializedAs("camera")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		public Transform FPSCamera;

		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		private List<InteractionTrigger> inContact;

		private List<int> bestRangeIndexes;

		public InteractionDelegate OnInteractionStart;

		public InteractionDelegate OnInteractionPause;

		public InteractionDelegate OnInteractionPickUp;

		public InteractionDelegate OnInteractionResume;

		public InteractionDelegate OnInteractionStop;

		public InteractionEventDelegate OnInteractionEvent;

		public RaycastHit raycastHit;

		[Space(10f)]
		[SerializeField]
		[Tooltip("Reference to the FBBIK component.")]
		private FullBodyBipedIK fullBody;

		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		private InteractionEffector[] interactionEffectors;

		private Collider lastCollider;

		private Collider c;

		public bool inInteraction => false;

		public FullBodyBipedIK ik
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<InteractionTrigger> triggersInRange { get; private set; }

		public bool initiated { get; private set; }

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[ContextMenu("Support")]
		private void SupportGroup()
		{
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return false;
		}

		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return false;
		}

		public bool IsPaused()
		{
			return false;
		}

		public bool IsInSync()
		{
			return false;
		}

		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return false;
		}

		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return false;
		}

		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return false;
		}

		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return false;
		}

		public void PauseAll()
		{
		}

		public void ResumeAll()
		{
		}

		public void StopAll()
		{
		}

		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return 0f;
		}

		public float GetMinActiveProgress()
		{
			return 0f;
		}

		public bool TriggerInteraction(int index, bool interrupt)
		{
			return false;
		}

		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			interactionObject = null;
			return false;
		}

		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			interactionTarget = null;
			return false;
		}

		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		public bool TriggerEffectorsReady(int index)
		{
			return false;
		}

		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		public int GetClosestTriggerIndex()
		{
			return 0;
		}

		public void Start()
		{
		}

		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		public void OnTriggerEnter(Collider c)
		{
		}

		public void OnTriggerExit(Collider c)
		{
		}

		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			bestRangeIndex = default(int);
			return false;
		}

		private void OnDrawGizmosSelected()
		{
		}

		public void Update()
		{
		}

		private void Raycasting()
		{
		}

		private void UpdateTriggerEventBroadcasting()
		{
		}

		private void UpdateEffectors()
		{
		}

		private void OnPreFBBIK()
		{
		}

		private void OnPostFBBIK()
		{
		}

		private void OnFixTransforms()
		{
		}

		private void OnDestroy()
		{
		}

		private bool IsValid(bool log)
		{
			return false;
		}

		private bool TriggerIndexIsValid(int index)
		{
			return false;
		}
	}
}

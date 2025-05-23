using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		public class OffsetLimits
		{
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Tooltip("The limits")]
			public float minX;

			[Tooltip("The limits")]
			public float maxX;

			[Tooltip("The limits")]
			public float minY;

			[Tooltip("The limits")]
			public float maxY;

			[Tooltip("The limits")]
			public float minZ;

			[Tooltip("The limits")]
			public float maxZ;

			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			private float SpringAxis(float value, float min, float max)
			{
				return 0f;
			}

			private float Spring(float value, float limit, bool negative)
			{
				return 0f;
			}
		}

		[CompilerGenerated]
		private sealed class _003CInitiate_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OffsetModifier _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInitiate_003Ed__8(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Tooltip("The master weight")]
		public float weight;

		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		protected float lastTime;

		protected float deltaTime => 0f;

		protected abstract void OnModifyOffset();

		protected virtual void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CInitiate_003Ed__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		private void ModifyOffset()
		{
		}

		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		protected virtual void OnDestroy()
		{
		}
	}
}

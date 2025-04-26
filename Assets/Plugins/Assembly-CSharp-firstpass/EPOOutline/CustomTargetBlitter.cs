using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace EPOOutline
{
	[ExecuteAlways]
	public class CustomTargetBlitter : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CBlit_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CustomTargetBlitter _003C_003E4__this;

			private WaitForEndOfFrame _003CwaitForEndOfFrame_003E5__2;

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
			public _003CBlit_003Ed__9(int _003C_003E1__state)
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

		[SerializeField]
		private string customTargetName;

		private CommandBuffer buffer;

		private Material blitMaterial;

		private Coroutine blitProcess;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void CheckMaterial()
		{
		}

		[IteratorStateMachine(typeof(_003CBlit_003Ed__9))]
		private IEnumerator Blit()
		{
			return null;
		}
	}
}

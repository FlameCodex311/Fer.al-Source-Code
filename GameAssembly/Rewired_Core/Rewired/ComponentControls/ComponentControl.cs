/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
	public abstract class ComponentControl : UnityEngine.MonoBehaviour, IComponentControl // TypeDefIndex: 5952
	{
		// Fields
		private IComponentController _controller; // 0x18
		[NonSerialized]
		private bool ZjOOLblNcYQwrXXNEEJgJyiCsWf; // 0x20
		[NonSerialized]
		private bool eWmIQnowqnQnKiVcsFDbGrDwNfz; // 0x21
		private int _lastUpdateFrame; // 0x24
	
		// Properties
		internal abstract bool hasController { get; }
		internal bool initialized { get; } // 0x00000001803FA090-0x00000001803FA0A0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class vDaYfPtEiqmInLjinFexdEcFKYw : IEnumerator<object> // TypeDefIndex: 5953
		{
			// Fields
			private object aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			public ComponentControl gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
	
			// Properties
			object QGqPetJmjramAjqiOgIAXgxEFKEb { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public vDaYfPtEiqmInLjinFexdEcFKYw(int <>1__state); // 0x0000000180924460-0x0000000180924490
	
			// Methods
			private bool MoveNext(); // 0x00000001809242A0-0x0000000180924410
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180924410-0x0000000180924460
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal ComponentControl(); // 0x0000000180910910-0x0000000180910920
	
		// Methods
		public abstract void ClearValue();
		void IComponentControl.Update(); // 0x00000001809106F0-0x0000000180910740
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void Awake(); // 0x0000000180910130-0x0000000180910140
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void Start(); // 0x00000001803774A0-0x00000001803774B0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void OnEnable(); // 0x0000000180910500-0x00000001809105B0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void OnDisable(); // 0x00000001809104C0-0x0000000180910500
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void OnDestroy(); // 0x00000001803774A0-0x00000001803774B0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void OnValidate(); // 0x00000001809106D0-0x00000001809106F0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void OnCanvasGroupChanged(); // 0x00000001809104A0-0x00000001809104C0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void OnTransformParentChanged(); // 0x00000001809106A0-0x00000001809106C0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void OnDidApplyAnimationProperties(); // 0x00000001803774A0-0x00000001803774B0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void Reset(); // 0x00000001803774A0-0x00000001803774B0
		internal virtual void OnUpdate(); // 0x00000001803774A0-0x00000001803774B0
		internal virtual bool OnInitialize(); // 0x00000001809105B0-0x0000000180910620
		internal virtual void WFAGIZjSiiMwzmaHWHrBHRQZFpHG(); // 0x0000000180910740-0x00000001809107D0
		internal virtual void OnSubscribeEvents(); // 0x0000000180910660-0x00000001809106A0
		internal virtual void OnUnsubscribeEvents(); // 0x00000001809106C0-0x00000001809106D0
		internal virtual void OnSetProperty(); // 0x0000000180910620-0x0000000180910660
		internal virtual void OnClear(); // 0x00000001803774A0-0x00000001803774B0
		internal virtual void FindEventHandlers(); // 0x00000001803774A0-0x00000001803774B0
		internal bool pZZsjZGxmnNFXfvvyEpNHpEJHxn(); // 0x0000000180910920-0x0000000180910980
		internal bool qLpKhZHHXXFrTNsbtDCudYkkOPzW(); // 0x0000000180910980-0x00000001809109E0
		internal IComponentController LKaeclUBVOWnEmgeJcBnjqBnXI(); // 0x0000000180372430-0x0000000180372440
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal abstract IComponentController FindController();
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal abstract Type GetRequiredControllerType();
		private IEnumerator YsYHCkAiAOXNcPmMSVGrvIeeXxW(); // 0x00000001809107D0-0x0000000180910850
		private void DeRyKKaIFeIgBBjcstmktRxedrNm(); // 0x0000000180910140-0x00000001809101C0
		private bool GEgOhDhFWzlyUDjyMHeIcciCspI(bool param_0000c8e4, bool param_0000c8e5); // 0x00000001809101C0-0x0000000180910490
		private void LZtLIradkTZxeuvnkQoCvQBxNXr(); // 0x0000000180910490-0x00000001809104A0
		private void ZGVHnXXDseHxZFDLQjcaXQZEgJG(); // 0x0000000180910850-0x0000000180910910
	}
}

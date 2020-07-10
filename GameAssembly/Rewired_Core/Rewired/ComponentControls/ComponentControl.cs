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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public abstract class ComponentControl : UnityEngine.MonoBehaviour, IComponentControl // TypeDefIndex: 5793
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
		internal bool initialized { get; } // 0x00000001803C19E0-0x00000001803C19F0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class vDaYfPtEiqmInLjinFexdEcFKYw : IEnumerator<object> // TypeDefIndex: 5794
		{
			// Fields
			private object aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			public ComponentControl gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
	
			// Properties
			object QGqPetJmjramAjqiOgIAXgxEFKEb { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public vDaYfPtEiqmInLjinFexdEcFKYw(int <>1__state); // 0x0000000181446CC0-0x0000000181446CF0
	
			// Methods
			private bool MoveNext(); // 0x0000000181446B00-0x0000000181446C70
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181446C70-0x0000000181446CC0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal ComponentControl(); // 0x0000000181432EB0-0x0000000181432EC0
	
		// Methods
		public abstract void ClearValue();
		void IComponentControl.Update(); // 0x0000000181432C90-0x0000000181432CE0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void Awake(); // 0x00000001814326D0-0x00000001814326E0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void Start(); // 0x00000001803581E0-0x00000001803581F0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void OnEnable(); // 0x0000000181432AA0-0x0000000181432B50
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void OnDisable(); // 0x0000000181432A60-0x0000000181432AA0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void OnDestroy(); // 0x00000001803581E0-0x00000001803581F0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void OnValidate(); // 0x0000000181432C70-0x0000000181432C90
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void OnCanvasGroupChanged(); // 0x0000000181432A40-0x0000000181432A60
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void OnTransformParentChanged(); // 0x0000000181432C40-0x0000000181432C60
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void OnDidApplyAnimationProperties(); // 0x00000001803581E0-0x00000001803581F0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void Reset(); // 0x00000001803581E0-0x00000001803581F0
		internal virtual void OnUpdate(); // 0x00000001803581E0-0x00000001803581F0
		internal virtual bool OnInitialize(); // 0x0000000181432B50-0x0000000181432BC0
		internal virtual void WFAGIZjSiiMwzmaHWHrBHRQZFpHG(); // 0x0000000181432CE0-0x0000000181432D70
		internal virtual void OnSubscribeEvents(); // 0x0000000181432C00-0x0000000181432C40
		internal virtual void OnUnsubscribeEvents(); // 0x0000000181432C60-0x0000000181432C70
		internal virtual void OnSetProperty(); // 0x0000000181432BC0-0x0000000181432C00
		internal virtual void OnClear(); // 0x00000001803581E0-0x00000001803581F0
		internal virtual void FindEventHandlers(); // 0x00000001803581E0-0x00000001803581F0
		internal bool pZZsjZGxmnNFXfvvyEpNHpEJHxn(); // 0x0000000181432EC0-0x0000000181432F20
		internal bool qLpKhZHHXXFrTNsbtDCudYkkOPzW(); // 0x0000000181432F20-0x0000000181432F80
		internal IComponentController LKaeclUBVOWnEmgeJcBnjqBnXI(); // 0x000000018038B150-0x000000018038B160
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal abstract IComponentController FindController();
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal abstract Type GetRequiredControllerType();
		private IEnumerator YsYHCkAiAOXNcPmMSVGrvIeeXxW(); // 0x0000000181432D70-0x0000000181432DF0
		private void DeRyKKaIFeIgBBjcstmktRxedrNm(); // 0x00000001814326E0-0x0000000181432760
		private bool GEgOhDhFWzlyUDjyMHeIcciCspI(bool param_0000c674, bool param_0000c675); // 0x0000000181432760-0x0000000181432A30
		private void LZtLIradkTZxeuvnkQoCvQBxNXr(); // 0x0000000181432A30-0x0000000181432A40
		private void ZGVHnXXDseHxZFDLQjcaXQZEgJG(); // 0x0000000181432DF0-0x0000000181432EB0
	}
}

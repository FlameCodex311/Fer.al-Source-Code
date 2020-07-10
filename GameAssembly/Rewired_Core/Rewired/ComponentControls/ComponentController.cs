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
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public abstract class ComponentController : UnityEngine.MonoBehaviour, IComponentController // TypeDefIndex: 5797
	{
		// Fields
		[NonSerialized]
		private bool ZjOOLblNcYQwrXXNEEJgJyiCsWf; // 0x18
		[NonSerialized]
		private bool eWmIQnowqnQnKiVcsFDbGrDwNfz; // 0x19
		private List<IComponentControl> _controls; // 0x20
	
		// Properties
		internal bool initialized { get; } // 0x000000018041BAC0-0x000000018041BAD0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class vvYvuJCMSULdnHkbBqpUNlHXEtG : IEnumerator<object> // TypeDefIndex: 5798
		{
			// Fields
			private object aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			public ComponentController gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
	
			// Properties
			object QGqPetJmjramAjqiOgIAXgxEFKEb { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public vvYvuJCMSULdnHkbBqpUNlHXEtG(int <>1__state); // 0x0000000181446CC0-0x0000000181446CF0
	
			// Methods
			private bool MoveNext(); // 0x0000000181446CF0-0x0000000181446DC0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181446DC0-0x0000000181446E10
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal ComponentController(); // 0x0000000181433690-0x0000000181433700
	
		// Methods
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void Awake(); // 0x0000000181432F80-0x0000000181432F90
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void Update(); // 0x00000001814334B0-0x0000000181433690
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void OnEnable(); // 0x00000001814332C0-0x00000001814333B0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void OnDisable(); // 0x00000001814332A0-0x00000001814332C0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void OnValidate(); // 0x0000000180567730-0x0000000180567740
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void OnDestroy(); // 0x0000000181433250-0x00000001814332A0
		internal virtual bool OnInitialize(); // 0x00000001803C29F0-0x00000001803C2A00
		internal virtual void OnSubscribeEvents(); // 0x0000000180B1FBB0-0x0000000180B1FBD0
		internal virtual void OnUnsubscribeEvents(); // 0x00000001803581E0-0x00000001803581F0
		void IRegistrar<IComponentControl>.Register(IComponentControl param_0000c679); // 0x0000000181433450-0x00000001814334B0
		void IRegistrar<IComponentControl>.Deregister(IComponentControl param_0000c67a); // 0x00000001814333B0-0x0000000181433450
		public virtual void ClearControlValues(); // 0x0000000181432F90-0x0000000181433190
		private void DeRyKKaIFeIgBBjcstmktRxedrNm(); // 0x0000000181433190-0x00000001814331F0
		private void cmtbuFqVYbwoFNiprYsdGZCxOJZ(); // 0x00000001803581E0-0x00000001803581F0
		private IEnumerator GTHIUozEeYqGuSBqusjhCpEyriq(); // 0x00000001814331F0-0x0000000181433250
	}
}

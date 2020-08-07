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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
	public abstract class ComponentController : UnityEngine.MonoBehaviour, IComponentController // TypeDefIndex: 5956
	{
		// Fields
		[NonSerialized]
		private bool ZjOOLblNcYQwrXXNEEJgJyiCsWf; // 0x18
		[NonSerialized]
		private bool eWmIQnowqnQnKiVcsFDbGrDwNfz; // 0x19
		private List<IComponentControl> _controls; // 0x20
	
		// Properties
		internal bool initialized { get; } // 0x00000001803F6D30-0x00000001803F6D40 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class vvYvuJCMSULdnHkbBqpUNlHXEtG : IEnumerator<object> // TypeDefIndex: 5957
		{
			// Fields
			private object aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			public ComponentController gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
	
			// Properties
			object QGqPetJmjramAjqiOgIAXgxEFKEb { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public vvYvuJCMSULdnHkbBqpUNlHXEtG(int <>1__state); // 0x0000000180924460-0x0000000180924490
	
			// Methods
			private bool MoveNext(); // 0x0000000180924490-0x0000000180924560
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180924560-0x00000001809245B0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal ComponentController(); // 0x0000000180911100-0x0000000180911170
	
		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void Awake(); // 0x00000001809109E0-0x00000001809109F0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void Update(); // 0x0000000180910F30-0x0000000180911100
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void OnEnable(); // 0x0000000180910D20-0x0000000180910E10
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void OnDisable(); // 0x0000000180910D00-0x0000000180910D20
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void OnValidate(); // 0x0000000180910E30-0x0000000180910E40
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void OnDestroy(); // 0x0000000180910CB0-0x0000000180910D00
		internal virtual bool OnInitialize(); // 0x0000000180380B60-0x0000000180380B70
		internal virtual void OnSubscribeEvents(); // 0x0000000180910E10-0x0000000180910E30
		internal virtual void OnUnsubscribeEvents(); // 0x00000001803774A0-0x00000001803774B0
		void IRegistrar<IComponentControl>.Register(IComponentControl param_0000c8e9); // 0x0000000180910ED0-0x0000000180910F30
		void IRegistrar<IComponentControl>.Deregister(IComponentControl param_0000c8ea); // 0x0000000180910E40-0x0000000180910ED0
		public virtual void ClearControlValues(); // 0x00000001809109F0-0x0000000180910BF0
		private void DeRyKKaIFeIgBBjcstmktRxedrNm(); // 0x0000000180910BF0-0x0000000180910C50
		private void cmtbuFqVYbwoFNiprYsdGZCxOJZ(); // 0x00000001803774A0-0x00000001803774B0
		private IEnumerator GTHIUozEeYqGuSBqusjhCpEyriq(); // 0x0000000180910C50-0x0000000180910CB0
	}
}

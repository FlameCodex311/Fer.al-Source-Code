/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.Networking;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x0000000180220220-0x0000000180220310
	[Color] // 0x0000000180220220-0x0000000180220310
	[Description] // 0x0000000180220220-0x0000000180220310
	[Icon] // 0x0000000180220220-0x0000000180220310
	[Name] // 0x0000000180220220-0x0000000180220310
	public class InternetConnected : BTComposite // TypeDefIndex: 15189
	{
		// Fields
		public ERepeat repeatType; // 0x88
		public BBParameter<bool> connected; // 0x90
		private Status _status; // 0x98
		private bool _waiting; // 0x9C
	
		// Nested types
		public enum ERepeat // TypeDefIndex: 15190
		{
			NONE = 0,
			ONFAILURE = 1,
			ONSUCCESS = 2,
			ALWAYS = 3
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Connected>d__6 : IEnumerator<object> // TypeDefIndex: 15191
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Action<bool> internetConnectedCallback; // 0x20
			private UnityWebRequest <internetCheckWebRequest>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Connected>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001808B5FD0-0x00000001808B6460
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001808B6460-0x00000001808B64B0
		}
	
		// Constructors
		public InternetConnected(); // 0x00000001808AFA30-0x00000001808AFA50
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808AF880-0x00000001808AF970
		[IteratorStateMachine] // 0x0000000180220960-0x00000001802209B0
		private IEnumerator Connected(Action<bool> internetConnectedCallback); // 0x00000001808AF820-0x00000001808AF880
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnExecute>b__5_0(bool bConnected); // 0x00000001808AF970-0x00000001808AFA30
	}
}

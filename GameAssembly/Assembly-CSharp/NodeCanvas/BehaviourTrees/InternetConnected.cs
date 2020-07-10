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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x0000000180171850-0x0000000180171940
	[Color] // 0x0000000180171850-0x0000000180171940
	[Description] // 0x0000000180171850-0x0000000180171940
	[Icon] // 0x0000000180171850-0x0000000180171940
	[Name] // 0x0000000180171850-0x0000000180171940
	public class InternetConnected : BTComposite // TypeDefIndex: 14069
	{
		// Fields
		public ERepeat repeatType; // 0x78
		public BBParameter<bool> connected; // 0x80
		private Status _status; // 0x88
		private bool _waiting; // 0x8C
	
		// Nested types
		public enum ERepeat // TypeDefIndex: 14070
		{
			NONE = 0,
			ONFAILURE = 1,
			ONSUCCESS = 2,
			ALWAYS = 3
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Connected>d__6 : IEnumerator<object> // TypeDefIndex: 14071
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Action<bool> internetConnectedCallback; // 0x20
			private UnityWebRequest <internetCheckWebRequest>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Connected>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181574B70-0x0000000181575010
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181575010-0x0000000181575060
		}
	
		// Constructors
		public InternetConnected(); // 0x0000000181568420-0x0000000181568440
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000181568280-0x0000000181568370
		[IteratorStateMachine] // 0x0000000180171ED0-0x0000000180171F20
		private IEnumerator Connected(Action<bool> internetConnectedCallback); // 0x0000000181568220-0x0000000181568280
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnExecute>b__5_0(bool bConnected); // 0x0000000181568370-0x0000000181568420
	}
}

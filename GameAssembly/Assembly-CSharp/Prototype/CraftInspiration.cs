/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype
{
	public class CraftInspiration : Interactable // TypeDefIndex: 16064
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private MeshRenderer _meshRenderer; // 0x1A0
		private string _inspirationDefId; // 0x1A8
		private InspirationDefComponent _inspirationDef; // 0x1B0
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public string texturePath; // 0x1B8
		private static CraftInspiration _craftInspiration; // 0x00
	
		// Properties
		public InspirationDefComponent inspirationDef { get; } // 0x000000018139DB90-0x000000018139DC20 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <SetInteractionAllow>d__10 : IEnumerator<object> // TypeDefIndex: 16065
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CraftInspiration <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <SetInteractionAllow>d__10(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813ACA90-0x00000001813ACBA0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813ACBA0-0x00000001813ACBF0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <GetTextureRoutine>d__12 : IEnumerator<object> // TypeDefIndex: 16066
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CraftInspiration <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <GetTextureRoutine>d__12(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813A8BE0-0x00000001813A8E40
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813A90C0-0x00000001813A9110
		}
	
		// Constructors
		public CraftInspiration(); // 0x0000000180F5D120-0x0000000180F5D130
	
		// Methods
		public static CraftInspiration Get(); // 0x000000018139D7E0-0x000000018139D880
		public void Setup(string inInspirationDefId); // 0x000000018139D9F0-0x000000018139DB20
		public override void MStart(); // 0x000000018139D880-0x000000018139D8F0
		[IteratorStateMachine] // 0x00000001800FA2A0-0x00000001800FA2F0
		private IEnumerator SetInteractionAllow(); // 0x000000018139D990-0x000000018139D9F0
		public void Collect(); // 0x000000018139D6C0-0x000000018139D780
		[IteratorStateMachine] // 0x00000001800FA5A0-0x00000001800FA5F0
		private IEnumerator GetTextureRoutine(); // 0x000000018139D780-0x000000018139D7E0
		private new void OnDrawGizmosSelected(); // 0x000000018139D8F0-0x000000018139D990
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <GetTextureRoutine>b__12_0(Texture loadedAsset); // 0x000000018139DB20-0x000000018139DB90
	}
}

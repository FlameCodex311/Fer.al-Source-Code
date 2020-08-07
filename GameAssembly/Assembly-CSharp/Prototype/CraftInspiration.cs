/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype
{
	public class CraftInspiration : Interactable // TypeDefIndex: 14803
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private MeshRenderer _meshRenderer; // 0x1A0
		private string _inspirationDefId; // 0x1A8
		private InspirationDefComponent _inspirationDef; // 0x1B0
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string texturePath; // 0x1B8
		private static CraftInspiration _craftInspiration; // 0x00
	
		// Properties
		public InspirationDefComponent inspirationDef { get; } // 0x0000000180D94D80-0x0000000180D94E10 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <SetInteractionAllow>d__10 : IEnumerator<object> // TypeDefIndex: 14804
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CraftInspiration <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <SetInteractionAllow>d__10(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE0DE0-0x0000000180AE0EF0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE0EF0-0x0000000180AE0F40
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <GetTextureRoutine>d__12 : IEnumerator<object> // TypeDefIndex: 14805
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CraftInspiration <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <GetTextureRoutine>d__12(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180ADF520-0x0000000180ADF770
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180ADF770-0x0000000180ADF7C0
		}
	
		// Constructors
		public CraftInspiration(); // 0x00000001804EF080-0x00000001804EF090
	
		// Methods
		public static CraftInspiration Get(); // 0x0000000180D94A50-0x0000000180D94AF0
		public void Setup(string inInspirationDefId); // 0x0000000180D94BE0-0x0000000180D94D10
		public override void MStart(); // 0x0000000180D94AF0-0x0000000180D94B70
		[IteratorStateMachine] // 0x0000000180215920-0x0000000180215970
		private IEnumerator SetInteractionAllow(); // 0x0000000180D94B70-0x0000000180D94BE0
		public void Collect(); // 0x0000000180D94920-0x0000000180D949E0
		[IteratorStateMachine] // 0x0000000180215C80-0x0000000180215CD0
		private IEnumerator GetTextureRoutine(); // 0x0000000180D949E0-0x0000000180D94A50
		private new void OnDrawGizmosSelected(); // 0x0000000180A3CFE0-0x0000000180A3D080
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <GetTextureRoutine>b__12_0(Texture loadedAsset); // 0x0000000180D94D10-0x0000000180D94D80
	}
}

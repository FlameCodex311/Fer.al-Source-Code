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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001801242D0-0x0000000180124330
	[Description] // 0x00000001801242D0-0x0000000180124330
	public class RotateTransformOverTime : ActionTask<Transform> // TypeDefIndex: 14444
	{
		// Fields
		public BBParameter<Vector3> rotation; // 0x68
		public BBParameter<float> duration; // 0x70
		public BBParameter<bool> additive; // 0x78
		public BBParameter<bool> waitToContinue; // 0x80
		private Vector3 endRot; // 0x88
	
		// Properties
		protected override string info { get; } // 0x000000018125C230-0x000000018125C6F0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RotateIt>d__8 : IEnumerator<object> // TypeDefIndex: 14445
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RotateTransformOverTime <>4__this; // 0x20
			private Vector3 <startRot>5__2; // 0x28
			private float <t>5__3; // 0x34
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RotateIt>d__8(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181267E00-0x0000000181268170
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181268170-0x00000001812681C0
		}
	
		// Constructors
		public RotateTransformOverTime(); // 0x000000018125C1E0-0x000000018125C230
	
		// Methods
		protected override void OnExecute(); // 0x000000018125BD60-0x000000018125C180
		[IteratorStateMachine] // 0x00000001801245F0-0x0000000180124640
		private IEnumerator RotateIt(); // 0x000000018125C180-0x000000018125C1E0
	}
}

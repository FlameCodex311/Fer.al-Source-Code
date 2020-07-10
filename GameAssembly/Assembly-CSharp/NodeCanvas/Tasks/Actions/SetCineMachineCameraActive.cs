/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001801272A0-0x0000000180127300
	[Description] // 0x00000001801272A0-0x0000000180127300
	public class SetCineMachineCameraActive : ActionTask<GameObject> // TypeDefIndex: 14450
	{
		// Fields
		public BBParameter<CinemachineVirtualCamera> cinemachineVirtualCamera; // 0x68
		public BBParameter<bool> setActive; // 0x70
		public BBParameter<FeralAudioEmitter> audioEmitter; // 0x78
		public BBParameter<float> audioDelay; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018125F3F0-0x000000018125F4F0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ReEnable>d__8 : IEnumerator<object> // TypeDefIndex: 14451
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CinemachineVirtualCamera inVirtualCamera; // 0x20
			public SetCineMachineCameraActive <>4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ReEnable>d__8(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001812676F0-0x0000000181267DB0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181267DB0-0x0000000181267E00
		}
	
		// Constructors
		public SetCineMachineCameraActive(); // 0x000000018125F3A0-0x000000018125F3F0
	
		// Methods
		protected override string OnInit(); // 0x000000018125F110-0x000000018125F1A0
		protected override void OnExecute(); // 0x000000018125EB30-0x000000018125F110
		[IteratorStateMachine] // 0x00000001801275B0-0x0000000180127600
		private IEnumerator ReEnable(CinemachineVirtualCamera inVirtualCamera); // 0x000000018125F1A0-0x000000018125F210
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnExecute>b__7_0(); // 0x000000018125F210-0x000000018125F340
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnExecute>b__7_1(); // 0x000000018125F340-0x000000018125F3A0
	}
}

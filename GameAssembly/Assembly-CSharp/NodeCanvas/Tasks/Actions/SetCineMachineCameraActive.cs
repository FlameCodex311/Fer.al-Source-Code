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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180290B90-0x0000000180290BF0
	[Description] // 0x0000000180290B90-0x0000000180290BF0
	public class SetCineMachineCameraActive : ActionTask<GameObject> // TypeDefIndex: 15556
	{
		// Fields
		public BBParameter<CinemachineVirtualCamera> cinemachineVirtualCamera; // 0x68
		public BBParameter<bool> setActive; // 0x70
		public BBParameter<FeralAudioEmitter> audioEmitter; // 0x78
		public BBParameter<float> audioDelay; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807A3F00-0x00000001807A4000 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ReEnable>d__8 : IEnumerator<object> // TypeDefIndex: 15557
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CinemachineVirtualCamera inVirtualCamera; // 0x20
			public SetCineMachineCameraActive <>4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ReEnable>d__8(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001807ABB00-0x00000001807AC1A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001807AC1A0-0x00000001807AC1F0
		}
	
		// Constructors
		public SetCineMachineCameraActive(); // 0x00000001807A3EB0-0x00000001807A3F00
	
		// Methods
		protected override string OnInit(); // 0x00000001807A3C30-0x00000001807A3CC0
		protected override void OnExecute(); // 0x00000001807A3660-0x00000001807A3C30
		[IteratorStateMachine] // 0x0000000180291F60-0x0000000180291FB0
		private IEnumerator ReEnable(CinemachineVirtualCamera inVirtualCamera); // 0x00000001807A3CC0-0x00000001807A3D30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnExecute>b__7_0(); // 0x00000001807A3D30-0x00000001807A3E50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnExecute>b__7_1(); // 0x00000001807A3E50-0x00000001807A3EB0
	}
}

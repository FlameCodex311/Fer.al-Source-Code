/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Coffee.UIExtensions
{
	[Serializable]
	public class EffectPlayer // TypeDefIndex: 16326
	{
		// Fields
		[Tooltip] // 0x00000001801F0E00-0x00000001801F0E30
		public bool play; // 0x10
		[Tooltip] // 0x00000001801F0F60-0x00000001801F0F90
		public bool loop; // 0x11
		[Range] // 0x00000001801F1270-0x00000001801F12D0
		[Tooltip] // 0x00000001801F1270-0x00000001801F12D0
		public float duration; // 0x14
		[Range] // 0x00000001801F1560-0x00000001801F15C0
		[Tooltip] // 0x00000001801F1560-0x00000001801F15C0
		public float loopDelay; // 0x18
		[Tooltip] // 0x00000001801F1870-0x00000001801F18A0
		public AnimatorUpdateMode updateMode; // 0x1C
		private static List<Action> s_UpdateActions; // 0x00
		private float _time; // 0x20
		private Action<float> _callback; // 0x28
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 16327
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Canvas.WillRenderCanvases <>9__6_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180786FA0-0x0000000180787000
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <OnEnable>b__6_0(); // 0x0000000180786910-0x0000000180786A00
		}
	
		// Constructors
		public EffectPlayer(); // 0x00000001807843A0-0x00000001807843B0
	
		// Methods
		public void OnEnable(Action<float> callback = null); // 0x0000000180784110-0x00000001807842A0
		public void OnDisable(); // 0x0000000180784070-0x0000000180784110
		public void Play(Action<float> callback = null); // 0x0000000180784370-0x0000000180784390
		public void Stop(); // 0x0000000180784390-0x00000001807843A0
		private void OnWillRenderCanvases(); // 0x00000001807842A0-0x0000000180784370
	}
}

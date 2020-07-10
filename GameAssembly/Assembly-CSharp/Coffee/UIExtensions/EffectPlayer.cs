/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Coffee.UIExtensions
{
	[Serializable]
	public class EffectPlayer // TypeDefIndex: 15487
	{
		// Fields
		[Tooltip] // 0x00000001800EBBD0-0x00000001800EBC00
		public bool play; // 0x10
		[Tooltip] // 0x00000001800EBE30-0x00000001800EBE60
		public bool loop; // 0x11
		[Range] // 0x00000001800EBF80-0x00000001800EBFE0
		[Tooltip] // 0x00000001800EBF80-0x00000001800EBFE0
		public float duration; // 0x14
		[Range] // 0x00000001800EC0F0-0x00000001800EC150
		[Tooltip] // 0x00000001800EC0F0-0x00000001800EC150
		public float loopDelay; // 0x18
		[Tooltip] // 0x00000001800EC330-0x00000001800EC360
		public AnimatorUpdateMode updateMode; // 0x1C
		private static List<Action> s_UpdateActions; // 0x00
		private float _time; // 0x20
		private Action<float> _callback; // 0x28
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 15488
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Canvas.WillRenderCanvases <>9__6_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000181281EF0-0x0000000181281F50
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <OnEnable>b__6_0(); // 0x0000000181281720-0x0000000181281810
		}
	
		// Constructors
		public EffectPlayer(); // 0x000000018127EAF0-0x000000018127EB00
	
		// Methods
		public void OnEnable(Action<float> callback = null); // 0x000000018127E860-0x000000018127E9F0
		public void OnDisable(); // 0x000000018127E7C0-0x000000018127E860
		public void Play(Action<float> callback = null); // 0x000000018127EAC0-0x000000018127EAE0
		public void Stop(); // 0x000000018127EAE0-0x000000018127EAF0
		private void OnWillRenderCanvases(); // 0x000000018127E9F0-0x000000018127EAC0
	}
}

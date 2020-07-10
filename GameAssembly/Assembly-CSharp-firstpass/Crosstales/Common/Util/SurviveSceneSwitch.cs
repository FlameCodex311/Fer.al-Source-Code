/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.Common.Util
{
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public class SurviveSceneSwitch : UnityEngine.MonoBehaviour // TypeDefIndex: 9940
	{
		// Fields
		[Tooltip] // 0x000000018010DB20-0x000000018010DB50
		public GameObject[] Survivors; // 0x18
		[Tooltip] // 0x000000018010DD90-0x000000018010DDC0
		public bool DontDestroy; // 0x20
		private const float ensureParentTime = 1.5f; // Metadata: 0x00746313
		private float ensureParentTimer; // 0x24
		private static SurviveSceneSwitch instance; // 0x00
		private static Transform tf; // 0x08
		private static bool loggedOnlyOneInstance; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 9941
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<GameObject, bool> <>9__7_0; // 0x08
			public static Func<GameObject, bool> <>9__9_0; // 0x10
	
			// Constructors
			static <>c(); // 0x00000001815ED9B0-0x00000001815EDA10
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <OnEnable>b__7_0(GameObject _go); // 0x00000001815ED540-0x00000001815ED5A0
			internal bool <Update>b__9_0(GameObject _go); // 0x00000001815ED5B0-0x00000001815ED610
		}
	
		// Constructors
		public SurviveSceneSwitch(); // 0x000000018061F370-0x000000018061F3C0
		static SurviveSceneSwitch(); // 0x00000001803581E0-0x00000001803581F0
	
		// Methods
		public void OnEnable(); // 0x00000001815EC190-0x00000001815EC750
		public void Start(); // 0x00000001815EC750-0x00000001815EC760
		public void Update(); // 0x00000001815EC760-0x00000001815EC9D0
	}
}

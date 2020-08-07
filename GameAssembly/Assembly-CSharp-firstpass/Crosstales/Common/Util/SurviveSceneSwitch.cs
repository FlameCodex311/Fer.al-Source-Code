/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace Crosstales.Common.Util
{
	[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class SurviveSceneSwitch : UnityEngine.MonoBehaviour // TypeDefIndex: 9726
	{
		// Fields
		[Tooltip] // 0x00000001801EF1B0-0x00000001801EF1E0
		public GameObject[] Survivors; // 0x18
		[Tooltip] // 0x00000001801EF3E0-0x00000001801EF410
		public bool DontDestroy; // 0x20
		private const float ensureParentTime = 1.5f; // Metadata: 0x0077A5DE
		private float ensureParentTimer; // 0x24
		private static SurviveSceneSwitch instance; // 0x00
		private static Transform tf; // 0x08
		private static bool loggedOnlyOneInstance; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 9727
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<GameObject, bool> <>9__7_0; // 0x08
			public static Func<GameObject, bool> <>9__9_0; // 0x10
	
			// Constructors
			static <>c(); // 0x000000018108D610-0x000000018108D670
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <OnEnable>b__7_0(GameObject _go); // 0x000000018108D1A0-0x000000018108D200
			internal bool <Update>b__9_0(GameObject _go); // 0x000000018108D210-0x000000018108D270
		}
	
		// Constructors
		public SurviveSceneSwitch(); // 0x0000000180E63040-0x0000000180E63090
		static SurviveSceneSwitch(); // 0x00000001803774A0-0x00000001803774B0
	
		// Methods
		public void OnEnable(); // 0x000000018108BE40-0x000000018108C3F0
		public void Start(); // 0x000000018108C3F0-0x000000018108C400
		public void Update(); // 0x000000018108C400-0x000000018108C670
	}
}

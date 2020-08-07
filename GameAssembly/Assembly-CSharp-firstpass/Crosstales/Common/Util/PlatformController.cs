/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crosstales.Common.Model.Enum;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace Crosstales.Common.Util
{
	public class PlatformController : UnityEngine.MonoBehaviour // TypeDefIndex: 9744
	{
		// Fields
		[Header] // 0x00000001801FD2C0-0x00000001801FD320
		[Tooltip] // 0x00000001801FD2C0-0x00000001801FD320
		public List<Crosstales.Common.Model.Enum.Platform> Platforms; // 0x18
		[Tooltip] // 0x00000001801FD860-0x00000001801FD890
		public bool Active; // 0x20
		[Header] // 0x00000001801FDA80-0x00000001801FDAE0
		[Tooltip] // 0x00000001801FDA80-0x00000001801FDAE0
		public GameObject[] Objects; // 0x28
		protected Crosstales.Common.Model.Enum.Platform currentPlatform; // 0x30
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 9745
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<GameObject, bool> <>9__6_0; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018108D670-0x000000018108D6D0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <activateGO>b__6_0(GameObject go); // 0x000000018108D270-0x000000018108D2D0
		}
	
		// Constructors
		public PlatformController(); // 0x0000000180E63040-0x0000000180E63090
	
		// Methods
		public virtual void Start(); // 0x000000018108A250-0x000000018108A2F0
		protected void selectPlatform(); // 0x000000018108A250-0x000000018108A2F0
		protected void activateGO(); // 0x000000018108A2F0-0x000000018108A580
	}
}

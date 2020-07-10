/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crosstales.Common.Model.Enum;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.Common.Util
{
	public class PlatformController : UnityEngine.MonoBehaviour // TypeDefIndex: 9958
	{
		// Fields
		[Header] // 0x0000000180117800-0x0000000180117860
		[Tooltip] // 0x0000000180117800-0x0000000180117860
		public List<Crosstales.Common.Model.Enum.Platform> Platforms; // 0x18
		[Tooltip] // 0x0000000180117BB0-0x0000000180117BE0
		public bool Active; // 0x20
		[Header] // 0x0000000180117D80-0x0000000180117DE0
		[Tooltip] // 0x0000000180117D80-0x0000000180117DE0
		public GameObject[] Objects; // 0x28
		protected Crosstales.Common.Model.Enum.Platform currentPlatform; // 0x30
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 9959
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<GameObject, bool> <>9__6_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001815EDA10-0x00000001815EDA70
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <activateGO>b__6_0(GameObject go); // 0x00000001815ED610-0x00000001815ED670
		}
	
		// Constructors
		public PlatformController(); // 0x000000018061F370-0x000000018061F3C0
	
		// Methods
		public virtual void Start(); // 0x00000001815EA570-0x00000001815EA610
		protected void selectPlatform(); // 0x00000001815EA570-0x00000001815EA610
		protected void activateGO(); // 0x00000001815EA610-0x00000001815EA8A0
	}
}

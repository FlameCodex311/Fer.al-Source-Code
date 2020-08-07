/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace GestureRecognizer
{
	[CreateAssetMenu] // 0x000000018028F3B0-0x000000018028F3E0
	public class GesturePattern : ScriptableObject // TypeDefIndex: 10038
	{
		// Fields
		public string id; // 0x18
		[HideInInspector] // 0x000000018028F560-0x000000018028F5C0
		[Obsolete] // 0x000000018028F560-0x000000018028F5C0
		[SerializeField] // 0x000000018028F560-0x000000018028F5C0
		public List<Vector2> points; // 0x20
		public GestureData gesture; // 0x28
		public bool useLinesOrder; // 0x30
		public bool useLinesDirections; // 0x31
	
		// Constructors
		public GesturePattern(); // 0x00000001803FEC00-0x00000001803FEC10
	}
}

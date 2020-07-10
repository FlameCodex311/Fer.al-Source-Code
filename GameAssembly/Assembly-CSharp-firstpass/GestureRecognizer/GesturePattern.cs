/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace GestureRecognizer
{
	[CreateAssetMenu] // 0x00000001800E9C70-0x00000001800E9CA0
	public class GesturePattern : ScriptableObject // TypeDefIndex: 9584
	{
		// Fields
		public string id; // 0x18
		[HideInInspector] // 0x00000001800E9E60-0x00000001800E9EC0
		[Obsolete] // 0x00000001800E9E60-0x00000001800E9EC0
		[SerializeField] // 0x00000001800E9E60-0x00000001800E9EC0
		public List<Vector2> points; // 0x20
		public GestureData gesture; // 0x28
		public bool useLinesOrder; // 0x30
		public bool useLinesDirections; // 0x31
	
		// Constructors
		public GesturePattern(); // 0x00000001803A2BB0-0x00000001803A2BC0
	}
}

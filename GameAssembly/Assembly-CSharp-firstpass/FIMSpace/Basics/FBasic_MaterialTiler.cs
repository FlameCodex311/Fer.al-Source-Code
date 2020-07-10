/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FIMSpace.Basics
{
	public class FBasic_MaterialTiler : FBasic_MaterialScriptBase // TypeDefIndex: 9914
	{
		// Fields
		[Header] // 0x00000001801087F0-0x0000000180108890
		[Header] // 0x00000001801087F0-0x0000000180108890
		[Space] // 0x00000001801087F0-0x0000000180108890
		[Tooltip] // 0x00000001801087F0-0x0000000180108890
		public string TextureProperty; // 0x28
		[Tooltip] // 0x0000000180108C50-0x0000000180108C80
		public Vector2 ScaleValues; // 0x30
		[Tooltip] // 0x0000000180108E80-0x0000000180108EB0
		public bool EqualDimensions; // 0x38
	
		// Constructors
		public FBasic_MaterialTiler(); // 0x00000001815D5D20-0x00000001815D5D90
	
		// Methods
		private void OnValidate(); // 0x00000001815D5A30-0x00000001815D5BB0
		private void TileMaterialToScale(); // 0x00000001815D5BB0-0x00000001815D5D20
	}
}

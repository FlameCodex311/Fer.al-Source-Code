/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.Basics
{
	public class FBasic_MaterialTiler : FBasic_MaterialScriptBase // TypeDefIndex: 10368
	{
		// Fields
		[Header] // 0x00000001801EB440-0x00000001801EB4E0
		[Header] // 0x00000001801EB440-0x00000001801EB4E0
		[Space] // 0x00000001801EB440-0x00000001801EB4E0
		[Tooltip] // 0x00000001801EB440-0x00000001801EB4E0
		public string TextureProperty; // 0x28
		[Tooltip] // 0x00000001801EB890-0x00000001801EB8C0
		public Vector2 ScaleValues; // 0x30
		[Tooltip] // 0x00000001801EBAF0-0x00000001801EBB20
		public bool EqualDimensions; // 0x38
	
		// Constructors
		public FBasic_MaterialTiler(); // 0x000000018107F980-0x000000018107F9F0
	
		// Methods
		private void OnValidate(); // 0x000000018107F690-0x000000018107F810
		private void TileMaterialToScale(); // 0x000000018107F810-0x000000018107F980
	}
}

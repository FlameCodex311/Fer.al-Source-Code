/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech.CustomAttributes
{
	public class RegexAttribute : PropertyAttribute // TypeDefIndex: 13935
	{
		// Fields
		public readonly string Pattern; // 0x18
		public readonly Mode InputMode; // 0x20
		public readonly RegexOptions MatchOptions; // 0x24
	
		// Nested types
		public enum Mode // TypeDefIndex: 13936
		{
			Force = 0,
			DisplayInvalid = 1
		}
	
		// Constructors
		public RegexAttribute(string pattern, Mode inputMode = Mode.DisplayInvalid /* Metadata: 0x00784274 */, RegexOptions matchOptions = RegexOptions.None | RegexOptions.Singleline /* Metadata: 0x00784278 */); // 0x0000000181356D40-0x0000000181356DD0
	}
}

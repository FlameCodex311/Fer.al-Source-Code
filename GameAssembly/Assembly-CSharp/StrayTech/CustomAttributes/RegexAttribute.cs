/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech.CustomAttributes
{
	public class RegexAttribute : PropertyAttribute // TypeDefIndex: 14603
	{
		// Fields
		public readonly string Pattern; // 0x18
		public readonly Mode InputMode; // 0x20
		public readonly RegexOptions MatchOptions; // 0x24
	
		// Nested types
		public enum Mode // TypeDefIndex: 14604
		{
			Force = 0,
			DisplayInvalid = 1
		}
	
		// Constructors
		public RegexAttribute(string pattern, Mode inputMode = Mode.DisplayInvalid /* Metadata: 0x007BAD37 */, RegexOptions matchOptions = RegexOptions.None | RegexOptions.Singleline /* Metadata: 0x007BAD3B */); // 0x0000000180CB6E80-0x0000000180CB6F10
	}
}

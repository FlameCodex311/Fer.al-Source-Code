/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ColorChartData : ChartDataObject<ColorDef, ColorChartData> // TypeDefIndex: 11605
{
	// Fields
	[NonSerialized]
	private List<ColorDef> _avatarBodyColorList; // 0x78
	[NonSerialized]
	private List<ColorDef> _avatarPatternColorList; // 0x80
	[NonSerialized]
	private List<ColorDef> _avatarEyeColorList; // 0x88

	// Properties
	public List<ColorDef> AvatarBodyColorList { get; } // 0x000000018077B370-0x000000018077B470 
	public List<ColorDef> AvatarPatternColorList { get; } // 0x000000018077B580-0x000000018077B690 
	public List<ColorDef> AvatarEyeColorList { get; } // 0x000000018077B470-0x000000018077B580 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11606
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<string, ColorDef> <>9__2_0; // 0x08
		public static Func<string, ColorDef> <>9__5_0; // 0x10
		public static Func<string, ColorDef> <>9__8_0; // 0x18

		// Constructors
		static <>c(); // 0x0000000180787060-0x00000001807870C0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal ColorDef <get_AvatarBodyColorList>b__2_0(string inDef); // 0x0000000180786D60-0x0000000180786DC0
		internal ColorDef <get_AvatarPatternColorList>b__5_0(string inDef); // 0x0000000180786E20-0x0000000180786E80
		internal ColorDef <get_AvatarEyeColorList>b__8_0(string inDef); // 0x0000000180786DC0-0x0000000180786E20
	}

	// Constructors
	public ColorChartData(); // 0x000000018077B310-0x000000018077B370

	// Methods
	public override void WriteCSVChart(); // 0x00000001803774A0-0x00000001803774B0
}


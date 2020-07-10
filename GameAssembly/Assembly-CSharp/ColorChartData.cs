/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ColorChartData : ChartDataObject<ColorDef, ColorChartData> // TypeDefIndex: 10114
{
	// Fields
	[NonSerialized]
	private List<ColorDef> _avatarBodyColorList; // 0x78
	[NonSerialized]
	private List<ColorDef> _avatarPatternColorList; // 0x80
	[NonSerialized]
	private List<ColorDef> _avatarEyeColorList; // 0x88

	// Properties
	public List<ColorDef> AvatarBodyColorList { get; } // 0x000000018146FC10-0x000000018146FD10 
	public List<ColorDef> AvatarPatternColorList { get; } // 0x000000018146FE20-0x000000018146FF30 
	public List<ColorDef> AvatarEyeColorList { get; } // 0x000000018146FD10-0x000000018146FE20 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10115
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<string, ColorDef> <>9__2_0; // 0x08
		public static Func<string, ColorDef> <>9__5_0; // 0x10
		public static Func<string, ColorDef> <>9__8_0; // 0x18

		// Constructors
		static <>c(); // 0x0000000181484120-0x0000000181484180
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal ColorDef <get_AvatarBodyColorList>b__2_0(string inDef); // 0x0000000181483FE0-0x0000000181484040
		internal ColorDef <get_AvatarPatternColorList>b__5_0(string inDef); // 0x00000001814840A0-0x0000000181484100
		internal ColorDef <get_AvatarEyeColorList>b__8_0(string inDef); // 0x0000000181484040-0x00000001814840A0
	}

	// Constructors
	public ColorChartData(); // 0x000000018146FBB0-0x000000018146FC10

	// Methods
	public override void WriteCSVChart(); // 0x00000001803581E0-0x00000001803581F0
}


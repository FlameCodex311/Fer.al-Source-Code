/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[CreateAssetMenu] // 0x00000001800D55F0-0x00000001800D5630
public class UI_Theme : ScriptableObject // TypeDefIndex: 13592
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_ImageThemeData> _imageThemeData; // 0x18
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_TextThemeData> _textThemeData; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_ButtonThemeData> _buttonThemeData; // 0x28

	// Properties
	public List<UI_ImageThemeData> ImageThemeData { get; } // 0x000000018038B150-0x000000018038B160 
	public List<UI_TextThemeData> TextThemeData { get; } // 0x000000018036AC70-0x000000018036AC80 
	public List<UI_ButtonThemeData> ButtonThemeData { get; } // 0x0000000180369B60-0x0000000180369B70 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 13593
	{
		// Fields
		public string inId; // 0x10

		// Constructors
		public <>c__DisplayClass3_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <GetImageThemeData>b__0(UI_ImageThemeData dataItem); // 0x0000000180EB3C90-0x0000000180EB3CC0
		internal bool <GetImageThemeData>b__1(UI_ImageThemeData dataItem); // 0x0000000180E3BE80-0x0000000180E3BEB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 13594
	{
		// Fields
		public string inId; // 0x10

		// Constructors
		public <>c__DisplayClass7_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <GetTextThemeData>b__0(UI_TextThemeData dataItem); // 0x0000000180EB3C90-0x0000000180EB3CC0
		internal bool <GetTextThemeData>b__1(UI_TextThemeData dataItem); // 0x0000000180E3BE80-0x0000000180E3BEB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 13595
	{
		// Fields
		public string inId; // 0x10

		// Constructors
		public <>c__DisplayClass11_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <GetButtonThemeData>b__0(UI_ButtonThemeData dataItem); // 0x0000000180EB3C90-0x0000000180EB3CC0
		internal bool <GetButtonThemeData>b__1(UI_ButtonThemeData dataItem); // 0x0000000180E3BE80-0x0000000180E3BEB0
	}

	// Constructors
	public UI_Theme(); // 0x0000000180F95120-0x0000000180F951D0

	// Methods
	public UI_ImageThemeData GetImageThemeData(string inId); // 0x0000000180F94EE0-0x0000000180F95000
	public UI_TextThemeData GetTextThemeData(string inId); // 0x0000000180F95000-0x0000000180F95120
	public UI_ButtonThemeData GetButtonThemeData(string inId); // 0x0000000180F94DC0-0x0000000180F94EE0
}


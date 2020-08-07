/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[CreateAssetMenu] // 0x00000001802701D0-0x0000000180270210
public class UI_Theme : ScriptableObject // TypeDefIndex: 11259
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_ImageThemeData> _imageThemeData; // 0x18
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_TextThemeData> _textThemeData; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_ButtonThemeData> _buttonThemeData; // 0x28

	// Properties
	public List<UI_ImageThemeData> ImageThemeData { get; } // 0x0000000180372430-0x0000000180372440 
	public List<UI_TextThemeData> TextThemeData { get; } // 0x0000000180374AF0-0x0000000180374B00 
	public List<UI_ButtonThemeData> ButtonThemeData { get; } // 0x00000001803745B0-0x00000001803745C0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 11260
	{
		// Fields
		public string inId; // 0x10

		// Constructors
		public <>c__DisplayClass3_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <GetImageThemeData>b__0(UI_ImageThemeData dataItem); // 0x00000001803E2140-0x00000001803E2170
		internal bool <GetImageThemeData>b__1(UI_ImageThemeData dataItem); // 0x0000000180387C90-0x0000000180387CC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 11261
	{
		// Fields
		public string inId; // 0x10

		// Constructors
		public <>c__DisplayClass7_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <GetTextThemeData>b__0(UI_TextThemeData dataItem); // 0x00000001803E2140-0x00000001803E2170
		internal bool <GetTextThemeData>b__1(UI_TextThemeData dataItem); // 0x0000000180387C90-0x0000000180387CC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 11262
	{
		// Fields
		public string inId; // 0x10

		// Constructors
		public <>c__DisplayClass11_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <GetButtonThemeData>b__0(UI_ButtonThemeData dataItem); // 0x00000001803E2140-0x00000001803E2170
		internal bool <GetButtonThemeData>b__1(UI_ButtonThemeData dataItem); // 0x0000000180387C90-0x0000000180387CC0
	}

	// Constructors
	public UI_Theme(); // 0x0000000180635D90-0x0000000180635E40

	// Methods
	public UI_ImageThemeData GetImageThemeData(string inId); // 0x0000000180635B50-0x0000000180635C70
	public UI_TextThemeData GetTextThemeData(string inId); // 0x0000000180635C70-0x0000000180635D90
	public UI_ButtonThemeData GetButtonThemeData(string inId); // 0x0000000180635A30-0x0000000180635B50
}


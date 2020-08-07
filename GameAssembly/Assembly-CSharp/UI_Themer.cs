/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using Unitilities.Tuples;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[CreateAssetMenu] // 0x0000000180270F20-0x0000000180270F60
public class UI_Themer : ScriptableObject // TypeDefIndex: 11264
{
	// Fields
	private static UI_Themer _instance; // 0x00
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _currentThemeIndex; // 0x18
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_Theme> _themes; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<StringTuple> _imgManifest; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<StringTuple> _txtManifest; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<StringTuple> _btnManifest; // 0x38

	// Properties
	public static UI_Themer instance { get; } // 0x00000001806385E0-0x00000001806387A0 
	private UI_Theme CurrentTheme { get; } // 0x0000000180638560-0x00000001806385E0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 11265
	{
		// Fields
		public string inId; // 0x10

		// Constructors
		public <>c__DisplayClass14_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <UpdateImageThemeDataFromSrc>b__0(StringTuple item); // 0x00000001803E2140-0x00000001803E2170
		internal bool <UpdateImageThemeDataFromSrc>b__1(StringTuple item); // 0x00000001803E2140-0x00000001803E2170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass15_0 // TypeDefIndex: 11266
	{
		// Fields
		public string inName; // 0x10

		// Constructors
		public <>c__DisplayClass15_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <AddImageThemeDataFromSrc>b__0(UI_ImageThemeData item); // 0x0000000180387C90-0x0000000180387CC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 11267
	{
		// Fields
		public string inId; // 0x10

		// Constructors
		public <>c__DisplayClass18_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <UpdateTextThemeDataFromSrc>b__0(StringTuple item); // 0x00000001803E2140-0x00000001803E2170
		internal bool <UpdateTextThemeDataFromSrc>b__1(StringTuple item); // 0x00000001803E2140-0x00000001803E2170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass19_0 // TypeDefIndex: 11268
	{
		// Fields
		public string inName; // 0x10

		// Constructors
		public <>c__DisplayClass19_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <AddTextThemeDataFromSrc>b__0(UI_TextThemeData item); // 0x0000000180387C90-0x0000000180387CC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass22_0 // TypeDefIndex: 11269
	{
		// Fields
		public string inId; // 0x10

		// Constructors
		public <>c__DisplayClass22_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <UpdateButtonThemeDataFromSrc>b__0(StringTuple item); // 0x00000001803E2140-0x00000001803E2170
		internal bool <UpdateButtonThemeDataFromSrc>b__1(StringTuple item); // 0x00000001803E2140-0x00000001803E2170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass23_0 // TypeDefIndex: 11270
	{
		// Fields
		public string inName; // 0x10

		// Constructors
		public <>c__DisplayClass23_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <AddButtonThemeDataFromSrc>b__0(UI_ButtonThemeData item); // 0x0000000180387C90-0x0000000180387CC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass24_0 // TypeDefIndex: 11271
	{
		// Fields
		public UI_Theme theme; // 0x10

		// Constructors
		public <>c__DisplayClass24_0(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass24_1 // TypeDefIndex: 11272
	{
		// Fields
		public int i; // 0x10
		public <>c__DisplayClass24_0 CS$<>8__locals1; // 0x18

		// Constructors
		public <>c__DisplayClass24_1(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <SyncThemeContentsWithManifests>b__0(StringTuple item); // 0x0000000180635130-0x00000001806351E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass24_2 // TypeDefIndex: 11273
	{
		// Fields
		public StringTuple st; // 0x10

		// Constructors
		public <>c__DisplayClass24_2(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <SyncThemeContentsWithManifests>b__1(UI_ImageThemeData item); // 0x00000001806351E0-0x0000000180635220
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass24_3 // TypeDefIndex: 11274
	{
		// Fields
		public int i; // 0x10
		public <>c__DisplayClass24_0 CS$<>8__locals2; // 0x18

		// Constructors
		public <>c__DisplayClass24_3(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <SyncThemeContentsWithManifests>b__2(StringTuple item); // 0x0000000180635220-0x00000001806352D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass24_4 // TypeDefIndex: 11275
	{
		// Fields
		public StringTuple st; // 0x10

		// Constructors
		public <>c__DisplayClass24_4(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <SyncThemeContentsWithManifests>b__3(UI_TextThemeData item); // 0x00000001806351E0-0x0000000180635220
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass24_5 // TypeDefIndex: 11276
	{
		// Fields
		public int i; // 0x10
		public <>c__DisplayClass24_0 CS$<>8__locals3; // 0x18

		// Constructors
		public <>c__DisplayClass24_5(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <SyncThemeContentsWithManifests>b__4(StringTuple item); // 0x00000001806352D0-0x0000000180635380
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass24_6 // TypeDefIndex: 11277
	{
		// Fields
		public StringTuple st; // 0x10

		// Constructors
		public <>c__DisplayClass24_6(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <SyncThemeContentsWithManifests>b__5(UI_ButtonThemeData item); // 0x00000001806351E0-0x0000000180635220
	}

	// Constructors
	public UI_Themer(); // 0x0000000180638490-0x0000000180638560
	static UI_Themer(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	public void SetTheme(int inThemeIndex); // 0x0000000180636D50-0x0000000180636E60
	private void Init(); // 0x0000000180636CB0-0x0000000180636CC0
	public List<StringTuple> GetImageDataOptions(); // 0x0000000180636A90-0x0000000180636AF0
	public UI_ImageThemeData GetImageThemeData(string inId); // 0x0000000180636AF0-0x0000000180636BA0
	public bool UpdateImageThemeDataFromSrc(string inId, string inName, WWImage inSrc); // 0x0000000180638000-0x0000000180638240
	public bool AddImageThemeDataFromSrc(string inName, WWImage inSrc); // 0x0000000180636200-0x00000001806365C0
	public List<StringTuple> GetTextDataOptions(); // 0x0000000180636BA0-0x0000000180636C00
	public UI_TextThemeData GetTextThemeData(string inId); // 0x0000000180636C00-0x0000000180636CB0
	public bool UpdateTextThemeDataFromSrc(string inId, string inName, WWTextMeshProUGUI inSrc, bool inIgnoreSizeSettings); // 0x0000000180638240-0x0000000180638490
	public bool AddTextThemeDataFromSrc(string inName, WWTextMeshProUGUI inSrc); // 0x00000001806365C0-0x0000000180636980
	public List<StringTuple> GetButtonDataOptions(); // 0x0000000180636980-0x00000001806369E0
	public UI_ButtonThemeData GetButtonThemeData(string inId); // 0x00000001806369E0-0x0000000180636A90
	public bool UpdateButtonThemeDataFromSrc(string inId, string inName, WWButton inSrc); // 0x0000000180637DC0-0x0000000180638000
	public bool AddButtonThemeDataFromSrc(string inName, WWButton inSrc); // 0x0000000180635E40-0x0000000180636200
	public void SyncThemeContentsWithManifests(); // 0x0000000180636E60-0x0000000180637DC0
	public void ReportChangedTheme(); // 0x0000000180636CC0-0x0000000180636D50
}


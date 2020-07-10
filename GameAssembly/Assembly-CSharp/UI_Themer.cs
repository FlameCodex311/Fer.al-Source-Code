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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[CreateAssetMenu] // 0x00000001800D65E0-0x00000001800D6620
public class UI_Themer : ScriptableObject // TypeDefIndex: 13597
{
	// Fields
	private static UI_Themer _instance; // 0x00
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _currentThemeIndex; // 0x18
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_Theme> _themes; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<StringTuple> _imgManifest; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<StringTuple> _txtManifest; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<StringTuple> _btnManifest; // 0x38

	// Properties
	public static UI_Themer instance { get; } // 0x0000000180F97BD0-0x0000000180F97D90 
	private UI_Theme CurrentTheme { get; } // 0x0000000180F97B50-0x0000000180F97BD0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 13598
	{
		// Fields
		public string inId; // 0x10

		// Constructors
		public <>c__DisplayClass14_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <UpdateImageThemeDataFromSrc>b__0(StringTuple item); // 0x0000000180EB3C90-0x0000000180EB3CC0
		internal bool <UpdateImageThemeDataFromSrc>b__1(StringTuple item); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass15_0 // TypeDefIndex: 13599
	{
		// Fields
		public string inName; // 0x10

		// Constructors
		public <>c__DisplayClass15_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <AddImageThemeDataFromSrc>b__0(UI_ImageThemeData item); // 0x0000000180E3BE80-0x0000000180E3BEB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 13600
	{
		// Fields
		public string inId; // 0x10

		// Constructors
		public <>c__DisplayClass18_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <UpdateTextThemeDataFromSrc>b__0(StringTuple item); // 0x0000000180EB3C90-0x0000000180EB3CC0
		internal bool <UpdateTextThemeDataFromSrc>b__1(StringTuple item); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass19_0 // TypeDefIndex: 13601
	{
		// Fields
		public string inName; // 0x10

		// Constructors
		public <>c__DisplayClass19_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <AddTextThemeDataFromSrc>b__0(UI_TextThemeData item); // 0x0000000180E3BE80-0x0000000180E3BEB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass22_0 // TypeDefIndex: 13602
	{
		// Fields
		public string inId; // 0x10

		// Constructors
		public <>c__DisplayClass22_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <UpdateButtonThemeDataFromSrc>b__0(StringTuple item); // 0x0000000180EB3C90-0x0000000180EB3CC0
		internal bool <UpdateButtonThemeDataFromSrc>b__1(StringTuple item); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass23_0 // TypeDefIndex: 13603
	{
		// Fields
		public string inName; // 0x10

		// Constructors
		public <>c__DisplayClass23_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <AddButtonThemeDataFromSrc>b__0(UI_ButtonThemeData item); // 0x0000000180E3BE80-0x0000000180E3BEB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass24_0 // TypeDefIndex: 13604
	{
		// Fields
		public UI_Theme theme; // 0x10

		// Constructors
		public <>c__DisplayClass24_0(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass24_1 // TypeDefIndex: 13605
	{
		// Fields
		public int i; // 0x10
		public <>c__DisplayClass24_0 CS$<>8__locals1; // 0x18

		// Constructors
		public <>c__DisplayClass24_1(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <SyncThemeContentsWithManifests>b__0(StringTuple item); // 0x0000000180F8EF00-0x0000000180F8EFC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass24_2 // TypeDefIndex: 13606
	{
		// Fields
		public StringTuple st; // 0x10

		// Constructors
		public <>c__DisplayClass24_2(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <SyncThemeContentsWithManifests>b__1(UI_ImageThemeData item); // 0x0000000180F8EFC0-0x0000000180F8F000
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass24_3 // TypeDefIndex: 13607
	{
		// Fields
		public int i; // 0x10
		public <>c__DisplayClass24_0 CS$<>8__locals2; // 0x18

		// Constructors
		public <>c__DisplayClass24_3(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <SyncThemeContentsWithManifests>b__2(StringTuple item); // 0x0000000180F8F000-0x0000000180F8F0C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass24_4 // TypeDefIndex: 13608
	{
		// Fields
		public StringTuple st; // 0x10

		// Constructors
		public <>c__DisplayClass24_4(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <SyncThemeContentsWithManifests>b__3(UI_TextThemeData item); // 0x0000000180F8EFC0-0x0000000180F8F000
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass24_5 // TypeDefIndex: 13609
	{
		// Fields
		public int i; // 0x10
		public <>c__DisplayClass24_0 CS$<>8__locals3; // 0x18

		// Constructors
		public <>c__DisplayClass24_5(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <SyncThemeContentsWithManifests>b__4(StringTuple item); // 0x0000000180F8F0C0-0x0000000180F8F180
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass24_6 // TypeDefIndex: 13610
	{
		// Fields
		public StringTuple st; // 0x10

		// Constructors
		public <>c__DisplayClass24_6(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <SyncThemeContentsWithManifests>b__5(UI_ButtonThemeData item); // 0x0000000180F8EFC0-0x0000000180F8F000
	}

	// Constructors
	public UI_Themer(); // 0x0000000180F97A80-0x0000000180F97B50
	static UI_Themer(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	public void SetTheme(int inThemeIndex); // 0x0000000180F962A0-0x0000000180F963B0
	private void Init(); // 0x0000000180F96200-0x0000000180F96210
	public List<StringTuple> GetImageDataOptions(); // 0x0000000180F95FC0-0x0000000180F96020
	public UI_ImageThemeData GetImageThemeData(string inId); // 0x0000000180F96020-0x0000000180F960E0
	public bool UpdateImageThemeDataFromSrc(string inId, string inName, WWImage inSrc); // 0x0000000180F975E0-0x0000000180F97830
	public bool AddImageThemeDataFromSrc(string inName, WWImage inSrc); // 0x0000000180F955A0-0x0000000180F95970
	public List<StringTuple> GetTextDataOptions(); // 0x0000000180F960E0-0x0000000180F96140
	public UI_TextThemeData GetTextThemeData(string inId); // 0x0000000180F96140-0x0000000180F96200
	public bool UpdateTextThemeDataFromSrc(string inId, string inName, WWTextMeshProUGUI inSrc, bool inIgnoreSizeSettings); // 0x0000000180F97830-0x0000000180F97A80
	public bool AddTextThemeDataFromSrc(string inName, WWTextMeshProUGUI inSrc); // 0x0000000180F95970-0x0000000180F95EA0
	public List<StringTuple> GetButtonDataOptions(); // 0x0000000180F95EA0-0x0000000180F95F00
	public UI_ButtonThemeData GetButtonThemeData(string inId); // 0x0000000180F95F00-0x0000000180F95FC0
	public bool UpdateButtonThemeDataFromSrc(string inId, string inName, WWButton inSrc); // 0x0000000180F97390-0x0000000180F975E0
	public bool AddButtonThemeDataFromSrc(string inName, WWButton inSrc); // 0x0000000180F951D0-0x0000000180F955A0
	public void SyncThemeContentsWithManifests(); // 0x0000000180F963B0-0x0000000180F97390
	public void ReportChangedTheme(); // 0x0000000180F96210-0x0000000180F962A0
}


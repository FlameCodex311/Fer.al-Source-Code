/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class ParsableDefBase // TypeDefIndex: 13354
{
	// Fields
	[NonSerialized]
	public string parentChartName; // 0x10
	[NonSerialized]
	public Dictionary<string, string> headerNameToDataDict; // 0x18
	[NonSerialized]
	public float lastAccessTime; // 0x20

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13355
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<string, int> <>9__13_0; // 0x08
		public static Func<string, string> <>9__14_0; // 0x10

		// Constructors
		static <>c(); // 0x000000018117C180-0x000000018117C1E0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <LoadTupleListInt>b__13_0(string value); // 0x000000018117B330-0x000000018117B360
		internal string <LoadTupleListString>b__14_0(string value); // 0x00000001804DE840-0x00000001804DE850
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass16_0<T, U> // TypeDefIndex: 13356
		where T : BaseDef
		where U : ChartDataObject
	{
		// Fields
		public ParsableDefBase <>4__this;
		public string inCategory;

		// Constructors
		public <>c__DisplayClass16_0();

		// Methods
		internal T <LoadLazyDef>b__0(string defIDs);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass17_0<T, U> // TypeDefIndex: 13357
		where T : BaseDef
		where U : ChartDataObject
	{
		// Fields
		public ParsableDefBase <>4__this;
		public string inCategory;

		// Constructors
		public <>c__DisplayClass17_0();

		// Methods
		internal List<T> <LoadLazyDefList>b__0(List<string> defIDs);
	}

	// Constructors
	public ParsableDefBase(); // 0x0000000181172870-0x00000001811728B0

	// Methods
	public virtual void Load(); // 0x0000000181172810-0x0000000181172870
	public virtual void LoadEntry(); // 0x00000001803581E0-0x00000001803581F0
	public virtual void LoadComponents(); // 0x00000001803581E0-0x00000001803581F0
	public virtual void OnLoaded(); // 0x00000001803581E0-0x00000001803581F0
	public T LoadEnum<T>(string inCategory, int inDefaultValue = 0 /* Metadata: 0x00783BAD */)
		where T : struct;
	public T LoadJSON<T>(string inCategory, bool inCanReturnNull = false /* Metadata: 0x00783BB1 */)
		where T : new();
	public void LoadJSONOverwrite<T>(string inCategory, T inTargetObject)
		where T : new();
	public string LoadString(string inCategory, string defaultValue = "Missing" /* Metadata: 0x00783BB2 */); // 0x0000000181171EA0-0x0000000181171F40
	public long LoadDate(string inCategory); // 0x0000000181171960-0x0000000181171AC0
	public DateTime LoadDateTime(string inCategory); // 0x0000000181171800-0x0000000181171960
	public List<ValueTuple<string, int>> LoadTupleListInt(string inCategory); // 0x0000000181171F40-0x0000000181172050
	public List<ValueTuple<string, string>> LoadTupleListString(string inCategory); // 0x0000000181172050-0x0000000181172160
	private List<ValueTuple<string, T>> LoadTupleList<T>(string inCategory, Func<string, T> inParseFunc);
	public LazyDef<T> LoadLazyDef<T, U>(string inCategory)
		where T : BaseDef
		where U : ChartDataObject;
	public LazyDefList<T> LoadLazyDefList<T, U>(string inCategory)
		where T : BaseDef
		where U : ChartDataObject;
	public List<string> LoadStringList(string inCategory, bool isDynamic = false /* Metadata: 0x00783BBD */); // 0x0000000181171E70-0x0000000181171EA0
	public List<string> LoadStringList(string inCategory, char inSeperator, bool isDynamic = false /* Metadata: 0x00783BBE */); // 0x0000000181171CB0-0x0000000181171E70
	public List<T> LoadGenericDefList<T>(string inChartName, string inCategory)
		where T : BaseDef;
	public T LoadGenericDef<T, U>(string inCategory)
		where T : BaseDef
		where U : ChartDataObject;
	public List<T> LoadGenericDefList<T, U>(string inCategory)
		where T : BaseDef
		where U : ChartDataObject;
	public List<T> LoadGenericDynamicDefList<T>(string inCategory)
		where T : BaseDef;
	public List<List<string>> LoadColorRefList(string inCategory); // 0x0000000181171460-0x0000000181171750
	public Color LoadColor(string inCategory); // 0x0000000181171750-0x0000000181171800
	public Color LoadColorAsString(string inString); // 0x00000001811711D0-0x0000000181171460
	public Vector2 LoadVector2(string inCategory); // 0x0000000181172160-0x0000000181172460
	public Vector3 LoadVector3(string inCategory); // 0x0000000181172460-0x0000000181172810
	public float LoadFloat(string inCategory, float? inDefault = default); // 0x0000000181171AC0-0x0000000181171B80
	public int LoadInt(string inCategory); // 0x0000000181171B80-0x0000000181171C10
	public long LoadLong(string inCategory); // 0x0000000181171C10-0x0000000181171CB0
	public bool LoadBool(string inCategory, bool inDefault = false /* Metadata: 0x00783BBF */); // 0x0000000181171120-0x00000001811711D0
}


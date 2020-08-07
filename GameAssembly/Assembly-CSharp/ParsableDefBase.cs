/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class ParsableDefBase // TypeDefIndex: 11025
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
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11026
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<string, int> <>9__13_0; // 0x08
		public static Func<string, string> <>9__14_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001804ED3B0-0x00000001804ED410
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <LoadTupleListInt>b__13_0(string value); // 0x00000001804ECBE0-0x00000001804ECC10
		internal string <LoadTupleListString>b__14_0(string value); // 0x00000001804EC160-0x00000001804EC170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass16_0<T, U> // TypeDefIndex: 11027
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

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass17_0<T, U> // TypeDefIndex: 11028
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
	public ParsableDefBase(); // 0x00000001804DF970-0x00000001804DF9B0

	// Methods
	public virtual void Load(); // 0x00000001804DF910-0x00000001804DF970
	public virtual void LoadEntry(); // 0x00000001803774A0-0x00000001803774B0
	public virtual void LoadComponents(); // 0x00000001803774A0-0x00000001803774B0
	public virtual void OnLoaded(); // 0x00000001803774A0-0x00000001803774B0
	public T LoadEnum<T>(string inCategory, int inDefaultValue = 0 /* Metadata: 0x0077C676 */)
		where T : struct;
	public T LoadJSON<T>(string inCategory, bool inCanReturnNull = false /* Metadata: 0x0077C67A */)
		where T : new();
	public void LoadJSONOverwrite<T>(string inCategory, T inTargetObject)
		where T : new();
	public string LoadString(string inCategory, string defaultValue = "Missing" /* Metadata: 0x0077C67B */); // 0x00000001804DEFE0-0x00000001804DF080
	public long LoadDate(string inCategory); // 0x00000001804DE940-0x00000001804DEAA0
	public DateTime LoadDateTime(string inCategory); // 0x00000001804DE7E0-0x00000001804DE940
	public List<ValueTuple<string, int>> LoadTupleListInt(string inCategory); // 0x00000001804DF080-0x00000001804DF180
	public List<ValueTuple<string, string>> LoadTupleListString(string inCategory); // 0x00000001804DF180-0x00000001804DF280
	private List<ValueTuple<string, T>> LoadTupleList<T>(string inCategory, Func<string, T> inParseFunc);
	public LazyDef<T> LoadLazyDef<T, U>(string inCategory)
		where T : BaseDef
		where U : ChartDataObject;
	public LazyDefList<T> LoadLazyDefList<T, U>(string inCategory)
		where T : BaseDef
		where U : ChartDataObject;
	public List<string> LoadStringList(string inCategory, bool isDynamic = false /* Metadata: 0x0077C686 */); // 0x00000001804DEE40-0x00000001804DEFE0
	public List<string> LoadStringList(string inCategory, char inSeperator, bool isDynamic = false /* Metadata: 0x0077C687 */); // 0x00000001804DEC90-0x00000001804DEE40
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
	public List<List<string>> LoadColorRefList(string inCategory); // 0x00000001804DE460-0x00000001804DE730
	public Color LoadColor(string inCategory); // 0x00000001804DE730-0x00000001804DE7E0
	public Color LoadColorAsString(string inString); // 0x00000001804DE1F0-0x00000001804DE460
	public Vector2 LoadVector2(string inCategory); // 0x00000001804DF280-0x00000001804DF570
	public Vector3 LoadVector3(string inCategory); // 0x00000001804DF570-0x00000001804DF910
	public float LoadFloat(string inCategory, float? inDefault = default); // 0x00000001804DEAA0-0x00000001804DEB60
	public int LoadInt(string inCategory); // 0x00000001804DEB60-0x00000001804DEBF0
	public long LoadLong(string inCategory); // 0x00000001804DEBF0-0x00000001804DEC90
	public bool LoadBool(string inCategory, bool inDefault = false /* Metadata: 0x0077C688 */); // 0x00000001804DE140-0x00000001804DE1F0
}


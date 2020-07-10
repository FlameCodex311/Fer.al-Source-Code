/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using LitJson;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BaseDef : ParsableDefBase // TypeDefIndex: 13304
{
	// Fields
	[NonSerialized]
	public string defName; // 0x28
	[NonSerialized]
	public string lowerDefName; // 0x30
	[NonSerialized]
	public string defID; // 0x38
	[NonSerialized]
	public Type templateType; // 0x40
	private static Dictionary<string, ChartDataObject> _defIDToChartName; // 0x00
	private static Dictionary<string, List<string>> _templateToDefIDs; // 0x08
	private static Dictionary<string, Func<DefComponent>> _defComponentConstructorDict; // 0x10
	private ComponentContainer _components; // 0x48

	// Properties
	private static Dictionary<string, ChartDataObject> DefIDToChart { get; } // 0x0000000181041F70-0x00000001810422E0 
	private static Dictionary<string, List<string>> TemplateToDefIDs { get; } // 0x00000001810422E0-0x0000000181042790 
	public virtual Type ChartType { get; } // 0x0000000181041ED0-0x0000000181041F70 

	// Nested types
	[Serializable]
	public class ChartSerializedJSONComponent // TypeDefIndex: 13305
	{
		// Fields
		public string componentClass; // 0x10
		public string componentJSON; // 0x18
		public bool componentIsCustom; // 0x20

		// Constructors
		public ChartSerializedJSONComponent(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class ChartSerializedJSON // TypeDefIndex: 13306
	{
		// Fields
		public string templateClass; // 0x10
		public string templateFormatHash; // 0x18
		public List<ChartSerializedJSONComponent> components; // 0x20

		// Constructors
		public ChartSerializedJSON(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	public static class Constructor // TypeDefIndex: 13307
	{
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 13308
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ParameterInfo, Type> <>9__0_0; // 0x08

			// Constructors
			static <>c(); // 0x000000018104F690-0x000000018104F6F0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal Type <Compile>b__0_0(ParameterInfo pi); // 0x0000000180DF2B50-0x0000000180DF2B80
		}

		// Methods
		public static Delegate Compile(Type delegateType, Type instanceType); // 0x0000000181049B60-0x0000000181049FF0
		public static TDelegate Compile<TDelegate>(Type instanceType);
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13309
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<DefComponent> <>9__19_1; // 0x08

		// Constructors
		static <>c(); // 0x000000018104F6F0-0x000000018104F750
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnLoaded>b__19_1(DefComponent c); // 0x000000018104D5D0-0x000000018104D600
	}

	// Constructors
	public BaseDef(); // 0x0000000181041E50-0x0000000181041ED0
	static BaseDef(); // 0x0000000181041DD0-0x0000000181041E50

	// Methods
	public static void ClearDefCache(); // 0x0000000181040790-0x00000001810408D0
	public static BaseDef GetDef(string inDefID, bool inShowErrors = false /* Metadata: 0x00783B2E */); // 0x0000000181040D00-0x0000000181040DF0
	public static List<string> GetAllDefIDsWithTemplate<T>();
	public static List<BaseDef> GetAllDefsWithTemplate<T>();
	public static T GetDefComponent<T>(string inDefID, bool inShowErrors = false /* Metadata: 0x00783B2F */)
		where T : DefComponent;
	public static List<BaseDef> GetDefs(List<string> inDefIDs, bool inShowErrors = false /* Metadata: 0x00783B30 */); // 0x0000000181040DF0-0x0000000181041050
	public static List<T> GetDefComponents<T>(List<string> inDefIDs, bool inShowErrors = false /* Metadata: 0x00783B31 */)
		where T : DefComponent;
	public override void LoadEntry(); // 0x0000000181041BB0-0x0000000181041C50
	public override void LoadComponents(); // 0x00000001810410B0-0x0000000181041120
	public override void OnLoaded(); // 0x0000000181041C50-0x0000000181041DA0
	public static DefComponent ConstructDefComponent(string inTypeName); // 0x00000001810408D0-0x0000000181040B40
	public void LoadDataJSON(string inJSON); // 0x0000000181041120-0x0000000181041BB0
	public static bool isValidDefID(string inDefID); // 0x0000000181042790-0x00000001810427F0
	public static bool IsValidBundleID(string inBundleID); // 0x0000000181041050-0x00000001810410B0
	public override bool Equals(object obj); // 0x0000000181040B40-0x0000000181040C00
	public static bool operator ==(BaseDef a, BaseDef b); // 0x00000001810427F0-0x0000000181042820
	public static bool operator !=(BaseDef a, BaseDef b); // 0x0000000181042820-0x00000001810428C0
	public override int GetHashCode(); // 0x00000001806D2810-0x00000001806D2820
	public override string ToString(); // 0x0000000180369B60-0x0000000180369B70
	public static BaseDef FromJson(JsonData data); // 0x0000000181040C00-0x0000000181040D00
	public bool HasComponent<T>()
		where T : DefComponent;
	public T GetComponent<T>()
		where T : DefComponent;
	public T AddComponent<T>()
		where T : DefComponent;
	public T AddComponent<T>(T inDefComponent)
		where T : DefComponent;
	public T AddComponentByTypeof<T>(T inDefComponent)
		where T : DefComponent;
	public void RemoveComponent<T>()
		where T : DefComponent;
	public void ForeachComponent<T>(Action<T> action)
		where T : class;
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnLoaded>b__19_0(DefComponent c); // 0x0000000181041DA0-0x0000000181041DD0
}


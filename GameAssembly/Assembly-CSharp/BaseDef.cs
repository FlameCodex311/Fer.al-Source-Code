/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using LitJson;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BaseDef : ParsableDefBase // TypeDefIndex: 10975
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
	private static Dictionary<string, ChartDataObject> DefIDToChart { get; } // 0x000000018215BBA0-0x000000018215BF00 
	private static Dictionary<string, List<string>> TemplateToDefIDs { get; } // 0x000000018215BF00-0x000000018215C390 
	public virtual Type ChartType { get; } // 0x000000018215BB00-0x000000018215BBA0 

	// Nested types
	[Serializable]
	public class ChartSerializedJSONComponent // TypeDefIndex: 10976
	{
		// Fields
		public string componentClass; // 0x10
		public string componentJSON; // 0x18
		public bool componentIsCustom; // 0x20

		// Constructors
		public ChartSerializedJSONComponent(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class ChartSerializedJSON // TypeDefIndex: 10977
	{
		// Fields
		public string templateClass; // 0x10
		public string templateFormatHash; // 0x18
		public List<ChartSerializedJSONComponent> components; // 0x20

		// Constructors
		public ChartSerializedJSON(); // 0x0000000180373240-0x0000000180373250
	}

	public static class Constructor // TypeDefIndex: 10978
	{
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 10979
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ParameterInfo, Type> <>9__0_0; // 0x08

			// Constructors
			static <>c(); // 0x000000018214C460-0x000000018214C4C0
			public <>c(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal Type <Compile>b__0_0(ParameterInfo pi); // 0x00000001806D97C0-0x00000001806D97F0
		}

		// Methods
		public static Delegate Compile(Type delegateType, Type instanceType); // 0x000000018214A2E0-0x000000018214A6F0
		public static TDelegate Compile<TDelegate>(Type instanceType);
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10980
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<DefComponent> <>9__19_1; // 0x08

		// Constructors
		static <>c(); // 0x000000018214C4C0-0x000000018214C520
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnLoaded>b__19_1(DefComponent c); // 0x000000018214C260-0x000000018214C290
	}

	// Constructors
	public BaseDef(); // 0x000000018215BA80-0x000000018215BB00
	static BaseDef(); // 0x000000018215BA00-0x000000018215BA80

	// Methods
	public static void ClearDefCache(); // 0x000000018215A450-0x000000018215A590
	public static BaseDef GetDef(string inDefID, bool inShowErrors = false /* Metadata: 0x0077C5F7 */); // 0x000000018215A9C0-0x000000018215AAA0
	public static List<string> GetAllDefIDsWithTemplate<T>();
	public static List<BaseDef> GetAllDefsWithTemplate<T>();
	public static T GetDefComponent<T>(string inDefID, bool inShowErrors = false /* Metadata: 0x0077C5F8 */)
		where T : DefComponent;
	public static List<BaseDef> GetDefs(List<string> inDefIDs, bool inShowErrors = false /* Metadata: 0x0077C5F9 */); // 0x000000018215AAA0-0x000000018215ACF0
	public static List<T> GetDefComponents<T>(List<string> inDefIDs, bool inShowErrors = false /* Metadata: 0x0077C5FA */)
		where T : DefComponent;
	public override void LoadEntry(); // 0x000000018215B7F0-0x000000018215B890
	public override void LoadComponents(); // 0x000000018215AD50-0x000000018215ADC0
	public override void OnLoaded(); // 0x000000018215B890-0x000000018215B9D0
	public static DefComponent ConstructDefComponent(string inTypeName); // 0x000000018215A590-0x000000018215A800
	public void LoadDataJSON(string inJSON); // 0x000000018215ADC0-0x000000018215B7F0
	public static bool isValidDefID(string inDefID); // 0x000000018215C390-0x000000018215C3F0
	public static bool IsValidBundleID(string inBundleID); // 0x000000018215ACF0-0x000000018215AD50
	public override bool Equals(object obj); // 0x000000018215A800-0x000000018215A8C0
	public static bool operator ==(BaseDef a, BaseDef b); // 0x000000018215C3F0-0x000000018215C420
	public static bool operator !=(BaseDef a, BaseDef b); // 0x000000018215C420-0x000000018215C4C0
	public override int GetHashCode(); // 0x0000000180766BC0-0x0000000180766BD0
	public override string ToString(); // 0x00000001803745B0-0x00000001803745C0
	public static BaseDef FromJson(JsonData data); // 0x000000018215A8C0-0x000000018215A9C0
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
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnLoaded>b__19_0(DefComponent c); // 0x000000018215B9D0-0x000000018215BA00
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public sealed class Item : ISoftReferable // TypeDefIndex: 11983
{
	// Fields
	[NonSerialized]
	public DateTime timeCreated; // 0x10
	public readonly string Id; // 0x18
	public readonly ItemType ItemType; // 0x20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private BaseDef <def>k__BackingField; // 0x28
	private bool _dirty; // 0x30
	private ComponentContainer _components; // 0x38

	// Properties
	public BaseDef def { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	public string defID { get; } // 0x0000000180879AB0-0x0000000180879AC0 
	public bool IsDirty { get; set; } // 0x0000000180455B90-0x0000000180455BA0 0x0000000180879AC0-0x0000000180879D00

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11984
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<ItemComponent> <>9__18_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180884A60-0x0000000180884AC0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnLoaded>b__18_0(ItemComponent c); // 0x00000001806D97C0-0x00000001806D97F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass19_0 // TypeDefIndex: 11985
	{
		// Fields
		public Item <>4__this; // 0x10
		public Item clone; // 0x18

		// Constructors
		public <>c__DisplayClass19_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <UpdateFromServer>b__0(ItemComponent c); // 0x0000000180884790-0x00000001808848F0
		internal void <UpdateFromServer>b__1(ItemComponent c); // 0x00000001808848F0-0x0000000180884960
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 11986
	{
		// Fields
		public JsonData componentsJson; // 0x10

		// Constructors
		public <>c__DisplayClass20_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <ToJson>b__0(ItemComponent c); // 0x0000000180884960-0x0000000180884A30
	}

	// Constructors
	public Item(JsonData data); // 0x0000000180879530-0x00000001808799E0
	public Item(ItemType category, BaseDef def = null); // 0x00000001808799E0-0x0000000180879AB0

	// Methods
	public T GetDef<T>()
		where T : BaseDef;
	public T GetDefComponent<T>()
		where T : DefComponent;
	private void LoadDef(string defId); // 0x0000000180878EE0-0x0000000180879130
	public void OnLoaded(); // 0x0000000180879130-0x0000000180879230
	public void UpdateFromServer(Item clone); // 0x00000001808793E0-0x0000000180879530
	public JsonData ToJson(); // 0x0000000180879230-0x00000001808793E0
	public ItemComponent AddComponentFromUpdate(ItemComponent compFromServer); // 0x0000000180878CB0-0x0000000180878D20
	public T AddComponent<T>(bool isClientOnly = false /* Metadata: 0x007B9472 */)
		where T : ItemComponent;
	public T AddComponent<T>(JsonData json)
		where T : ItemComponent;
	public ItemComponent AddComponent(Type ofType); // 0x0000000180878D20-0x0000000180878DD0
	public ItemComponent GetComponent(Type ofType); // 0x0000000180878E30-0x0000000180878EE0
	public T GetComponent<T>()
		where T : ItemComponent;
	public bool HasComponent<T>()
		where T : ItemComponent;
	public void RemoveComponent<T>()
		where T : ItemComponent;
	public void ForEachComponent<T>(Action<T> op)
		where T : ItemComponent;
	public void ForEachComponent(Action<ItemComponent> op); // 0x0000000180878DD0-0x0000000180878E30
}


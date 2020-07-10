/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public sealed class Item : ISoftReferable // TypeDefIndex: 10495
{
	// Fields
	[NonSerialized]
	public DateTime timeCreated; // 0x10
	public readonly string Id; // 0x18
	public readonly ItemType ItemType; // 0x20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private BaseDef <def>k__BackingField; // 0x28
	private bool _dirty; // 0x30
	private ComponentContainer _components; // 0x38

	// Properties
	public BaseDef def { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	public string defID { get; } // 0x00000001812C0280-0x00000001812C0290 
	public bool IsDirty { get; set; } // 0x000000018048B840-0x000000018048B850 0x00000001812C0290-0x00000001812C04D0

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10496
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<ItemComponent> <>9__18_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001812D5DE0-0x00000001812D5E40
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnLoaded>b__18_0(ItemComponent c); // 0x0000000180DF2B50-0x0000000180DF2B80
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass19_0 // TypeDefIndex: 10497
	{
		// Fields
		public Item <>4__this; // 0x10
		public Item clone; // 0x18

		// Constructors
		public <>c__DisplayClass19_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <UpdateFromServer>b__0(ItemComponent c); // 0x00000001812D5B30-0x00000001812D5CA0
		internal void <UpdateFromServer>b__1(ItemComponent c); // 0x00000001812D5CA0-0x00000001812D5D10
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 10498
	{
		// Fields
		public JsonData componentsJson; // 0x10

		// Constructors
		public <>c__DisplayClass20_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <ToJson>b__0(ItemComponent c); // 0x00000001812D5D10-0x00000001812D5DE0
	}

	// Constructors
	public Item(JsonData data); // 0x00000001812BFBB0-0x00000001812C01B0
	public Item(ItemType category, BaseDef def = null); // 0x00000001812C01B0-0x00000001812C0280

	// Methods
	public T GetDef<T>()
		where T : BaseDef;
	public T GetDefComponent<T>()
		where T : DefComponent;
	private void LoadDef(string defId); // 0x00000001812BF450-0x00000001812BF6A0
	public void OnLoaded(); // 0x00000001812BF6A0-0x00000001812BF7A0
	public void UpdateFromServer(Item clone); // 0x00000001812BFA50-0x00000001812BFBB0
	public JsonData ToJson(); // 0x00000001812BF7A0-0x00000001812BFA50
	public ItemComponent AddComponentFromUpdate(ItemComponent compFromServer); // 0x00000001812BF220-0x00000001812BF290
	public T AddComponent<T>(bool isClientOnly = false /* Metadata: 0x00781DC7 */)
		where T : ItemComponent;
	public T AddComponent<T>(JsonData json)
		where T : ItemComponent;
	public ItemComponent AddComponent(Type ofType); // 0x00000001812BF290-0x00000001812BF340
	public ItemComponent GetComponent(Type ofType); // 0x00000001812BF3A0-0x00000001812BF450
	public T GetComponent<T>()
		where T : ItemComponent;
	public bool HasComponent<T>()
		where T : ItemComponent;
	public void RemoveComponent<T>()
		where T : ItemComponent;
	public void ForEachComponent<T>(Action<T> op)
		where T : ItemComponent;
	public void ForEachComponent(Action<ItemComponent> op); // 0x00000001812BF340-0x00000001812BF3A0
}


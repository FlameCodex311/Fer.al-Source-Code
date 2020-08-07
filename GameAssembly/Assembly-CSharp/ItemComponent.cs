/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public abstract class ItemComponent : ComponentBase, ISoftReferable // TypeDefIndex: 11988
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Item <item>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsClientOnly>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsDirty>k__BackingField; // 0x19

	// Properties
	public Item item { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
	public bool IsClientOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803F6D30-0x00000001803F6D40 0x00000001803F6D40-0x00000001803F6D50
	public bool IsDirty { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180690340-0x0000000180690350 0x0000000180878500-0x0000000180878510

	// Constructors
	protected ItemComponent(); // 0x00000001803F46D0-0x00000001803F46E0

	// Methods
	public virtual void OnAdded(Item item); // 0x0000000180379F20-0x0000000180379F30
	public void ParseJson(Item item, JsonData jsonData); // 0x0000000180878350-0x00000001808783B0
	public virtual ItemComponent ParseJsonOverride(JsonData jsonData); // 0x000000018037DDC0-0x000000018037DDD0
	public JsonData ToJson(); // 0x00000001808783B0-0x0000000180878430
	protected virtual JsonData ToJsonOverride(); // 0x000000018037DDC0-0x000000018037DDD0
	public void CopyInto(ItemComponent overwriteMe); // 0x00000001808781A0-0x0000000180878250
	public virtual void OnLoaded(); // 0x00000001803774A0-0x00000001803774B0
	public void UpdateFromServer(ItemComponent fromServer); // 0x0000000180878430-0x0000000180878500
	protected virtual ItemComponent UpdateFromServerOverride(ItemComponent fromServer); // 0x000000018037DDC0-0x000000018037DDD0
	public virtual void OnAddedFromUpdate(ItemComponent fromUpdate); // 0x00000001803774A0-0x00000001803774B0
	public virtual void OnRemovedFromUpdate(); // 0x00000001803774A0-0x00000001803774B0
	protected virtual void OnCopiedFrom(ItemComponent from); // 0x00000001803774A0-0x00000001803774B0
	public static Type GetTypeFromJsonKey(string key); // 0x00000001808782C0-0x0000000180878350
	public static string GetJsonKeyFromType(Type type); // 0x0000000180878250-0x00000001808782C0
}


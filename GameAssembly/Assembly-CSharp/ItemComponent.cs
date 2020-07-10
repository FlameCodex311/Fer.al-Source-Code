/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public abstract class ItemComponent : ComponentBase, ISoftReferable // TypeDefIndex: 10500
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Item <item>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <IsClientOnly>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <IsDirty>k__BackingField; // 0x19

	// Properties
	public Item item { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
	public bool IsClientOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018041BAC0-0x000000018041BAD0 0x000000018048F590-0x000000018048F5A0
	public bool IsDirty { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018048F440-0x000000018048F450 0x000000018048F560-0x000000018048F570

	// Constructors
	protected ItemComponent(); // 0x000000018037E800-0x000000018037E810

	// Methods
	public virtual void OnAdded(Item item); // 0x000000018036B1E0-0x000000018036B1F0
	public void ParseJson(Item item, JsonData jsonData); // 0x00000001812BE8C0-0x00000001812BE920
	public virtual ItemComponent ParseJsonOverride(JsonData jsonData); // 0x000000018035FCC0-0x000000018035FCD0
	public JsonData ToJson(); // 0x00000001812BE920-0x00000001812BE9A0
	protected virtual JsonData ToJsonOverride(); // 0x000000018035FCC0-0x000000018035FCD0
	public void CopyInto(ItemComponent overwriteMe); // 0x00000001812BE710-0x00000001812BE7C0
	public virtual void OnLoaded(); // 0x00000001803581E0-0x00000001803581F0
	public void UpdateFromServer(ItemComponent fromServer); // 0x00000001812BE9A0-0x00000001812BEA70
	protected virtual ItemComponent UpdateFromServerOverride(ItemComponent fromServer); // 0x000000018035FCC0-0x000000018035FCD0
	public virtual void OnAddedFromUpdate(ItemComponent fromUpdate); // 0x00000001803581E0-0x00000001803581F0
	public virtual void OnRemovedFromUpdate(); // 0x00000001803581E0-0x00000001803581F0
	protected virtual void OnCopiedFrom(ItemComponent from); // 0x00000001803581E0-0x00000001803581F0
	public static Type GetTypeFromJsonKey(string key); // 0x00000001812BE830-0x00000001812BE8C0
	public static string GetJsonKeyFromType(Type type); // 0x00000001812BE7C0-0x00000001812BE830
}


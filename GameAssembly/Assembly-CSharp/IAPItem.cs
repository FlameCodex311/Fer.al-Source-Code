/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class IAPItem // TypeDefIndex: 12552
{
	// Fields
	public string uuid; // 0x10
	public string title; // 0x18
	public string shortDescription; // 0x20
	public string longDescription; // 0x28
	public string imageURL; // 0x30
	public string priceText; // 0x38
	public bool isConsumable; // 0x40
	public bool hasBeenPurchased; // 0x41
	public string defId; // 0x48
	private BaseDef _def; // 0x50
	public IAPItemReward[] rewards; // 0x58

	// Properties
	public BaseDef Def { get; } // 0x0000000180620130-0x00000001806201D0 
	public bool IsBundlePack { get; } // 0x00000001806201D0-0x00000001806202C0 

	// Constructors
	public IAPItem(JsonData jsonData); // 0x000000018061FD70-0x0000000180620130
}


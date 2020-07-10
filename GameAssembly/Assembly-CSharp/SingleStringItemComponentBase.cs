/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public abstract class SingleStringItemComponentBase : ItemComponent // TypeDefIndex: 10504
{
	// Fields
	public string value; // 0x20

	// Properties
	public abstract string JsonKey { get; }

	// Constructors
	protected SingleStringItemComponentBase(); // 0x0000000180363710-0x0000000180363720

	// Methods
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x0000000181358630-0x00000001813586C0
}


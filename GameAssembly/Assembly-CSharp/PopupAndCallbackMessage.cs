/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class PopupAndCallbackMessage : Message // TypeDefIndex: 13531
{
	// Fields
	public string message; // 0x18
	public string title; // 0x20
	public Action<string> callback; // 0x28

	// Constructors
	public PopupAndCallbackMessage(string inMessage, string inTitle, Action<string> inCallback); // 0x0000000180E982D0-0x0000000180E98320
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class DecreeItem // TypeDefIndex: 12506
{
	// Fields
	public readonly string headerLocalizationDefId; // 0x10
	public readonly string messageLocalizationDefId; // 0x18
	public readonly string imageDefId; // 0x20
	public readonly DecreeCategory decreeCategory; // 0x28
	public readonly DecreeLayoutType decreeLayoutType; // 0x2C

	// Nested types
	public enum DecreeLayoutType // TypeDefIndex: 12507
	{
		Billboard = 0,
		ImageWithText = 1,
		TextWithIcon = 2,
		TextOnly = 3,
		ImageOnly = 4
	}

	public enum DecreeCategory // TypeDefIndex: 12508
	{
		FrontPage = 0,
		Events = 1,
		CheckItOut = 2
	}

	// Constructors
	public DecreeItem(DecreeDefComponent decreeDef); // 0x000000018055F460-0x000000018055F4C0
	public DecreeItem(JsonData jsonData); // 0x0000000180373240-0x0000000180373250
}


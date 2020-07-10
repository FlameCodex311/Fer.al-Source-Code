/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartTemplate] // 0x00000001800D1200-0x00000001800D12A0
public class LocalizationTemplate : PropertyEditor.ChartTemplateBase // TypeDefIndex: 11552
{
	// Fields
	public LocalizationDefComponent localizationDefComponent; // 0x18
	public OldLocalizationDefComponent oldLocalizationDefComponent; // 0x20
	private string _enText; // 0x28

	// Properties
	public string EnText { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40

	// Constructors
	public LocalizationTemplate(); // 0x00000001811E7F60-0x00000001811E7FC0

	// Methods
	public override void OnCreateGUI(); // 0x00000001811E7E60-0x00000001811E7EE0
	public override List<ValueTuple<string, string>> GetSuggestions(); // 0x00000001811E7B50-0x00000001811E7E60
	public override void OnCreated(PropertyEditor.DefEntry inDefEntry); // 0x00000001811E7EE0-0x00000001811E7F60
}


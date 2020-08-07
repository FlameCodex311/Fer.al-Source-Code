/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartTemplate] // 0x0000000180270270-0x0000000180270310
public class LocalizationTemplate : PropertyEditor.ChartTemplateBase // TypeDefIndex: 13076
{
	// Fields
	public LocalizationDefComponent localizationDefComponent; // 0x18
	public OldLocalizationDefComponent oldLocalizationDefComponent; // 0x20
	private string _enText; // 0x28

	// Properties
	public string EnText { get; set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0

	// Constructors
	public LocalizationTemplate(); // 0x00000001804EEB00-0x00000001804EEB60

	// Methods
	public override void OnCreateGUI(); // 0x00000001804EEA00-0x00000001804EEA80
	public override List<ValueTuple<string, string>> GetSuggestions(); // 0x00000001804EE700-0x00000001804EEA00
	public override void OnCreated(PropertyEditor.DefEntry inDefEntry); // 0x00000001804EEA80-0x00000001804EEB00
}


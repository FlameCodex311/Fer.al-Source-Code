/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartTemplate] // 0x0000000180268290-0x0000000180268330
public class ActorNPCTemplate : PropertyEditor.ChartTemplateBase // TypeDefIndex: 13051
{
	// Fields
	public ActorNPCDefComponent actorNPCDefComponent; // 0x18
	public LocalizedNameDefComponent localizedNameDefComponent; // 0x20
	public Icon2DDefComponent icon2DDefComponent; // 0x28
	public ActorInfoGetModelDefComponent actorInfoGetModelDefComponent; // 0x30
	public ActorInfoDefComponent actorInfoDefComponent; // 0x38
	public EditorScreenshotDefComponent editorScreenshotDefComponent; // 0x40

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 13052
	{
		// Fields
		public PropertyEditor.DefEntry inDefEntry; // 0x10

		// Constructors
		public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenInNPCEditor>b__0(UI_Window_CreatureCustomization inWindow); // 0x00000001821626B0-0x00000001821627F0
	}

	// Constructors
	public ActorNPCTemplate(); // 0x000000018214D7A0-0x000000018214D800

	// Methods
	[TemplateButton] // 0x00000001802684C0-0x00000001802684F0
	public static void OpenInNPCEditor(PropertyEditor.DefEntry inDefEntry); // 0x000000018214D6E0-0x000000018214D7A0
	public static bool OpenInNPCEditor_Visible(PropertyEditor.DefEntry inDefEntry); // 0x000000018214D6C0-0x000000018214D6E0
}


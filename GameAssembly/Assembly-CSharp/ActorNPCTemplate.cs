/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartTemplate] // 0x00000001800C8AC0-0x00000001800C8B60
public class ActorNPCTemplate : PropertyEditor.ChartTemplateBase // TypeDefIndex: 11527
{
	// Fields
	public ActorNPCDefComponent actorNPCDefComponent; // 0x18
	public LocalizedNameDefComponent localizedNameDefComponent; // 0x20
	public Icon2DDefComponent icon2DDefComponent; // 0x28
	public ActorInfoGetModelDefComponent actorInfoGetModelDefComponent; // 0x30
	public ActorInfoDefComponent actorInfoDefComponent; // 0x38
	public EditorScreenshotDefComponent editorScreenshotDefComponent; // 0x40

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 11528
	{
		// Fields
		public PropertyEditor.DefEntry inDefEntry; // 0x10

		// Constructors
		public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenInNPCEditor>b__0(UI_Window_CreatureCustomization inWindow); // 0x000000018141CF50-0x000000018141CFE0
	}

	// Constructors
	public ActorNPCTemplate(); // 0x000000018140FB10-0x000000018140FB70

	// Methods
	[TemplateButton] // 0x00000001800C9110-0x00000001800C9140
	public static void OpenInNPCEditor(PropertyEditor.DefEntry inDefEntry); // 0x000000018140FA40-0x000000018140FB10
	public static bool OpenInNPCEditor_Visible(PropertyEditor.DefEntry inDefEntry); // 0x000000018140FA20-0x000000018140FA40
}


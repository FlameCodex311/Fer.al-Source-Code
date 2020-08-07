/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Category] // 0x00000001802236C0-0x00000001802236F0
public class SetEnumFlag : ActionTask // TypeDefIndex: 11365
{
	// Fields
	[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
	[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
	public readonly BBObjectParameter Variable; // 0x68
	public readonly BBObjectParameter Flag; // 0x70
	public readonly BBParameter<bool> Clear; // 0x78

	// Properties
	protected override string info { get; } // 0x000000018076AF70-0x000000018076AFF0 

	// Constructors
	public SetEnumFlag(); // 0x000000018076AE80-0x000000018076AF70

	// Methods
	protected override void OnExecute(); // 0x000000018076AC70-0x000000018076AE80
}


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
public class CheckEnumFlag : ConditionTask // TypeDefIndex: 11366
{
	// Fields
	[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
	[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
	public readonly BBObjectParameter Variable; // 0x68
	public readonly BBObjectParameter Flag; // 0x70

	// Properties
	protected override string info { get; } // 0x0000000180521BF0-0x0000000180521C30 

	// Constructors
	public CheckEnumFlag(); // 0x0000000180521B20-0x0000000180521BF0

	// Methods
	protected override bool OnCheck(); // 0x00000001805219A0-0x0000000180521B20
}


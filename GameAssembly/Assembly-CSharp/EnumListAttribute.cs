/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class EnumListAttribute : PropertyAttribute // TypeDefIndex: 13678
{
	// Fields
	public readonly Type enumType; // 0x18
	public readonly float labelWidthPercent; // 0x20
	public readonly bool isEnum; // 0x24
	public readonly string[] enumNames; // 0x28

	// Constructors
	public EnumListAttribute(Type inEnumType, float inLabelWidthPercent = 0.35f /* Metadata: 0x00783FBF */); // 0x0000000181192010-0x0000000181192140

	// Methods
	public static int EnumValueToIndex<T>(T enumValue)
		where T : struct, IConvertible;
	public static T EnumIndexToValue<T>(int index, T defaultValue)
		where T : struct, IConvertible;
}


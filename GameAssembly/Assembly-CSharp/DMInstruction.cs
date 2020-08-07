/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class DMInstruction // TypeDefIndex: 10878
{
	// Fields
	public static int CREATE; // 0x00
	public static int GROUP; // 0x04
	public static int UNGROUP; // 0x08
	public static int SECTION; // 0x0C
	public static int UNSECTION; // 0x10
	public static int COLLAPSE; // 0x14
	public static int UNCOLLAPSE; // 0x18
	public static int HORIZONTAL; // 0x1C
	public static int VERTICAL; // 0x20
	public static int TEXT; // 0x24
	public static int INPUT; // 0x28
	public static int BUTTON; // 0x2C
	public static int TOGGLE; // 0x30
	public int action; // 0x10
	public GameObject prefab; // 0x18
	public int type; // 0x20
	public int direction; // 0x24
	public Action onClick; // 0x28
	public Func<string> sGetter; // 0x30
	public Action<string> sSetter; // 0x38
	public Func<bool> bGetter; // 0x40
	public Action<bool> bSetter; // 0x48
	public string text; // 0x50
	public string title; // 0x58
	public bool open; // 0x60
	public string id; // 0x68
	public string parentId; // 0x70
	public bool isParent; // 0x78
	public bool isParentEnd; // 0x79

	// Constructors
	public DMInstruction(); // 0x0000000180373240-0x0000000180373250
	static DMInstruction(); // 0x0000000180556A30-0x0000000180556B70
}


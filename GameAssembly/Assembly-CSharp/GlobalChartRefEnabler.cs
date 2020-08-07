/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class GlobalChartRefEnabler : ManagedBehaviour // TypeDefIndex: 11588
{
	// Fields
	[Header] // 0x0000000180222B10-0x0000000180222B60
	[SerializeField] // 0x0000000180222B10-0x0000000180222B60
	private GlobalChartRef _globalChartRef; // 0x50
	[Header] // 0x00000001802237A0-0x00000001802237F0
	[SerializeField] // 0x00000001802237A0-0x00000001802237F0
	private Argument[] _arguments; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private EAndOr _andOr; // 0x60
	[Header] // 0x0000000180222CA0-0x0000000180222CF0
	[SerializeField] // 0x0000000180222CA0-0x0000000180222CF0
	private GameObject[] enabledOnAvailable; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject[] enabledOnUnAvailable; // 0x70

	// Nested types
	public enum EDataType // TypeDefIndex: 11589
	{
		BOOL = 0,
		FLOAT = 1,
		STRING = 2,
		INT = 3
	}

	public enum EComparisons // TypeDefIndex: 11590
	{
		EQUAL = 0,
		NOTEQUAL = 1,
		GREATERTHAN = 2,
		GREATERTHANOREQUALTO = 3,
		LESSERTHAN = 4,
		LESSERTHANOREQUALTO = 5
	}

	public enum EAndOr // TypeDefIndex: 11591
	{
		AND = 0,
		OR = 1
	}

	[Serializable]
	public class Argument // TypeDefIndex: 11592
	{
		// Fields
		[Header] // 0x0000000180223DE0-0x0000000180223E10
		public EDataType dataType; // 0x10
		[Header] // 0x0000000180223F10-0x0000000180223F40
		public EComparisons boolCompare; // 0x14
		public bool boolToCheck; // 0x18
		[Header] // 0x0000000180224110-0x0000000180224140
		public EComparisons floatCompare; // 0x1C
		public float floatToCheck; // 0x20
		[Header] // 0x0000000180225610-0x0000000180225640
		public EComparisons stringCompare; // 0x24
		public string stringToCheck; // 0x28
		[Header] // 0x0000000180225730-0x0000000180225760
		public EComparisons intCompare; // 0x30
		public int intToCheck; // 0x34

		// Constructors
		public Argument(); // 0x000000018067A570-0x000000018067A5B0
	}

	// Constructors
	public GlobalChartRefEnabler(); // 0x0000000180683140-0x00000001806831A0

	// Methods
	public override void MStart(); // 0x0000000180682E20-0x00000001806830A0
	private bool Compare(Argument inArgument); // 0x0000000180682920-0x0000000180682A90
	private bool BoolCompare(Argument inArgument); // 0x0000000180682890-0x0000000180682920
	private bool StringCompare(Argument inArgument); // 0x00000001806830A0-0x0000000180683140
	private bool FloatCompare(Argument inArgument); // 0x0000000180682A90-0x0000000180682C70
	private bool IntCompare(Argument inArgument); // 0x0000000180682C70-0x0000000180682E20
}


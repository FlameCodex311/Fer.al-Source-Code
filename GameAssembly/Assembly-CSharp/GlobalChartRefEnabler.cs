/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class GlobalChartRefEnabler : ManagedBehaviour // TypeDefIndex: 10097
{
	// Fields
	[Header] // 0x00000001801496D0-0x0000000180149720
	[SerializeField] // 0x00000001801496D0-0x0000000180149720
	private GlobalChartRef _globalChartRef; // 0x50
	[Header] // 0x000000018014A7B0-0x000000018014A800
	[SerializeField] // 0x000000018014A7B0-0x000000018014A800
	private Argument[] _arguments; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private EAndOr _andOr; // 0x60
	[Header] // 0x0000000180149BA0-0x0000000180149BF0
	[SerializeField] // 0x0000000180149BA0-0x0000000180149BF0
	private GameObject[] enabledOnAvailable; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject[] enabledOnUnAvailable; // 0x70

	// Nested types
	public enum EDataType // TypeDefIndex: 10098
	{
		BOOL = 0,
		FLOAT = 1,
		STRING = 2,
		INT = 3
	}

	public enum EComparisons // TypeDefIndex: 10099
	{
		EQUAL = 0,
		NOTEQUAL = 1,
		GREATERTHAN = 2,
		GREATERTHANOREQUALTO = 3,
		LESSERTHAN = 4,
		LESSERTHANOREQUALTO = 5
	}

	public enum EAndOr // TypeDefIndex: 10100
	{
		AND = 0,
		OR = 1
	}

	[Serializable]
	public class Argument // TypeDefIndex: 10101
	{
		// Fields
		[Header] // 0x000000018014AEC0-0x000000018014AEF0
		public EDataType dataType; // 0x10
		[Header] // 0x000000018014B090-0x000000018014B0C0
		public EComparisons boolCompare; // 0x14
		public bool boolToCheck; // 0x18
		[Header] // 0x000000018014B200-0x000000018014B230
		public EComparisons floatCompare; // 0x1C
		public float floatToCheck; // 0x20
		[Header] // 0x000000018014B4D0-0x000000018014B500
		public EComparisons stringCompare; // 0x24
		public string stringToCheck; // 0x28
		[Header] // 0x000000018014B730-0x000000018014B760
		public EComparisons intCompare; // 0x30
		public int intToCheck; // 0x34

		// Constructors
		public Argument(); // 0x000000018104FBD0-0x000000018104FC10
	}

	// Constructors
	public GlobalChartRefEnabler(); // 0x0000000181057AC0-0x0000000181057B20

	// Methods
	public override void MStart(); // 0x0000000181057780-0x0000000181057A20
	private bool Compare(Argument inArgument); // 0x0000000181057240-0x00000001810573C0
	private bool BoolCompare(Argument inArgument); // 0x00000001810571A0-0x0000000181057240
	private bool StringCompare(Argument inArgument); // 0x0000000181057A20-0x0000000181057AC0
	private bool FloatCompare(Argument inArgument); // 0x00000001810573C0-0x00000001810575C0
	private bool IntCompare(Argument inArgument); // 0x00000001810575C0-0x0000000181057780
}


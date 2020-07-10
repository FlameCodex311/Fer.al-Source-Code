/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FeralAudioEventMapper // TypeDefIndex: 13699
{
	// Fields
	private static FeralAudioEventMapper _instance; // 0x00
	private Dictionary<string, string> _eventBankMap; // 0x10

	// Properties
	public static FeralAudioEventMapper instance { get; } // 0x00000001810FA280-0x00000001810FA300 
	public Dictionary<string, string> eventBankMap { get; } // 0x00000001810FA100-0x00000001810FA280 

	// Nested types
	[Serializable]
	public class EventBankDictionaryEntry // TypeDefIndex: 13700
	{
		// Fields
		public string key; // 0x10
		public string value; // 0x18

		// Constructors
		public EventBankDictionaryEntry(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class EventBankDictionary // TypeDefIndex: 13701
	{
		// Fields
		public EventBankDictionaryEntry[] items; // 0x10

		// Constructors
		public EventBankDictionary(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public FeralAudioEventMapper(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	public string LookupBank(string eventId); // 0x00000001810F9FF0-0x00000001810FA100
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FeralAudioEventMapper // TypeDefIndex: 11372
{
	// Fields
	private static FeralAudioEventMapper _instance; // 0x00
	private Dictionary<string, string> _eventBankMap; // 0x10

	// Properties
	public static FeralAudioEventMapper instance { get; } // 0x000000018068F660-0x000000018068F6E0 
	public Dictionary<string, string> eventBankMap { get; } // 0x000000018068F4F0-0x000000018068F660 

	// Nested types
	[Serializable]
	public class EventBankDictionaryEntry // TypeDefIndex: 11373
	{
		// Fields
		public string key; // 0x10
		public string value; // 0x18

		// Constructors
		public EventBankDictionaryEntry(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class EventBankDictionary // TypeDefIndex: 11374
	{
		// Fields
		public EventBankDictionaryEntry[] items; // 0x10

		// Constructors
		public EventBankDictionary(); // 0x0000000180373240-0x0000000180373250
	}

	// Constructors
	public FeralAudioEventMapper(); // 0x0000000180373240-0x0000000180373250

	// Methods
	public string LookupBank(string eventId); // 0x000000018068F3E0-0x000000018068F4F0
}


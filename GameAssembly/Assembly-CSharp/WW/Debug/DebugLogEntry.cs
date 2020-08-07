/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Debug
{
	public class DebugLogEntry : IEquatable<WW.Debug.DebugLogEntry> // TypeDefIndex: 16262
	{
		// Fields
		private const int HASH_NOT_CALCULATED = -623218; // Metadata: 0x007BBAA3
		public string logString; // 0x10
		public string stackTrace; // 0x18
		private string completeLog; // 0x20
		public Sprite logTypeSpriteRepresentation; // 0x28
		public int count; // 0x30
		private int hashValue; // 0x34
	
		// Constructors
		public DebugLogEntry(string logString, string stackTrace, Sprite sprite); // 0x0000000180969560-0x00000001809695C0
	
		// Methods
		public bool Equals(DebugLogEntry other); // 0x0000000180969320-0x0000000180969380
		public bool Search(string inSearchString); // 0x0000000180969470-0x0000000180969510
		public override string ToString(); // 0x0000000180969510-0x0000000180969560
		public override int GetHashCode(); // 0x0000000180969380-0x0000000180969470
	}
}

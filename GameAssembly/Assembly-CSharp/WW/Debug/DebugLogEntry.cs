/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Debug
{
	public class DebugLogEntry : IEquatable<WW.Debug.DebugLogEntry> // TypeDefIndex: 15710
	{
		// Fields
		private const int HASH_NOT_CALCULATED = -623218; // Metadata: 0x00784EBB
		public string logString; // 0x10
		public string stackTrace; // 0x18
		private string completeLog; // 0x20
		public Sprite logTypeSpriteRepresentation; // 0x28
		public int count; // 0x30
		private int hashValue; // 0x34
	
		// Constructors
		public DebugLogEntry(string logString, string stackTrace, Sprite sprite); // 0x0000000181124550-0x00000001811245B0
	
		// Methods
		public bool Equals(DebugLogEntry other); // 0x0000000181124300-0x0000000181124360
		public bool Search(string inSearchString); // 0x0000000181124450-0x0000000181124500
		public override string ToString(); // 0x0000000181124500-0x0000000181124550
		public override int GetHashCode(); // 0x0000000181124360-0x0000000181124450
	}
}

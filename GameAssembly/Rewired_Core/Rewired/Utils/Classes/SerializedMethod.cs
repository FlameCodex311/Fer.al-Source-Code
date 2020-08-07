/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001801DDE50-0x00000001801DDE80
	public abstract class SerializedMethod : ScriptableObject // TypeDefIndex: 6204
	{
		// Fields
		private const int bIAFJjrEhxJVesagGnsnZvfWEVL = 3; // Metadata: 0x00764519
		[NonSerialized]
		private bool EzMOIXQBTFiJAAYENudzxAahUBH; // 0x18
		[NonSerialized]
		internal List<TypeWrapper> _data; // 0x20
		[NonSerialized]
		internal TypeWrapper _result; // 0x28
		[NonSerialized]
		internal bool _resultIsValid; // 0x48
	
		// Properties
		internal abstract TypeWrapper.DataType ResultType { get; }
		internal int DataCount { get; } // 0x00000001813FA340-0x00000001813FA380 
		internal TypeWrapper Result { get; } // 0x00000001813FA380-0x00000001813FA3A0 
		internal bool ResultIsValid { get; } // 0x00000001803C9D60-0x00000001803C9D70 
	
		// Constructors
		protected SerializedMethod(); // 0x00000001803FEC00-0x00000001803FEC10
	
		// Methods
		internal TypeWrapper GetData(int index); // 0x00000001813FA200-0x00000001813FA2E0
		internal void AddData(byte item); // 0x00000001813F9A10-0x00000001813F9B10
		internal void AddData(sbyte item); // 0x00000001813F9560-0x00000001813F9650
		internal void AddData(char item); // 0x00000001813F9F40-0x00000001813FA050
		internal void AddData(int item); // 0x00000001813F9650-0x00000001813F9740
		internal void AddData(uint item); // 0x00000001813F9D40-0x00000001813F9E30
		internal void AddData(long item); // 0x00000001813FA050-0x00000001813FA150
		internal void AddData(ulong item); // 0x00000001813F9740-0x00000001813F9820
		internal void AddData(float item); // 0x00000001813F9E30-0x00000001813F9F40
		internal void AddData(double item); // 0x00000001813F9910-0x00000001813F9A10
		internal void AddData(bool item); // 0x00000001813F9C30-0x00000001813F9D40
		internal void AddData(string item); // 0x00000001813F9820-0x00000001813F9910
		internal void AddData(object item); // 0x00000001813F9B10-0x00000001813F9C30
		internal void AddData(TypeWrapper item); // 0x00000001813F94A0-0x00000001813F9560
		internal void ClearData(); // 0x00000001813FA150-0x00000001813FA1C0
		internal void ClearResult(); // 0x00000001813FA1C0-0x00000001813FA200
		internal abstract bool Process();
		private void ZIgkBPuFKjtpWUdBApUAAPQeJKk(); // 0x00000001813FA2E0-0x00000001813FA340
	}
}

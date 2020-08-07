/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class CustomCalculation_CompareElementValues : CustomCalculation // TypeDefIndex: 6210
	{
		// Fields
		private const TypeWrapper.DataType resultType = TypeWrapper.DataType.Single; // Metadata: 0x00764539
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ComparisonType _comparisonType; // 0x50
	
		// Properties
		internal override TypeWrapper.DataType ResultType { get; } // 0x0000000180C9C3D0-0x0000000180C9C3E0 
	
		// Nested types
		public enum ComparisonType // TypeDefIndex: 6211
		{
			Min = 0,
			Max = 1,
			MinAbs = 2,
			MaxAbs = 3
		}
	
		// Constructors
		public CustomCalculation_CompareElementValues(); // 0x000000018069E0F0-0x000000018069E100
	
		// Methods
		internal override bool Process(); // 0x0000000180D83720-0x0000000180D837D0
		private float OTfvVZBgrBYnzyMoxrfyrtGNpzR(); // 0x0000000180D83430-0x0000000180D83720
	}
}

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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class CustomCalculation_CompareElementValues : CustomCalculation // TypeDefIndex: 6051
	{
		// Fields
		private const TypeWrapper.DataType resultType = TypeWrapper.DataType.Single; // Metadata: 0x0072F89C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ComparisonType _comparisonType; // 0x50
	
		// Properties
		internal override TypeWrapper.DataType ResultType { get; } // 0x00000001805B2290-0x00000001805B22A0 
	
		// Nested types
		public enum ComparisonType // TypeDefIndex: 6052
		{
			Min = 0,
			Max = 1,
			MinAbs = 2,
			MaxAbs = 3
		}
	
		// Constructors
		public CustomCalculation_CompareElementValues(); // 0x00000001805E3F50-0x00000001805E3F60
	
		// Methods
		internal override bool Process(); // 0x00000001805E44D0-0x00000001805E4580
		private float OTfvVZBgrBYnzyMoxrfyrtGNpzR(); // 0x00000001805E41D0-0x00000001805E44D0
	}
}

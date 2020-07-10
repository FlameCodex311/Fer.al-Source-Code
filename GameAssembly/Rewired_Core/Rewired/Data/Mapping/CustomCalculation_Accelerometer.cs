/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Classes.Data;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class CustomCalculation_Accelerometer : CustomCalculation // TypeDefIndex: 6047
	{
		// Fields
		public CalculationType _calculationType; // 0x50
		public InputType _inputType; // 0x54
		public OutputType _outputType; // 0x58
	
		// Properties
		internal override TypeWrapper.DataType ResultType { get; } // 0x00000001805B2290-0x00000001805B22A0 
	
		// Nested types
		public enum CalculationType // TypeDefIndex: 6048
		{
			Pitch = 0,
			Roll = 1
		}
	
		public enum OutputType // TypeDefIndex: 6049
		{
			Axis = 0,
			Angle = 1
		}
	
		public enum InputType // TypeDefIndex: 6050
		{
			Acceleration = 0,
			UserAcceleration = 1,
			Gravity = 2
		}
	
		// Constructors
		public CustomCalculation_Accelerometer(); // 0x00000001805E3F50-0x00000001805E3F60
	
		// Methods
		internal override bool Process(); // 0x00000001805E3B50-0x00000001805E3C60
		private float VlFbFkKNFShaBpZYQmudNCSgmlkH(); // 0x00000001805E3C60-0x00000001805E3F50
		private float zyHIVCjgmZsZjkMMGrqJKeZqzGw(); // 0x00000001805E3F60-0x00000001805E41D0
		private float FebQTanNEDhUxWgOBFPSIeJPXSh(float param_0000cd1a); // 0x00000001805E3B00-0x00000001805E3B50
	}
}

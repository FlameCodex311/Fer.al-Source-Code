/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Classes.Data;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class CustomCalculation_Accelerometer : CustomCalculation // TypeDefIndex: 6206
	{
		// Fields
		public CalculationType _calculationType; // 0x50
		public InputType _inputType; // 0x54
		public OutputType _outputType; // 0x58
	
		// Properties
		internal override TypeWrapper.DataType ResultType { get; } // 0x0000000180C9C3D0-0x0000000180C9C3E0 
	
		// Nested types
		public enum CalculationType // TypeDefIndex: 6207
		{
			Pitch = 0,
			Roll = 1
		}
	
		public enum OutputType // TypeDefIndex: 6208
		{
			Axis = 0,
			Angle = 1
		}
	
		public enum InputType // TypeDefIndex: 6209
		{
			Acceleration = 0,
			UserAcceleration = 1,
			Gravity = 2
		}
	
		// Constructors
		public CustomCalculation_Accelerometer(); // 0x000000018069E0F0-0x000000018069E100
	
		// Methods
		internal override bool Process(); // 0x0000000180D82DC0-0x0000000180D82ED0
		private float VlFbFkKNFShaBpZYQmudNCSgmlkH(); // 0x0000000180D82ED0-0x0000000180D831C0
		private float zyHIVCjgmZsZjkMMGrqJKeZqzGw(); // 0x0000000180D831C0-0x0000000180D83430
		private float FebQTanNEDhUxWgOBFPSIeJPXSh(float param_0000cf8a); // 0x0000000180D82D70-0x0000000180D82DC0
	}
}

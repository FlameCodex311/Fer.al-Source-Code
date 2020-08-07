/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Interfaces
{
	[CustomClassObfuscation] // 0x00000001801CE700-0x00000001801CE750
	[CustomObfuscation] // 0x00000001801CE700-0x00000001801CE750
	public interface IControllerVibrator // TypeDefIndex: 6073
	{
		// Properties
		int vibrationMotorCount { get; }
	
		// Methods
		void SetVibration(int motorIndex, float motorLevel);
		void SetVibration(int motorIndex, float motorLevel, float duration);
		void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors);
		void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors);
		float GetVibration(int motorIndex);
		void StopVibration();
	}
}

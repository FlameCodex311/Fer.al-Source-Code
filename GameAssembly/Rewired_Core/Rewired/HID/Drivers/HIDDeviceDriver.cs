/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Config;
using Rewired.Drivers.Interfaces;
using Rewired.HID;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.HID.Drivers
{
	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	internal abstract class HIDDeviceDriver : IDisposable, IControllerDriver // TypeDefIndex: 6405
	{
		// Fields
		public HIDAxis[] axes; // 0x10
		public HIDButton[] buttons; // 0x18
		public HIDHat[] hats; // 0x20
		public HIDAccelerometer[] accelerometers; // 0x28
		public HIDGyroscope[] gyroscopes; // 0x30
		public HIDTouchpad[] touchpads; // 0x38
		public HIDVibrationMotor[] vibrationMotors; // 0x40
		public HIDLight[] lights; // 0x48
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x50
	
		// Properties
		public int AxisCount { get; } // 0x0000000180395190-0x00000001803951A0 
		public int ButtonCount { get; } // 0x00000001803951A0-0x00000001803951B0 
		public int HatCount { get; } // 0x0000000180619B20-0x0000000180619B30 
		public int AccelerometerCount { get; } // 0x0000000180619B10-0x0000000180619B20 
		public int GyroscopeCount { get; } // 0x000000018039A130-0x000000018039A140 
		public int TouchpadCount { get; } // 0x0000000180397580-0x0000000180397590 
		public int LightCount { get; } // 0x0000000180619B30-0x0000000180619B40 
		public int VibrationMotorCount { get; } // 0x0000000180619B40-0x0000000180619B50 
		protected bool disposed { get; } // 0x0000000180619B50-0x0000000180619B60 
	
		// Nested types
		[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
		[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
		internal class InitArgs // TypeDefIndex: 6406
		{
			// Fields
			public UpdateLoopSetting updateLoopSetting; // 0x10
			public DeviceConnectionType connectionType; // 0x14
			public int minAxisValue; // 0x18
			public int maxAxisValue; // 0x1C
			public int hatZeroValue; // 0x20
			public int hatSpan; // 0x24
			public int inputReportLength; // 0x28
			public int outputReportLength; // 0x2C
			public Func<OutputReport, bool> synchronousWriteOutputReportDelegate; // 0x30
			public Action<OutputReport> asynchronousWriteOutputReportDelegate; // 0x38
	
			// Constructors
			public InitArgs(UpdateLoopSetting updateLoopSetting, DeviceConnectionType connectionType, int minAxisValue, int maxAxisValue, int hatZeroValue, int hatSpan, int inputReportLength, int outputReportLength, Func<OutputReport, bool> synchronousWriteOutputReportDelegate, Action<OutputReport> asynchronousWriteOutputReportDelegate); // 0x000000018061ED90-0x000000018061EE90
		}
	
		// Constructors
		public HIDDeviceDriver(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public abstract void Update(UpdateLoopType updateLoop);
		public abstract bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, float timestamp);
		public abstract Controller.Extension CreateControllerExtension();
		public static HIDDeviceDriver GetDriver(int driverId, InitArgs hidDriverInitArgs); // 0x0000000180619A10-0x0000000180619B10
		public static int FindDriverId(int vendorId, int productId); // 0x00000001806199C0-0x0000000180619A10
		public void Dispose(); // 0x00000001806198A0-0x0000000180619910
		~HIDDeviceDriver(); // 0x0000000180619920-0x00000001806199C0
		protected virtual void Dispose(bool disposing); // 0x0000000180619910-0x0000000180619920
	}
}

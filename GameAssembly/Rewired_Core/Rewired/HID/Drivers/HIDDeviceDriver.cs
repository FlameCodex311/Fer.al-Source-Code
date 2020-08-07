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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.HID.Drivers
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal abstract class HIDDeviceDriver : IDisposable, IControllerDriver // TypeDefIndex: 6564
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
		public int AxisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
		public int ButtonCount { get; } // 0x00000001805EF540-0x00000001805EF550 
		public int HatCount { get; } // 0x0000000180E5DA10-0x0000000180E5DA20 
		public int AccelerometerCount { get; } // 0x0000000180E5DA00-0x0000000180E5DA10 
		public int GyroscopeCount { get; } // 0x00000001805F42F0-0x00000001805F4300 
		public int TouchpadCount { get; } // 0x00000001805F1850-0x00000001805F1860 
		public int LightCount { get; } // 0x0000000180E5DA20-0x0000000180E5DA30 
		public int VibrationMotorCount { get; } // 0x0000000180E5DA30-0x0000000180E5DA40 
		protected bool disposed { get; } // 0x0000000180379EC0-0x0000000180379ED0 
	
		// Nested types
		[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		internal class InitArgs // TypeDefIndex: 6565
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
			public InitArgs(UpdateLoopSetting updateLoopSetting, DeviceConnectionType connectionType, int minAxisValue, int maxAxisValue, int hatZeroValue, int hatSpan, int inputReportLength, int outputReportLength, Func<OutputReport, bool> synchronousWriteOutputReportDelegate, Action<OutputReport> asynchronousWriteOutputReportDelegate); // 0x0000000180E62A70-0x0000000180E62B70
		}
	
		// Constructors
		public HIDDeviceDriver(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public abstract void Update(UpdateLoopType updateLoop);
		public abstract bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, float timestamp);
		public abstract Controller.Extension CreateControllerExtension();
		public static HIDDeviceDriver GetDriver(int driverId, InitArgs hidDriverInitArgs); // 0x0000000180E5D900-0x0000000180E5DA00
		public static int FindDriverId(int vendorId, int productId); // 0x0000000180E5D8B0-0x0000000180E5D900
		public void Dispose(); // 0x0000000180E5D790-0x0000000180E5D800
		~HIDDeviceDriver(); // 0x0000000180E5D810-0x0000000180E5D8B0
		protected virtual void Dispose(bool disposing); // 0x0000000180E5D800-0x0000000180E5D810
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Platforms.Custom
{
	public abstract class CustomInputSource : IDisposable // TypeDefIndex: 6179
	{
		// Fields
		private readonly InputSource RwhgOOAwEVeabPZQdQPAoyiygdKN; // 0x10
		private readonly List<Joystick> UHVUQTqVgIBHblFxLAYzBdaFQh; // 0x18
		private readonly ReadOnlyCollection<Joystick> nKwZCYrUQaGoXWnUWmHNrSYftMA; // 0x20
		private bool bXFQDHjZhBmDzpILPGsxNUpEbbQJ; // 0x28
		private Action QstPIVnMnMgMpgUsSHpIWRGOoMK; // 0x30
		private Action vYeVUjeOjLfYPnIvVncGdTvXaQm; // 0x38
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x40
	
		// Properties
		public bool useApproximateMatching { get; protected set; } // 0x00000001804C6790-0x00000001804C67A0 0x00000001804D9980-0x00000001804D9990
		internal InputSource inputSource { get; } // 0x0000000180387590-0x0000000180387930 
		public abstract bool isReady { get; }
	
		// Events
		private event Action _JoystickConnectedEvent {
			add; // 0x0000000180E9ECA0-0x0000000180E9ED60
			remove; // 0x0000000180E9EE40-0x0000000180E9EF00
		}
		private event Action _JoystickDisconnectedEvent {
			add; // 0x0000000180E9ED60-0x0000000180E9EE40
			remove; // 0x0000000180E9EF00-0x0000000180E9EFC0
		}
		internal event Action JoystickConnectedEvent {
			add; // 0x0000000180E9ECA0-0x0000000180E9ED60
			remove; // 0x0000000180E9EE40-0x0000000180E9EF00
		}
		internal event Action JoystickDisconnectedEvent {
			add; // 0x0000000180E9ED60-0x0000000180E9EE40
			remove; // 0x0000000180E9EF00-0x0000000180E9EFC0
		}
	
		// Nested types
		public abstract class Controller // TypeDefIndex: 6180
		{
			// Fields
			protected bool _isConnected; // 0x10
			protected string _deviceName; // 0x18
			protected string _customName; // 0x20
	
			// Properties
			public string customName { get; } // 0x0000000180374AF0-0x0000000180374B00 
			public bool isConnected { get; set; } // 0x00000001803FD450-0x00000001803FD460 0x0000000180E9E870-0x0000000180E9E880
			public string deviceName { get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			protected Controller(string deviceName); // 0x000000018056B4B0-0x000000018056B4E0
	
			// Methods
			public void Disconnect(); // 0x0000000180E9E860-0x0000000180E9E870
			public void Connect(); // 0x0000000180E9E850-0x0000000180E9E860
			public abstract void Update();
		}
	
		public abstract class Joystick : Controller // TypeDefIndex: 6181
		{
			// Fields
			private long? ZtpFOHCSvVTitFWYQVgBoObqQOKf; // 0x28
			private int QqpCMJrIsoyyefcScyWUdCeTfPn; // 0x38
			private readonly Axis[] BqSdtKydcIEkoWCjLJvCiEzwQMG; // 0x40
			private readonly Button[] fjFgJnkphrVLUzcZIWNBokLGbBNJ; // 0x48
			private readonly ReadOnlyCollection<Axis> HgnDXeeXjaKmhoSMUMJYfFspyCX; // 0x50
			private readonly ReadOnlyCollection<Button> QuTkLcsJfPxBFSRuDfxUaqsjZOb; // 0x58
			private bool bxYnOIxNeRaXtbzEetOhxJbUfsRC; // 0x60
			private Controller.Extension ZXidIbsBtOYiKGegrccafjeNbYN; // 0x68
	
			// Properties
			public long? systemId { get; protected set; } // 0x0000000180379E90-0x0000000180379EA0 0x000000018041B740-0x000000018041B750
			public int unityId { get; protected set; } // 0x000000018057D1C0-0x000000018057D1D0 0x000000018041B190-0x000000018041B1A0
			public IList<Axis> Axes { get; } // 0x0000000180378320-0x0000000180378330 
			public IList<Button> Buttons { get; } // 0x00000001803A1580-0x00000001803A1590 
			public bool supportsVibration { get; set; } // 0x00000001803CE080-0x00000001803CE090 0x000000018045A0C0-0x000000018045A0D0
			public Controller.Extension extension { get; set; } // 0x00000001803765E0-0x00000001803765F0 0x00000001804ADAC0-0x00000001804ADAD0
			public int buttonCount { get; } // 0x0000000180EA29C0-0x0000000180EA29E0 
			public int axisCount { get; } // 0x0000000180EA29A0-0x0000000180EA29C0 
	
			// Constructors
			public Joystick(string deviceName, long? systemId, int unityId, int axisCount, int buttonCount); // 0x0000000180EA20F0-0x0000000180EA2320
	
			// Methods
			public virtual float GetAxisValue(int index); // 0x0000000180E9FAC0-0x0000000180E9FB30
			public virtual bool GetButtonValue(int index); // 0x0000000180E9FB30-0x0000000180E9FB90
		}
	
		public abstract class Element // TypeDefIndex: 6182
		{
			// Constructors
			protected Element(); // 0x0000000180373240-0x0000000180373250
		}
	
		public sealed class Axis : Element // TypeDefIndex: 6183
		{
			// Fields
			public float value; // 0x10
	
			// Constructors
			public Axis(); // 0x0000000180373240-0x0000000180373250
		}
	
		public sealed class Button : Element // TypeDefIndex: 6184
		{
			// Fields
			public bool value; // 0x10
	
			// Constructors
			public Button(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Constructors
		public CustomInputSource(int inputSource); // 0x0000000180E9EB30-0x0000000180E9ECA0
	
		// Methods
		public void AddJoystick(Joystick joystick); // 0x0000000180E9E880-0x0000000180E9E940
		public void RemoveJoystick(Joystick joystick); // 0x0000000180E9EA60-0x0000000180E9EB30
		public IList<Joystick> GetJoysticks(); // 0x0000000180374AF0-0x0000000180374B00
		protected virtual void OnJoystickConnected(); // 0x00000001804D7B40-0x00000001804D7B60
		protected virtual void OnJoystickDisconnected(); // 0x0000000180CD2E60-0x0000000180CD2E80
		internal Joystick[] sYJxMVfMrKvJHvANnWrwXwBXTZG(); // 0x0000000180E9EFC0-0x0000000180E9F170
		public virtual void Dispose(); // 0x0000000180E9E940-0x0000000180E9E9B0
		~CustomInputSource(); // 0x0000000180E9E9C0-0x0000000180E9EA60
		protected virtual void Dispose(bool disposing); // 0x0000000180E9E9B0-0x0000000180E9E9C0
		public abstract void Update();
	}
}

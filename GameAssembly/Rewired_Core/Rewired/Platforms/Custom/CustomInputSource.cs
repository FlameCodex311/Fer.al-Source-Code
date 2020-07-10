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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Platforms.Custom
{
	public abstract class CustomInputSource : IDisposable // TypeDefIndex: 6020
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
		public bool useApproximateMatching { get; protected set; } // 0x00000001803A2790-0x00000001803A27A0 0x00000001803A2840-0x00000001803A2850
		internal InputSource inputSource { get; } // 0x000000018036CFF0-0x000000018036D000 
		public abstract bool isReady { get; }
	
		// Events
		private event Action _JoystickConnectedEvent {
			add; // 0x00000001806270F0-0x00000001806271B0
			remove; // 0x0000000180627290-0x0000000180627350
		}
		private event Action _JoystickDisconnectedEvent {
			add; // 0x00000001806271B0-0x0000000180627290
			remove; // 0x0000000180627350-0x0000000180627410
		}
		internal event Action JoystickConnectedEvent {
			add; // 0x00000001806270F0-0x00000001806271B0
			remove; // 0x0000000180627290-0x0000000180627350
		}
		internal event Action JoystickDisconnectedEvent {
			add; // 0x00000001806271B0-0x0000000180627290
			remove; // 0x0000000180627350-0x0000000180627410
		}
	
		// Nested types
		public abstract class Controller // TypeDefIndex: 6021
		{
			// Fields
			protected bool _isConnected; // 0x10
			protected string _deviceName; // 0x18
			protected string _customName; // 0x20
	
			// Properties
			public string customName { get; } // 0x000000018036AC70-0x000000018036AC80 
			public bool isConnected { get; set; } // 0x0000000180375540-0x0000000180375550 0x0000000180626C70-0x0000000180626C80
			public string deviceName { get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			protected Controller(string deviceName); // 0x0000000180626C40-0x0000000180626C70
	
			// Methods
			public void Disconnect(); // 0x0000000180626C30-0x0000000180626C40
			public void Connect(); // 0x0000000180626C20-0x0000000180626C30
			public abstract void Update();
		}
	
		public abstract class Joystick : Controller // TypeDefIndex: 6022
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
			public long? systemId { get; protected set; } // 0x000000018036CB50-0x000000018036CB60 0x000000018036CC20-0x000000018036CC30
			public int unityId { get; protected set; } // 0x00000001804999D0-0x00000001804999E0 0x000000018036C620-0x000000018036C630
			public IList<Axis> Axes { get; } // 0x00000001803A27A0-0x00000001803A27B0 
			public IList<Button> Buttons { get; } // 0x0000000180357120-0x0000000180357130 
			public bool supportsVibration { get; set; } // 0x00000001804785B0-0x00000001804785C0 0x000000018062BA40-0x000000018062BA50
			public Controller.Extension extension { get; set; } // 0x0000000180358970-0x0000000180358980 0x00000001803A27D0-0x00000001803A27E0
			public int buttonCount { get; } // 0x000000018062AEE0-0x000000018062AF00 
			public int axisCount { get; } // 0x000000018062AEC0-0x000000018062AEE0 
	
			// Constructors
			public Joystick(string deviceName, long? systemId, int unityId, int axisCount, int buttonCount); // 0x000000018062A5D0-0x000000018062A810
	
			// Methods
			public virtual float GetAxisValue(int index); // 0x0000000180627F10-0x0000000180627F80
			public virtual bool GetButtonValue(int index); // 0x0000000180627F80-0x0000000180627FF0
		}
	
		public abstract class Element // TypeDefIndex: 6023
		{
			// Constructors
			protected Element(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		public sealed class Axis : Element // TypeDefIndex: 6024
		{
			// Fields
			public float value; // 0x10
	
			// Constructors
			public Axis(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		public sealed class Button : Element // TypeDefIndex: 6025
		{
			// Fields
			public bool value; // 0x10
	
			// Constructors
			public Button(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		// Constructors
		public CustomInputSource(int inputSource); // 0x0000000180626F80-0x00000001806270F0
	
		// Methods
		public void AddJoystick(Joystick joystick); // 0x0000000180626C80-0x0000000180626D40
		public void RemoveJoystick(Joystick joystick); // 0x0000000180626EA0-0x0000000180626F80
		public IList<Joystick> GetJoysticks(); // 0x000000018036AC70-0x000000018036AC80
		protected virtual void OnJoystickConnected(); // 0x0000000180626E60-0x0000000180626E80
		protected virtual void OnJoystickDisconnected(); // 0x0000000180626E80-0x0000000180626EA0
		internal Joystick[] sYJxMVfMrKvJHvANnWrwXwBXTZG(); // 0x0000000180627410-0x00000001806275C0
		public virtual void Dispose(); // 0x0000000180626D40-0x0000000180626DB0
		~CustomInputSource(); // 0x0000000180626DC0-0x0000000180626E60
		protected virtual void Dispose(bool disposing); // 0x0000000180626DB0-0x0000000180626DC0
		public abstract void Update();
	}
}

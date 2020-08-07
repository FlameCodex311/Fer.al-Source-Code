/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public abstract class ControllerWithAxes : ControllerWithMap // TypeDefIndex: 6068
	{
		// Fields
		protected readonly int _axisCount; // 0x100
		protected readonly int _axis2DCount; // 0x104
		protected readonly Axis[] axes; // 0x108
		protected readonly ReadOnlyCollection<Axis> axes_readOnly; // 0x110
		protected readonly Axis2D[] axes2D; // 0x118
		protected readonly ReadOnlyCollection<Axis2D> axes2D_readOnly; // 0x120
		protected CalibrationMap _calibrationMap; // 0x128
		private float[] gcUIqYzphGzXesYISQtMAneCyQL; // 0x130
		private uint PseRHBIlRcUNTLqiVuKUiknWMPT; // 0x138
		private Func<int, int> EotiliTrgdUTSJkOZdzwhNzvaUiG; // 0x140
	
		// Properties
		public int axisCount { get; } // 0x000000018154BB30-0x000000018154BBD0 
		public int axis2DCount { get; } // 0x000000018154BA90-0x000000018154BB30 
		public IList<Axis> Axes { get; } // 0x000000018154B920-0x000000018154B9D0 
		public IList<Axis2D> Axes2D { get; } // 0x000000018154B870-0x000000018154B920 
		public CalibrationMap calibrationMap { get; } // 0x000000018154BBD0-0x000000018154BC80 
		public IList<ControllerElementIdentifier> AxisElementIdentifiers { get; } // 0x000000018154B9D0-0x000000018154BA90 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class wBSfXSetyKnkKevTCKCwJhUHxyK : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6069
		{
			// Fields
			private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
			public ControllerWithAxes gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
			public ControllerPollingInfo eVWiQkUidoghskOROefZSoZbByIn; // 0x58
			public ControllerPollingInfo iEmEgIbiWHiuMUOJzTbGvvvfOyTx; // 0x90
			public IEnumerator<ControllerPollingInfo> IFjqIuMXDNRyWIScPohuqJVYAOP; // 0xC8
			public IEnumerator<ControllerPollingInfo> ffCrvtMpQXqCenVVUEbFRBzZHhc; // 0xD0
	
			// Properties
			ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000181558A60-0x0000000181558AD0 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public wBSfXSetyKnkKevTCKCwJhUHxyK(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001815588E0-0x0000000181558A10
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001815588E0-0x0000000181558A10
			private bool MoveNext(); // 0x00000001815584B0-0x00000001815588E0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181558A10-0x0000000181558A60
			void IDisposable.Dispose(); // 0x0000000181558AD0-0x0000000181558C20
			private void ISxlGoNrohaTYGNdnYJULBjdBYA(); // 0x0000000181558410-0x0000000181558460
			private void KjDPrbOXKqcCztaVQXoVAHXVeJi(); // 0x0000000181558460-0x00000001815584B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class BIBhjIcIIcFHXhYMhaKUTfLVTQRS : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6070
		{
			// Fields
			private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
			public ControllerWithAxes gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
			public ControllerPollingInfo CcSppCTofQdEEIROOHmEQrNsaHk; // 0x58
			public ControllerPollingInfo bYGhVrNceCDcnJBTEUdbNdKbJjvB; // 0x90
			public IEnumerator<ControllerPollingInfo> xNdvDSqXttGZLBGrHHAmDiSXBJA; // 0xC8
			public IEnumerator<ControllerPollingInfo> oQmNDLfDupdprISzaCFjyxpPezJQ; // 0xD0
	
			// Properties
			ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x000000018153C2F0-0x000000018153C360 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public BIBhjIcIIcFHXhYMhaKUTfLVTQRS(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018153C190-0x000000018153C2A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018153C190-0x000000018153C2A0
			private bool MoveNext(); // 0x000000018153BD50-0x000000018153C190
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018153C2A0-0x000000018153C2F0
			void IDisposable.Dispose(); // 0x000000018153C360-0x000000018153C4A0
			private void zfEOugiqmCWgPcwmlPqiEQqAtOi(); // 0x000000018153C4F0-0x000000018153C610
			private void TtIbqtBwfORqCZOIrghuXSQuchIa(); // 0x000000018153C4A0-0x000000018153C4F0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class AAjSUOuZhJSauIgEGaGrzMfuGze : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6071
		{
			// Fields
			private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
			public ControllerWithAxes gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
			public int GislVEIIWhvuFIBvluQVCtNFtAT; // 0x58
			public Pole JwOTnJylSCdrgdlAKmOHfuUdoxbC; // 0x5C
			public int ZeQJPxLXfmRSPnIgumXcsqYKKus; // 0x60
	
			// Properties
			ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x000000018153BC70-0x000000018153BCE0 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public AAjSUOuZhJSauIgEGaGrzMfuGze(int <>1__state); // 0x000000018153BCE0-0x000000018153BD50
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018153BAF0-0x000000018153BC20
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018153BAF0-0x000000018153BC20
			private bool MoveNext(); // 0x000000018153B780-0x000000018153BAF0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018153BC20-0x000000018153BC70
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		// Constructors
		internal ControllerWithAxes(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, ControllerType type, Guid hardwareTypeGuid, int axisCount, int buttonCount, bool[] isButtonPressureSensitive, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater); // 0x000000018154B020-0x000000018154B870
	
		// Methods
		public override Element GetElementById(int elementIdentifierId); // 0x00000001815490A0-0x0000000181549220
		public int GetAxisIndexById(int elementIdentifierId); // 0x0000000181547510-0x0000000181547600
		public float GetAxis(int index); // 0x0000000181548FA0-0x00000001815490A0
		public float GetAxisPrev(int index); // 0x0000000181547BC0-0x0000000181547CF0
		public float GetAxisRaw(int index); // 0x00000001815489D0-0x0000000181548B00
		public float GetAxisRawPrev(int index); // 0x00000001815483A0-0x00000001815484C0
		public float GetAxisTimeActive(int index); // 0x0000000181548C20-0x0000000181548D20
		public float GetAxisTimeInactive(int index); // 0x0000000181548E80-0x0000000181548FA0
		public float GetAxisLastTimeActive(int index); // 0x0000000181547760-0x0000000181547860
		public float GetAxisLastTimeInactive(int index); // 0x0000000181547980-0x0000000181547A80
		public float GetAxisRawTimeActive(int index); // 0x0000000181548600-0x0000000181548720
		public float GetAxisRawTimeInactive(int index); // 0x00000001815488A0-0x00000001815489D0
		public float GetAxisRawLastTimeActive(int index); // 0x0000000181547F30-0x0000000181548030
		public float GetAxisRawLastTimeInactive(int index); // 0x0000000181548180-0x0000000181548280
		public float GetAxisById(int elementIdentifierId); // 0x00000001815473F0-0x0000000181547510
		public float GetAxisPrevById(int elementIdentifierId); // 0x0000000181547A80-0x0000000181547BC0
		public float GetAxisRawById(int elementIdentifierId); // 0x0000000181547CF0-0x0000000181547E10
		public float GetAxisRawPrevById(int elementIdentifierId); // 0x0000000181548280-0x00000001815483A0
		public float GetAxisTimeActiveById(int elementIdentifierId); // 0x0000000181548B00-0x0000000181548C20
		public float GetAxisTimeInactiveById(int elementIdentifierId); // 0x0000000181548D20-0x0000000181548E80
		public float GetAxisLastTimeActiveById(int elementIdentifierId); // 0x0000000181547600-0x0000000181547760
		public float GetAxisLastTimeInactiveById(int elementIdentifierId); // 0x0000000181547860-0x0000000181547980
		public float GetAxisRawTimeActiveById(int elementIdentifierId); // 0x00000001815484C0-0x0000000181548600
		public float GetAxisRawTimeInactiveById(int elementIdentifierId); // 0x0000000181548720-0x00000001815488A0
		public float GetAxisRawLastTimeActiveById(int elementIdentifierId); // 0x0000000181547E10-0x0000000181547F30
		public float GetAxisRawLastTimeInactiveById(int elementIdentifierId); // 0x0000000181548030-0x0000000181548180
		public Vector2 GetAxis2D(int index); // 0x00000001815472A0-0x00000001815473F0
		public Vector2 GetAxis2DPrev(int index); // 0x0000000181546EB0-0x0000000181547000
		public Vector2 GetAxis2DRaw(int index); // 0x0000000181547150-0x00000001815472A0
		public Vector2 GetAxis2DRawPrev(int index); // 0x0000000181547000-0x0000000181547150
		public override float GetLastTimeActive(); // 0x0000000181549310-0x00000001815493C0
		public override float GetLastTimeActive(bool useRawValues); // 0x0000000181549220-0x0000000181549310
		public override float GetLastTimeAnyElementChanged(); // 0x00000001815497F0-0x0000000181549810
		public override float GetLastTimeAnyElementChanged(bool useRawValues); // 0x0000000181549810-0x0000000181549900
		public float GetLastTimeAnyAxisActive(); // 0x00000001815495D0-0x00000001815495E0
		public float GetLastTimeAnyAxisActive(bool useRawValues); // 0x00000001815493C0-0x00000001815495D0
		public float GetLastTimeAnyAxisChanged(); // 0x00000001815495E0-0x00000001815495F0
		public float GetLastTimeAnyAxisChanged(bool useRawValues); // 0x00000001815495F0-0x00000001815497F0
		public override ControllerPollingInfo PollForFirstElement(); // 0x000000018154A3C0-0x000000018154A530
		public override ControllerPollingInfo PollForFirstElementDown(); // 0x000000018154A2C0-0x000000018154A3C0
		public ControllerPollingInfo PollForFirstAxis(); // 0x000000018154A040-0x000000018154A2C0
		public override IEnumerable<ControllerPollingInfo> PollForAllElements(); // 0x0000000181549FC0-0x000000018154A040
		public override IEnumerable<ControllerPollingInfo> PollForAllElementsDown(); // 0x0000000181549F40-0x0000000181549FC0
		public IEnumerable<ControllerPollingInfo> PollForAllAxes(); // 0x0000000181549EA0-0x0000000181549F40
		private void FWfIShfTbcuUKciiAtgjxfVNQmh(); // 0x0000000181546C50-0x0000000181546EB0
		protected virtual bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId); // 0x0000000181549B80-0x0000000181549EA0
		public bool ImportCalibrationMapFromXmlString(string xmlString); // 0x0000000181549A40-0x0000000181549B80
		public bool ImportCalibrationMapFromJsonString(string jsonString); // 0x0000000181549900-0x0000000181549A40
		internal override void UpdateData(UpdateLoopType param_0000cc03); // 0x000000018154A530-0x000000018154ABE0
		internal bool ZCwSgWICOtGrttGFfncnGpDlgEa(ActionElementMap param_0000cc04, int param_0000cc05, bool param_0000cc06, bool param_0000cc07, out float param_0000cc08); // 0x000000018154ABE0-0x000000018154B020
		internal override void BakeMap(ControllerMap param_0000cc09); // 0x0000000181546980-0x0000000181546B50
		internal override void BakeActionElementMap(ControllerMap param_0000cc0a, ActionElementMap param_0000cc0b); // 0x0000000181546940-0x0000000181546980
		internal void zqYZancoLvjwyJrtvfMQBRgBvCOJ(); // 0x000000018154BCA0-0x000000018154BF60
		internal override void Clear(); // 0x0000000181546B50-0x0000000181546C50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IEnumerable<ControllerPollingInfo> tfjkAeqeyeISOpYFEFSfmAcEdOcE(); // 0x000000018154BC90-0x000000018154BCA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IEnumerable<ControllerPollingInfo> mUZbNIaWJplRJrsbIEGGxbMeJSw(); // 0x000000018154BC80-0x000000018154BC90
	}
}

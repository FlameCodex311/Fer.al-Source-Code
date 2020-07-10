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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public abstract class ControllerWithAxes : ControllerWithMap // TypeDefIndex: 5909
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
		public int axisCount { get; } // 0x0000000180A96A60-0x0000000180A96B00 
		public int axis2DCount { get; } // 0x0000000180A969C0-0x0000000180A96A60 
		public IList<Axis> Axes { get; } // 0x0000000180A96850-0x0000000180A96900 
		public IList<Axis2D> Axes2D { get; } // 0x0000000180A967A0-0x0000000180A96850 
		public CalibrationMap calibrationMap { get; } // 0x0000000180A96B00-0x0000000180A96BB0 
		public IList<ControllerElementIdentifier> AxisElementIdentifiers { get; } // 0x0000000180A96900-0x0000000180A969C0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class wBSfXSetyKnkKevTCKCwJhUHxyK : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 5910
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
			ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180AA3EE0-0x0000000180AA3F50 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public wBSfXSetyKnkKevTCKCwJhUHxyK(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180AA3D60-0x0000000180AA3E90
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180AA3D60-0x0000000180AA3E90
			private bool MoveNext(); // 0x0000000180AA3920-0x0000000180AA3D60
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180AA3E90-0x0000000180AA3EE0
			void IDisposable.Dispose(); // 0x0000000180AA3F50-0x0000000180AA40B0
			private void ISxlGoNrohaTYGNdnYJULBjdBYA(); // 0x0000000180AA3880-0x0000000180AA38D0
			private void KjDPrbOXKqcCztaVQXoVAHXVeJi(); // 0x0000000180AA38D0-0x0000000180AA3920
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class BIBhjIcIIcFHXhYMhaKUTfLVTQRS : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 5911
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
			ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180A86E80-0x0000000180A86EF0 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public BIBhjIcIIcFHXhYMhaKUTfLVTQRS(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180A86D10-0x0000000180A86E30
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180A86D10-0x0000000180A86E30
			private bool MoveNext(); // 0x0000000180A868C0-0x0000000180A86D10
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180A86E30-0x0000000180A86E80
			void IDisposable.Dispose(); // 0x0000000180A86EF0-0x0000000180A87030
			private void zfEOugiqmCWgPcwmlPqiEQqAtOi(); // 0x0000000180A87080-0x0000000180A871A0
			private void TtIbqtBwfORqCZOIrghuXSQuchIa(); // 0x0000000180A87030-0x0000000180A87080
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class AAjSUOuZhJSauIgEGaGrzMfuGze : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 5912
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
			ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180A867E0-0x0000000180A86850 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public AAjSUOuZhJSauIgEGaGrzMfuGze(int <>1__state); // 0x0000000180A86850-0x0000000180A868C0
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180A86650-0x0000000180A86790
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180A86650-0x0000000180A86790
			private bool MoveNext(); // 0x0000000180A862E0-0x0000000180A86650
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180A86790-0x0000000180A867E0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		// Constructors
		internal ControllerWithAxes(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, ControllerType type, Guid hardwareTypeGuid, int axisCount, int buttonCount, bool[] isButtonPressureSensitive, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater); // 0x0000000180A95F10-0x0000000180A967A0
	
		// Methods
		public override Element GetElementById(int elementIdentifierId); // 0x0000000180A93F00-0x0000000180A94090
		public int GetAxisIndexById(int elementIdentifierId); // 0x0000000180A92330-0x0000000180A92420
		public float GetAxis(int index); // 0x0000000180A93E00-0x0000000180A93F00
		public float GetAxisPrev(int index); // 0x0000000180A929F0-0x0000000180A92B30
		public float GetAxisRaw(int index); // 0x0000000180A93820-0x0000000180A93950
		public float GetAxisRawPrev(int index); // 0x0000000180A931E0-0x0000000180A93300
		public float GetAxisTimeActive(int index); // 0x0000000180A93A70-0x0000000180A93B70
		public float GetAxisTimeInactive(int index); // 0x0000000180A93CE0-0x0000000180A93E00
		public float GetAxisLastTimeActive(int index); // 0x0000000180A92590-0x0000000180A92690
		public float GetAxisLastTimeInactive(int index); // 0x0000000180A927B0-0x0000000180A928B0
		public float GetAxisRawTimeActive(int index); // 0x0000000180A93440-0x0000000180A93560
		public float GetAxisRawTimeInactive(int index); // 0x0000000180A936F0-0x0000000180A93820
		public float GetAxisRawLastTimeActive(int index); // 0x0000000180A92D70-0x0000000180A92E70
		public float GetAxisRawLastTimeInactive(int index); // 0x0000000180A92FC0-0x0000000180A930C0
		public float GetAxisById(int elementIdentifierId); // 0x0000000180A92210-0x0000000180A92330
		public float GetAxisPrevById(int elementIdentifierId); // 0x0000000180A928B0-0x0000000180A929F0
		public float GetAxisRawById(int elementIdentifierId); // 0x0000000180A92B30-0x0000000180A92C50
		public float GetAxisRawPrevById(int elementIdentifierId); // 0x0000000180A930C0-0x0000000180A931E0
		public float GetAxisTimeActiveById(int elementIdentifierId); // 0x0000000180A93950-0x0000000180A93A70
		public float GetAxisTimeInactiveById(int elementIdentifierId); // 0x0000000180A93B70-0x0000000180A93CE0
		public float GetAxisLastTimeActiveById(int elementIdentifierId); // 0x0000000180A92420-0x0000000180A92590
		public float GetAxisLastTimeInactiveById(int elementIdentifierId); // 0x0000000180A92690-0x0000000180A927B0
		public float GetAxisRawTimeActiveById(int elementIdentifierId); // 0x0000000180A93300-0x0000000180A93440
		public float GetAxisRawTimeInactiveById(int elementIdentifierId); // 0x0000000180A93560-0x0000000180A936F0
		public float GetAxisRawLastTimeActiveById(int elementIdentifierId); // 0x0000000180A92C50-0x0000000180A92D70
		public float GetAxisRawLastTimeInactiveById(int elementIdentifierId); // 0x0000000180A92E70-0x0000000180A92FC0
		public Vector2 GetAxis2D(int index); // 0x0000000180A920B0-0x0000000180A92210
		public Vector2 GetAxis2DPrev(int index); // 0x0000000180A91CC0-0x0000000180A91E10
		public Vector2 GetAxis2DRaw(int index); // 0x0000000180A91F60-0x0000000180A920B0
		public Vector2 GetAxis2DRawPrev(int index); // 0x0000000180A91E10-0x0000000180A91F60
		public override float GetLastTimeActive(); // 0x0000000180A94180-0x0000000180A94230
		public override float GetLastTimeActive(bool useRawValues); // 0x0000000180A94090-0x0000000180A94180
		public override float GetLastTimeAnyElementChanged(); // 0x0000000180A94680-0x0000000180A946A0
		public override float GetLastTimeAnyElementChanged(bool useRawValues); // 0x0000000180A946A0-0x0000000180A94790
		public float GetLastTimeAnyAxisActive(); // 0x0000000180A94450-0x0000000180A94460
		public float GetLastTimeAnyAxisActive(bool useRawValues); // 0x0000000180A94230-0x0000000180A94450
		public float GetLastTimeAnyAxisChanged(); // 0x0000000180A94460-0x0000000180A94470
		public float GetLastTimeAnyAxisChanged(bool useRawValues); // 0x0000000180A94470-0x0000000180A94680
		public override ControllerPollingInfo PollForFirstElement(); // 0x0000000180A95270-0x0000000180A953E0
		public override ControllerPollingInfo PollForFirstElementDown(); // 0x0000000180A95170-0x0000000180A95270
		public ControllerPollingInfo PollForFirstAxis(); // 0x0000000180A94EF0-0x0000000180A95170
		public override IEnumerable<ControllerPollingInfo> PollForAllElements(); // 0x0000000180A94E70-0x0000000180A94EF0
		public override IEnumerable<ControllerPollingInfo> PollForAllElementsDown(); // 0x0000000180A94DF0-0x0000000180A94E70
		public IEnumerable<ControllerPollingInfo> PollForAllAxes(); // 0x0000000180A94D40-0x0000000180A94DF0
		private void FWfIShfTbcuUKciiAtgjxfVNQmh(); // 0x0000000180A91A50-0x0000000180A91CC0
		protected virtual bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId); // 0x0000000180A94A10-0x0000000180A94D40
		public bool ImportCalibrationMapFromXmlString(string xmlString); // 0x0000000180A948D0-0x0000000180A94A10
		public bool ImportCalibrationMapFromJsonString(string jsonString); // 0x0000000180A94790-0x0000000180A948D0
		internal override void UpdateData(UpdateLoopType param_0000c993); // 0x0000000180A953E0-0x0000000180A95AC0
		internal bool ZCwSgWICOtGrttGFfncnGpDlgEa(ActionElementMap param_0000c994, int param_0000c995, bool param_0000c996, bool param_0000c997, out float param_0000c998); // 0x0000000180A95AC0-0x0000000180A95F10
		internal override void BakeMap(ControllerMap param_0000c999); // 0x0000000180A91770-0x0000000180A91940
		internal override void BakeActionElementMap(ControllerMap param_0000c99a, ActionElementMap param_0000c99b); // 0x0000000180A91730-0x0000000180A91770
		internal void zqYZancoLvjwyJrtvfMQBRgBvCOJ(); // 0x0000000180A96BD0-0x0000000180A96EA0
		internal override void Clear(); // 0x0000000180A91940-0x0000000180A91A50
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IEnumerable<ControllerPollingInfo> tfjkAeqeyeISOpYFEFSfmAcEdOcE(); // 0x0000000180A96BC0-0x0000000180A96BD0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IEnumerable<ControllerPollingInfo> mUZbNIaWJplRJrsbIEGGxbMeJSw(); // 0x0000000180A96BB0-0x0000000180A96BC0
	}
}

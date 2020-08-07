/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using Rewired.Utils.Attributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x0000000180211240-0x00000001802112A0
	[RequireComponent] // 0x0000000180211240-0x00000001802112A0
	public sealed class TouchPad : TouchInteractable, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 6014
	{
		// Fields
		private const int SMOOTH_DELTA_FRAME_COUNT = 3; // Metadata: 0x00763995
		[CustomObfuscation] // 0x00000001802114C0-0x0000000180211520
		[SerializeField] // 0x00000001802114C0-0x0000000180211520
		[Tooltip] // 0x00000001802114C0-0x0000000180211520
		private CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement; // 0x128
		[CustomObfuscation] // 0x00000001802117D0-0x0000000180211830
		[SerializeField] // 0x00000001802117D0-0x0000000180211830
		[Tooltip] // 0x00000001802117D0-0x0000000180211830
		private CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement; // 0x130
		[CustomObfuscation] // 0x0000000180211A10-0x0000000180211A70
		[SerializeField] // 0x0000000180211A10-0x0000000180211A70
		[Tooltip] // 0x0000000180211A10-0x0000000180211A70
		private CustomControllerElementTargetSetForBoolean _tapCustomControllerElement; // 0x138
		[CustomObfuscation] // 0x0000000180212F90-0x0000000180212FF0
		[SerializeField] // 0x0000000180212F90-0x0000000180212FF0
		[Tooltip] // 0x0000000180212F90-0x0000000180212FF0
		private CustomControllerElementTargetSetForBoolean _pressCustomControllerElement; // 0x140
		[CustomObfuscation] // 0x00000001802132F0-0x0000000180213350
		[SerializeField] // 0x00000001802132F0-0x0000000180213350
		[Tooltip] // 0x00000001802132F0-0x0000000180213350
		private AxisDirection _axesToUse; // 0x148
		[CustomObfuscation] // 0x00000001802136E0-0x0000000180213740
		[SerializeField] // 0x00000001802136E0-0x0000000180213740
		[Tooltip] // 0x00000001802136E0-0x0000000180213740
		private TouchPadMode _touchPadMode; // 0x14C
		[CustomObfuscation] // 0x0000000180213BC0-0x0000000180213C20
		[SerializeField] // 0x0000000180213BC0-0x0000000180213C20
		[Tooltip] // 0x0000000180213BC0-0x0000000180213C20
		private ValueFormat _valueFormat; // 0x150
		[CustomObfuscation] // 0x0000000180213E40-0x0000000180213EA0
		[SerializeField] // 0x0000000180213E40-0x0000000180213EA0
		[Tooltip] // 0x0000000180213E40-0x0000000180213EA0
		private bool _useInertia; // 0x154
		[CustomObfuscation] // 0x00000001802141D0-0x0000000180214250
		[FieldRange] // 0x00000001802141D0-0x0000000180214250
		[SerializeField] // 0x00000001802141D0-0x0000000180214250
		[Tooltip] // 0x00000001802141D0-0x0000000180214250
		private float _inertiaFriction; // 0x158
		[CustomObfuscation] // 0x00000001802145F0-0x0000000180214650
		[SerializeField] // 0x00000001802145F0-0x0000000180214650
		[Tooltip] // 0x00000001802145F0-0x0000000180214650
		private bool _activateOnSwipeIn; // 0x15C
		[CustomObfuscation] // 0x00000001802149B0-0x0000000180214A10
		[SerializeField] // 0x00000001802149B0-0x0000000180214A10
		[Tooltip] // 0x00000001802149B0-0x0000000180214A10
		private bool _stayActiveOnSwipeOut; // 0x15D
		[CustomObfuscation] // 0x0000000180214F30-0x0000000180214F90
		[SerializeField] // 0x0000000180214F30-0x0000000180214F90
		[Tooltip] // 0x0000000180214F30-0x0000000180214F90
		private bool _allowTap; // 0x15E
		[CustomObfuscation] // 0x00000001801FA920-0x00000001801FA9A0
		[FieldRange] // 0x00000001801FA920-0x00000001801FA9A0
		[SerializeField] // 0x00000001801FA920-0x00000001801FA9A0
		[Tooltip] // 0x00000001801FA920-0x00000001801FA9A0
		private float _tapTimeout; // 0x160
		[CustomObfuscation] // 0x0000000180215330-0x00000001802153B0
		[FieldRange] // 0x0000000180215330-0x00000001802153B0
		[SerializeField] // 0x0000000180215330-0x00000001802153B0
		[Tooltip] // 0x0000000180215330-0x00000001802153B0
		private int _tapDistanceLimit; // 0x164
		[CustomObfuscation] // 0x00000001802156A0-0x0000000180215700
		[SerializeField] // 0x00000001802156A0-0x0000000180215700
		[Tooltip] // 0x00000001802156A0-0x0000000180215700
		private bool _allowPress; // 0x168
		[CustomObfuscation] // 0x0000000180215A30-0x0000000180215A90
		[SerializeField] // 0x0000000180215A30-0x0000000180215A90
		[Tooltip] // 0x0000000180215A30-0x0000000180215A90
		private float _pressStartDelay; // 0x16C
		[CustomObfuscation] // 0x0000000180215D70-0x0000000180215DF0
		[FieldRange] // 0x0000000180215D70-0x0000000180215DF0
		[SerializeField] // 0x0000000180215D70-0x0000000180215DF0
		[Tooltip] // 0x0000000180215D70-0x0000000180215DF0
		private int _pressDistanceLimit; // 0x170
		[CustomObfuscation] // 0x00000001802161D0-0x0000000180216230
		[SerializeField] // 0x00000001802161D0-0x0000000180216230
		[Tooltip] // 0x00000001802161D0-0x0000000180216230
		private bool _hideAtRuntime; // 0x174
		[CustomObfuscation] // 0x0000000180216540-0x00000001802165A0
		[SerializeField] // 0x0000000180216540-0x00000001802165A0
		[Tooltip] // 0x0000000180216540-0x00000001802165A0
		private StandaloneAxis2D _axis2D; // 0x178
		[CustomObfuscation] // 0x00000001802167D0-0x0000000180216830
		[SerializeField] // 0x00000001802167D0-0x0000000180216830
		[Tooltip] // 0x00000001802167D0-0x0000000180216830
		private ValueChangedEventHandler _onValueChanged; // 0x180
		[CustomObfuscation] // 0x0000000180216BA0-0x0000000180216C00
		[SerializeField] // 0x0000000180216BA0-0x0000000180216C00
		[Tooltip] // 0x0000000180216BA0-0x0000000180216C00
		private TapEventHandler _onTap; // 0x188
		[CustomObfuscation] // 0x0000000180217130-0x0000000180217190
		[SerializeField] // 0x0000000180217130-0x0000000180217190
		[Tooltip] // 0x0000000180217130-0x0000000180217190
		private PressDownEventHandler _onPressDown; // 0x190
		[CustomObfuscation] // 0x0000000180217470-0x00000001802174D0
		[SerializeField] // 0x0000000180217470-0x00000001802174D0
		[Tooltip] // 0x0000000180217470-0x00000001802174D0
		private PressUpEventHandler _onPressUp; // 0x198
		private bool _useXAxis; // 0x1A0
		private bool _useYAxis; // 0x1A1
		private int _pointerId; // 0x1A4
		private int _realMousePointerId; // 0x1A8
		[NonSerialized]
		private bool byeanBfvjEeOOwRBSBerFwsuBMBA; // 0x1AC
		[NonSerialized]
		private bool IXgubBiHZOnBAjLkDRcJjAfbtyr; // 0x1AD
		private bool _pointerDownIsFake; // 0x1AE
		private Vector2 _touchStartPosition; // 0x1B0
		private float _touchStartTime; // 0x1B8
		private Vector3 _currentCenter; // 0x1BC
		private Vector2 _previousTouchPosition; // 0x1C8
		private int _lastTapFrame; // 0x1D0
		private bool _isEligibleForTap; // 0x1D4
		private bool _isEligibleForPress; // 0x1D5
		private bool _pressValue; // 0x1D6
		private dFUjlNlXKzLEwMEvPWlCFDoWiJta _smoothDelta; // 0x1D8
		private Dictionary<int, PointerEventData> __fakePointerEventData; // 0x1E0
	
		// Properties
		public CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement { get; } // 0x00000001803EF180-0x00000001803EF190 
		public CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement { get; } // 0x0000000180383C00-0x0000000180383C10 
		public CustomControllerElementTargetSetForBoolean tapCustomControllerElement { get; } // 0x00000001803EF230-0x00000001803EF240 
		public CustomControllerElementTargetSetForBoolean pressCustomControllerElement { get; } // 0x00000001803EF170-0x00000001803EF180 
		public AxisDirection axesToUse { get; set; } // 0x00000001810600E0-0x00000001810600F0 0x00000001810C6640-0x00000001810C6680
		public TouchPadMode touchPadMode { get; set; } // 0x000000018044F710-0x000000018044F720 0x00000001810C6940-0x00000001810C6990
		public ValueFormat valueFormat { get; set; } // 0x00000001810C6240-0x00000001810C6250 0x00000001810C69E0-0x00000001810C6A40
		public bool useInertia { get; set; } // 0x000000018091EDD0-0x000000018091EDE0 0x00000001810C6990-0x00000001810C69E0
		public float inertiaFriction { get; set; } // 0x000000018058C870-0x000000018058C880 0x00000001810C66B0-0x00000001810C6730
		public bool activateOnSwipeIn { get; set; } // 0x000000018091EDE0-0x000000018091EDF0 0x00000001810C6560-0x00000001810C6580
		public bool stayActiveOnSwipeOut { get; set; } // 0x00000001810C6030-0x00000001810C6040 0x00000001810C6830-0x00000001810C6890
		public bool allowTap { get; set; } // 0x00000001810C5F60-0x00000001810C5F70 0x00000001810C65D0-0x00000001810C6640
		public float tapTimeout { get; set; } // 0x000000018091EE80-0x000000018091EE90 0x00000001810C68E0-0x00000001810C6940
		public int tapDistanceLimit { get; set; } // 0x00000001810C6040-0x00000001810C6050 0x00000001810C6890-0x00000001810C68E0
		public bool allowPress { get; set; } // 0x00000001810C5F50-0x00000001810C5F60 0x00000001810C6580-0x00000001810C65D0
		public float pressStartDelay { get; set; } // 0x00000001810C6020-0x00000001810C6030 0x00000001810C6790-0x00000001810C6830
		public int pressDistanceLimit { get; set; } // 0x0000000180652A50-0x0000000180652A60 0x00000001810C6740-0x00000001810C6790
		public bool hideAtRuntime { get; set; } // 0x00000001810C5FD0-0x00000001810C5FE0 0x00000001810C6680-0x00000001810C66B0
		public int pointerId { get; set; } // 0x00000001810C6010-0x00000001810C6020 0x00000001810C6730-0x00000001810C6740
		public bool hasPointer { get; } // 0x00000001810C5FC0-0x00000001810C5FD0 
		public Vector2 touchStartPosition { get; } // 0x00000001810C61C0-0x00000001810C6240 
		public Vector2 touchPosition { get; } // 0x00000001810C6070-0x00000001810C61C0 
		public AxisCalibration horizontalAxisCalibration { get; } // 0x00000001810C5FE0-0x00000001810C6010 
		public AxisCalibration verticalAxisCalibration { get; } // 0x00000001810C6250-0x00000001810C6280 
		public Axis2DCalibration axis2DCalibration { get; } // 0x00000001810C5F70-0x00000001810C5F90 
		internal StandaloneAxis2D axis2D { get; } // 0x00000001803EF200-0x00000001803EF210 
		private int effectivePointerId { get; } // 0x00000001810C5F90-0x00000001810C5FC0 
		private bool tapValue { get; } // 0x00000001810C6050-0x00000001810C6070 
	
		// Events
		public event UnityAction<Vector2> ValueChangedEvent {
			add; // 0x00000001810C53C0-0x00000001810C5420
			remove; // 0x00000001810C6500-0x00000001810C6560
		}
		public event UnityAction TapEvent {
			add; // 0x00000001810C5390-0x00000001810C53C0
			remove; // 0x00000001810C64D0-0x00000001810C6500
		}
		public event UnityAction PressDownEvent {
			add; // 0x00000001810C5330-0x00000001810C5360
			remove; // 0x00000001810C6470-0x00000001810C64A0
		}
		public event UnityAction PressUpEvent {
			add; // 0x00000001810C5360-0x00000001810C5390
			remove; // 0x00000001810C64A0-0x00000001810C64D0
		}
	
		// Nested types
		public enum AxisDirection // TypeDefIndex: 6015
		{
			Both = 0,
			Horizontal = 1,
			Vertical = 2
		}
	
		public enum TouchPadMode // TypeDefIndex: 6016
		{
			Delta = 0,
			ScreenPosition = 1,
			VectorFromCenter = 2,
			VectorFromInitialTouch = 3
		}
	
		public enum ValueFormat // TypeDefIndex: 6017
		{
			Pixels = 0,
			Screen = 1,
			Physical = 2,
			Direction = 3
		}
	
		private class dFUjlNlXKzLEwMEvPWlCFDoWiJta // TypeDefIndex: 6018
		{
			// Fields
			private int mVECVjbYFaPhPNQctHGOhFAndGU; // 0x10
			private LOYICrNmJbEDpcDLFqNLeTHiFDY[] BuwIKNnQECuDvuXrWMqVIxlxRgA; // 0x18
			private int JmjyOQGqMTQVyuPjpVribdoqBbW; // 0x20
	
			// Nested types
			private class LOYICrNmJbEDpcDLFqNLeTHiFDY // TypeDefIndex: 6019
			{
				// Fields
				public float jMeIpvfjZOxlpswPIuhuwRcOfdO; // 0x10
				public float FgjvfzHcWabyGiXRtsKQNmtuoEKC; // 0x14
				public uint eupkLNYHupbKxOgCHbqidLtXZAwi; // 0x18
	
				// Constructors
				public LOYICrNmJbEDpcDLFqNLeTHiFDY(); // 0x0000000180373240-0x0000000180373250
			}
	
			// Constructors
			public dFUjlNlXKzLEwMEvPWlCFDoWiJta(int maxSmoothFrames); // 0x00000001810C88C0-0x00000001810C89D0
	
			// Methods
			public void IkSMympyYfTpBxGGBkGOyOMOaezh(float param_0000caaf, float param_0000cab0); // 0x00000001810C8730-0x00000001810C8890
			public Vector2 IjzmsmvNpkKBYeAGrGuMVKQsCYQ(); // 0x00000001810C84C0-0x00000001810C8730
			private void AFKVQgrHuwiOwfOUIfeZXkJEZEl(); // 0x00000001810C84A0-0x00000001810C84C0
			private static int eZAMChHDXNgmrtyMjYWIOHUYdkj(int param_0000cab1, int param_0000cab2); // 0x00000001810C89D0-0x00000001810C89E0
			private int XUVqQKnBoCQfbGmCIQBaomAPHKT(int param_0000cab3, int param_0000cab4); // 0x00000001810C88B0-0x00000001810C88C0
			private static bool RRxmUmWwueUrTzwHPpzYwWNwuBO(uint param_0000cab5, uint param_0000cab6); // 0x00000001810C8890-0x00000001810C88B0
		}
	
		[Serializable]
		public class ValueChangedEventHandler : UnityEvent<Vector2> // TypeDefIndex: 6020
		{
			// Constructors
			public ValueChangedEventHandler(); // 0x00000001810C83A0-0x00000001810C83E0
		}
	
		[Serializable]
		public class TapEventHandler : UnityEvent // TypeDefIndex: 6021
		{
			// Constructors
			public TapEventHandler(); // 0x0000000180372000-0x0000000180372010
		}
	
		[Serializable]
		public class PressDownEventHandler : UnityEvent // TypeDefIndex: 6022
		{
			// Constructors
			public PressDownEventHandler(); // 0x0000000180372000-0x0000000180372010
		}
	
		[Serializable]
		public class PressUpEventHandler : UnityEvent // TypeDefIndex: 6023
		{
			// Constructors
			public PressUpEventHandler(); // 0x0000000180372000-0x0000000180372010
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private TouchPad(); // 0x00000001810C5040-0x00000001810C5330
	
		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void Awake(); // 0x00000001810C1F20-0x00000001810C1FA0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnValidate(); // 0x00000001810C47F0-0x00000001810C4840
		internal override bool OnInitialize(); // 0x00000001810C4240-0x00000001810C4270
		internal override void OnUpdate(); // 0x00000001810C4760-0x00000001810C47F0
		internal override void OnCustomControllerUpdate(); // 0x00000001810C4010-0x00000001810C4240
		internal override void OnSetProperty(); // 0x00000001810C4710-0x00000001810C4760
		internal override void OnClear(); // 0x00000001810C3E60-0x00000001810C4010
		public override void ClearValue(); // 0x00000001810C2A60-0x00000001810C2BD0
		private new void LZtLIradkTZxeuvnkQoCvQBxNXr(); // 0x00000001810C3490-0x00000001810C3550
		private void ngSCpflbmnAmEnJEbHrUjRCLHCB(); // 0x00000001810C6280-0x00000001810C6470
		private void dzynYViRaRMlteHKPpYVKSjcRik(AxisDirection param_0000ca97); // 0x00000001810C59C0-0x00000001810C5B50
		private void MsGuhXEMmfanqTAvXbqFjDUICT(); // 0x00000001810C3C20-0x00000001810C3E40
		private void BQXLkxqmrsdRiepPtxyGHXIuPQt(); // 0x00000001810C1FA0-0x00000001810C27B0
		private void IvRpjOAYYthzVxkzBPRWdoQLnFF(); // 0x00000001810C31F0-0x00000001810C3490
		private void ZZYGIlXqqUsylsfQBQmTnvRyFpn(); // 0x00000001810C4D70-0x00000001810C5040
		private void zxcfAcvnwhOviPQlyJevzmGbgxl(ref Vector2 param_0000ca98); // 0x00000001810C6DB0-0x00000001810C6F60
		private void ImouRQkIXMEoNjSzsGeHbJZwBkk(ref Vector2 param_0000ca99); // 0x00000001810C2FD0-0x00000001810C31F0
		private void BffNHkpvQpNHpcLLgKUWPenUbOQ(); // 0x00000001810C27B0-0x00000001810C2A60
		private Vector2 TYRElaYuYnmVyhgBDTWyacTpNzS(Vector2 param_0000ca9a); // 0x00000001810C4B40-0x00000001810C4D70
		private void bWoaCnGbNpCyBbXGQNlrHaHvCCum(bool param_0000ca9b); // 0x00000001810C5420-0x00000001810C54B0
		private void RxEZUnGIHFENEtIpjktQHvdabdW(PointerEventData param_0000ca9c); // 0x00000001810C4840-0x00000001810C4B40
		private void uyQABlNHvFbAnbhXXlzvvLWQhYr(PointerEventData param_0000ca9d); // 0x00000001810C6A40-0x00000001810C6BD0
		private void cMtnsaxGhUfiDcRwjkYxflgBASiH(PointerEventData param_0000ca9e); // 0x00000001810C54B0-0x00000001810C5860
		private void EzJjjNAhQSmydhBVfCMGbRhVYoAK(PointerEventData param_0000ca9f); // 0x00000001810C2BD0-0x00000001810C2DF0
		private void eCctVKDNgyQGyeaOcqjOyVlLJqO(int param_0000caa0, Vector2 param_0000caa1); // 0x00000001810C5B50-0x00000001810C5CB0
		private void vFVybIPqofnIcLfQTuNwraHYvlu(); // 0x00000001810C6BD0-0x00000001810C6DB0
		internal override void OnPointerUp(PointerEventData eventData); // 0x00000001810C44E0-0x00000001810C4710
		internal override void OnPointerDown(PointerEventData eventData); // 0x00000001810C4270-0x00000001810C4350
		internal override void OnPointerEnter(PointerEventData eventData); // 0x00000001810C4350-0x00000001810C4430
		internal override void OnPointerExit(PointerEventData eventData); // 0x00000001810C4430-0x00000001810C44E0
		private void OZFNDbURhVZKFtFmWGnJgPfugYpe(); // 0x00000001810C3E40-0x00000001810C3E60
		private bool dhOQlLJinYpERxCGGhjOgbBZapAV(int param_0000caa6); // 0x00000001810C5900-0x00000001810C59C0
		private PointerEventData LlGMCNteBCahnPiqWbTrHoAGivp(int param_0000caa7, GameObject param_0000caa8); // 0x00000001810C3550-0x00000001810C3C20
		private PointerEventData IeozbiZwrTQxWvulmeRKsKBLdtja(int param_0000caa9, GameObject param_0000caaa); // 0x00000001810C2DF0-0x00000001810C2FD0
		private PointerEventData AMQXfcKdkhATGEHBZPeTJWJpfSUA(int param_0000caab); // 0x00000001810C1D60-0x00000001810C1F20
		private void cuuvieNpgXrCVXOlgxCyYFCjPIj(PointerEventData param_0000caac); // 0x00000001810C5860-0x00000001810C5900
		private PointerEventData gEzDDiQGlFHTAMAVPqWluKHtuyP(int param_0000caad); // 0x00000001810C5CB0-0x00000001810C5F50
	}
}

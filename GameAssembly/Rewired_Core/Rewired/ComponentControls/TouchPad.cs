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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001801717F0-0x0000000180171850
	[RequireComponent] // 0x00000001801717F0-0x0000000180171850
	public sealed class TouchPad : TouchInteractable, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 5855
	{
		// Fields
		private const int SMOOTH_DELTA_FRAME_COUNT = 3; // Metadata: 0x0072ECF8
		[CustomObfuscation] // 0x0000000180171B90-0x0000000180171BF0
		[SerializeField] // 0x0000000180171B90-0x0000000180171BF0
		[Tooltip] // 0x0000000180171B90-0x0000000180171BF0
		private CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement; // 0x128
		[CustomObfuscation] // 0x0000000180171FE0-0x0000000180172040
		[SerializeField] // 0x0000000180171FE0-0x0000000180172040
		[Tooltip] // 0x0000000180171FE0-0x0000000180172040
		private CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement; // 0x130
		[CustomObfuscation] // 0x0000000180173610-0x0000000180173670
		[SerializeField] // 0x0000000180173610-0x0000000180173670
		[Tooltip] // 0x0000000180173610-0x0000000180173670
		private CustomControllerElementTargetSetForBoolean _tapCustomControllerElement; // 0x138
		[CustomObfuscation] // 0x0000000180173910-0x0000000180173970
		[SerializeField] // 0x0000000180173910-0x0000000180173970
		[Tooltip] // 0x0000000180173910-0x0000000180173970
		private CustomControllerElementTargetSetForBoolean _pressCustomControllerElement; // 0x140
		[CustomObfuscation] // 0x0000000180173B50-0x0000000180173BB0
		[SerializeField] // 0x0000000180173B50-0x0000000180173BB0
		[Tooltip] // 0x0000000180173B50-0x0000000180173BB0
		private AxisDirection _axesToUse; // 0x148
		[CustomObfuscation] // 0x0000000180173E00-0x0000000180173E60
		[SerializeField] // 0x0000000180173E00-0x0000000180173E60
		[Tooltip] // 0x0000000180173E00-0x0000000180173E60
		private TouchPadMode _touchPadMode; // 0x14C
		[CustomObfuscation] // 0x00000001801743A0-0x0000000180174400
		[SerializeField] // 0x00000001801743A0-0x0000000180174400
		[Tooltip] // 0x00000001801743A0-0x0000000180174400
		private ValueFormat _valueFormat; // 0x150
		[CustomObfuscation] // 0x0000000180174810-0x0000000180174870
		[SerializeField] // 0x0000000180174810-0x0000000180174870
		[Tooltip] // 0x0000000180174810-0x0000000180174870
		private bool _useInertia; // 0x154
		[CustomObfuscation] // 0x0000000180174B10-0x0000000180174B90
		[FieldRange] // 0x0000000180174B10-0x0000000180174B90
		[SerializeField] // 0x0000000180174B10-0x0000000180174B90
		[Tooltip] // 0x0000000180174B10-0x0000000180174B90
		private float _inertiaFriction; // 0x158
		[CustomObfuscation] // 0x0000000180175070-0x00000001801750D0
		[SerializeField] // 0x0000000180175070-0x00000001801750D0
		[Tooltip] // 0x0000000180175070-0x00000001801750D0
		private bool _activateOnSwipeIn; // 0x15C
		[CustomObfuscation] // 0x0000000180175390-0x00000001801753F0
		[SerializeField] // 0x0000000180175390-0x00000001801753F0
		[Tooltip] // 0x0000000180175390-0x00000001801753F0
		private bool _stayActiveOnSwipeOut; // 0x15D
		[CustomObfuscation] // 0x0000000180175740-0x00000001801757A0
		[SerializeField] // 0x0000000180175740-0x00000001801757A0
		[Tooltip] // 0x0000000180175740-0x00000001801757A0
		private bool _allowTap; // 0x15E
		[CustomObfuscation] // 0x00000001800B3A10-0x00000001800B3A90
		[FieldRange] // 0x00000001800B3A10-0x00000001800B3A90
		[SerializeField] // 0x00000001800B3A10-0x00000001800B3A90
		[Tooltip] // 0x00000001800B3A10-0x00000001800B3A90
		private float _tapTimeout; // 0x160
		[CustomObfuscation] // 0x00000001800B3DA0-0x00000001800B3E20
		[FieldRange] // 0x00000001800B3DA0-0x00000001800B3E20
		[SerializeField] // 0x00000001800B3DA0-0x00000001800B3E20
		[Tooltip] // 0x00000001800B3DA0-0x00000001800B3E20
		private int _tapDistanceLimit; // 0x164
		[CustomObfuscation] // 0x00000001800B40C0-0x00000001800B4120
		[SerializeField] // 0x00000001800B40C0-0x00000001800B4120
		[Tooltip] // 0x00000001800B40C0-0x00000001800B4120
		private bool _allowPress; // 0x168
		[CustomObfuscation] // 0x00000001800B55E0-0x00000001800B5640
		[SerializeField] // 0x00000001800B55E0-0x00000001800B5640
		[Tooltip] // 0x00000001800B55E0-0x00000001800B5640
		private float _pressStartDelay; // 0x16C
		[CustomObfuscation] // 0x00000001800B58E0-0x00000001800B5960
		[FieldRange] // 0x00000001800B58E0-0x00000001800B5960
		[SerializeField] // 0x00000001800B58E0-0x00000001800B5960
		[Tooltip] // 0x00000001800B58E0-0x00000001800B5960
		private int _pressDistanceLimit; // 0x170
		[CustomObfuscation] // 0x00000001800B5B70-0x00000001800B5BD0
		[SerializeField] // 0x00000001800B5B70-0x00000001800B5BD0
		[Tooltip] // 0x00000001800B5B70-0x00000001800B5BD0
		private bool _hideAtRuntime; // 0x174
		[CustomObfuscation] // 0x00000001800B5E80-0x00000001800B5EE0
		[SerializeField] // 0x00000001800B5E80-0x00000001800B5EE0
		[Tooltip] // 0x00000001800B5E80-0x00000001800B5EE0
		private StandaloneAxis2D _axis2D; // 0x178
		[CustomObfuscation] // 0x00000001800B61A0-0x00000001800B6200
		[SerializeField] // 0x00000001800B61A0-0x00000001800B6200
		[Tooltip] // 0x00000001800B61A0-0x00000001800B6200
		private ValueChangedEventHandler _onValueChanged; // 0x180
		[CustomObfuscation] // 0x00000001800B64B0-0x00000001800B6510
		[SerializeField] // 0x00000001800B64B0-0x00000001800B6510
		[Tooltip] // 0x00000001800B64B0-0x00000001800B6510
		private TapEventHandler _onTap; // 0x188
		[CustomObfuscation] // 0x00000001800B65D0-0x00000001800B6630
		[SerializeField] // 0x00000001800B65D0-0x00000001800B6630
		[Tooltip] // 0x00000001800B65D0-0x00000001800B6630
		private PressDownEventHandler _onPressDown; // 0x190
		[CustomObfuscation] // 0x00000001800B6750-0x00000001800B67B0
		[SerializeField] // 0x00000001800B6750-0x00000001800B67B0
		[Tooltip] // 0x00000001800B6750-0x00000001800B67B0
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
		public CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement { get; } // 0x00000001803BD350-0x00000001803BD360 
		public CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement { get; } // 0x00000001803BD390-0x00000001803BD3A0 
		public CustomControllerElementTargetSetForBoolean tapCustomControllerElement { get; } // 0x00000001803BD3B0-0x00000001803BD3C0 
		public CustomControllerElementTargetSetForBoolean pressCustomControllerElement { get; } // 0x00000001803BD3E0-0x00000001803BD3F0 
		public AxisDirection axesToUse { get; set; } // 0x0000000180A98E90-0x0000000180A98EA0 0x00000001819209D0-0x0000000181920A10
		public TouchPadMode touchPadMode { get; set; } // 0x0000000180F83870-0x0000000180F83880 0x0000000181920CD0-0x0000000181920D20
		public ValueFormat valueFormat { get; set; } // 0x00000001819205B0-0x00000001819205C0 0x0000000181920D70-0x0000000181920DD0
		public bool useInertia { get; set; } // 0x0000000181441600-0x0000000181441610 0x0000000181920D20-0x0000000181920D70
		public float inertiaFriction { get; set; } // 0x0000000181441680-0x0000000181441690 0x0000000181920A40-0x0000000181920AC0
		public bool activateOnSwipeIn { get; set; } // 0x0000000181441610-0x0000000181441620 0x00000001819208F0-0x0000000181920910
		public bool stayActiveOnSwipeOut { get; set; } // 0x00000001819203B0-0x00000001819203C0 0x0000000181920BC0-0x0000000181920C20
		public bool allowTap { get; set; } // 0x00000001819202B0-0x00000001819202C0 0x0000000181920960-0x00000001819209D0
		public float tapTimeout { get; set; } // 0x00000001814416B0-0x00000001814416C0 0x0000000181920C70-0x0000000181920CD0
		public int tapDistanceLimit { get; set; } // 0x000000018081DF40-0x000000018081DF50 0x0000000181920C20-0x0000000181920C70
		public bool allowPress { get; set; } // 0x00000001819202A0-0x00000001819202B0 0x0000000181920910-0x0000000181920960
		public float pressStartDelay { get; set; } // 0x00000001819203A0-0x00000001819203B0 0x0000000181920B20-0x0000000181920BC0
		public int pressDistanceLimit { get; set; } // 0x0000000181920390-0x00000001819203A0 0x0000000181920AD0-0x0000000181920B20
		public bool hideAtRuntime { get; set; } // 0x0000000181920330-0x0000000181920340 0x0000000181920A10-0x0000000181920A40
		public int pointerId { get; set; } // 0x0000000181920380-0x0000000181920390 0x0000000181920AC0-0x0000000181920AD0
		public bool hasPointer { get; } // 0x0000000181920320-0x0000000181920330 
		public Vector2 touchStartPosition { get; } // 0x0000000181920530-0x00000001819205B0 
		public Vector2 touchPosition { get; } // 0x00000001819203E0-0x0000000181920530 
		public AxisCalibration horizontalAxisCalibration { get; } // 0x0000000181920340-0x0000000181920380 
		public AxisCalibration verticalAxisCalibration { get; } // 0x00000001819205C0-0x0000000181920600 
		public Axis2DCalibration axis2DCalibration { get; } // 0x00000001819202C0-0x00000001819202F0 
		internal StandaloneAxis2D axis2D { get; } // 0x000000018081E150-0x000000018081E160 
		private int effectivePointerId { get; } // 0x00000001819202F0-0x0000000181920320 
		private bool tapValue { get; } // 0x00000001819203C0-0x00000001819203E0 
	
		// Events
		public event UnityAction<Vector2> ValueChangedEvent {
			add; // 0x000000018191F700-0x000000018191F760
			remove; // 0x0000000181920890-0x00000001819208F0
		}
		public event UnityAction TapEvent {
			add; // 0x000000018191F6D0-0x000000018191F700
			remove; // 0x0000000181920860-0x0000000181920890
		}
		public event UnityAction PressDownEvent {
			add; // 0x000000018191F670-0x000000018191F6A0
			remove; // 0x0000000181920800-0x0000000181920830
		}
		public event UnityAction PressUpEvent {
			add; // 0x000000018191F6A0-0x000000018191F6D0
			remove; // 0x0000000181920830-0x0000000181920860
		}
	
		// Nested types
		public enum AxisDirection // TypeDefIndex: 5856
		{
			Both = 0,
			Horizontal = 1,
			Vertical = 2
		}
	
		public enum TouchPadMode // TypeDefIndex: 5857
		{
			Delta = 0,
			ScreenPosition = 1,
			VectorFromCenter = 2,
			VectorFromInitialTouch = 3
		}
	
		public enum ValueFormat // TypeDefIndex: 5858
		{
			Pixels = 0,
			Screen = 1,
			Physical = 2,
			Direction = 3
		}
	
		private class dFUjlNlXKzLEwMEvPWlCFDoWiJta // TypeDefIndex: 5859
		{
			// Fields
			private int mVECVjbYFaPhPNQctHGOhFAndGU; // 0x10
			private LOYICrNmJbEDpcDLFqNLeTHiFDY[] BuwIKNnQECuDvuXrWMqVIxlxRgA; // 0x18
			private int JmjyOQGqMTQVyuPjpVribdoqBbW; // 0x20
	
			// Nested types
			private class LOYICrNmJbEDpcDLFqNLeTHiFDY // TypeDefIndex: 5860
			{
				// Fields
				public float jMeIpvfjZOxlpswPIuhuwRcOfdO; // 0x10
				public float FgjvfzHcWabyGiXRtsKQNmtuoEKC; // 0x14
				public uint eupkLNYHupbKxOgCHbqidLtXZAwi; // 0x18
	
				// Constructors
				public LOYICrNmJbEDpcDLFqNLeTHiFDY(); // 0x000000018036B6C0-0x000000018036B6D0
			}
	
			// Constructors
			public dFUjlNlXKzLEwMEvPWlCFDoWiJta(int maxSmoothFrames); // 0x0000000181922CA0-0x0000000181922DB0
	
			// Methods
			public void IkSMympyYfTpBxGGBkGOyOMOaezh(float param_0000c83f, float param_0000c840); // 0x0000000181922B10-0x0000000181922C70
			public Vector2 IjzmsmvNpkKBYeAGrGuMVKQsCYQ(); // 0x0000000181922890-0x0000000181922B10
			private void AFKVQgrHuwiOwfOUIfeZXkJEZEl(); // 0x0000000181922870-0x0000000181922890
			private static int eZAMChHDXNgmrtyMjYWIOHUYdkj(int param_0000c841, int param_0000c842); // 0x0000000181922DB0-0x0000000181922DC0
			private int XUVqQKnBoCQfbGmCIQBaomAPHKT(int param_0000c843, int param_0000c844); // 0x0000000181922C90-0x0000000181922CA0
			private static bool RRxmUmWwueUrTzwHPpzYwWNwuBO(uint param_0000c845, uint param_0000c846); // 0x0000000181922C70-0x0000000181922C90
		}
	
		[Serializable]
		public class ValueChangedEventHandler : UnityEvent<Vector2> // TypeDefIndex: 5861
		{
			// Constructors
			public ValueChangedEventHandler(); // 0x0000000181922770-0x00000001819227B0
		}
	
		[Serializable]
		public class TapEventHandler : UnityEvent // TypeDefIndex: 5862
		{
			// Constructors
			public TapEventHandler(); // 0x0000000180E3CEA0-0x0000000180E3CEB0
		}
	
		[Serializable]
		public class PressDownEventHandler : UnityEvent // TypeDefIndex: 5863
		{
			// Constructors
			public PressDownEventHandler(); // 0x0000000180E3CEA0-0x0000000180E3CEB0
		}
	
		[Serializable]
		public class PressUpEventHandler : UnityEvent // TypeDefIndex: 5864
		{
			// Constructors
			public PressUpEventHandler(); // 0x0000000180E3CEA0-0x0000000180E3CEB0
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private TouchPad(); // 0x000000018191F380-0x000000018191F670
	
		// Methods
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void Awake(); // 0x000000018191C220-0x000000018191C2A0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnValidate(); // 0x000000018191EB30-0x000000018191EB80
		internal override bool OnInitialize(); // 0x000000018191E570-0x000000018191E5A0
		internal override void OnUpdate(); // 0x000000018191EAA0-0x000000018191EB30
		internal override void OnCustomControllerUpdate(); // 0x000000018191E340-0x000000018191E570
		internal override void OnSetProperty(); // 0x000000018191EA50-0x000000018191EAA0
		internal override void OnClear(); // 0x000000018191E190-0x000000018191E340
		public override void ClearValue(); // 0x000000018191CD70-0x000000018191CEE0
		private new void LZtLIradkTZxeuvnkQoCvQBxNXr(); // 0x000000018191D7A0-0x000000018191D860
		private void ngSCpflbmnAmEnJEbHrUjRCLHCB(); // 0x0000000181920600-0x0000000181920800
		private void dzynYViRaRMlteHKPpYVKSjcRik(AxisDirection param_0000c827); // 0x000000018191FD00-0x000000018191FE90
		private void MsGuhXEMmfanqTAvXbqFjDUICT(); // 0x000000018191DF50-0x000000018191E170
		private void BQXLkxqmrsdRiepPtxyGHXIuPQt(); // 0x000000018191C2A0-0x000000018191CAC0
		private void IvRpjOAYYthzVxkzBPRWdoQLnFF(); // 0x000000018191D500-0x000000018191D7A0
		private void ZZYGIlXqqUsylsfQBQmTnvRyFpn(); // 0x000000018191F0B0-0x000000018191F380
		private void zxcfAcvnwhOviPQlyJevzmGbgxl(ref Vector2 param_0000c828); // 0x0000000181921140-0x00000001819212F0
		private void ImouRQkIXMEoNjSzsGeHbJZwBkk(ref Vector2 param_0000c829); // 0x000000018191D2E0-0x000000018191D500
		private void BffNHkpvQpNHpcLLgKUWPenUbOQ(); // 0x000000018191CAC0-0x000000018191CD70
		private Vector2 TYRElaYuYnmVyhgBDTWyacTpNzS(Vector2 param_0000c82a); // 0x000000018191EE80-0x000000018191F0B0
		private void bWoaCnGbNpCyBbXGQNlrHaHvCCum(bool param_0000c82b); // 0x000000018191F760-0x000000018191F7F0
		private void RxEZUnGIHFENEtIpjktQHvdabdW(PointerEventData param_0000c82c); // 0x000000018191EB80-0x000000018191EE80
		private void uyQABlNHvFbAnbhXXlzvvLWQhYr(PointerEventData param_0000c82d); // 0x0000000181920DD0-0x0000000181920F60
		private void cMtnsaxGhUfiDcRwjkYxflgBASiH(PointerEventData param_0000c82e); // 0x000000018191F7F0-0x000000018191FBA0
		private void EzJjjNAhQSmydhBVfCMGbRhVYoAK(PointerEventData param_0000c82f); // 0x000000018191CEE0-0x000000018191D100
		private void eCctVKDNgyQGyeaOcqjOyVlLJqO(int param_0000c830, Vector2 param_0000c831); // 0x000000018191FE90-0x000000018191FFF0
		private void vFVybIPqofnIcLfQTuNwraHYvlu(); // 0x0000000181920F60-0x0000000181921140
		internal override void OnPointerUp(PointerEventData eventData); // 0x000000018191E810-0x000000018191EA50
		internal override void OnPointerDown(PointerEventData eventData); // 0x000000018191E5A0-0x000000018191E680
		internal override void OnPointerEnter(PointerEventData eventData); // 0x000000018191E680-0x000000018191E760
		internal override void OnPointerExit(PointerEventData eventData); // 0x000000018191E760-0x000000018191E810
		private void OZFNDbURhVZKFtFmWGnJgPfugYpe(); // 0x000000018191E170-0x000000018191E190
		private bool dhOQlLJinYpERxCGGhjOgbBZapAV(int param_0000c836); // 0x000000018191FC40-0x000000018191FD00
		private PointerEventData LlGMCNteBCahnPiqWbTrHoAGivp(int param_0000c837, GameObject param_0000c838); // 0x000000018191D860-0x000000018191DF50
		private PointerEventData IeozbiZwrTQxWvulmeRKsKBLdtja(int param_0000c839, GameObject param_0000c83a); // 0x000000018191D100-0x000000018191D2E0
		private PointerEventData AMQXfcKdkhATGEHBZPeTJWJpfSUA(int param_0000c83b); // 0x000000018191C060-0x000000018191C220
		private void cuuvieNpgXrCVXOlgxCyYFCjPIj(PointerEventData param_0000c83c); // 0x000000018191FBA0-0x000000018191FC40
		private PointerEventData gEzDDiQGlFHTAMAVPqWluKHtuyP(int param_0000c83d); // 0x000000018191FFF0-0x00000001819202A0
	}
}

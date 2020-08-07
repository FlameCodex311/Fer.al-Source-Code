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
using Rewired.Config;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public abstract class Controller // TypeDefIndex: 6049
	{
		// Fields
		public readonly int id; // 0x10
		protected string _tag; // 0x18
		protected string _name; // 0x20
		protected string _hardwareName; // 0x28
		protected readonly ControllerType _type; // 0x30
		internal readonly Guid OYSjChAEXTYpiFBMHycpqxKbEmz; // 0x34
		protected string _hardwareIdentifier; // 0x48
		protected bool _isConnected; // 0x50
		private Extension ZXidIbsBtOYiKGegrccafjeNbYN; // 0x58
		private bool RYgMGyqWnNNUOzFUBDIFjvchsBxb; // 0x60
		private ControllerIdentifier mizXqOjprEzLWtbeUgyGyojvrZX; // 0x68
		internal int vSShldFHkaZKEuThltrSgFmPfc; // 0x98
		protected readonly int _buttonCount; // 0x9C
		protected readonly Button[] buttons; // 0xA0
		protected readonly ReadOnlyCollection<Button> buttons_readOnly; // 0xA8
		private readonly IList<Element> OuMXbYHQWjhHUDiQLPmgBAWEshm; // 0xB0
		private readonly ReadOnlyCollection<Element> kaRwVFuEhQdielEoQKhHRABCAZN; // 0xB8
		internal readonly InputSource IfWmLaqyRlsuporQiJgqwmXsLqe; // 0xC0
		internal readonly ControllerDataUpdater gafVTBKVGEvFjAIIaWNuYPCcFkz; // 0xC8
		internal readonly HardwareControllerMap_Game VnQIptJChOAyXtaioLZfAFotfgY; // 0xD0
		internal uint VJAXydzWoKegMkpuYraXEqFVHWYE; // 0xD8
		private uint FaCAMYzyKJEAjbltvEZQjYLhkAE; // 0xDC
		private uint KJSwBCHqilatIrHwECLaYlgmekY; // 0xE0
		private Action<bool> PqDQtwapHeHHTvTTXUKIVftJHvU; // 0xE8
		private IControllerTemplate[] qoiVGKyiLiRjLGtdYxdTebqasqP; // 0xF0
		private ReadOnlyCollection<IControllerTemplate> izcgnJucoQqYHqtWNfYFckZOkRe; // 0xF8
		private static Func<Controller, Guid, bool> XvByQJmlbPnmVKoVhyVVDqOtTxT; // 0x00
		private static Func<Controller, Type, bool> WLbptarfsmoolwfNBesRCVoxZai; // 0x08
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Func<Controller, Guid, bool> CWjBcSiUYzmlMwepxVNqomArHSvB; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Func<Controller, Type, bool> TjGEBsHFMVCHUCaUrhTtAyNgOuoQ; // 0x18
	
		// Properties
		internal bool wasPollingPrev { get; } // 0x00000001808DB690-0x00000001808DB700 
		public bool enabled { get; set; } // 0x00000001808DAD90-0x00000001808DAE30 0x00000001808DBEB0-0x00000001808DBED0
		public string name { get; internal set; } // 0x00000001808DB3E0-0x00000001808DB490 0x00000001803F70C0-0x00000001803F70D0
		public string tag { get; set; } // 0x00000001808DB490-0x00000001808DB540 0x00000001808DBFE0-0x00000001808DC0B0
		public string hardwareName { get; } // 0x00000001808DAF80-0x00000001808DB060 
		public ControllerType type { get; } // 0x00000001808DB5F0-0x00000001808DB690 
		public Guid hardwareTypeGuid { get; } // 0x00000001808DB060-0x00000001808DB140 
		public abstract Guid deviceInstanceGuid { get; }
		public ControllerIdentifier identifier { get; } // 0x00000001808DB140-0x00000001808DB160 
		public bool isConnected { get; internal set; } // 0x00000001808DB2C0-0x00000001808DB360 0x00000001808DBED0-0x00000001808DBFE0
		public string hardwareIdentifier { get; } // 0x00000001808DAED0-0x00000001808DAF80 
		public string mapTypeString { get; } // 0x00000001808DB360-0x00000001808DB3E0 
		public int elementCount { get; } // 0x00000001808DACD0-0x00000001808DAD90 
		public int buttonCount { get; } // 0x00000001808DAC00-0x00000001808DACD0 
		public IList<Element> Elements { get; } // 0x00000001808DAAA0-0x00000001808DAB50 
		public IList<Button> Buttons { get; } // 0x00000001808DA930-0x00000001808DA9E0 
		public Extension extension { get; } // 0x00000001808DAE30-0x00000001808DAED0 
		public IList<ControllerElementIdentifier> ElementIdentifiers { get; } // 0x00000001808DA9E0-0x00000001808DAAA0 
		public IList<ControllerElementIdentifier> ButtonElementIdentifiers { get; } // 0x00000001808DA840-0x00000001808DA930 
		public IList<IControllerTemplate> Templates { get; } // 0x00000001808DAB50-0x00000001808DAC00 
		public int templateCount { get; } // 0x00000001808DB540-0x00000001808DB5F0 
		internal static Func<Controller, Guid, bool> implementsTemplateDelegate_Guid { get; } // 0x00000001808DB160-0x00000001808DB200 
		internal static Func<Controller, Type, bool> implementsTemplateDelegate_Type { get; } // 0x00000001808DB200-0x00000001808DB2C0 
	
		// Events
		internal event Action<bool> EnabledStateChangedEvent {
			add; // 0x00000001808DA730-0x00000001808DA7C0
			remove; // 0x00000001808DBDD0-0x00000001808DBE60
		}
	
		// Nested types
		public abstract class Element // TypeDefIndex: 6050
		{
			// Fields
			public readonly int id; // 0x10
			public readonly string name; // 0x18
			public readonly ControllerElementType type; // 0x20
			internal gKllCxkHIedBUuUddXdAeLyxxPH BzPTUktQKzpSptpMHgKsLeECXUF; // 0x28
			internal int cxQbbedSXGoZnWLrqcrVGMIkKdQE; // 0x30
			internal Controller VFyAcBdeMMCAMfDOgPwemixrJuYM; // 0x38
			internal readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x40
	
			// Properties
			public ControllerElementIdentifier elementIdentifier { get; } // 0x00000001808E0EB0-0x00000001808E0F70 
			public bool isMemberElement { get; } // 0x00000001808E0F70-0x00000001808E1010 
	
			// Nested types
			internal abstract class gKllCxkHIedBUuUddXdAeLyxxPH // TypeDefIndex: 6051
			{
				// Fields
				protected readonly int WGHFFzJMXRpPuoqnoZfReFkMDCNi; // 0x10
				protected readonly int[] YIfdsEMRhAyoDoMFbNpXyyKydTj; // 0x18
				protected NZqFOhpkTYBQHjwhGNmVuMipjoqc[] kfTISdkkctRzKjoxkCEklUCQgYlt; // 0x20
				public NZqFOhpkTYBQHjwhGNmVuMipjoqc hXsQEjeqlbsWHdImyyWjqLiDOxk; // 0x28
				private int JmjyOQGqMTQVyuPjpVribdoqBbW; // 0x30
				public int BiWKybgirUycdinIYBuMqCscBJH; // 0x34
				protected ReadOnlyCollection<NZqFOhpkTYBQHjwhGNmVuMipjoqc> KiSTfJOVBLGRUkrmLtgbiZfWTRw; // 0x38
	
				// Properties
				public IList<NZqFOhpkTYBQHjwhGNmVuMipjoqc> sswPLpxFhWaHaJPpqMOtHCHzCGfx { get; } // 0x00000001803743D0-0x00000001803743E0 
				public UpdateLoopType wWvAsBevxHsqtvaIJuSLgaJqAjGk { set; } // 0x00000001808E6210-0x00000001808E62A0
	
				// Nested types
				public abstract class NZqFOhpkTYBQHjwhGNmVuMipjoqc // TypeDefIndex: 6052
				{
					// Constructors
					protected NZqFOhpkTYBQHjwhGNmVuMipjoqc(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public abstract void Reset();
				}
	
				// Constructors
				public gKllCxkHIedBUuUddXdAeLyxxPH(UpdateLoopSetting updateLoopSetting); // 0x00000001808E6020-0x00000001808E6210
	
				// Methods
				public void SmPrdLxmfnoOLIRlFAKVSpooigo(); // 0x00000001808E5F80-0x00000001808E6020
			}
	
			// Constructors
			internal Element(Controller controller, int elementIdentifierId, string name, ControllerElementType type); // 0x00000001808E0D60-0x00000001808E0E50
	
			// Methods
			public void Reset(); // 0x00000001808E0BF0-0x00000001808E0D60
			internal void RQpQdWYFNuHAdFnyRfdbNYEwdSOz(); // 0x00000001808E0BA0-0x00000001808E0BF0
			internal void gYPEWPMgoYJtmuRxUSccfQXOhyF(); // 0x00000001808E0E50-0x00000001808E0EB0
		}
	
		public sealed class Axis : Element // TypeDefIndex: 6053
		{
			// Fields
			internal readonly AxisRange AxikYLhruiOSODJDsEJYTOGYrus; // 0x48
			internal readonly HardwareAxisInfo dRqofzmtaxmVkmGGnZECveoSJWe; // 0x50
	
			// Properties
			public float value { get; } // 0x00000001808BAF50-0x00000001808BB200 
			public float valuePrev { get; } // 0x00000001808BA9E0-0x00000001808BAC90 
			public float valueRaw { get; internal set; } // 0x00000001808BADF0-0x00000001808BAF50 0x00000001808BB2C0-0x00000001808BB400
			public float valueRawPrev { get; } // 0x00000001808BAC90-0x00000001808BADF0 
			public float valueDelta { get; } // 0x00000001808BA920-0x00000001808BA9E0 
			public float valueDeltaRaw { get; } // 0x00000001808BA720-0x00000001808BA920 
			public float lastTimeActive { get; } // 0x00000001808B97D0-0x00000001808B9930 
			public float lastTimeActiveRaw { get; } // 0x00000001808B9670-0x00000001808B97D0 
			public float lastTimeInactive { get; } // 0x00000001808B9A90-0x00000001808B9BF0 
			public float lastTimeInactiveRaw { get; } // 0x00000001808B9930-0x00000001808B9A90 
			public float lastTimeValueChanged { get; } // 0x00000001808B9D50-0x00000001808B9EB0 
			public float lastTimeValueChangedRaw { get; } // 0x00000001808B9BF0-0x00000001808B9D50 
			public float timeActive { get; } // 0x00000001808BA1F0-0x00000001808BA350 
			public float timeActiveRaw { get; } // 0x00000001808BA090-0x00000001808BA1F0 
			public float timeInactive { get; } // 0x00000001808BA550-0x00000001808BA720 
			public float timeInactiveRaw { get; } // 0x00000001808BA350-0x00000001808BA550 
			internal float selfValue { get; } // 0x00000001808B9FA0-0x00000001808BA090 
			internal float selfValuePrev { get; } // 0x00000001808B9EB0-0x00000001808B9FA0 
	
			// Nested types
			internal class nrpsByqfLqXbUsjOXVPnlFCTrju : Element.gKllCxkHIedBUuUddXdAeLyxxPH // TypeDefIndex: 6054
			{
				// Nested types
				public class ydKGSKAotmyHFasBWSVZwhBXYUH : Element.gKllCxkHIedBUuUddXdAeLyxxPH.NZqFOhpkTYBQHjwhGNmVuMipjoqc // TypeDefIndex: 6055
				{
					// Fields
					private const float WCRFThUmXuCzbJONDbQkDXaQXrw = 0.001f; // Metadata: 0x00763FED
					public float PLdosENimxvPBjeGrIWuaBaRuLxb; // 0x10
					public float HktmpbSPOVYjrGTtMaPwVasCJTI; // 0x14
					public float FSXrOGPapUkkgfGpihvezGesBzC; // 0x18
					public float sqEgBCBiRjjFcOEsNWDZBMgBjsD; // 0x1C
					public float soPJYXPotAlKhtuYAhxCtIhzCN; // 0x20
					public float PrRtzwtqkerxZGOBEdEnbLNidDU; // 0x24
					public float wZjKcxIfZZDpQiYmQdDIGAuiLCtl; // 0x28
					public float OOLgefJgTCmrBmLbUFnkcfJJwVLF; // 0x2C
					public float VZbiuHMhdLNBifosAaCXNMmVERc; // 0x30
					public float HdeznedPxjssZpJLnjLWjgDLARwB; // 0x34
					public float kByKRBkYABoEwGLIhIQlGiJKkqgP; // 0x38
					public float mtcVWJPFtSARKlYPJgJrHeZywmC; // 0x3C
	
					// Properties
					public float akdthFYutoDbvRAFvoNDdsgeIPA { get; } // 0x00000001808E78B0-0x00000001808E7930 
					public float jndTDZXOaHkRvIhQbXOvUixaFTu { get; } // 0x00000001808E7830-0x00000001808E78B0 
					public float oaXtXBnkaBvYvwxuufVsUSsdiLp { get; } // 0x00000001808E79B0-0x00000001808E7A30 
					public float GumnViPOfNWsASkIhulbtgJsZsO { get; } // 0x00000001808E7930-0x00000001808E79B0 
	
					// Constructors
					public ydKGSKAotmyHFasBWSVZwhBXYUH(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public void MrPMknIMZzaXDjcXZFUzCeTcWDAs(bool param_0000cb78); // 0x00000001808E75D0-0x00000001808E77D0
					public void ustjKVIgieTYpSnbLmtZWVjTdNY(float param_0000cb79); // 0x00000001808E7A30-0x00000001808E7B00
					public override void Reset(); // 0x00000001808E77D0-0x00000001808E7830
				}
	
				// Constructors
				public nrpsByqfLqXbUsjOXVPnlFCTrju(UpdateLoopSetting updateCycle); // 0x00000001808E62A0-0x00000001808E63F0
			}
	
			// Constructors
			internal Axis(Controller controller, int elementIdentifierId, string name, AxisRange axisRange, HardwareAxisInfo axisInfo); // 0x00000001808B9420-0x00000001808B9670
	
			// Methods
			internal void QWJGvwpIJOczRCgySZZevezUHDn(float param_0000cb6c); // 0x00000001808B9070-0x00000001808B9120
			internal void hqUjXbPdQhNezAIjLHfkcOcGJVU(UpdateLoopType param_0000cb72); // 0x00000001808BB2A0-0x00000001808BB2C0
			internal void YKdbwLVCnKvLBowbragYgaqDiAF(AxisCalibration param_0000cb73); // 0x00000001808B9250-0x00000001808B9380
			internal void YKdbwLVCnKvLBowbragYgaqDiAF(); // 0x00000001808B9380-0x00000001808B9420
			internal void hDkFKubBLMWfBHshwJXYGdErqMu(); // 0x00000001808BB200-0x00000001808BB2A0
			internal void zJCwLvrMemjXxundxiDzcttCetB(); // 0x00000001808BB400-0x00000001808BB4C0
			internal void LWmWbWwpersSuJbuIfaFgzdBatj(float param_0000cb74); // 0x00000001808B8D70-0x00000001808B9070
			internal float ShOHQXOtVItcAxtiSdPVHaNaORV(UpdateLoopType param_0000cb75, AxisCalibration param_0000cb76); // 0x00000001808B9120-0x00000001808B9250
		}
	
		public sealed class Button : Element // TypeDefIndex: 6056
		{
			// Fields
			internal readonly bool EeDLYQiKNGDULrQgtGHrYganhBD; // 0x48
			internal readonly HardwareButtonInfo BhXKcJtDoJtAIMFZndDnVdDSNkc; // 0x50
	
			// Properties
			public bool valuePrev { get; } // 0x00000001808BDD20-0x00000001808BDE80 
			public bool value { get; } // 0x00000001808BDE80-0x00000001808BDFE0 
			public float pressure { get; } // 0x00000001808BD6A0-0x00000001808BD8E0 
			public float pressurePrev { get; } // 0x00000001808BD460-0x00000001808BD6A0 
			public bool isPressureSensitive { get; } // 0x00000001808BC7A0-0x00000001808BC840 
			public bool justPressed { get; } // 0x00000001808BCBC0-0x00000001808BCDC0 
			public bool justReleased { get; } // 0x00000001808BCDC0-0x00000001808BD010 
			public bool justChangedState { get; } // 0x00000001808BC840-0x00000001808BCA40 
			public bool doublePressedAndHeld { get; } // 0x00000001808BC630-0x00000001808BC7A0 
			public bool justDoublePressed { get; } // 0x00000001808BCA40-0x00000001808BCBC0 
			public float timePressed { get; } // 0x00000001808BDA40-0x00000001808BDBB0 
			public float timeUnpressed { get; } // 0x00000001808BDBB0-0x00000001808BDD20 
			public float lastTimePressed { get; } // 0x00000001808BD010-0x00000001808BD180 
			public float lastTimeUnpressed { get; } // 0x00000001808BD2F0-0x00000001808BD460 
			public float lastTimeStateChanged { get; } // 0x00000001808BD180-0x00000001808BD2F0 
			internal ButtonStateFlags state { get; } // 0x00000001808BD8E0-0x00000001808BDA40 
	
			// Nested types
			internal class oMwYBkOFEiripQYUdJBBjGPAJRe : Element.gKllCxkHIedBUuUddXdAeLyxxPH // TypeDefIndex: 6057
			{
				// Nested types
				public class uDyBLFztajyiOHLTJQyDWdEcerl : Element.gKllCxkHIedBUuUddXdAeLyxxPH.NZqFOhpkTYBQHjwhGNmVuMipjoqc // TypeDefIndex: 6058
				{
					// Fields
					public bool PLdosENimxvPBjeGrIWuaBaRuLxb; // 0x10
					public bool HktmpbSPOVYjrGTtMaPwVasCJTI; // 0x11
					public ButtonStateRecorder ZOlAZuNPkNelKJcWCAHKiaGdPtp; // 0x18
					public zbKvqlmGLDZsOtXGfzkwQFPNfbW SntOfeXIJWStrkTtkBxHAwNdQjp; // 0x20
	
					// Constructors
					public uDyBLFztajyiOHLTJQyDWdEcerl(); // 0x00000001808E6A60-0x00000001808E6B10
	
					// Methods
					public void IkSMympyYfTpBxGGBkGOyOMOaezh(bool param_0000cb8c); // 0x00000001808E68B0-0x00000001808E6A20
					public override void Reset(); // 0x00000001808E6A20-0x00000001808E6A60
				}
	
				public class XUtwuXDONFBFAYpUKAMdEjMTOWH : uDyBLFztajyiOHLTJQyDWdEcerl // TypeDefIndex: 6059
				{
					// Fields
					public float otBDqpUNZNMADxFRLNtflZSqYnO; // 0x28
					public float PbGvHUnWNbASzIWzUiMVgBIzctk; // 0x2C
	
					// Constructors
					public XUtwuXDONFBFAYpUKAMdEjMTOWH(); // 0x00000001808E5F70-0x00000001808E5F80
	
					// Methods
					public void IkSMympyYfTpBxGGBkGOyOMOaezh(float param_0000cb8d); // 0x00000001808E5E10-0x00000001808E5F20
					public override void Reset(); // 0x00000001808E5F20-0x00000001808E5F70
				}
	
				// Constructors
				public oMwYBkOFEiripQYUdJBBjGPAJRe(UpdateLoopSetting updateCycle, bool isPressureSensitive); // 0x00000001808E6580-0x00000001808E6720
	
				// Methods
				public void sNNPgwbtvqFUoiXlubbhTxvTGIp(float param_0000cb8b); // 0x00000001808E6720-0x00000001808E68B0
				public void ShKpqWDsLNGwgnLVfZOfKDHTenw(); // 0x00000001808E63F0-0x00000001808E6580
			}
	
			// Constructors
			internal Button(Controller controller, int elementIdentifierId, string name, HardwareButtonInfo buttonInfo); // 0x00000001808BC500-0x00000001808BC630
			internal Button(Controller controller, int elementIdentifierId, string name, bool isPressureSensitive, HardwareButtonInfo buttonInfo); // 0x00000001808BC3D0-0x00000001808BC500
	
			// Methods
			public bool DoublePressedAndHeld(float speed); // 0x00000001808BB4C0-0x00000001808BB730
			public bool JustDoublePressed(float speed); // 0x00000001808BBB00-0x00000001808BBD80
			internal void IkSMympyYfTpBxGGBkGOyOMOaezh(UpdateLoopType param_0000cb85, int param_0000cb86, ControllerDataUpdater param_0000cb87); // 0x00000001808BB730-0x00000001808BBB00
			internal void TBkciYaVDQZnFSVOwktxSNpyOXvc(UpdateLoopType param_0000cb88); // 0x00000001808BC040-0x00000001808BC3D0
			internal void LWmWbWwpersSuJbuIfaFgzdBatj(); // 0x00000001808BBD80-0x00000001808BC040
		}
	
		public abstract class CompoundElement // TypeDefIndex: 6060
		{
			// Fields
			private int ilJvqPoikRsmduZhwvvUegWxsnI; // 0x10
			private string MYcWDFnyndJzsFpKvFFizAMuaiT; // 0x18
			private CompoundControllerElementType qYQtZXCUUQiyGpzdDXLOHBOwcPe; // 0x20
			private int YTYDwGdmGpEbFaMPNISAGnnqKPXP; // 0x24
			private pnJzsEHGFREekdnGNTFGuDKfGvk[] BuwIKNnQECuDvuXrWMqVIxlxRgA; // 0x28
			private Controller VFyAcBdeMMCAMfDOgPwemixrJuYM; // 0x30
			internal readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x38
	
			// Properties
			public int id { get; } // 0x00000001808BEAE0-0x00000001808BEB80 
			public string name { get; } // 0x00000001808BEB80-0x00000001808BEC60 
			public CompoundControllerElementType type { get; } // 0x00000001808BEC60-0x00000001808BED00 
			public bool hasElements { get; } // 0x00000001808BEA40-0x00000001808BEAE0 
			public int elementCount { get; } // 0x00000001808BE8E0-0x00000001808BE980 
			public abstract int elementCapacity { get; }
			public ControllerElementIdentifier elementIdentifier { get; } // 0x00000001808BE980-0x00000001808BEA40 
	
			// Nested types
			private class pnJzsEHGFREekdnGNTFGuDKfGvk // TypeDefIndex: 6061
			{
				// Fields
				public readonly Element bDuDNJMpWydtSCGFbesOhkyhlgiA; // 0x10
				public readonly int OoafPFmbAKFhjaPFYhWyXnQMIEQ; // 0x18
	
				// Constructors
				public pnJzsEHGFREekdnGNTFGuDKfGvk(Element element, int elementIndex); // 0x00000001804164D0-0x0000000180416510
			}
	
			// Constructors
			internal CompoundElement(Controller controller, int elementIdentifierId, string name, CompoundControllerElementType type); // 0x00000001808BE4A0-0x00000001808BE5F0
	
			// Methods
			internal Element UGlMdiDpLKJKtHXHHJEhBRhmhUC(int param_0000cb92); // 0x00000001808BE2B0-0x00000001808BE340
			internal T UGlMdiDpLKJKtHXHHJEhBRhmhUC<T>(int param_0000cb93)
				where T : Element;
			internal T CdtbDBGKfWRBxiYJdMMQImhpjPVn<T>(int param_0000cb94, out int param_0000cb95)
				where T : Element;
			internal bool eMLWHPWlVLcjuKEIpkdHeEbTVNGo(Element param_0000cb96, int param_0000cb97); // 0x00000001808BE5F0-0x00000001808BE8E0
			internal bool WjDodnnnkGABdaGkUAoANfXXqDdB(Element param_0000cb98); // 0x00000001808BE3D0-0x00000001808BE4A0
			internal void UwQeYiGaAcFnYVkJKCkujenGmFRY(); // 0x00000001808BE340-0x00000001808BE3D0
			private int JBZNIUqbswEjAdvJHzevReoISFt(Element param_0000cb99); // 0x00000001808BE1C0-0x00000001808BE2B0
			private bool BfaxGVZdfXrDwXRTVMsXVfQJjoP(Element param_0000cb9a, int param_0000cb9b, int param_0000cb9c); // 0x00000001808BE030-0x00000001808BE1C0
			private bool qyKLmUccLrMtPwfPxgpnBvuscszJ(int param_0000cb9d); // 0x00000001808BED00-0x00000001808BEEF0
			private int xWVZQJEaHRjVQWZdvIhwHcqBIIU(); // 0x00000001808BEEF0-0x00000001808BEF90
		}
	
		public sealed class Axis2D : CompoundElement // TypeDefIndex: 6062
		{
			// Fields
			private const int INjGyVgrQSNvWyNCqSFpjQCSUVih = 2; // Metadata: 0x00763FF1
			private CalibrationMap rFTaGZBlSEdpmUZrxTeQfhZlAuV; // 0x40
	
			// Properties
			public override int elementCapacity { get; } // 0x0000000180411150-0x0000000180411160 
			public Axis xAxis { get; } // 0x00000001808B8530-0x00000001808B85E0 
			public Axis yAxis { get; } // 0x00000001808B85E0-0x00000001808B8690 
			public Vector2 value { get; } // 0x00000001808B8440-0x00000001808B8530 
			public Vector2 valuePrev { get; } // 0x00000001808B8090-0x00000001808B8160 
			public Vector2 valueRaw { get; } // 0x00000001808B82D0-0x00000001808B8440 
			public Vector2 valueRawPrev { get; } // 0x00000001808B8160-0x00000001808B82D0 
	
			// Constructors
			internal Axis2D(Controller controller, int elementIdentifierId, string name, Axis xAxis, Axis yAxis, int xAxisIndex, int yAxisIndex, CalibrationMap calibratonMap); // 0x00000001808B7FD0-0x00000001808B8090
	
			// Methods
			internal void rzuGAfEQNaiaoqemRHAGVezNtDwq(); // 0x00000001808B8B40-0x00000001808B8D70
			private Vector2 oPyaghqkUHEApITnvPYJepJPIGHn(); // 0x00000001808B88F0-0x00000001808B8B40
			private Vector2 oLPMEUuGnvKTBpdmxlvmSmDFdaO(); // 0x00000001808B8690-0x00000001808B88F0
		}
	
		public sealed class Hat : CompoundElement // TypeDefIndex: 6063
		{
			// Fields
			private const int INjGyVgrQSNvWyNCqSFpjQCSUVih = 8; // Metadata: 0x00763FF5
			private const int tVfEykBFGBEmztpedekaswYLuAJ = 0; // Metadata: 0x00763FF9
			private const int AotHUJcjEjMquhSXHsIlZhLfxui = 1; // Metadata: 0x00763FFD
			private const int risFniaOlwEmtqZeneBwHyFsnsaY = 2; // Metadata: 0x00764001
			private const int ODgVMPQmrEuevAVapwiASZwMzFQ = 3; // Metadata: 0x00764005
			private const int nTYkDXiZBjxEYkJlfDEWCEFZuFw = 4; // Metadata: 0x00764009
			private const int lhAlaoCrIGItgIrlMCnVecpGRLc = 5; // Metadata: 0x0076400D
			private const int rFuvUZSuAQWYKyCcBglXnxrmCuC = 6; // Metadata: 0x00764011
			private const int GCYQfDxgicTAMFyuovwqvytsPg = 7; // Metadata: 0x00764015
			private readonly int frWlFJmIuHDCrDwnhgqBkPNnPHK; // 0x40
			private readonly Button[] fjFgJnkphrVLUzcZIWNBokLGbBNJ; // 0x48
			private readonly ReadOnlyCollection<Button> CEHAYvDxPqzPPJoLnHrWKFRLuehV; // 0x50
			private readonly int[] FFclcZyJinSRFeSpKoICXBbvNOP; // 0x58
			private bool hofcIUcsArJRaFowMTZVCzGCgRoY; // 0x60
	
			// Properties
			public override int elementCapacity { get; } // 0x00000001808E2210-0x00000001808E2220 
			public bool force4Way { get; set; } // 0x00000001808E2220-0x00000001808E22C0 0x00000001808E3BD0-0x00000001808E3C90
			public int directionCount { get; } // 0x00000001808E2170-0x00000001808E2210 
			public IList<Button> Buttons { get; } // 0x00000001808E1AE0-0x00000001808E1B90 
			public Button buttonUp { get; } // 0x00000001808E20C0-0x00000001808E2170 
			public Button buttonRight { get; } // 0x00000001808E1EB0-0x00000001808E1F60 
			public Button buttonDown { get; } // 0x00000001808E1D20-0x00000001808E1E00 
			public Button buttonLeft { get; } // 0x00000001808E1E00-0x00000001808E1EB0 
			public Button buttonUpRight { get; } // 0x00000001808E2010-0x00000001808E20C0 
			public Button buttonDownRight { get; } // 0x00000001808E1C70-0x00000001808E1D20 
			public Button buttonDownLeft { get; } // 0x00000001808E1B90-0x00000001808E1C70 
			public Button buttonUpLeft { get; } // 0x00000001808E1F60-0x00000001808E2010 
	
			// Constructors
			internal Hat(Controller controller, int elementIdentifierId, string name, Button[] buttons, int[] buttonIndices); // 0x00000001808E17D0-0x00000001808E1AE0
	
			// Methods
			internal void rzuGAfEQNaiaoqemRHAGVezNtDwq(UpdateLoopType param_0000cbae, ControllerDataUpdater param_0000cbaf); // 0x00000001808E22C0-0x00000001808E3BD0
			private void EBvjhSKOylinfUhrVURoQtjUkDQ(Button param_0000cbb0, int param_0000cbb1, int param_0000cbb2, int param_0000cbb3, UpdateLoopType param_0000cbb4, ControllerDataUpdater param_0000cbb5); // 0x00000001808E12C0-0x00000001808E1650
			private void LpvSiWUbwMTeemJRnbVCWJxidhj(Button param_0000cbb6, int param_0000cbb7, UpdateLoopType param_0000cbb8, ControllerDataUpdater param_0000cbb9); // 0x00000001808E1650-0x00000001808E17D0
		}
	
		[CustomClassObfuscation] // 0x00000001801DDE50-0x00000001801DDE80
		public abstract class Extension // TypeDefIndex: 6064
		{
			// Fields
			private Controller VFyAcBdeMMCAMfDOgPwemixrJuYM; // 0x10
			private IControllerExtensionSource JEVAvDAWidJhVxFUpAPvixPZmfz; // 0x18
			internal readonly int _reInputId; // 0x20
	
			// Properties
			internal bool isJoystickConnected { get; } // 0x00000001808E12B0-0x00000001808E12C0 
			internal bool enabled { get; } // 0x00000001808E11F0-0x00000001808E12B0 
			internal Controller controller { get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			internal Extension(IControllerExtensionSource source); // 0x00000001808E10F0-0x00000001808E11D0
			internal Extension(Extension source); // 0x00000001808E1090-0x00000001808E10F0
	
			// Methods
			internal T GetController<T>()
				where T : Controller;
			internal void SetController(Controller controller); // 0x0000000180379F20-0x0000000180379F30
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal IControllerExtensionSource GetSource(); // 0x0000000180372430-0x0000000180372440
			internal void SetSource(Extension extension); // 0x00000001808E1010-0x00000001808E1090
			private void dBbwxpRxhSnukLMiOidHSbWeUJS(IControllerExtensionSource param_0000cbbe); // 0x00000001808E11D0-0x00000001808E11F0
			internal virtual void Clear(); // 0x00000001803774A0-0x00000001803774B0
			internal abstract void SourceUpdated(IControllerExtensionSource source);
			internal abstract void UpdateData(UpdateLoopType updateLoop);
			internal abstract Extension Clone();
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class wgYsIBAfKvaVPRaazzGbphtmbsi : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6065
		{
			// Fields
			private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
			public Controller gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
			public int ZKnOmfdBGxPCzuiOaEmmaNwByyN; // 0x58
			public int CFzQGIXKxDcukxUiAvbkwQTIlGG; // 0x5C
	
			// Properties
			ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E74E0-0x00000001808E7550 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public wgYsIBAfKvaVPRaazzGbphtmbsi(int <>1__state); // 0x00000001808E7550-0x00000001808E75D0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001808E73A0-0x00000001808E7490
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001808E73A0-0x00000001808E7490
			private bool MoveNext(); // 0x00000001808E7050-0x00000001808E73A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001808E7490-0x00000001808E74E0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class vXWFjxGSpVFgYZdUWFxTXDSoYso : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6066
		{
			// Fields
			private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
			public Controller gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
			public int TQugBPNeqlgCCDlNLspsCnOHCXoe; // 0x58
			public int hYTYPhAiwARQZoGMEyCgRIBJObS; // 0x5C
	
			// Properties
			ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F90-0x00000001808E7000 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public vXWFjxGSpVFgYZdUWFxTXDSoYso(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001808E6DE0-0x00000001808E6F10
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001808E6DE0-0x00000001808E6F10
			private bool MoveNext(); // 0x00000001808E6B10-0x00000001808E6DE0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001808E6F40-0x00000001808E6F90
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		// Constructors
		internal Controller(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, ControllerType type, Guid hardwareTypeGuid, int buttonCount, bool[] isButtonPressureSensitive, HardwareButtonInfo[] hwButtonInfo, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater); // 0x00000001808D9F30-0x00000001808DA730
	
		// Methods
		internal virtual void sEgICXGepTiSOjhLtpsMEEgcpIKA(); // 0x00000001808DBE60-0x00000001808DBEB0
		public virtual Element GetElementById(int elementIdentifierId); // 0x00000001808D7D00-0x00000001808D7E00
		public int GetButtonIndexById(int elementIdentifierId); // 0x00000001808D6C90-0x00000001808D6D60
		public ControllerElementIdentifier GetElementIdentifierById(int elementIdentifierId); // 0x00000001808D7E00-0x00000001808D7ED0
		public virtual bool GetButton(int index); // 0x00000001808D7BD0-0x00000001808D7D00
		public virtual bool GetButtonDown(int index); // 0x00000001808D6B90-0x00000001808D6C90
		public virtual bool GetButtonUp(int index); // 0x00000001808D7AB0-0x00000001808D7BD0
		public virtual bool GetButtonChanged(int index); // 0x00000001808D60A0-0x00000001808D6200
		public virtual bool GetButtonPrev(int index); // 0x00000001808D7320-0x00000001808D7460
		public virtual bool GetButtonDoublePressHold(int index); // 0x00000001808D69A0-0x00000001808D6A70
		public virtual bool GetButtonDoublePressHold(int index, float speed); // 0x00000001808D6850-0x00000001808D69A0
		public virtual bool GetButtonDoublePressDown(int index); // 0x00000001808D6540-0x00000001808D6610
		public virtual bool GetButtonDoublePressDown(int index, float speed); // 0x00000001808D6430-0x00000001808D6540
		public virtual float GetButtonTimePressed(int index); // 0x00000001808D75B0-0x00000001808D76F0
		public virtual float GetButtonTimeUnpressed(int index); // 0x00000001808D7840-0x00000001808D7940
		public virtual float GetButtonLastTimePressed(int index); // 0x00000001808D6E80-0x00000001808D6FC0
		public virtual float GetButtonLastTimeUnpressed(int index); // 0x00000001808D70E0-0x00000001808D71E0
		public virtual bool GetAnyButton(); // 0x00000001808D5E50-0x00000001808D5F80
		public virtual bool GetAnyButtonDown(); // 0x00000001808D5AE0-0x00000001808D5C00
		public virtual bool GetAnyButtonUp(); // 0x00000001808D5D30-0x00000001808D5E50
		public virtual bool GetAnyButtonPrev(); // 0x00000001808D5C00-0x00000001808D5D30
		public virtual bool GetAnyButtonChanged(); // 0x00000001808D59A0-0x00000001808D5AE0
		public virtual bool GetButtonById(int elementIdentifierId); // 0x00000001808D5F80-0x00000001808D60A0
		public virtual bool GetButtonDownById(int elementIdentifierId); // 0x00000001808D6A70-0x00000001808D6B90
		public virtual bool GetButtonUpById(int elementIdentifierId); // 0x00000001808D7940-0x00000001808D7AB0
		public virtual bool GetButtonDoublePressHoldById(int elementIdentifierId, float speed); // 0x00000001808D66F0-0x00000001808D6850
		public virtual bool GetButtonDoublePressDownById(int elementIdentifierId, float speed); // 0x00000001808D6310-0x00000001808D6430
		public virtual bool GetButtonDoublePressHoldById(int elementIdentifierId); // 0x00000001808D6610-0x00000001808D66F0
		public virtual bool GetButtonDoublePressDownById(int elementIdentifierId); // 0x00000001808D6200-0x00000001808D6310
		public virtual bool GetButtonPrevById(int elementIdentifierId); // 0x00000001808D71E0-0x00000001808D7320
		public virtual float GetButtonTimePressedById(int elementIdentifierId); // 0x00000001808D7460-0x00000001808D75B0
		public virtual float GetButtonTimeUnpressedById(int elementIdentifierId); // 0x00000001808D76F0-0x00000001808D7840
		public virtual float GetButtonLastTimePressedById(int elementIdentifierId); // 0x00000001808D6D60-0x00000001808D6E80
		public virtual float GetButtonLastTimeUnpressedById(int elementIdentifierId); // 0x00000001808D6FC0-0x00000001808D70E0
		public virtual ControllerPollingInfo PollForFirstElement(); // 0x00000001808D9810-0x00000001808D9860
		public virtual ControllerPollingInfo PollForFirstElementDown(); // 0x00000001808D97C0-0x00000001808D9810
		public virtual ControllerPollingInfo PollForFirstButton(); // 0x00000001808D95C0-0x00000001808D97C0
		public virtual ControllerPollingInfo PollForFirstButtonDown(); // 0x00000001808D93A0-0x00000001808D95C0
		public virtual IEnumerable<ControllerPollingInfo> PollForAllElements(); // 0x00000001808D9380-0x00000001808D93A0
		public virtual IEnumerable<ControllerPollingInfo> PollForAllElementsDown(); // 0x00000001808D9360-0x00000001808D9380
		public virtual IEnumerable<ControllerPollingInfo> PollForAllButtons(); // 0x00000001808D92F0-0x00000001808D9360
		public virtual IEnumerable<ControllerPollingInfo> PollForAllButtonsDown(); // 0x00000001808D9270-0x00000001808D92F0
		private bool PoSJNfCUyVaNtAgYxHsJRuyKbJw(int param_0000cb45, out int param_0000cb46); // 0x00000001808D9130-0x00000001808D9270
		private bool TbDgiVXBBKKrkhRtBqROOVnNfYG(int param_0000cb47, out int param_0000cb48); // 0x00000001808D9930-0x00000001808D9A70
		protected void UpdatePollingFrameTracking(); // 0x00000001808D9D60-0x00000001808D9F30
		public virtual float GetLastTimeActive(); // 0x00000001808D8100-0x00000001808D81B0
		public virtual float GetLastTimeActive(bool useRawValues); // 0x00000001808D7ED0-0x00000001808D8100
		public virtual float GetLastTimeAnyElementChanged(); // 0x00000001808D8640-0x00000001808D86F0
		public virtual float GetLastTimeAnyElementChanged(bool useRawValues); // 0x00000001808D86F0-0x00000001808D87A0
		public float GetLastTimeAnyButtonPressed(); // 0x00000001808D84A0-0x00000001808D8640
		public float GetLastTimeAnyButtonChanged(); // 0x00000001808D81B0-0x00000001808D84A0
		public T GetExtension<T>()
			where T : class;
		public IControllerTemplate GetTemplate(Guid typeGuid); // 0x00000001808D87A0-0x00000001808D8A10
		public IControllerTemplate GetTemplate(Type type); // 0x00000001808D8A10-0x00000001808D8BC0
		public T GetTemplate<T>()
			where T : class;
		public bool ImplementsTemplate(Guid typeGuid); // 0x00000001808D8D50-0x00000001808D8F90
		public bool ImplementsTemplate(Type type); // 0x00000001808D8BC0-0x00000001808D8D50
		public bool ImplementsTemplate<T>()
			where T : class;
		internal void zgMhriHysuIjQRrMQrjIuyxmseb(IControllerTemplate[] param_0000cb4f); // 0x00000001808DC1C0-0x00000001808DC240
		internal virtual void UpdateData(UpdateLoopType param_0000cb50); // 0x00000001808D9A70-0x00000001808D9D60
		internal virtual ButtonStateFlags ooPkXeSnzrhNmNGPIQyYywRrCHh(int param_0000cb51); // 0x00000001808DBB10-0x00000001808DBCD0
		internal void yfRWsfTQXyegFbUdQIKkIniCckQk(Extension param_0000cb52); // 0x00000001808DC0B0-0x00000001808DC190
		internal void qFQGYVdEHFJPtRNQyKVVNRpsaCz(Extension param_0000cb53); // 0x00000001808DBCD0-0x00000001808DBDD0
		internal virtual void Clear(); // 0x00000001808D5690-0x00000001808D5820
		internal virtual bool SetEnabled(bool param_0000cb54); // 0x00000001808D9860-0x00000001808D9930
		internal virtual void BakeMap(ControllerMap param_0000cb55); // 0x00000001808D5530-0x00000001808D5690
		internal virtual void BakeActionElementMap(ControllerMap param_0000cb56, ActionElementMap param_0000cb57); // 0x00000001808D54D0-0x00000001808D5530
		internal bool nHiArjzVQQIMIkkfpIeGhBgwpOxe(ActionElementMap param_0000cb58, int param_0000cb59, out float param_0000cb5a, out bool param_0000cb5b); // 0x00000001808DB7F0-0x00000001808DBB10
		internal bool nHiArjzVQQIMIkkfpIeGhBgwpOxe(ActionElementMap param_0000cb5c, int param_0000cb5d, bool param_0000cb5e, out float param_0000cb5f); // 0x00000001808DB700-0x00000001808DB7F0
		internal void eMLWHPWlVLcjuKEIpkdHeEbTVNGo(Element param_0000cb60); // 0x00000001808DA7C0-0x00000001808DA840
		internal virtual Guid GQambcIsXAcazlWWAnqpteoiGUs(); // 0x00000001808D5930-0x00000001808D59A0
		protected virtual void Connected(); // 0x00000001808D5820-0x00000001808D5830
		protected virtual void Disconnected(); // 0x00000001808D5830-0x00000001808D5930
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static bool zcRiFyiFzElCKwOQLcDjHhleHSjh(Controller param_0000cb61, Guid param_0000cb62); // 0x00000001808DC190-0x00000001808DC1C0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static bool JAjEgZtpLqzokVDaKdCvEstTswP(Controller param_0000cb63, Type param_0000cb64); // 0x00000001808D8F90-0x00000001808D9130
	}
}

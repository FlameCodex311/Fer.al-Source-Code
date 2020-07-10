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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public abstract class Controller // TypeDefIndex: 5890
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Func<Controller, Guid, bool> CWjBcSiUYzmlMwepxVNqomArHSvB; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Func<Controller, Type, bool> TjGEBsHFMVCHUCaUrhTtAyNgOuoQ; // 0x18
	
		// Properties
		internal bool wasPollingPrev { get; } // 0x0000000180454C30-0x0000000180454CA0 
		public bool enabled { get; set; } // 0x0000000180454320-0x00000001804543C0 0x0000000180455490-0x00000001804554B0
		public string name { get; internal set; } // 0x0000000180454970-0x0000000180454A20 0x000000018036AC90-0x000000018036ACA0
		public string tag { get; set; } // 0x0000000180454A20-0x0000000180454AD0 0x00000001804555C0-0x0000000180455690
		public string hardwareName { get; } // 0x0000000180454510-0x00000001804545F0 
		public ControllerType type { get; } // 0x0000000180454B90-0x0000000180454C30 
		public Guid hardwareTypeGuid { get; } // 0x00000001804545F0-0x00000001804546D0 
		public abstract Guid deviceInstanceGuid { get; }
		public ControllerIdentifier identifier { get; } // 0x00000001804546D0-0x00000001804546F0 
		public bool isConnected { get; internal set; } // 0x0000000180454850-0x00000001804548F0 0x00000001804554B0-0x00000001804555C0
		public string hardwareIdentifier { get; } // 0x0000000180454460-0x0000000180454510 
		public string mapTypeString { get; } // 0x00000001804548F0-0x0000000180454970 
		public int elementCount { get; } // 0x0000000180454260-0x0000000180454320 
		public int buttonCount { get; } // 0x0000000180454190-0x0000000180454260 
		public IList<Element> Elements { get; } // 0x0000000180454030-0x00000001804540E0 
		public IList<Button> Buttons { get; } // 0x0000000180453EC0-0x0000000180453F70 
		public Extension extension { get; } // 0x00000001804543C0-0x0000000180454460 
		public IList<ControllerElementIdentifier> ElementIdentifiers { get; } // 0x0000000180453F70-0x0000000180454030 
		public IList<ControllerElementIdentifier> ButtonElementIdentifiers { get; } // 0x0000000180453DD0-0x0000000180453EC0 
		public IList<IControllerTemplate> Templates { get; } // 0x00000001804540E0-0x0000000180454190 
		public int templateCount { get; } // 0x0000000180454AD0-0x0000000180454B90 
		internal static Func<Controller, Guid, bool> implementsTemplateDelegate_Guid { get; } // 0x00000001804546F0-0x0000000180454790 
		internal static Func<Controller, Type, bool> implementsTemplateDelegate_Type { get; } // 0x0000000180454790-0x0000000180454850 
	
		// Events
		internal event Action<bool> EnabledStateChangedEvent {
			add; // 0x0000000180453CC0-0x0000000180453D50
			remove; // 0x00000001804553B0-0x0000000180455440
		}
	
		// Nested types
		public abstract class Element // TypeDefIndex: 5891
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
			public ControllerElementIdentifier elementIdentifier { get; } // 0x000000018045A400-0x000000018045A4C0 
			public bool isMemberElement { get; } // 0x000000018045A4C0-0x000000018045A560 
	
			// Nested types
			internal abstract class gKllCxkHIedBUuUddXdAeLyxxPH // TypeDefIndex: 5892
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
				public IList<NZqFOhpkTYBQHjwhGNmVuMipjoqc> sswPLpxFhWaHaJPpqMOtHCHzCGfx { get; } // 0x0000000180369BB0-0x0000000180369BC0 
				public UpdateLoopType wWvAsBevxHsqtvaIJuSLgaJqAjGk { set; } // 0x000000018045F9B0-0x000000018045FA50
	
				// Nested types
				public abstract class NZqFOhpkTYBQHjwhGNmVuMipjoqc // TypeDefIndex: 5893
				{
					// Constructors
					protected NZqFOhpkTYBQHjwhGNmVuMipjoqc(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public abstract void Reset();
				}
	
				// Constructors
				public gKllCxkHIedBUuUddXdAeLyxxPH(UpdateLoopSetting updateLoopSetting); // 0x000000018045F7B0-0x000000018045F9B0
	
				// Methods
				public void SmPrdLxmfnoOLIRlFAKVSpooigo(); // 0x000000018045F710-0x000000018045F7B0
			}
	
			// Constructors
			internal Element(Controller controller, int elementIdentifierId, string name, ControllerElementType type); // 0x000000018045A2B0-0x000000018045A3A0
	
			// Methods
			public void Reset(); // 0x000000018045A140-0x000000018045A2B0
			internal void RQpQdWYFNuHAdFnyRfdbNYEwdSOz(); // 0x000000018045A0F0-0x000000018045A140
			internal void gYPEWPMgoYJtmuRxUSccfQXOhyF(); // 0x000000018045A3A0-0x000000018045A400
		}
	
		public sealed class Axis : Element // TypeDefIndex: 5894
		{
			// Fields
			internal readonly AxisRange AxikYLhruiOSODJDsEJYTOGYrus; // 0x48
			internal readonly HardwareAxisInfo dRqofzmtaxmVkmGGnZECveoSJWe; // 0x50
	
			// Properties
			public float value { get; } // 0x0000000180433C40-0x0000000180433F00 
			public float valuePrev { get; } // 0x00000001804336C0-0x0000000180433980 
			public float valueRaw { get; internal set; } // 0x0000000180433AE0-0x0000000180433C40 0x0000000180433FD0-0x0000000180434120
			public float valueRawPrev { get; } // 0x0000000180433980-0x0000000180433AE0 
			public float valueDelta { get; } // 0x0000000180433600-0x00000001804336C0 
			public float valueDeltaRaw { get; } // 0x0000000180433400-0x0000000180433600 
			public float lastTimeActive { get; } // 0x00000001804324B0-0x0000000180432610 
			public float lastTimeActiveRaw { get; } // 0x0000000180432350-0x00000001804324B0 
			public float lastTimeInactive { get; } // 0x0000000180432770-0x00000001804328D0 
			public float lastTimeInactiveRaw { get; } // 0x0000000180432610-0x0000000180432770 
			public float lastTimeValueChanged { get; } // 0x0000000180432A30-0x0000000180432B90 
			public float lastTimeValueChangedRaw { get; } // 0x00000001804328D0-0x0000000180432A30 
			public float timeActive { get; } // 0x0000000180432ED0-0x0000000180433030 
			public float timeActiveRaw { get; } // 0x0000000180432D70-0x0000000180432ED0 
			public float timeInactive { get; } // 0x0000000180433230-0x0000000180433400 
			public float timeInactiveRaw { get; } // 0x0000000180433030-0x0000000180433230 
			internal float selfValue { get; } // 0x0000000180432C80-0x0000000180432D70 
			internal float selfValuePrev { get; } // 0x0000000180432B90-0x0000000180432C80 
	
			// Nested types
			internal class nrpsByqfLqXbUsjOXVPnlFCTrju : Element.gKllCxkHIedBUuUddXdAeLyxxPH // TypeDefIndex: 5895
			{
				// Nested types
				public class ydKGSKAotmyHFasBWSVZwhBXYUH : Element.gKllCxkHIedBUuUddXdAeLyxxPH.NZqFOhpkTYBQHjwhGNmVuMipjoqc // TypeDefIndex: 5896
				{
					// Fields
					private const float WCRFThUmXuCzbJONDbQkDXaQXrw = 0.001f; // Metadata: 0x0072F350
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
					public float akdthFYutoDbvRAFvoNDdsgeIPA { get; } // 0x00000001804610C0-0x0000000180461140 
					public float jndTDZXOaHkRvIhQbXOvUixaFTu { get; } // 0x0000000180461040-0x00000001804610C0 
					public float oaXtXBnkaBvYvwxuufVsUSsdiLp { get; } // 0x00000001804611C0-0x0000000180461240 
					public float GumnViPOfNWsASkIhulbtgJsZsO { get; } // 0x0000000180461140-0x00000001804611C0 
	
					// Constructors
					public ydKGSKAotmyHFasBWSVZwhBXYUH(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public void MrPMknIMZzaXDjcXZFUzCeTcWDAs(bool param_0000c908); // 0x0000000180460DE0-0x0000000180460FE0
					public void ustjKVIgieTYpSnbLmtZWVjTdNY(float param_0000c909); // 0x0000000180461240-0x0000000180461310
					public override void Reset(); // 0x0000000180460FE0-0x0000000180461040
				}
	
				// Constructors
				public nrpsByqfLqXbUsjOXVPnlFCTrju(UpdateLoopSetting updateCycle); // 0x000000018045FA50-0x000000018045FBB0
			}
	
			// Constructors
			internal Axis(Controller controller, int elementIdentifierId, string name, AxisRange axisRange, HardwareAxisInfo axisInfo); // 0x0000000180432100-0x0000000180432350
	
			// Methods
			internal void QWJGvwpIJOczRCgySZZevezUHDn(float param_0000c8fc); // 0x0000000180431D30-0x0000000180431DE0
			internal void hqUjXbPdQhNezAIjLHfkcOcGJVU(UpdateLoopType param_0000c902); // 0x0000000180433FB0-0x0000000180433FD0
			internal void YKdbwLVCnKvLBowbragYgaqDiAF(AxisCalibration param_0000c903); // 0x0000000180431F20-0x0000000180432050
			internal void YKdbwLVCnKvLBowbragYgaqDiAF(); // 0x0000000180432050-0x0000000180432100
			internal void hDkFKubBLMWfBHshwJXYGdErqMu(); // 0x0000000180433F00-0x0000000180433FB0
			internal void zJCwLvrMemjXxundxiDzcttCetB(); // 0x0000000180434120-0x00000001804341E0
			internal void LWmWbWwpersSuJbuIfaFgzdBatj(float param_0000c904); // 0x0000000180431A20-0x0000000180431D30
			internal float ShOHQXOtVItcAxtiSdPVHaNaORV(UpdateLoopType param_0000c905, AxisCalibration param_0000c906); // 0x0000000180431DE0-0x0000000180431F20
		}
	
		public sealed class Button : Element // TypeDefIndex: 5897
		{
			// Fields
			internal readonly bool EeDLYQiKNGDULrQgtGHrYganhBD; // 0x48
			internal readonly HardwareButtonInfo BhXKcJtDoJtAIMFZndDnVdDSNkc; // 0x50
	
			// Properties
			public bool valuePrev { get; } // 0x0000000180436AC0-0x0000000180436C20 
			public bool value { get; } // 0x0000000180436C20-0x0000000180436D80 
			public float pressure { get; } // 0x0000000180436430-0x0000000180436670 
			public float pressurePrev { get; } // 0x00000001804361F0-0x0000000180436430 
			public bool isPressureSensitive { get; } // 0x0000000180435510-0x00000001804355B0 
			public bool justPressed { get; } // 0x0000000180435940-0x0000000180435B50 
			public bool justReleased { get; } // 0x0000000180435B50-0x0000000180435DA0 
			public bool justChangedState { get; } // 0x00000001804355B0-0x00000001804357C0 
			public bool doublePressedAndHeld { get; } // 0x00000001804353A0-0x0000000180435510 
			public bool justDoublePressed { get; } // 0x00000001804357C0-0x0000000180435940 
			public float timePressed { get; } // 0x00000001804367E0-0x0000000180436950 
			public float timeUnpressed { get; } // 0x0000000180436950-0x0000000180436AC0 
			public float lastTimePressed { get; } // 0x0000000180435DA0-0x0000000180435F10 
			public float lastTimeUnpressed { get; } // 0x0000000180436080-0x00000001804361F0 
			public float lastTimeStateChanged { get; } // 0x0000000180435F10-0x0000000180436080 
			internal ButtonStateFlags state { get; } // 0x0000000180436670-0x00000001804367E0 
	
			// Nested types
			internal class oMwYBkOFEiripQYUdJBBjGPAJRe : Element.gKllCxkHIedBUuUddXdAeLyxxPH // TypeDefIndex: 5898
			{
				// Nested types
				public class uDyBLFztajyiOHLTJQyDWdEcerl : Element.gKllCxkHIedBUuUddXdAeLyxxPH.NZqFOhpkTYBQHjwhGNmVuMipjoqc // TypeDefIndex: 5899
				{
					// Fields
					public bool PLdosENimxvPBjeGrIWuaBaRuLxb; // 0x10
					public bool HktmpbSPOVYjrGTtMaPwVasCJTI; // 0x11
					public ButtonStateRecorder ZOlAZuNPkNelKJcWCAHKiaGdPtp; // 0x18
					public zbKvqlmGLDZsOtXGfzkwQFPNfbW SntOfeXIJWStrkTtkBxHAwNdQjp; // 0x20
	
					// Constructors
					public uDyBLFztajyiOHLTJQyDWdEcerl(); // 0x0000000180460250-0x0000000180460300
	
					// Methods
					public void IkSMympyYfTpBxGGBkGOyOMOaezh(bool param_0000c91c); // 0x00000001804600A0-0x0000000180460210
					public override void Reset(); // 0x0000000180460210-0x0000000180460250
				}
	
				public class XUtwuXDONFBFAYpUKAMdEjMTOWH : uDyBLFztajyiOHLTJQyDWdEcerl // TypeDefIndex: 5900
				{
					// Fields
					public float otBDqpUNZNMADxFRLNtflZSqYnO; // 0x28
					public float PbGvHUnWNbASzIWzUiMVgBIzctk; // 0x2C
	
					// Constructors
					public XUtwuXDONFBFAYpUKAMdEjMTOWH(); // 0x000000018045F700-0x000000018045F710
	
					// Methods
					public void IkSMympyYfTpBxGGBkGOyOMOaezh(float param_0000c91d); // 0x000000018045F5A0-0x000000018045F6B0
					public override void Reset(); // 0x000000018045F6B0-0x000000018045F700
				}
	
				// Constructors
				public oMwYBkOFEiripQYUdJBBjGPAJRe(UpdateLoopSetting updateCycle, bool isPressureSensitive); // 0x000000018045FD50-0x000000018045FF00
	
				// Methods
				public void sNNPgwbtvqFUoiXlubbhTxvTGIp(float param_0000c91b); // 0x000000018045FF00-0x00000001804600A0
				public void ShKpqWDsLNGwgnLVfZOfKDHTenw(); // 0x000000018045FBB0-0x000000018045FD50
			}
	
			// Constructors
			internal Button(Controller controller, int elementIdentifierId, string name, HardwareButtonInfo buttonInfo); // 0x0000000180435270-0x00000001804353A0
			internal Button(Controller controller, int elementIdentifierId, string name, bool isPressureSensitive, HardwareButtonInfo buttonInfo); // 0x0000000180435140-0x0000000180435270
	
			// Methods
			public bool DoublePressedAndHeld(float speed); // 0x00000001804341E0-0x0000000180434460
			public bool JustDoublePressed(float speed); // 0x0000000180434840-0x0000000180434AD0
			internal void IkSMympyYfTpBxGGBkGOyOMOaezh(UpdateLoopType param_0000c915, int param_0000c916, ControllerDataUpdater param_0000c917); // 0x0000000180434460-0x0000000180434840
			internal void TBkciYaVDQZnFSVOwktxSNpyOXvc(UpdateLoopType param_0000c918); // 0x0000000180434DA0-0x0000000180435140
			internal void LWmWbWwpersSuJbuIfaFgzdBatj(); // 0x0000000180434AD0-0x0000000180434DA0
		}
	
		public abstract class CompoundElement // TypeDefIndex: 5901
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
			public int id { get; } // 0x00000001804378C0-0x0000000180437960 
			public string name { get; } // 0x0000000180437960-0x0000000180437A40 
			public CompoundControllerElementType type { get; } // 0x0000000180437A40-0x0000000180437AE0 
			public bool hasElements { get; } // 0x0000000180437820-0x00000001804378C0 
			public int elementCount { get; } // 0x00000001804376C0-0x0000000180437760 
			public abstract int elementCapacity { get; }
			public ControllerElementIdentifier elementIdentifier { get; } // 0x0000000180437760-0x0000000180437820 
	
			// Nested types
			private class pnJzsEHGFREekdnGNTFGuDKfGvk // TypeDefIndex: 5902
			{
				// Fields
				public readonly Element bDuDNJMpWydtSCGFbesOhkyhlgiA; // 0x10
				public readonly int OoafPFmbAKFhjaPFYhWyXnQMIEQ; // 0x18
	
				// Constructors
				public pnJzsEHGFREekdnGNTFGuDKfGvk(Element element, int elementIndex); // 0x0000000180367610-0x0000000180367650
			}
	
			// Constructors
			internal CompoundElement(Controller controller, int elementIdentifierId, string name, CompoundControllerElementType type); // 0x0000000180437270-0x00000001804373C0
	
			// Methods
			internal Element UGlMdiDpLKJKtHXHHJEhBRhmhUC(int param_0000c922); // 0x0000000180437070-0x0000000180437110
			internal T UGlMdiDpLKJKtHXHHJEhBRhmhUC<T>(int param_0000c923)
				where T : Element;
			internal T CdtbDBGKfWRBxiYJdMMQImhpjPVn<T>(int param_0000c924, out int param_0000c925)
				where T : Element;
			internal bool eMLWHPWlVLcjuKEIpkdHeEbTVNGo(Element param_0000c926, int param_0000c927); // 0x00000001804373C0-0x00000001804376C0
			internal bool WjDodnnnkGABdaGkUAoANfXXqDdB(Element param_0000c928); // 0x00000001804371A0-0x0000000180437270
			internal void UwQeYiGaAcFnYVkJKCkujenGmFRY(); // 0x0000000180437110-0x00000001804371A0
			private int JBZNIUqbswEjAdvJHzevReoISFt(Element param_0000c929); // 0x0000000180436F70-0x0000000180437070
			private bool BfaxGVZdfXrDwXRTVMsXVfQJjoP(Element param_0000c92a, int param_0000c92b, int param_0000c92c); // 0x0000000180436DD0-0x0000000180436F70
			private bool qyKLmUccLrMtPwfPxgpnBvuscszJ(int param_0000c92d); // 0x0000000180437AE0-0x0000000180437CF0
			private int xWVZQJEaHRjVQWZdvIhwHcqBIIU(); // 0x0000000180437CF0-0x0000000180437D90
		}
	
		public sealed class Axis2D : CompoundElement // TypeDefIndex: 5903
		{
			// Fields
			private const int INjGyVgrQSNvWyNCqSFpjQCSUVih = 2; // Metadata: 0x0072F354
			private CalibrationMap rFTaGZBlSEdpmUZrxTeQfhZlAuV; // 0x40
	
			// Properties
			public override int elementCapacity { get; } // 0x0000000180362180-0x0000000180362190 
			public Axis xAxis { get; } // 0x00000001804311E0-0x0000000180431290 
			public Axis yAxis { get; } // 0x0000000180431290-0x0000000180431340 
			public Vector2 value { get; } // 0x00000001804310F0-0x00000001804311E0 
			public Vector2 valuePrev { get; } // 0x0000000180430D40-0x0000000180430E10 
			public Vector2 valueRaw { get; } // 0x0000000180430F80-0x00000001804310F0 
			public Vector2 valueRawPrev { get; } // 0x0000000180430E10-0x0000000180430F80 
	
			// Constructors
			internal Axis2D(Controller controller, int elementIdentifierId, string name, Axis xAxis, Axis yAxis, int xAxisIndex, int yAxisIndex, CalibrationMap calibratonMap); // 0x0000000180430C80-0x0000000180430D40
	
			// Methods
			internal void rzuGAfEQNaiaoqemRHAGVezNtDwq(); // 0x00000001804317F0-0x0000000180431A20
			private Vector2 oPyaghqkUHEApITnvPYJepJPIGHn(); // 0x00000001804315A0-0x00000001804317F0
			private Vector2 oLPMEUuGnvKTBpdmxlvmSmDFdaO(); // 0x0000000180431340-0x00000001804315A0
		}
	
		public sealed class Hat : CompoundElement // TypeDefIndex: 5904
		{
			// Fields
			private const int INjGyVgrQSNvWyNCqSFpjQCSUVih = 8; // Metadata: 0x0072F358
			private const int tVfEykBFGBEmztpedekaswYLuAJ = 0; // Metadata: 0x0072F35C
			private const int AotHUJcjEjMquhSXHsIlZhLfxui = 1; // Metadata: 0x0072F360
			private const int risFniaOlwEmtqZeneBwHyFsnsaY = 2; // Metadata: 0x0072F364
			private const int ODgVMPQmrEuevAVapwiASZwMzFQ = 3; // Metadata: 0x0072F368
			private const int nTYkDXiZBjxEYkJlfDEWCEFZuFw = 4; // Metadata: 0x0072F36C
			private const int lhAlaoCrIGItgIrlMCnVecpGRLc = 5; // Metadata: 0x0072F370
			private const int rFuvUZSuAQWYKyCcBglXnxrmCuC = 6; // Metadata: 0x0072F374
			private const int GCYQfDxgicTAMFyuovwqvytsPg = 7; // Metadata: 0x0072F378
			private readonly int frWlFJmIuHDCrDwnhgqBkPNnPHK; // 0x40
			private readonly Button[] fjFgJnkphrVLUzcZIWNBokLGbBNJ; // 0x48
			private readonly ReadOnlyCollection<Button> CEHAYvDxPqzPPJoLnHrWKFRLuehV; // 0x50
			private readonly int[] FFclcZyJinSRFeSpKoICXBbvNOP; // 0x58
			private bool hofcIUcsArJRaFowMTZVCzGCgRoY; // 0x60
	
			// Properties
			public override int elementCapacity { get; } // 0x000000018045B7B0-0x000000018045B7C0 
			public bool force4Way { get; set; } // 0x000000018045B7C0-0x000000018045B860 0x000000018045D310-0x000000018045D3D0
			public int directionCount { get; } // 0x000000018045B710-0x000000018045B7B0 
			public IList<Button> Buttons { get; } // 0x000000018045B080-0x000000018045B130 
			public Button buttonUp { get; } // 0x000000018045B660-0x000000018045B710 
			public Button buttonRight { get; } // 0x000000018045B450-0x000000018045B500 
			public Button buttonDown { get; } // 0x000000018045B2C0-0x000000018045B3A0 
			public Button buttonLeft { get; } // 0x000000018045B3A0-0x000000018045B450 
			public Button buttonUpRight { get; } // 0x000000018045B5B0-0x000000018045B660 
			public Button buttonDownRight { get; } // 0x000000018045B210-0x000000018045B2C0 
			public Button buttonDownLeft { get; } // 0x000000018045B130-0x000000018045B210 
			public Button buttonUpLeft { get; } // 0x000000018045B500-0x000000018045B5B0 
	
			// Constructors
			internal Hat(Controller controller, int elementIdentifierId, string name, Button[] buttons, int[] buttonIndices); // 0x000000018045AD60-0x000000018045B080
	
			// Methods
			internal void rzuGAfEQNaiaoqemRHAGVezNtDwq(UpdateLoopType param_0000c93e, ControllerDataUpdater param_0000c93f); // 0x000000018045B860-0x000000018045D310
			private void EBvjhSKOylinfUhrVURoQtjUkDQ(Button param_0000c940, int param_0000c941, int param_0000c942, int param_0000c943, UpdateLoopType param_0000c944, ControllerDataUpdater param_0000c945); // 0x000000018045A810-0x000000018045ABD0
			private void LpvSiWUbwMTeemJRnbVCWJxidhj(Button param_0000c946, int param_0000c947, UpdateLoopType param_0000c948, ControllerDataUpdater param_0000c949); // 0x000000018045ABD0-0x000000018045AD60
		}
	
		[CustomClassObfuscation] // 0x00000001800C10A0-0x00000001800C10D0
		public abstract class Extension // TypeDefIndex: 5905
		{
			// Fields
			private Controller VFyAcBdeMMCAMfDOgPwemixrJuYM; // 0x10
			private IControllerExtensionSource JEVAvDAWidJhVxFUpAPvixPZmfz; // 0x18
			internal readonly int _reInputId; // 0x20
	
			// Properties
			internal bool isJoystickConnected { get; } // 0x000000018045A800-0x000000018045A810 
			internal bool enabled { get; } // 0x000000018045A740-0x000000018045A800 
			internal Controller controller { get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			internal Extension(IControllerExtensionSource source); // 0x000000018045A640-0x000000018045A720
			internal Extension(Extension source); // 0x000000018045A5E0-0x000000018045A640
	
			// Methods
			internal T GetController<T>()
				where T : Controller;
			internal void SetController(Controller controller); // 0x000000018036B1E0-0x000000018036B1F0
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal IControllerExtensionSource GetSource(); // 0x000000018038B150-0x000000018038B160
			internal void SetSource(Extension extension); // 0x000000018045A560-0x000000018045A5E0
			private void dBbwxpRxhSnukLMiOidHSbWeUJS(IControllerExtensionSource param_0000c94e); // 0x000000018045A720-0x000000018045A740
			internal virtual void Clear(); // 0x00000001803581E0-0x00000001803581F0
			internal abstract void SourceUpdated(IControllerExtensionSource source);
			internal abstract void UpdateData(UpdateLoopType updateLoop);
			internal abstract Extension Clone();
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class wgYsIBAfKvaVPRaazzGbphtmbsi : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 5906
		{
			// Fields
			private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
			public Controller gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
			public int ZKnOmfdBGxPCzuiOaEmmaNwByyN; // 0x58
			public int CFzQGIXKxDcukxUiAvbkwQTIlGG; // 0x5C
	
			// Properties
			ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460CF0-0x0000000180460D60 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public wgYsIBAfKvaVPRaazzGbphtmbsi(int <>1__state); // 0x0000000180460D60-0x0000000180460DE0
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180460BA0-0x0000000180460CA0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180460BA0-0x0000000180460CA0
			private bool MoveNext(); // 0x0000000180460850-0x0000000180460BA0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180460CA0-0x0000000180460CF0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class vXWFjxGSpVFgYZdUWFxTXDSoYso : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 5907
		{
			// Fields
			private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
			public Controller gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
			public int TQugBPNeqlgCCDlNLspsCnOHCXoe; // 0x58
			public int hYTYPhAiwARQZoGMEyCgRIBJObS; // 0x5C
	
			// Properties
			ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460790-0x0000000180460800 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public vXWFjxGSpVFgYZdUWFxTXDSoYso(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001804605D0-0x0000000180460710
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001804605D0-0x0000000180460710
			private bool MoveNext(); // 0x0000000180460300-0x00000001804605D0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180460740-0x0000000180460790
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		// Constructors
		internal Controller(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, ControllerType type, Guid hardwareTypeGuid, int buttonCount, bool[] isButtonPressureSensitive, HardwareButtonInfo[] hwButtonInfo, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater); // 0x0000000180453490-0x0000000180453CC0
	
		// Methods
		internal virtual void sEgICXGepTiSOjhLtpsMEEgcpIKA(); // 0x0000000180455440-0x0000000180455490
		public virtual Element GetElementById(int elementIdentifierId); // 0x0000000180451230-0x0000000180451330
		public int GetButtonIndexById(int elementIdentifierId); // 0x00000001804501B0-0x0000000180450280
		public ControllerElementIdentifier GetElementIdentifierById(int elementIdentifierId); // 0x0000000180451330-0x0000000180451400
		public virtual bool GetButton(int index); // 0x0000000180451100-0x0000000180451230
		public virtual bool GetButtonDown(int index); // 0x00000001804500B0-0x00000001804501B0
		public virtual bool GetButtonUp(int index); // 0x0000000180450FE0-0x0000000180451100
		public virtual bool GetButtonChanged(int index); // 0x000000018044F590-0x000000018044F700
		public virtual bool GetButtonPrev(int index); // 0x0000000180450840-0x0000000180450980
		public virtual bool GetButtonDoublePressHold(int index); // 0x000000018044FEC0-0x000000018044FF90
		public virtual bool GetButtonDoublePressHold(int index, float speed); // 0x000000018044FD70-0x000000018044FEC0
		public virtual bool GetButtonDoublePressDown(int index); // 0x000000018044FA50-0x000000018044FB20
		public virtual bool GetButtonDoublePressDown(int index, float speed); // 0x000000018044F930-0x000000018044FA50
		public virtual float GetButtonTimePressed(int index); // 0x0000000180450AE0-0x0000000180450C20
		public virtual float GetButtonTimeUnpressed(int index); // 0x0000000180450D70-0x0000000180450E70
		public virtual float GetButtonLastTimePressed(int index); // 0x00000001804503A0-0x00000001804504E0
		public virtual float GetButtonLastTimeUnpressed(int index); // 0x0000000180450600-0x0000000180450700
		public virtual bool GetAnyButton(); // 0x000000018044F330-0x000000018044F470
		public virtual bool GetAnyButtonDown(); // 0x000000018044EFA0-0x000000018044F0D0
		public virtual bool GetAnyButtonUp(); // 0x000000018044F200-0x000000018044F330
		public virtual bool GetAnyButtonPrev(); // 0x000000018044F0D0-0x000000018044F200
		public virtual bool GetAnyButtonChanged(); // 0x000000018044EE60-0x000000018044EFA0
		public virtual bool GetButtonById(int elementIdentifierId); // 0x000000018044F470-0x000000018044F590
		public virtual bool GetButtonDownById(int elementIdentifierId); // 0x000000018044FF90-0x00000001804500B0
		public virtual bool GetButtonUpById(int elementIdentifierId); // 0x0000000180450E70-0x0000000180450FE0
		public virtual bool GetButtonDoublePressHoldById(int elementIdentifierId, float speed); // 0x000000018044FC00-0x000000018044FD70
		public virtual bool GetButtonDoublePressDownById(int elementIdentifierId, float speed); // 0x000000018044F810-0x000000018044F930
		public virtual bool GetButtonDoublePressHoldById(int elementIdentifierId); // 0x000000018044FB20-0x000000018044FC00
		public virtual bool GetButtonDoublePressDownById(int elementIdentifierId); // 0x000000018044F700-0x000000018044F810
		public virtual bool GetButtonPrevById(int elementIdentifierId); // 0x0000000180450700-0x0000000180450840
		public virtual float GetButtonTimePressedById(int elementIdentifierId); // 0x0000000180450980-0x0000000180450AE0
		public virtual float GetButtonTimeUnpressedById(int elementIdentifierId); // 0x0000000180450C20-0x0000000180450D70
		public virtual float GetButtonLastTimePressedById(int elementIdentifierId); // 0x0000000180450280-0x00000001804503A0
		public virtual float GetButtonLastTimeUnpressedById(int elementIdentifierId); // 0x00000001804504E0-0x0000000180450600
		public virtual ControllerPollingInfo PollForFirstElement(); // 0x0000000180452D40-0x0000000180452D90
		public virtual ControllerPollingInfo PollForFirstElementDown(); // 0x0000000180452CF0-0x0000000180452D40
		public virtual ControllerPollingInfo PollForFirstButton(); // 0x0000000180452AF0-0x0000000180452CF0
		public virtual ControllerPollingInfo PollForFirstButtonDown(); // 0x00000001804528D0-0x0000000180452AF0
		public virtual IEnumerable<ControllerPollingInfo> PollForAllElements(); // 0x00000001804528B0-0x00000001804528D0
		public virtual IEnumerable<ControllerPollingInfo> PollForAllElementsDown(); // 0x0000000180452890-0x00000001804528B0
		public virtual IEnumerable<ControllerPollingInfo> PollForAllButtons(); // 0x0000000180452820-0x0000000180452890
		public virtual IEnumerable<ControllerPollingInfo> PollForAllButtonsDown(); // 0x00000001804527A0-0x0000000180452820
		private bool PoSJNfCUyVaNtAgYxHsJRuyKbJw(int param_0000c8d5, out int param_0000c8d6); // 0x0000000180452650-0x00000001804527A0
		private bool TbDgiVXBBKKrkhRtBqROOVnNfYG(int param_0000c8d7, out int param_0000c8d8); // 0x0000000180452E60-0x0000000180452FB0
		protected void UpdatePollingFrameTracking(); // 0x00000001804532C0-0x0000000180453490
		public virtual float GetLastTimeActive(); // 0x0000000180451630-0x00000001804516E0
		public virtual float GetLastTimeActive(bool useRawValues); // 0x0000000180451400-0x0000000180451630
		public virtual float GetLastTimeAnyElementChanged(); // 0x00000001804519E0-0x0000000180451A90
		public virtual float GetLastTimeAnyElementChanged(bool useRawValues); // 0x0000000180451A90-0x0000000180451C90
		public float GetLastTimeAnyButtonPressed(); // 0x0000000180451840-0x00000001804519E0
		public float GetLastTimeAnyButtonChanged(); // 0x00000001804516E0-0x0000000180451840
		public T GetExtension<T>()
			where T : class;
		public IControllerTemplate GetTemplate(Guid typeGuid); // 0x0000000180451C90-0x0000000180451F10
		public IControllerTemplate GetTemplate(Type type); // 0x0000000180451F10-0x00000001804520C0
		public T GetTemplate<T>()
			where T : class;
		public bool ImplementsTemplate(Guid typeGuid); // 0x0000000180452260-0x00000001804524A0
		public bool ImplementsTemplate(Type type); // 0x00000001804520C0-0x0000000180452260
		public bool ImplementsTemplate<T>()
			where T : class;
		internal void zgMhriHysuIjQRrMQrjIuyxmseb(IControllerTemplate[] param_0000c8df); // 0x00000001804557A0-0x0000000180455820
		internal virtual void UpdateData(UpdateLoopType param_0000c8e0); // 0x0000000180452FB0-0x00000001804532C0
		internal virtual ButtonStateFlags ooPkXeSnzrhNmNGPIQyYywRrCHh(int param_0000c8e1); // 0x00000001804550D0-0x00000001804552A0
		internal void yfRWsfTQXyegFbUdQIKkIniCckQk(Extension param_0000c8e2); // 0x0000000180455690-0x0000000180455770
		internal void qFQGYVdEHFJPtRNQyKVVNRpsaCz(Extension param_0000c8e3); // 0x00000001804552A0-0x00000001804553B0
		internal virtual void Clear(); // 0x000000018044EB40-0x000000018044ECE0
		internal virtual bool SetEnabled(bool param_0000c8e4); // 0x0000000180452D90-0x0000000180452E60
		internal virtual void BakeMap(ControllerMap param_0000c8e5); // 0x000000018044E9D0-0x000000018044EB40
		internal virtual void BakeActionElementMap(ControllerMap param_0000c8e6, ActionElementMap param_0000c8e7); // 0x000000018044E970-0x000000018044E9D0
		internal bool nHiArjzVQQIMIkkfpIeGhBgwpOxe(ActionElementMap param_0000c8e8, int param_0000c8e9, out float param_0000c8ea, out bool param_0000c8eb); // 0x0000000180454D90-0x00000001804550D0
		internal bool nHiArjzVQQIMIkkfpIeGhBgwpOxe(ActionElementMap param_0000c8ec, int param_0000c8ed, bool param_0000c8ee, out float param_0000c8ef); // 0x0000000180454CA0-0x0000000180454D90
		internal void eMLWHPWlVLcjuKEIpkdHeEbTVNGo(Element param_0000c8f0); // 0x0000000180453D50-0x0000000180453DD0
		internal virtual Guid GQambcIsXAcazlWWAnqpteoiGUs(); // 0x000000018044EDF0-0x000000018044EE60
		protected virtual void Connected(); // 0x000000018044ECE0-0x000000018044ECF0
		protected virtual void Disconnected(); // 0x000000018044ECF0-0x000000018044EDF0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static bool zcRiFyiFzElCKwOQLcDjHhleHSjh(Controller param_0000c8f1, Guid param_0000c8f2); // 0x0000000180455770-0x00000001804557A0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static bool JAjEgZtpLqzokVDaKdCvEstTswP(Controller param_0000c8f3, Type param_0000c8f4); // 0x00000001804524A0-0x0000000180452650
	}
}

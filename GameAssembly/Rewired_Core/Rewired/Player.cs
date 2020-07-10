/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils;
using Rewired.Utils.Classes;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public sealed class Player // TypeDefIndex: 6588
	{
		// Fields
		private readonly GOCsEdcRqIdaMQpgFWoBujLBrvX AoGmvlgpgvDvEPufAzhECdZfmlf; // 0x10
		private bool aomFahYawZCtEfvqgieyFRpNBEB; // 0x18
		private int jotfbgeLQZTIFstijorJbghJlvHQ; // 0x1C
		private string MYcWDFnyndJzsFpKvFFizAMuaiT; // 0x20
		private string nMArBKqVFJGDMXuQgzGpKHGekZp; // 0x28
		private bool BehdbTjAadwGBArRmdjvgPqrrwqs; // 0x30
		private readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x34
		public readonly ControllerHelper controllers; // 0x38
	
		// Properties
		public int id { get; internal set; } // 0x000000018084D770-0x000000018084D810 0x000000018037E600-0x000000018037E610
		public string name { get; internal set; } // 0x000000018084D8B0-0x000000018084D960 0x000000018036AC90-0x000000018036ACA0
		public string descriptiveName { get; internal set; } // 0x000000018084D6C0-0x000000018084D770 0x0000000180422D30-0x0000000180422D40
		public bool isPlaying { get; set; } // 0x000000018084D810-0x000000018084D8B0 0x000000018048B850-0x000000018048B860
	
		// Nested types
		[Browsable] // 0x00000001800D4F10-0x00000001800D4F50
		[EditorBrowsable] // 0x00000001800D4F10-0x00000001800D4F50
		public sealed class ControllerHelper // TypeDefIndex: 6589
		{
			// Fields
			private readonly egXAAqgVCShQeuJnjIKIGPUQzKT kjcfkBjrQkYuXOIuOAVTAohfNFLa; // 0x10
			private bool DltVeAWOftOsatsUOyyDXbQZoYf; // 0x18
			private bool yrdehMQHNKfGqUhXmAFthRgGXibc; // 0x19
			private bool VCsJeXHuvxKMGlHlHqyTsCiKIRlg; // 0x1A
			private float nNotoQyuvMlnNzGudIeGiuunWjb; // 0x1C
			private float rPEuzcfajrNclqqlomTyOntGOXL; // 0x20
			private SafeAction<ControllerAssignmentChangedEventArgs> hevtkFAAcwsaWUduMzJoSldvEAhG; // 0x28
			private SafeAction<ControllerAssignmentChangedEventArgs> gQFdpWzunAnCpGgOphLvBJoYWbGb; // 0x30
			private readonly jAchFPOUJqmmtMllCTHcROXwbLj VoNXLwsbUAMaIxrCOafEXDdBDZn; // 0x38
			private readonly Player yHWXapLnjMXUYBDESFaAUIdnziK; // 0x40
			private readonly EOJGUkiUCmDxCVgwuamVbrNKilvC VNXSIBPhgXxupWtsLpgyapRjbDq; // 0x48
			private readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x50
			public readonly MapHelper maps; // 0x58
			public readonly ConflictCheckingHelper conflictChecking; // 0x60
			public readonly PollingHelper polling; // 0x68
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Action<Exception> SoptGiBIwpEzOTmBujKpoVBsSer; // 0x00
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Action<Exception> AGoLVphFiYSQJEBguHfxHhzJytur; // 0x08
	
			// Properties
			private yuzjpKSgIlOzFrmYoCjvudWJHqg<Joystick, JoystickMap> joystickSet { get; } // 0x000000018083E300-0x000000018083E370 
			private UqmUJOucnPAhoXhVuhvbmxKGsOH<KeyboardMap> keyboardMapSet { get; } // 0x000000018083E370-0x000000018083E420 
			private UqmUJOucnPAhoXhVuhvbmxKGsOH<MouseMap> mouseMapSet { get; } // 0x000000018083E420-0x000000018083E4D0 
			private yuzjpKSgIlOzFrmYoCjvudWJHqg<CustomController, CustomControllerMap> customControllerSet { get; } // 0x000000018083DFA0-0x000000018083E010 
			public bool hasMouse { get; set; } // 0x000000018083E150-0x000000018083E220 0x000000018083EAE0-0x000000018083EF10
			public bool hasKeyboard { get; set; } // 0x000000018083E0B0-0x000000018083E150 0x000000018083E700-0x000000018083EAE0
			public bool excludeFromControllerAutoAssignment { get; set; } // 0x000000018083E010-0x000000018083E0B0 0x000000018083E650-0x000000018083E700
			public Keyboard Keyboard { get; } // 0x000000018083DD10-0x000000018083DDD0 
			public Mouse Mouse { get; } // 0x000000018083DDD0-0x000000018083DE90 
			public int joystickCount { get; } // 0x000000018083E220-0x000000018083E300 
			public IList<Joystick> Joysticks { get; } // 0x000000018083DC20-0x000000018083DD10 
			public int customControllerCount { get; } // 0x000000018083DE90-0x000000018083DFA0 
			public IList<CustomController> CustomControllers { get; } // 0x000000018083DB30-0x000000018083DC20 
			public IEnumerable<Controller> Controllers { get; } // 0x000000018083DAC0-0x000000018083DB30 
	
			// Events
			public event Action<ControllerAssignmentChangedEventArgs> ControllerAddedEvent {
				add; // 0x000000018083DA00-0x000000018083DA60
				remove; // 0x000000018083E590-0x000000018083E5F0
			}
			public event Action<ControllerAssignmentChangedEventArgs> ControllerRemovedEvent {
				add; // 0x000000018083DA60-0x000000018083DAC0
				remove; // 0x000000018083E5F0-0x000000018083E650
			}
	
			// Nested types
			[Browsable] // 0x00000001800D4F10-0x00000001800D4F50
			[EditorBrowsable] // 0x00000001800D4F10-0x00000001800D4F50
			public sealed class ConflictCheckingHelper : CodeHelper // TypeDefIndex: 6590
			{
				// Fields
				private readonly Player yHWXapLnjMXUYBDESFaAUIdnziK; // 0x10
				private readonly ControllerHelper GsoDNwSmTlqXUxYxRnLUXMOoArhh; // 0x18
				private readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x20
	
				// Nested types
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class SzsVaIezRRtvUGCGQSactMaiXzx : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6591
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x48
					public int ApclWZWATFcgBgxbNPQkMDQJKvCT; // 0x50
					public int UFtQErWYQIHFhzaXnGUeSzqyBsH; // 0x54
					public JoystickMap rwXPIhaGJmyGraOwfLwocOygkZp; // 0x58
					public JoystickMap cPOeTCjdtzrMyQdUohGYjHxDEbFE; // 0x60
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x68
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x69
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg; // 0x6A
					public bool zvtRiMruKwJnFepPguqIcMMwcWL; // 0x6B
					public int hdPQaKteytYWJzmknFrOgDwsPlJ; // 0x6C
					public Joystick FZJWiwgVAICbrLduFfrRsNvIamuK; // 0x70
					public ElementAssignmentConflictInfo hMayGiCOlextzkJNUqhFBvqTODM; // 0x78
					public IEnumerator<ElementAssignmentConflictInfo> cQcBKvPWPCnEwWPEuuwBdAdMLEa; // 0xA8
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001808F4370-0x00000001808F43D0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public SzsVaIezRRtvUGCGQSactMaiXzx(int <>1__state); // 0x00000001808F4440-0x00000001808F44B0
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x00000001808F41D0-0x00000001808F4320
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001808F41D0-0x00000001808F4320
					private bool MoveNext(); // 0x00000001808F3DB0-0x00000001808F41D0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x00000001808F4320-0x00000001808F4370
					void IDisposable.Dispose(); // 0x00000001808F43D0-0x00000001808F4440
					private void dbcAqPOPRsdGnKnXQdpmygocXEL(); // 0x00000001808F44B0-0x00000001808F45E0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class wTIkzkqxyPQpNRizyWXQMIpUlJw : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6592
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x48
					public int ApclWZWATFcgBgxbNPQkMDQJKvCT; // 0x50
					public int UFtQErWYQIHFhzaXnGUeSzqyBsH; // 0x54
					public JoystickMap rwXPIhaGJmyGraOwfLwocOygkZp; // 0x58
					public JoystickMap cPOeTCjdtzrMyQdUohGYjHxDEbFE; // 0x60
					public ActionElementMap fltxxhyRZfQdEoMAlCOVFHsvVnlJ; // 0x68
					public ActionElementMap vSfdRccImBdXghlwRdvRgMCkGBN; // 0x70
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x78
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x79
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg; // 0x7A
					public bool zvtRiMruKwJnFepPguqIcMMwcWL; // 0x7B
					public int eTuBfxlilBkzIsGvYsYBMrfWKLw; // 0x7C
					public Joystick FfgPzSpcKgdUeWyNsbxeobtJdARA; // 0x80
					public ElementAssignmentConflictInfo NHPevMcDkqGngPxBIFJjmdQiqiX; // 0x88
					public IEnumerator<ElementAssignmentConflictInfo> langcIztTbIcqzxDOhkhhwoqTJF; // 0xB8
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001808F65D0-0x00000001808F6630 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public wTIkzkqxyPQpNRizyWXQMIpUlJw(int <>1__state); // 0x0000000180648C40-0x0000000180648C90
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x00000001808F6460-0x00000001808F6580
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001808F6460-0x00000001808F6580
					private bool MoveNext(); // 0x00000001808F5F80-0x00000001808F6460
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x00000001808F6580-0x00000001808F65D0
					void IDisposable.Dispose(); // 0x00000001808F6630-0x00000001808F66A0
					private void xcAVusbXlUDusmCdbvVNsTYvMHV(); // 0x00000001808F66A0-0x00000001808F67C0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class MbaVideVWBJvwyBfaieKiefXdDFH : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6593
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x48
					public ElementAssignmentConflictCheck gdXiyfccIlKDtIhrdLInicIqLXay; // 0x50
					public ElementAssignmentConflictCheck rCEjBPidFUoNshKDDcSlCqEOzsi; // 0x88
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0xC0
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0xC1
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg; // 0xC2
					public bool zvtRiMruKwJnFepPguqIcMMwcWL; // 0xC3
					public int DKkMJkMWUEmNmZbANhFoeetfnYp; // 0xC4
					public Joystick sGvEEZkCLMdExRJTGaKCLWaObTi; // 0xC8
					public ElementAssignmentConflictInfo nATCnyTGfgXcIFgARzbwYjLtSHo; // 0xD0
					public IEnumerator<ElementAssignmentConflictInfo> HTmpQVSARCFwnTgkYjHYKcLLhuO; // 0x100
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180840200-0x0000000180840260 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public MbaVideVWBJvwyBfaieKiefXdDFH(int <>1__state); // 0x0000000180648C40-0x0000000180648C90
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000180840030-0x00000001808401B0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180840030-0x00000001808401B0
					private bool MoveNext(); // 0x000000018083F970-0x000000018083FFE0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x00000001808401B0-0x0000000180840200
					void IDisposable.Dispose(); // 0x0000000180840260-0x0000000180840310
					private void RsDcNovKyKhnWvjwYFNKEyositf(); // 0x000000018083FFE0-0x0000000180840030
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class lbGCxUtbsCUWEYjwuLUIEqbQFbDc : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6594
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x48
					public int FRSDqXfaespBhDCDevzOMunPlhsy; // 0x50
					public int VYkIHAcGNJAdQdWYaWGsQoCuTMw; // 0x54
					public CustomControllerMap hjJeeldXugdVafyVnLNjHwybuBz; // 0x58
					public CustomControllerMap KqceBBRVZFmWfODIxIwCbgtYGZR; // 0x60
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x68
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x69
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg; // 0x6A
					public bool zvtRiMruKwJnFepPguqIcMMwcWL; // 0x6B
					public int GktVIdZszugAyizJhsYVtgAqQVK; // 0x6C
					public CustomController jLqrDOMmvrQHzqmkzHryDCWcCfW; // 0x70
					public ElementAssignmentConflictInfo jpVkPJsiZKloSJHiNWRwgUVEEZc; // 0x78
					public IEnumerator<ElementAssignmentConflictInfo> zvtlpoHTzipISITgSSteRJlGbJB; // 0xA8
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001808F55C0-0x00000001808F5620 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public lbGCxUtbsCUWEYjwuLUIEqbQFbDc(int <>1__state); // 0x0000000180648C40-0x0000000180648C90
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x00000001808F53F0-0x00000001808F5570
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001808F53F0-0x00000001808F5570
					private bool MoveNext(); // 0x00000001808F4E50-0x00000001808F53F0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x00000001808F5570-0x00000001808F55C0
					void IDisposable.Dispose(); // 0x00000001808F5620-0x00000001808F5690
					private void ZzaLzKBGxfxOMRfaoRENBijhygg(); // 0x00000001808F5690-0x00000001808F57B0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class XimVxZsAJJlhYNNJOetGgvRrdDd : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6595
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x48
					public int FRSDqXfaespBhDCDevzOMunPlhsy; // 0x50
					public int VYkIHAcGNJAdQdWYaWGsQoCuTMw; // 0x54
					public CustomControllerMap hjJeeldXugdVafyVnLNjHwybuBz; // 0x58
					public CustomControllerMap KqceBBRVZFmWfODIxIwCbgtYGZR; // 0x60
					public ActionElementMap fltxxhyRZfQdEoMAlCOVFHsvVnlJ; // 0x68
					public ActionElementMap vSfdRccImBdXghlwRdvRgMCkGBN; // 0x70
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x78
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x79
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg; // 0x7A
					public bool zvtRiMruKwJnFepPguqIcMMwcWL; // 0x7B
					public int FqDIYmSLXwyrqwrmarMyGCDNqfE; // 0x7C
					public CustomController RYfXVsiwymFkoeNxFoKzlrOkrHM; // 0x80
					public ElementAssignmentConflictInfo haablRDMJrcmBQCSJJGPFoqDtaUS; // 0x88
					public IEnumerator<ElementAssignmentConflictInfo> fPLQrdhPkEvpWPAlQiYjaAUxrLAV; // 0xB8
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001808F4C30-0x00000001808F4C90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public XimVxZsAJJlhYNNJOetGgvRrdDd(int <>1__state); // 0x0000000180648C40-0x0000000180648C90
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x00000001808F4A90-0x00000001808F4BE0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001808F4A90-0x00000001808F4BE0
					private bool MoveNext(); // 0x00000001808F45E0-0x00000001808F4A90
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x00000001808F4BE0-0x00000001808F4C30
					void IDisposable.Dispose(); // 0x00000001808F4C90-0x00000001808F4D30
					private void YKcbISxRyfoXfGDKpQEZechYaZY(); // 0x00000001808F4D30-0x00000001808F4E50
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class wQHAtjccGdckXIyVLyPzolzcNGNQ : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6596
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x48
					public ElementAssignmentConflictCheck gdXiyfccIlKDtIhrdLInicIqLXay; // 0x50
					public ElementAssignmentConflictCheck rCEjBPidFUoNshKDDcSlCqEOzsi; // 0x88
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0xC0
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0xC1
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg; // 0xC2
					public bool zvtRiMruKwJnFepPguqIcMMwcWL; // 0xC3
					public int SXQIZDMUIYfKSCLJfqPvuNKWazPA; // 0xC4
					public CustomController PKkYPLVEgQlcpxTeASEFPzfPdDd; // 0xC8
					public ElementAssignmentConflictInfo NDzzgpzBSNoxKybduPFORgalMLX; // 0xD0
					public IEnumerator<ElementAssignmentConflictInfo> wUKVEbaSfpjAHdCahRBxUAhlXYXS; // 0x100
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001808F5E70-0x00000001808F5ED0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public wQHAtjccGdckXIyVLyPzolzcNGNQ(int <>1__state); // 0x0000000180648C40-0x0000000180648C90
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x00000001808F5CC0-0x00000001808F5E20
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001808F5CC0-0x00000001808F5E20
					private bool MoveNext(); // 0x00000001808F5800-0x00000001808F5CC0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x00000001808F5E20-0x00000001808F5E70
					void IDisposable.Dispose(); // 0x00000001808F5ED0-0x00000001808F5F80
					private void EuqoCsxJgbyLTLQWQWXqAlploEj(); // 0x00000001808F57B0-0x00000001808F5800
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class PuVMbLmYgSEDXCslgLvixWwJtIx<T> : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6597
					where T : ControllerMap
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO;
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL;
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo;
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo;
					public ControllerType MwSPhixbHhGhQJHlYxMHTaFzpvRE;
					public ControllerType PxWjSUQJGPwPKdocHnvDYVjvPeI;
					public int FZCiaBjzpHGiTGGuVbrbiMgKNtm;
					public int EZxLSbQNitjXVBgcbwwpdZMFWYJg;
					public T slEGCclmLZBxNgPEaCjlWADKjFY;
					public T tkGppmZwIVaiaDOXXgwDfjSfymh;
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa;
					public bool hsvMDnJdujXlHczadGEjywGdfVj;
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg;
					public bool zvtRiMruKwJnFepPguqIcMMwcWL;
					public UqmUJOucnPAhoXhVuhvbmxKGsOH<T> QFbEjLPYLEydDXhqQTvsfCYpEMA;
					public UqmUJOucnPAhoXhVuhvbmxKGsOH<T> RXggHQzbQOgiUVWydWFjVgMkbeZ;
					public InputMapCategory kyVLnXvgiHzfmpEFHfjcjwSSCQrZ;
					public int MZVOuEoNiLJQnLowXRbjOgPjHWp;
					public ControllerMap amPzhCREpDTGtLaNwfdRFrvWbRrX;
					public ElementAssignmentConflictInfo nyCKhURskuLVrHhhbISxtinPjd;
					public ElementAssignmentConflictInfo DrXNrFIjNjTCqxYybijpJDkZdlr;
					public IEnumerator<ElementAssignmentConflictInfo> wmEgctWLffnfgthozJzyrdNLRLY;
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public PuVMbLmYgSEDXCslgLvixWwJtIx(int <>1__state);
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator();
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator();
					private bool MoveNext();
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset();
					void IDisposable.Dispose();
					private void zwycPmKKqzmwlzvHmKkodWCoEpgs();
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class rRVYQiFhxnxaLpQbzwWsBBpBeuI<T> : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6598
					where T : ControllerMap
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO;
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL;
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo;
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo;
					public ControllerType MwSPhixbHhGhQJHlYxMHTaFzpvRE;
					public ControllerType PxWjSUQJGPwPKdocHnvDYVjvPeI;
					public int FZCiaBjzpHGiTGGuVbrbiMgKNtm;
					public int EZxLSbQNitjXVBgcbwwpdZMFWYJg;
					public T slEGCclmLZBxNgPEaCjlWADKjFY;
					public T tkGppmZwIVaiaDOXXgwDfjSfymh;
					public ActionElementMap jhTCfPFMhFaPhAKlIYBuTUWJFYFr;
					public ActionElementMap PjxPTmvnjGAeSiNCdkIAxYZmuRhQ;
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa;
					public bool hsvMDnJdujXlHczadGEjywGdfVj;
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg;
					public bool zvtRiMruKwJnFepPguqIcMMwcWL;
					public UqmUJOucnPAhoXhVuhvbmxKGsOH<T> QFbEjLPYLEydDXhqQTvsfCYpEMA;
					public UqmUJOucnPAhoXhVuhvbmxKGsOH<T> RXggHQzbQOgiUVWydWFjVgMkbeZ;
					public InputMapCategory qeWoEDMVRQTSYDVJuqcqiaYvsLG;
					public int HwIPYaoBaYeoyvIeGcbDApKiyxj;
					public ControllerMap RzTlZYZAUBWuifbriWGmsBdhHjaI;
					public ElementAssignmentConflictInfo eUlqMHbtQoiVzWSnknsgBAJwFZu;
					public ElementAssignmentConflictInfo oMjBMPFMMCmjieHyvZlgTzOjOqyQ;
					public IEnumerator<ElementAssignmentConflictInfo> AimIAUzWJzqRTvvRSOziblXXlgI;
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public rRVYQiFhxnxaLpQbzwWsBBpBeuI(int <>1__state);
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator();
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator();
					private bool MoveNext();
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset();
					void IDisposable.Dispose();
					private void DsTpVgMHWRPtNsSqsDRbdOEEKgE();
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class nnsDbiyEFehLmZPfthrqCLdLqabh<T> : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6599
					where T : ControllerMap
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO;
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL;
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo;
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo;
					public ElementAssignmentConflictCheck gdXiyfccIlKDtIhrdLInicIqLXay;
					public ElementAssignmentConflictCheck rCEjBPidFUoNshKDDcSlCqEOzsi;
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa;
					public bool hsvMDnJdujXlHczadGEjywGdfVj;
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg;
					public bool zvtRiMruKwJnFepPguqIcMMwcWL;
					public UqmUJOucnPAhoXhVuhvbmxKGsOH<T> QFbEjLPYLEydDXhqQTvsfCYpEMA;
					public UqmUJOucnPAhoXhVuhvbmxKGsOH<T> RXggHQzbQOgiUVWydWFjVgMkbeZ;
					public Player TpGdpfCwKyWbJFMkGPybIJVqvbcP;
					public ControllerMap mwIhwCvWLPwVAXYNfdVMLhiRNRW;
					public InputMapCategory fZYNGuRhjsFcBEHOFFDklQnBbTPZ;
					public int BNuqfNDuOFuzxCNDPrirhUayqeU;
					public ControllerMap LmGBJXGJuUxhBquKqjCtDNzhGFBt;
					public ElementAssignmentConflictInfo WNgclhkADOhVKGVTbvynLlZhAPp;
					public ElementAssignmentConflictInfo aCliIXGpFxWJGkactEDIjMbqTYIW;
					public IEnumerator<ElementAssignmentConflictInfo> HiCZECnBPSTXZOwJOsJRpZykqiA;
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public nnsDbiyEFehLmZPfthrqCLdLqabh(int <>1__state);
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator();
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator();
					private bool MoveNext();
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset();
					void IDisposable.Dispose();
					private void PrLaIDOKwuIEIBpQhboNIabkErob();
				}
	
				// Constructors
				internal ConflictCheckingHelper(Player player, ControllerHelper parent); // 0x0000000180835020-0x00000001808350F0
	
				// Methods
				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap); // 0x0000000180830B40-0x0000000180830B70
				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps); // 0x0000000180830E10-0x0000000180830E40
				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180830B70-0x0000000180830E10
				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap); // 0x0000000180830E90-0x0000000180830EC0
				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps); // 0x0000000180831170-0x00000001808311A0
				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x00000001808311A0-0x0000000180831480
				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck); // 0x0000000180830AF0-0x0000000180830B40
				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x0000000180830E40-0x0000000180830E90
				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180830EC0-0x0000000180831170
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap); // 0x00000001808321C0-0x00000001808321F0
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps); // 0x0000000180832A50-0x0000000180832A80
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180831E80-0x00000001808321C0
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap); // 0x0000000180832A80-0x0000000180832AB0
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps); // 0x0000000180832290-0x00000001808322C0
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x00000001808322C0-0x0000000180832650
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x00000001808321F0-0x0000000180832240
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x0000000180832240-0x0000000180832290
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180832650-0x0000000180832A50
				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap); // 0x00000001808348E0-0x0000000180834910
				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipRemovedMaps); // 0x00000001808348B0-0x00000001808348E0
				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipRemovedMaps, bool forceCheckAllCategories); // 0x0000000180834910-0x0000000180834B80
				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap); // 0x00000001808342C0-0x00000001808342F0
				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipRemovedMaps); // 0x0000000180834290-0x00000001808342C0
				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipRemovedMaps, bool forceCheckAllCategories); // 0x0000000180834340-0x0000000180834610
				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x0000000180834B80-0x0000000180834BD0
				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipRemovedMaps); // 0x00000001808342F0-0x0000000180834340
				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipRemovedMaps, bool forceCheckAllCategories); // 0x0000000180834610-0x00000001808348B0
				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap); // 0x00000001808309C0-0x00000001808309F0
				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps); // 0x00000001808309F0-0x0000000180830A20
				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180830180-0x0000000180830420
				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap); // 0x0000000180830150-0x0000000180830180
				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps); // 0x0000000180830A70-0x0000000180830AA0
				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x00000001808306D0-0x00000001808309C0
				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x0000000180830A20-0x0000000180830A70
				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x0000000180830AA0-0x0000000180830AF0
				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180830420-0x00000001808306D0
				private bool DxUxCsinfAWFYpubKnmfntdUduK(int param_0000decd, JoystickMap param_0000dece, bool param_0000decf = false /* Metadata: 0x0073117E */, bool param_0000ded0 = false /* Metadata: 0x0073117F */); // 0x0000000180831480-0x00000001808317C0
				private bool DxUxCsinfAWFYpubKnmfntdUduK(int param_0000ded1, JoystickMap param_0000ded2, ActionElementMap param_0000ded3, bool param_0000ded4 = false /* Metadata: 0x00731180 */, bool param_0000ded5 = false /* Metadata: 0x00731181 */); // 0x0000000180831B20-0x0000000180831E80
				private bool DxUxCsinfAWFYpubKnmfntdUduK(ElementAssignmentConflictCheck param_0000ded6, bool param_0000ded7 = false /* Metadata: 0x00731182 */, bool param_0000ded8 = false /* Metadata: 0x00731183 */); // 0x00000001808317C0-0x0000000180831B20
				private bool wXcueicCklSRvlxEnukgGZLyfpI(KeyboardMap param_0000ded9, bool param_0000deda = false /* Metadata: 0x00731184 */, bool param_0000dedb = false /* Metadata: 0x00731185 */); // 0x0000000180837020-0x00000001808370C0
				private bool wXcueicCklSRvlxEnukgGZLyfpI(KeyboardMap param_0000dedc, ActionElementMap param_0000dedd, bool param_0000dede = false /* Metadata: 0x00731186 */, bool param_0000dedf = false /* Metadata: 0x00731187 */); // 0x00000001808370C0-0x0000000180837160
				private bool wXcueicCklSRvlxEnukgGZLyfpI(ElementAssignmentConflictCheck param_0000dee0, bool param_0000dee1 = false /* Metadata: 0x00731188 */, bool param_0000dee2 = false /* Metadata: 0x00731189 */); // 0x0000000180836F60-0x0000000180837020
				private bool aEPFDkgvlTaxDMvMdXmXlPcSWfzg(MouseMap param_0000dee3, bool param_0000dee4 = false /* Metadata: 0x0073118A */, bool param_0000dee5 = false /* Metadata: 0x0073118B */); // 0x00000001808350F0-0x0000000180835190
				private bool aEPFDkgvlTaxDMvMdXmXlPcSWfzg(MouseMap param_0000dee6, ActionElementMap param_0000dee7, bool param_0000dee8 = false /* Metadata: 0x0073118C */, bool param_0000dee9 = false /* Metadata: 0x0073118D */); // 0x0000000180835190-0x0000000180835230
				private bool aEPFDkgvlTaxDMvMdXmXlPcSWfzg(ElementAssignmentConflictCheck param_0000deea, bool param_0000deeb = false /* Metadata: 0x0073118E */, bool param_0000deec = false /* Metadata: 0x0073118F */); // 0x0000000180835230-0x00000001808352F0
				private bool RTzJvqyIWdYfpLMnYXwBLikApnt(int param_0000deed, CustomControllerMap param_0000deee, bool param_0000deef = false /* Metadata: 0x00731190 */, bool param_0000def0 = false /* Metadata: 0x00731191 */); // 0x0000000180833910-0x0000000180833C40
				private bool RTzJvqyIWdYfpLMnYXwBLikApnt(int param_0000def1, CustomControllerMap param_0000def2, ActionElementMap param_0000def3, bool param_0000def4 = false /* Metadata: 0x00731192 */, bool param_0000def5 = false /* Metadata: 0x00731193 */); // 0x0000000180833C40-0x0000000180833F90
				private bool RTzJvqyIWdYfpLMnYXwBLikApnt(ElementAssignmentConflictCheck param_0000def6, bool param_0000def7 = false /* Metadata: 0x00731194 */, bool param_0000def8 = false /* Metadata: 0x00731195 */); // 0x0000000180833F90-0x0000000180834290
				private IEnumerable<ElementAssignmentConflictInfo> MRgnTPvPKuFIQVnkoOgsMkvypzz(int param_0000def9, JoystickMap param_0000defa, bool param_0000defb = false /* Metadata: 0x00731196 */, bool param_0000defc = false /* Metadata: 0x00731197 */); // 0x0000000180832CD0-0x0000000180832D80
				private IEnumerable<ElementAssignmentConflictInfo> MRgnTPvPKuFIQVnkoOgsMkvypzz(int param_0000defd, JoystickMap param_0000defe, ActionElementMap param_0000deff, bool param_0000df00 = false /* Metadata: 0x00731198 */, bool param_0000df01 = false /* Metadata: 0x00731199 */); // 0x0000000180832E90-0x0000000180832F40
				private IEnumerable<ElementAssignmentConflictInfo> MRgnTPvPKuFIQVnkoOgsMkvypzz(ElementAssignmentConflictCheck param_0000df02, bool param_0000df03 = false /* Metadata: 0x0073119A */, bool param_0000df04 = false /* Metadata: 0x0073119B */); // 0x0000000180832D80-0x0000000180832E90
				private IEnumerable<ElementAssignmentConflictInfo> tUDCLjaXyYDhvMbyzbdykNyovBi(KeyboardMap param_0000df05, bool param_0000df06 = false /* Metadata: 0x0073119C */, bool param_0000df07 = false /* Metadata: 0x0073119D */); // 0x0000000180836CC0-0x0000000180836D60
				private IEnumerable<ElementAssignmentConflictInfo> tUDCLjaXyYDhvMbyzbdykNyovBi(KeyboardMap param_0000df08, ActionElementMap param_0000df09, bool param_0000df0a = false /* Metadata: 0x0073119E */, bool param_0000df0b = false /* Metadata: 0x0073119F */); // 0x0000000180836C20-0x0000000180836CC0
				private IEnumerable<ElementAssignmentConflictInfo> tUDCLjaXyYDhvMbyzbdykNyovBi(ElementAssignmentConflictCheck param_0000df0c, bool param_0000df0d = false /* Metadata: 0x007311A0 */, bool param_0000df0e = false /* Metadata: 0x007311A1 */); // 0x0000000180836B40-0x0000000180836C20
				private IEnumerable<ElementAssignmentConflictInfo> GBpaKcaXjHwRPKNwzvYTCbohHIuH(MouseMap param_0000df0f, bool param_0000df10 = false /* Metadata: 0x007311A2 */, bool param_0000df11 = false /* Metadata: 0x007311A3 */); // 0x0000000180832B50-0x0000000180832BF0
				private IEnumerable<ElementAssignmentConflictInfo> GBpaKcaXjHwRPKNwzvYTCbohHIuH(MouseMap param_0000df12, ActionElementMap param_0000df13, bool param_0000df14 = false /* Metadata: 0x007311A4 */, bool param_0000df15 = false /* Metadata: 0x007311A5 */); // 0x0000000180832AB0-0x0000000180832B50
				private IEnumerable<ElementAssignmentConflictInfo> GBpaKcaXjHwRPKNwzvYTCbohHIuH(ElementAssignmentConflictCheck param_0000df16, bool param_0000df17 = false /* Metadata: 0x007311A6 */, bool param_0000df18 = false /* Metadata: 0x007311A7 */); // 0x0000000180832BF0-0x0000000180832CD0
				private IEnumerable<ElementAssignmentConflictInfo> nYfulgjqWJpqujfJpXbCGeUTYHC(int param_0000df19, CustomControllerMap param_0000df1a, bool param_0000df1b = false /* Metadata: 0x007311A8 */, bool param_0000df1c = false /* Metadata: 0x007311A9 */); // 0x0000000180835470-0x0000000180835520
				private IEnumerable<ElementAssignmentConflictInfo> nYfulgjqWJpqujfJpXbCGeUTYHC(int param_0000df1d, CustomControllerMap param_0000df1e, ActionElementMap param_0000df1f, bool param_0000df20 = false /* Metadata: 0x007311AA */, bool param_0000df21 = false /* Metadata: 0x007311AB */); // 0x00000001808353C0-0x0000000180835470
				private IEnumerable<ElementAssignmentConflictInfo> nYfulgjqWJpqujfJpXbCGeUTYHC(ElementAssignmentConflictCheck param_0000df22, bool param_0000df23 = false /* Metadata: 0x007311AC */, bool param_0000df24 = false /* Metadata: 0x007311AD */); // 0x00000001808352F0-0x00000001808353C0
				private int zUesUqgzAjTqcPAFWJspqFdOSAK(int param_0000df25, JoystickMap param_0000df26, bool param_0000df27 = false /* Metadata: 0x007311AE */, bool param_0000df28 = false /* Metadata: 0x007311AF */); // 0x00000001808374E0-0x0000000180837800
				private int zUesUqgzAjTqcPAFWJspqFdOSAK(int param_0000df29, JoystickMap param_0000df2a, ActionElementMap param_0000df2b, bool param_0000df2c = false /* Metadata: 0x007311B0 */, bool param_0000df2d = false /* Metadata: 0x007311B1 */); // 0x0000000180837800-0x0000000180837B40
				private int zUesUqgzAjTqcPAFWJspqFdOSAK(ElementAssignmentConflictCheck param_0000df2e, bool param_0000df2f = false /* Metadata: 0x007311B2 */, bool param_0000df30 = false /* Metadata: 0x007311B3 */); // 0x0000000180837160-0x00000001808374E0
				private int AAzbhFdYOVScAsWiElenoaQTPBi(KeyboardMap param_0000df31, bool param_0000df32 = false /* Metadata: 0x007311B4 */, bool param_0000df33 = false /* Metadata: 0x007311B5 */); // 0x000000018082FF50-0x000000018082FFF0
				private int AAzbhFdYOVScAsWiElenoaQTPBi(KeyboardMap param_0000df34, ActionElementMap param_0000df35, bool param_0000df36 = false /* Metadata: 0x007311B6 */, bool param_0000df37 = false /* Metadata: 0x007311B7 */); // 0x00000001808300B0-0x0000000180830150
				private int AAzbhFdYOVScAsWiElenoaQTPBi(ElementAssignmentConflictCheck param_0000df38, bool param_0000df39 = false /* Metadata: 0x007311B8 */, bool param_0000df3a = false /* Metadata: 0x007311B9 */); // 0x000000018082FFF0-0x00000001808300B0
				private int ulBXXqKdVzAGMiziSQvOSsbqBDM(MouseMap param_0000df3b, bool param_0000df3c = false /* Metadata: 0x007311BA */, bool param_0000df3d = false /* Metadata: 0x007311BB */); // 0x0000000180836EC0-0x0000000180836F60
				private int ulBXXqKdVzAGMiziSQvOSsbqBDM(MouseMap param_0000df3e, ActionElementMap param_0000df3f, bool param_0000df40 = false /* Metadata: 0x007311BC */, bool param_0000df41 = false /* Metadata: 0x007311BD */); // 0x0000000180836E20-0x0000000180836EC0
				private int ulBXXqKdVzAGMiziSQvOSsbqBDM(ElementAssignmentConflictCheck param_0000df42, bool param_0000df43 = false /* Metadata: 0x007311BE */, bool param_0000df44 = false /* Metadata: 0x007311BF */); // 0x0000000180836D60-0x0000000180836E20
				private int ogsyqhxhlaCnaGAJLkpKnbhucbi(int param_0000df45, CustomControllerMap param_0000df46, bool param_0000df47 = false /* Metadata: 0x007311C0 */, bool param_0000df48 = false /* Metadata: 0x007311C1 */); // 0x0000000180835520-0x0000000180835870
				private int ogsyqhxhlaCnaGAJLkpKnbhucbi(int param_0000df49, CustomControllerMap param_0000df4a, ActionElementMap param_0000df4b, bool param_0000df4c = false /* Metadata: 0x007311C2 */, bool param_0000df4d = false /* Metadata: 0x007311C3 */); // 0x0000000180835870-0x0000000180835BD0
				private int ogsyqhxhlaCnaGAJLkpKnbhucbi(ElementAssignmentConflictCheck param_0000df4e, bool param_0000df4f = false /* Metadata: 0x007311C4 */, bool param_0000df50 = false /* Metadata: 0x007311C5 */); // 0x0000000180835BD0-0x0000000180835F10
				private int NelggbthumjxGTexgIAOZhYwWoK(int param_0000df51, JoystickMap param_0000df52, bool param_0000df53 = false /* Metadata: 0x007311C6 */, bool param_0000df54 = false /* Metadata: 0x007311C7 */, List<ActionElementMap> param_0000df55 = null); // 0x0000000180833290-0x00000001808335C0
				private int NelggbthumjxGTexgIAOZhYwWoK(int param_0000df56, JoystickMap param_0000df57, ActionElementMap param_0000df58, bool param_0000df59 = false /* Metadata: 0x007311C8 */, bool param_0000df5a = false /* Metadata: 0x007311C9 */, List<ActionElementMap> param_0000df5b = null); // 0x0000000180832F40-0x0000000180833290
				private int NelggbthumjxGTexgIAOZhYwWoK(ElementAssignmentConflictCheck param_0000df5c, bool param_0000df5d = false /* Metadata: 0x007311CA */, bool param_0000df5e = false /* Metadata: 0x007311CB */, List<ActionElementMap> param_0000df5f = null); // 0x00000001808335C0-0x0000000180833910
				private int SkffTQYiVFTbnzlfYOUqAgXirDr(KeyboardMap param_0000df60, bool param_0000df61 = false /* Metadata: 0x007311CC */, bool param_0000df62 = false /* Metadata: 0x007311CD */, List<ActionElementMap> param_0000df63 = null); // 0x0000000180834EB0-0x0000000180834F50
				private int SkffTQYiVFTbnzlfYOUqAgXirDr(KeyboardMap param_0000df64, ActionElementMap param_0000df65, bool param_0000df66 = false /* Metadata: 0x007311CE */, bool param_0000df67 = false /* Metadata: 0x007311CF */, List<ActionElementMap> param_0000df68 = null); // 0x0000000180834E00-0x0000000180834EB0
				private int SkffTQYiVFTbnzlfYOUqAgXirDr(ElementAssignmentConflictCheck param_0000df69, bool param_0000df6a = false /* Metadata: 0x007311D0 */, bool param_0000df6b = false /* Metadata: 0x007311D1 */, List<ActionElementMap> param_0000df6c = null); // 0x0000000180834F50-0x0000000180835020
				private int ptrQHwldfEFdoVXaZbwIaOGNCLAh(MouseMap param_0000df6d, bool param_0000df6e = false /* Metadata: 0x007311D2 */, bool param_0000df6f = false /* Metadata: 0x007311D3 */, List<ActionElementMap> param_0000df70 = null); // 0x0000000180836090-0x0000000180836140
				private int ptrQHwldfEFdoVXaZbwIaOGNCLAh(MouseMap param_0000df71, ActionElementMap param_0000df72, bool param_0000df73 = false /* Metadata: 0x007311D4 */, bool param_0000df74 = false /* Metadata: 0x007311D5 */, List<ActionElementMap> param_0000df75 = null); // 0x0000000180835FE0-0x0000000180836090
				private int ptrQHwldfEFdoVXaZbwIaOGNCLAh(ElementAssignmentConflictCheck param_0000df76, bool param_0000df77 = false /* Metadata: 0x007311D6 */, bool param_0000df78 = false /* Metadata: 0x007311D7 */, List<ActionElementMap> param_0000df79 = null); // 0x0000000180835F10-0x0000000180835FE0
				private int qzXyzfORVDqhzRVipLqpqtoChSh(int param_0000df7a, CustomControllerMap param_0000df7b, bool param_0000df7c = false /* Metadata: 0x007311D8 */, bool param_0000df7d = false /* Metadata: 0x007311D9 */, List<ActionElementMap> param_0000df7e = null); // 0x0000000180836490-0x00000001808367A0
				private int qzXyzfORVDqhzRVipLqpqtoChSh(int param_0000df7f, CustomControllerMap param_0000df80, ActionElementMap param_0000df81, bool param_0000df82 = false /* Metadata: 0x007311DA */, bool param_0000df83 = false /* Metadata: 0x007311DB */, List<ActionElementMap> param_0000df84 = null); // 0x0000000180836140-0x0000000180836490
				private int qzXyzfORVDqhzRVipLqpqtoChSh(ElementAssignmentConflictCheck param_0000df85, bool param_0000df86 = false /* Metadata: 0x007311DC */, bool param_0000df87 = false /* Metadata: 0x007311DD */, List<ActionElementMap> param_0000df88 = null); // 0x00000001808367A0-0x0000000180836B40
				private bool rCWLbLscSTtJFXWAMHzqUevhLDg<T>(ControllerType param_0000df89, int param_0000df8a, T param_0000df8b, bool param_0000df8c, bool param_0000df8d, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000df8e)
					where T : ControllerMap;
				private bool rCWLbLscSTtJFXWAMHzqUevhLDg<T>(ControllerType param_0000df8f, int param_0000df90, T param_0000df91, ActionElementMap param_0000df92, bool param_0000df93, bool param_0000df94, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000df95)
					where T : ControllerMap;
				private bool rCWLbLscSTtJFXWAMHzqUevhLDg<T>(ElementAssignmentConflictCheck param_0000df96, bool param_0000df97, bool param_0000df98, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000df99)
					where T : ControllerMap;
				private IEnumerable<ElementAssignmentConflictInfo> XcEtdDcnreaNiJbFAQuTHdzlGEEj<T>(ControllerType param_0000df9a, int param_0000df9b, T param_0000df9c, bool param_0000df9d, bool param_0000df9e, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000df9f)
					where T : ControllerMap;
				private IEnumerable<ElementAssignmentConflictInfo> XcEtdDcnreaNiJbFAQuTHdzlGEEj<T>(ControllerType param_0000dfa0, int param_0000dfa1, T param_0000dfa2, ActionElementMap param_0000dfa3, bool param_0000dfa4, bool param_0000dfa5, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000dfa6)
					where T : ControllerMap;
				private IEnumerable<ElementAssignmentConflictInfo> XcEtdDcnreaNiJbFAQuTHdzlGEEj<T>(ElementAssignmentConflictCheck param_0000dfa7, bool param_0000dfa8, bool param_0000dfa9, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000dfaa)
					where T : ControllerMap;
				private int WjCYeZhDvSvxKcQpcKOBJaKPtus<T>(ControllerType param_0000dfab, int param_0000dfac, T param_0000dfad, bool param_0000dfae, bool param_0000dfaf, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000dfb0)
					where T : ControllerMap;
				private int WjCYeZhDvSvxKcQpcKOBJaKPtus<T>(ControllerType param_0000dfb1, int param_0000dfb2, T param_0000dfb3, ActionElementMap param_0000dfb4, bool param_0000dfb5, bool param_0000dfb6, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000dfb7)
					where T : ControllerMap;
				private int WjCYeZhDvSvxKcQpcKOBJaKPtus<T>(ElementAssignmentConflictCheck param_0000dfb8, bool param_0000dfb9, bool param_0000dfba, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000dfbb)
					where T : ControllerMap;
				private int QuwzUKTytrTXmrjDzPdLAVycjts<T>(ControllerType param_0000dfbc, int param_0000dfbd, T param_0000dfbe, bool param_0000dfbf, bool param_0000dfc0, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000dfc1, List<ActionElementMap> param_0000dfc2 = null)
					where T : ControllerMap;
				private int QuwzUKTytrTXmrjDzPdLAVycjts<T>(ControllerType param_0000dfc3, int param_0000dfc4, T param_0000dfc5, ActionElementMap param_0000dfc6, bool param_0000dfc7, bool param_0000dfc8, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000dfc9, List<ActionElementMap> param_0000dfca = null)
					where T : ControllerMap;
				private int QuwzUKTytrTXmrjDzPdLAVycjts<T>(ElementAssignmentConflictCheck param_0000dfcb, bool param_0000dfcc, bool param_0000dfcd, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000dfce, List<ActionElementMap> param_0000dfcf = null)
					where T : ControllerMap;
				private bool SABKxadsuyVakSFClQoKRWbOjqP(InputMapCategory param_0000dfd0, ControllerMap param_0000dfd1); // 0x0000000180834BD0-0x0000000180834E00
			}
	
			internal interface uwILKJrQnvyPKXqkviwAHMwxglt // TypeDefIndex: 6600
			{
				// Properties
				zPwANwSjcNWfOppJVpCEtGyMPGw MWiOWGzUiqOkOMPKltvfuPDthis[int index] { get => default; }
				ControllerType CGckBVNLLRbsxHptZVYgQLPSxKH { get; }
				int SHujHYUxHggDGFiBfPBtOLtZhMW { get; }
	
				// Methods
				bool Contains(Controller param_0000dfdc);
				bool Contains(int param_0000dfdd);
				void RemoveController(int param_0000dfde);
				void RemoveController(Controller param_0000dfdf);
				void RemoveAt(int param_0000dfe0);
				Controller GetController(int param_0000dfe1);
				Controller GetControllerWithTag(string param_0000dfe2);
				int IndexOf(Controller param_0000dfe3);
				int IndexOf(int param_0000dfe4);
				int IndexOfTag(string param_0000dfe5);
				void Clear();
				zPwANwSjcNWfOppJVpCEtGyMPGw GetEntry(int param_0000dfe6);
				zPwANwSjcNWfOppJVpCEtGyMPGw GetEntry(Controller param_0000dfe7);
				void AddEntry(zPwANwSjcNWfOppJVpCEtGyMPGw param_0000dfe8);
			}
	
			internal interface zPwANwSjcNWfOppJVpCEtGyMPGw // TypeDefIndex: 6601
			{
				// Properties
				sNfUcPzqbmfpkWQZGXbzVNvzIYo rQzQjzZPEBGirpUCdHIDZcYWbNF { get; }
				Controller jbVnEoSGijlOtsPVojcUnqQxqRw { get; }
				float AGsglnLOcnetMiOqoKNEaqYaDAlI { get; }
			}
	
			internal sealed class yuzjpKSgIlOzFrmYoCjvudWJHqg<TController, TMap> : uwILKJrQnvyPKXqkviwAHMwxglt // TypeDefIndex: 6602
				where TController : Controller
				where TMap : ControllerMap
			{
				// Fields
				private List<KvWmrlRvIDMhfmIzEoUOUFQtsIT> BuwIKNnQECuDvuXrWMqVIxlxRgA;
				private List<TController> utSQKhThHRMCyRAztmqTHAWxVeb;
				private ReadOnlyCollection<TController> ZuVolyAKtLblxeZubjdCVedtILQ;
				private readonly ControllerType jVRvmdSGLvngKifezJIAQbIZrmi;
	
				// Properties
				public int SHujHYUxHggDGFiBfPBtOLtZhMW { get; }
				public IList<TController> hCYHQatsbxOCyEdosYKFoCnNnkt { get; }
				public KvWmrlRvIDMhfmIzEoUOUFQtsIT MWiOWGzUiqOkOMPKltvfuPDthis[int index] { get => default; }
				public ControllerType CGckBVNLLRbsxHptZVYgQLPSxKH { get; }
				zPwANwSjcNWfOppJVpCEtGyMPGw RwrcWaBdSKNUOdtlhMnMhslnthis[int index] { get => default; }
	
				// Nested types
				public class KvWmrlRvIDMhfmIzEoUOUFQtsIT : zPwANwSjcNWfOppJVpCEtGyMPGw // TypeDefIndex: 6603
				{
					// Fields
					public TController jbVnEoSGijlOtsPVojcUnqQxqRw;
					public UqmUJOucnPAhoXhVuhvbmxKGsOH<TMap> rQzQjzZPEBGirpUCdHIDZcYWbNF;
					public float AGsglnLOcnetMiOqoKNEaqYaDAlI;
	
					// Properties
					Controller PjXMZKkDeRhnnHXpRsFQkNWeaUa { get; }
					sNfUcPzqbmfpkWQZGXbzVNvzIYo owfBVchPcbnDalFpHCDepzYWmxTA { get; }
					float SfWzvrEQzNiPKoZdejQTwsqivJF { get; }
	
					// Constructors
					public KvWmrlRvIDMhfmIzEoUOUFQtsIT(TController controller, UqmUJOucnPAhoXhVuhvbmxKGsOH<TMap> mapSet);
	
					// Methods
					public void PiIvWOebYJRTGGXjPLJfusqSYgE();
				}
	
				// Constructors
				public yuzjpKSgIlOzFrmYoCjvudWJHqg();
	
				// Methods
				public KvWmrlRvIDMhfmIzEoUOUFQtsIT uDGNCWGQfmuhvDHBSxGtBouWbNb(int param_0000dfea);
				public KvWmrlRvIDMhfmIzEoUOUFQtsIT uDGNCWGQfmuhvDHBSxGtBouWbNb(TController param_0000dfeb);
				public void oaKHEhKiCbesQaMGhlFggnhHCet(KvWmrlRvIDMhfmIzEoUOUFQtsIT param_0000dfec);
				public void RemoveController(int param_0000dfed);
				public void XwNcwiEaatgODGzkmSbKgFgCVEWa(TController param_0000dfee);
				public void RemoveAt(int param_0000dfef);
				public TController vHZICLYpyCcWjWVSNhoczOfMnCG(int param_0000dff0);
				public bool Contains(int param_0000dff1);
				public bool QiqTwdMaCeiulPEUZWQFMcDFHZHG(TController param_0000dff2);
				public int IndexOf(int param_0000dff3);
				public int ItDzbHMiIYGseDXjmhIUEkIaQew(TController param_0000dff4);
				public int IndexOfTag(string param_0000dff5);
				public void Clear();
				zPwANwSjcNWfOppJVpCEtGyMPGw Rewired.Player.ControllerHelper.IControllerSet.GetEntry(int param_0000dff7);
				zPwANwSjcNWfOppJVpCEtGyMPGw Rewired.Player.ControllerHelper.IControllerSet.GetEntry(Controller param_0000dff8);
				void Rewired.Player.ControllerHelper.IControllerSet.AddEntry(zPwANwSjcNWfOppJVpCEtGyMPGw param_0000dff9);
				void Rewired.Player.ControllerHelper.IControllerSet.RemoveController(Controller param_0000dffa);
				Controller Rewired.Player.ControllerHelper.IControllerSet.GetController(int param_0000dffb);
				bool Rewired.Player.ControllerHelper.IControllerSet.Contains(Controller param_0000dffc);
				int Rewired.Player.ControllerHelper.IControllerSet.IndexOf(Controller param_0000dffd);
				Controller Rewired.Player.ControllerHelper.IControllerSet.GetControllerWithTag(string param_0000dffe);
			}
	
			internal class egXAAqgVCShQeuJnjIKIGPUQzKT // TypeDefIndex: 6604
			{
				// Fields
				public readonly int SHujHYUxHggDGFiBfPBtOLtZhMW; // 0x10
				private ControllerType[] qXozjOicCkZQWMdOnmdtBiFcfuy; // 0x18
				private uwILKJrQnvyPKXqkviwAHMwxglt[] DOGjWfNqXhJwrYMCygTRCsZHQkS; // 0x20
	
				// Constructors
				public egXAAqgVCShQeuJnjIKIGPUQzKT(int length); // 0x000000018087BC60-0x000000018087BD00
	
				// Methods
				public uwILKJrQnvyPKXqkviwAHMwxglt VILyHUbxRbFBNVlpaPnEuRjNgLM(int param_0000e001); // 0x000000018087BC20-0x000000018087BC60
				public ControllerType tGyhsBkxYMxCvfukQbFmUfQxatN(int param_0000e002); // 0x000000018087BDB0-0x000000018087BDF0
				public uwILKJrQnvyPKXqkviwAHMwxglt HidcSjbKbECBzYyBnCtcFeYTQWme(ControllerType param_0000e004); // 0x000000018087BB20-0x000000018087BC20
				public void olCMPMvbEidtAtcrerbWKjnDXsq(int param_0000e005, ControllerType param_0000e006, uwILKJrQnvyPKXqkviwAHMwxglt param_0000e007); // 0x000000018087BD00-0x000000018087BDB0
			}
	
			private class jAchFPOUJqmmtMllCTHcROXwbLj // TypeDefIndex: 6605
			{
				// Fields
				private readonly List<KdfyLBQApCbzGOVOOAmpdQFMdzgU> hnpXymCoCCHPwqlDSIZkffYsKwxu; // 0x10
				private readonly Player yHWXapLnjMXUYBDESFaAUIdnziK; // 0x18
	
				// Nested types
				public class KdfyLBQApCbzGOVOOAmpdQFMdzgU // TypeDefIndex: 6606
				{
					// Fields
					public int ApclWZWATFcgBgxbNPQkMDQJKvCT; // 0x10
					public UqmUJOucnPAhoXhVuhvbmxKGsOH<JoystickMap> rQzQjzZPEBGirpUCdHIDZcYWbNF; // 0x18
					public float lFDHcXCTqlOntOoxLiXLgvQIJOsj; // 0x20
	
					// Constructors
					public KdfyLBQApCbzGOVOOAmpdQFMdzgU(int joystickId, UqmUJOucnPAhoXhVuhvbmxKGsOH<JoystickMap> mapSet, float lastConnectedTime); // 0x000000018086B150-0x000000018086B1D0
				}
	
				// Constructors
				public jAchFPOUJqmmtMllCTHcROXwbLj(Player player); // 0x000000018087D7A0-0x000000018087D810
	
				// Methods
				public void lmldbkvCGcJRSRLClxvEdfwGeFAF(Joystick param_0000e009, UqmUJOucnPAhoXhVuhvbmxKGsOH<JoystickMap> param_0000e00a); // 0x000000018087D840-0x000000018087DA50
				public void lmldbkvCGcJRSRLClxvEdfwGeFAF(yuzjpKSgIlOzFrmYoCjvudWJHqg.KvWmrlRvIDMhfmIzEoUOUFQtsIT<Joystick, JoystickMap> param_0000e00b); // 0x000000018087D810-0x000000018087D840
				public void rIBoFCqulfliDqgYQSDqUUlhTyk(); // 0x000000018087DA50-0x000000018087DBE0
				public KdfyLBQApCbzGOVOOAmpdQFMdzgU SJSWnEKwuoLTQVEoRbtWctEUXhl(int param_0000e00c); // 0x000000018087D650-0x000000018087D7A0
				public bool QiqTwdMaCeiulPEUZWQFMcDFHZHG(int param_0000e00d); // 0x000000018087D570-0x000000018087D650
				public int ItDzbHMiIYGseDXjmhIUEkIaQew(int param_0000e00e); // 0x000000018087D470-0x000000018087D570
				public void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x000000018087DBE0-0x000000018087DC30
			}
	
			[Browsable] // 0x00000001800D5150-0x00000001800D5190
			[EditorBrowsable] // 0x00000001800D5150-0x00000001800D5190
			public sealed class MapHelper : CodeHelper // TypeDefIndex: 6607
			{
				// Fields
				private readonly VVLouGbEKulMPcFZiTUTqikUjEp uZAindJKwIucctNndiMpyAASdId; // 0x10
				private Player yHWXapLnjMXUYBDESFaAUIdnziK; // 0x18
				private ControllerHelper GsoDNwSmTlqXUxYxRnLUXMOoArhh; // 0x20
				private readonly ControllerMapEnabler mEPluSgrvSHStUTqLfvUfSdRIBD; // 0x28
				private readonly ControllerMapLayoutManager KKSdtRLTEfvlNthGKcGKiNRvdEEA; // 0x30
				private readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x38
	
				// Properties
				public ControllerMapLayoutManager layoutManager { get; } // 0x0000000180397720-0x0000000180397730 
				public ControllerMapEnabler mapEnabler { get; } // 0x0000000180369B60-0x0000000180369B70 
				public IList<InputBehavior> InputBehaviors { get; } // 0x00000001808EC710-0x00000001808EC7E0 
	
				// Nested types
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class PpjFLnskNUaFvgPSAsrBsQUnVOG : IEnumerable<ControllerMap>, IEnumerator<ControllerMap> // TypeDefIndex: 6608
				{
					// Fields
					private ControllerMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int LnTTYwYqUaZYwdeyRsukFDiffhI; // 0x28
					public int QMWZmrRIyRBQIIbpuZDXuMGtSBM; // 0x2C
					public uwILKJrQnvyPKXqkviwAHMwxglt KieWswpgHqKMcGRiWjdimHKeQuq; // 0x30
					public int ToAidQUCcmqjasgGGrcTxWYPOjm; // 0x38
					public int kMYiKUCvqIkNCJXtthYoeTUXmOU; // 0x3C
					public sNfUcPzqbmfpkWQZGXbzVNvzIYo SYJdtiHRMSKNAJdydGwwsineNccF; // 0x40
					public int pAfSeDHpbyBVDJwhhbGWQAzjzHU; // 0x48
					public int zcCGRMjqnNAILwWIApgZbdGnkwn; // 0x4C
	
					// Properties
					ControllerMap hcosEcMSQqfpybuxojowXuHfzvIU { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public PpjFLnskNUaFvgPSAsrBsQUnVOG(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerMap> IEnumerable<ControllerMap>.GetEnumerator(); // 0x0000000180876E60-0x0000000180876F40
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180876E60-0x0000000180876F40
					private bool MoveNext(); // 0x0000000180876AD0-0x0000000180876E60
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180876F40-0x0000000180876F90
					void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class uDOWLiwoBWXsXQRCdxoiSQelQBI<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 6609
					where T : ControllerMap
				{
					// Fields
					private T aSrFEaALHwhGTdXfCdeUqgbwaZGO;
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL;
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo;
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo;
					public ControllerType RWhZYOqTIjlMJfqWAPeptKFICKff;
					public uwILKJrQnvyPKXqkviwAHMwxglt WbATuKFWFfwevjXAPWbHnxzbuEa;
					public int amISzMpWxngapeyTzKkfgIxuMeA;
					public int eyoNFasBNSqPiIdLFqdGAfwRewig;
					public sNfUcPzqbmfpkWQZGXbzVNvzIYo uCsELMeXguJSJpsXSOrZqrCIlOT;
					public int ZvxLkbTkyWtMXWUyVnbiNpzDYel;
					public int fkifoFeKNgnhofqXbBodzQHpMMKY;
					public int oXGPnFkSwMErBzOmornqpVRZpoj;
					public int bUAAznyZPbTHZLyezwyEdgrVmsT;
					public uwILKJrQnvyPKXqkviwAHMwxglt FZPCaSRCiuWovKxkUKukhqPdBPqF;
					public int RMpvhzvmMPqzsDTKmPshruRIKxd;
					public int tijGrQyNuZUyZRoiOMUxTIicqpi;
					public sNfUcPzqbmfpkWQZGXbzVNvzIYo mhUIbnUDzDDcoWGUzLcrZwuapbt;
					public int SmrjUKFtdZUxDDEmhDicmEgWgEIK;
					public int uHAZMjYdXpSmqsbhQFIvopsTEZt;
					public T PDzHlHICkdzTGSWaRpKzWFaoivaw;
	
					// Properties
					T kdSuZhjZosqvqDiXRzmNfvdMwrh { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public uDOWLiwoBWXsXQRCdxoiSQelQBI(int <>1__state);
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<T> IEnumerable<T>.GetEnumerator();
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator();
					private bool MoveNext();
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset();
					void IDisposable.Dispose();
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class HuAAwsgQIqJtWQlWZgrSgaHIDhbO : IEnumerable<ControllerMap>, IEnumerator<ControllerMap> // TypeDefIndex: 6610
				{
					// Fields
					private ControllerMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public ControllerType CGckBVNLLRbsxHptZVYgQLPSxKH; // 0x28
					public ControllerType PoVlmmPEJptPdkbnGyoBoppGFSXC; // 0x2C
					public uwILKJrQnvyPKXqkviwAHMwxglt tPCpIaQeIpZUCeCzrpkymvgzUvX; // 0x30
					public int NtuSRKzuXeDVRqpbbfqbWkLRyWs; // 0x38
					public int GrOYznvWfNTvOgBxDxxoyOyfebZ; // 0x3C
					public sNfUcPzqbmfpkWQZGXbzVNvzIYo jjwMKeAapYHKLipJwOFUCqbGEOvj; // 0x40
					public int kHwIDtCqEPgmnaagZwGJXDypFiBB; // 0x48
					public int yFDrYOQHpBRrlfHefLJJTTfLsOs; // 0x4C
	
					// Properties
					ControllerMap hcosEcMSQqfpybuxojowXuHfzvIU { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public HuAAwsgQIqJtWQlWZgrSgaHIDhbO(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerMap> IEnumerable<ControllerMap>.GetEnumerator(); // 0x00000001808D6FE0-0x00000001808D70E0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001808D6FE0-0x00000001808D70E0
					private bool MoveNext(); // 0x00000001808D6CF0-0x00000001808D6FE0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x00000001808D70E0-0x00000001808D7130
					void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class EJgQWVwFTpZqGDsRReAnPTQBApR : IEnumerable<ControllerMap>, IEnumerator<ControllerMap> // TypeDefIndex: 6611
				{
					// Fields
					private ControllerMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int dowbRlGIIniWSeAGysskFGgBremp; // 0x28
					public int KsrdqTrgHEoQODZSdprvCFDgWBr; // 0x2C
					public int WWyGdIWNbYkTyZFwVKbRiIFQvUW; // 0x30
					public int yDPtboNsLbSvDeRGDVMXnUHWhcu; // 0x34
					public uwILKJrQnvyPKXqkviwAHMwxglt HbtZpcMKJZITqknzuKkpWswdtkci; // 0x38
					public int YJxZffRTQNHBZtOniGdaLroTja; // 0x40
					public int orPPWNbGvIhjfEgdniYaDZvcjpz; // 0x44
					public sNfUcPzqbmfpkWQZGXbzVNvzIYo xnYFuBFTRwxkITwZYMSrlFEsnuw; // 0x48
					public int bTWmBIeGTBIfEmkhkiICcSNMuRxE; // 0x50
					public int vDZzGfmPTAhmNlkwhtZGHUIbjNP; // 0x54
					public ControllerMap vvFKezXGPQHihJVwWmVcHOMKSOi; // 0x58
	
					// Properties
					ControllerMap hcosEcMSQqfpybuxojowXuHfzvIU { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public EJgQWVwFTpZqGDsRReAnPTQBApR(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerMap> IEnumerable<ControllerMap>.GetEnumerator(); // 0x00000001808D6B60-0x00000001808D6CA0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001808D6B60-0x00000001808D6CA0
					private bool MoveNext(); // 0x00000001808D6780-0x00000001808D6B60
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x00000001808D6CA0-0x00000001808D6CF0
					void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class NNEtiJNjkQfzMVjmMfmJWhAhmxO<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 6612
					where T : ControllerMap
				{
					// Fields
					private T aSrFEaALHwhGTdXfCdeUqgbwaZGO;
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL;
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo;
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo;
					public int dowbRlGIIniWSeAGysskFGgBremp;
					public int KsrdqTrgHEoQODZSdprvCFDgWBr;
					public ControllerType GMIXHXiddLaSxaqBnHppyLAjESCe;
					public uwILKJrQnvyPKXqkviwAHMwxglt pRlcxLtpTBFCUUTJVHDNSParrNC;
					public int pQxGiAHgOHoxRzHHQGlcrbvsnwT;
					public int chubRKUSdcldFnfWfZJSkUACnnN;
					public sNfUcPzqbmfpkWQZGXbzVNvzIYo QUQJkmgiCzpKyjJIVVsrgJDKcko;
					public int cELWHfvIwBStdLdbmskCveWzdKuK;
					public int jchKQBAoAVHJWtopQflzQcfLhDi;
					public ControllerMap lEJdPVUXQdEkEqHRAkXmUnuwRtR;
					public int qBCmnQqihIXqrpbfHYqjGGinKjy;
					public int wqocdqmPOpDhWruShPGTGwLQfCE;
					public uwILKJrQnvyPKXqkviwAHMwxglt kpHFBahyKhhdGWypGxtQpqyzQYfp;
					public int NTougxwPYxwBPHuDHBTjAjcPSAi;
					public int ifdtXvyDfFTOafJmrspLzkMjYBj;
					public sNfUcPzqbmfpkWQZGXbzVNvzIYo OpWlWkNjsIVRZhFevVQIBsLrYBu;
					public int AeQMObKMqdKeVMxkDKvjdyGUeAd;
					public int OEsGpIFFOMasIkfRvhVqBJSUEYW;
					public T tBXNgbmOGBMnkLONKVkrlIourtx;
	
					// Properties
					T kdSuZhjZosqvqDiXRzmNfvdMwrh { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public NNEtiJNjkQfzMVjmMfmJWhAhmxO(int <>1__state);
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<T> IEnumerable<T>.GetEnumerator();
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator();
					private bool MoveNext();
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset();
					void IDisposable.Dispose();
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class qsLwYlbXLKLMXzzlSdgFscZncBJ : IEnumerable<ControllerMap>, IEnumerator<ControllerMap> // TypeDefIndex: 6613
				{
					// Fields
					private ControllerMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int dowbRlGIIniWSeAGysskFGgBremp; // 0x28
					public int KsrdqTrgHEoQODZSdprvCFDgWBr; // 0x2C
					public ControllerType CGckBVNLLRbsxHptZVYgQLPSxKH; // 0x30
					public ControllerType PoVlmmPEJptPdkbnGyoBoppGFSXC; // 0x34
					public uwILKJrQnvyPKXqkviwAHMwxglt rAGJqfCYatBJaYfmQVjGtdsXZYH; // 0x38
					public int HkRMVTybjKmhTHdHDoEdCNypPOr; // 0x40
					public int WbGBKEBWuwfITOGDfFzFnADMOfdf; // 0x44
					public sNfUcPzqbmfpkWQZGXbzVNvzIYo sAxnCQaJdkTTBigoYaYEPUMByyY; // 0x48
					public int aUeJnGtDMPXqbDBUlQLUreqNekj; // 0x50
					public int cFmzrFKwGjYLfhbOhfOtOckLgjvc; // 0x54
					public ControllerMap tEKnpSnlYHsgKMfucifilFVElou; // 0x58
	
					// Properties
					ControllerMap hcosEcMSQqfpybuxojowXuHfzvIU { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public qsLwYlbXLKLMXzzlSdgFscZncBJ(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerMap> IEnumerable<ControllerMap>.GetEnumerator(); // 0x00000001808806F0-0x00000001808807F0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001808806F0-0x00000001808807F0
					private bool MoveNext(); // 0x00000001808801D0-0x00000001808806F0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x00000001808807F0-0x0000000180880840
					void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class wFLPuxxmtKMbqMAUJfaQMfkEapMJ : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6614
				{
					// Fields
					private ActionElementMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int OQcyWgBmnPWCLAcqVAqEsHoBwiC; // 0x28
					public int QxHmeEAGmVFnLuiDvwBgXueGYzo; // 0x2C
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x30
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x31
					public int ShzdWTThsLUNJKzkmnWmlXrcDnG; // 0x34
					public int gtsfkogVcNsjUjMSfrCWeLHjhLEd; // 0x38
					public uwILKJrQnvyPKXqkviwAHMwxglt VITEvZSlgZsmAhFpFErqBVsxFZH; // 0x40
					public int DXytjoZntKwUFusxHInqouDWHwN; // 0x48
					public int pRUdaJxTKJGCOfCDxpBHSvTkFfr; // 0x4C
					public sNfUcPzqbmfpkWQZGXbzVNvzIYo CCZvxqJVrpsJbQmGwFvMhyYPzcZ; // 0x50
					public int BkvYKBUkwugHkjibIDalLQkJTLnN; // 0x58
					public int xKJXSPPQhrvfRRsmoAbNflMGdPk; // 0x5C
					public ControllerMap uVcTfwtjHOmUDLloeGgrJubtUlz; // 0x60
					public ActionElementMap jgmDsWJWePBjiGBONEMHGnComkl; // 0x68
					public IEnumerator<ActionElementMap> COBYsEMXioctseShXsOYKPBXIAgi; // 0x70
	
					// Properties
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public wFLPuxxmtKMbqMAUJfaQMfkEapMJ(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x0000000180883DA0-0x0000000180883EB0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180883DA0-0x0000000180883EB0
					private bool MoveNext(); // 0x0000000180883770-0x0000000180883C90
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180883EB0-0x0000000180883F00
					void IDisposable.Dispose(); // 0x0000000180883F00-0x0000000180883F70
					private void SuDpvywRnkhZqGQDCrTkbWRlpbt(); // 0x0000000180883C90-0x0000000180883DA0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class wAjumWVzHYdtszNmTTAxnCJrIUg : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6615
				{
					// Fields
					private ActionElementMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int OQcyWgBmnPWCLAcqVAqEsHoBwiC; // 0x28
					public int QxHmeEAGmVFnLuiDvwBgXueGYzo; // 0x2C
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x30
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x31
					public int awfiUVEWlOjEuSLPSeSnvyrXqYX; // 0x34
					public int FBMUfvOhXnFxnWWJOEscwbYbcwl; // 0x38
					public uwILKJrQnvyPKXqkviwAHMwxglt YPyAxwcFhwPgDkXiyehHTIlnTPH; // 0x40
					public int gCJJdbHxJVkZUGMmxrNWqCWltUY; // 0x48
					public int prsMODqydXIEPzljhNtkzFiDaaY; // 0x4C
					public sNfUcPzqbmfpkWQZGXbzVNvzIYo XeyCdhKbNuZrrdbhCPbJzXCsfgIP; // 0x50
					public int XATMQWxWQNnAQVnEHSFmQCpaog; // 0x58
					public int sbEIGTyDhzDkUYOQkSqTKUfUnzO; // 0x5C
					public ControllerMapWithAxes EXyaiVxpOJkEmFRGezAvLfnOYgB; // 0x60
					public ActionElementMap VXEhhobqifgydTFLbEYpvlIhXhU; // 0x68
					public IEnumerator<ActionElementMap> ngHzBAMfApJbkqmlynJnzAMoAah; // 0x70
	
					// Properties
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public wAjumWVzHYdtszNmTTAxnCJrIUg(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x0000000180883450-0x00000001808835C0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180883450-0x00000001808835C0
					private bool MoveNext(); // 0x0000000180882EE0-0x0000000180883450
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x00000001808835C0-0x0000000180883610
					void IDisposable.Dispose(); // 0x0000000180883610-0x0000000180883680
					private void uYCbFxJgUPfIUiVCKDgjPfcnROFa(); // 0x0000000180883680-0x0000000180883770
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class gfvNoukMzddCvglLpYruxjzhAxV : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6616
				{
					// Fields
					private ActionElementMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int OQcyWgBmnPWCLAcqVAqEsHoBwiC; // 0x28
					public int QxHmeEAGmVFnLuiDvwBgXueGYzo; // 0x2C
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x30
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x31
					public int TYwxwBdXjzKYKaWAvAFiANMYaNM; // 0x34
					public int MpvNDUHagIsoJmhfYyWJfMTuLvQ; // 0x38
					public uwILKJrQnvyPKXqkviwAHMwxglt oiPRHegMJTzXFaFgOQCBcdYvwTk; // 0x40
					public int YjjdaWbtlkgllwpueANSTOwQSSs; // 0x48
					public int hIOPAbfkLGxauKrlavDTRWglmpM; // 0x4C
					public sNfUcPzqbmfpkWQZGXbzVNvzIYo miHfLbSIrWZXcWrmoYzemOpxlSB; // 0x50
					public int IxPFXlihjZWrrDfrAoPTZzUFxSPu; // 0x58
					public int WCobQoYHkDbwYOFztckttkLhATg; // 0x5C
					public ControllerMap pipjrjRhIHOjFdBxzubVvZhacLt; // 0x60
					public ActionElementMap ExhsSAERYBDpreCdIHHWFghNsar; // 0x68
					public IEnumerator<ActionElementMap> pyGBmIHinQBLjDzWdpSqQWlLMVEm; // 0x70
	
					// Properties
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public gfvNoukMzddCvglLpYruxjzhAxV(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x000000018087D160-0x000000018087D260
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018087D160-0x000000018087D260
					private bool MoveNext(); // 0x000000018087CC40-0x000000018087D160
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018087D260-0x000000018087D2B0
					void IDisposable.Dispose(); // 0x000000018087D2B0-0x000000018087D370
					private void jNCbkpEvKJlNgDwiftxpwhVvtvsb(); // 0x000000018087D370-0x000000018087D470
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class VQIEFeTtUHkPEVcCYHXPJbfRHQnJ : IEnumerable<ControllerMap>, IEnumerator<ControllerMap> // TypeDefIndex: 6617
				{
					// Fields
					private ControllerMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public ControllerType CGckBVNLLRbsxHptZVYgQLPSxKH; // 0x28
					public ControllerType PoVlmmPEJptPdkbnGyoBoppGFSXC; // 0x2C
					public int AkkOxeFFauQvLEuBcHkzXcxVDoLa; // 0x30
					public int HiUejrNlCkcqLEXEYrOZVhlGqJDR; // 0x34
					public int dowbRlGIIniWSeAGysskFGgBremp; // 0x38
					public int KsrdqTrgHEoQODZSdprvCFDgWBr; // 0x3C
					public uwILKJrQnvyPKXqkviwAHMwxglt dAGMPrnAJfNSZifeacRdqFgQIpp; // 0x40
					public int EjYyNKPCDmHiwipiaMUrcmseErQ; // 0x48
					public IList<ControllerMap> vqVdoQAyWfLISnsYuJHczovWcdg; // 0x50
					public int wcxhqEtRuKOWTbFizDmwtegwhAY; // 0x58
	
					// Properties
					ControllerMap hcosEcMSQqfpybuxojowXuHfzvIU { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public VQIEFeTtUHkPEVcCYHXPJbfRHQnJ(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerMap> IEnumerable<ControllerMap>.GetEnumerator(); // 0x0000000180878DB0-0x0000000180878F10
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180878DB0-0x0000000180878F10
					private bool MoveNext(); // 0x0000000180878960-0x0000000180878DB0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180878F10-0x0000000180878F60
					void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class AzcdhbVEpZvVURNXZcZsCGbsIni<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 6618
					where T : ControllerMap
				{
					// Fields
					private T aSrFEaALHwhGTdXfCdeUqgbwaZGO;
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL;
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo;
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo;
					public int AkkOxeFFauQvLEuBcHkzXcxVDoLa;
					public int HiUejrNlCkcqLEXEYrOZVhlGqJDR;
					public int dowbRlGIIniWSeAGysskFGgBremp;
					public int KsrdqTrgHEoQODZSdprvCFDgWBr;
					public ControllerType WNkCKiIRNTlBieHhFQEIgvlxkpzJ;
					public uwILKJrQnvyPKXqkviwAHMwxglt MWUWjFGfUyfOotLRiaiqdbdufLK;
					public int GrGnsnXZvmIMaykwsHEgFnmdCeVd;
					public IList<T> CkNAXJkEMnEuYfyTHAXtdxTsnSb;
					public int sMmEpuvhFKbpmEDHFLJsDfFWBlV;
	
					// Properties
					T kdSuZhjZosqvqDiXRzmNfvdMwrh { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public AzcdhbVEpZvVURNXZcZsCGbsIni(int <>1__state);
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<T> IEnumerable<T>.GetEnumerator();
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator();
					private bool MoveNext();
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset();
					void IDisposable.Dispose();
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class uNzNaiXgPJRRtupkvIjXHfOQFVs : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6619
				{
					// Fields
					private ActionElementMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public ControllerType CGckBVNLLRbsxHptZVYgQLPSxKH; // 0x28
					public ControllerType PoVlmmPEJptPdkbnGyoBoppGFSXC; // 0x2C
					public int OQcyWgBmnPWCLAcqVAqEsHoBwiC; // 0x30
					public int QxHmeEAGmVFnLuiDvwBgXueGYzo; // 0x34
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x38
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x39
					public uwILKJrQnvyPKXqkviwAHMwxglt LYoZLXatjplHotFXYvFedrNCvac; // 0x40
					public int EAvWlpAIpTSOAYgezAsjewDZNpB; // 0x48
					public IList<ControllerMap> rnubUkgUqmusWgpRzTUsnrGzQrv; // 0x50
					public int hZOMHwGLexSOcZicGAFtcVYDJZEF; // 0x58
					public ActionElementMap KAcEunNkyWsrIYZUYHmpjKBmuOJ; // 0x60
					public IEnumerator<ActionElementMap> KksIqMsrBhmzkVPmBkgOSnQlPOo; // 0x68
	
					// Properties
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public uNzNaiXgPJRRtupkvIjXHfOQFVs(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x0000000180881D10-0x0000000180881E80
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180881D10-0x0000000180881E80
					private bool MoveNext(); // 0x0000000180881880-0x0000000180881D10
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180881E80-0x0000000180881ED0
					void IDisposable.Dispose(); // 0x0000000180881ED0-0x0000000180881F40
					private void vjCmAiNjHwTktzZlmuuvOVWpAam(); // 0x0000000180881F40-0x0000000180882050
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class vhgkykkTQBwAcjiiKixzoviLeql : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6620
				{
					// Fields
					private ActionElementMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public ControllerType CGckBVNLLRbsxHptZVYgQLPSxKH; // 0x28
					public ControllerType PoVlmmPEJptPdkbnGyoBoppGFSXC; // 0x2C
					public int OQcyWgBmnPWCLAcqVAqEsHoBwiC; // 0x30
					public int QxHmeEAGmVFnLuiDvwBgXueGYzo; // 0x34
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x38
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x39
					public uwILKJrQnvyPKXqkviwAHMwxglt RAOjBWDRaGezPkCtFqZtXjwRbHFx; // 0x40
					public int kPwaeRqNXXCSXffXqNpgggNDTWfc; // 0x48
					public IList<ControllerMap> WmpEiheEgoFGhJWtuvFkfzwxlts; // 0x50
					public int ZvuGvRgOFjTJQeKsTPooDYCHyhKH; // 0x58
					public ActionElementMap uzhJmwGkOpdLKGlTimYGqeBOAQB; // 0x60
					public IEnumerator<ActionElementMap> oRzEDAxpcBDypcHHwCBNxNCnylXi; // 0x68
	
					// Properties
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public vhgkykkTQBwAcjiiKixzoviLeql(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x0000000180882C50-0x0000000180882D90
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180882C50-0x0000000180882D90
					private bool MoveNext(); // 0x0000000180882720-0x0000000180882C50
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180882D90-0x0000000180882DE0
					void IDisposable.Dispose(); // 0x0000000180882DE0-0x0000000180882E90
					private void cQwCABvOuQEbfdiuPfHjkbtxoxCR(); // 0x0000000180882E90-0x0000000180882EE0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class ekYMYIzNFvfNvriZWxLUNiLTiLH : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6621
				{
					// Fields
					private ActionElementMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public ControllerType CGckBVNLLRbsxHptZVYgQLPSxKH; // 0x28
					public ControllerType PoVlmmPEJptPdkbnGyoBoppGFSXC; // 0x2C
					public int OQcyWgBmnPWCLAcqVAqEsHoBwiC; // 0x30
					public int QxHmeEAGmVFnLuiDvwBgXueGYzo; // 0x34
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x38
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x39
					public uwILKJrQnvyPKXqkviwAHMwxglt tpucywtNEUfmykLwFrEBTlEMcWj; // 0x40
					public int zQyUgHoOcLAvlisEvpxlZGxiPsOy; // 0x48
					public IList<ControllerMap> LtvcBukfDIJJRpzyrgtsSdqlJgw; // 0x50
					public int RGDCvmWIpVwCnmIXZEUCAtQMvpKi; // 0x58
					public ActionElementMap rTsvRFqIOVeFKgskvBSLCgEMmKHL; // 0x60
					public IEnumerator<ActionElementMap> nCfYQZRPFCSmrgsHsrHRSgCwYIa; // 0x68
	
					// Properties
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public ekYMYIzNFvfNvriZWxLUNiLTiLH(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x000000018087C2D0-0x000000018087C3E0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018087C2D0-0x000000018087C3E0
					private bool MoveNext(); // 0x000000018087BDF0-0x000000018087C280
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018087C3E0-0x000000018087C430
					void IDisposable.Dispose(); // 0x000000018087C430-0x000000018087C4E0
					private void OJpgGMGcRQgnWxzbqhJNdoDgVTXL(); // 0x000000018087C280-0x000000018087C2D0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class cAOpYMMifsDOzfJJHITxAOJHbOYk : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6622
				{
					// Fields
					private ActionElementMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public ControllerType CGckBVNLLRbsxHptZVYgQLPSxKH; // 0x28
					public ControllerType PoVlmmPEJptPdkbnGyoBoppGFSXC; // 0x2C
					public int AkkOxeFFauQvLEuBcHkzXcxVDoLa; // 0x30
					public int HiUejrNlCkcqLEXEYrOZVhlGqJDR; // 0x34
					public int OQcyWgBmnPWCLAcqVAqEsHoBwiC; // 0x38
					public int QxHmeEAGmVFnLuiDvwBgXueGYzo; // 0x3C
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x40
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x41
					public uwILKJrQnvyPKXqkviwAHMwxglt SlCAJMugukjADqsEOZXHJbsgteg; // 0x48
					public int NDuJCnBuBhfhWbKSScExLyieooG; // 0x50
					public IList<ControllerMap> nNnDnBCPvuhcqPvAKcijGSVKKYaN; // 0x58
					public int nNkdVZfzkIhoXPVeAUWfaGNMKSW; // 0x60
					public ActionElementMap zMoPKHlGvCgrnWeQzapkNyEJvaQ; // 0x68
					public IEnumerator<ActionElementMap> hgIxCXCCtKFDpGTnWGVcFlwjXYiu; // 0x70
	
					// Properties
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public cAOpYMMifsDOzfJJHITxAOJHbOYk(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x000000018087B890-0x000000018087B9B0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018087B890-0x000000018087B9B0
					private bool MoveNext(); // 0x000000018087B350-0x000000018087B890
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018087B9B0-0x000000018087BA00
					void IDisposable.Dispose(); // 0x000000018087BA00-0x000000018087BAD0
					private void vOCkLguFhcPfzjPXdZGRzfzmYxp(); // 0x000000018087BAD0-0x000000018087BB20
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class SXaIYhzgPtQEtrfUreUeadbEUljR : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6623
				{
					// Fields
					private ActionElementMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public ControllerType CGckBVNLLRbsxHptZVYgQLPSxKH; // 0x28
					public ControllerType PoVlmmPEJptPdkbnGyoBoppGFSXC; // 0x2C
					public int AkkOxeFFauQvLEuBcHkzXcxVDoLa; // 0x30
					public int HiUejrNlCkcqLEXEYrOZVhlGqJDR; // 0x34
					public int OQcyWgBmnPWCLAcqVAqEsHoBwiC; // 0x38
					public int QxHmeEAGmVFnLuiDvwBgXueGYzo; // 0x3C
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x40
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x41
					public uwILKJrQnvyPKXqkviwAHMwxglt MiIFsxpiagHKuSpDJQfIppmTGzd; // 0x48
					public int EwYCNSAPFwVxlnzxDJTEdWSQFlJE; // 0x50
					public IList<ControllerMap> ieokKdUBbiOXGzoMqfIQydTLWgb; // 0x58
					public int rbZyYLgRhXIjSTlFhtApPRaXbQG; // 0x60
					public ActionElementMap WIcKGAqrBAGzFDCnHYcFBdFwNAYd; // 0x68
					public IEnumerator<ActionElementMap> XaUqGameKoMoLEaQwpMyidKMMCR; // 0x70
	
					// Properties
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public SXaIYhzgPtQEtrfUreUeadbEUljR(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x0000000180877E10-0x0000000180877F50
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180877E10-0x0000000180877F50
					private bool MoveNext(); // 0x0000000180877740-0x0000000180877D00
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180877F50-0x0000000180877FA0
					void IDisposable.Dispose(); // 0x0000000180877FA0-0x0000000180878010
					private void OyWIUVoGYxCZKrerbcwBmdgCYBC(); // 0x0000000180877D00-0x0000000180877E10
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class sjOgsiJvvUKvJScVzqozNcvEizZA : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6624
				{
					// Fields
					private ActionElementMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public ControllerType CGckBVNLLRbsxHptZVYgQLPSxKH; // 0x28
					public ControllerType PoVlmmPEJptPdkbnGyoBoppGFSXC; // 0x2C
					public int AkkOxeFFauQvLEuBcHkzXcxVDoLa; // 0x30
					public int HiUejrNlCkcqLEXEYrOZVhlGqJDR; // 0x34
					public int OQcyWgBmnPWCLAcqVAqEsHoBwiC; // 0x38
					public int QxHmeEAGmVFnLuiDvwBgXueGYzo; // 0x3C
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x40
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x41
					public uwILKJrQnvyPKXqkviwAHMwxglt rIASchtVDhVFNtGxZeJoVftFXxC; // 0x48
					public int kDrbbAHXHOaZuqRGqFTomPPgZrDA; // 0x50
					public IList<ControllerMap> CMfVnzPYgFfeksvaGWBhewQhFEb; // 0x58
					public int pRQdChmyxNtFOXqMnmzgrdNMcky; // 0x60
					public ActionElementMap QdTfmpBXylfifGQMTdPRfHSBpjsz; // 0x68
					public IEnumerator<ActionElementMap> hIcrLRbfPuVhHPHwdYHYDolfEifD; // 0x70
	
					// Properties
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public sjOgsiJvvUKvJScVzqozNcvEizZA(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001808814F0-0x0000000180881670
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001808814F0-0x0000000180881670
					private bool MoveNext(); // 0x0000000180880FC0-0x00000001808814F0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180881670-0x00000001808816C0
					void IDisposable.Dispose(); // 0x00000001808816C0-0x0000000180881770
					private void nVMCFVFgBmyHorsZfTSmkMtpqOx(); // 0x0000000180881770-0x0000000180881880
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class DttafkbbGCWlpehfzhcGLhhkfCY : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6625
				{
					// Fields
					private ActionElementMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public MapHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public IControllerElementTarget VFwMDZMYrBvQvqPfgitohgKyAGR; // 0x28
					public IControllerElementTarget nCYudTpjINOmBpcFqbImQYuVzYO; // 0x30
					public bool pmHDFWKrTdQilCfvVICBAZTENyn; // 0x38
					public bool MjkXSOECrLUZazxqODRPiImqYpW; // 0x39
					public int OQcyWgBmnPWCLAcqVAqEsHoBwiC; // 0x3C
					public int QxHmeEAGmVFnLuiDvwBgXueGYzo; // 0x40
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x44
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x45
					public Controller yFkMYpbfRPFzVJTjgoatfddwQAW; // 0x48
					public uwILKJrQnvyPKXqkviwAHMwxglt zPtgClFXZFYbKgweXHcKoQfztYF; // 0x50
					public int edZLaSAGGksDrZNJcpKMIWuoeJk; // 0x58
					public int XbJzVuHkGJaenoiXcZPrldXKcfq; // 0x5C
					public sNfUcPzqbmfpkWQZGXbzVNvzIYo fcQBXNpKPDGSALQOwzyqtBQAhNX; // 0x60
					public IList<ControllerMap> agDEYcHqbVjWQPBmcMXHMsoMHhr; // 0x68
					public int aygtdkJQJLRAGaaCYGymaKZaDwH; // 0x70
					public int iXpwDDdmYpObjPFzfeNZWBPJHMQ; // 0x74
					public ControllerMap BMrdtqRZcrWiWvcOphPCKKTJkFiP; // 0x78
					public TempListPool.TList<ActionElementMap> NhPJAVfuaFTaKYCdSoKGVilpKQX; // 0x80
					public List<ActionElementMap> aCEfKzikverUnQhplMrwBNEqryqb; // 0x88
					public bool vOqkohsFIniCMqNzOYXrLxHBOEi; // 0x90
					public ActionElementMap QbMWVmvskQSUktZoUVJATGJhyvW; // 0x98
					public List<ActionElementMap> anBfrpIVZQBdXTzZZBfYyzPJyDW; // 0xA0
	
					// Properties
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public DttafkbbGCWlpehfzhcGLhhkfCY(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001808D6350-0x00000001808D64C0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001808D6350-0x00000001808D64C0
					private bool MoveNext(); // 0x00000001808D5E60-0x00000001808D6350
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x00000001808D64C0-0x00000001808D6510
					void IDisposable.Dispose(); // 0x00000001808D6510-0x00000001808D6610
					private void iBNEFvDxBNrecocohZJfaqBbbuod(); // 0x00000001808D6610-0x00000001808D6730
					private void nfSyBxkKKDgwlZFLDGyFJULCDneE(); // 0x00000001808D6730-0x00000001808D6780
				}
	
				// Constructors
				internal MapHelper(Player player, ControllerHelper parent, VVLouGbEKulMPcFZiTUTqikUjEp startingControllerMapInfo, ControllerMapLayoutManager.StartingSettings controllerMapLayoutManagerSettings, ControllerMapEnabler.ZgESyvoCZDaaWJMTaxFmFrlTHlVN controllerMapEnablerSettings); // 0x00000001808EB320-0x00000001808EB490
	
				// Methods
				public void LoadMap<T>(int controllerId, int categoryId, int layoutId)
					where T : ControllerMap;
				public void LoadMap<T>(int controllerId, string categoryName, string layoutName)
					where T : ControllerMap;
				public void LoadMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId); // 0x00000001808E51A0-0x00000001808E51D0
				public void LoadMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName); // 0x00000001808E51D0-0x00000001808E5200
				public void LoadMap<T>(int controllerId, int categoryId, int layoutId, bool startEnabled)
					where T : ControllerMap;
				public void LoadMap<T>(int controllerId, string categoryName, string layoutName, bool startEnabled)
					where T : ControllerMap;
				public void LoadMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId, bool startEnabled); // 0x00000001808E5240-0x00000001808E5280
				public void LoadMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName, bool startEnabled); // 0x00000001808E5200-0x00000001808E5240
				private void lzRURLodCXjlaMATvFEbJFSRQAus<T>(int param_0000e037, int param_0000e038, int param_0000e039, BoolOption param_0000e03a)
					where T : ControllerMap;
				private void lzRURLodCXjlaMATvFEbJFSRQAus<T>(int param_0000e03b, string param_0000e03c, string param_0000e03d, BoolOption param_0000e03e)
					where T : ControllerMap;
				private void lzRURLodCXjlaMATvFEbJFSRQAus(ControllerType param_0000e03f, int param_0000e040, int param_0000e041, int param_0000e042, BoolOption param_0000e043); // 0x00000001808EDA50-0x00000001808EDB30
				private void lzRURLodCXjlaMATvFEbJFSRQAus(ControllerType param_0000e044, int param_0000e045, string param_0000e046, string param_0000e047, BoolOption param_0000e048); // 0x00000001808ED940-0x00000001808EDA50
				public IEnumerable<ControllerMap> GetAllMaps(); // 0x00000001808DDED0-0x00000001808DDF40
				public int GetAllMaps(List<ControllerMap> results); // 0x00000001808DDA80-0x00000001808DDED0
				public IEnumerable<T> GetAllMaps<T>()
					where T : ControllerMap;
				public int GetAllMaps<T>(List<T> results)
					where T : ControllerMap;
				public IEnumerable<ControllerMap> GetAllMaps(ControllerType controllerType); // 0x00000001808DE370-0x00000001808DE420
				public int GetAllMaps(ControllerType controllerType, List<ControllerMap> results); // 0x00000001808DDF40-0x00000001808DE370
				public IEnumerable<ControllerMap> GetAllMapsInCategory(string categoryName); // 0x00000001808DD5F0-0x00000001808DD7B0
				public IEnumerable<ControllerMap> GetAllMapsInCategory(int categoryId); // 0x00000001808DCA40-0x00000001808DCAF0
				public IEnumerable<T> GetAllMapsInCategory<T>(string categoryName)
					where T : ControllerMap;
				public IEnumerable<T> GetAllMapsInCategory<T>(int categoryId)
					where T : ControllerMap;
				public IEnumerable<ControllerMap> GetAllMapsInCategory(string categoryName, ControllerType controllerType); // 0x00000001808DCFE0-0x00000001808DD1B0
				public IEnumerable<ControllerMap> GetAllMapsInCategory(int categoryId, ControllerType controllerType); // 0x00000001808DD7B0-0x00000001808DD870
				public int GetAllMapsInCategory(string categoryName, List<ControllerMap> results); // 0x00000001808DD980-0x00000001808DDA80
				public int GetAllMapsInCategory(int categoryId, List<ControllerMap> results); // 0x00000001808DCAF0-0x00000001808DCFE0
				public int GetAllMapsInCategory<T>(string categoryName, List<T> results)
					where T : ControllerMap;
				public int GetAllMapsInCategory<T>(int categoryId, List<T> results)
					where T : ControllerMap;
				public int GetAllMapsInCategory(string categoryName, ControllerType controllerType, List<ControllerMap> results); // 0x00000001808DD870-0x00000001808DD980
				public int GetAllMapsInCategory(int categoryId, ControllerType controllerType, List<ControllerMap> results); // 0x00000001808DD1B0-0x00000001808DD5F0
				public IList<T> GetMaps<T>(int controllerId)
					where T : ControllerMap;
				public IList<ControllerMap> GetMaps(ControllerType controllerType, int controllerId); // 0x00000001808E48D0-0x00000001808E49A0
				public IList<ControllerMap> GetMaps(Controller controller); // 0x00000001808E49A0-0x00000001808E4B20
				public IEnumerable<ControllerMap> GetMapsInCategory(ControllerType controllerType, int controllerId, int categoryId); // 0x00000001808E44C0-0x00000001808E4660
				public IEnumerable<ControllerMap> GetMapsInCategory(ControllerType controllerType, int controllerId, string categoryName); // 0x00000001808E4660-0x00000001808E47B0
				public IEnumerable<ControllerMap> GetMapsInCategory(Controller controller, int categoryId); // 0x00000001808E42C0-0x00000001808E43A0
				public IEnumerable<ControllerMap> GetMapsInCategory(Controller controller, string categoryName); // 0x00000001808E43A0-0x00000001808E44C0
				public int GetMapsInCategory(ControllerType controllerType, int controllerId, int categoryId, List<ControllerMap> results); // 0x00000001808E3DF0-0x00000001808E4040
				public int GetMapsInCategory(ControllerType controllerType, int controllerId, string categoryName, List<ControllerMap> results); // 0x00000001808E4190-0x00000001808E42C0
				public int GetMapsInCategory(Controller controller, int categoryId, List<ControllerMap> results); // 0x00000001808E47B0-0x00000001808E48D0
				public int GetMapsInCategory(Controller controller, string categoryName, List<ControllerMap> results); // 0x00000001808E4040-0x00000001808E4190
				public IEnumerable<T> GetMapsInCategory<T>(int controllerId, int categoryId)
					where T : ControllerMap;
				public IEnumerable<T> GetMapsInCategory<T>(int controllerId, string categoryName)
					where T : ControllerMap;
				public int GetMapsInCategory<T>(int controllerId, int categoryId, List<T> results)
					where T : ControllerMap;
				public int GetMapsInCategory<T>(int controllerId, string categoryName, List<T> results)
					where T : ControllerMap;
				public T GetMap<T>(int controllerId, int mapId)
					where T : ControllerMap;
				public T GetMap<T>(int controllerId, int categoryId, int layoutId)
					where T : ControllerMap;
				public T GetMap<T>(int controllerId, string categoryName, string layoutName)
					where T : ControllerMap;
				public ControllerMap GetMap(int mapId); // 0x00000001808E3280-0x00000001808E36A0
				public ControllerMap GetMap(ControllerType controllerType, int controllerId, int mapId); // 0x00000001808E36A0-0x00000001808E3780
				public ControllerMap GetMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId); // 0x00000001808E39D0-0x00000001808E3AC0
				public ControllerMap GetMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName); // 0x00000001808E38F0-0x00000001808E39D0
				public ControllerMap GetMap(Controller controller, int mapId); // 0x00000001808E3AC0-0x00000001808E3C30
				public ControllerMap GetMap(Controller controller, int categoryId, int layoutId); // 0x00000001808E3780-0x00000001808E38F0
				public ControllerMap GetMap(Controller controller, string categoryName, string layoutName); // 0x00000001808E3C30-0x00000001808E3DF0
				public T GetFirstMapInCategory<T>(int controllerId, string categoryName)
					where T : ControllerMap;
				public T GetFirstMapInCategory<T>(int controllerId, int categoryId)
					where T : ControllerMap;
				public ControllerMap GetFirstMapInCategory(ControllerType controllerType, int controllerId, string categoryName); // 0x00000001808E2CB0-0x00000001808E2E00
				public ControllerMap GetFirstMapInCategory(ControllerType controllerType, int controllerId, int categoryId); // 0x00000001808E2E00-0x00000001808E2F00
				public ControllerMap GetFirstMapInCategory(Controller controller, string categoryName); // 0x00000001808E2AA0-0x00000001808E2CB0
				public ControllerMap GetFirstMapInCategory(Controller controller, int categoryId); // 0x00000001808E2F00-0x00000001808E2FE0
				public void AddMap<T>(int controllerId, ControllerMap map)
					where T : ControllerMap;
				public void AddMap(Controller controller, ControllerMap map); // 0x00000001808D78B0-0x00000001808D79B0
				public void AddMap(ControllerType controllerType, int controllerId, ControllerMap map); // 0x00000001808D7BA0-0x00000001808D7C80
				public void AddMap<T>(int controllerId, ControllerMap map, bool startEnabled)
					where T : ControllerMap;
				public void AddMap(Controller controller, ControllerMap map, bool startEnabled); // 0x00000001808D79B0-0x00000001808D7AB0
				public void AddMap(ControllerType controllerType, int controllerId, ControllerMap map, bool startEnabled); // 0x00000001808D7AB0-0x00000001808D7BA0
				public bool AddMapFromXml<T>(int controllerId, string xmlString)
					where T : ControllerMap;
				public bool AddMapFromXml(ControllerType controllerType, int controllerId, string xmlString); // 0x00000001808D77D0-0x00000001808D78B0
				public int AddMapsFromXml<T>(int controllerId, List<string> xmlStrings)
					where T : ControllerMap;
				public int AddMapsFromXml(ControllerType controllerType, int controllerId, List<string> xmlStrings); // 0x00000001808D7EB0-0x00000001808D8120
				public bool AddMapFromJson<T>(int controllerId, string jsonString)
					where T : ControllerMap;
				public bool AddMapFromJson(ControllerType controllerType, int controllerId, string jsonString); // 0x00000001808D76D0-0x00000001808D77D0
				public int AddMapsFromJson<T>(int controllerId, List<string> jsonStrings)
					where T : ControllerMap;
				public int AddMapsFromJson(ControllerType controllerType, int controllerId, List<string> jsonStrings); // 0x00000001808D7C80-0x00000001808D7EB0
				public void AddEmptyMap<T>(int controllerId, int categoryId, int layoutId)
					where T : ControllerMap;
				public void AddEmptyMap<T>(int controllerId, string categoryName, string layoutName)
					where T : ControllerMap;
				public void AddEmptyMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId); // 0x00000001808D75F0-0x00000001808D76D0
				public void AddEmptyMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName); // 0x00000001808D7450-0x00000001808D75F0
				public void RemoveMap<T>(int controllerId, int mapId)
					where T : ControllerMap;
				public void RemoveMap<T>(int controllerId, int categoryId, int layoutId)
					where T : ControllerMap;
				public void RemoveMap<T>(int controllerId, string categoryName, string layoutName)
					where T : ControllerMap;
				public void RemoveMap(ControllerType controllerType, int controllerId, int mapId); // 0x00000001808E7570-0x00000001808E7650
				public void RemoveMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId); // 0x00000001808E7350-0x00000001808E7490
				public void RemoveMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName); // 0x00000001808E7490-0x00000001808E7570
				public void ClearMaps<T>(bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMaps(ControllerType controllerType, bool userAssignableOnly); // 0x00000001808DAD90-0x00000001808DB130
				public void ClearMapsInCategory<T>(int categoryId, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsInCategory<T>(string categoryName, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsInCategory<T>(int categoryId, int layoutId, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsInCategory<T>(string categoryName, string layoutName, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsInCategory(int categoryId, bool userAssignableOnly); // 0x00000001808D9F90-0x00000001808DA3A0
				public void ClearMapsInCategory(string categoryName, bool userAssignableOnly); // 0x00000001808DA510-0x00000001808DA640
				public void ClearMapsInCategory(ControllerType controllerType, int categoryId, bool userAssignableOnly); // 0x00000001808D9C80-0x00000001808D9E70
				public void ClearMapsInCategory(ControllerType controllerType, string categoryName, bool userAssignableOnly); // 0x00000001808D9E70-0x00000001808D9F90
				public void ClearMapsInCategory(ControllerType controllerType, int categoryId, int layoutId, bool userAssignableOnly); // 0x00000001808DA640-0x00000001808DAA50
				public void ClearMapsInCategory(ControllerType controllerType, string categoryName, string layoutName, bool userAssignableOnly); // 0x00000001808DA3A0-0x00000001808DA510
				public void ClearMapsInLayout<T>(int layoutId, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsInLayout<T>(string layoutName, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsInLayout(ControllerType controllerType, int layoutId, bool userAssignableOnly); // 0x00000001808DAB60-0x00000001808DAD90
				public void ClearMapsInLayout(ControllerType controllerType, string layoutName, bool userAssignableOnly); // 0x00000001808DAA50-0x00000001808DAB60
				public void ClearMapsForController<T>(int controllerId, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsForController<T>(int controllerId, int categoryId, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsForController<T>(int controllerId, string categoryName, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsForController(ControllerType controllerType, int controllerId, bool userAssignableOnly); // 0x00000001808D9940-0x00000001808D9B00
				public void ClearMapsForController(ControllerType controllerType, int controllerId, int categoryId, bool userAssignableOnly); // 0x00000001808D9B00-0x00000001808D9C80
				public void ClearMapsForController(ControllerType controllerType, int controllerId, string categoryName, bool userAssignableOnly); // 0x00000001808D97E0-0x00000001808D9940
				public void ClearMapsForControllerInLayout<T>(int controllerId, int layoutId, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsForControllerInLayout<T>(int controllerId, string layoutName, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsForControllerInLayout(ControllerType controllerType, int controllerId, int layoutId, bool userAssignableOnly); // 0x00000001808D95A0-0x00000001808D97E0
				public void ClearMapsForControllerInLayout(ControllerType controllerType, int controllerId, string layoutName, bool userAssignableOnly); // 0x00000001808D9440-0x00000001808D95A0
				public void ClearAllMaps(bool userAssignableOnly); // 0x00000001808D9300-0x00000001808D9440
				public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps); // 0x00000001808E10B0-0x00000001808E1160
				public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps); // 0x00000001808E1160-0x00000001808E12E0
				public ActionElementMap GetFirstButtonMapWithAction(Controller controller, int actionId, bool skipDisabledMaps); // 0x00000001808E12E0-0x00000001808E13D0
				public ActionElementMap GetFirstButtonMapWithAction(Controller controller, string actionName, bool skipDisabledMaps); // 0x00000001808E13D0-0x00000001808E14F0
				public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps); // 0x00000001808E18B0-0x00000001808E1990
				public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps); // 0x00000001808E1740-0x00000001808E18B0
				public ActionElementMap GetFirstButtonMapWithAction(int actionId, bool skipDisabledMaps); // 0x00000001808E0F30-0x00000001808E10B0
				public ActionElementMap GetFirstButtonMapWithAction(string actionName, bool skipDisabledMaps); // 0x00000001808E14F0-0x00000001808E1740
				public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps); // 0x00000001808D8E90-0x00000001808D8F40
				public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps); // 0x00000001808D89B0-0x00000001808D8B30
				public IEnumerable<ActionElementMap> ButtonMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps); // 0x00000001808D9020-0x00000001808D9110
				public IEnumerable<ActionElementMap> ButtonMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps); // 0x00000001808D8B30-0x00000001808D8C50
				public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps); // 0x00000001808D8F40-0x00000001808D9020
				public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps); // 0x00000001808D9110-0x00000001808D9300
				public IEnumerable<ActionElementMap> ButtonMapsWithAction(int actionId, bool skipDisabledMaps); // 0x00000001808D8DD0-0x00000001808D8E90
				public IEnumerable<ActionElementMap> ButtonMapsWithAction(string actionName, bool skipDisabledMaps); // 0x00000001808D8C50-0x00000001808D8DD0
				public int GetButtonMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DED30-0x00000001808DEDF0
				public int GetButtonMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DF450-0x00000001808DF5D0
				public int GetButtonMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DF000-0x00000001808DF180
				public int GetButtonMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DF180-0x00000001808DF2A0
				public int GetButtonMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DEDF0-0x00000001808DEEE0
				public int GetButtonMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DF2A0-0x00000001808DF450
				public int GetButtonMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DED10-0x00000001808DED30
				public int GetButtonMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DEEE0-0x00000001808DF000
				public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps); // 0x00000001808E0580-0x00000001808E0630
				public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps); // 0x00000001808E07B0-0x00000001808E0930
				public ActionElementMap GetFirstAxisMapWithAction(Controller controller, int actionId, bool skipDisabledMaps); // 0x00000001808E0E20-0x00000001808E0F30
				public ActionElementMap GetFirstAxisMapWithAction(Controller controller, string actionName, bool skipDisabledMaps); // 0x00000001808E0930-0x00000001808E0A50
				public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps); // 0x00000001808E04A0-0x00000001808E0580
				public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps); // 0x00000001808E0A50-0x00000001808E0BC0
				public ActionElementMap GetFirstAxisMapWithAction(int actionId, bool skipDisabledMaps); // 0x00000001808E0630-0x00000001808E07B0
				public ActionElementMap GetFirstAxisMapWithAction(string actionName, bool skipDisabledMaps); // 0x00000001808E0BC0-0x00000001808E0E20
				public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps); // 0x00000001808D8580-0x00000001808D8630
				public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps); // 0x00000001808D8280-0x00000001808D8400
				public IEnumerable<ActionElementMap> AxisMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps); // 0x00000001808D8750-0x00000001808D8840
				public IEnumerable<ActionElementMap> AxisMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps); // 0x00000001808D8630-0x00000001808D8750
				public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps); // 0x00000001808D88D0-0x00000001808D89B0
				public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps); // 0x00000001808D8400-0x00000001808D8580
				public IEnumerable<ActionElementMap> AxisMapsWithAction(int actionId, bool skipDisabledMaps); // 0x00000001808D8840-0x00000001808D88D0
				public IEnumerable<ActionElementMap> AxisMapsWithAction(string actionName, bool skipDisabledMaps); // 0x00000001808D8120-0x00000001808D8280
				public int GetAxisMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DE710-0x00000001808DE7D0
				public int GetAxisMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DE540-0x00000001808DE6F0
				public int GetAxisMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DEAF0-0x00000001808DEBF0
				public int GetAxisMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DE7D0-0x00000001808DE910
				public int GetAxisMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DE420-0x00000001808DE540
				public int GetAxisMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DE910-0x00000001808DEAF0
				public int GetAxisMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DE6F0-0x00000001808DE710
				public int GetAxisMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DEBF0-0x00000001808DED10
				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps); // 0x00000001808E1990-0x00000001808E1A40
				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps); // 0x00000001808E2250-0x00000001808E23D0
				public ActionElementMap GetFirstElementMapWithAction(Controller controller, int actionId, bool skipDisabledMaps); // 0x00000001808E1A40-0x00000001808E1B30
				public ActionElementMap GetFirstElementMapWithAction(Controller controller, string actionName, bool skipDisabledMaps); // 0x00000001808E2130-0x00000001808E2250
				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps); // 0x00000001808E23D0-0x00000001808E24D0
				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps); // 0x00000001808E1B30-0x00000001808E1CF0
				public ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps); // 0x00000001808E1CF0-0x00000001808E1EB0
				public ActionElementMap GetFirstElementMapWithAction(string actionName, bool skipDisabledMaps); // 0x00000001808E1EB0-0x00000001808E2130
				public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps); // 0x00000001808DBD30-0x00000001808DBDE0
				public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps); // 0x00000001808DBEC0-0x00000001808DC040
				public IEnumerable<ActionElementMap> ElementMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps); // 0x00000001808DBB90-0x00000001808DBCA0
				public IEnumerable<ActionElementMap> ElementMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps); // 0x00000001808DBA70-0x00000001808DBB90
				public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps); // 0x00000001808DBDE0-0x00000001808DBEC0
				public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps); // 0x00000001808DC040-0x00000001808DC1C0
				public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId, bool skipDisabledMaps); // 0x00000001808DBCA0-0x00000001808DBD30
				public IEnumerable<ActionElementMap> ElementMapsWithAction(string actionName, bool skipDisabledMaps); // 0x00000001808DB910-0x00000001808DBA70
				public int GetElementMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DFDF0-0x00000001808DFEB0
				public int GetElementMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DFB60-0x00000001808DFCE0
				public int GetElementMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DF5D0-0x00000001808DF6D0
				public int GetElementMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DF840-0x00000001808DF960
				public int GetElementMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DFD00-0x00000001808DFDF0
				public int GetElementMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DF960-0x00000001808DFB60
				public int GetElementMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DFCE0-0x00000001808DFD00
				public int GetElementMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DF6D0-0x00000001808DF840
				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps); // 0x00000001808DC1C0-0x00000001808DC2C0
				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps); // 0x00000001808DC3F0-0x00000001808DC420
				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps); // 0x00000001808DC2C0-0x00000001808DC3F0
				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps); // 0x00000001808DC450-0x00000001808DC660
				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps); // 0x00000001808DC420-0x00000001808DC450
				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps); // 0x00000001808DC660-0x00000001808DC720
				public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps); // 0x00000001808E2720-0x00000001808E2850
				public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps); // 0x00000001808E24D0-0x00000001808E2500
				public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps); // 0x00000001808E2850-0x00000001808E2980
				public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps); // 0x00000001808E2530-0x00000001808E2720
				public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps); // 0x00000001808E2500-0x00000001808E2530
				public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps); // 0x00000001808E2980-0x00000001808E2AA0
				public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808E0230-0x00000001808E0340
				public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808E0470-0x00000001808E04A0
				public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808E0100-0x00000001808E0230
				public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DFEF0-0x00000001808E0100
				public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808DFEB0-0x00000001808DFEF0
				public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808E0340-0x00000001808E0470
				public T[] GetMapSaveData<T>(int controllerId, bool userAssignableMapsOnly)
					where T : ControllerMapSaveData;
				public ControllerMapSaveData[] GetMapSaveData(ControllerType controllerType, int controllerId, bool userAssignableMapsOnly); // 0x00000001808E31A0-0x00000001808E3280
				public T[] GetAllMapSaveData<T>(bool userAssignableMapsOnly)
					where T : ControllerMapSaveData;
				public ControllerMapSaveData[] GetAllMapSaveData(ControllerType controllerType, bool userAssignableMapsOnly); // 0x00000001808DC810-0x00000001808DC8E0
				public ControllerMapSaveData[] GetAllMapSaveData(bool userAssignableMapsOnly); // 0x00000001808DC8E0-0x00000001808DCA40
				public int SetAllMapsEnabled(bool state); // 0x00000001808E7A90-0x00000001808E7E90
				public int SetAllMapsEnabled(bool state, ControllerType controllerType); // 0x00000001808E7FE0-0x00000001808E8310
				public int SetAllMapsEnabled(bool state, Controller controller); // 0x00000001808E8310-0x00000001808E84F0
				public int SetAllMapsEnabled(bool state, ControllerType controllerType, int controllerId); // 0x00000001808E7E90-0x00000001808E7FE0
				public int SetMapsEnabled(bool state, int categoryId); // 0x00000001808E8910-0x00000001808E8D00
				public int SetMapsEnabled(bool state, string categoryName); // 0x00000001808E9AD0-0x00000001808E9BD0
				public int SetMapsEnabled(bool state, string categoryName, string layoutName); // 0x00000001808E86C0-0x00000001808E8910
				public int SetMapsEnabled(bool state, ControllerType controllerType, int categoryId); // 0x00000001808E9550-0x00000001808E9870
				public int SetMapsEnabled(bool state, ControllerType controllerType, string categoryName); // 0x00000001808E9050-0x00000001808E9160
				public int SetMapsEnabled(bool state, ControllerType controllerType, int categoryId, int layoutId); // 0x00000001808E9160-0x00000001808E9550
				public int SetMapsEnabled(bool state, ControllerType controllerType, string categoryName, string layoutName); // 0x00000001808E8D00-0x00000001808E8EB0
				public int SetMapsEnabled(bool state, Controller controller, int categoryId); // 0x00000001808E8EB0-0x00000001808E9050
				public int SetMapsEnabled(bool state, Controller controller, int categoryId, int layoutId); // 0x00000001808E84F0-0x00000001808E86C0
				public int SetMapsEnabled(bool state, Controller controller, string categoryName); // 0x00000001808E9870-0x00000001808E9AD0
				public int SetMapsEnabled(bool state, Controller controller, string categoryName, string layoutName); // 0x00000001808E9BD0-0x00000001808E9D50
				public void LoadDefaultMaps(ControllerType controllerType); // 0x00000001808E4FF0-0x00000001808E51A0
				public bool ContainsMapInCategory(InputMapCategory category); // 0x00000001808DB510-0x00000001808DB5D0
				public bool ContainsMapInCategory(int categoryId); // 0x00000001808DB180-0x00000001808DB410
				public bool ContainsMapInCategory(string categoryName); // 0x00000001808DB410-0x00000001808DB510
				public bool ContainsMapInCategory(ControllerType controllerType, int categoryId); // 0x00000001808DB5D0-0x00000001808DB910
				public InputBehavior GetInputBehavior(int behaviorId); // 0x00000001808E2FE0-0x00000001808E30C0
				public InputBehavior GetInputBehavior(string behaviorName); // 0x00000001808E30C0-0x00000001808E31A0
				internal void ItdhavHGXcUkAhyjaCFbIXENJheh(); // 0x00000001808E4B20-0x00000001808E4B60
				internal void ljuzyhLOykfHUNqpupeYHHYVVUa(bool param_0000e2a7); // 0x00000001808ECE90-0x00000001808ED6A0
				internal void NHvEbWUrKnQLGxXIuzllGPcMtQ(bool param_0000e2a8); // 0x00000001808E5B30-0x00000001808E61D0
				internal void SlISPtLfLQFUPagROOqtyucSdRl(bool param_0000e2a9); // 0x00000001808E9D50-0x00000001808EA2D0
				internal void zAYHkHeBUioXAywUbyMjEbgDqMXE(bool param_0000e2aa); // 0x00000001808F13E0-0x00000001808F1CD0
				private uwILKJrQnvyPKXqkviwAHMwxglt hxOOzhfeazOtLJWADoJhQgiGlzs<T>()
					where T : ControllerMap;
				internal UqmUJOucnPAhoXhVuhvbmxKGsOH<JoystickMap> OjIHCxhPqXjtJWjGkbWIODpinHE(Joystick param_0000e2ab, bool param_0000e2ac); // 0x00000001808E61D0-0x00000001808E6560
				private void kpLbpdIVdpCOPCuotjOTQDWMlps(Joystick param_0000e2ad, UqmUJOucnPAhoXhVuhvbmxKGsOH<JoystickMap> param_0000e2ae, VazWCJszjSvmMxSvRJnnBczpVoI param_0000e2af, bool param_0000e2b0); // 0x00000001808ECC50-0x00000001808ECE90
				internal UqmUJOucnPAhoXhVuhvbmxKGsOH<CustomControllerMap> VJVfCBZpPxtAMcwrGcyftqeWpph(CustomController param_0000e2b1, bool param_0000e2b2); // 0x00000001808EA910-0x00000001808EAD50
				private void cvcNRPlBVHsHAXnqfBvnJlkrtaA(CustomController param_0000e2b3, UqmUJOucnPAhoXhVuhvbmxKGsOH<CustomControllerMap> param_0000e2b4, VazWCJszjSvmMxSvRJnnBczpVoI param_0000e2b5, bool param_0000e2b6); // 0x00000001808EBE20-0x00000001808EC0B0
				internal void CmxbnCZUDHhLTtrfUROfRgOsrHY(Controller param_0000e2b7, ControllerMap param_0000e2b8); // 0x00000001808DB130-0x00000001808DB180
				private IList<T> yWZVEngpJTrWcIAabCcjjehlxsBj<T>(int param_0000e2b9)
					where T : ControllerMap;
				private IList<T> yWZVEngpJTrWcIAabCcjjehlxsBj<T>(Controller param_0000e2ba)
					where T : ControllerMap;
				private IList<ControllerMap> yWZVEngpJTrWcIAabCcjjehlxsBj(ControllerType param_0000e2bb, int param_0000e2bc); // 0x00000001808F12D0-0x00000001808F13E0
				private IList<ControllerMap> yWZVEngpJTrWcIAabCcjjehlxsBj(Controller param_0000e2bd); // 0x00000001808F1280-0x00000001808F12D0
				private void azHszTgePDPkBJLxcubKkYACbrS(ControllerType param_0000e2be, int param_0000e2bf, int param_0000e2c0, int param_0000e2c1); // 0x00000001808EBDF0-0x00000001808EBE20
				private void azHszTgePDPkBJLxcubKkYACbrS(Controller param_0000e2c2, int param_0000e2c3, int param_0000e2c4); // 0x00000001808EB920-0x00000001808EB990
				private void azHszTgePDPkBJLxcubKkYACbrS(ControllerType param_0000e2c5, int param_0000e2c6, string param_0000e2c7, string param_0000e2c8); // 0x00000001808EBBF0-0x00000001808EBC20
				private void azHszTgePDPkBJLxcubKkYACbrS(Controller param_0000e2c9, string param_0000e2ca, string param_0000e2cb); // 0x00000001808EBA90-0x00000001808EBB00
				private void azHszTgePDPkBJLxcubKkYACbrS(ControllerType param_0000e2cc, int param_0000e2cd, int param_0000e2ce, int param_0000e2cf, BoolOption param_0000e2d0); // 0x00000001808EBC20-0x00000001808EBDF0
				private void azHszTgePDPkBJLxcubKkYACbrS(Controller param_0000e2d1, int param_0000e2d2, int param_0000e2d3, BoolOption param_0000e2d4); // 0x00000001808EB990-0x00000001808EBA10
				private void azHszTgePDPkBJLxcubKkYACbrS(ControllerType param_0000e2d5, int param_0000e2d6, string param_0000e2d7, string param_0000e2d8, BoolOption param_0000e2d9); // 0x00000001808EBB00-0x00000001808EBBF0
				private void azHszTgePDPkBJLxcubKkYACbrS(Controller param_0000e2da, string param_0000e2db, string param_0000e2dc, BoolOption param_0000e2dd); // 0x00000001808EBA10-0x00000001808EBA90
				private void nRpfYcSMpjzNOMaRrgWhxbaFFow(Controller param_0000e2de, ControllerMap param_0000e2df, BoolOption param_0000e2e0); // 0x00000001808EDBF0-0x00000001808EDEB0
				private void nRpfYcSMpjzNOMaRrgWhxbaFFow(ControllerType param_0000e2e1, int param_0000e2e2, ControllerMap param_0000e2e3, BoolOption param_0000e2e4); // 0x00000001808EDB30-0x00000001808EDBF0
				private bool gCUvtoINFiRJKWCKAiyXBKgcwCw(ControllerType param_0000e2e5, int param_0000e2e6, string param_0000e2e7); // 0x00000001808EC580-0x00000001808EC710
				private int McaTJhbNDEhUXOYSYjSfoXlxXsD(ControllerType param_0000e2e8, int param_0000e2e9, List<string> param_0000e2ea); // 0x00000001808E5280-0x00000001808E54C0
				private bool lmastpkegqvXgzyngLJdWbYQovD(ControllerType param_0000e2eb, int param_0000e2ec, string param_0000e2ed); // 0x00000001808ED6A0-0x00000001808ED940
				private int QeUGCFVLdpkvKuroBITzfcEEQaU(ControllerType param_0000e2ee, int param_0000e2ef, List<string> param_0000e2f0); // 0x00000001808E7180-0x00000001808E7350
				private void SWSIQZFYSQLALpiqLfqjsjCanYk(ControllerType param_0000e2f1, int param_0000e2f2, int param_0000e2f3, int param_0000e2f4); // 0x00000001808E76C0-0x00000001808E7850
				private void SWSIQZFYSQLALpiqLfqjsjCanYk(Controller param_0000e2f5, int param_0000e2f6, int param_0000e2f7); // 0x00000001808E7650-0x00000001808E76C0
				private void SWSIQZFYSQLALpiqLfqjsjCanYk(ControllerType param_0000e2f8, int param_0000e2f9, string param_0000e2fa, string param_0000e2fb); // 0x00000001808E7980-0x00000001808E7A90
				private void SWSIQZFYSQLALpiqLfqjsjCanYk(Controller param_0000e2fc, string param_0000e2fd, string param_0000e2fe); // 0x00000001808E7850-0x00000001808E7980
				private void wdXBtZaFNKlhBUmtaHeXouumymuU(ControllerType param_0000e2ff, int param_0000e300, int param_0000e301); // 0x00000001808F0300-0x00000001808F0580
				private void wdXBtZaFNKlhBUmtaHeXouumymuU(Controller param_0000e302, int param_0000e303); // 0x00000001808F09C0-0x00000001808F0A20
				private void wdXBtZaFNKlhBUmtaHeXouumymuU(ControllerType param_0000e304, int param_0000e305, ControllerMap param_0000e306); // 0x00000001808F07E0-0x00000001808F0950
				private void wdXBtZaFNKlhBUmtaHeXouumymuU(Controller param_0000e307, ControllerMap param_0000e308); // 0x00000001808F0BE0-0x00000001808F0C60
				private void wdXBtZaFNKlhBUmtaHeXouumymuU(ControllerType param_0000e309, int param_0000e30a, int param_0000e30b, int param_0000e30c); // 0x00000001808F0A20-0x00000001808F0BE0
				private void wdXBtZaFNKlhBUmtaHeXouumymuU(Controller param_0000e30d, int param_0000e30e, int param_0000e30f); // 0x00000001808F0950-0x00000001808F09C0
				private void wdXBtZaFNKlhBUmtaHeXouumymuU(ControllerType param_0000e310, int param_0000e311, string param_0000e312, string param_0000e313); // 0x00000001808F0580-0x00000001808F07E0
				private void wdXBtZaFNKlhBUmtaHeXouumymuU(Controller param_0000e314, string param_0000e315, string param_0000e316); // 0x00000001808F0C60-0x00000001808F0CD0
				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(ControllerType param_0000e317, int param_0000e318, int param_0000e319); // 0x00000001808EFED0-0x00000001808EFFE0
				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(Controller param_0000e31a, int param_0000e31b); // 0x00000001808F01C0-0x00000001808F0220
				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(ControllerType param_0000e31c, int param_0000e31d, int param_0000e31e, int param_0000e31f); // 0x00000001808EFFE0-0x00000001808F01C0
				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(Controller param_0000e320, int param_0000e321, int param_0000e322); // 0x00000001808F0220-0x00000001808F0290
				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(ControllerType param_0000e323, int param_0000e324, string param_0000e325, string param_0000e326); // 0x00000001808EFDF0-0x00000001808EFED0
				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(Controller param_0000e327, string param_0000e328, string param_0000e329); // 0x00000001808F0290-0x00000001808F0300
				private ControllerMap uydcTkSsveNrDWhdfejCzhPijCK(ControllerType param_0000e32a, int param_0000e32b, int param_0000e32c); // 0x00000001808EFC80-0x00000001808EFD90
				private ControllerMap uydcTkSsveNrDWhdfejCzhPijCK(Controller param_0000e32d, int param_0000e32e); // 0x00000001808EFD90-0x00000001808EFDF0
				private ControllerMap uydcTkSsveNrDWhdfejCzhPijCK(ControllerType param_0000e32f, int param_0000e330, string param_0000e331); // 0x00000001808EFA60-0x00000001808EFB60
				private ControllerMap uydcTkSsveNrDWhdfejCzhPijCK(Controller param_0000e332, string param_0000e333); // 0x00000001808EFB60-0x00000001808EFC80
				private ControllerMap[] MsRJVqmqJMIZqczuwuGRjMnFXPNf(ControllerType param_0000e334); // 0x00000001808E54C0-0x00000001808E5B30
				private ControllerMapSaveData[] UxlfCZTeJutCpoKfgKKpmMIRjUX(ControllerType param_0000e335, int param_0000e336, bool param_0000e337); // 0x00000001808EA2D0-0x00000001808EA910
				private T[] UxlfCZTeJutCpoKfgKKpmMIRjUX<T>(int param_0000e338, bool param_0000e339)
					where T : ControllerMapSaveData;
				private ControllerMapSaveData[] WepHTJHYyuxCQWQDKcGkMoxbloqK(ControllerType param_0000e33a, bool param_0000e33b); // 0x00000001808EB010-0x00000001808EB320
				private T[] WepHTJHYyuxCQWQDKcGkMoxbloqK<T>(bool param_0000e33c)
					where T : ControllerMapSaveData;
				private int tMiAgVhCKUhHOdiwAySOMpxktsU(ControllerType param_0000e33d, int param_0000e33e, int param_0000e33f, List<ControllerMap> param_0000e340); // 0x00000001808EF940-0x00000001808EFA60
				private int tMiAgVhCKUhHOdiwAySOMpxktsU(Controller param_0000e341, int param_0000e342, List<ControllerMap> param_0000e343); // 0x00000001808EF8D0-0x00000001808EF940
				private int tMiAgVhCKUhHOdiwAySOMpxktsU(ControllerType param_0000e344, int param_0000e345, string param_0000e346, List<ControllerMap> param_0000e347); // 0x00000001808EF7C0-0x00000001808EF8D0
				private int tMiAgVhCKUhHOdiwAySOMpxktsU(Controller param_0000e348, string param_0000e349, List<ControllerMap> param_0000e34a); // 0x00000001808EF690-0x00000001808EF7C0
				private IEnumerable<ControllerMap> QLyRBVUAepSHUPCdsjmRgMsOiId(ControllerType param_0000e34b, int param_0000e34c, int param_0000e34d); // 0x00000001808E6E00-0x00000001808E6EA0
				private IEnumerable<T> QLyRBVUAepSHUPCdsjmRgMsOiId<T>(int param_0000e34e, int param_0000e34f)
					where T : ControllerMap;
				private ActionElementMap zWuVeIfMjbjzeGortobFYQWfBWD(ControllerType param_0000e350, int param_0000e351, bool param_0000e352); // 0x00000001808F22E0-0x00000001808F2870
				private ActionElementMap zWuVeIfMjbjzeGortobFYQWfBWD(ControllerType param_0000e353, string param_0000e354, bool param_0000e355); // 0x00000001808F2220-0x00000001808F22E0
				private IEnumerable<ActionElementMap> VceQlZlQeNWnAVcXwZFwSzxauNl(ControllerType param_0000e356, int param_0000e357, bool param_0000e358); // 0x00000001808EAF70-0x00000001808EB010
				private IEnumerable<ActionElementMap> VceQlZlQeNWnAVcXwZFwSzxauNl(ControllerType param_0000e359, string param_0000e35a, bool param_0000e35b); // 0x00000001808EADF0-0x00000001808EAEB0
				private ActionElementMap zewHWDgjyeGLAqThpksnKtNDbCr(ControllerType param_0000e35c, int param_0000e35d, bool param_0000e35e); // 0x00000001808F30C0-0x00000001808F3530
				private ActionElementMap zewHWDgjyeGLAqThpksnKtNDbCr(ControllerType param_0000e35f, string param_0000e360, bool param_0000e361); // 0x00000001808F3000-0x00000001808F30C0
				private IEnumerable<ActionElementMap> QQTvpNWmnOTXXWnIOJysgquOOSN(ControllerType param_0000e362, int param_0000e363, bool param_0000e364); // 0x00000001808E7020-0x00000001808E70C0
				private IEnumerable<ActionElementMap> QQTvpNWmnOTXXWnIOJysgquOOSN(ControllerType param_0000e365, string param_0000e366, bool param_0000e367); // 0x00000001808E6F60-0x00000001808E7020
				private ActionElementMap zfCiUcEGjnQvFnQdnvuKbtLhWwHb(ControllerType param_0000e368, int param_0000e369, bool param_0000e36a); // 0x00000001808F35F0-0x00000001808F3900
				private ActionElementMap zfCiUcEGjnQvFnQdnvuKbtLhWwHb(ControllerType param_0000e36b, string param_0000e36c, bool param_0000e36d); // 0x00000001808F3530-0x00000001808F35F0
				private IEnumerable<ActionElementMap> AGYVxhOwMpMgdAOTqqeUwEDCKEZ(ControllerType param_0000e36e, int param_0000e36f, bool param_0000e370); // 0x00000001808D72B0-0x00000001808D7350
				private IEnumerable<ActionElementMap> AGYVxhOwMpMgdAOTqqeUwEDCKEZ(ControllerType param_0000e371, string param_0000e372, bool param_0000e373); // 0x00000001808D71F0-0x00000001808D72B0
				private int iRpRMXtGPzaRzbxQcKhFNYOkpU(int param_0000e374, bool param_0000e375, List<ActionElementMap> param_0000e376, bool param_0000e377); // 0x00000001808EC7E0-0x00000001808ECC50
				private int aJrBTCaTOYGxSpVpmfRGkxuxFcsp(int param_0000e378, bool param_0000e379, List<ActionElementMap> param_0000e37a, bool param_0000e37b); // 0x00000001808EB490-0x00000001808EB920
				private int LUtxNstqrZkFfSUMrtjuNGVLWKp(int param_0000e37c, bool param_0000e37d, List<ActionElementMap> param_0000e37e, bool param_0000e37f); // 0x00000001808E4B60-0x00000001808E4FF0
				private int PpzEHMktrgrSozWFKEKIrJEwDdl(ControllerType param_0000e380, int param_0000e381, bool param_0000e382, List<ActionElementMap> param_0000e383, bool param_0000e384); // 0x00000001808E69A0-0x00000001808E6D30
				private int PpzEHMktrgrSozWFKEKIrJEwDdl(ControllerType param_0000e385, string param_0000e386, bool param_0000e387, List<ActionElementMap> param_0000e388, bool param_0000e389); // 0x00000001808E6560-0x00000001808E6630
				private int orYUSPTLyKzGaPIjbumYvhkmHjZ(ControllerType param_0000e38a, int param_0000e38b, bool param_0000e38c, List<ActionElementMap> param_0000e38d, bool param_0000e38e); // 0x00000001808EE590-0x00000001808EEA60
				private int orYUSPTLyKzGaPIjbumYvhkmHjZ(ControllerType param_0000e38f, string param_0000e390, bool param_0000e391, List<ActionElementMap> param_0000e392, bool param_0000e393); // 0x00000001808EE4C0-0x00000001808EE590
				private int sMrwWquwVtpROYhaaLmsTNgBJiKh(ControllerType param_0000e394, int param_0000e395, bool param_0000e396, List<ActionElementMap> param_0000e397, bool param_0000e398); // 0x00000001808EEB30-0x00000001808EEED0
				private int sMrwWquwVtpROYhaaLmsTNgBJiKh(ControllerType param_0000e399, string param_0000e39a, bool param_0000e39b, List<ActionElementMap> param_0000e39c, bool param_0000e39d); // 0x00000001808EF5C0-0x00000001808EF690
				private ActionElementMap zWuVeIfMjbjzeGortobFYQWfBWD(ControllerType param_0000e39e, int param_0000e39f, int param_0000e3a0, bool param_0000e3a1); // 0x00000001808F1D90-0x00000001808F2220
				private ActionElementMap zWuVeIfMjbjzeGortobFYQWfBWD(ControllerType param_0000e3a2, int param_0000e3a3, string param_0000e3a4, bool param_0000e3a5); // 0x00000001808F1CD0-0x00000001808F1D90
				private IEnumerable<ActionElementMap> VceQlZlQeNWnAVcXwZFwSzxauNl(ControllerType param_0000e3a6, int param_0000e3a7, int param_0000e3a8, bool param_0000e3a9); // 0x00000001808EAD50-0x00000001808EADF0
				private IEnumerable<ActionElementMap> VceQlZlQeNWnAVcXwZFwSzxauNl(ControllerType param_0000e3aa, int param_0000e3ab, string param_0000e3ac, bool param_0000e3ad); // 0x00000001808EAEB0-0x00000001808EAF70
				private ActionElementMap zewHWDgjyeGLAqThpksnKtNDbCr(ControllerType param_0000e3ae, int param_0000e3af, int param_0000e3b0, bool param_0000e3b1); // 0x00000001808F2930-0x00000001808F3000
				private ActionElementMap zewHWDgjyeGLAqThpksnKtNDbCr(ControllerType param_0000e3b2, int param_0000e3b3, string param_0000e3b4, bool param_0000e3b5); // 0x00000001808F2870-0x00000001808F2930
				private IEnumerable<ActionElementMap> QQTvpNWmnOTXXWnIOJysgquOOSN(ControllerType param_0000e3b6, int param_0000e3b7, int param_0000e3b8, bool param_0000e3b9); // 0x00000001808E70C0-0x00000001808E7180
				private IEnumerable<ActionElementMap> QQTvpNWmnOTXXWnIOJysgquOOSN(ControllerType param_0000e3ba, int param_0000e3bb, string param_0000e3bc, bool param_0000e3bd); // 0x00000001808E6EA0-0x00000001808E6F60
				private ActionElementMap zfCiUcEGjnQvFnQdnvuKbtLhWwHb(ControllerType param_0000e3be, int param_0000e3bf, int param_0000e3c0, bool param_0000e3c1); // 0x00000001808F3900-0x00000001808F3CF0
				private ActionElementMap zfCiUcEGjnQvFnQdnvuKbtLhWwHb(ControllerType param_0000e3c2, int param_0000e3c3, string param_0000e3c4, bool param_0000e3c5); // 0x00000001808F3CF0-0x00000001808F3DB0
				private IEnumerable<ActionElementMap> AGYVxhOwMpMgdAOTqqeUwEDCKEZ(ControllerType param_0000e3c6, int param_0000e3c7, int param_0000e3c8, bool param_0000e3c9); // 0x00000001808D7350-0x00000001808D7450
				private IEnumerable<ActionElementMap> AGYVxhOwMpMgdAOTqqeUwEDCKEZ(ControllerType param_0000e3ca, int param_0000e3cb, string param_0000e3cc, bool param_0000e3cd); // 0x00000001808D7130-0x00000001808D71F0
				private int PpzEHMktrgrSozWFKEKIrJEwDdl(ControllerType param_0000e3ce, int param_0000e3cf, int param_0000e3d0, bool param_0000e3d1, List<ActionElementMap> param_0000e3d2, bool param_0000e3d3); // 0x00000001808E6630-0x00000001808E69A0
				private int PpzEHMktrgrSozWFKEKIrJEwDdl(ControllerType param_0000e3d4, int param_0000e3d5, string param_0000e3d6, bool param_0000e3d7, List<ActionElementMap> param_0000e3d8, bool param_0000e3d9); // 0x00000001808E6D30-0x00000001808E6E00
				private int orYUSPTLyKzGaPIjbumYvhkmHjZ(ControllerType param_0000e3da, int param_0000e3db, int param_0000e3dc, bool param_0000e3dd, List<ActionElementMap> param_0000e3de, bool param_0000e3df); // 0x00000001808EDEB0-0x00000001808EE3F0
				private int orYUSPTLyKzGaPIjbumYvhkmHjZ(ControllerType param_0000e3e0, int param_0000e3e1, string param_0000e3e2, bool param_0000e3e3, List<ActionElementMap> param_0000e3e4, bool param_0000e3e5); // 0x00000001808EE3F0-0x00000001808EE4C0
				private int sMrwWquwVtpROYhaaLmsTNgBJiKh(ControllerType param_0000e3e6, int param_0000e3e7, int param_0000e3e8, bool param_0000e3e9, List<ActionElementMap> param_0000e3ea, bool param_0000e3eb); // 0x00000001808EEED0-0x00000001808EF5C0
				private int sMrwWquwVtpROYhaaLmsTNgBJiKh(ControllerType param_0000e3ec, int param_0000e3ed, string param_0000e3ee, bool param_0000e3ef, List<ActionElementMap> param_0000e3f0, bool param_0000e3f1); // 0x00000001808EEA60-0x00000001808EEB30
				private ActionElementMap xGTFTEwJTsxlOSroXbTPCnZFHCo(IControllerElementTarget param_0000e3f2, bool param_0000e3f3, int param_0000e3f4, bool param_0000e3f5); // 0x00000001808F0CD0-0x00000001808F1280
				private IEnumerable<ActionElementMap> GVIGeapkjeIDqIFeJwntvbxutdYh(IControllerElementTarget param_0000e3f6, bool param_0000e3f7, int param_0000e3f8, bool param_0000e3f9); // 0x00000001808DC720-0x00000001808DC810
				private int fayFUJtQndSNaRgkmUFdjreRzfd(IControllerElementTarget param_0000e3fa, bool param_0000e3fb, int param_0000e3fc, bool param_0000e3fd, List<ActionElementMap> param_0000e3fe, bool param_0000e3ff); // 0x00000001808EC0B0-0x00000001808EC580
			}
	
			[Browsable] // 0x00000001800D4F10-0x00000001800D4F50
			[EditorBrowsable] // 0x00000001800D4F10-0x00000001800D4F50
			public sealed class PollingHelper : CodeHelper // TypeDefIndex: 6626
			{
				// Fields
				private readonly Player yHWXapLnjMXUYBDESFaAUIdnziK; // 0x10
				private readonly ControllerHelper GsoDNwSmTlqXUxYxRnLUXMOoArhh; // 0x18
				private readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x20
	
				// Nested types
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class gCtaoVNHtJKnmRmilNOOWSUEkmc : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6627
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public int ApclWZWATFcgBgxbNPQkMDQJKvCT; // 0x58
					public int UFtQErWYQIHFhzaXnGUeSzqyBsH; // 0x5C
					public Joystick VxKjmjgPbPAtwroauQtwlWHsYbf; // 0x60
					public ControllerPollingInfo ZcTtNpfLILrYLuevnEsBCtRpvjN; // 0x68
					public ControllerPollingInfo lTOgsbwCkJNipTjfhuADGDOWQOR; // 0xA0
					public IEnumerator<ControllerPollingInfo> tsFJfGviNaNuLvIcKiipKDVPofJb; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018087CAD0-0x000000018087CB40 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public gCtaoVNHtJKnmRmilNOOWSUEkmc(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018087C940-0x000000018087CA80
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018087C940-0x000000018087CA80
					private bool MoveNext(); // 0x000000018087C4E0-0x000000018087C940
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018087CA80-0x000000018087CAD0
					void IDisposable.Dispose(); // 0x000000018087CB40-0x000000018087CBF0
					private void fqAGLNbhXzpioMYpWiwuPqYhgcFI(); // 0x000000018087CBF0-0x000000018087CC40
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class sJqIMjawweOOsGQOECgdBgSLYST : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6628
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public int ApclWZWATFcgBgxbNPQkMDQJKvCT; // 0x58
					public int UFtQErWYQIHFhzaXnGUeSzqyBsH; // 0x5C
					public Joystick XhvwbkDJHXWlRdAqBiHxwWNSYKr; // 0x60
					public ControllerPollingInfo ePfCcMKELDRGoHuxDzJeylhvmcs; // 0x68
					public ControllerPollingInfo nTpnIQIfMJiTIexQUGbkcwgvYavJ; // 0xA0
					public IEnumerator<ControllerPollingInfo> ONEXuTjurByhLMdqjzCAUQTtIMc; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180880DC0-0x0000000180880E30 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public sJqIMjawweOOsGQOECgdBgSLYST(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180880C60-0x0000000180880D70
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180880C60-0x0000000180880D70
					private bool MoveNext(); // 0x0000000180880840-0x0000000180880C60
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180880D70-0x0000000180880DC0
					void IDisposable.Dispose(); // 0x0000000180880E30-0x0000000180880EA0
					private void YkKITNrqwDsdCQUrvnJtBEbHeSE(); // 0x0000000180880EA0-0x0000000180880FC0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class OtNtyBucKLRJTjZxccdiwYUZejB : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6629
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public int ApclWZWATFcgBgxbNPQkMDQJKvCT; // 0x58
					public int UFtQErWYQIHFhzaXnGUeSzqyBsH; // 0x5C
					public Joystick cAhbIiFIrJOxoXyPOSeFxCURlfr; // 0x60
					public ControllerPollingInfo WeRonvUnTNdKMicIfLiAELIbzwlj; // 0x68
					public ControllerPollingInfo LfiiYECIQaTVrHKkHUSbuocgqEGb; // 0xA0
					public IEnumerator<ControllerPollingInfo> ZEVSoFdFuAnKSvwSALlfZnFKQuH; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018086C790-0x000000018086C800 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public OtNtyBucKLRJTjZxccdiwYUZejB(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018086C640-0x000000018086C740
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018086C640-0x000000018086C740
					private bool MoveNext(); // 0x000000018086C150-0x000000018086C640
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018086C740-0x000000018086C790
					void IDisposable.Dispose(); // 0x000000018086C800-0x000000018086C870
					private void TWjQtFekWIBuEKzcTePdQUBcHUc(); // 0x000000018086C870-0x000000018086C960
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class jKvcHakBvXgsXvuKpRTXunOmGyGC : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6630
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public int ApclWZWATFcgBgxbNPQkMDQJKvCT; // 0x58
					public int UFtQErWYQIHFhzaXnGUeSzqyBsH; // 0x5C
					public Joystick tobPRTyjHsDyWFvtEEIhIXvFPem; // 0x60
					public ControllerPollingInfo WfBUKMsGIohCaPMDgEBPXALAgnk; // 0x68
					public ControllerPollingInfo vhmFNWekZSymORPpsbCmYYjLbXaR; // 0xA0
					public IEnumerator<ControllerPollingInfo> napseiAPYPinHvZfsyQZCytfnSw; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018087E0F0-0x000000018087E160 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public jKvcHakBvXgsXvuKpRTXunOmGyGC(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018087DFA0-0x000000018087E0A0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018087DFA0-0x000000018087E0A0
					private bool MoveNext(); // 0x000000018087DC30-0x000000018087DFA0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018087E0A0-0x000000018087E0F0
					void IDisposable.Dispose(); // 0x000000018087E160-0x000000018087E1D0
					private void yNVMOVEijljPsdvazRDxIxnepmxe(); // 0x000000018087E1D0-0x000000018087E2D0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class zHTCNTACEbezSLsTBfZwXgHjYLs : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6631
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public int ApclWZWATFcgBgxbNPQkMDQJKvCT; // 0x58
					public int UFtQErWYQIHFhzaXnGUeSzqyBsH; // 0x5C
					public Joystick mycijteGXsOylYglxcrSRJYSbZAb; // 0x60
					public ControllerPollingInfo RNJmWPISyyeaQvohMxUeoPfBAhr; // 0x68
					public ControllerPollingInfo DVRLOWnHXHtriZrgqdEICQBJxkN; // 0xA0
					public IEnumerator<ControllerPollingInfo> gYoSeHwhrRvKWKfWfBEtkWFxbarG; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180884460-0x00000001808844D0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public zHTCNTACEbezSLsTBfZwXgHjYLs(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001808842C0-0x0000000180884410
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001808842C0-0x0000000180884410
					private bool MoveNext(); // 0x0000000180883F70-0x00000001808842C0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180884410-0x0000000180884460
					void IDisposable.Dispose(); // 0x00000001808844D0-0x0000000180884580
					private void eeqLcjHwNPDPmlWJPRDqAnCgAgu(); // 0x0000000180884580-0x00000001808845D0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class aXopQFWXqHJOhGflGbwwauGTXQOk : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6632
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public IList<Joystick> RmCkFmYdELduFFcGPeplGmzcckew; // 0x58
					public int TSKMixbysxHKUjkwTGaTcjGBIrv; // 0x60
					public int NfbdIpneUmrMMOVabhuSmKfpCZd; // 0x64
					public ControllerPollingInfo cldFzfHxjyFontPEqjrEDKkUHysg; // 0x68
					public ControllerPollingInfo delayYowfFWNbAjcwUPVFeMjhAe; // 0xA0
					public IEnumerator<ControllerPollingInfo> MqZXtdJAcIbcrZuETkjoyovoRHA; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018087AB30-0x000000018087ABA0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public aXopQFWXqHJOhGflGbwwauGTXQOk(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018087AA00-0x000000018087AAE0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018087AA00-0x000000018087AAE0
					private bool MoveNext(); // 0x000000018087A2F0-0x000000018087A8E0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018087AAE0-0x000000018087AB30
					void IDisposable.Dispose(); // 0x000000018087ABA0-0x000000018087AC10
					private void SlLyhKovlngbnFzSserBsfRvlnB(); // 0x000000018087A8E0-0x000000018087AA00
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class AKfotMJaboGCSkdXqlgdGJUeFAtF : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6633
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public IList<Joystick> GeLIqAizQfHlpphEEveFNHEnwqC; // 0x58
					public int yHpJPAeaquAkZomQpJwveSbtBTZ; // 0x60
					public int xlmqzMwaJzQMgTIjfqPwUckZnGx; // 0x64
					public ControllerPollingInfo BcdKwrQpXLuFfTaHNnyeKGMktKD; // 0x68
					public ControllerPollingInfo BbXeYPlXwqxxuOwdmmVmZTiiigu; // 0xA0
					public IEnumerator<ControllerPollingInfo> ycLiBIaScwyNrpELelGbGaVtZWw; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180869860-0x00000001808698D0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public AKfotMJaboGCSkdXqlgdGJUeFAtF(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001808696E0-0x0000000180869810
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001808696E0-0x0000000180869810
					private bool MoveNext(); // 0x00000001808690C0-0x00000001808696E0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180869810-0x0000000180869860
					void IDisposable.Dispose(); // 0x00000001808698D0-0x0000000180869940
					private void mjjnILKelBAASEpTRIomFyXhZAEe(); // 0x0000000180869940-0x0000000180869A70
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class keJWfHsmVDTJdRqYBzFJrpGsdPf : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6634
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public IList<Joystick> UUxcZziIyyCIHtnhoBqzTiMpdOS; // 0x58
					public int iFwjwsCHJThcUYDfealyRINBhlAj; // 0x60
					public int mlZVOmjOuiPYxqPrNRPsPRFudYs; // 0x64
					public ControllerPollingInfo lIuULNKfnwCWWfSjsRdcptzHYZKo; // 0x68
					public ControllerPollingInfo xwTIwXlIyemCyefVIXHuJJQuRbY; // 0xA0
					public IEnumerator<ControllerPollingInfo> zsYqbtHXmfTsoEbBYyOZSSvflQf; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018087EAB0-0x000000018087EB20 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public keJWfHsmVDTJdRqYBzFJrpGsdPf(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018087E960-0x000000018087EA60
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018087E960-0x000000018087EA60
					private bool MoveNext(); // 0x000000018087E320-0x000000018087E960
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018087EA60-0x000000018087EAB0
					void IDisposable.Dispose(); // 0x000000018087EB20-0x000000018087EBD0
					private void JwuDFniyORfcXeHkdYjTurcoUQOJ(); // 0x000000018087E2D0-0x000000018087E320
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class AKrCDkEqInEVRtylFTHfoSQIzGV : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6635
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public IList<Joystick> qjmIOCHbBbdlzQbUyNtQbugzbqj; // 0x58
					public int eEUnElnMsoAlIHVxXcTpnXbIzHra; // 0x60
					public int NYNnnShMlnlDNsGsJFkfRYwGSOt; // 0x64
					public ControllerPollingInfo JudxxoQgkgOHLoONoltGKSikTmD; // 0x68
					public ControllerPollingInfo MDxYmMykSOfpimbShdnEmDudeEt; // 0xA0
					public IEnumerator<ControllerPollingInfo> JAIVLEpvkyEuLoXoBiKKGKqPrZm; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018086A080-0x000000018086A0F0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public AKrCDkEqInEVRtylFTHfoSQIzGV(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180869F40-0x000000018086A030
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180869F40-0x000000018086A030
					private bool MoveNext(); // 0x0000000180869A70-0x0000000180869F40
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018086A030-0x000000018086A080
					void IDisposable.Dispose(); // 0x000000018086A0F0-0x000000018086A1E0
					private void dPgNoUYkvilxbgoqdCDWbOqUuMW(); // 0x000000018086A1E0-0x000000018086A230
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class RYmUoNsKRvIZuGYgMrhnaMgNfJy : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6636
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public IList<Joystick> dGLZduyBildKnKLLgVhXfvmuPYFZ; // 0x58
					public int MfymKWkgwadDPXWtgWyaHPKovHu; // 0x60
					public int ZGyfutOPKsXpICkSNzjzcdbPBeV; // 0x64
					public ControllerPollingInfo OHKeUhNVhFUQHgoiScBkNZuaPGb; // 0x68
					public ControllerPollingInfo dgMLmTmeFrJBesGWvDnBCXLlvvMi; // 0xA0
					public IEnumerator<ControllerPollingInfo> cSjSKoDbXReXKNmgSsRJkiqqnCL; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001808775E0-0x0000000180877650 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public RYmUoNsKRvIZuGYgMrhnaMgNfJy(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180877460-0x0000000180877590
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180877460-0x0000000180877590
					private bool MoveNext(); // 0x0000000180876FE0-0x0000000180877460
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180877590-0x00000001808775E0
					void IDisposable.Dispose(); // 0x0000000180877650-0x0000000180877740
					private void ERNfBkLvKlyFkwYqMAGJURIvBwg(); // 0x0000000180876F90-0x0000000180876FE0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class kiFcjQgtdsRkKEjjzTtFaqHHjwuC : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6637
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public int FRSDqXfaespBhDCDevzOMunPlhsy; // 0x58
					public int VYkIHAcGNJAdQdWYaWGsQoCuTMw; // 0x5C
					public CustomController KHsciErgnLIorfXwphOXYiFyBiWh; // 0x60
					public ControllerPollingInfo AhtbFBOOKMakyFelSwOzPBhnqaK; // 0x68
					public ControllerPollingInfo hvFOzaYwWWMTHCLGqUEfQbXMgLp; // 0xA0
					public IEnumerator<ControllerPollingInfo> TMowUiEmOChWYHAaPOAufkEYbFdP; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018087F0F0-0x000000018087F160 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public kiFcjQgtdsRkKEjjzTtFaqHHjwuC(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018087EFB0-0x000000018087F0A0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018087EFB0-0x000000018087F0A0
					private bool MoveNext(); // 0x000000018087EBD0-0x000000018087EFB0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018087F0A0-0x000000018087F0F0
					void IDisposable.Dispose(); // 0x000000018087F160-0x000000018087F1D0
					private void UCeJKEJDaLsszsXalTMxDkCaNni(); // 0x000000018087F1D0-0x000000018087F2F0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class VTvpfXfHHunOiWonwxlVAqSGcSj : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6638
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public int FRSDqXfaespBhDCDevzOMunPlhsy; // 0x58
					public int VYkIHAcGNJAdQdWYaWGsQoCuTMw; // 0x5C
					public CustomController dYuiheMxQrNrfCcsQBAvmhFMlVu; // 0x60
					public ControllerPollingInfo roufOrJmQQRoOmYyLtvCZptFFgS; // 0x68
					public ControllerPollingInfo CWUQYDlwrEEdUmfptVIDktlRpCx; // 0xA0
					public IEnumerator<ControllerPollingInfo> AlLQQMaKSUUnCJWcvbCybqxZQgU; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180879480-0x00000001808794F0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public VTvpfXfHHunOiWonwxlVAqSGcSj(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180879330-0x0000000180879430
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180879330-0x0000000180879430
					private bool MoveNext(); // 0x0000000180878FB0-0x0000000180879330
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180879430-0x0000000180879480
					void IDisposable.Dispose(); // 0x00000001808794F0-0x00000001808795A0
					private void LpSAtIFNkJCaKAjcaebZkcXdPWiJ(); // 0x0000000180878F60-0x0000000180878FB0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class YiXCXkQKgfEpacJYrCacawfdkyio : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6639
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public int FRSDqXfaespBhDCDevzOMunPlhsy; // 0x58
					public int VYkIHAcGNJAdQdWYaWGsQoCuTMw; // 0x5C
					public CustomController tXnBnJEilTglWEcwxYhCWsKatcV; // 0x60
					public ControllerPollingInfo czsbqwAFMPuVlWCyPtjipnBCDoG; // 0x68
					public ControllerPollingInfo IrHeZQBNQcbnypqdcTCySoTRKOIF; // 0xA0
					public IEnumerator<ControllerPollingInfo> RLTiXLtrCJQvtVQDGsyYEkfbtSk; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180879A50-0x0000000180879AC0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public YiXCXkQKgfEpacJYrCacawfdkyio(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180879900-0x0000000180879A00
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180879900-0x0000000180879A00
					private bool MoveNext(); // 0x00000001808795A0-0x0000000180879900
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180879A00-0x0000000180879A50
					void IDisposable.Dispose(); // 0x0000000180879AC0-0x0000000180879B30
					private void pqKpusOlYXnfjOxvSyXpvFHFRFN(); // 0x0000000180879B30-0x0000000180879C50
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class ZSJERXgHekvwfHenwIRmxhKvodtc : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6640
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public int FRSDqXfaespBhDCDevzOMunPlhsy; // 0x58
					public int VYkIHAcGNJAdQdWYaWGsQoCuTMw; // 0x5C
					public CustomController fAFlOwAVDKJSHVJrfVsMItoBKqS; // 0x60
					public ControllerPollingInfo bFHICrAroDRlxTvVxiSURvEfQbqC; // 0x68
					public ControllerPollingInfo cxwZKRPpdBTlVuJAoeUdaknbyab; // 0xA0
					public IEnumerator<ControllerPollingInfo> lEjnksKWgAXbOdfzEANlDBrWtIc; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018087A180-0x000000018087A1F0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public ZSJERXgHekvwfHenwIRmxhKvodtc(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180879FE0-0x000000018087A130
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180879FE0-0x000000018087A130
					private bool MoveNext(); // 0x0000000180879C50-0x0000000180879FE0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018087A130-0x000000018087A180
					void IDisposable.Dispose(); // 0x000000018087A1F0-0x000000018087A2A0
					private void lkDNNaQkAOwbpAgxOXdDVYXbapt(); // 0x000000018087A2A0-0x000000018087A2F0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class MUAwfCvNHsDaochDRApoLwoimLsp : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6641
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public int FRSDqXfaespBhDCDevzOMunPlhsy; // 0x58
					public int VYkIHAcGNJAdQdWYaWGsQoCuTMw; // 0x5C
					public CustomController qEzYXSCZcoOZMkXllVMPHNETXGY; // 0x60
					public ControllerPollingInfo SSMPWmhXvsUTWJKGhYbIZLxPRvL; // 0x68
					public ControllerPollingInfo pcoZXtvqZXnRTTyUXEwJWOVFrpL; // 0xA0
					public IEnumerator<ControllerPollingInfo> sZEBngKoIzOXdUNJiDIiFElJAdql; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018086B820-0x000000018086B890 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public MUAwfCvNHsDaochDRApoLwoimLsp(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018086B6A0-0x000000018086B7D0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018086B6A0-0x000000018086B7D0
					private bool MoveNext(); // 0x000000018086B1D0-0x000000018086B6A0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018086B7D0-0x000000018086B820
					void IDisposable.Dispose(); // 0x000000018086B890-0x000000018086B900
					private void gqsvnpZPqaDPPmTwCcRItmtytJL(); // 0x000000018086B900-0x000000018086BA20
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class nnOJfSsrEaLPcDaLLpJGwvBitiD : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6642
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public IList<CustomController> TrJglavlnGEirxkIKxVmWxthPtp; // 0x58
					public int JRxFExknfFPtBFSIyHvAPsLVUoi; // 0x60
					public int aJdDNcJsuTdDlikPbptGSZwzInow; // 0x64
					public ControllerPollingInfo WCPDrwdmFaSHzciYWcHdfoWzwTid; // 0x68
					public ControllerPollingInfo iyeUJyHXYvfIgDuhjBZJsdebFOug; // 0xA0
					public IEnumerator<ControllerPollingInfo> tVaWbClsLJygCGZCsBkgOGvlRVG; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018087FA00-0x000000018087FA70 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public nnOJfSsrEaLPcDaLLpJGwvBitiD(int <>1__state); // 0x000000018087FAE0-0x000000018087FB50
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018087F880-0x000000018087F9B0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018087F880-0x000000018087F9B0
					private bool MoveNext(); // 0x000000018087F2F0-0x000000018087F880
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018087F9B0-0x000000018087FA00
					void IDisposable.Dispose(); // 0x000000018087FA70-0x000000018087FAE0
					private void joGbrKiZzuivGqYHrRNzrsboSAp(); // 0x000000018087FB50-0x000000018087FC40
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class UGbESIkdAtEWZFaohrhLMBpIYOts : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6643
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public IList<CustomController> zcsDDYEfPybdPwKwlDsqZdffigUT; // 0x58
					public int VqCzvIlJLfYMJNTRtOEBGqRMRjU; // 0x60
					public int bCliFhFDfqCGhXFUrkbXFrqdHYAP; // 0x64
					public ControllerPollingInfo YBDNHBtDTSCEEMaxnQoDtJwjGnQ; // 0x68
					public ControllerPollingInfo afAwQOgjyeSpOEnNAhjnHAQzqMNs; // 0xA0
					public IEnumerator<ControllerPollingInfo> RjCCQJHFnsCiUamGpTNJejtOmpvY; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180878880-0x00000001808788F0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public UGbESIkdAtEWZFaohrhLMBpIYOts(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180878730-0x0000000180878830
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180878730-0x0000000180878830
					private bool MoveNext(); // 0x0000000180878130-0x0000000180878730
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180878830-0x0000000180878880
					void IDisposable.Dispose(); // 0x00000001808788F0-0x0000000180878960
					private void EQluhAPJOkWMtYWjgsiAqkoxbiS(); // 0x0000000180878010-0x0000000180878130
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class bBaPMlWkUHAaTFfKqUkBPVWFJwdn : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6644
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public IList<CustomController> hoyifvPTcMwYFmMYgGijlDokIlBh; // 0x58
					public int PKWqBJDVpgrCCUWUjVEvCdLugkn; // 0x60
					public int aXkGjXpcTTQMDNHeckLvYscgilf; // 0x64
					public ControllerPollingInfo KhxZILoiZxabLKdtPQKzvJNCEPF; // 0x68
					public ControllerPollingInfo wWyiWCNzElHuQgchnkuYYgfPfRlK; // 0xA0
					public IEnumerator<ControllerPollingInfo> dUVxjSJNCityTrFvLjjNHPSYDRD; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018087B150-0x000000018087B1C0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public bBaPMlWkUHAaTFfKqUkBPVWFJwdn(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018087AFE0-0x000000018087B100
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018087AFE0-0x000000018087B100
					private bool MoveNext(); // 0x000000018087AC10-0x000000018087AFE0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018087B100-0x000000018087B150
					void IDisposable.Dispose(); // 0x000000018087B1C0-0x000000018087B230
					private void VeIhzYKDLGQcNcVKGEelUxHlBri(); // 0x000000018087B230-0x000000018087B350
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class NuJLRNtegORChwTlBYTbLgLrBDt : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6645
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public IList<CustomController> zqSDaAghKHeJVGjRjrLhtuLZMbad; // 0x58
					public int WzadnwrhbTHnlGDzgSrQQicOTit; // 0x60
					public int WlTnFoqBScjGOZOBbJlGKkyKxpM; // 0x64
					public ControllerPollingInfo tmaOyWrTJBFIRiFAMVPIvIsjsVX; // 0x68
					public ControllerPollingInfo veUAxnkIMvoCQLjYNtaLkrBgpYq; // 0xA0
					public IEnumerator<ControllerPollingInfo> SjfayFCkFojnQjKHRMREagWrCuO; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018086BFC0-0x000000018086C030 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public NuJLRNtegORChwTlBYTbLgLrBDt(int <>1__state); // 0x000000018086C0E0-0x000000018086C150
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018086BE50-0x000000018086BF70
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018086BE50-0x000000018086BF70
					private bool MoveNext(); // 0x000000018086BA70-0x000000018086BE50
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018086BF70-0x000000018086BFC0
					void IDisposable.Dispose(); // 0x000000018086C030-0x000000018086C0E0
					private void GWsHWjJnudmPZrLzQBKmhHvfpgLn(); // 0x000000018086BA20-0x000000018086BA70
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class vZkZTXMRClNwCGjTqDDnFbVfFekD : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6646
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public IList<CustomController> gtNPZKsRiyHEKvhWgBbZoaeIfkj; // 0x58
					public int cOwgpzfKOVduadaFpfbWXoRFEYzv; // 0x60
					public int HBZkpCBMCYXYfsgnYDtVAoQqatNN; // 0x64
					public ControllerPollingInfo JMhLXnVdtLjuKpDGpVeHqPaaIWb; // 0x68
					public ControllerPollingInfo YLyWmVupLHZNcimVvTUUJXaXPgi; // 0xA0
					public IEnumerator<ControllerPollingInfo> SDdfuJxUuJJnAhxlosQgyHQcQza; // 0xD8
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001808825B0-0x0000000180882620 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public vZkZTXMRClNwCGjTqDDnFbVfFekD(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180882430-0x0000000180882560
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180882430-0x0000000180882560
					private bool MoveNext(); // 0x0000000180882050-0x0000000180882430
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180882560-0x00000001808825B0
					void IDisposable.Dispose(); // 0x0000000180882620-0x00000001808826D0
					private void YuFNQOfmtlzapzcIPzghEEIaiQB(); // 0x00000001808826D0-0x0000000180882720
				}
	
				// Constructors
				internal PollingHelper(Player player, ControllerHelper parent); // 0x0000000180874FF0-0x00000001808750C0
	
				// Methods
				public ControllerPollingInfo PollControllerForFirstElement(ControllerType controllerType, int controllerId); // 0x0000000180874000-0x0000000180874450
				public ControllerPollingInfo PollControllerForFirstElementDown(ControllerType controllerType, int controllerId); // 0x0000000180873B60-0x0000000180874000
				public ControllerPollingInfo PollControllerForFirstButton(ControllerType controllerType, int controllerId); // 0x0000000180873680-0x0000000180873B60
				public ControllerPollingInfo PollControllerForFirstButtonDown(ControllerType controllerType, int controllerId); // 0x00000001808731E0-0x0000000180873680
				public ControllerPollingInfo PollControllerForFirstAxis(ControllerType controllerType, int controllerId); // 0x0000000180872DF0-0x00000001808731E0
				public IEnumerable<ControllerPollingInfo> PollControllerForAllElements(ControllerType controllerType, int controllerId); // 0x0000000180872B30-0x0000000180872DF0
				public IEnumerable<ControllerPollingInfo> PollControllerForAllElementsDown(ControllerType controllerType, int controllerId); // 0x0000000180872810-0x0000000180872B30
				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtons(ControllerType controllerType, int controllerId); // 0x0000000180872600-0x0000000180872810
				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtonsDown(ControllerType controllerType, int controllerId); // 0x0000000180872410-0x0000000180872600
				public IEnumerable<ControllerPollingInfo> PollControllerForAllAxes(ControllerType controllerType, int controllerId); // 0x0000000180872180-0x0000000180872410
				public ControllerPollingInfo PollAllControllersOfTypeForFirstElement(ControllerType controllerType); // 0x0000000180871F00-0x0000000180872180
				public ControllerPollingInfo PollAllControllersOfTypeForFirstButton(ControllerType controllerType); // 0x00000001808719E0-0x0000000180871F00
				public ControllerPollingInfo PollAllControllersOfTypeForFirstButtonDown(ControllerType controllerType); // 0x0000000180871640-0x00000001808719E0
				public ControllerPollingInfo PollAllControllersOfTypeForFirstAxis(ControllerType controllerType); // 0x00000001808711E0-0x0000000180871640
				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllElements(ControllerType controllerType); // 0x0000000180870F80-0x00000001808711E0
				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllElementsDown(ControllerType controllerType); // 0x0000000180870D90-0x0000000180870F80
				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllButtons(ControllerType controllerType); // 0x0000000180870BA0-0x0000000180870D90
				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllButtonsDown(ControllerType controllerType); // 0x0000000180870900-0x0000000180870BA0
				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllAxes(ControllerType controllerType); // 0x00000001808706F0-0x0000000180870900
				private ControllerPollingInfo bGKlLbFWmbtGAiOmNKKPUtnwcAZ(int param_0000e431); // 0x00000001808750C0-0x0000000180875240
				private ControllerPollingInfo rqyemvFZhjSSrBYMaOhYnmPCKqem(int param_0000e432); // 0x0000000180876390-0x00000001808764F0
				private ControllerPollingInfo NQtBLmIPQGvDNomIxxmiVjxcQNAA(int param_0000e433); // 0x0000000180870040-0x00000001808701D0
				private ControllerPollingInfo NadfyxFpnsKvEQGCdsAnNZMYaax(int param_0000e434); // 0x00000001808701D0-0x0000000180870370
				private ControllerPollingInfo oKWdenitALAFVrRNgIdhEPKFJvb(int param_0000e435); // 0x0000000180875C30-0x0000000180875D80
				private IEnumerable<ControllerPollingInfo> ZWimbzFMwCSuhYFEcXFEeWFifWR(int param_0000e436); // 0x0000000180874D40-0x0000000180874DF0
				private IEnumerable<ControllerPollingInfo> RehcirISqbiBTGUaoHnpFtPenXv(int param_0000e437); // 0x00000001808744E0-0x0000000180874590
				private IEnumerable<ControllerPollingInfo> zWDCSWjzhmjQvPyFnbCXiBHCOwJJ(int param_0000e438); // 0x0000000180876A40-0x0000000180876AD0
				private IEnumerable<ControllerPollingInfo> MtBriKVVFZdgebmAQffCEKEFdXl(int param_0000e439); // 0x000000018086FFB0-0x0000000180870040
				private IEnumerable<ControllerPollingInfo> OSicUzHcokWNlWyDVoxJoXjEYvE(int param_0000e43a); // 0x0000000180870370-0x0000000180870400
				private ControllerPollingInfo dxGBopFwPGpRnntJodvmMTzYCpiY(); // 0x00000001808752D0-0x0000000180875580
				private ControllerPollingInfo fWKPjGiTOuPWukeRyCkdtHrmENvE(); // 0x0000000180875580-0x0000000180875820
				private ControllerPollingInfo ZofbmNrsDVSejYtKcoCeGNYmbpn(); // 0x0000000180874DF0-0x0000000180874FF0
				private ControllerPollingInfo PUcjNuzteixdxqKUVlKFhYGZmsf(); // 0x0000000180870520-0x00000001808706F0
				private ControllerPollingInfo UKRVFPSTSpcGXWGJXZBATXbYkwq(); // 0x0000000180874780-0x0000000180874940
				private IEnumerable<ControllerPollingInfo> AItrmiLLNLETHbDmllsTwttPIQaC(); // 0x000000018086F640-0x000000018086F6C0
				private IEnumerable<ControllerPollingInfo> jrGRHFKGLMVcvwxfLWDvEVEfMLi(); // 0x0000000180875940-0x00000001808759C0
				private IEnumerable<ControllerPollingInfo> BtGYtVGEqwSHtYaXzzQUrewGJtn(); // 0x000000018086F970-0x000000018086F9F0
				private IEnumerable<ControllerPollingInfo> uMQCThPkzuvLVNhlZAgYnTPKtmq(); // 0x0000000180876730-0x00000001808767B0
				private IEnumerable<ControllerPollingInfo> CfecEujJWgnIEBaHKLlKSQqNiSk(); // 0x000000018086F9F0-0x000000018086FA70
				private ControllerPollingInfo DIwYDhteIrUYYQHskNqJZhFugHo(); // 0x000000018086FA70-0x000000018086FB00
				private ControllerPollingInfo ciKfGFbLFusTsJrpdJggIwKAROUA(); // 0x0000000180875240-0x00000001808752D0
				private IEnumerable<ControllerPollingInfo> omzYIcEzjUxwVujJpCnfGdFwAbX(); // 0x0000000180875FF0-0x0000000180876070
				private IEnumerable<ControllerPollingInfo> MklBDqRYzLrUUBNdRhVSLsUiLKI(); // 0x000000018086FF30-0x000000018086FFB0
				private ControllerPollingInfo nPZxtrrDJyGWOPAciHrsnAGWWPi(); // 0x0000000180875BA0-0x0000000180875C30
				private ControllerPollingInfo qBQnfvsldcNuFORfufcManPBmLhk(); // 0x0000000180876300-0x0000000180876390
				private ControllerPollingInfo gzutiYORsAguHeeehFjLCLdsDfQh(); // 0x00000001808758B0-0x0000000180875940
				private ControllerPollingInfo QjcCJttJgHDOZjHbrELXHpwfUGLO(); // 0x0000000180874450-0x00000001808744E0
				private ControllerPollingInfo sNEfSVWAjRTlpjNlZKETBtDzecp(); // 0x00000001808764F0-0x0000000180876580
				private IEnumerable<ControllerPollingInfo> LhmHRTYQoeUAxXbxFBjrIwBLUWUp(); // 0x000000018086FE20-0x000000018086FEB0
				private IEnumerable<ControllerPollingInfo> ZPuArbyTCfKafkfAWuhezckKgqj(); // 0x0000000180874CB0-0x0000000180874D40
				private IEnumerable<ControllerPollingInfo> gsMyLZGcNmItjsvMlQRZdhKNgYvC(); // 0x0000000180875820-0x00000001808758B0
				private IEnumerable<ControllerPollingInfo> OyLGmfjCcioJWJtAePmnOTazcwS(); // 0x0000000180870490-0x0000000180870520
				private IEnumerable<ControllerPollingInfo> KyIBIZHBRRlfClOWAZETcMKeKqb(); // 0x000000018086FDA0-0x000000018086FE20
				private ControllerPollingInfo ukARGcUNoOKRPjiqVKBcGVMeLqZ(int param_0000e43b); // 0x00000001808767B0-0x0000000180876910
				private ControllerPollingInfo SsyPctSmRbgMoZvfEsIGiNBNfBS(int param_0000e43c); // 0x0000000180874590-0x00000001808746F0
				private ControllerPollingInfo HTLpMztZmHhBNnBWhwmKUZaJjJx(int param_0000e43d); // 0x000000018086FC70-0x000000018086FDA0
				private ControllerPollingInfo EVefEGecgrsLVWECEuaCKzyFaYa(int param_0000e43e); // 0x000000018086FB00-0x000000018086FC70
				private ControllerPollingInfo meAjTtJCVRtvGxDotlYZDOPybkb(int param_0000e43f); // 0x0000000180875A40-0x0000000180875BA0
				private IEnumerable<ControllerPollingInfo> wYgrvTepDlcraADeICRgBBKzeBpu(int param_0000e440); // 0x0000000180876910-0x00000001808769A0
				private IEnumerable<ControllerPollingInfo> BqEGmaeHIeNTnicYHhRMjMtLkMLC(int param_0000e441); // 0x000000018086F6C0-0x000000018086F750
				private IEnumerable<ControllerPollingInfo> YklCVTfTmFGyKDdTjkJgSXyKecKX(int param_0000e442); // 0x0000000180874C00-0x0000000180874CB0
				private IEnumerable<ControllerPollingInfo> OevlbRZKmWsizWsTsKtDOUmFvIt(int param_0000e443); // 0x0000000180870400-0x0000000180870490
				private IEnumerable<ControllerPollingInfo> TrQFuxrthJtxLaAuKTMNREkLqsA(int param_0000e444); // 0x00000001808746F0-0x0000000180874780
				private ControllerPollingInfo oSFtmtOlVnmtllndgZhgzjXrcPbB(); // 0x0000000180875D80-0x0000000180875FF0
				private ControllerPollingInfo BqyFLNGhnxjMKKYomIkiUEqnhvbC(); // 0x000000018086F750-0x000000018086F970
				private ControllerPollingInfo pxpCQJFztfslpkhJUtGDeDKsfMI(); // 0x0000000180876130-0x0000000180876300
				private ControllerPollingInfo VttanxeBuoolFYVesRmMRlbaZaiL(); // 0x0000000180874940-0x0000000180874B80
				private ControllerPollingInfo sxpqmzYXwllNCeZVMFVbptxNUkx(); // 0x0000000180876580-0x0000000180876730
				private IEnumerable<ControllerPollingInfo> ptBfGdJhSVIOGLSnobCWSRZzxBii(); // 0x0000000180876070-0x0000000180876130
				private IEnumerable<ControllerPollingInfo> XKeRkgCoTdFtbODgFSXZqtgWlrZ(); // 0x0000000180874B80-0x0000000180874C00
				private IEnumerable<ControllerPollingInfo> MJIamdcXeYbqxTTEaHBvVhjKibf(); // 0x000000018086FEB0-0x000000018086FF30
				private IEnumerable<ControllerPollingInfo> yoOWDMRSkMEUZtHTwrKxqttgCFo(); // 0x00000001808769A0-0x0000000180876A40
				private IEnumerable<ControllerPollingInfo> maRRnmjmoNDrDjpkFIWHkPqGUslH(); // 0x00000001808759C0-0x0000000180875A40
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class oevHatVHifWURdnOTzPYFQtPrXj : IEnumerable<Controller>, IEnumerator<Controller> // TypeDefIndex: 6647
			{
				// Fields
				private Controller aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public ControllerHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int AhLxwFKRxnlmvTkCPpwqSWfHvNK; // 0x28
				public IList<Joystick> KaTVtYXdnIexpbRPqRTcjzBGvHFi; // 0x30
				public int DteXgtkdonKsIueFqDxBRYoRLvj; // 0x38
				public int KeSIUfcrzmKlhHbuWImGZHAOprfL; // 0x3C
				public IList<CustomController> FCGxhtXDbdyoimPIsyRVbbkkfJC; // 0x40
				public int pZiIWgXORgPECaBXrOJZTjMciLmE; // 0x48
	
				// Properties
				Controller zfTTcVuktSqnpnLaNjCEBYRXWaU { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public oevHatVHifWURdnOTzPYFQtPrXj(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Controller> IEnumerable<Controller>.GetEnumerator(); // 0x00000001808800A0-0x0000000180880180
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001808800A0-0x0000000180880180
				private bool MoveNext(); // 0x000000018087FC40-0x00000001808800A0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180880180-0x00000001808801D0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			internal ControllerHelper(Player player, VVLouGbEKulMPcFZiTUTqikUjEp startingControllerMapInfo, ControllerMapLayoutManager.StartingSettings controllerMapLayoutManagerSettings, ControllerMapEnabler.ZgESyvoCZDaaWJMTaxFmFrlTHlVN controllerMapEnablerSettings); // 0x000000018083D4D0-0x000000018083DA00
	
			// Methods
			public T GetController<T>(int controllerId)
				where T : Controller;
			public Controller GetController(ControllerType controllerType, int controllerId); // 0x0000000180839A50-0x0000000180839BB0
			public T GetControllerWithTag<T>(string tag)
				where T : Controller;
			public Controller GetControllerWithTag(ControllerType controllerType, string tag); // 0x00000001808398F0-0x0000000180839A50
			public void AddController<T>(int controllerId, bool removeFromOtherPlayers)
				where T : Controller;
			public void AddController(Controller controller, bool removeFromOtherPlayers); // 0x00000001808385F0-0x0000000180838850
			public void AddController(ControllerType controllerType, int controllerId, bool removeFromOtherPlayers); // 0x0000000180838850-0x0000000180838BF0
			public void RemoveController<T>(int controllerId)
				where T : Controller;
			public void RemoveController(ControllerType controllerType, int controllerId); // 0x000000018083B350-0x000000018083B4E0
			public void RemoveController(Controller controller); // 0x000000018083B4E0-0x000000018083B700
			public bool ContainsController<T>(int controllerId)
				where T : Controller;
			public bool ContainsController(ControllerType controllerType, int controllerId); // 0x00000001808392A0-0x0000000180839470
			public bool ContainsController(Controller controller); // 0x0000000180839470-0x0000000180839540
			public void ClearControllersOfType<T>()
				where T : Controller;
			public void ClearControllersOfType(ControllerType controllerType); // 0x0000000180838FC0-0x0000000180839140
			public void ClearAllControllers(); // 0x0000000180838EF0-0x0000000180838FC0
			public Controller GetLastActiveController(); // 0x000000018083A020-0x000000018083A280
			public Controller GetLastActiveController(ControllerType controllerType); // 0x000000018083A280-0x000000018083A5F0
			private void EUVYCARsIPrBKbpQiGBVjqXpKpjH(ControllerType param_0000de0e, ref Controller param_0000de0f, ref float param_0000de10); // 0x0000000180839540-0x00000001808398B0
			public Controller GetLastActiveController<T>()
				where T : Controller;
			public void AddLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback); // 0x0000000180838BF0-0x0000000180838D60
			public void AddLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback, ControllerType controllerType); // 0x0000000180838D60-0x0000000180838EF0
			public void RemoveLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback); // 0x000000018083B850-0x000000018083B9E0
			public void RemoveLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback, ControllerType controllerType); // 0x000000018083B700-0x000000018083B850
			public void ClearLastActiveControllerChangedDelegates(); // 0x0000000180839140-0x00000001808392A0
			public Controller GetFirstControllerWithTemplate(Guid templateTypeGuid); // 0x0000000180839BB0-0x0000000180839E00
			public Controller GetFirstControllerWithTemplate(Type templateType); // 0x0000000180839E00-0x000000018083A020
			public Controller GetFirstControllerWithTemplate<T>()
				where T : class;
			public IList<TInterface> GetControllerTemplates<TInterface>()
				where TInterface : IControllerTemplate;
			private Controller jYszhMBrmTjIcZxErgYoWfGYMXC<TDelegateParam>(ControllerType param_0000de19, Func<Controller, TDelegateParam, bool> param_0000de1a, TDelegateParam param_0000de1b);
			internal void ItdhavHGXcUkAhyjaCFbIXENJheh(); // 0x000000018083A5F0-0x000000018083AA30
			internal float FYIElmJxflCFhgIZyTsOMvYpGHtG(int param_0000de1c); // 0x00000001808398B0-0x00000001808398F0
			internal void XaPQxcyWqNsdQjhKzBKsjimvZyS(Joystick param_0000de1d, bool param_0000de1e); // 0x000000018083BE90-0x000000018083C3F0
			internal void XaPQxcyWqNsdQjhKzBKsjimvZyS(int param_0000de1f, bool param_0000de20); // 0x000000018083BDC0-0x000000018083BE90
			internal void xzceZeGGWmetBAeiWNsduDUsewIa(int param_0000de21); // 0x000000018083F490-0x000000018083F910
			internal void xzceZeGGWmetBAeiWNsduDUsewIa(Joystick param_0000de22); // 0x000000018083F470-0x000000018083F490
			internal void JVgdmkDNRxZQzikVOAghyODdmTo(); // 0x000000018083AA30-0x000000018083AFE0
			internal void XiHbKYIwqhdauDbRGGwGkFljxrFY(CustomController param_0000de23, bool param_0000de24); // 0x000000018083C3F0-0x000000018083C770
			internal void XiHbKYIwqhdauDbRGGwGkFljxrFY(int param_0000de25, bool param_0000de26); // 0x000000018083C770-0x000000018083C840
			internal void ThZteeIklpsxGRYsSIfxQcYzcae(int param_0000de27); // 0x000000018083B9E0-0x000000018083BDA0
			internal void ThZteeIklpsxGRYsSIfxQcYzcae(CustomController param_0000de28); // 0x000000018083BDA0-0x000000018083BDC0
			internal void uOzYhSCLiLcGIIOdEdqkuYDlGKHv(); // 0x000000018083EF60-0x000000018083F420
			internal CustomController KVVCTKWyFZmIycuszMOZbQGKMvX(int param_0000de29); // 0x000000018083AFE0-0x000000018083B350
			internal void tzDaIgFQnfsVMqJsHHtXDlwsoxaI(Action<bool, int, int> param_0000de2a); // 0x000000018083EF10-0x000000018083EF60
			internal void AbkUkCWdTMWidEEQvyYkEXJXtVW(Keyboard param_0000de2b, djpwPzKBzvznzxIiuRBprQLHfCc param_0000de2c, Action<bool, int, int> param_0000de2d); // 0x0000000180837B40-0x00000001808385F0
			private static void XpMdjVJIiPLupjAFCctYNYGLQFMI(Keyboard param_0000de2e, ControllerMap param_0000de2f, ActionElementMap param_0000de30, IqIukLIsmYdsSTXcphOdCKQUWBG param_0000de31, ButtonStateFlags param_0000de32); // 0x000000018083C840-0x000000018083C980
			internal void ZUUoXTAWbstgZnbECVAwXArHCqOf(Mouse param_0000de33, Action<bool, int, int> param_0000de34); // 0x000000018083C980-0x000000018083D4D0
			internal void xYYePMSKaQDySNlDrymJaiyuDfTi(Action<bool, int, int> param_0000de35); // 0x000000018083F420-0x000000018083F470
			private void oKtDVECOnvicsHXYOjPcsNPoasn<T, TMap>(ControllerType param_0000de36, Action<bool, int, int> param_0000de37)
				where T : ControllerWithAxes
				where TMap : ControllerMapWithAxes;
			private bool PPjNWtPrrNLfSFeDfxlPEFiPlWi<TMap>(ControllerWithAxes param_0000de38, int param_0000de39, int param_0000de3a, ActionElementMap param_0000de3b, UqmUJOucnPAhoXhVuhvbmxKGsOH<TMap> param_0000de3c, int param_0000de3d, ref float param_0000de3e)
				where TMap : ControllerMapWithAxes;
			private bool VgZTJYILLhKkehwJvkGIEHsbWZu<TMap>(UnknownControllerHat.HatButtons param_0000de3f, int param_0000de40, UqmUJOucnPAhoXhVuhvbmxKGsOH<TMap> param_0000de41)
				where TMap : ControllerMapWithAxes;
			private bool PTrrixCBiTdabCtPetYhlDlQzig<TMap>(UnknownControllerHat.HatButtons param_0000de42, int param_0000de43, UqmUJOucnPAhoXhVuhvbmxKGsOH<TMap> param_0000de44)
				where TMap : ControllerMapWithAxes;
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static void pOcCcEPETYfiVgcsLGAPfcnitqGJ(Exception param_0000de45); // 0x000000018083E530-0x000000018083E590
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static void nKBfZOoSRNcWGVmXsGDbjHqfeFdg(Exception param_0000de46); // 0x000000018083E4D0-0x000000018083E530
		}
	
		// Constructors
		internal Player(bool isSystem, int playerId, string name, string descriptiveName, VVLouGbEKulMPcFZiTUTqikUjEp startingControllerMapInfo, ControllerMapLayoutManager.StartingSettings controllerMapLayoutManagerSettings, ControllerMapEnabler.ZgESyvoCZDaaWJMTaxFmFrlTHlVN controllerMapEnablerSettings); // 0x000000018084D4D0-0x000000018084D6C0
	
		// Methods
		public PlayerSaveData GetSaveData(bool userAssignableMapsOnly); // 0x000000018084ADC0-0x000000018084B030
		public bool GetButton(string actionName); // 0x0000000180847600-0x00000001808476E0
		public bool GetButton(int actionId); // 0x00000001808474F0-0x0000000180847600
		public bool GetButtonDown(string actionName); // 0x0000000180844F60-0x0000000180845040
		public bool GetButtonDown(int actionId); // 0x0000000180844E60-0x0000000180844F60
		public bool GetButtonUp(string actionName); // 0x00000001808472E0-0x00000001808473C0
		public bool GetButtonUp(int actionId); // 0x00000001808473C0-0x00000001808474F0
		public bool GetButtonPrev(string actionName); // 0x0000000180845610-0x00000001808456F0
		public bool GetButtonPrev(int actionId); // 0x00000001808456F0-0x00000001808457D0
		public bool GetButtonSinglePressHold(int actionId); // 0x00000001808461F0-0x0000000180846300
		public bool GetButtonSinglePressHold(string actionName); // 0x0000000180846110-0x00000001808461F0
		public bool GetButtonSinglePressDown(int actionId); // 0x0000000180845F50-0x0000000180846030
		public bool GetButtonSinglePressDown(string actionName); // 0x0000000180846030-0x0000000180846110
		public bool GetButtonSinglePressUp(int actionId); // 0x0000000180846300-0x0000000180846400
		public bool GetButtonSinglePressUp(string actionName); // 0x0000000180846400-0x00000001808464E0
		public bool GetButtonDoublePressHold(string actionName, float speed); // 0x00000001808446D0-0x00000001808447F0
		public bool GetButtonDoublePressHold(int actionId, float speed); // 0x00000001808447F0-0x00000001808448D0
		public bool GetButtonDoublePressHold(string actionName); // 0x00000001808449B0-0x0000000180844AC0
		public bool GetButtonDoublePressHold(int actionId); // 0x00000001808448D0-0x00000001808449B0
		public bool GetButtonDoublePressDown(string actionName, float speed); // 0x0000000180844500-0x00000001808445F0
		public bool GetButtonDoublePressDown(int actionId, float speed); // 0x00000001808445F0-0x00000001808446D0
		public bool GetButtonDoublePressDown(string actionName); // 0x0000000180844280-0x00000001808443C0
		public bool GetButtonDoublePressDown(int actionId); // 0x00000001808443C0-0x0000000180844500
		public bool GetButtonDoublePressUp(string actionName, float speed); // 0x0000000180844BA0-0x0000000180844C90
		public bool GetButtonDoublePressUp(int actionId, float speed); // 0x0000000180844AC0-0x0000000180844BA0
		public bool GetButtonDoublePressUp(string actionName); // 0x0000000180844D70-0x0000000180844E60
		public bool GetButtonDoublePressUp(int actionId); // 0x0000000180844C90-0x0000000180844D70
		public bool GetButtonTimedPress(string actionName, float time); // 0x0000000180846EC0-0x0000000180846FB0
		public bool GetButtonTimedPress(int actionId, float time); // 0x00000001808470E0-0x00000001808471D0
		public bool GetButtonTimedPress(string actionName, float time, float expireIn); // 0x0000000180846FB0-0x00000001808470E0
		public bool GetButtonTimedPress(int actionId, float time, float expireIn); // 0x00000001808471D0-0x00000001808472E0
		public bool GetButtonTimedPressDown(string actionName, float time); // 0x0000000180846990-0x0000000180846A80
		public bool GetButtonTimedPressDown(int actionId, float time); // 0x0000000180846880-0x0000000180846990
		public bool GetButtonTimedPressUp(string actionName, float time); // 0x0000000180846DB0-0x0000000180846EC0
		public bool GetButtonTimedPressUp(int actionId, float time); // 0x0000000180846A80-0x0000000180846B70
		public bool GetButtonTimedPressUp(string actionName, float time, float expireIn); // 0x0000000180846B70-0x0000000180846C90
		public bool GetButtonTimedPressUp(int actionId, float time, float expireIn); // 0x0000000180846C90-0x0000000180846DB0
		public bool GetButtonShortPress(string actionName); // 0x0000000180845E40-0x0000000180845F50
		public bool GetButtonShortPress(int actionId); // 0x0000000180845D60-0x0000000180845E40
		public bool GetButtonShortPressDown(string actionName); // 0x0000000180845AA0-0x0000000180845B80
		public bool GetButtonShortPressDown(int actionId); // 0x0000000180845990-0x0000000180845AA0
		public bool GetButtonShortPressUp(string actionName); // 0x0000000180845C80-0x0000000180845D60
		public bool GetButtonShortPressUp(int actionId); // 0x0000000180845B80-0x0000000180845C80
		public bool GetButtonLongPress(string actionName); // 0x0000000180845500-0x0000000180845610
		public bool GetButtonLongPress(int actionId); // 0x00000001808453F0-0x0000000180845500
		public bool GetButtonLongPressDown(string actionName); // 0x0000000180845150-0x0000000180845230
		public bool GetButtonLongPressDown(int actionId); // 0x0000000180845040-0x0000000180845150
		public bool GetButtonLongPressUp(string actionName); // 0x0000000180845310-0x00000001808453F0
		public bool GetButtonLongPressUp(int actionId); // 0x0000000180845230-0x0000000180845310
		public bool GetButtonRepeating(string actionName); // 0x00000001808458B0-0x0000000180845990
		public bool GetButtonRepeating(int actionId); // 0x00000001808457D0-0x00000001808458B0
		public bool GetAnyButton(); // 0x0000000180841550-0x0000000180841630
		public bool GetAnyButtonDown(); // 0x0000000180841310-0x00000001808413F0
		public bool GetAnyButtonUp(); // 0x00000001808414A0-0x0000000180841550
		public bool GetAnyButtonPrev(); // 0x00000001808413F0-0x00000001808414A0
		public float GetButtonTimePressed(string actionName); // 0x00000001808465C0-0x00000001808466A0
		public float GetButtonTimePressed(int actionId); // 0x00000001808464E0-0x00000001808465C0
		public float GetButtonTimeUnpressed(string actionName); // 0x0000000180846780-0x0000000180846880
		public float GetButtonTimeUnpressed(int actionId); // 0x00000001808466A0-0x0000000180846780
		public bool GetNegativeButton(string actionName); // 0x000000018084AC00-0x000000018084ACE0
		public bool GetNegativeButton(int actionId); // 0x000000018084ACE0-0x000000018084ADC0
		public bool GetNegativeButtonDown(string actionName); // 0x00000001808484C0-0x00000001808485A0
		public bool GetNegativeButtonDown(int actionId); // 0x00000001808485A0-0x00000001808486A0
		public bool GetNegativeButtonUp(string actionName); // 0x000000018084A9E0-0x000000018084AAF0
		public bool GetNegativeButtonUp(int actionId); // 0x000000018084AAF0-0x000000018084AC00
		public bool GetNegativeButtonPrev(string actionName); // 0x0000000180848C40-0x0000000180848D20
		public bool GetNegativeButtonPrev(int actionId); // 0x0000000180848D20-0x0000000180848E20
		public bool GetNegativeButtonSinglePressHold(int actionId); // 0x0000000180849870-0x00000001808499A0
		public bool GetNegativeButtonSinglePressHold(string actionName); // 0x0000000180849790-0x0000000180849870
		public bool GetNegativeButtonSinglePressDown(int actionId); // 0x00000001808495A0-0x0000000180849680
		public bool GetNegativeButtonSinglePressDown(string actionName); // 0x0000000180849680-0x0000000180849790
		public bool GetNegativeButtonSinglePressUp(int actionId); // 0x0000000180849A80-0x0000000180849BB0
		public bool GetNegativeButtonSinglePressUp(string actionName); // 0x00000001808499A0-0x0000000180849A80
		public bool GetNegativeButtonDoublePressHold(string actionName, float speed); // 0x0000000180847D60-0x0000000180847E90
		public bool GetNegativeButtonDoublePressHold(int actionId, float speed); // 0x0000000180847C80-0x0000000180847D60
		public bool GetNegativeButtonDoublePressHold(string actionName); // 0x0000000180847E90-0x0000000180847FC0
		public bool GetNegativeButtonDoublePressHold(int actionId); // 0x0000000180847FC0-0x00000001808480A0
		public bool GetNegativeButtonDoublePressDown(string actionName, float speed); // 0x0000000180847AB0-0x0000000180847BA0
		public bool GetNegativeButtonDoublePressDown(int actionId, float speed); // 0x0000000180847BA0-0x0000000180847C80
		public bool GetNegativeButtonDoublePressDown(string actionName); // 0x00000001808478E0-0x00000001808479D0
		public bool GetNegativeButtonDoublePressDown(int actionId); // 0x00000001808479D0-0x0000000180847AB0
		public bool GetNegativeButtonDoublePressUp(string actionName, float speed); // 0x00000001808483D0-0x00000001808484C0
		public bool GetNegativeButtonDoublePressUp(int actionId, float speed); // 0x0000000180848190-0x00000001808482C0
		public bool GetNegativeButtonDoublePressUp(string actionName); // 0x00000001808480A0-0x0000000180848190
		public bool GetNegativeButtonDoublePressUp(int actionId); // 0x00000001808482C0-0x00000001808483D0
		public bool GetNegativeButtonTimedPress(string actionName, float time); // 0x000000018084A6D0-0x000000018084A7C0
		public bool GetNegativeButtonTimedPress(int actionId, float time); // 0x000000018084A8D0-0x000000018084A9E0
		public bool GetNegativeButtonTimedPress(string actionName, float time, float expireIn); // 0x000000018084A7C0-0x000000018084A8D0
		public bool GetNegativeButtonTimedPress(int actionId, float time, float expireIn); // 0x000000018084A5C0-0x000000018084A6D0
		public bool GetNegativeButtonTimedPressDown(string actionName, float time); // 0x0000000180849FE0-0x000000018084A100
		public bool GetNegativeButtonTimedPressDown(int actionId, float time); // 0x000000018084A100-0x000000018084A1E0
		public bool GetNegativeButtonTimedPressUp(string actionName, float time); // 0x000000018084A1E0-0x000000018084A2E0
		public bool GetNegativeButtonTimedPressUp(int actionId, float time); // 0x000000018084A4D0-0x000000018084A5C0
		public bool GetNegativeButtonTimedPressUp(string actionName, float time, float expireIn); // 0x000000018084A3D0-0x000000018084A4D0
		public bool GetNegativeButtonTimedPressUp(int actionId, float time, float expireIn); // 0x000000018084A2E0-0x000000018084A3D0
		public bool GetNegativeButtonShortPress(string actionName); // 0x00000001808494C0-0x00000001808495A0
		public bool GetNegativeButtonShortPress(int actionId); // 0x00000001808493B0-0x00000001808494C0
		public bool GetNegativeButtonShortPressDown(string actionName); // 0x00000001808490D0-0x00000001808491F0
		public bool GetNegativeButtonShortPressDown(int actionId); // 0x0000000180848FF0-0x00000001808490D0
		public bool GetNegativeButtonShortPressUp(string actionName); // 0x00000001808492D0-0x00000001808493B0
		public bool GetNegativeButtonShortPressUp(int actionId); // 0x00000001808491F0-0x00000001808492D0
		public bool GetNegativeButtonLongPress(string actionName); // 0x0000000180848B30-0x0000000180848C40
		public bool GetNegativeButtonLongPress(int actionId); // 0x0000000180848A50-0x0000000180848B30
		public bool GetNegativeButtonLongPressDown(string actionName); // 0x0000000180848780-0x0000000180848860
		public bool GetNegativeButtonLongPressDown(int actionId); // 0x00000001808486A0-0x0000000180848780
		public bool GetNegativeButtonLongPressUp(string actionName); // 0x0000000180848860-0x0000000180848940
		public bool GetNegativeButtonLongPressUp(int actionId); // 0x0000000180848940-0x0000000180848A50
		public bool GetNegativeButtonRepeating(string actionName); // 0x0000000180848F10-0x0000000180848FF0
		public bool GetNegativeButtonRepeating(int actionId); // 0x0000000180848E20-0x0000000180848F10
		public bool GetAnyNegativeButton(); // 0x0000000180841840-0x00000001808418F0
		public bool GetAnyNegativeButtonDown(); // 0x0000000180841630-0x00000001808416E0
		public bool GetAnyNegativeButtonUp(); // 0x0000000180841790-0x0000000180841840
		public bool GetAnyNegativeButtonPrev(); // 0x00000001808416E0-0x0000000180841790
		public float GetNegativeButtonTimePressed(string actionName); // 0x0000000180849BB0-0x0000000180849CC0
		public float GetNegativeButtonTimePressed(int actionId); // 0x0000000180849CC0-0x0000000180849DA0
		public float GetNegativeButtonTimeUnpressed(string actionName); // 0x0000000180849DA0-0x0000000180849EE0
		public float GetNegativeButtonTimeUnpressed(int actionId); // 0x0000000180849EE0-0x0000000180849FE0
		public float GetAxis(string actionName); // 0x00000001808440A0-0x00000001808441A0
		public float GetAxis(int actionId); // 0x00000001808441A0-0x0000000180844280
		public float GetAxisRaw(string actionName); // 0x0000000180843BC0-0x0000000180843CA0
		public float GetAxisRaw(int actionId); // 0x0000000180843AE0-0x0000000180843BC0
		public float GetAxisPrev(string actionName); // 0x0000000180842F40-0x0000000180843020
		public float GetAxisPrev(int actionId); // 0x0000000180842E60-0x0000000180842F40
		public float GetAxisRawPrev(string actionName); // 0x00000001808435A0-0x0000000180843680
		public float GetAxisRawPrev(int actionId); // 0x0000000180843680-0x0000000180843760
		public float GetAxisDelta(string actionName); // 0x0000000180842CA0-0x0000000180842D80
		public float GetAxisDelta(int actionId); // 0x0000000180842D80-0x0000000180842E60
		public float GetAxisRawDelta(string actionName); // 0x00000001808433E0-0x00000001808434C0
		public float GetAxisRawDelta(int actionId); // 0x00000001808434C0-0x00000001808435A0
		public Vector2 GetAxis2D(string xAxisActionName, string yAxisActionName); // 0x0000000180842720-0x00000001808428E0
		public Vector2 GetAxis2D(int xAxisActionId, int yAxisActionId); // 0x0000000180842550-0x0000000180842720
		public Vector2 GetAxis2DPrev(string xAxisActionName, string yAxisActionName); // 0x0000000180841B30-0x0000000180841D20
		public Vector2 GetAxis2DPrev(int xAxisActionId, int yAxisActionId); // 0x00000001808418F0-0x0000000180841B30
		public Vector2 GetAxis2DRaw(string xAxisActionName, string yAxisActionName); // 0x0000000180842110-0x0000000180842340
		public Vector2 GetAxis2DRaw(int xAxisActionId, int yAxisActionId); // 0x0000000180842340-0x0000000180842550
		public Vector2 GetAxis2DRawPrev(string xAxisActionName, string yAxisActionName); // 0x0000000180841EF0-0x0000000180842110
		public Vector2 GetAxis2DRawPrev(int xAxisActionId, int yAxisActionId); // 0x0000000180841D20-0x0000000180841EF0
		public float GetAxisTimeActive(string actionName); // 0x0000000180843DB0-0x0000000180843E90
		public float GetAxisTimeActive(int actionId); // 0x0000000180843CA0-0x0000000180843DB0
		public float GetAxisTimeInactive(string actionName); // 0x0000000180843F70-0x00000001808440A0
		public float GetAxisTimeInactive(int actionId); // 0x0000000180843E90-0x0000000180843F70
		public float GetAxisRawTimeActive(string actionName); // 0x0000000180843840-0x0000000180843920
		public float GetAxisRawTimeActive(int actionId); // 0x0000000180843760-0x0000000180843840
		public float GetAxisRawTimeInactive(string actionName); // 0x0000000180843A00-0x0000000180843AE0
		public float GetAxisRawTimeInactive(int actionId); // 0x0000000180843920-0x0000000180843A00
		public AxisCoordinateMode GetAxisCoordinateMode(string actionName); // 0x0000000180842BC0-0x0000000180842CA0
		public AxisCoordinateMode GetAxisCoordinateMode(int actionId); // 0x0000000180842AA0-0x0000000180842BC0
		public AxisCoordinateMode GetAxisRawCoordinateMode(string actionName); // 0x0000000180843200-0x0000000180843300
		public AxisCoordinateMode GetAxisRawCoordinateMode(int actionId); // 0x0000000180843300-0x00000001808433E0
		public AxisCoordinateMode GetAxisCoordinateModePrev(string actionName); // 0x00000001808428E0-0x00000001808429C0
		public AxisCoordinateMode GetAxisCoordinateModePrev(int actionId); // 0x00000001808429C0-0x0000000180842AA0
		public AxisCoordinateMode GetAxisRawCoordinateModePrev(string actionName); // 0x0000000180843120-0x0000000180843200
		public AxisCoordinateMode GetAxisRawCoordinateModePrev(int actionId); // 0x0000000180843020-0x0000000180843120
		public IList<InputActionSourceData> GetCurrentInputSources(string actionName); // 0x00000001808477E0-0x00000001808478E0
		public IList<InputActionSourceData> GetCurrentInputSources(int actionId); // 0x00000001808476E0-0x00000001808477E0
		public bool IsCurrentInputSource(string actionName, ControllerType controllerType); // 0x000000018084B400-0x000000018084B4E0
		public bool IsCurrentInputSource(int actionId, ControllerType controllerType); // 0x000000018084B5D0-0x000000018084B6B0
		public bool IsCurrentInputSource(string actionName, ControllerType controllerType, int controllerId); // 0x000000018084B6B0-0x000000018084B7B0
		public bool IsCurrentInputSource(int actionId, ControllerType controllerType, int controllerId); // 0x000000018084B300-0x000000018084B400
		public bool IsCurrentInputSource(string actionName, Controller controller); // 0x000000018084B4E0-0x000000018084B5D0
		public bool IsCurrentInputSource(int actionId, Controller controller); // 0x000000018084B1E0-0x000000018084B300
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop); // 0x00000001808407F0-0x0000000180840990
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, int actionId); // 0x0000000180840650-0x00000001808407F0
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, string actionName); // 0x0000000180840310-0x0000000180840650
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType); // 0x0000000180840990-0x0000000180840AF0
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId); // 0x0000000180840AF0-0x0000000180840B20
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName); // 0x0000000180840D30-0x0000000180840F30
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, object[] arguments); // 0x0000000180841090-0x00000001808411F0
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId, object[] arguments); // 0x0000000180840F30-0x0000000180841090
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName, object[] arguments); // 0x0000000180840B20-0x0000000180840D30
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback); // 0x000000018084BAA0-0x000000018084BC10
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, int actionId); // 0x000000018084BDA0-0x000000018084BF10
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, string actionName); // 0x000000018084C360-0x000000018084C6E0
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop); // 0x000000018084C9F0-0x000000018084CB30
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType); // 0x000000018084C870-0x000000018084C9F0
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, int actionId); // 0x000000018084BC10-0x000000018084BDA0
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, string actionName); // 0x000000018084BF10-0x000000018084C1D0
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType, int actionId); // 0x000000018084C1D0-0x000000018084C360
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType, string actionName); // 0x000000018084B7E0-0x000000018084BAA0
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType); // 0x000000018084C6E0-0x000000018084C870
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId); // 0x000000018084CB30-0x000000018084CCE0
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName); // 0x000000018084CCE0-0x000000018084CFB0
		public void ClearInputEventDelegates(); // 0x00000001808411F0-0x0000000180841310
		public void SetVibration(int motorIndex, float motorLevel); // 0x000000018084CFD0-0x000000018084CFF0
		public void SetVibration(int motorIndex, float motorLevel, float duration); // 0x000000018084CFB0-0x000000018084CFD0
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors); // 0x000000018084CFF0-0x000000018084D010
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors); // 0x000000018084D010-0x000000018084D230
		public float GetVibration(int motorIndex); // 0x000000018084B030-0x000000018084B1E0
		public void StopVibration(); // 0x000000018084D230-0x000000018084D4D0
		internal void SmPrdLxmfnoOLIRlFAKVSpooigo(); // 0x000000018084B7B0-0x000000018084B7E0
		private void ItdhavHGXcUkAhyjaCFbIXENJheh(); // 0x000000018084B7B0-0x000000018084B7E0
	}
}

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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public sealed class Player // TypeDefIndex: 6747
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
		public int id { get; internal set; } // 0x00000001811875D0-0x0000000181187670 0x000000018042D0F0-0x000000018042D100
		public string name { get; internal set; } // 0x0000000181187710-0x00000001811877C0 0x00000001803F70C0-0x00000001803F70D0
		public string descriptiveName { get; internal set; } // 0x0000000181187520-0x00000001811875D0 0x00000001803FA0C0-0x00000001803FA0D0
		public bool isPlaying { get; set; } // 0x0000000181187670-0x0000000181187710 0x0000000180455C10-0x0000000180455C20
	
		// Nested types
		[Browsable] // 0x0000000180210FD0-0x0000000180211010
		[EditorBrowsable] // 0x0000000180210FD0-0x0000000180211010
		public sealed class ControllerHelper // TypeDefIndex: 6748
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
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Action<Exception> SoptGiBIwpEzOTmBujKpoVBsSer; // 0x00
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Action<Exception> AGoLVphFiYSQJEBguHfxHhzJytur; // 0x08
	
			// Properties
			private yuzjpKSgIlOzFrmYoCjvudWJHqg<Joystick, JoystickMap> joystickSet { get; } // 0x00000001811781F0-0x0000000181178260 
			private UqmUJOucnPAhoXhVuhvbmxKGsOH<KeyboardMap> keyboardMapSet { get; } // 0x0000000181178260-0x0000000181178310 
			private UqmUJOucnPAhoXhVuhvbmxKGsOH<MouseMap> mouseMapSet { get; } // 0x0000000181178310-0x00000001811783C0 
			private yuzjpKSgIlOzFrmYoCjvudWJHqg<CustomController, CustomControllerMap> customControllerSet { get; } // 0x0000000181177EA0-0x0000000181177F10 
			public bool hasMouse { get; set; } // 0x0000000181178050-0x0000000181178120 0x00000001811789C0-0x0000000181178DD0
			public bool hasKeyboard { get; set; } // 0x0000000181177FB0-0x0000000181178050 0x00000001811785F0-0x00000001811789C0
			public bool excludeFromControllerAutoAssignment { get; set; } // 0x0000000181177F10-0x0000000181177FB0 0x0000000181178540-0x00000001811785F0
			public Keyboard Keyboard { get; } // 0x0000000181177C10-0x0000000181177CD0 
			public Mouse Mouse { get; } // 0x0000000181177CD0-0x0000000181177D90 
			public int joystickCount { get; } // 0x0000000181178120-0x00000001811781F0 
			public IList<Joystick> Joysticks { get; } // 0x0000000181177B20-0x0000000181177C10 
			public int customControllerCount { get; } // 0x0000000181177D90-0x0000000181177EA0 
			public IList<CustomController> CustomControllers { get; } // 0x0000000181177A30-0x0000000181177B20 
			public IEnumerable<Controller> Controllers { get; } // 0x00000001811779C0-0x0000000181177A30 
	
			// Events
			public event Action<ControllerAssignmentChangedEventArgs> ControllerAddedEvent {
				add; // 0x0000000181177900-0x0000000181177960
				remove; // 0x0000000181178480-0x00000001811784E0
			}
			public event Action<ControllerAssignmentChangedEventArgs> ControllerRemovedEvent {
				add; // 0x0000000181177960-0x00000001811779C0
				remove; // 0x00000001811784E0-0x0000000181178540
			}
	
			// Nested types
			[Browsable] // 0x0000000180210FD0-0x0000000180211010
			[EditorBrowsable] // 0x0000000180210FD0-0x0000000180211010
			public sealed class ConflictCheckingHelper : CodeHelper // TypeDefIndex: 6749
			{
				// Fields
				private readonly Player yHWXapLnjMXUYBDESFaAUIdnziK; // 0x10
				private readonly ControllerHelper GsoDNwSmTlqXUxYxRnLUXMOoArhh; // 0x18
				private readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x20
	
				// Nested types
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class SzsVaIezRRtvUGCGQSactMaiXzx : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6750
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001812A3410-0x00000001812A3470 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public SzsVaIezRRtvUGCGQSactMaiXzx(int <>1__state); // 0x00000001812A34E0-0x00000001812A3550
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x00000001812A3280-0x00000001812A33C0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001812A3280-0x00000001812A33C0
					private bool MoveNext(); // 0x00000001812A2E80-0x00000001812A3280
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001812A33C0-0x00000001812A3410
					void IDisposable.Dispose(); // 0x00000001812A3470-0x00000001812A34E0
					private void dbcAqPOPRsdGnKnXQdpmygocXEL(); // 0x00000001812A3550-0x00000001812A3680
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class wTIkzkqxyPQpNRizyWXQMIpUlJw : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6751
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001812A55D0-0x00000001812A5630 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public wTIkzkqxyPQpNRizyWXQMIpUlJw(int <>1__state); // 0x0000000180EE87E0-0x0000000180EE8830
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x00000001812A5460-0x00000001812A5580
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001812A5460-0x00000001812A5580
					private bool MoveNext(); // 0x00000001812A4FA0-0x00000001812A5460
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001812A5580-0x00000001812A55D0
					void IDisposable.Dispose(); // 0x00000001812A5630-0x00000001812A56A0
					private void xcAVusbXlUDusmCdbvVNsTYvMHV(); // 0x00000001812A56A0-0x00000001812A57C0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class MbaVideVWBJvwyBfaieKiefXdDFH : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6752
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x000000018117A080-0x000000018117A0E0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public MbaVideVWBJvwyBfaieKiefXdDFH(int <>1__state); // 0x0000000180EE87E0-0x0000000180EE8830
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000181179EC0-0x000000018117A030
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181179EC0-0x000000018117A030
					private bool MoveNext(); // 0x0000000181179810-0x0000000181179E70
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x000000018117A030-0x000000018117A080
					void IDisposable.Dispose(); // 0x000000018117A0E0-0x000000018117A190
					private void RsDcNovKyKhnWvjwYFNKEyositf(); // 0x0000000181179E70-0x0000000181179EC0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class lbGCxUtbsCUWEYjwuLUIEqbQFbDc : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6753
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001812A4600-0x00000001812A4660 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public lbGCxUtbsCUWEYjwuLUIEqbQFbDc(int <>1__state); // 0x0000000180EE87E0-0x0000000180EE8830
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x00000001812A4440-0x00000001812A45B0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001812A4440-0x00000001812A45B0
					private bool MoveNext(); // 0x00000001812A3EC0-0x00000001812A4440
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001812A45B0-0x00000001812A4600
					void IDisposable.Dispose(); // 0x00000001812A4660-0x00000001812A46D0
					private void ZzaLzKBGxfxOMRfaoRENBijhygg(); // 0x00000001812A46D0-0x00000001812A47F0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class XimVxZsAJJlhYNNJOetGgvRrdDd : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6754
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001812A3CA0-0x00000001812A3D00 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public XimVxZsAJJlhYNNJOetGgvRrdDd(int <>1__state); // 0x0000000180EE87E0-0x0000000180EE8830
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x00000001812A3B10-0x00000001812A3C50
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001812A3B10-0x00000001812A3C50
					private bool MoveNext(); // 0x00000001812A3680-0x00000001812A3B10
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001812A3C50-0x00000001812A3CA0
					void IDisposable.Dispose(); // 0x00000001812A3D00-0x00000001812A3DA0
					private void YKcbISxRyfoXfGDKpQEZechYaZY(); // 0x00000001812A3DA0-0x00000001812A3EC0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class wQHAtjccGdckXIyVLyPzolzcNGNQ : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6755
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001812A4E90-0x00000001812A4EF0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public wQHAtjccGdckXIyVLyPzolzcNGNQ(int <>1__state); // 0x0000000180EE87E0-0x0000000180EE8830
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x00000001812A4CE0-0x00000001812A4E40
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001812A4CE0-0x00000001812A4E40
					private bool MoveNext(); // 0x00000001812A4840-0x00000001812A4CE0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001812A4E40-0x00000001812A4E90
					void IDisposable.Dispose(); // 0x00000001812A4EF0-0x00000001812A4FA0
					private void EuqoCsxJgbyLTLQWQWXqAlploEj(); // 0x00000001812A47F0-0x00000001812A4840
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class PuVMbLmYgSEDXCslgLvixWwJtIx<T> : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6756
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public PuVMbLmYgSEDXCslgLvixWwJtIx(int <>1__state);
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator();
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator();
					private bool MoveNext();
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset();
					void IDisposable.Dispose();
					private void zwycPmKKqzmwlzvHmKkodWCoEpgs();
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class rRVYQiFhxnxaLpQbzwWsBBpBeuI<T> : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6757
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public rRVYQiFhxnxaLpQbzwWsBBpBeuI(int <>1__state);
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator();
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator();
					private bool MoveNext();
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset();
					void IDisposable.Dispose();
					private void DsTpVgMHWRPtNsSqsDRbdOEEKgE();
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class nnsDbiyEFehLmZPfthrqCLdLqabh<T> : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6758
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public nnsDbiyEFehLmZPfthrqCLdLqabh(int <>1__state);
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator();
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator();
					private bool MoveNext();
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset();
					void IDisposable.Dispose();
					private void PrLaIDOKwuIEIBpQhboNIabkErob();
				}
	
				// Constructors
				internal ConflictCheckingHelper(Player player, ControllerHelper parent); // 0x000000018116EF10-0x000000018116EFE0
	
				// Methods
				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap); // 0x000000018116AAE0-0x000000018116AB10
				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps); // 0x000000018116ADB0-0x000000018116ADE0
				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x000000018116AB10-0x000000018116ADB0
				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap); // 0x000000018116AE30-0x000000018116AE60
				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps); // 0x000000018116B100-0x000000018116B130
				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x000000018116B130-0x000000018116B410
				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck); // 0x000000018116AA90-0x000000018116AAE0
				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x000000018116ADE0-0x000000018116AE30
				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x000000018116AE60-0x000000018116B100
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap); // 0x000000018116C110-0x000000018116C140
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps); // 0x000000018116C9A0-0x000000018116C9D0
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x000000018116BDE0-0x000000018116C110
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap); // 0x000000018116C9D0-0x000000018116CA00
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps); // 0x000000018116C1E0-0x000000018116C210
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x000000018116C210-0x000000018116C5A0
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x000000018116C140-0x000000018116C190
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x000000018116C190-0x000000018116C1E0
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x000000018116C5A0-0x000000018116C9A0
				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap); // 0x000000018116E7D0-0x000000018116E800
				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipRemovedMaps); // 0x000000018116E7A0-0x000000018116E7D0
				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipRemovedMaps, bool forceCheckAllCategories); // 0x000000018116E800-0x000000018116EA70
				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap); // 0x000000018116E1C0-0x000000018116E1F0
				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipRemovedMaps); // 0x000000018116E190-0x000000018116E1C0
				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipRemovedMaps, bool forceCheckAllCategories); // 0x000000018116E240-0x000000018116E500
				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x000000018116EA70-0x000000018116EAC0
				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipRemovedMaps); // 0x000000018116E1F0-0x000000018116E240
				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipRemovedMaps, bool forceCheckAllCategories); // 0x000000018116E500-0x000000018116E7A0
				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap); // 0x000000018116A960-0x000000018116A990
				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps); // 0x000000018116A990-0x000000018116A9C0
				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x000000018116A130-0x000000018116A3D0
				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap); // 0x000000018116A100-0x000000018116A130
				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps); // 0x000000018116AA10-0x000000018116AA40
				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x000000018116A670-0x000000018116A960
				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x000000018116A9C0-0x000000018116AA10
				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x000000018116AA40-0x000000018116AA90
				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x000000018116A3D0-0x000000018116A670
				private bool DxUxCsinfAWFYpubKnmfntdUduK(int param_0000e13d, JoystickMap param_0000e13e, bool param_0000e13f = false /* Metadata: 0x00765E1B */, bool param_0000e140 = false /* Metadata: 0x00765E1C */); // 0x000000018116B410-0x000000018116B740
				private bool DxUxCsinfAWFYpubKnmfntdUduK(int param_0000e141, JoystickMap param_0000e142, ActionElementMap param_0000e143, bool param_0000e144 = false /* Metadata: 0x00765E1D */, bool param_0000e145 = false /* Metadata: 0x00765E1E */); // 0x000000018116BA90-0x000000018116BDE0
				private bool DxUxCsinfAWFYpubKnmfntdUduK(ElementAssignmentConflictCheck param_0000e146, bool param_0000e147 = false /* Metadata: 0x00765E1F */, bool param_0000e148 = false /* Metadata: 0x00765E20 */); // 0x000000018116B740-0x000000018116BA90
				private bool wXcueicCklSRvlxEnukgGZLyfpI(KeyboardMap param_0000e149, bool param_0000e14a = false /* Metadata: 0x00765E21 */, bool param_0000e14b = false /* Metadata: 0x00765E22 */); // 0x0000000181170EC0-0x0000000181170F60
				private bool wXcueicCklSRvlxEnukgGZLyfpI(KeyboardMap param_0000e14c, ActionElementMap param_0000e14d, bool param_0000e14e = false /* Metadata: 0x00765E23 */, bool param_0000e14f = false /* Metadata: 0x00765E24 */); // 0x0000000181170F60-0x0000000181171000
				private bool wXcueicCklSRvlxEnukgGZLyfpI(ElementAssignmentConflictCheck param_0000e150, bool param_0000e151 = false /* Metadata: 0x00765E25 */, bool param_0000e152 = false /* Metadata: 0x00765E26 */); // 0x0000000181170E00-0x0000000181170EC0
				private bool aEPFDkgvlTaxDMvMdXmXlPcSWfzg(MouseMap param_0000e153, bool param_0000e154 = false /* Metadata: 0x00765E27 */, bool param_0000e155 = false /* Metadata: 0x00765E28 */); // 0x000000018116EFE0-0x000000018116F080
				private bool aEPFDkgvlTaxDMvMdXmXlPcSWfzg(MouseMap param_0000e156, ActionElementMap param_0000e157, bool param_0000e158 = false /* Metadata: 0x00765E29 */, bool param_0000e159 = false /* Metadata: 0x00765E2A */); // 0x000000018116F080-0x000000018116F120
				private bool aEPFDkgvlTaxDMvMdXmXlPcSWfzg(ElementAssignmentConflictCheck param_0000e15a, bool param_0000e15b = false /* Metadata: 0x00765E2B */, bool param_0000e15c = false /* Metadata: 0x00765E2C */); // 0x000000018116F120-0x000000018116F1E0
				private bool RTzJvqyIWdYfpLMnYXwBLikApnt(int param_0000e15d, CustomControllerMap param_0000e15e, bool param_0000e15f = false /* Metadata: 0x00765E2D */, bool param_0000e160 = false /* Metadata: 0x00765E2E */); // 0x000000018116D820-0x000000018116DB40
				private bool RTzJvqyIWdYfpLMnYXwBLikApnt(int param_0000e161, CustomControllerMap param_0000e162, ActionElementMap param_0000e163, bool param_0000e164 = false /* Metadata: 0x00765E2F */, bool param_0000e165 = false /* Metadata: 0x00765E30 */); // 0x000000018116DB40-0x000000018116DE90
				private bool RTzJvqyIWdYfpLMnYXwBLikApnt(ElementAssignmentConflictCheck param_0000e166, bool param_0000e167 = false /* Metadata: 0x00765E31 */, bool param_0000e168 = false /* Metadata: 0x00765E32 */); // 0x000000018116DE90-0x000000018116E190
				private IEnumerable<ElementAssignmentConflictInfo> MRgnTPvPKuFIQVnkoOgsMkvypzz(int param_0000e169, JoystickMap param_0000e16a, bool param_0000e16b = false /* Metadata: 0x00765E33 */, bool param_0000e16c = false /* Metadata: 0x00765E34 */); // 0x000000018116CC20-0x000000018116CCC0
				private IEnumerable<ElementAssignmentConflictInfo> MRgnTPvPKuFIQVnkoOgsMkvypzz(int param_0000e16d, JoystickMap param_0000e16e, ActionElementMap param_0000e16f, bool param_0000e170 = false /* Metadata: 0x00765E35 */, bool param_0000e171 = false /* Metadata: 0x00765E36 */); // 0x000000018116CDC0-0x000000018116CE70
				private IEnumerable<ElementAssignmentConflictInfo> MRgnTPvPKuFIQVnkoOgsMkvypzz(ElementAssignmentConflictCheck param_0000e172, bool param_0000e173 = false /* Metadata: 0x00765E37 */, bool param_0000e174 = false /* Metadata: 0x00765E38 */); // 0x000000018116CCC0-0x000000018116CDC0
				private IEnumerable<ElementAssignmentConflictInfo> tUDCLjaXyYDhvMbyzbdykNyovBi(KeyboardMap param_0000e175, bool param_0000e176 = false /* Metadata: 0x00765E39 */, bool param_0000e177 = false /* Metadata: 0x00765E3A */); // 0x0000000181170B60-0x0000000181170C00
				private IEnumerable<ElementAssignmentConflictInfo> tUDCLjaXyYDhvMbyzbdykNyovBi(KeyboardMap param_0000e178, ActionElementMap param_0000e179, bool param_0000e17a = false /* Metadata: 0x00765E3B */, bool param_0000e17b = false /* Metadata: 0x00765E3C */); // 0x0000000181170AC0-0x0000000181170B60
				private IEnumerable<ElementAssignmentConflictInfo> tUDCLjaXyYDhvMbyzbdykNyovBi(ElementAssignmentConflictCheck param_0000e17c, bool param_0000e17d = false /* Metadata: 0x00765E3D */, bool param_0000e17e = false /* Metadata: 0x00765E3E */); // 0x00000001811709E0-0x0000000181170AC0
				private IEnumerable<ElementAssignmentConflictInfo> GBpaKcaXjHwRPKNwzvYTCbohHIuH(MouseMap param_0000e17f, bool param_0000e180 = false /* Metadata: 0x00765E3F */, bool param_0000e181 = false /* Metadata: 0x00765E40 */); // 0x000000018116CAA0-0x000000018116CB40
				private IEnumerable<ElementAssignmentConflictInfo> GBpaKcaXjHwRPKNwzvYTCbohHIuH(MouseMap param_0000e182, ActionElementMap param_0000e183, bool param_0000e184 = false /* Metadata: 0x00765E41 */, bool param_0000e185 = false /* Metadata: 0x00765E42 */); // 0x000000018116CA00-0x000000018116CAA0
				private IEnumerable<ElementAssignmentConflictInfo> GBpaKcaXjHwRPKNwzvYTCbohHIuH(ElementAssignmentConflictCheck param_0000e186, bool param_0000e187 = false /* Metadata: 0x00765E43 */, bool param_0000e188 = false /* Metadata: 0x00765E44 */); // 0x000000018116CB40-0x000000018116CC20
				private IEnumerable<ElementAssignmentConflictInfo> nYfulgjqWJpqujfJpXbCGeUTYHC(int param_0000e189, CustomControllerMap param_0000e18a, bool param_0000e18b = false /* Metadata: 0x00765E45 */, bool param_0000e18c = false /* Metadata: 0x00765E46 */); // 0x000000018116F360-0x000000018116F400
				private IEnumerable<ElementAssignmentConflictInfo> nYfulgjqWJpqujfJpXbCGeUTYHC(int param_0000e18d, CustomControllerMap param_0000e18e, ActionElementMap param_0000e18f, bool param_0000e190 = false /* Metadata: 0x00765E47 */, bool param_0000e191 = false /* Metadata: 0x00765E48 */); // 0x000000018116F2B0-0x000000018116F360
				private IEnumerable<ElementAssignmentConflictInfo> nYfulgjqWJpqujfJpXbCGeUTYHC(ElementAssignmentConflictCheck param_0000e192, bool param_0000e193 = false /* Metadata: 0x00765E49 */, bool param_0000e194 = false /* Metadata: 0x00765E4A */); // 0x000000018116F1E0-0x000000018116F2B0
				private int zUesUqgzAjTqcPAFWJspqFdOSAK(int param_0000e195, JoystickMap param_0000e196, bool param_0000e197 = false /* Metadata: 0x00765E4B */, bool param_0000e198 = false /* Metadata: 0x00765E4C */); // 0x0000000181171370-0x0000000181171680
				private int zUesUqgzAjTqcPAFWJspqFdOSAK(int param_0000e199, JoystickMap param_0000e19a, ActionElementMap param_0000e19b, bool param_0000e19c = false /* Metadata: 0x00765E4D */, bool param_0000e19d = false /* Metadata: 0x00765E4E */); // 0x0000000181171680-0x00000001811719B0
				private int zUesUqgzAjTqcPAFWJspqFdOSAK(ElementAssignmentConflictCheck param_0000e19e, bool param_0000e19f = false /* Metadata: 0x00765E4F */, bool param_0000e1a0 = false /* Metadata: 0x00765E50 */); // 0x0000000181171000-0x0000000181171370
				private int AAzbhFdYOVScAsWiElenoaQTPBi(KeyboardMap param_0000e1a1, bool param_0000e1a2 = false /* Metadata: 0x00765E51 */, bool param_0000e1a3 = false /* Metadata: 0x00765E52 */); // 0x0000000181169F00-0x0000000181169FA0
				private int AAzbhFdYOVScAsWiElenoaQTPBi(KeyboardMap param_0000e1a4, ActionElementMap param_0000e1a5, bool param_0000e1a6 = false /* Metadata: 0x00765E53 */, bool param_0000e1a7 = false /* Metadata: 0x00765E54 */); // 0x000000018116A060-0x000000018116A100
				private int AAzbhFdYOVScAsWiElenoaQTPBi(ElementAssignmentConflictCheck param_0000e1a8, bool param_0000e1a9 = false /* Metadata: 0x00765E55 */, bool param_0000e1aa = false /* Metadata: 0x00765E56 */); // 0x0000000181169FA0-0x000000018116A060
				private int ulBXXqKdVzAGMiziSQvOSsbqBDM(MouseMap param_0000e1ab, bool param_0000e1ac = false /* Metadata: 0x00765E57 */, bool param_0000e1ad = false /* Metadata: 0x00765E58 */); // 0x0000000181170D60-0x0000000181170E00
				private int ulBXXqKdVzAGMiziSQvOSsbqBDM(MouseMap param_0000e1ae, ActionElementMap param_0000e1af, bool param_0000e1b0 = false /* Metadata: 0x00765E59 */, bool param_0000e1b1 = false /* Metadata: 0x00765E5A */); // 0x0000000181170CC0-0x0000000181170D60
				private int ulBXXqKdVzAGMiziSQvOSsbqBDM(ElementAssignmentConflictCheck param_0000e1b2, bool param_0000e1b3 = false /* Metadata: 0x00765E5B */, bool param_0000e1b4 = false /* Metadata: 0x00765E5C */); // 0x0000000181170C00-0x0000000181170CC0
				private int ogsyqhxhlaCnaGAJLkpKnbhucbi(int param_0000e1b5, CustomControllerMap param_0000e1b6, bool param_0000e1b7 = false /* Metadata: 0x00765E5D */, bool param_0000e1b8 = false /* Metadata: 0x00765E5E */); // 0x000000018116F400-0x000000018116F740
				private int ogsyqhxhlaCnaGAJLkpKnbhucbi(int param_0000e1b9, CustomControllerMap param_0000e1ba, ActionElementMap param_0000e1bb, bool param_0000e1bc = false /* Metadata: 0x00765E5F */, bool param_0000e1bd = false /* Metadata: 0x00765E60 */); // 0x000000018116F740-0x000000018116FA90
				private int ogsyqhxhlaCnaGAJLkpKnbhucbi(ElementAssignmentConflictCheck param_0000e1be, bool param_0000e1bf = false /* Metadata: 0x00765E61 */, bool param_0000e1c0 = false /* Metadata: 0x00765E62 */); // 0x000000018116FA90-0x000000018116FDD0
				private int NelggbthumjxGTexgIAOZhYwWoK(int param_0000e1c1, JoystickMap param_0000e1c2, bool param_0000e1c3 = false /* Metadata: 0x00765E63 */, bool param_0000e1c4 = false /* Metadata: 0x00765E64 */, List<ActionElementMap> param_0000e1c5 = null); // 0x000000018116D1B0-0x000000018116D4D0
				private int NelggbthumjxGTexgIAOZhYwWoK(int param_0000e1c6, JoystickMap param_0000e1c7, ActionElementMap param_0000e1c8, bool param_0000e1c9 = false /* Metadata: 0x00765E65 */, bool param_0000e1ca = false /* Metadata: 0x00765E66 */, List<ActionElementMap> param_0000e1cb = null); // 0x000000018116CE70-0x000000018116D1B0
				private int NelggbthumjxGTexgIAOZhYwWoK(ElementAssignmentConflictCheck param_0000e1cc, bool param_0000e1cd = false /* Metadata: 0x00765E67 */, bool param_0000e1ce = false /* Metadata: 0x00765E68 */, List<ActionElementMap> param_0000e1cf = null); // 0x000000018116D4D0-0x000000018116D820
				private int SkffTQYiVFTbnzlfYOUqAgXirDr(KeyboardMap param_0000e1d0, bool param_0000e1d1 = false /* Metadata: 0x00765E69 */, bool param_0000e1d2 = false /* Metadata: 0x00765E6A */, List<ActionElementMap> param_0000e1d3 = null); // 0x000000018116EDA0-0x000000018116EE40
				private int SkffTQYiVFTbnzlfYOUqAgXirDr(KeyboardMap param_0000e1d4, ActionElementMap param_0000e1d5, bool param_0000e1d6 = false /* Metadata: 0x00765E6B */, bool param_0000e1d7 = false /* Metadata: 0x00765E6C */, List<ActionElementMap> param_0000e1d8 = null); // 0x000000018116ECF0-0x000000018116EDA0
				private int SkffTQYiVFTbnzlfYOUqAgXirDr(ElementAssignmentConflictCheck param_0000e1d9, bool param_0000e1da = false /* Metadata: 0x00765E6D */, bool param_0000e1db = false /* Metadata: 0x00765E6E */, List<ActionElementMap> param_0000e1dc = null); // 0x000000018116EE40-0x000000018116EF10
				private int ptrQHwldfEFdoVXaZbwIaOGNCLAh(MouseMap param_0000e1dd, bool param_0000e1de = false /* Metadata: 0x00765E6F */, bool param_0000e1df = false /* Metadata: 0x00765E70 */, List<ActionElementMap> param_0000e1e0 = null); // 0x000000018116FF50-0x0000000181170000
				private int ptrQHwldfEFdoVXaZbwIaOGNCLAh(MouseMap param_0000e1e1, ActionElementMap param_0000e1e2, bool param_0000e1e3 = false /* Metadata: 0x00765E71 */, bool param_0000e1e4 = false /* Metadata: 0x00765E72 */, List<ActionElementMap> param_0000e1e5 = null); // 0x000000018116FEA0-0x000000018116FF50
				private int ptrQHwldfEFdoVXaZbwIaOGNCLAh(ElementAssignmentConflictCheck param_0000e1e6, bool param_0000e1e7 = false /* Metadata: 0x00765E73 */, bool param_0000e1e8 = false /* Metadata: 0x00765E74 */, List<ActionElementMap> param_0000e1e9 = null); // 0x000000018116FDD0-0x000000018116FEA0
				private int qzXyzfORVDqhzRVipLqpqtoChSh(int param_0000e1ea, CustomControllerMap param_0000e1eb, bool param_0000e1ec = false /* Metadata: 0x00765E75 */, bool param_0000e1ed = false /* Metadata: 0x00765E76 */, List<ActionElementMap> param_0000e1ee = null); // 0x0000000181170340-0x0000000181170640
				private int qzXyzfORVDqhzRVipLqpqtoChSh(int param_0000e1ef, CustomControllerMap param_0000e1f0, ActionElementMap param_0000e1f1, bool param_0000e1f2 = false /* Metadata: 0x00765E77 */, bool param_0000e1f3 = false /* Metadata: 0x00765E78 */, List<ActionElementMap> param_0000e1f4 = null); // 0x0000000181170000-0x0000000181170340
				private int qzXyzfORVDqhzRVipLqpqtoChSh(ElementAssignmentConflictCheck param_0000e1f5, bool param_0000e1f6 = false /* Metadata: 0x00765E79 */, bool param_0000e1f7 = false /* Metadata: 0x00765E7A */, List<ActionElementMap> param_0000e1f8 = null); // 0x0000000181170640-0x00000001811709E0
				private bool rCWLbLscSTtJFXWAMHzqUevhLDg<T>(ControllerType param_0000e1f9, int param_0000e1fa, T param_0000e1fb, bool param_0000e1fc, bool param_0000e1fd, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000e1fe)
					where T : ControllerMap;
				private bool rCWLbLscSTtJFXWAMHzqUevhLDg<T>(ControllerType param_0000e1ff, int param_0000e200, T param_0000e201, ActionElementMap param_0000e202, bool param_0000e203, bool param_0000e204, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000e205)
					where T : ControllerMap;
				private bool rCWLbLscSTtJFXWAMHzqUevhLDg<T>(ElementAssignmentConflictCheck param_0000e206, bool param_0000e207, bool param_0000e208, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000e209)
					where T : ControllerMap;
				private IEnumerable<ElementAssignmentConflictInfo> XcEtdDcnreaNiJbFAQuTHdzlGEEj<T>(ControllerType param_0000e20a, int param_0000e20b, T param_0000e20c, bool param_0000e20d, bool param_0000e20e, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000e20f)
					where T : ControllerMap;
				private IEnumerable<ElementAssignmentConflictInfo> XcEtdDcnreaNiJbFAQuTHdzlGEEj<T>(ControllerType param_0000e210, int param_0000e211, T param_0000e212, ActionElementMap param_0000e213, bool param_0000e214, bool param_0000e215, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000e216)
					where T : ControllerMap;
				private IEnumerable<ElementAssignmentConflictInfo> XcEtdDcnreaNiJbFAQuTHdzlGEEj<T>(ElementAssignmentConflictCheck param_0000e217, bool param_0000e218, bool param_0000e219, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000e21a)
					where T : ControllerMap;
				private int WjCYeZhDvSvxKcQpcKOBJaKPtus<T>(ControllerType param_0000e21b, int param_0000e21c, T param_0000e21d, bool param_0000e21e, bool param_0000e21f, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000e220)
					where T : ControllerMap;
				private int WjCYeZhDvSvxKcQpcKOBJaKPtus<T>(ControllerType param_0000e221, int param_0000e222, T param_0000e223, ActionElementMap param_0000e224, bool param_0000e225, bool param_0000e226, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000e227)
					where T : ControllerMap;
				private int WjCYeZhDvSvxKcQpcKOBJaKPtus<T>(ElementAssignmentConflictCheck param_0000e228, bool param_0000e229, bool param_0000e22a, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000e22b)
					where T : ControllerMap;
				private int QuwzUKTytrTXmrjDzPdLAVycjts<T>(ControllerType param_0000e22c, int param_0000e22d, T param_0000e22e, bool param_0000e22f, bool param_0000e230, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000e231, List<ActionElementMap> param_0000e232 = null)
					where T : ControllerMap;
				private int QuwzUKTytrTXmrjDzPdLAVycjts<T>(ControllerType param_0000e233, int param_0000e234, T param_0000e235, ActionElementMap param_0000e236, bool param_0000e237, bool param_0000e238, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000e239, List<ActionElementMap> param_0000e23a = null)
					where T : ControllerMap;
				private int QuwzUKTytrTXmrjDzPdLAVycjts<T>(ElementAssignmentConflictCheck param_0000e23b, bool param_0000e23c, bool param_0000e23d, UqmUJOucnPAhoXhVuhvbmxKGsOH<T> param_0000e23e, List<ActionElementMap> param_0000e23f = null)
					where T : ControllerMap;
				private bool SABKxadsuyVakSFClQoKRWbOjqP(InputMapCategory param_0000e240, ControllerMap param_0000e241); // 0x000000018116EAC0-0x000000018116ECF0
			}
	
			internal interface uwILKJrQnvyPKXqkviwAHMwxglt // TypeDefIndex: 6759
			{
				// Properties
				zPwANwSjcNWfOppJVpCEtGyMPGw MWiOWGzUiqOkOMPKltvfuPDthis[int index] { get => default; }
				ControllerType CGckBVNLLRbsxHptZVYgQLPSxKH { get; }
				int SHujHYUxHggDGFiBfPBtOLtZhMW { get; }
	
				// Methods
				bool Contains(Controller param_0000e24c);
				bool Contains(int param_0000e24d);
				void RemoveController(int param_0000e24e);
				void RemoveController(Controller param_0000e24f);
				void RemoveAt(int param_0000e250);
				Controller GetController(int param_0000e251);
				Controller GetControllerWithTag(string param_0000e252);
				int IndexOf(Controller param_0000e253);
				int IndexOf(int param_0000e254);
				int IndexOfTag(string param_0000e255);
				void Clear();
				zPwANwSjcNWfOppJVpCEtGyMPGw GetEntry(int param_0000e256);
				zPwANwSjcNWfOppJVpCEtGyMPGw GetEntry(Controller param_0000e257);
				void AddEntry(zPwANwSjcNWfOppJVpCEtGyMPGw param_0000e258);
			}
	
			internal interface zPwANwSjcNWfOppJVpCEtGyMPGw // TypeDefIndex: 6760
			{
				// Properties
				sNfUcPzqbmfpkWQZGXbzVNvzIYo rQzQjzZPEBGirpUCdHIDZcYWbNF { get; }
				Controller jbVnEoSGijlOtsPVojcUnqQxqRw { get; }
				float AGsglnLOcnetMiOqoKNEaqYaDAlI { get; }
			}
	
			internal sealed class yuzjpKSgIlOzFrmYoCjvudWJHqg<TController, TMap> : uwILKJrQnvyPKXqkviwAHMwxglt // TypeDefIndex: 6761
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
				public class KvWmrlRvIDMhfmIzEoUOUFQtsIT : zPwANwSjcNWfOppJVpCEtGyMPGw // TypeDefIndex: 6762
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
				public KvWmrlRvIDMhfmIzEoUOUFQtsIT uDGNCWGQfmuhvDHBSxGtBouWbNb(int param_0000e25a);
				public KvWmrlRvIDMhfmIzEoUOUFQtsIT uDGNCWGQfmuhvDHBSxGtBouWbNb(TController param_0000e25b);
				public void oaKHEhKiCbesQaMGhlFggnhHCet(KvWmrlRvIDMhfmIzEoUOUFQtsIT param_0000e25c);
				public void RemoveController(int param_0000e25d);
				public void XwNcwiEaatgODGzkmSbKgFgCVEWa(TController param_0000e25e);
				public void RemoveAt(int param_0000e25f);
				public TController vHZICLYpyCcWjWVSNhoczOfMnCG(int param_0000e260);
				public bool Contains(int param_0000e261);
				public bool QiqTwdMaCeiulPEUZWQFMcDFHZHG(TController param_0000e262);
				public int IndexOf(int param_0000e263);
				public int ItDzbHMiIYGseDXjmhIUEkIaQew(TController param_0000e264);
				public int IndexOfTag(string param_0000e265);
				public void Clear();
				zPwANwSjcNWfOppJVpCEtGyMPGw Rewired.Player.ControllerHelper.IControllerSet.GetEntry(int param_0000e267);
				zPwANwSjcNWfOppJVpCEtGyMPGw Rewired.Player.ControllerHelper.IControllerSet.GetEntry(Controller param_0000e268);
				void Rewired.Player.ControllerHelper.IControllerSet.AddEntry(zPwANwSjcNWfOppJVpCEtGyMPGw param_0000e269);
				void Rewired.Player.ControllerHelper.IControllerSet.RemoveController(Controller param_0000e26a);
				Controller Rewired.Player.ControllerHelper.IControllerSet.GetController(int param_0000e26b);
				bool Rewired.Player.ControllerHelper.IControllerSet.Contains(Controller param_0000e26c);
				int Rewired.Player.ControllerHelper.IControllerSet.IndexOf(Controller param_0000e26d);
				Controller Rewired.Player.ControllerHelper.IControllerSet.GetControllerWithTag(string param_0000e26e);
			}
	
			internal class egXAAqgVCShQeuJnjIKIGPUQzKT // TypeDefIndex: 6763
			{
				// Fields
				public readonly int SHujHYUxHggDGFiBfPBtOLtZhMW; // 0x10
				private ControllerType[] qXozjOicCkZQWMdOnmdtBiFcfuy; // 0x18
				private uwILKJrQnvyPKXqkviwAHMwxglt[] DOGjWfNqXhJwrYMCygTRCsZHQkS; // 0x20
	
				// Constructors
				public egXAAqgVCShQeuJnjIKIGPUQzKT(int length); // 0x00000001811E4320-0x00000001811E43C0
	
				// Methods
				public uwILKJrQnvyPKXqkviwAHMwxglt VILyHUbxRbFBNVlpaPnEuRjNgLM(int param_0000e271); // 0x00000001811E42E0-0x00000001811E4320
				public ControllerType tGyhsBkxYMxCvfukQbFmUfQxatN(int param_0000e272); // 0x00000001811E4470-0x00000001811E44B0
				public uwILKJrQnvyPKXqkviwAHMwxglt HidcSjbKbECBzYyBnCtcFeYTQWme(ControllerType param_0000e274); // 0x00000001811E41E0-0x00000001811E42E0
				public void olCMPMvbEidtAtcrerbWKjnDXsq(int param_0000e275, ControllerType param_0000e276, uwILKJrQnvyPKXqkviwAHMwxglt param_0000e277); // 0x00000001811E43C0-0x00000001811E4470
			}
	
			private class jAchFPOUJqmmtMllCTHcROXwbLj // TypeDefIndex: 6764
			{
				// Fields
				private readonly List<KdfyLBQApCbzGOVOOAmpdQFMdzgU> hnpXymCoCCHPwqlDSIZkffYsKwxu; // 0x10
				private readonly Player yHWXapLnjMXUYBDESFaAUIdnziK; // 0x18
	
				// Nested types
				public class KdfyLBQApCbzGOVOOAmpdQFMdzgU // TypeDefIndex: 6765
				{
					// Fields
					public int ApclWZWATFcgBgxbNPQkMDQJKvCT; // 0x10
					public UqmUJOucnPAhoXhVuhvbmxKGsOH<JoystickMap> rQzQjzZPEBGirpUCdHIDZcYWbNF; // 0x18
					public float lFDHcXCTqlOntOoxLiXLgvQIJOsj; // 0x20
	
					// Constructors
					public KdfyLBQApCbzGOVOOAmpdQFMdzgU(int joystickId, UqmUJOucnPAhoXhVuhvbmxKGsOH<JoystickMap> mapSet, float lastConnectedTime); // 0x00000001811D3B80-0x00000001811D3C00
				}
	
				// Constructors
				public jAchFPOUJqmmtMllCTHcROXwbLj(Player player); // 0x00000001811E5DF0-0x00000001811E5E60
	
				// Methods
				public void lmldbkvCGcJRSRLClxvEdfwGeFAF(Joystick param_0000e279, UqmUJOucnPAhoXhVuhvbmxKGsOH<JoystickMap> param_0000e27a); // 0x00000001811E5E90-0x00000001811E60A0
				public void lmldbkvCGcJRSRLClxvEdfwGeFAF(yuzjpKSgIlOzFrmYoCjvudWJHqg.KvWmrlRvIDMhfmIzEoUOUFQtsIT<Joystick, JoystickMap> param_0000e27b); // 0x00000001811E5E60-0x00000001811E5E90
				public void rIBoFCqulfliDqgYQSDqUUlhTyk(); // 0x00000001811E60A0-0x00000001811E6230
				public KdfyLBQApCbzGOVOOAmpdQFMdzgU SJSWnEKwuoLTQVEoRbtWctEUXhl(int param_0000e27c); // 0x00000001811E5CB0-0x00000001811E5DF0
				public bool QiqTwdMaCeiulPEUZWQFMcDFHZHG(int param_0000e27d); // 0x00000001811E5BD0-0x00000001811E5CB0
				public int ItDzbHMiIYGseDXjmhIUEkIaQew(int param_0000e27e); // 0x00000001811E5AD0-0x00000001811E5BD0
				public void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x00000001811E6230-0x00000001811E6280
			}
	
			[Browsable] // 0x00000001801D4BF0-0x00000001801D4C30
			[EditorBrowsable] // 0x00000001801D4BF0-0x00000001801D4C30
			public sealed class MapHelper : CodeHelper // TypeDefIndex: 6766
			{
				// Fields
				private readonly VVLouGbEKulMPcFZiTUTqikUjEp uZAindJKwIucctNndiMpyAASdId; // 0x10
				private Player yHWXapLnjMXUYBDESFaAUIdnziK; // 0x18
				private ControllerHelper GsoDNwSmTlqXUxYxRnLUXMOoArhh; // 0x20
				private readonly ControllerMapEnabler mEPluSgrvSHStUTqLfvUfSdRIBD; // 0x28
				private readonly ControllerMapLayoutManager KKSdtRLTEfvlNthGKcGKiNRvdEEA; // 0x30
				private readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x38
	
				// Properties
				public ControllerMapLayoutManager layoutManager { get; } // 0x00000001803745C0-0x00000001803745D0 
				public ControllerMapEnabler mapEnabler { get; } // 0x00000001803745B0-0x00000001803745C0 
				public IList<InputBehavior> InputBehaviors { get; } // 0x000000018129B9E0-0x000000018129BAB0 
	
				// Nested types
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class PpjFLnskNUaFvgPSAsrBsQUnVOG : IEnumerable<ControllerMap>, IEnumerator<ControllerMap> // TypeDefIndex: 6767
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
					ControllerMap hcosEcMSQqfpybuxojowXuHfzvIU { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public PpjFLnskNUaFvgPSAsrBsQUnVOG(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerMap> IEnumerable<ControllerMap>.GetEnumerator(); // 0x00000001811DF690-0x00000001811DF770
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811DF690-0x00000001811DF770
					private bool MoveNext(); // 0x00000001811DF2F0-0x00000001811DF690
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811DF770-0x00000001811DF7C0
					void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class uDOWLiwoBWXsXQRCdxoiSQelQBI<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 6768
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
					T kdSuZhjZosqvqDiXRzmNfvdMwrh { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public uDOWLiwoBWXsXQRCdxoiSQelQBI(int <>1__state);
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<T> IEnumerable<T>.GetEnumerator();
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator();
					private bool MoveNext();
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset();
					void IDisposable.Dispose();
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class HuAAwsgQIqJtWQlWZgrSgaHIDhbO : IEnumerable<ControllerMap>, IEnumerator<ControllerMap> // TypeDefIndex: 6769
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
					ControllerMap hcosEcMSQqfpybuxojowXuHfzvIU { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public HuAAwsgQIqJtWQlWZgrSgaHIDhbO(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerMap> IEnumerable<ControllerMap>.GetEnumerator(); // 0x0000000181286310-0x0000000181286400
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181286310-0x0000000181286400
					private bool MoveNext(); // 0x0000000181286030-0x0000000181286310
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000181286400-0x0000000181286450
					void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class EJgQWVwFTpZqGDsRReAnPTQBApR : IEnumerable<ControllerMap>, IEnumerator<ControllerMap> // TypeDefIndex: 6770
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
					ControllerMap hcosEcMSQqfpybuxojowXuHfzvIU { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public EJgQWVwFTpZqGDsRReAnPTQBApR(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerMap> IEnumerable<ControllerMap>.GetEnumerator(); // 0x0000000181285EB0-0x0000000181285FE0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181285EB0-0x0000000181285FE0
					private bool MoveNext(); // 0x0000000181285AE0-0x0000000181285EB0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000181285FE0-0x0000000181286030
					void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class NNEtiJNjkQfzMVjmMfmJWhAhmxO<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 6771
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
					T kdSuZhjZosqvqDiXRzmNfvdMwrh { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public NNEtiJNjkQfzMVjmMfmJWhAhmxO(int <>1__state);
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<T> IEnumerable<T>.GetEnumerator();
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator();
					private bool MoveNext();
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset();
					void IDisposable.Dispose();
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class qsLwYlbXLKLMXzzlSdgFscZncBJ : IEnumerable<ControllerMap>, IEnumerator<ControllerMap> // TypeDefIndex: 6772
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
					ControllerMap hcosEcMSQqfpybuxojowXuHfzvIU { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public qsLwYlbXLKLMXzzlSdgFscZncBJ(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerMap> IEnumerable<ControllerMap>.GetEnumerator(); // 0x00000001811E8CB0-0x00000001811E8DB0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E8CB0-0x00000001811E8DB0
					private bool MoveNext(); // 0x00000001811E87A0-0x00000001811E8CB0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E8DB0-0x00000001811E8E00
					void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class wFLPuxxmtKMbqMAUJfaQMfkEapMJ : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6773
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
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public wFLPuxxmtKMbqMAUJfaQMfkEapMJ(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001811EC2D0-0x00000001811EC3D0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811EC2D0-0x00000001811EC3D0
					private bool MoveNext(); // 0x00000001811EBC90-0x00000001811EC1C0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811EC3D0-0x00000001811EC420
					void IDisposable.Dispose(); // 0x00000001811EC420-0x00000001811EC490
					private void SuDpvywRnkhZqGQDCrTkbWRlpbt(); // 0x00000001811EC1C0-0x00000001811EC2D0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class wAjumWVzHYdtszNmTTAxnCJrIUg : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6774
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
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public wAjumWVzHYdtszNmTTAxnCJrIUg(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001811EB970-0x00000001811EBAE0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811EB970-0x00000001811EBAE0
					private bool MoveNext(); // 0x00000001811EB420-0x00000001811EB970
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811EBAE0-0x00000001811EBB30
					void IDisposable.Dispose(); // 0x00000001811EBB30-0x00000001811EBBA0
					private void uYCbFxJgUPfIUiVCKDgjPfcnROFa(); // 0x00000001811EBBA0-0x00000001811EBC90
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class gfvNoukMzddCvglLpYruxjzhAxV : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6775
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
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public gfvNoukMzddCvglLpYruxjzhAxV(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001811E57E0-0x00000001811E58D0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E57E0-0x00000001811E58D0
					private bool MoveNext(); // 0x00000001811E52C0-0x00000001811E57E0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E58D0-0x00000001811E5920
					void IDisposable.Dispose(); // 0x00000001811E5920-0x00000001811E59D0
					private void jNCbkpEvKJlNgDwiftxpwhVvtvsb(); // 0x00000001811E59D0-0x00000001811E5AD0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class VQIEFeTtUHkPEVcCYHXPJbfRHQnJ : IEnumerable<ControllerMap>, IEnumerator<ControllerMap> // TypeDefIndex: 6776
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
					ControllerMap hcosEcMSQqfpybuxojowXuHfzvIU { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public VQIEFeTtUHkPEVcCYHXPJbfRHQnJ(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerMap> IEnumerable<ControllerMap>.GetEnumerator(); // 0x00000001811E1520-0x00000001811E1680
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E1520-0x00000001811E1680
					private bool MoveNext(); // 0x00000001811E10F0-0x00000001811E1520
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E1680-0x00000001811E16D0
					void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class AzcdhbVEpZvVURNXZcZsCGbsIni<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 6777
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
					T kdSuZhjZosqvqDiXRzmNfvdMwrh { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public AzcdhbVEpZvVURNXZcZsCGbsIni(int <>1__state);
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<T> IEnumerable<T>.GetEnumerator();
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator();
					private bool MoveNext();
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset();
					void IDisposable.Dispose();
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class uNzNaiXgPJRRtupkvIjXHfOQFVs : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6778
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
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public uNzNaiXgPJRRtupkvIjXHfOQFVs(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001811EA280-0x00000001811EA3F0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811EA280-0x00000001811EA3F0
					private bool MoveNext(); // 0x00000001811E9E10-0x00000001811EA280
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811EA3F0-0x00000001811EA440
					void IDisposable.Dispose(); // 0x00000001811EA440-0x00000001811EA4B0
					private void vjCmAiNjHwTktzZlmuuvOVWpAam(); // 0x00000001811EA4B0-0x00000001811EA5C0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class vhgkykkTQBwAcjiiKixzoviLeql : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6779
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
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public vhgkykkTQBwAcjiiKixzoviLeql(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001811EB190-0x00000001811EB2D0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811EB190-0x00000001811EB2D0
					private bool MoveNext(); // 0x00000001811EAC80-0x00000001811EB190
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811EB2D0-0x00000001811EB320
					void IDisposable.Dispose(); // 0x00000001811EB320-0x00000001811EB3D0
					private void cQwCABvOuQEbfdiuPfHjkbtxoxCR(); // 0x00000001811EB3D0-0x00000001811EB420
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class ekYMYIzNFvfNvriZWxLUNiLTiLH : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6780
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
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public ekYMYIzNFvfNvriZWxLUNiLTiLH(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001811E4970-0x00000001811E4A80
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E4970-0x00000001811E4A80
					private bool MoveNext(); // 0x00000001811E44B0-0x00000001811E4920
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E4A80-0x00000001811E4AD0
					void IDisposable.Dispose(); // 0x00000001811E4AD0-0x00000001811E4B80
					private void OJpgGMGcRQgnWxzbqhJNdoDgVTXL(); // 0x00000001811E4920-0x00000001811E4970
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class cAOpYMMifsDOzfJJHITxAOJHbOYk : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6781
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
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public cAOpYMMifsDOzfJJHITxAOJHbOYk(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001811E3F60-0x00000001811E4070
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E3F60-0x00000001811E4070
					private bool MoveNext(); // 0x00000001811E3A40-0x00000001811E3F60
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E4070-0x00000001811E40C0
					void IDisposable.Dispose(); // 0x00000001811E40C0-0x00000001811E4190
					private void vOCkLguFhcPfzjPXdZGRzfzmYxp(); // 0x00000001811E4190-0x00000001811E41E0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class SXaIYhzgPtQEtrfUreUeadbEUljR : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6782
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
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public SXaIYhzgPtQEtrfUreUeadbEUljR(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001811E05E0-0x00000001811E0710
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E05E0-0x00000001811E0710
					private bool MoveNext(); // 0x00000001811DFF30-0x00000001811E04D0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E0710-0x00000001811E0760
					void IDisposable.Dispose(); // 0x00000001811E0760-0x00000001811E07D0
					private void OyWIUVoGYxCZKrerbcwBmdgCYBC(); // 0x00000001811E04D0-0x00000001811E05E0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class sjOgsiJvvUKvJScVzqozNcvEizZA : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6783
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
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public sjOgsiJvvUKvJScVzqozNcvEizZA(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001811E9A80-0x00000001811E9C00
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E9A80-0x00000001811E9C00
					private bool MoveNext(); // 0x00000001811E9570-0x00000001811E9A80
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E9C00-0x00000001811E9C50
					void IDisposable.Dispose(); // 0x00000001811E9C50-0x00000001811E9D00
					private void nVMCFVFgBmyHorsZfTSmkMtpqOx(); // 0x00000001811E9D00-0x00000001811E9E10
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class DttafkbbGCWlpehfzhcGLhhkfCY : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6784
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
					ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public DttafkbbGCWlpehfzhcGLhhkfCY(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001812856D0-0x0000000181285830
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001812856D0-0x0000000181285830
					private bool MoveNext(); // 0x0000000181285200-0x00000001812856D0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000181285830-0x0000000181285880
					void IDisposable.Dispose(); // 0x0000000181285880-0x0000000181285970
					private void iBNEFvDxBNrecocohZJfaqBbbuod(); // 0x0000000181285970-0x0000000181285A90
					private void nfSyBxkKKDgwlZFLDGyFJULCDneE(); // 0x0000000181285A90-0x0000000181285AE0
				}
	
				// Constructors
				internal MapHelper(Player player, ControllerHelper parent, VVLouGbEKulMPcFZiTUTqikUjEp startingControllerMapInfo, ControllerMapLayoutManager.StartingSettings controllerMapLayoutManagerSettings, ControllerMapEnabler.ZgESyvoCZDaaWJMTaxFmFrlTHlVN controllerMapEnablerSettings); // 0x000000018129A650-0x000000018129A7C0
	
				// Methods
				public void LoadMap<T>(int controllerId, int categoryId, int layoutId)
					where T : ControllerMap;
				public void LoadMap<T>(int controllerId, string categoryName, string layoutName)
					where T : ControllerMap;
				public void LoadMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId); // 0x00000001812944F0-0x0000000181294520
				public void LoadMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName); // 0x0000000181294520-0x0000000181294550
				public void LoadMap<T>(int controllerId, int categoryId, int layoutId, bool startEnabled)
					where T : ControllerMap;
				public void LoadMap<T>(int controllerId, string categoryName, string layoutName, bool startEnabled)
					where T : ControllerMap;
				public void LoadMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId, bool startEnabled); // 0x0000000181294590-0x00000001812945D0
				public void LoadMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName, bool startEnabled); // 0x0000000181294550-0x0000000181294590
				private void lzRURLodCXjlaMATvFEbJFSRQAus<T>(int param_0000e2a7, int param_0000e2a8, int param_0000e2a9, BoolOption param_0000e2aa)
					where T : ControllerMap;
				private void lzRURLodCXjlaMATvFEbJFSRQAus<T>(int param_0000e2ab, string param_0000e2ac, string param_0000e2ad, BoolOption param_0000e2ae)
					where T : ControllerMap;
				private void lzRURLodCXjlaMATvFEbJFSRQAus(ControllerType param_0000e2af, int param_0000e2b0, int param_0000e2b1, int param_0000e2b2, BoolOption param_0000e2b3); // 0x000000018129CCB0-0x000000018129CD90
				private void lzRURLodCXjlaMATvFEbJFSRQAus(ControllerType param_0000e2b4, int param_0000e2b5, string param_0000e2b6, string param_0000e2b7, BoolOption param_0000e2b8); // 0x000000018129CBA0-0x000000018129CCB0
				public IEnumerable<ControllerMap> GetAllMaps(); // 0x000000018128D2B0-0x000000018128D320
				public int GetAllMaps(List<ControllerMap> results); // 0x000000018128CE70-0x000000018128D2B0
				public IEnumerable<T> GetAllMaps<T>()
					where T : ControllerMap;
				public int GetAllMaps<T>(List<T> results)
					where T : ControllerMap;
				public IEnumerable<ControllerMap> GetAllMaps(ControllerType controllerType); // 0x000000018128D740-0x000000018128D7F0
				public int GetAllMaps(ControllerType controllerType, List<ControllerMap> results); // 0x000000018128D320-0x000000018128D740
				public IEnumerable<ControllerMap> GetAllMapsInCategory(string categoryName); // 0x000000018128C9E0-0x000000018128CBA0
				public IEnumerable<ControllerMap> GetAllMapsInCategory(int categoryId); // 0x000000018128BE60-0x000000018128BF10
				public IEnumerable<T> GetAllMapsInCategory<T>(string categoryName)
					where T : ControllerMap;
				public IEnumerable<T> GetAllMapsInCategory<T>(int categoryId)
					where T : ControllerMap;
				public IEnumerable<ControllerMap> GetAllMapsInCategory(string categoryName, ControllerType controllerType); // 0x000000018128C3E0-0x000000018128C5B0
				public IEnumerable<ControllerMap> GetAllMapsInCategory(int categoryId, ControllerType controllerType); // 0x000000018128CBA0-0x000000018128CC60
				public int GetAllMapsInCategory(string categoryName, List<ControllerMap> results); // 0x000000018128CD70-0x000000018128CE70
				public int GetAllMapsInCategory(int categoryId, List<ControllerMap> results); // 0x000000018128BF10-0x000000018128C3E0
				public int GetAllMapsInCategory<T>(string categoryName, List<T> results)
					where T : ControllerMap;
				public int GetAllMapsInCategory<T>(int categoryId, List<T> results)
					where T : ControllerMap;
				public int GetAllMapsInCategory(string categoryName, ControllerType controllerType, List<ControllerMap> results); // 0x000000018128CC60-0x000000018128CD70
				public int GetAllMapsInCategory(int categoryId, ControllerType controllerType, List<ControllerMap> results); // 0x000000018128C5B0-0x000000018128C9E0
				public IList<T> GetMaps<T>(int controllerId)
					where T : ControllerMap;
				public IList<ControllerMap> GetMaps(ControllerType controllerType, int controllerId); // 0x0000000181293C40-0x0000000181293D10
				public IList<ControllerMap> GetMaps(Controller controller); // 0x0000000181293D10-0x0000000181293E90
				public IEnumerable<ControllerMap> GetMapsInCategory(ControllerType controllerType, int controllerId, int categoryId); // 0x0000000181293830-0x00000001812939D0
				public IEnumerable<ControllerMap> GetMapsInCategory(ControllerType controllerType, int controllerId, string categoryName); // 0x00000001812939D0-0x0000000181293B20
				public IEnumerable<ControllerMap> GetMapsInCategory(Controller controller, int categoryId); // 0x0000000181293630-0x0000000181293710
				public IEnumerable<ControllerMap> GetMapsInCategory(Controller controller, string categoryName); // 0x0000000181293710-0x0000000181293830
				public int GetMapsInCategory(ControllerType controllerType, int controllerId, int categoryId, List<ControllerMap> results); // 0x0000000181293170-0x00000001812933C0
				public int GetMapsInCategory(ControllerType controllerType, int controllerId, string categoryName, List<ControllerMap> results); // 0x0000000181293500-0x0000000181293630
				public int GetMapsInCategory(Controller controller, int categoryId, List<ControllerMap> results); // 0x0000000181293B20-0x0000000181293C40
				public int GetMapsInCategory(Controller controller, string categoryName, List<ControllerMap> results); // 0x00000001812933C0-0x0000000181293500
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
				public ControllerMap GetMap(int mapId); // 0x0000000181292600-0x0000000181292A20
				public ControllerMap GetMap(ControllerType controllerType, int controllerId, int mapId); // 0x0000000181292A20-0x0000000181292B00
				public ControllerMap GetMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId); // 0x0000000181292D50-0x0000000181292E40
				public ControllerMap GetMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName); // 0x0000000181292C70-0x0000000181292D50
				public ControllerMap GetMap(Controller controller, int mapId); // 0x0000000181292E40-0x0000000181292FB0
				public ControllerMap GetMap(Controller controller, int categoryId, int layoutId); // 0x0000000181292B00-0x0000000181292C70
				public ControllerMap GetMap(Controller controller, string categoryName, string layoutName); // 0x0000000181292FB0-0x0000000181293170
				public T GetFirstMapInCategory<T>(int controllerId, string categoryName)
					where T : ControllerMap;
				public T GetFirstMapInCategory<T>(int controllerId, int categoryId)
					where T : ControllerMap;
				public ControllerMap GetFirstMapInCategory(ControllerType controllerType, int controllerId, string categoryName); // 0x0000000181292030-0x0000000181292180
				public ControllerMap GetFirstMapInCategory(ControllerType controllerType, int controllerId, int categoryId); // 0x0000000181292180-0x0000000181292280
				public ControllerMap GetFirstMapInCategory(Controller controller, string categoryName); // 0x0000000181291E20-0x0000000181292030
				public ControllerMap GetFirstMapInCategory(Controller controller, int categoryId); // 0x0000000181292280-0x0000000181292360
				public void AddMap<T>(int controllerId, ControllerMap map)
					where T : ControllerMap;
				public void AddMap(Controller controller, ControllerMap map); // 0x0000000181286BD0-0x0000000181286CD0
				public void AddMap(ControllerType controllerType, int controllerId, ControllerMap map); // 0x0000000181286EC0-0x0000000181286FA0
				public void AddMap<T>(int controllerId, ControllerMap map, bool startEnabled)
					where T : ControllerMap;
				public void AddMap(Controller controller, ControllerMap map, bool startEnabled); // 0x0000000181286CD0-0x0000000181286DD0
				public void AddMap(ControllerType controllerType, int controllerId, ControllerMap map, bool startEnabled); // 0x0000000181286DD0-0x0000000181286EC0
				public bool AddMapFromXml<T>(int controllerId, string xmlString)
					where T : ControllerMap;
				public bool AddMapFromXml(ControllerType controllerType, int controllerId, string xmlString); // 0x0000000181286AF0-0x0000000181286BD0
				public int AddMapsFromXml<T>(int controllerId, List<string> xmlStrings)
					where T : ControllerMap;
				public int AddMapsFromXml(ControllerType controllerType, int controllerId, List<string> xmlStrings); // 0x00000001812871D0-0x0000000181287440
				public bool AddMapFromJson<T>(int controllerId, string jsonString)
					where T : ControllerMap;
				public bool AddMapFromJson(ControllerType controllerType, int controllerId, string jsonString); // 0x00000001812869F0-0x0000000181286AF0
				public int AddMapsFromJson<T>(int controllerId, List<string> jsonStrings)
					where T : ControllerMap;
				public int AddMapsFromJson(ControllerType controllerType, int controllerId, List<string> jsonStrings); // 0x0000000181286FA0-0x00000001812871D0
				public void AddEmptyMap<T>(int controllerId, int categoryId, int layoutId)
					where T : ControllerMap;
				public void AddEmptyMap<T>(int controllerId, string categoryName, string layoutName)
					where T : ControllerMap;
				public void AddEmptyMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId); // 0x0000000181286910-0x00000001812869F0
				public void AddEmptyMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName); // 0x0000000181286770-0x0000000181286910
				public void RemoveMap<T>(int controllerId, int mapId)
					where T : ControllerMap;
				public void RemoveMap<T>(int controllerId, int categoryId, int layoutId)
					where T : ControllerMap;
				public void RemoveMap<T>(int controllerId, string categoryName, string layoutName)
					where T : ControllerMap;
				public void RemoveMap(ControllerType controllerType, int controllerId, int mapId); // 0x0000000181296810-0x00000001812968F0
				public void RemoveMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId); // 0x00000001812965F0-0x0000000181296730
				public void RemoveMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName); // 0x0000000181296730-0x0000000181296810
				public void ClearMaps<T>(bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMaps(ControllerType controllerType, bool userAssignableOnly); // 0x000000018128A1E0-0x000000018128A570
				public void ClearMapsInCategory<T>(int categoryId, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsInCategory<T>(string categoryName, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsInCategory<T>(int categoryId, int layoutId, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsInCategory<T>(string categoryName, string layoutName, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsInCategory(int categoryId, bool userAssignableOnly); // 0x0000000181289400-0x0000000181289800
				public void ClearMapsInCategory(string categoryName, bool userAssignableOnly); // 0x0000000181289970-0x0000000181289AA0
				public void ClearMapsInCategory(ControllerType controllerType, int categoryId, bool userAssignableOnly); // 0x0000000181288F70-0x0000000181289160
				public void ClearMapsInCategory(ControllerType controllerType, string categoryName, bool userAssignableOnly); // 0x0000000181289160-0x0000000181289400
				public void ClearMapsInCategory(ControllerType controllerType, int categoryId, int layoutId, bool userAssignableOnly); // 0x0000000181289AA0-0x0000000181289EA0
				public void ClearMapsInCategory(ControllerType controllerType, string categoryName, string layoutName, bool userAssignableOnly); // 0x0000000181289800-0x0000000181289970
				public void ClearMapsInLayout<T>(int layoutId, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsInLayout<T>(string layoutName, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsInLayout(ControllerType controllerType, int layoutId, bool userAssignableOnly); // 0x0000000181289FB0-0x000000018128A1E0
				public void ClearMapsInLayout(ControllerType controllerType, string layoutName, bool userAssignableOnly); // 0x0000000181289EA0-0x0000000181289FB0
				public void ClearMapsForController<T>(int controllerId, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsForController<T>(int controllerId, int categoryId, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsForController<T>(int controllerId, string categoryName, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsForController(ControllerType controllerType, int controllerId, bool userAssignableOnly); // 0x0000000181288C40-0x0000000181288DF0
				public void ClearMapsForController(ControllerType controllerType, int controllerId, int categoryId, bool userAssignableOnly); // 0x0000000181288DF0-0x0000000181288F70
				public void ClearMapsForController(ControllerType controllerType, int controllerId, string categoryName, bool userAssignableOnly); // 0x0000000181288AF0-0x0000000181288C40
				public void ClearMapsForControllerInLayout<T>(int controllerId, int layoutId, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsForControllerInLayout<T>(int controllerId, string layoutName, bool userAssignableOnly)
					where T : ControllerMap;
				public void ClearMapsForControllerInLayout(ControllerType controllerType, int controllerId, int layoutId, bool userAssignableOnly); // 0x00000001812888B0-0x0000000181288AF0
				public void ClearMapsForControllerInLayout(ControllerType controllerType, int controllerId, string layoutName, bool userAssignableOnly); // 0x0000000181288750-0x00000001812888B0
				public void ClearAllMaps(bool userAssignableOnly); // 0x0000000181288620-0x0000000181288750
				public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps); // 0x0000000181290450-0x0000000181290500
				public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps); // 0x0000000181290500-0x0000000181290670
				public ActionElementMap GetFirstButtonMapWithAction(Controller controller, int actionId, bool skipDisabledMaps); // 0x0000000181290670-0x0000000181290760
				public ActionElementMap GetFirstButtonMapWithAction(Controller controller, string actionName, bool skipDisabledMaps); // 0x0000000181290760-0x0000000181290880
				public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps); // 0x0000000181290C40-0x0000000181290D20
				public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps); // 0x0000000181290AD0-0x0000000181290C40
				public ActionElementMap GetFirstButtonMapWithAction(int actionId, bool skipDisabledMaps); // 0x00000001812902D0-0x0000000181290450
				public ActionElementMap GetFirstButtonMapWithAction(string actionName, bool skipDisabledMaps); // 0x0000000181290880-0x0000000181290AD0
				public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps); // 0x00000001812881B0-0x0000000181288260
				public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps); // 0x0000000181287CD0-0x0000000181287E50
				public IEnumerable<ActionElementMap> ButtonMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps); // 0x0000000181288340-0x0000000181288430
				public IEnumerable<ActionElementMap> ButtonMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps); // 0x0000000181287E50-0x0000000181287F70
				public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps); // 0x0000000181288260-0x0000000181288340
				public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps); // 0x0000000181288430-0x0000000181288620
				public IEnumerable<ActionElementMap> ButtonMapsWithAction(int actionId, bool skipDisabledMaps); // 0x00000001812880F0-0x00000001812881B0
				public IEnumerable<ActionElementMap> ButtonMapsWithAction(string actionName, bool skipDisabledMaps); // 0x0000000181287F70-0x00000001812880F0
				public int GetButtonMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128E100-0x000000018128E1C0
				public int GetButtonMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128E810-0x000000018128E990
				public int GetButtonMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128E3D0-0x000000018128E540
				public int GetButtonMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128E540-0x000000018128E660
				public int GetButtonMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128E1C0-0x000000018128E2B0
				public int GetButtonMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128E660-0x000000018128E810
				public int GetButtonMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128E0E0-0x000000018128E100
				public int GetButtonMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128E2B0-0x000000018128E3D0
				public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps); // 0x000000018128F940-0x000000018128F9F0
				public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps); // 0x000000018128FB70-0x000000018128FCE0
				public ActionElementMap GetFirstAxisMapWithAction(Controller controller, int actionId, bool skipDisabledMaps); // 0x00000001812901C0-0x00000001812902D0
				public ActionElementMap GetFirstAxisMapWithAction(Controller controller, string actionName, bool skipDisabledMaps); // 0x000000018128FCE0-0x000000018128FE00
				public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps); // 0x000000018128F860-0x000000018128F940
				public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps); // 0x000000018128FE00-0x000000018128FF70
				public ActionElementMap GetFirstAxisMapWithAction(int actionId, bool skipDisabledMaps); // 0x000000018128F9F0-0x000000018128FB70
				public ActionElementMap GetFirstAxisMapWithAction(string actionName, bool skipDisabledMaps); // 0x000000018128FF70-0x00000001812901C0
				public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps); // 0x00000001812878A0-0x0000000181287950
				public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps); // 0x00000001812875A0-0x0000000181287720
				public IEnumerable<ActionElementMap> AxisMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps); // 0x0000000181287A70-0x0000000181287B60
				public IEnumerable<ActionElementMap> AxisMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps); // 0x0000000181287950-0x0000000181287A70
				public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps); // 0x0000000181287BF0-0x0000000181287CD0
				public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps); // 0x0000000181287720-0x00000001812878A0
				public IEnumerable<ActionElementMap> AxisMapsWithAction(int actionId, bool skipDisabledMaps); // 0x0000000181287B60-0x0000000181287BF0
				public IEnumerable<ActionElementMap> AxisMapsWithAction(string actionName, bool skipDisabledMaps); // 0x0000000181287440-0x00000001812875A0
				public int GetAxisMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128DAE0-0x000000018128DBA0
				public int GetAxisMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128D910-0x000000018128DAC0
				public int GetAxisMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128DEC0-0x000000018128DFC0
				public int GetAxisMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128DBA0-0x000000018128DCE0
				public int GetAxisMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128D7F0-0x000000018128D910
				public int GetAxisMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128DCE0-0x000000018128DEC0
				public int GetAxisMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128DAC0-0x000000018128DAE0
				public int GetAxisMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128DFC0-0x000000018128E0E0
				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps); // 0x0000000181290D20-0x0000000181290DD0
				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps); // 0x00000001812915E0-0x0000000181291750
				public ActionElementMap GetFirstElementMapWithAction(Controller controller, int actionId, bool skipDisabledMaps); // 0x0000000181290DD0-0x0000000181290EC0
				public ActionElementMap GetFirstElementMapWithAction(Controller controller, string actionName, bool skipDisabledMaps); // 0x00000001812914C0-0x00000001812915E0
				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps); // 0x0000000181291750-0x0000000181291850
				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps); // 0x0000000181290EC0-0x0000000181291080
				public ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps); // 0x0000000181291080-0x0000000181291240
				public ActionElementMap GetFirstElementMapWithAction(string actionName, bool skipDisabledMaps); // 0x0000000181291240-0x00000001812914C0
				public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps); // 0x000000018128B160-0x000000018128B210
				public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps); // 0x000000018128B2F0-0x000000018128B470
				public IEnumerable<ActionElementMap> ElementMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps); // 0x000000018128AFC0-0x000000018128B0D0
				public IEnumerable<ActionElementMap> ElementMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps); // 0x000000018128AEA0-0x000000018128AFC0
				public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps); // 0x000000018128B210-0x000000018128B2F0
				public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps); // 0x000000018128B470-0x000000018128B5F0
				public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId, bool skipDisabledMaps); // 0x000000018128B0D0-0x000000018128B160
				public IEnumerable<ActionElementMap> ElementMapsWithAction(string actionName, bool skipDisabledMaps); // 0x000000018128AD40-0x000000018128AEA0
				public int GetElementMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128F1B0-0x000000018128F270
				public int GetElementMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128EF20-0x000000018128F0A0
				public int GetElementMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128E990-0x000000018128EA90
				public int GetElementMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128EC00-0x000000018128ED20
				public int GetElementMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128F0C0-0x000000018128F1B0
				public int GetElementMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128ED20-0x000000018128EF20
				public int GetElementMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128F0A0-0x000000018128F0C0
				public int GetElementMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128EA90-0x000000018128EC00
				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps); // 0x000000018128B5F0-0x000000018128B6F0
				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps); // 0x000000018128B820-0x000000018128B850
				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps); // 0x000000018128B6F0-0x000000018128B820
				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps); // 0x000000018128B880-0x000000018128BA90
				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps); // 0x000000018128B850-0x000000018128B880
				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps); // 0x000000018128BA90-0x000000018128BB50
				public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps); // 0x0000000181291AA0-0x0000000181291BD0
				public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps); // 0x0000000181291850-0x0000000181291880
				public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps); // 0x0000000181291BD0-0x0000000181291D00
				public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps); // 0x00000001812918B0-0x0000000181291AA0
				public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps); // 0x0000000181291880-0x00000001812918B0
				public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps); // 0x0000000181291D00-0x0000000181291E20
				public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128F5F0-0x000000018128F700
				public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128F830-0x000000018128F860
				public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128F4C0-0x000000018128F5F0
				public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128F2B0-0x000000018128F4C0
				public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128F270-0x000000018128F2B0
				public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x000000018128F700-0x000000018128F830
				public T[] GetMapSaveData<T>(int controllerId, bool userAssignableMapsOnly)
					where T : ControllerMapSaveData;
				public ControllerMapSaveData[] GetMapSaveData(ControllerType controllerType, int controllerId, bool userAssignableMapsOnly); // 0x0000000181292520-0x0000000181292600
				public T[] GetAllMapSaveData<T>(bool userAssignableMapsOnly)
					where T : ControllerMapSaveData;
				public ControllerMapSaveData[] GetAllMapSaveData(ControllerType controllerType, bool userAssignableMapsOnly); // 0x000000018128BC30-0x000000018128BD00
				public ControllerMapSaveData[] GetAllMapSaveData(bool userAssignableMapsOnly); // 0x000000018128BD00-0x000000018128BE60
				public int SetAllMapsEnabled(bool state); // 0x0000000181296D20-0x0000000181297120
				public int SetAllMapsEnabled(bool state, ControllerType controllerType); // 0x0000000181297270-0x0000000181297590
				public int SetAllMapsEnabled(bool state, Controller controller); // 0x0000000181297590-0x0000000181297770
				public int SetAllMapsEnabled(bool state, ControllerType controllerType, int controllerId); // 0x0000000181297120-0x0000000181297270
				public int SetMapsEnabled(bool state, int categoryId); // 0x0000000181297B90-0x0000000181297F80
				public int SetMapsEnabled(bool state, string categoryName); // 0x0000000181298D30-0x0000000181298E30
				public int SetMapsEnabled(bool state, string categoryName, string layoutName); // 0x0000000181297940-0x0000000181297B90
				public int SetMapsEnabled(bool state, ControllerType controllerType, int categoryId); // 0x00000001812987C0-0x0000000181298AD0
				public int SetMapsEnabled(bool state, ControllerType controllerType, string categoryName); // 0x00000001812982D0-0x00000001812983E0
				public int SetMapsEnabled(bool state, ControllerType controllerType, int categoryId, int layoutId); // 0x00000001812983E0-0x00000001812987C0
				public int SetMapsEnabled(bool state, ControllerType controllerType, string categoryName, string layoutName); // 0x0000000181297F80-0x0000000181298130
				public int SetMapsEnabled(bool state, Controller controller, int categoryId); // 0x0000000181298130-0x00000001812982D0
				public int SetMapsEnabled(bool state, Controller controller, int categoryId, int layoutId); // 0x0000000181297770-0x0000000181297940
				public int SetMapsEnabled(bool state, Controller controller, string categoryName); // 0x0000000181298AD0-0x0000000181298D30
				public int SetMapsEnabled(bool state, Controller controller, string categoryName, string layoutName); // 0x0000000181298E30-0x0000000181299100
				public void LoadDefaultMaps(ControllerType controllerType); // 0x0000000181294340-0x00000001812944F0
				public bool ContainsMapInCategory(InputMapCategory category); // 0x000000018128A940-0x000000018128AA00
				public bool ContainsMapInCategory(int categoryId); // 0x000000018128A5C0-0x000000018128A850
				public bool ContainsMapInCategory(string categoryName); // 0x000000018128A850-0x000000018128A940
				public bool ContainsMapInCategory(ControllerType controllerType, int categoryId); // 0x000000018128AA00-0x000000018128AD40
				public InputBehavior GetInputBehavior(int behaviorId); // 0x0000000181292360-0x0000000181292440
				public InputBehavior GetInputBehavior(string behaviorName); // 0x0000000181292440-0x0000000181292520
				internal void ItdhavHGXcUkAhyjaCFbIXENJheh(); // 0x0000000181293E90-0x0000000181293ED0
				internal void ljuzyhLOykfHUNqpupeYHHYVVUa(bool param_0000e517); // 0x000000018129C130-0x000000018129C910
				internal void NHvEbWUrKnQLGxXIuzllGPcMtQ(bool param_0000e518); // 0x0000000181294E60-0x00000001812954C0
				internal void SlISPtLfLQFUPagROOqtyucSdRl(bool param_0000e519); // 0x0000000181299100-0x0000000181299650
				internal void zAYHkHeBUioXAywUbyMjEbgDqMXE(bool param_0000e51a); // 0x00000001812A05A0-0x00000001812A0E50
				private uwILKJrQnvyPKXqkviwAHMwxglt hxOOzhfeazOtLJWADoJhQgiGlzs<T>()
					where T : ControllerMap;
				internal UqmUJOucnPAhoXhVuhvbmxKGsOH<JoystickMap> OjIHCxhPqXjtJWjGkbWIODpinHE(Joystick param_0000e51b, bool param_0000e51c); // 0x00000001812954C0-0x0000000181295840
				private void kpLbpdIVdpCOPCuotjOTQDWMlps(Joystick param_0000e51d, UqmUJOucnPAhoXhVuhvbmxKGsOH<JoystickMap> param_0000e51e, VazWCJszjSvmMxSvRJnnBczpVoI param_0000e51f, bool param_0000e520); // 0x000000018129BF00-0x000000018129C130
				internal UqmUJOucnPAhoXhVuhvbmxKGsOH<CustomControllerMap> VJVfCBZpPxtAMcwrGcyftqeWpph(CustomController param_0000e521, bool param_0000e522); // 0x0000000181299C80-0x000000018129A0A0
				private void cvcNRPlBVHsHAXnqfBvnJlkrtaA(CustomController param_0000e523, UqmUJOucnPAhoXhVuhvbmxKGsOH<CustomControllerMap> param_0000e524, VazWCJszjSvmMxSvRJnnBczpVoI param_0000e525, bool param_0000e526); // 0x000000018129B120-0x000000018129B3A0
				internal void CmxbnCZUDHhLTtrfUROfRgOsrHY(Controller param_0000e527, ControllerMap param_0000e528); // 0x000000018128A570-0x000000018128A5C0
				private IList<T> yWZVEngpJTrWcIAabCcjjehlxsBj<T>(int param_0000e529)
					where T : ControllerMap;
				private IList<T> yWZVEngpJTrWcIAabCcjjehlxsBj<T>(Controller param_0000e52a)
					where T : ControllerMap;
				private IList<ControllerMap> yWZVEngpJTrWcIAabCcjjehlxsBj(ControllerType param_0000e52b, int param_0000e52c); // 0x00000001812A0490-0x00000001812A05A0
				private IList<ControllerMap> yWZVEngpJTrWcIAabCcjjehlxsBj(Controller param_0000e52d); // 0x00000001812A0450-0x00000001812A0490
				private void azHszTgePDPkBJLxcubKkYACbrS(ControllerType param_0000e52e, int param_0000e52f, int param_0000e530, int param_0000e531); // 0x000000018129B0F0-0x000000018129B120
				private void azHszTgePDPkBJLxcubKkYACbrS(Controller param_0000e532, int param_0000e533, int param_0000e534); // 0x000000018129AC30-0x000000018129ACA0
				private void azHszTgePDPkBJLxcubKkYACbrS(ControllerType param_0000e535, int param_0000e536, string param_0000e537, string param_0000e538); // 0x000000018129AF00-0x000000018129AF30
				private void azHszTgePDPkBJLxcubKkYACbrS(Controller param_0000e539, string param_0000e53a, string param_0000e53b); // 0x000000018129ADA0-0x000000018129AE10
				private void azHszTgePDPkBJLxcubKkYACbrS(ControllerType param_0000e53c, int param_0000e53d, int param_0000e53e, int param_0000e53f, BoolOption param_0000e540); // 0x000000018129AF30-0x000000018129B0F0
				private void azHszTgePDPkBJLxcubKkYACbrS(Controller param_0000e541, int param_0000e542, int param_0000e543, BoolOption param_0000e544); // 0x000000018129ACA0-0x000000018129AD20
				private void azHszTgePDPkBJLxcubKkYACbrS(ControllerType param_0000e545, int param_0000e546, string param_0000e547, string param_0000e548, BoolOption param_0000e549); // 0x000000018129AE10-0x000000018129AF00
				private void azHszTgePDPkBJLxcubKkYACbrS(Controller param_0000e54a, string param_0000e54b, string param_0000e54c, BoolOption param_0000e54d); // 0x000000018129AD20-0x000000018129ADA0
				private void nRpfYcSMpjzNOMaRrgWhxbaFFow(Controller param_0000e54e, ControllerMap param_0000e54f, BoolOption param_0000e550); // 0x000000018129CE40-0x000000018129D100
				private void nRpfYcSMpjzNOMaRrgWhxbaFFow(ControllerType param_0000e551, int param_0000e552, ControllerMap param_0000e553, BoolOption param_0000e554); // 0x000000018129CD90-0x000000018129CE40
				private bool gCUvtoINFiRJKWCKAiyXBKgcwCw(ControllerType param_0000e555, int param_0000e556, string param_0000e557); // 0x000000018129B860-0x000000018129B9E0
				private int McaTJhbNDEhUXOYSYjSfoXlxXsD(ControllerType param_0000e558, int param_0000e559, List<string> param_0000e55a); // 0x00000001812945D0-0x0000000181294810
				private bool lmastpkegqvXgzyngLJdWbYQovD(ControllerType param_0000e55b, int param_0000e55c, string param_0000e55d); // 0x000000018129C910-0x000000018129CBA0
				private int QeUGCFVLdpkvKuroBITzfcEEQaU(ControllerType param_0000e55e, int param_0000e55f, List<string> param_0000e560); // 0x0000000181296420-0x00000001812965F0
				private void SWSIQZFYSQLALpiqLfqjsjCanYk(ControllerType param_0000e561, int param_0000e562, int param_0000e563, int param_0000e564); // 0x0000000181296960-0x0000000181296AF0
				private void SWSIQZFYSQLALpiqLfqjsjCanYk(Controller param_0000e565, int param_0000e566, int param_0000e567); // 0x00000001812968F0-0x0000000181296960
				private void SWSIQZFYSQLALpiqLfqjsjCanYk(ControllerType param_0000e568, int param_0000e569, string param_0000e56a, string param_0000e56b); // 0x0000000181296C10-0x0000000181296D20
				private void SWSIQZFYSQLALpiqLfqjsjCanYk(Controller param_0000e56c, string param_0000e56d, string param_0000e56e); // 0x0000000181296AF0-0x0000000181296C10
				private void wdXBtZaFNKlhBUmtaHeXouumymuU(ControllerType param_0000e56f, int param_0000e570, int param_0000e571); // 0x000000018129F500-0x000000018129F780
				private void wdXBtZaFNKlhBUmtaHeXouumymuU(Controller param_0000e572, int param_0000e573); // 0x000000018129FBB0-0x000000018129FC10
				private void wdXBtZaFNKlhBUmtaHeXouumymuU(ControllerType param_0000e574, int param_0000e575, ControllerMap param_0000e576); // 0x000000018129F9D0-0x000000018129FB40
				private void wdXBtZaFNKlhBUmtaHeXouumymuU(Controller param_0000e577, ControllerMap param_0000e578); // 0x000000018129FDC0-0x000000018129FE40
				private void wdXBtZaFNKlhBUmtaHeXouumymuU(ControllerType param_0000e579, int param_0000e57a, int param_0000e57b, int param_0000e57c); // 0x000000018129FC10-0x000000018129FDC0
				private void wdXBtZaFNKlhBUmtaHeXouumymuU(Controller param_0000e57d, int param_0000e57e, int param_0000e57f); // 0x000000018129FB40-0x000000018129FBB0
				private void wdXBtZaFNKlhBUmtaHeXouumymuU(ControllerType param_0000e580, int param_0000e581, string param_0000e582, string param_0000e583); // 0x000000018129F780-0x000000018129F9D0
				private void wdXBtZaFNKlhBUmtaHeXouumymuU(Controller param_0000e584, string param_0000e585, string param_0000e586); // 0x000000018129FE40-0x000000018129FEB0
				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(ControllerType param_0000e587, int param_0000e588, int param_0000e589); // 0x000000018129F0D0-0x000000018129F1E0
				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(Controller param_0000e58a, int param_0000e58b); // 0x000000018129F3C0-0x000000018129F420
				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(ControllerType param_0000e58c, int param_0000e58d, int param_0000e58e, int param_0000e58f); // 0x000000018129F1E0-0x000000018129F3C0
				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(Controller param_0000e590, int param_0000e591, int param_0000e592); // 0x000000018129F420-0x000000018129F490
				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(ControllerType param_0000e593, int param_0000e594, string param_0000e595, string param_0000e596); // 0x000000018129EFF0-0x000000018129F0D0
				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(Controller param_0000e597, string param_0000e598, string param_0000e599); // 0x000000018129F490-0x000000018129F500
				private ControllerMap uydcTkSsveNrDWhdfejCzhPijCK(ControllerType param_0000e59a, int param_0000e59b, int param_0000e59c); // 0x000000018129EE80-0x000000018129EF90
				private ControllerMap uydcTkSsveNrDWhdfejCzhPijCK(Controller param_0000e59d, int param_0000e59e); // 0x000000018129EF90-0x000000018129EFF0
				private ControllerMap uydcTkSsveNrDWhdfejCzhPijCK(ControllerType param_0000e59f, int param_0000e5a0, string param_0000e5a1); // 0x000000018129EC60-0x000000018129ED60
				private ControllerMap uydcTkSsveNrDWhdfejCzhPijCK(Controller param_0000e5a2, string param_0000e5a3); // 0x000000018129ED60-0x000000018129EE80
				private ControllerMap[] MsRJVqmqJMIZqczuwuGRjMnFXPNf(ControllerType param_0000e5a4); // 0x0000000181294810-0x0000000181294E60
				private ControllerMapSaveData[] UxlfCZTeJutCpoKfgKKpmMIRjUX(ControllerType param_0000e5a5, int param_0000e5a6, bool param_0000e5a7); // 0x0000000181299650-0x0000000181299C80
				private T[] UxlfCZTeJutCpoKfgKKpmMIRjUX<T>(int param_0000e5a8, bool param_0000e5a9)
					where T : ControllerMapSaveData;
				private ControllerMapSaveData[] WepHTJHYyuxCQWQDKcGkMoxbloqK(ControllerType param_0000e5aa, bool param_0000e5ab); // 0x000000018129A360-0x000000018129A650
				private T[] WepHTJHYyuxCQWQDKcGkMoxbloqK<T>(bool param_0000e5ac)
					where T : ControllerMapSaveData;
				private int tMiAgVhCKUhHOdiwAySOMpxktsU(ControllerType param_0000e5ad, int param_0000e5ae, int param_0000e5af, List<ControllerMap> param_0000e5b0); // 0x000000018129EB40-0x000000018129EC60
				private int tMiAgVhCKUhHOdiwAySOMpxktsU(Controller param_0000e5b1, int param_0000e5b2, List<ControllerMap> param_0000e5b3); // 0x000000018129EAD0-0x000000018129EB40
				private int tMiAgVhCKUhHOdiwAySOMpxktsU(ControllerType param_0000e5b4, int param_0000e5b5, string param_0000e5b6, List<ControllerMap> param_0000e5b7); // 0x000000018129E9C0-0x000000018129EAD0
				private int tMiAgVhCKUhHOdiwAySOMpxktsU(Controller param_0000e5b8, string param_0000e5b9, List<ControllerMap> param_0000e5ba); // 0x000000018129E890-0x000000018129E9C0
				private IEnumerable<ControllerMap> QLyRBVUAepSHUPCdsjmRgMsOiId(ControllerType param_0000e5bb, int param_0000e5bc, int param_0000e5bd); // 0x00000001812960A0-0x0000000181296140
				private IEnumerable<T> QLyRBVUAepSHUPCdsjmRgMsOiId<T>(int param_0000e5be, int param_0000e5bf)
					where T : ControllerMap;
				private ActionElementMap zWuVeIfMjbjzeGortobFYQWfBWD(ControllerType param_0000e5c0, int param_0000e5c1, bool param_0000e5c2); // 0x00000001812A1440-0x00000001812A19B0
				private ActionElementMap zWuVeIfMjbjzeGortobFYQWfBWD(ControllerType param_0000e5c3, string param_0000e5c4, bool param_0000e5c5); // 0x00000001812A1380-0x00000001812A1440
				private IEnumerable<ActionElementMap> VceQlZlQeNWnAVcXwZFwSzxauNl(ControllerType param_0000e5c6, int param_0000e5c7, bool param_0000e5c8); // 0x000000018129A2C0-0x000000018129A360
				private IEnumerable<ActionElementMap> VceQlZlQeNWnAVcXwZFwSzxauNl(ControllerType param_0000e5c9, string param_0000e5ca, bool param_0000e5cb); // 0x000000018129A140-0x000000018129A200
				private ActionElementMap zewHWDgjyeGLAqThpksnKtNDbCr(ControllerType param_0000e5cc, int param_0000e5cd, bool param_0000e5ce); // 0x00000001812A21F0-0x00000001812A2640
				private ActionElementMap zewHWDgjyeGLAqThpksnKtNDbCr(ControllerType param_0000e5cf, string param_0000e5d0, bool param_0000e5d1); // 0x00000001812A2130-0x00000001812A21F0
				private IEnumerable<ActionElementMap> QQTvpNWmnOTXXWnIOJysgquOOSN(ControllerType param_0000e5d2, int param_0000e5d3, bool param_0000e5d4); // 0x00000001812962C0-0x0000000181296360
				private IEnumerable<ActionElementMap> QQTvpNWmnOTXXWnIOJysgquOOSN(ControllerType param_0000e5d5, string param_0000e5d6, bool param_0000e5d7); // 0x0000000181296200-0x00000001812962C0
				private ActionElementMap zfCiUcEGjnQvFnQdnvuKbtLhWwHb(ControllerType param_0000e5d8, int param_0000e5d9, bool param_0000e5da); // 0x00000001812A2700-0x00000001812A29F0
				private ActionElementMap zfCiUcEGjnQvFnQdnvuKbtLhWwHb(ControllerType param_0000e5db, string param_0000e5dc, bool param_0000e5dd); // 0x00000001812A2640-0x00000001812A2700
				private IEnumerable<ActionElementMap> AGYVxhOwMpMgdAOTqqeUwEDCKEZ(ControllerType param_0000e5de, int param_0000e5df, bool param_0000e5e0); // 0x00000001812865D0-0x0000000181286670
				private IEnumerable<ActionElementMap> AGYVxhOwMpMgdAOTqqeUwEDCKEZ(ControllerType param_0000e5e1, string param_0000e5e2, bool param_0000e5e3); // 0x0000000181286510-0x00000001812865D0
				private int iRpRMXtGPzaRzbxQcKhFNYOkpU(int param_0000e5e4, bool param_0000e5e5, List<ActionElementMap> param_0000e5e6, bool param_0000e5e7); // 0x000000018129BAB0-0x000000018129BF00
				private int aJrBTCaTOYGxSpVpmfRGkxuxFcsp(int param_0000e5e8, bool param_0000e5e9, List<ActionElementMap> param_0000e5ea, bool param_0000e5eb); // 0x000000018129A7C0-0x000000018129AC30
				private int LUtxNstqrZkFfSUMrtjuNGVLWKp(int param_0000e5ec, bool param_0000e5ed, List<ActionElementMap> param_0000e5ee, bool param_0000e5ef); // 0x0000000181293ED0-0x0000000181294340
				private int PpzEHMktrgrSozWFKEKIrJEwDdl(ControllerType param_0000e5f0, int param_0000e5f1, bool param_0000e5f2, List<ActionElementMap> param_0000e5f3, bool param_0000e5f4); // 0x0000000181295C60-0x0000000181295FD0
				private int PpzEHMktrgrSozWFKEKIrJEwDdl(ControllerType param_0000e5f5, string param_0000e5f6, bool param_0000e5f7, List<ActionElementMap> param_0000e5f8, bool param_0000e5f9); // 0x0000000181295840-0x0000000181295910
				private int orYUSPTLyKzGaPIjbumYvhkmHjZ(ControllerType param_0000e5fa, int param_0000e5fb, bool param_0000e5fc, List<ActionElementMap> param_0000e5fd, bool param_0000e5fe); // 0x000000018129D7D0-0x000000018129DC80
				private int orYUSPTLyKzGaPIjbumYvhkmHjZ(ControllerType param_0000e5ff, string param_0000e600, bool param_0000e601, List<ActionElementMap> param_0000e602, bool param_0000e603); // 0x000000018129D700-0x000000018129D7D0
				private int sMrwWquwVtpROYhaaLmsTNgBJiKh(ControllerType param_0000e604, int param_0000e605, bool param_0000e606, List<ActionElementMap> param_0000e607, bool param_0000e608); // 0x000000018129DD50-0x000000018129E0E0
				private int sMrwWquwVtpROYhaaLmsTNgBJiKh(ControllerType param_0000e609, string param_0000e60a, bool param_0000e60b, List<ActionElementMap> param_0000e60c, bool param_0000e60d); // 0x000000018129E7C0-0x000000018129E890
				private ActionElementMap zWuVeIfMjbjzeGortobFYQWfBWD(ControllerType param_0000e60e, int param_0000e60f, int param_0000e610, bool param_0000e611); // 0x00000001812A0F10-0x00000001812A1380
				private ActionElementMap zWuVeIfMjbjzeGortobFYQWfBWD(ControllerType param_0000e612, int param_0000e613, string param_0000e614, bool param_0000e615); // 0x00000001812A0E50-0x00000001812A0F10
				private IEnumerable<ActionElementMap> VceQlZlQeNWnAVcXwZFwSzxauNl(ControllerType param_0000e616, int param_0000e617, int param_0000e618, bool param_0000e619); // 0x000000018129A0A0-0x000000018129A140
				private IEnumerable<ActionElementMap> VceQlZlQeNWnAVcXwZFwSzxauNl(ControllerType param_0000e61a, int param_0000e61b, string param_0000e61c, bool param_0000e61d); // 0x000000018129A200-0x000000018129A2C0
				private ActionElementMap zewHWDgjyeGLAqThpksnKtNDbCr(ControllerType param_0000e61e, int param_0000e61f, int param_0000e620, bool param_0000e621); // 0x00000001812A1A70-0x00000001812A2130
				private ActionElementMap zewHWDgjyeGLAqThpksnKtNDbCr(ControllerType param_0000e622, int param_0000e623, string param_0000e624, bool param_0000e625); // 0x00000001812A19B0-0x00000001812A1A70
				private IEnumerable<ActionElementMap> QQTvpNWmnOTXXWnIOJysgquOOSN(ControllerType param_0000e626, int param_0000e627, int param_0000e628, bool param_0000e629); // 0x0000000181296360-0x0000000181296420
				private IEnumerable<ActionElementMap> QQTvpNWmnOTXXWnIOJysgquOOSN(ControllerType param_0000e62a, int param_0000e62b, string param_0000e62c, bool param_0000e62d); // 0x0000000181296140-0x0000000181296200
				private ActionElementMap zfCiUcEGjnQvFnQdnvuKbtLhWwHb(ControllerType param_0000e62e, int param_0000e62f, int param_0000e630, bool param_0000e631); // 0x00000001812A29F0-0x00000001812A2DC0
				private ActionElementMap zfCiUcEGjnQvFnQdnvuKbtLhWwHb(ControllerType param_0000e632, int param_0000e633, string param_0000e634, bool param_0000e635); // 0x00000001812A2DC0-0x00000001812A2E80
				private IEnumerable<ActionElementMap> AGYVxhOwMpMgdAOTqqeUwEDCKEZ(ControllerType param_0000e636, int param_0000e637, int param_0000e638, bool param_0000e639); // 0x0000000181286670-0x0000000181286770
				private IEnumerable<ActionElementMap> AGYVxhOwMpMgdAOTqqeUwEDCKEZ(ControllerType param_0000e63a, int param_0000e63b, string param_0000e63c, bool param_0000e63d); // 0x0000000181286450-0x0000000181286510
				private int PpzEHMktrgrSozWFKEKIrJEwDdl(ControllerType param_0000e63e, int param_0000e63f, int param_0000e640, bool param_0000e641, List<ActionElementMap> param_0000e642, bool param_0000e643); // 0x0000000181295910-0x0000000181295C60
				private int PpzEHMktrgrSozWFKEKIrJEwDdl(ControllerType param_0000e644, int param_0000e645, string param_0000e646, bool param_0000e647, List<ActionElementMap> param_0000e648, bool param_0000e649); // 0x0000000181295FD0-0x00000001812960A0
				private int orYUSPTLyKzGaPIjbumYvhkmHjZ(ControllerType param_0000e64a, int param_0000e64b, int param_0000e64c, bool param_0000e64d, List<ActionElementMap> param_0000e64e, bool param_0000e64f); // 0x000000018129D100-0x000000018129D630
				private int orYUSPTLyKzGaPIjbumYvhkmHjZ(ControllerType param_0000e650, int param_0000e651, string param_0000e652, bool param_0000e653, List<ActionElementMap> param_0000e654, bool param_0000e655); // 0x000000018129D630-0x000000018129D700
				private int sMrwWquwVtpROYhaaLmsTNgBJiKh(ControllerType param_0000e656, int param_0000e657, int param_0000e658, bool param_0000e659, List<ActionElementMap> param_0000e65a, bool param_0000e65b); // 0x000000018129E0E0-0x000000018129E7C0
				private int sMrwWquwVtpROYhaaLmsTNgBJiKh(ControllerType param_0000e65c, int param_0000e65d, string param_0000e65e, bool param_0000e65f, List<ActionElementMap> param_0000e660, bool param_0000e661); // 0x000000018129DC80-0x000000018129DD50
				private ActionElementMap xGTFTEwJTsxlOSroXbTPCnZFHCo(IControllerElementTarget param_0000e662, bool param_0000e663, int param_0000e664, bool param_0000e665); // 0x000000018129FEB0-0x00000001812A0450
				private IEnumerable<ActionElementMap> GVIGeapkjeIDqIFeJwntvbxutdYh(IControllerElementTarget param_0000e666, bool param_0000e667, int param_0000e668, bool param_0000e669); // 0x000000018128BB50-0x000000018128BC30
				private int fayFUJtQndSNaRgkmUFdjreRzfd(IControllerElementTarget param_0000e66a, bool param_0000e66b, int param_0000e66c, bool param_0000e66d, List<ActionElementMap> param_0000e66e, bool param_0000e66f); // 0x000000018129B3A0-0x000000018129B860
			}
	
			[Browsable] // 0x0000000180210FD0-0x0000000180211010
			[EditorBrowsable] // 0x0000000180210FD0-0x0000000180211010
			public sealed class PollingHelper : CodeHelper // TypeDefIndex: 6785
			{
				// Fields
				private readonly Player yHWXapLnjMXUYBDESFaAUIdnziK; // 0x10
				private readonly ControllerHelper GsoDNwSmTlqXUxYxRnLUXMOoArhh; // 0x18
				private readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x20
	
				// Nested types
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class gCtaoVNHtJKnmRmilNOOWSUEkmc : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6786
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811E5150-0x00000001811E51C0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public gCtaoVNHtJKnmRmilNOOWSUEkmc(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811E4FD0-0x00000001811E5100
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E4FD0-0x00000001811E5100
					private bool MoveNext(); // 0x00000001811E4B80-0x00000001811E4FD0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E5100-0x00000001811E5150
					void IDisposable.Dispose(); // 0x00000001811E51C0-0x00000001811E5270
					private void fqAGLNbhXzpioMYpWiwuPqYhgcFI(); // 0x00000001811E5270-0x00000001811E52C0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class sJqIMjawweOOsGQOECgdBgSLYST : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6787
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811E9370-0x00000001811E93E0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public sJqIMjawweOOsGQOECgdBgSLYST(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811E9210-0x00000001811E9320
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E9210-0x00000001811E9320
					private bool MoveNext(); // 0x00000001811E8E00-0x00000001811E9210
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E9320-0x00000001811E9370
					void IDisposable.Dispose(); // 0x00000001811E93E0-0x00000001811E9450
					private void YkKITNrqwDsdCQUrvnJtBEbHeSE(); // 0x00000001811E9450-0x00000001811E9570
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class OtNtyBucKLRJTjZxccdiwYUZejB : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6788
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811D5190-0x00000001811D5200 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public OtNtyBucKLRJTjZxccdiwYUZejB(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811D5040-0x00000001811D5140
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811D5040-0x00000001811D5140
					private bool MoveNext(); // 0x00000001811D4B60-0x00000001811D5040
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811D5140-0x00000001811D5190
					void IDisposable.Dispose(); // 0x00000001811D5200-0x00000001811D5270
					private void TWjQtFekWIBuEKzcTePdQUBcHUc(); // 0x00000001811D5270-0x00000001811D5360
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class jKvcHakBvXgsXvuKpRTXunOmGyGC : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6789
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811E6730-0x00000001811E67A0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public jKvcHakBvXgsXvuKpRTXunOmGyGC(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811E65E0-0x00000001811E66E0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E65E0-0x00000001811E66E0
					private bool MoveNext(); // 0x00000001811E6280-0x00000001811E65E0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E66E0-0x00000001811E6730
					void IDisposable.Dispose(); // 0x00000001811E67A0-0x00000001811E6810
					private void yNVMOVEijljPsdvazRDxIxnepmxe(); // 0x00000001811E6810-0x00000001811E6910
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class zHTCNTACEbezSLsTBfZwXgHjYLs : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6790
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811EC960-0x00000001811EC9D0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public zHTCNTACEbezSLsTBfZwXgHjYLs(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811EC7D0-0x00000001811EC910
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811EC7D0-0x00000001811EC910
					private bool MoveNext(); // 0x00000001811EC490-0x00000001811EC7D0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811EC910-0x00000001811EC960
					void IDisposable.Dispose(); // 0x00000001811EC9D0-0x00000001811ECA80
					private void eeqLcjHwNPDPmlWJPRDqAnCgAgu(); // 0x00000001811ECA80-0x00000001811ECAD0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class aXopQFWXqHJOhGflGbwwauGTXQOk : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6791
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811E3240-0x00000001811E32B0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public aXopQFWXqHJOhGflGbwwauGTXQOk(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811E3110-0x00000001811E31F0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E3110-0x00000001811E31F0
					private bool MoveNext(); // 0x00000001811E2A20-0x00000001811E2FF0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E31F0-0x00000001811E3240
					void IDisposable.Dispose(); // 0x00000001811E32B0-0x00000001811E3320
					private void SlLyhKovlngbnFzSserBsfRvlnB(); // 0x00000001811E2FF0-0x00000001811E3110
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class AKfotMJaboGCSkdXqlgdGJUeFAtF : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6792
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811D2170-0x00000001811D21E0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public AKfotMJaboGCSkdXqlgdGJUeFAtF(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811D1FF0-0x00000001811D2120
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811D1FF0-0x00000001811D2120
					private bool MoveNext(); // 0x00000001811D19F0-0x00000001811D1FF0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811D2120-0x00000001811D2170
					void IDisposable.Dispose(); // 0x00000001811D21E0-0x00000001811D2250
					private void mjjnILKelBAASEpTRIomFyXhZAEe(); // 0x00000001811D2250-0x00000001811D2380
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class keJWfHsmVDTJdRqYBzFJrpGsdPf : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6793
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811E70D0-0x00000001811E7140 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public keJWfHsmVDTJdRqYBzFJrpGsdPf(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811E6F80-0x00000001811E7080
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E6F80-0x00000001811E7080
					private bool MoveNext(); // 0x00000001811E6960-0x00000001811E6F80
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E7080-0x00000001811E70D0
					void IDisposable.Dispose(); // 0x00000001811E7140-0x00000001811E71F0
					private void JwuDFniyORfcXeHkdYjTurcoUQOJ(); // 0x00000001811E6910-0x00000001811E6960
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class AKrCDkEqInEVRtylFTHfoSQIzGV : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6794
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811D2980-0x00000001811D29F0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public AKrCDkEqInEVRtylFTHfoSQIzGV(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811D2840-0x00000001811D2930
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811D2840-0x00000001811D2930
					private bool MoveNext(); // 0x00000001811D2380-0x00000001811D2840
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811D2930-0x00000001811D2980
					void IDisposable.Dispose(); // 0x00000001811D29F0-0x00000001811D2AE0
					private void dPgNoUYkvilxbgoqdCDWbOqUuMW(); // 0x00000001811D2AE0-0x00000001811D2B30
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class RYmUoNsKRvIZuGYgMrhnaMgNfJy : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6795
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811DFDE0-0x00000001811DFE50 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public RYmUoNsKRvIZuGYgMrhnaMgNfJy(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811DFC70-0x00000001811DFD90
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811DFC70-0x00000001811DFD90
					private bool MoveNext(); // 0x00000001811DF810-0x00000001811DFC70
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811DFD90-0x00000001811DFDE0
					void IDisposable.Dispose(); // 0x00000001811DFE50-0x00000001811DFF30
					private void ERNfBkLvKlyFkwYqMAGJURIvBwg(); // 0x00000001811DF7C0-0x00000001811DF810
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class kiFcjQgtdsRkKEjjzTtFaqHHjwuC : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6796
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811E7700-0x00000001811E7770 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public kiFcjQgtdsRkKEjjzTtFaqHHjwuC(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811E75C0-0x00000001811E76B0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E75C0-0x00000001811E76B0
					private bool MoveNext(); // 0x00000001811E71F0-0x00000001811E75C0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E76B0-0x00000001811E7700
					void IDisposable.Dispose(); // 0x00000001811E7770-0x00000001811E77E0
					private void UCeJKEJDaLsszsXalTMxDkCaNni(); // 0x00000001811E77E0-0x00000001811E7900
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class VTvpfXfHHunOiWonwxlVAqSGcSj : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6797
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811E1BE0-0x00000001811E1C50 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public VTvpfXfHHunOiWonwxlVAqSGcSj(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811E1A90-0x00000001811E1B90
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E1A90-0x00000001811E1B90
					private bool MoveNext(); // 0x00000001811E1720-0x00000001811E1A90
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E1B90-0x00000001811E1BE0
					void IDisposable.Dispose(); // 0x00000001811E1C50-0x00000001811E1D00
					private void LpSAtIFNkJCaKAjcaebZkcXdPWiJ(); // 0x00000001811E16D0-0x00000001811E1720
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class YiXCXkQKgfEpacJYrCacawfdkyio : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6798
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811E21A0-0x00000001811E2210 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public YiXCXkQKgfEpacJYrCacawfdkyio(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811E2050-0x00000001811E2150
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E2050-0x00000001811E2150
					private bool MoveNext(); // 0x00000001811E1D00-0x00000001811E2050
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E2150-0x00000001811E21A0
					void IDisposable.Dispose(); // 0x00000001811E2210-0x00000001811E2280
					private void pqKpusOlYXnfjOxvSyXpvFHFRFN(); // 0x00000001811E2280-0x00000001811E23A0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class ZSJERXgHekvwfHenwIRmxhKvodtc : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6799
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811E28B0-0x00000001811E2920 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public ZSJERXgHekvwfHenwIRmxhKvodtc(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811E2720-0x00000001811E2860
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E2720-0x00000001811E2860
					private bool MoveNext(); // 0x00000001811E23A0-0x00000001811E2720
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E2860-0x00000001811E28B0
					void IDisposable.Dispose(); // 0x00000001811E2920-0x00000001811E29D0
					private void lkDNNaQkAOwbpAgxOXdDVYXbapt(); // 0x00000001811E29D0-0x00000001811E2A20
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class MUAwfCvNHsDaochDRApoLwoimLsp : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6800
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811D4240-0x00000001811D42B0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public MUAwfCvNHsDaochDRApoLwoimLsp(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811D40C0-0x00000001811D41F0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811D40C0-0x00000001811D41F0
					private bool MoveNext(); // 0x00000001811D3C00-0x00000001811D40C0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811D41F0-0x00000001811D4240
					void IDisposable.Dispose(); // 0x00000001811D42B0-0x00000001811D4320
					private void gqsvnpZPqaDPPmTwCcRItmtytJL(); // 0x00000001811D4320-0x00000001811D4440
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class nnOJfSsrEaLPcDaLLpJGwvBitiD : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6801
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811E7FE0-0x00000001811E8050 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public nnOJfSsrEaLPcDaLLpJGwvBitiD(int <>1__state); // 0x00000001811E80C0-0x00000001811E8130
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811E7E70-0x00000001811E7F90
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E7E70-0x00000001811E7F90
					private bool MoveNext(); // 0x00000001811E7900-0x00000001811E7E70
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E7F90-0x00000001811E7FE0
					void IDisposable.Dispose(); // 0x00000001811E8050-0x00000001811E80C0
					private void joGbrKiZzuivGqYHrRNzrsboSAp(); // 0x00000001811E8130-0x00000001811E8220
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class UGbESIkdAtEWZFaohrhLMBpIYOts : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6802
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811E1010-0x00000001811E1080 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public UGbESIkdAtEWZFaohrhLMBpIYOts(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811E0ED0-0x00000001811E0FC0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E0ED0-0x00000001811E0FC0
					private bool MoveNext(); // 0x00000001811E08F0-0x00000001811E0ED0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E0FC0-0x00000001811E1010
					void IDisposable.Dispose(); // 0x00000001811E1080-0x00000001811E10F0
					private void EQluhAPJOkWMtYWjgsiAqkoxbiS(); // 0x00000001811E07D0-0x00000001811E08F0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class bBaPMlWkUHAaTFfKqUkBPVWFJwdn : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6803
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811E3840-0x00000001811E38B0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public bBaPMlWkUHAaTFfKqUkBPVWFJwdn(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811E36E0-0x00000001811E37F0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E36E0-0x00000001811E37F0
					private bool MoveNext(); // 0x00000001811E3320-0x00000001811E36E0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811E37F0-0x00000001811E3840
					void IDisposable.Dispose(); // 0x00000001811E38B0-0x00000001811E3920
					private void VeIhzYKDLGQcNcVKGEelUxHlBri(); // 0x00000001811E3920-0x00000001811E3A40
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class NuJLRNtegORChwTlBYTbLgLrBDt : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6804
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811D49D0-0x00000001811D4A40 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public NuJLRNtegORChwTlBYTbLgLrBDt(int <>1__state); // 0x00000001811D4AF0-0x00000001811D4B60
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811D4860-0x00000001811D4980
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811D4860-0x00000001811D4980
					private bool MoveNext(); // 0x00000001811D4490-0x00000001811D4860
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811D4980-0x00000001811D49D0
					void IDisposable.Dispose(); // 0x00000001811D4A40-0x00000001811D4AF0
					private void GWsHWjJnudmPZrLzQBKmhHvfpgLn(); // 0x00000001811D4440-0x00000001811D4490
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class vZkZTXMRClNwCGjTqDDnFbVfFekD : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6805
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001811EAB10-0x00000001811EAB80 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public vZkZTXMRClNwCGjTqDDnFbVfFekD(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x00000001811EA990-0x00000001811EAAC0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811EA990-0x00000001811EAAC0
					private bool MoveNext(); // 0x00000001811EA5C0-0x00000001811EA990
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001811EAAC0-0x00000001811EAB10
					void IDisposable.Dispose(); // 0x00000001811EAB80-0x00000001811EAC30
					private void YuFNQOfmtlzapzcIPzghEEIaiQB(); // 0x00000001811EAC30-0x00000001811EAC80
				}
	
				// Constructors
				internal PollingHelper(Player player, ControllerHelper parent); // 0x00000001811DD870-0x00000001811DD940
	
				// Methods
				public ControllerPollingInfo PollControllerForFirstElement(ControllerType controllerType, int controllerId); // 0x00000001811DC8D0-0x00000001811DCD10
				public ControllerPollingInfo PollControllerForFirstElementDown(ControllerType controllerType, int controllerId); // 0x00000001811DC440-0x00000001811DC8D0
				public ControllerPollingInfo PollControllerForFirstButton(ControllerType controllerType, int controllerId); // 0x00000001811DBF70-0x00000001811DC440
				public ControllerPollingInfo PollControllerForFirstButtonDown(ControllerType controllerType, int controllerId); // 0x00000001811DBAE0-0x00000001811DBF70
				public ControllerPollingInfo PollControllerForFirstAxis(ControllerType controllerType, int controllerId); // 0x00000001811DB700-0x00000001811DBAE0
				public IEnumerable<ControllerPollingInfo> PollControllerForAllElements(ControllerType controllerType, int controllerId); // 0x00000001811DB450-0x00000001811DB700
				public IEnumerable<ControllerPollingInfo> PollControllerForAllElementsDown(ControllerType controllerType, int controllerId); // 0x00000001811DB140-0x00000001811DB450
				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtons(ControllerType controllerType, int controllerId); // 0x00000001811DAF30-0x00000001811DB140
				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtonsDown(ControllerType controllerType, int controllerId); // 0x00000001811DAD50-0x00000001811DAF30
				public IEnumerable<ControllerPollingInfo> PollControllerForAllAxes(ControllerType controllerType, int controllerId); // 0x00000001811DAAC0-0x00000001811DAD50
				public ControllerPollingInfo PollAllControllersOfTypeForFirstElement(ControllerType controllerType); // 0x00000001811DA850-0x00000001811DAAC0
				public ControllerPollingInfo PollAllControllersOfTypeForFirstButton(ControllerType controllerType); // 0x00000001811DA340-0x00000001811DA850
				public ControllerPollingInfo PollAllControllersOfTypeForFirstButtonDown(ControllerType controllerType); // 0x00000001811D9FB0-0x00000001811DA340
				public ControllerPollingInfo PollAllControllersOfTypeForFirstAxis(ControllerType controllerType); // 0x00000001811D9B60-0x00000001811D9FB0
				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllElements(ControllerType controllerType); // 0x00000001811D9900-0x00000001811D9B60
				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllElementsDown(ControllerType controllerType); // 0x00000001811D9710-0x00000001811D9900
				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllButtons(ControllerType controllerType); // 0x00000001811D9520-0x00000001811D9710
				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllButtonsDown(ControllerType controllerType); // 0x00000001811D9290-0x00000001811D9520
				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllAxes(ControllerType controllerType); // 0x00000001811D9080-0x00000001811D9290
				private ControllerPollingInfo bGKlLbFWmbtGAiOmNKKPUtnwcAZ(int param_0000e6a1); // 0x00000001811DD940-0x00000001811DDAC0
				private ControllerPollingInfo rqyemvFZhjSSrBYMaOhYnmPCKqem(int param_0000e6a2); // 0x00000001811DEBD0-0x00000001811DED20
				private ControllerPollingInfo NQtBLmIPQGvDNomIxxmiVjxcQNAA(int param_0000e6a3); // 0x00000001811D89E0-0x00000001811D8B70
				private ControllerPollingInfo NadfyxFpnsKvEQGCdsAnNZMYaax(int param_0000e6a4); // 0x00000001811D8B70-0x00000001811D8D10
				private ControllerPollingInfo oKWdenitALAFVrRNgIdhEPKFJvb(int param_0000e6a5); // 0x00000001811DE480-0x00000001811DE5C0
				private IEnumerable<ControllerPollingInfo> ZWimbzFMwCSuhYFEcXFEeWFifWR(int param_0000e6a6); // 0x00000001811DD5C0-0x00000001811DD670
				private IEnumerable<ControllerPollingInfo> RehcirISqbiBTGUaoHnpFtPenXv(int param_0000e6a7); // 0x00000001811DCDA0-0x00000001811DCE50
				private IEnumerable<ControllerPollingInfo> zWDCSWjzhmjQvPyFnbCXiBHCOwJJ(int param_0000e6a8); // 0x00000001811DF260-0x00000001811DF2F0
				private IEnumerable<ControllerPollingInfo> MtBriKVVFZdgebmAQffCEKEFdXl(int param_0000e6a9); // 0x00000001811D8950-0x00000001811D89E0
				private IEnumerable<ControllerPollingInfo> OSicUzHcokWNlWyDVoxJoXjEYvE(int param_0000e6aa); // 0x00000001811D8D10-0x00000001811D8DA0
				private ControllerPollingInfo dxGBopFwPGpRnntJodvmMTzYCpiY(); // 0x00000001811DDB50-0x00000001811DDDF0
				private ControllerPollingInfo fWKPjGiTOuPWukeRyCkdtHrmENvE(); // 0x00000001811DDDF0-0x00000001811DE080
				private ControllerPollingInfo ZofbmNrsDVSejYtKcoCeGNYmbpn(); // 0x00000001811DD670-0x00000001811DD870
				private ControllerPollingInfo PUcjNuzteixdxqKUVlKFhYGZmsf(); // 0x00000001811D8EB0-0x00000001811D9080
				private ControllerPollingInfo UKRVFPSTSpcGXWGJXZBATXbYkwq(); // 0x00000001811DD030-0x00000001811DD1E0
				private IEnumerable<ControllerPollingInfo> AItrmiLLNLETHbDmllsTwttPIQaC(); // 0x00000001811D7FF0-0x00000001811D8070
				private IEnumerable<ControllerPollingInfo> jrGRHFKGLMVcvwxfLWDvEVEfMLi(); // 0x00000001811DE190-0x00000001811DE210
				private IEnumerable<ControllerPollingInfo> BtGYtVGEqwSHtYaXzzQUrewGJtn(); // 0x00000001811D8320-0x00000001811D83A0
				private IEnumerable<ControllerPollingInfo> uMQCThPkzuvLVNhlZAgYnTPKtmq(); // 0x00000001811DEF60-0x00000001811DEFE0
				private IEnumerable<ControllerPollingInfo> CfecEujJWgnIEBaHKLlKSQqNiSk(); // 0x00000001811D83A0-0x00000001811D8420
				private ControllerPollingInfo DIwYDhteIrUYYQHskNqJZhFugHo(); // 0x00000001811D8420-0x00000001811D84B0
				private ControllerPollingInfo ciKfGFbLFusTsJrpdJggIwKAROUA(); // 0x00000001811DDAC0-0x00000001811DDB50
				private IEnumerable<ControllerPollingInfo> omzYIcEzjUxwVujJpCnfGdFwAbX(); // 0x00000001811DE830-0x00000001811DE8B0
				private IEnumerable<ControllerPollingInfo> MklBDqRYzLrUUBNdRhVSLsUiLKI(); // 0x00000001811D88D0-0x00000001811D8950
				private ControllerPollingInfo nPZxtrrDJyGWOPAciHrsnAGWWPi(); // 0x00000001811DE3F0-0x00000001811DE480
				private ControllerPollingInfo qBQnfvsldcNuFORfufcManPBmLhk(); // 0x00000001811DEB40-0x00000001811DEBD0
				private ControllerPollingInfo gzutiYORsAguHeeehFjLCLdsDfQh(); // 0x00000001811DE100-0x00000001811DE190
				private ControllerPollingInfo QjcCJttJgHDOZjHbrELXHpwfUGLO(); // 0x00000001811DCD10-0x00000001811DCDA0
				private ControllerPollingInfo sNEfSVWAjRTlpjNlZKETBtDzecp(); // 0x00000001811DED20-0x00000001811DEDB0
				private IEnumerable<ControllerPollingInfo> LhmHRTYQoeUAxXbxFBjrIwBLUWUp(); // 0x00000001811D87D0-0x00000001811D8850
				private IEnumerable<ControllerPollingInfo> ZPuArbyTCfKafkfAWuhezckKgqj(); // 0x00000001811DD540-0x00000001811DD5C0
				private IEnumerable<ControllerPollingInfo> gsMyLZGcNmItjsvMlQRZdhKNgYvC(); // 0x00000001811DE080-0x00000001811DE100
				private IEnumerable<ControllerPollingInfo> OyLGmfjCcioJWJtAePmnOTazcwS(); // 0x00000001811D8E30-0x00000001811D8EB0
				private IEnumerable<ControllerPollingInfo> KyIBIZHBRRlfClOWAZETcMKeKqb(); // 0x00000001811D8750-0x00000001811D87D0
				private ControllerPollingInfo ukARGcUNoOKRPjiqVKBcGVMeLqZ(int param_0000e6ab); // 0x00000001811DEFE0-0x00000001811DF130
				private ControllerPollingInfo SsyPctSmRbgMoZvfEsIGiNBNfBS(int param_0000e6ac); // 0x00000001811DCE50-0x00000001811DCFA0
				private ControllerPollingInfo HTLpMztZmHhBNnBWhwmKUZaJjJx(int param_0000e6ad); // 0x00000001811D8620-0x00000001811D8750
				private ControllerPollingInfo EVefEGecgrsLVWECEuaCKzyFaYa(int param_0000e6ae); // 0x00000001811D84B0-0x00000001811D8620
				private ControllerPollingInfo meAjTtJCVRtvGxDotlYZDOPybkb(int param_0000e6af); // 0x00000001811DE290-0x00000001811DE3F0
				private IEnumerable<ControllerPollingInfo> wYgrvTepDlcraADeICRgBBKzeBpu(int param_0000e6b0); // 0x00000001811DF130-0x00000001811DF1C0
				private IEnumerable<ControllerPollingInfo> BqEGmaeHIeNTnicYHhRMjMtLkMLC(int param_0000e6b1); // 0x00000001811D8070-0x00000001811D8100
				private IEnumerable<ControllerPollingInfo> YklCVTfTmFGyKDdTjkJgSXyKecKX(int param_0000e6b2); // 0x00000001811DD490-0x00000001811DD540
				private IEnumerable<ControllerPollingInfo> OevlbRZKmWsizWsTsKtDOUmFvIt(int param_0000e6b3); // 0x00000001811D8DA0-0x00000001811D8E30
				private IEnumerable<ControllerPollingInfo> TrQFuxrthJtxLaAuKTMNREkLqsA(int param_0000e6b4); // 0x00000001811DCFA0-0x00000001811DD030
				private ControllerPollingInfo oSFtmtOlVnmtllndgZhgzjXrcPbB(); // 0x00000001811DE5C0-0x00000001811DE830
				private ControllerPollingInfo BqyFLNGhnxjMKKYomIkiUEqnhvbC(); // 0x00000001811D8100-0x00000001811D8320
				private ControllerPollingInfo pxpCQJFztfslpkhJUtGDeDKsfMI(); // 0x00000001811DE970-0x00000001811DEB40
				private ControllerPollingInfo VttanxeBuoolFYVesRmMRlbaZaiL(); // 0x00000001811DD1E0-0x00000001811DD410
				private ControllerPollingInfo sxpqmzYXwllNCeZVMFVbptxNUkx(); // 0x00000001811DEDB0-0x00000001811DEF60
				private IEnumerable<ControllerPollingInfo> ptBfGdJhSVIOGLSnobCWSRZzxBii(); // 0x00000001811DE8B0-0x00000001811DE970
				private IEnumerable<ControllerPollingInfo> XKeRkgCoTdFtbODgFSXZqtgWlrZ(); // 0x00000001811DD410-0x00000001811DD490
				private IEnumerable<ControllerPollingInfo> MJIamdcXeYbqxTTEaHBvVhjKibf(); // 0x00000001811D8850-0x00000001811D88D0
				private IEnumerable<ControllerPollingInfo> yoOWDMRSkMEUZtHTwrKxqttgCFo(); // 0x00000001811DF1C0-0x00000001811DF260
				private IEnumerable<ControllerPollingInfo> maRRnmjmoNDrDjpkFIWHkPqGUslH(); // 0x00000001811DE210-0x00000001811DE290
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class oevHatVHifWURdnOTzPYFQtPrXj : IEnumerable<Controller>, IEnumerator<Controller> // TypeDefIndex: 6806
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
				Controller zfTTcVuktSqnpnLaNjCEBYRXWaU { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public oevHatVHifWURdnOTzPYFQtPrXj(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Controller> IEnumerable<Controller>.GetEnumerator(); // 0x00000001811E8670-0x00000001811E8750
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001811E8670-0x00000001811E8750
				private bool MoveNext(); // 0x00000001811E8220-0x00000001811E8670
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001811E8750-0x00000001811E87A0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			internal ControllerHelper(Player player, VVLouGbEKulMPcFZiTUTqikUjEp startingControllerMapInfo, ControllerMapLayoutManager.StartingSettings controllerMapLayoutManagerSettings, ControllerMapEnabler.ZgESyvoCZDaaWJMTaxFmFrlTHlVN controllerMapEnablerSettings); // 0x00000001811773E0-0x0000000181177900
	
			// Methods
			public T GetController<T>(int controllerId)
				where T : Controller;
			public Controller GetController(ControllerType controllerType, int controllerId); // 0x0000000181173A10-0x0000000181173B70
			public T GetControllerWithTag<T>(string tag)
				where T : Controller;
			public Controller GetControllerWithTag(ControllerType controllerType, string tag); // 0x00000001811738B0-0x0000000181173A10
			public void AddController<T>(int controllerId, bool removeFromOtherPlayers)
				where T : Controller;
			public void AddController(Controller controller, bool removeFromOtherPlayers); // 0x0000000181172420-0x0000000181172670
			public void AddController(ControllerType controllerType, int controllerId, bool removeFromOtherPlayers); // 0x0000000181172670-0x0000000181172A10
			public void RemoveController<T>(int controllerId)
				where T : Controller;
			public void RemoveController(ControllerType controllerType, int controllerId); // 0x00000001811752F0-0x0000000181175480
			public void RemoveController(Controller controller); // 0x0000000181175480-0x00000001811756A0
			public bool ContainsController<T>(int controllerId)
				where T : Controller;
			public bool ContainsController(ControllerType controllerType, int controllerId); // 0x00000001811730C0-0x0000000181173290
			public bool ContainsController(Controller controller); // 0x0000000181173290-0x0000000181173510
			public void ClearControllersOfType<T>()
				where T : Controller;
			public void ClearControllersOfType(ControllerType controllerType); // 0x0000000181172DE0-0x0000000181172F60
			public void ClearAllControllers(); // 0x0000000181172D10-0x0000000181172DE0
			public Controller GetLastActiveController(); // 0x0000000181173FE0-0x0000000181174240
			public Controller GetLastActiveController(ControllerType controllerType); // 0x0000000181174240-0x00000001811745B0
			private void EUVYCARsIPrBKbpQiGBVjqXpKpjH(ControllerType param_0000e07e, ref Controller param_0000e07f, ref float param_0000e080); // 0x0000000181173510-0x0000000181173870
			public Controller GetLastActiveController<T>()
				where T : Controller;
			public void AddLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback); // 0x0000000181172A10-0x0000000181172B80
			public void AddLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback, ControllerType controllerType); // 0x0000000181172B80-0x0000000181172D10
			public void RemoveLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback); // 0x00000001811757F0-0x0000000181175970
			public void RemoveLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback, ControllerType controllerType); // 0x00000001811756A0-0x00000001811757F0
			public void ClearLastActiveControllerChangedDelegates(); // 0x0000000181172F60-0x00000001811730C0
			public Controller GetFirstControllerWithTemplate(Guid templateTypeGuid); // 0x0000000181173B70-0x0000000181173DC0
			public Controller GetFirstControllerWithTemplate(Type templateType); // 0x0000000181173DC0-0x0000000181173FE0
			public Controller GetFirstControllerWithTemplate<T>()
				where T : class;
			public IList<TInterface> GetControllerTemplates<TInterface>()
				where TInterface : IControllerTemplate;
			private Controller jYszhMBrmTjIcZxErgYoWfGYMXC<TDelegateParam>(ControllerType param_0000e089, Func<Controller, TDelegateParam, bool> param_0000e08a, TDelegateParam param_0000e08b);
			internal void ItdhavHGXcUkAhyjaCFbIXENJheh(); // 0x00000001811745B0-0x00000001811749F0
			internal float FYIElmJxflCFhgIZyTsOMvYpGHtG(int param_0000e08c); // 0x0000000181173870-0x00000001811738B0
			internal void XaPQxcyWqNsdQjhKzBKsjimvZyS(Joystick param_0000e08d, bool param_0000e08e); // 0x0000000181175E10-0x0000000181176360
			internal void XaPQxcyWqNsdQjhKzBKsjimvZyS(int param_0000e08f, bool param_0000e090); // 0x0000000181175D50-0x0000000181175E10
			internal void xzceZeGGWmetBAeiWNsduDUsewIa(int param_0000e091); // 0x0000000181179340-0x00000001811797B0
			internal void xzceZeGGWmetBAeiWNsduDUsewIa(Joystick param_0000e092); // 0x0000000181179320-0x0000000181179340
			internal void JVgdmkDNRxZQzikVOAghyODdmTo(); // 0x00000001811749F0-0x0000000181174F90
			internal void XiHbKYIwqhdauDbRGGwGkFljxrFY(CustomController param_0000e093, bool param_0000e094); // 0x0000000181176360-0x00000001811766D0
			internal void XiHbKYIwqhdauDbRGGwGkFljxrFY(int param_0000e095, bool param_0000e096); // 0x00000001811766D0-0x00000001811767A0
			internal void ThZteeIklpsxGRYsSIfxQcYzcae(int param_0000e097); // 0x0000000181175970-0x0000000181175D30
			internal void ThZteeIklpsxGRYsSIfxQcYzcae(CustomController param_0000e098); // 0x0000000181175D30-0x0000000181175D50
			internal void uOzYhSCLiLcGIIOdEdqkuYDlGKHv(); // 0x0000000181178E20-0x00000001811792D0
			internal CustomController KVVCTKWyFZmIycuszMOZbQGKMvX(int param_0000e099); // 0x0000000181174F90-0x00000001811752F0
			internal void tzDaIgFQnfsVMqJsHHtXDlwsoxaI(Action<bool, int, int> param_0000e09a); // 0x0000000181178DD0-0x0000000181178E20
			internal void AbkUkCWdTMWidEEQvyYkEXJXtVW(Keyboard param_0000e09b, djpwPzKBzvznzxIiuRBprQLHfCc param_0000e09c, Action<bool, int, int> param_0000e09d); // 0x00000001811719B0-0x0000000181172420
			private static void XpMdjVJIiPLupjAFCctYNYGLQFMI(Keyboard param_0000e09e, ControllerMap param_0000e09f, ActionElementMap param_0000e0a0, IqIukLIsmYdsSTXcphOdCKQUWBG param_0000e0a1, ButtonStateFlags param_0000e0a2); // 0x00000001811767A0-0x00000001811768D0
			internal void ZUUoXTAWbstgZnbECVAwXArHCqOf(Mouse param_0000e0a3, Action<bool, int, int> param_0000e0a4); // 0x00000001811768D0-0x00000001811773E0
			internal void xYYePMSKaQDySNlDrymJaiyuDfTi(Action<bool, int, int> param_0000e0a5); // 0x00000001811792D0-0x0000000181179320
			private void oKtDVECOnvicsHXYOjPcsNPoasn<T, TMap>(ControllerType param_0000e0a6, Action<bool, int, int> param_0000e0a7)
				where T : ControllerWithAxes
				where TMap : ControllerMapWithAxes;
			private bool PPjNWtPrrNLfSFeDfxlPEFiPlWi<TMap>(ControllerWithAxes param_0000e0a8, int param_0000e0a9, int param_0000e0aa, ActionElementMap param_0000e0ab, UqmUJOucnPAhoXhVuhvbmxKGsOH<TMap> param_0000e0ac, int param_0000e0ad, ref float param_0000e0ae)
				where TMap : ControllerMapWithAxes;
			private bool VgZTJYILLhKkehwJvkGIEHsbWZu<TMap>(UnknownControllerHat.HatButtons param_0000e0af, int param_0000e0b0, UqmUJOucnPAhoXhVuhvbmxKGsOH<TMap> param_0000e0b1)
				where TMap : ControllerMapWithAxes;
			private bool PTrrixCBiTdabCtPetYhlDlQzig<TMap>(UnknownControllerHat.HatButtons param_0000e0b2, int param_0000e0b3, UqmUJOucnPAhoXhVuhvbmxKGsOH<TMap> param_0000e0b4)
				where TMap : ControllerMapWithAxes;
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static void pOcCcEPETYfiVgcsLGAPfcnitqGJ(Exception param_0000e0b5); // 0x0000000181178420-0x0000000181178480
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static void nKBfZOoSRNcWGVmXsGDbjHqfeFdg(Exception param_0000e0b6); // 0x00000001811783C0-0x0000000181178420
		}
	
		// Constructors
		internal Player(bool isSystem, int playerId, string name, string descriptiveName, VVLouGbEKulMPcFZiTUTqikUjEp startingControllerMapInfo, ControllerMapLayoutManager.StartingSettings controllerMapLayoutManagerSettings, ControllerMapEnabler.ZgESyvoCZDaaWJMTaxFmFrlTHlVN controllerMapEnablerSettings); // 0x0000000181187330-0x0000000181187520
	
		// Methods
		public PlayerSaveData GetSaveData(bool userAssignableMapsOnly); // 0x0000000181184C30-0x0000000181184EA0
		public bool GetButton(string actionName); // 0x0000000181181470-0x0000000181181550
		public bool GetButton(int actionId); // 0x0000000181181360-0x0000000181181470
		public bool GetButtonDown(string actionName); // 0x000000018117EDD0-0x000000018117EEB0
		public bool GetButtonDown(int actionId); // 0x000000018117ECD0-0x000000018117EDD0
		public bool GetButtonUp(string actionName); // 0x0000000181181150-0x0000000181181230
		public bool GetButtonUp(int actionId); // 0x0000000181181230-0x0000000181181360
		public bool GetButtonPrev(string actionName); // 0x000000018117F480-0x000000018117F560
		public bool GetButtonPrev(int actionId); // 0x000000018117F560-0x000000018117F640
		public bool GetButtonSinglePressHold(int actionId); // 0x0000000181180060-0x0000000181180170
		public bool GetButtonSinglePressHold(string actionName); // 0x000000018117FF80-0x0000000181180060
		public bool GetButtonSinglePressDown(int actionId); // 0x000000018117FDC0-0x000000018117FEA0
		public bool GetButtonSinglePressDown(string actionName); // 0x000000018117FEA0-0x000000018117FF80
		public bool GetButtonSinglePressUp(int actionId); // 0x0000000181180170-0x0000000181180270
		public bool GetButtonSinglePressUp(string actionName); // 0x0000000181180270-0x0000000181180350
		public bool GetButtonDoublePressHold(string actionName, float speed); // 0x000000018117E540-0x000000018117E660
		public bool GetButtonDoublePressHold(int actionId, float speed); // 0x000000018117E660-0x000000018117E740
		public bool GetButtonDoublePressHold(string actionName); // 0x000000018117E820-0x000000018117E930
		public bool GetButtonDoublePressHold(int actionId); // 0x000000018117E740-0x000000018117E820
		public bool GetButtonDoublePressDown(string actionName, float speed); // 0x000000018117E370-0x000000018117E460
		public bool GetButtonDoublePressDown(int actionId, float speed); // 0x000000018117E460-0x000000018117E540
		public bool GetButtonDoublePressDown(string actionName); // 0x000000018117E0F0-0x000000018117E230
		public bool GetButtonDoublePressDown(int actionId); // 0x000000018117E230-0x000000018117E370
		public bool GetButtonDoublePressUp(string actionName, float speed); // 0x000000018117EA10-0x000000018117EB00
		public bool GetButtonDoublePressUp(int actionId, float speed); // 0x000000018117E930-0x000000018117EA10
		public bool GetButtonDoublePressUp(string actionName); // 0x000000018117EBE0-0x000000018117ECD0
		public bool GetButtonDoublePressUp(int actionId); // 0x000000018117EB00-0x000000018117EBE0
		public bool GetButtonTimedPress(string actionName, float time); // 0x0000000181180D30-0x0000000181180E20
		public bool GetButtonTimedPress(int actionId, float time); // 0x0000000181180F50-0x0000000181181040
		public bool GetButtonTimedPress(string actionName, float time, float expireIn); // 0x0000000181180E20-0x0000000181180F50
		public bool GetButtonTimedPress(int actionId, float time, float expireIn); // 0x0000000181181040-0x0000000181181150
		public bool GetButtonTimedPressDown(string actionName, float time); // 0x0000000181180800-0x00000001811808F0
		public bool GetButtonTimedPressDown(int actionId, float time); // 0x00000001811806F0-0x0000000181180800
		public bool GetButtonTimedPressUp(string actionName, float time); // 0x0000000181180C20-0x0000000181180D30
		public bool GetButtonTimedPressUp(int actionId, float time); // 0x00000001811808F0-0x00000001811809E0
		public bool GetButtonTimedPressUp(string actionName, float time, float expireIn); // 0x00000001811809E0-0x0000000181180B00
		public bool GetButtonTimedPressUp(int actionId, float time, float expireIn); // 0x0000000181180B00-0x0000000181180C20
		public bool GetButtonShortPress(string actionName); // 0x000000018117FCB0-0x000000018117FDC0
		public bool GetButtonShortPress(int actionId); // 0x000000018117FBD0-0x000000018117FCB0
		public bool GetButtonShortPressDown(string actionName); // 0x000000018117F910-0x000000018117F9F0
		public bool GetButtonShortPressDown(int actionId); // 0x000000018117F800-0x000000018117F910
		public bool GetButtonShortPressUp(string actionName); // 0x000000018117FAF0-0x000000018117FBD0
		public bool GetButtonShortPressUp(int actionId); // 0x000000018117F9F0-0x000000018117FAF0
		public bool GetButtonLongPress(string actionName); // 0x000000018117F370-0x000000018117F480
		public bool GetButtonLongPress(int actionId); // 0x000000018117F260-0x000000018117F370
		public bool GetButtonLongPressDown(string actionName); // 0x000000018117EFC0-0x000000018117F0A0
		public bool GetButtonLongPressDown(int actionId); // 0x000000018117EEB0-0x000000018117EFC0
		public bool GetButtonLongPressUp(string actionName); // 0x000000018117F180-0x000000018117F260
		public bool GetButtonLongPressUp(int actionId); // 0x000000018117F0A0-0x000000018117F180
		public bool GetButtonRepeating(string actionName); // 0x000000018117F720-0x000000018117F800
		public bool GetButtonRepeating(int actionId); // 0x000000018117F640-0x000000018117F720
		public bool GetAnyButton(); // 0x000000018117B3D0-0x000000018117B4B0
		public bool GetAnyButtonDown(); // 0x000000018117B190-0x000000018117B270
		public bool GetAnyButtonUp(); // 0x000000018117B320-0x000000018117B3D0
		public bool GetAnyButtonPrev(); // 0x000000018117B270-0x000000018117B320
		public float GetButtonTimePressed(string actionName); // 0x0000000181180430-0x0000000181180510
		public float GetButtonTimePressed(int actionId); // 0x0000000181180350-0x0000000181180430
		public float GetButtonTimeUnpressed(string actionName); // 0x00000001811805F0-0x00000001811806F0
		public float GetButtonTimeUnpressed(int actionId); // 0x0000000181180510-0x00000001811805F0
		public bool GetNegativeButton(string actionName); // 0x0000000181184A70-0x0000000181184B50
		public bool GetNegativeButton(int actionId); // 0x0000000181184B50-0x0000000181184C30
		public bool GetNegativeButtonDown(string actionName); // 0x0000000181182330-0x0000000181182410
		public bool GetNegativeButtonDown(int actionId); // 0x0000000181182410-0x0000000181182510
		public bool GetNegativeButtonUp(string actionName); // 0x0000000181184850-0x0000000181184960
		public bool GetNegativeButtonUp(int actionId); // 0x0000000181184960-0x0000000181184A70
		public bool GetNegativeButtonPrev(string actionName); // 0x0000000181182AB0-0x0000000181182B90
		public bool GetNegativeButtonPrev(int actionId); // 0x0000000181182B90-0x0000000181182C90
		public bool GetNegativeButtonSinglePressHold(int actionId); // 0x00000001811836E0-0x0000000181183810
		public bool GetNegativeButtonSinglePressHold(string actionName); // 0x0000000181183600-0x00000001811836E0
		public bool GetNegativeButtonSinglePressDown(int actionId); // 0x0000000181183410-0x00000001811834F0
		public bool GetNegativeButtonSinglePressDown(string actionName); // 0x00000001811834F0-0x0000000181183600
		public bool GetNegativeButtonSinglePressUp(int actionId); // 0x00000001811838F0-0x0000000181183A20
		public bool GetNegativeButtonSinglePressUp(string actionName); // 0x0000000181183810-0x00000001811838F0
		public bool GetNegativeButtonDoublePressHold(string actionName, float speed); // 0x0000000181181BD0-0x0000000181181D00
		public bool GetNegativeButtonDoublePressHold(int actionId, float speed); // 0x0000000181181AF0-0x0000000181181BD0
		public bool GetNegativeButtonDoublePressHold(string actionName); // 0x0000000181181D00-0x0000000181181E30
		public bool GetNegativeButtonDoublePressHold(int actionId); // 0x0000000181181E30-0x0000000181181F10
		public bool GetNegativeButtonDoublePressDown(string actionName, float speed); // 0x0000000181181920-0x0000000181181A10
		public bool GetNegativeButtonDoublePressDown(int actionId, float speed); // 0x0000000181181A10-0x0000000181181AF0
		public bool GetNegativeButtonDoublePressDown(string actionName); // 0x0000000181181750-0x0000000181181840
		public bool GetNegativeButtonDoublePressDown(int actionId); // 0x0000000181181840-0x0000000181181920
		public bool GetNegativeButtonDoublePressUp(string actionName, float speed); // 0x0000000181182240-0x0000000181182330
		public bool GetNegativeButtonDoublePressUp(int actionId, float speed); // 0x0000000181182000-0x0000000181182130
		public bool GetNegativeButtonDoublePressUp(string actionName); // 0x0000000181181F10-0x0000000181182000
		public bool GetNegativeButtonDoublePressUp(int actionId); // 0x0000000181182130-0x0000000181182240
		public bool GetNegativeButtonTimedPress(string actionName, float time); // 0x0000000181184540-0x0000000181184630
		public bool GetNegativeButtonTimedPress(int actionId, float time); // 0x0000000181184740-0x0000000181184850
		public bool GetNegativeButtonTimedPress(string actionName, float time, float expireIn); // 0x0000000181184630-0x0000000181184740
		public bool GetNegativeButtonTimedPress(int actionId, float time, float expireIn); // 0x0000000181184430-0x0000000181184540
		public bool GetNegativeButtonTimedPressDown(string actionName, float time); // 0x0000000181183E50-0x0000000181183F70
		public bool GetNegativeButtonTimedPressDown(int actionId, float time); // 0x0000000181183F70-0x0000000181184050
		public bool GetNegativeButtonTimedPressUp(string actionName, float time); // 0x0000000181184050-0x0000000181184150
		public bool GetNegativeButtonTimedPressUp(int actionId, float time); // 0x0000000181184340-0x0000000181184430
		public bool GetNegativeButtonTimedPressUp(string actionName, float time, float expireIn); // 0x0000000181184240-0x0000000181184340
		public bool GetNegativeButtonTimedPressUp(int actionId, float time, float expireIn); // 0x0000000181184150-0x0000000181184240
		public bool GetNegativeButtonShortPress(string actionName); // 0x0000000181183330-0x0000000181183410
		public bool GetNegativeButtonShortPress(int actionId); // 0x0000000181183220-0x0000000181183330
		public bool GetNegativeButtonShortPressDown(string actionName); // 0x0000000181182F40-0x0000000181183060
		public bool GetNegativeButtonShortPressDown(int actionId); // 0x0000000181182E60-0x0000000181182F40
		public bool GetNegativeButtonShortPressUp(string actionName); // 0x0000000181183140-0x0000000181183220
		public bool GetNegativeButtonShortPressUp(int actionId); // 0x0000000181183060-0x0000000181183140
		public bool GetNegativeButtonLongPress(string actionName); // 0x00000001811829A0-0x0000000181182AB0
		public bool GetNegativeButtonLongPress(int actionId); // 0x00000001811828C0-0x00000001811829A0
		public bool GetNegativeButtonLongPressDown(string actionName); // 0x00000001811825F0-0x00000001811826D0
		public bool GetNegativeButtonLongPressDown(int actionId); // 0x0000000181182510-0x00000001811825F0
		public bool GetNegativeButtonLongPressUp(string actionName); // 0x00000001811826D0-0x00000001811827B0
		public bool GetNegativeButtonLongPressUp(int actionId); // 0x00000001811827B0-0x00000001811828C0
		public bool GetNegativeButtonRepeating(string actionName); // 0x0000000181182D80-0x0000000181182E60
		public bool GetNegativeButtonRepeating(int actionId); // 0x0000000181182C90-0x0000000181182D80
		public bool GetAnyNegativeButton(); // 0x000000018117B6C0-0x000000018117B770
		public bool GetAnyNegativeButtonDown(); // 0x000000018117B4B0-0x000000018117B560
		public bool GetAnyNegativeButtonUp(); // 0x000000018117B610-0x000000018117B6C0
		public bool GetAnyNegativeButtonPrev(); // 0x000000018117B560-0x000000018117B610
		public float GetNegativeButtonTimePressed(string actionName); // 0x0000000181183A20-0x0000000181183B30
		public float GetNegativeButtonTimePressed(int actionId); // 0x0000000181183B30-0x0000000181183C10
		public float GetNegativeButtonTimeUnpressed(string actionName); // 0x0000000181183C10-0x0000000181183D50
		public float GetNegativeButtonTimeUnpressed(int actionId); // 0x0000000181183D50-0x0000000181183E50
		public float GetAxis(string actionName); // 0x000000018117DF10-0x000000018117E010
		public float GetAxis(int actionId); // 0x000000018117E010-0x000000018117E0F0
		public float GetAxisRaw(string actionName); // 0x000000018117DA30-0x000000018117DB10
		public float GetAxisRaw(int actionId); // 0x000000018117D950-0x000000018117DA30
		public float GetAxisPrev(string actionName); // 0x000000018117CDB0-0x000000018117CE90
		public float GetAxisPrev(int actionId); // 0x000000018117CCD0-0x000000018117CDB0
		public float GetAxisRawPrev(string actionName); // 0x000000018117D410-0x000000018117D4F0
		public float GetAxisRawPrev(int actionId); // 0x000000018117D4F0-0x000000018117D5D0
		public float GetAxisDelta(string actionName); // 0x000000018117CB10-0x000000018117CBF0
		public float GetAxisDelta(int actionId); // 0x000000018117CBF0-0x000000018117CCD0
		public float GetAxisRawDelta(string actionName); // 0x000000018117D250-0x000000018117D330
		public float GetAxisRawDelta(int actionId); // 0x000000018117D330-0x000000018117D410
		public Vector2 GetAxis2D(string xAxisActionName, string yAxisActionName); // 0x000000018117C590-0x000000018117C750
		public Vector2 GetAxis2D(int xAxisActionId, int yAxisActionId); // 0x000000018117C3C0-0x000000018117C590
		public Vector2 GetAxis2DPrev(string xAxisActionName, string yAxisActionName); // 0x000000018117B9A0-0x000000018117BB90
		public Vector2 GetAxis2DPrev(int xAxisActionId, int yAxisActionId); // 0x000000018117B770-0x000000018117B9A0
		public Vector2 GetAxis2DRaw(string xAxisActionName, string yAxisActionName); // 0x000000018117BF80-0x000000018117C1B0
		public Vector2 GetAxis2DRaw(int xAxisActionId, int yAxisActionId); // 0x000000018117C1B0-0x000000018117C3C0
		public Vector2 GetAxis2DRawPrev(string xAxisActionName, string yAxisActionName); // 0x000000018117BD60-0x000000018117BF80
		public Vector2 GetAxis2DRawPrev(int xAxisActionId, int yAxisActionId); // 0x000000018117BB90-0x000000018117BD60
		public float GetAxisTimeActive(string actionName); // 0x000000018117DC20-0x000000018117DD00
		public float GetAxisTimeActive(int actionId); // 0x000000018117DB10-0x000000018117DC20
		public float GetAxisTimeInactive(string actionName); // 0x000000018117DDE0-0x000000018117DF10
		public float GetAxisTimeInactive(int actionId); // 0x000000018117DD00-0x000000018117DDE0
		public float GetAxisRawTimeActive(string actionName); // 0x000000018117D6B0-0x000000018117D790
		public float GetAxisRawTimeActive(int actionId); // 0x000000018117D5D0-0x000000018117D6B0
		public float GetAxisRawTimeInactive(string actionName); // 0x000000018117D870-0x000000018117D950
		public float GetAxisRawTimeInactive(int actionId); // 0x000000018117D790-0x000000018117D870
		public AxisCoordinateMode GetAxisCoordinateMode(string actionName); // 0x000000018117CA30-0x000000018117CB10
		public AxisCoordinateMode GetAxisCoordinateMode(int actionId); // 0x000000018117C910-0x000000018117CA30
		public AxisCoordinateMode GetAxisRawCoordinateMode(string actionName); // 0x000000018117D070-0x000000018117D170
		public AxisCoordinateMode GetAxisRawCoordinateMode(int actionId); // 0x000000018117D170-0x000000018117D250
		public AxisCoordinateMode GetAxisCoordinateModePrev(string actionName); // 0x000000018117C750-0x000000018117C830
		public AxisCoordinateMode GetAxisCoordinateModePrev(int actionId); // 0x000000018117C830-0x000000018117C910
		public AxisCoordinateMode GetAxisRawCoordinateModePrev(string actionName); // 0x000000018117CF90-0x000000018117D070
		public AxisCoordinateMode GetAxisRawCoordinateModePrev(int actionId); // 0x000000018117CE90-0x000000018117CF90
		public IList<InputActionSourceData> GetCurrentInputSources(string actionName); // 0x0000000181181650-0x0000000181181750
		public IList<InputActionSourceData> GetCurrentInputSources(int actionId); // 0x0000000181181550-0x0000000181181650
		public bool IsCurrentInputSource(string actionName, ControllerType controllerType); // 0x0000000181185270-0x0000000181185350
		public bool IsCurrentInputSource(int actionId, ControllerType controllerType); // 0x0000000181185440-0x0000000181185520
		public bool IsCurrentInputSource(string actionName, ControllerType controllerType, int controllerId); // 0x0000000181185520-0x0000000181185620
		public bool IsCurrentInputSource(int actionId, ControllerType controllerType, int controllerId); // 0x0000000181185170-0x0000000181185270
		public bool IsCurrentInputSource(string actionName, Controller controller); // 0x0000000181185350-0x0000000181185440
		public bool IsCurrentInputSource(int actionId, Controller controller); // 0x0000000181185050-0x0000000181185170
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop); // 0x000000018117A670-0x000000018117A810
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, int actionId); // 0x000000018117A4D0-0x000000018117A670
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, string actionName); // 0x000000018117A190-0x000000018117A4D0
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType); // 0x000000018117A810-0x000000018117A970
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId); // 0x000000018117A970-0x000000018117A9A0
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName); // 0x000000018117ABB0-0x000000018117ADB0
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, object[] arguments); // 0x000000018117AF10-0x000000018117B070
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId, object[] arguments); // 0x000000018117ADB0-0x000000018117AF10
		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName, object[] arguments); // 0x000000018117A9A0-0x000000018117ABB0
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback); // 0x0000000181185910-0x0000000181185A80
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, int actionId); // 0x0000000181185C10-0x0000000181185D80
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, string actionName); // 0x00000001811861D0-0x0000000181186550
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop); // 0x0000000181186860-0x00000001811869A0
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType); // 0x00000001811866E0-0x0000000181186860
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, int actionId); // 0x0000000181185A80-0x0000000181185C10
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, string actionName); // 0x0000000181185D80-0x0000000181186040
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType, int actionId); // 0x0000000181186040-0x00000001811861D0
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType, string actionName); // 0x0000000181185650-0x0000000181185910
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType); // 0x0000000181186550-0x00000001811866E0
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId); // 0x00000001811869A0-0x0000000181186B50
		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName); // 0x0000000181186B50-0x0000000181186E20
		public void ClearInputEventDelegates(); // 0x000000018117B070-0x000000018117B190
		public void SetVibration(int motorIndex, float motorLevel); // 0x0000000181186E40-0x0000000181186E60
		public void SetVibration(int motorIndex, float motorLevel, float duration); // 0x0000000181186E20-0x0000000181186E40
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors); // 0x0000000181186E60-0x0000000181186E80
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors); // 0x0000000181186E80-0x0000000181187090
		public float GetVibration(int motorIndex); // 0x0000000181184EA0-0x0000000181185050
		public void StopVibration(); // 0x0000000181187090-0x0000000181187330
		internal void SmPrdLxmfnoOLIRlFAKVSpooigo(); // 0x0000000181185620-0x0000000181185650
		private void ItdhavHGXcUkAhyjaCFbIXENJheh(); // 0x0000000181185620-0x0000000181185650
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class ThreadHelper : IDisposable // TypeDefIndex: 7064
	{
		// Fields
		private const uint xRrBUqETfTFgVaeKYEwNasRTyVOn = 750; // Metadata: 0x00766976
		private readonly Stopwatch FKwdqzuvPRrWeVDIWsADAjGZLcc; // 0x10
		private Thread habGSklQHfgBqWkyroQbBEtCUJR; // 0x18
		private ManualResetEvent NQkCEnFdUEkdVrBHRrubSmTJhYov; // 0x20
		private ManualResetEvent AyYfOiGgrSxLTAdlEDUMUXnTRfB; // 0x28
		private AutoResetEvent ZUTwmekGucOcqyAeKEFNjBjsCTFR; // 0x30
		private bool poaRiUqiRYcMJhfteEEAaRqPCsRW; // 0x38
		private bool kjtzKmhFdsTjZhJRubaabYqJdEE; // 0x39
		private int EIjirRmgaJCksDxFWknrCnPJJoR; // 0x3C
		private bool oIvEaInphknKGxKSxbysjEnjjxS; // 0x40
		private int pkJsQFNiQkkfIgUtQDfwVaPoHrW; // 0x44
		private long QFbTemGqrlhUBpGKnAafIoTNkcl; // 0x48
		private bool yWYbVSTlcEadOIFRRMdhTDkOvtM; // 0x50
		private int bgjACySmyKYejqcBagxLhFRoWvm; // 0x54
		private long eHHlqGdDfpiFPGLLImXLQoAQMFBH; // 0x58
		private uint QmSRtIXiyzFHLjHuiqFwzkmnqKRf; // 0x60
		private readonly object HdReBjtnDdCBQVuNqrmXmuJmhjA; // 0x68
		private Queue<Action> FsZxrUpILXAJyOJFwCXhdsnDXWUe; // 0x70
		private Queue<Action> ysFeBhnBeCcmBfiwVCDZNDnnMNu; // 0x78
		private bool ArdEqPnNKZivrHMPdsmorqZgTIb; // 0x80
		private Action nNLdcDapmXavZMwpGvoMFYAzaFVg; // 0x88
		private Action CBzEsFzeCLGouetFgwrtBUMDQPB; // 0x90
		private Action UDIMQZSAvHGZVbNSRVCBaqkiUUVA; // 0x98
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0xA0
	
		// Properties
		public bool isRunning { get; } // 0x00000001804F1610-0x00000001804F1620 
		public bool isStopped { get; } // 0x00000001813FD670-0x00000001813FD6B0 
		public bool useHighPrecitionTimer { get; set; } // 0x00000001813FD6B0-0x00000001813FD6D0 0x00000001813FE020-0x00000001813FE060
		public bool useFixedTimeStep { get; } // 0x0000000180379EC0-0x0000000180379ED0 
		public int fixedTimeStepFPS { get; set; } // 0x00000001804ADA70-0x00000001804ADA80 0x00000001813FDFC0-0x00000001813FDFF0
		public int timeoutMS { get; set; } // 0x0000000180379EE0-0x0000000180379EF0 0x00000001813FDFF0-0x00000001813FE020
		public uint tick { get; } // 0x00000001804ADA80-0x00000001804ADA90 
	
		// Events
		public event Action ThreadUpdateEvent {
			add; // 0x00000001813FD5E0-0x00000001813FD670
			remove; // 0x00000001813FDF30-0x00000001813FDFC0
		}
		private event Action _ThreadStartedEvent {
			add; // 0x00000001813FD520-0x00000001813FD5E0
			remove; // 0x00000001813FDE60-0x00000001813FDF30
		}
		public event Action ThreadStartedEvent {
			add; // 0x00000001813FD520-0x00000001813FD5E0
			remove; // 0x00000001813FDE60-0x00000001813FDF30
		}
		private event Action _ThreadPreStopEvent {
			add; // 0x00000001813FCBD0-0x00000001813FCC90
			remove; // 0x00000001813FCAC0-0x00000001813FCB90
		}
		public event Action ThreadPreStopEvent {
			add; // 0x00000001813FCBD0-0x00000001813FCC90
			remove; // 0x00000001813FCAC0-0x00000001813FCB90
		}
	
		// Constructors
		private ThreadHelper(); // 0x00000001813FD500-0x00000001813FD520
		private ThreadHelper(int timeoutMS); // 0x00000001813FD4E0-0x00000001813FD500
		private ThreadHelper(int fixedTimeStepFPS, bool useHighPrecisionTimer, int timeoutMS); // 0x00000001813FD360-0x00000001813FD4E0
	
		// Methods
		public static ThreadHelper Create(bool fixedTimeStep = false /* Metadata: 0x00766963 */, int fixedTimeStepFPS = 100 /* Metadata: 0x00766964 */, bool useHighPrecisionTimer = false /* Metadata: 0x00766968 */, int timeoutMS = 0 /* Metadata: 0x00766969 */); // 0x00000001813FC6C0-0x00000001813FC7B0
		public static ThreadHelper CreateFixedTimeStep(int timeStepFPS, int timeoutMS = 0 /* Metadata: 0x0076696D */); // 0x00000001813FC650-0x00000001813FC6C0
		public static ThreadHelper CreateFixedTimeStep(int timeStepFPS, bool useHighPrecisionTimer = false /* Metadata: 0x00766971 */, int timeoutMS = 0 /* Metadata: 0x00766972 */); // 0x00000001813FC5D0-0x00000001813FC650
		public bool Start(bool wait); // 0x00000001813FCCE0-0x00000001813FCE30
		public void Stop(bool wait); // 0x00000001813FCE30-0x00000001813FD010
		public bool EnqueueAction(Action action); // 0x00000001813FC8F0-0x00000001813FCA30
		public bool InvokeActionSync(Action action); // 0x00000001813FCB90-0x00000001813FCBD0
		public void WaitForActionQueueToFinish(); // 0x00000001813FD010-0x00000001813FD1E0
		public void ResetTimeout(); // 0x00000001813FCC90-0x00000001813FCCE0
		private void kKSVTjtddAMHJluEODRtunpFBngb(); // 0x00000001813FD7B0-0x00000001813FDE60
		private void WeZwFgEsvVCMUMEuZbModzyyPsDT(); // 0x00000001813FD1E0-0x00000001813FD360
		private void xKfhMAjRMTJNkkhhxGNZLpQxWCs(); // 0x00000001813FE060-0x00000001813FE140
		private void iSQfPOuvmRjCJIOfvTnBxpTaZSb(); // 0x00000001813FD6D0-0x00000001813FD7A0
		public void Dispose(); // 0x00000001813FC7B0-0x00000001813FC810
		~ThreadHelper(); // 0x00000001813FCA30-0x00000001813FCAC0
		protected void Dispose(bool disposing); // 0x00000001813FC810-0x00000001813FC8F0
		[Conditional] // 0x00000001801D9290-0x00000001801D92C0
		private static void jTweAqDZThMkNjABOhuheMWIYxB(object param_0000f5eb); // 0x00000001813FD7A0-0x00000001813FD7B0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public sealed class InputMapper // TypeDefIndex: 6539
	{
		// Fields
		private static InputMapper DqYmGHECTlrDVQmfbrCSLOJGmsK; // 0x00
		private static int opOBHHseJkiuPTdqFxSPSFfBWwf; // 0x08
		private readonly int FeoFxBhvrqWrLlBecgmLnkpVHMiD; // 0x10
		private readonly bool LjPoycpcPSUbvwRTdkQajYjpFii; // 0x14
		private readonly tFToRgKlKSlWZGnYNcaZgcDXmAB FUdqWTUGhUBvKdECFktkLieEvKa; // 0x18
		private Options UkVnIfKaisHxULJaXHVDCMWuCPK; // 0x20
		private readonly Dictionary<MlZDdRIGUtZScPcHMvprNBhQCkt, SafeDelegate> dRHDBhOgBmQfHvZJblYfKVxrObH; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> oYBpUPtIotQpZlmyBzHgqIPdpVq; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> GmIYhGBcpMMCirEvOkwMHZBRaFg; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> nYlBBJwwcVkZtIQVFuIuqjeIcsK; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> CWjBcSiUYzmlMwepxVNqomArHSvB; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> gTLlTiQHUPsbMkAVANpjXDMPLlI; // 0x30
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> TjGEBsHFMVCHUCaUrhTtAyNgOuoQ; // 0x38
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> MTpUSWdtwFfJQssYigamHIUInVb; // 0x40
	
		// Properties
		public static InputMapper Default { get; } // 0x000000018048CF50-0x000000018048D000 
		public Options options { get; set; } // 0x000000018048D040-0x000000018048D1F0 0x000000018036AC90-0x000000018036ACA0
		public Context mappingContext { get; } // 0x000000018048D000-0x000000018048D040 
		public Status status { get; } // 0x000000018048D1F0-0x000000018048D210 
		public float timeRemaining { get; } // 0x000000018048D210-0x000000018048D230 
		internal int id { get; } // 0x000000018036CFF0-0x000000018036D000 
	
		// Events
		public event Action<InputMappedEventData> InputMappedEvent {
			add; // 0x000000018048CBB0-0x000000018048CCB0
			remove; // 0x000000018048D5A0-0x000000018048D6A0
		}
		public event Action<ErrorEventData> ErrorEvent {
			add; // 0x000000018048CAD0-0x000000018048CBB0
			remove; // 0x000000018048D490-0x000000018048D5A0
		}
		public event Action<CanceledEventData> CanceledEvent {
			add; // 0x000000018048C920-0x000000018048CA10
			remove; // 0x000000018048D2F0-0x000000018048D3D0
		}
		public event Action<TimedOutEventData> TimedOutEvent {
			add; // 0x000000018048CE30-0x000000018048CEF0
			remove; // 0x000000018048D820-0x000000018048D8E0
		}
		public event Action<StartedEventData> StartedEvent {
			add; // 0x000000018048CCB0-0x000000018048CD70
			remove; // 0x000000018048D6A0-0x000000018048D760
		}
		public event Action<StoppedEventData> StoppedEvent {
			add; // 0x000000018048CD70-0x000000018048CE30
			remove; // 0x000000018048D760-0x000000018048D820
		}
		public event Action<ConflictFoundEventData> ConflictFoundEvent {
			add; // 0x000000018048CA10-0x000000018048CAD0
			remove; // 0x000000018048D3D0-0x000000018048D490
		}
	
		// Nested types
		public class Context // TypeDefIndex: 6540
		{
			// Fields
			private int cjzdzLwOcjfmOCBkTzQRGkafOqG; // 0x10
			private ControllerMap RNrniZeIkGmMkeqZsCLNgsdrTfDu; // 0x18
			private ActionElementMap qBdQEHneVxyZRHnVzEDsbnVpgmaK; // 0x20
			private AxisRange SxOrufySjIQLzwPpmoMtAANjBBz; // 0x28
			private bool wKnBnddjnLGpvWTmfpNbnnIJgPbb; // 0x2C
	
			// Properties
			public int actionId { get; set; } // 0x000000018036CFF0-0x000000018036D000 0x0000000180480C80-0x0000000180480D00
			public string actionName { get; set; } // 0x0000000180480B80-0x0000000180480C10 0x0000000180480D00-0x0000000180480E60
			public ControllerMap controllerMap { get; set; } // 0x000000018038B150-0x000000018038B160 0x0000000180480EC0-0x0000000180480F20
			public ActionElementMap actionElementMapToReplace { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x0000000180480C20-0x0000000180480C80
			public AxisRange actionRange { get; set; } // 0x000000018038E0E0-0x000000018038E0F0 0x0000000180480E60-0x0000000180480EC0
	
			// Constructors
			public Context(); // 0x0000000180480B10-0x0000000180480B30
			private Context(Context source); // 0x0000000180480A20-0x0000000180480B10
	
			// Methods
			public Context Clone(); // 0x0000000180480820-0x0000000180480930
			internal void jYXfovrYDfhplaJjSKFtvcyiTsg(); // 0x0000000180480C10-0x0000000180480C20
			private bool gFugBsBBwnwfRrzPDrRopxyxMahP(); // 0x0000000180480B30-0x0000000180480B80
			public static void Copy(Context source, Context destination); // 0x0000000180480930-0x0000000180480A20
		}
	
		public enum ConflictResponse // TypeDefIndex: 6541
		{
			Cancel = 0,
			Replace = 1,
			Add = 2,
			Ignore = 3
		}
	
		public abstract class EventData // TypeDefIndex: 6542
		{
			// Fields
			public readonly InputMapper inputMapper; // 0x10
	
			// Constructors
			internal EventData(InputMapper inputMapper); // 0x000000018037D3F0-0x000000018037D420
		}
	
		public class InputMappedEventData : EventData // TypeDefIndex: 6543
		{
			// Fields
			public readonly ActionElementMap actionElementMap; // 0x18
	
			// Constructors
			internal InputMappedEventData(InputMapper mapper, ActionElementMap actionElementMap); // 0x00000001803DA900-0x00000001803DA940
		}
	
		public class CanceledEventData : EventData // TypeDefIndex: 6544
		{
			// Fields
			public readonly string message; // 0x18
	
			// Constructors
			internal CanceledEventData(InputMapper mapper, string message); // 0x00000001803DA900-0x00000001803DA940
		}
	
		public class ErrorEventData : EventData // TypeDefIndex: 6545
		{
			// Fields
			public readonly string message; // 0x18
	
			// Constructors
			internal ErrorEventData(InputMapper mapper, string message); // 0x00000001803DA900-0x00000001803DA940
		}
	
		public class TimedOutEventData : EventData // TypeDefIndex: 6546
		{
			// Constructors
			internal TimedOutEventData(InputMapper mapper); // 0x000000018037D3F0-0x000000018037D420
		}
	
		public class StartedEventData : EventData // TypeDefIndex: 6547
		{
			// Constructors
			internal StartedEventData(InputMapper mapper); // 0x000000018037D3F0-0x000000018037D420
		}
	
		public class StoppedEventData : EventData // TypeDefIndex: 6548
		{
			// Constructors
			internal StoppedEventData(InputMapper mapper); // 0x000000018037D3F0-0x000000018037D420
		}
	
		public class ConflictFoundEventData : EventData // TypeDefIndex: 6549
		{
			// Fields
			public readonly Action<ConflictResponse> responseCallback; // 0x18
			public readonly ElementAssignmentInfo assignment; // 0x20
			public readonly IList<ElementAssignmentConflictInfo> conflicts; // 0x28
			public readonly bool isProtected; // 0x30
	
			// Constructors
			internal ConflictFoundEventData(InputMapper mapper, Action<ConflictResponse> responseCallback, ElementAssignmentInfo assignment, IList<ElementAssignmentConflictInfo> conflicts, bool isProtected); // 0x00000001804807C0-0x0000000180480820
		}
	
		private enum MlZDdRIGUtZScPcHMvprNBhQCkt // TypeDefIndex: 6550
		{
			MmEFZJFHhQmcfXTDlVABkcOvmDn = 0,
			LfFbocAeTPRcdZLjKOHnxAMWEpJ = 1,
			iuOmxwSnbPjkYshIfUaDBvyBuLR = 2,
			XGRLZJxEbyYzsbRmapNzHgvRSFG = 3,
			UorMiexUoWrChVbOGBGhEftqiTOF = 4,
			AlwcgMEgFOTFNGrnSoqhtNYSAqg = 5,
			ZFrqZOtROcJuhlJAujNyNnNLDJtg = 6
		}
	
		public enum Status // TypeDefIndex: 6551
		{
			Idle = 0,
			Listening = 1,
			AwaitingResponse = 2
		}
	
		private class tFToRgKlKSlWZGnYNcaZgcDXmAB // TypeDefIndex: 6552
		{
			// Fields
			private readonly InputMapper PdhGYsFKOBEfRexHgTcxFTVoRup; // 0x10
			private readonly Options UkVnIfKaisHxULJaXHVDCMWuCPK; // 0x18
			private readonly AjAhIGttduGHijjBoUQQJwNFSNF qAWBfCUylfvjpaBoYORwHWHtEur; // 0x20
			private readonly Dictionary<MlZDdRIGUtZScPcHMvprNBhQCkt, SafeDelegate> dRHDBhOgBmQfHvZJblYfKVxrObH; // 0x28
			private readonly Dictionary<string, SafeDelegate> rcwrnwEzBvUpkFVZeEhnWqpZSss; // 0x30
			private Status egZseKiVnPHgfhjbzgKjgszxdwnb; // 0x38
			private nuURDKnoeWYysAiGUcCuhZwMnTc TBbkMvJcaPDFWtbduTqYMGmhYMo; // 0x3C
			private float hiNQNqdOtHYBhVZibpwRUsJJyGU; // 0x40
			private bool JuOFjzRkYuDstIuGjgxZUqWRewOV; // 0x44
			private List<Player> NdqRcsJwjlNcXDhcYrMhgdVRrvt; // 0x48
			private readonly List<ControllerPollingInfo> mAvILkJZgIwXlLPpNPjnIExbUpCH; // 0x50
			private ElementAssignment DEqzNNYBhMsQUneRKbXtqEOOaaO; // 0x58
	
			// Properties
			public Status PCFpBFutvFenwXMFHSFlIQYKAfm { get; } // 0x00000001804999D0-0x00000001804999E0 
			public float OjnboEIXbCOMoOgaEBCLSbywdqms { get; } // 0x00000001804999E0-0x0000000180499AD0 
			public Context DyxnimTkCxFztDAUeUGvaOsoNvGM { get; } // 0x00000001804999A0-0x00000001804999D0 
			private bool UKzpgnOXNRhJuQfRRZjPKwlWGyz { get; } // 0x0000000180499960-0x00000001804999A0 
	
			// Nested types
			private enum QVHCAulbBuKwohfufSTKbINweVi // TypeDefIndex: 6553
			{
				nnsHcHBOuBtpDqLdPuYxiGpucPB = 0,
				tRNhuUCDPvFMtZcovsMapbJzmCO = 1
			}
	
			private enum nuURDKnoeWYysAiGUcCuhZwMnTc // TypeDefIndex: 6554
			{
				PoBZZNoYGVGuWkUBxQqhGBhFqWy = 0,
				zJJaNpvrPQFECsQsivwBcHccLmz = 1
			}
	
			private class AjAhIGttduGHijjBoUQQJwNFSNF // TypeDefIndex: 6555
			{
				// Fields
				private Player ynTKxtAzNzOSGMpUVXFSwhkyvv; // 0x10
				private int cjzdzLwOcjfmOCBkTzQRGkafOqG; // 0x18
				private Context zIsDmpBbtAbGtEngJIcXXYXltMWp; // 0x20
				private ControllerType jVRvmdSGLvngKifezJIAQbIZrmi; // 0x28
				private int tiHDqwuWnAypLNJNoTzBctdWRZt; // 0x2C
				private ControllerPollingInfo zYudegFGYpfRFbJPhkwZmJNayQuC; // 0x30
				private ModifierKeyFlags WyYzmoHdRbnuKAzTWBtVuJIIols; // 0x68
	
				// Properties
				public Player yHWXapLnjMXUYBDESFaAUIdnziK { get; } // 0x000000018036AC80-0x000000018036AC90 
				public int OQcyWgBmnPWCLAcqVAqEsHoBwiC { get; } // 0x0000000180367710-0x0000000180367720 
				public Context QNycFmvnKcoUfGYDAghVcKMXHuQ { get; } // 0x000000018036AC70-0x000000018036AC80 
				public ControllerType CGckBVNLLRbsxHptZVYgQLPSxKH { get; } // 0x000000018038E0E0-0x000000018038E0F0 
				public int AkkOxeFFauQvLEuBcHkzXcxVDoLa { get; } // 0x000000018038E0D0-0x000000018038E0E0 
				public ControllerPollingInfo PJEAaAfwsJsBxlCAaiKyfPkkDXV { get; } // 0x0000000180480410-0x0000000180480440 
				public ModifierKeyFlags RgontomKqhXdwuPoWxcvUvVwbRm { get; } // 0x00000001803DAC60-0x00000001803DAC70 
				public AxisRange AxikYLhruiOSODJDsEJYTOGYrus { get; } // 0x00000001804800B0-0x0000000180480180 
				public string OEBQtXdKPjceipvIJipFBPbMcniS { get; } // 0x0000000180480180-0x0000000180480410 
	
				// Constructors
				public AjAhIGttduGHijjBoUQQJwNFSNF(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public void ItdhavHGXcUkAhyjaCFbIXENJheh(Player param_0000dc78, Context param_0000dc79); // 0x000000018047FD30-0x000000018047FEE0
				public void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x0000000180480440-0x00000001804804A0
				public ElementAssignment JMPRkrDiidDTjuwUjIXdRGHFjPb(ControllerPollingInfo param_0000dc7a); // 0x000000018047FEE0-0x000000018047FF40
				public ElementAssignment JMPRkrDiidDTjuwUjIXdRGHFjPb(ControllerPollingInfo param_0000dc7b, ModifierKeyFlags param_0000dc7c); // 0x0000000180480050-0x00000001804800B0
				public ElementAssignment JMPRkrDiidDTjuwUjIXdRGHFjPb(); // 0x000000018047FF40-0x0000000180480050
			}
	
			// Constructors
			public tFToRgKlKSlWZGnYNcaZgcDXmAB(InputMapper parent, Dictionary<MlZDdRIGUtZScPcHMvprNBhQCkt, SafeDelegate> events); // 0x0000000180498F20-0x0000000180499080
	
			// Methods
			~tFToRgKlKSlWZGnYNcaZgcDXmAB(); // 0x0000000180496500-0x0000000180496590
			public void JHzUZUsFQTvSmWjmIewXSnYsiSq(Context param_0000dc41, Options param_0000dc42); // 0x0000000180496680-0x0000000180496B80
			public void BXLwvwEIiTSSpiqsTXeFeyiNydA(string param_0000dc43); // 0x0000000180495EB0-0x0000000180495EC0
			private void MrPMknIMZzaXDjcXZFUzCeTcWDAs(UpdateLoopType param_0000dc44); // 0x00000001804976B0-0x0000000180497C40
			private void AGASRXthoscAbPvuERLUlyaRAws(); // 0x0000000180495E40-0x0000000180495EB0
			private void UoMHNaNPthiGlAUrLPIFatCuFSe(); // 0x0000000180498520-0x0000000180498610
			private QVHCAulbBuKwohfufSTKbINweVi bCkYPKTEYQDjkrBzXZPrDsSzfAc(out ElementAssignment param_0000dc45); // 0x0000000180499140-0x0000000180499710
			private bool lngezBDAJNlfbLzscckekTIvgzL(out IEnumerable<ControllerPollingInfo> param_0000dc46, out ModifierKeyFlags param_0000dc47); // 0x0000000180499B60-0x000000018049A170
			private IEnumerable<ControllerPollingInfo> mTXQvVovaHOXSeEVaPnffwDSYHR(out ModifierKeyFlags param_0000dc48); // 0x000000018049A530-0x000000018049A720
			private ControllerPollingInfo MlzjzvauDzOhkqLXNkyNGgHNkHt(Options param_0000dc49, out ModifierKeyFlags param_0000dc4a); // 0x0000000180496C00-0x0000000180496D20
			private static ControllerPollingInfo MlzjzvauDzOhkqLXNkyNGgHNkHt(Options param_0000dc4b, out bool param_0000dc4c, out ModifierKeyFlags param_0000dc4d, out string param_0000dc4e); // 0x0000000180496D20-0x00000001804976B0
			private static bool TGkGTNQktnilNAwOqlKPzrkLKZb(ControllerPollingInfo param_0000dc4f, Options param_0000dc50); // 0x0000000180498340-0x0000000180498520
			private static bool GUraTFbTKHxLGQDLARPJPNBUMJCF(AjAhIGttduGHijjBoUQQJwNFSNF param_0000dc51, ControllerPollingInfo param_0000dc52, Options param_0000dc53); // 0x0000000180496590-0x00000001804965E0
			private void qdAikkZAMUWXkqTDfjmZdqdoZFK(); // 0x000000018049ACD0-0x000000018049B140
			private QVHCAulbBuKwohfufSTKbINweVi yJOokDABwVxGMjhSkEEdQJFCCeT(ElementAssignment param_0000dc54); // 0x000000018049B390-0x000000018049B6B0
			private static bool CuUMVeEBqxETUGMohBNXVaBfkfnp(AjAhIGttduGHijjBoUQQJwNFSNF param_0000dc55, ElementAssignment param_0000dc56, List<Player> param_0000dc57); // 0x0000000180496070-0x0000000180496300
			private static bool oNQVtQiiPOrqxGHJMEOqKQuZjiPo(AjAhIGttduGHijjBoUQQJwNFSNF param_0000dc58, ElementAssignment param_0000dc59, List<Player> param_0000dc5a); // 0x000000018049A7C0-0x000000018049ACD0
			private static IList<ElementAssignmentConflictInfo> ZYEfQbSEthQoQFglHyoEjZrtuqp(AjAhIGttduGHijjBoUQQJwNFSNF param_0000dc5b, ElementAssignment param_0000dc5c, List<Player> param_0000dc5d); // 0x0000000180498A90-0x0000000180498F20
			private static bool cmTmXsPdDggToIjzpjYTbYHBjAMX(AjAhIGttduGHijjBoUQQJwNFSNF param_0000dc5e, ElementAssignment param_0000dc5f, out ElementAssignmentConflictCheck param_0000dc60); // 0x0000000180499710-0x00000001804998B0
			private static void WjCYeZhDvSvxKcQpcKOBJaKPtus(AjAhIGttduGHijjBoUQQJwNFSNF param_0000dc61, ElementAssignment param_0000dc62, List<Player> param_0000dc63); // 0x0000000180498680-0x00000001804988D0
			private void YBGnhLIAfSlHZLSMzgJcpbRSkFl(); // 0x00000001804988D0-0x0000000180498990
			private void inCcrRExDshyOoYwBZiFDCTZGBy(); // 0x0000000180499AD0-0x0000000180499B60
			private bool JuSaAYLuCkHqOlFCoIySHSjofunY(MlZDdRIGUtZScPcHMvprNBhQCkt param_0000dc64); // 0x0000000180496B80-0x0000000180496C00
			private void eKfLtIQtyipducYocpkuFFglmiz<T>(MlZDdRIGUtZScPcHMvprNBhQCkt param_0000dc65, T param_0000dc66);
			private void VRkInhuBwWwrNrPgyGHyDVpyDuxR(); // 0x0000000180498610-0x0000000180498680
			private void RBtjWbgEfvMJJdmuOZnqKPNoFNS(); // 0x00000001804981F0-0x0000000180498200
			private void YVGcgXCZEeEEezSjyHHOlijcbjR(ActionElementMap param_0000dc67); // 0x0000000180498990-0x0000000180498A90
			private void DBCCivHLhpUwCdvqiZeXKhMdLWh(string param_0000dc68); // 0x0000000180496300-0x0000000180496400
			private QVHCAulbBuKwohfufSTKbINweVi mJEMSDEOqJelIdAckQxbWWyuDyfN(ElementAssignment param_0000dc69); // 0x000000018049A170-0x000000018049A530
			private QVHCAulbBuKwohfufSTKbINweVi OIWKurDixFFcRGSNGtidEQekOdKs(ConflictResponse param_0000dc6a, ElementAssignment param_0000dc6b); // 0x0000000180497D10-0x0000000180497DA0
			private QVHCAulbBuKwohfufSTKbINweVi OIWKurDixFFcRGSNGtidEQekOdKs(ConflictResponse param_0000dc6c, ElementAssignment param_0000dc6d, bool param_0000dc6e); // 0x0000000180497DA0-0x0000000180498150
			private void yudbcuSIhPYLFjYWcLVKoiphvTM(); // 0x000000018049B6B0-0x000000018049B7D0
			private void DigEICdNKFcLQcMMQnNuGyVyaubk(string param_0000dc6f); // 0x0000000180496400-0x0000000180496500
			private void ODzuiatjXuCuviZpfFNOOIZGprvE(); // 0x0000000180497C40-0x0000000180497D10
			private void RUDfCgekHcgAputZrzNabpnpHzxD(); // 0x0000000180498200-0x0000000180498280
			private void BqBsVfEMnomqLAGoeIRtkzKfwVn(ElementAssignment param_0000dc70); // 0x0000000180495EC0-0x0000000180496070
			private void oKkDKXTQvvZYpRkUeWWEcdWNIOs(ActionElementMap param_0000dc71); // 0x000000018049A720-0x000000018049A7C0
			private void apVnrkjNwYgcGKFCtgHQGtkSMDle(); // 0x0000000180499080-0x0000000180499140
			private void HCJvJuZHNEBfhsXRocWIPFjHzLV(string param_0000dc72); // 0x00000001804965E0-0x0000000180496680
			private void dYxWzvsVguaVfgDIpqCWNUBZcID(string param_0000dc73); // 0x00000001804998B0-0x0000000180499960
			private void rTirlZRigFaTrfkbyjBkmJsCdGAE(ElementAssignmentInfo param_0000dc74, IList<ElementAssignmentConflictInfo> param_0000dc75, bool param_0000dc76); // 0x000000018049B140-0x000000018049B230
			private void RXBxalwWJsFQzWPVwCHxQUnmHdT(); // 0x0000000180498280-0x0000000180498340
			private void QYLfScPgOIyybiJNApxsvnKGOKQ(); // 0x0000000180498150-0x00000001804981F0
			public void vhjXagDioNFESXUfrXwAinEVHrX(ConflictResponse param_0000dc77); // 0x000000018049B230-0x000000018049B390
		}
	
		public class Options // TypeDefIndex: 6556
		{
			// Fields
			internal const string YNhaUZiTfaIgKxuhFAoHGXsBpJEK = "isElementAllowed"; // Metadata: 0x007301DC
			private bool dBasdtrcRywCygDiKJdCIpJBheoE; // 0x10
			private bool pktXvsiXxgjqdTXHyEpNoWoVHwJ; // 0x11
			private bool vggTxHfUufioTxNKdkOguryKdls; // 0x12
			private float KsihvWHnqPQVTsmmnFSDGGFjaXnu; // 0x14
			private bool xyLNXfKogTABXLuIpSdaRxvzakg; // 0x18
			private bool JOtFskeeZGJUjwWgQxOTvvrFhSXo; // 0x19
			private bool TqtsDXuSKFVoErDnCsKLgNfZVWt; // 0x1A
			private bool DNlEOnmIIryoZlfFFamkJIPhlCbE; // 0x1B
			private int[] ZxbwCzpHUJgnmrVTitCQOyGqjBh; // 0x20
			private ConflictResponse zFhvHzyCBpEiEqfQPUgudcerDAhB; // 0x28
			private bool ekRBSgGDWDcGmufdTAmsrrVIZYne; // 0x2C
			private bool OaNmsCmqtCWUzqKbZKnkbTxbinS; // 0x2D
			private bool AxpxodXqCsfvjeLtTxlBLBYSAHzv; // 0x2E
			private bool ZzJmBsgtNUYwyOXByZhyTVeVMRF; // 0x2F
			private float ulugqHJvrxAbqcJfRGljEPtdSmnJ; // 0x30
			private readonly Dictionary<string, SafeDelegate> rcwrnwEzBvUpkFVZeEhnWqpZSss; // 0x38
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Action<Exception> USlXdSBXnlfvXVVTMURFbvmMbBc; // 0x00
	
			// Properties
			public bool allowAxes { get; set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
			public bool allowButtons { get; set; } // 0x0000000180375550-0x0000000180375560 0x0000000180393640-0x0000000180393650
			public bool allowButtonsOnFullAxisAssignment { get; set; } // 0x000000018036CB60-0x000000018036CB70 0x000000018036CC30-0x000000018036CC40
			public float timeout { get; set; } // 0x000000018048F530-0x000000018048F540 0x000000018048F6C0-0x000000018048F6E0
			public bool checkForConflicts { get; set; } // 0x000000018041BAC0-0x000000018041BAD0 0x000000018048F590-0x000000018048F5A0
			public bool checkForConflictsWithAllPlayers { get; set; } // 0x000000018048F440-0x000000018048F450 0x000000018048F560-0x000000018048F570
			public bool checkForConflictsWithSelf { get; set; } // 0x000000018048F450-0x000000018048F460 0x000000018048F570-0x000000018048F580
			public bool checkForConflictsWithSystemPlayer { get; set; } // 0x000000018048F460-0x000000018048F470 0x000000018048F580-0x000000018048F590
			public int[] checkForConflictsWithPlayerIds { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
			public ConflictResponse defaultActionWhenConflictFound { get; set; } // 0x000000018038E0E0-0x000000018038E0F0 0x000000018036B790-0x000000018036B7A0
			public bool ignoreMouseXAxis { get; set; } // 0x0000000180488600-0x0000000180488610 0x0000000180488610-0x0000000180488620
			public bool ignoreMouseYAxis { get; set; } // 0x000000018048F470-0x000000018048F480 0x000000018048F5C0-0x000000018048F5D0
			public bool allowKeyboardKeysWithModifiers { get; set; } // 0x000000018048F420-0x000000018048F430 0x000000018048F540-0x000000018048F550
			public bool allowKeyboardModifierKeyAsPrimary { get; set; } // 0x000000018048F430-0x000000018048F440 0x000000018048F550-0x000000018048F560
			public float holdDurationToMapKeyboardModifierKeyAsPrimary { get; set; } // 0x0000000180485990-0x00000001804859A0 0x000000018048F5A0-0x000000018048F5C0
			public Predicate<ControllerPollingInfo> isElementAllowedCallback { get; set; } // 0x000000018048F480-0x000000018048F530 0x000000018048F5D0-0x000000018048F6C0
	
			// Constructors
			public Options(); // 0x000000018048F360-0x000000018048F420
			private Options(Options source); // 0x000000018048F260-0x000000018048F360
	
			// Methods
			internal T lRkegFMlGRwRJBayxACmeEBUdsJ<T>(string param_0000dc8d)
				where T : SafeDelegate;
			public Options Clone(); // 0x000000018048E860-0x000000018048E990
			public override string ToString(); // 0x000000018048ED50-0x000000018048F260
			internal void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x000000018048F6E0-0x000000018048F9E0
			public static void Copy(Options source, Options destination); // 0x000000018048E990-0x000000018048ECF0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static void HIWENDmrdRdtEplYoZrJumOqLPa(Exception param_0000dc91); // 0x000000018048ECF0-0x000000018048ED50
		}
	
		// Constructors
		public InputMapper(); // 0x000000018048C7A0-0x000000018048C920
		private InputMapper(bool isDefault); // 0x000000018048BFD0-0x000000018048C7A0
		static InputMapper(); // 0x000000018048BF90-0x000000018048BFD0
	
		// Methods
		private static int whuCWRHtUuaRrnNGmdillFWWQzKa(); // 0x000000018048D9A0-0x000000018048DA90
		public void RemoveEventListeners(object listenerOrParent); // 0x000000018048BC90-0x000000018048BE40
		public void RemoveAllEventListeners(); // 0x000000018048BB20-0x000000018048BC90
		internal void xVDRaZExjvXwxInuklypmYiqskE(object param_0000dc1d); // 0x00000001803581E0-0x00000001803581F0
		internal void RNkBwBdsVZpQPGrdBoekxOOmLqBx(); // 0x00000001803581E0-0x00000001803581F0
		public bool Start(Context mappingContext); // 0x000000018048BE40-0x000000018048BED0
		public void Stop(); // 0x000000018048BED0-0x000000018048BF30
		public void Clear(); // 0x000000018048B860-0x000000018048B8F0
		private bool JHzUZUsFQTvSmWjmIewXSnYsiSq(Context param_0000dc1f, Options param_0000dc20); // 0x000000018048B8F0-0x000000018048BAC0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void nKBfZOoSRNcWGVmXsGDbjHqfeFdg(Exception param_0000dc21); // 0x000000018048D230-0x000000018048D290
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void QCnBhbrcMfEzZgtusefqogRXgSm(Exception param_0000dc22); // 0x000000018048BAC0-0x000000018048BB20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void duLhsEnrjkGDDwuCgfSCCWjnKgSn(Exception param_0000dc23); // 0x000000018048CEF0-0x000000018048CF50
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void WAUAEupZrGtxBDFwxBMrGLgbpheC(Exception param_0000dc24); // 0x000000018048BF30-0x000000018048BF90
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void qFokFxPuLlKEeQtuzioYbpTyKhQ(Exception param_0000dc25); // 0x000000018048D290-0x000000018048D2F0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void uSEzyJAsfYEgkEIIZypMIYItiji(Exception param_0000dc26); // 0x000000018048D940-0x000000018048D9A0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void sHLnowayslNERUCHckPNeNeJjCXd(Exception param_0000dc27); // 0x000000018048D8E0-0x000000018048D940
	}
}


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation. Tutti i diritti riservati.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly extern System
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly extern xunit.core
{
  .publickeytoken = (8D 05 B1 BB 7A 6F DB 6C )                         // ....zo.l
  .ver 2:9:0:0
}
.assembly extern xunit.abstractions
{
  .publickeytoken = (8D 05 B1 BB 7A 6F DB 6C )                         // ....zo.l
  .ver 2:0:0:0
}
.assembly extern xunit.execution.desktop
{
  .publickeytoken = (8D 05 B1 BB 7A 6F DB 6C )                         // ....zo.l
  .ver 2:9:0:0
}
.assembly extern System.Runtime.InteropServices.RuntimeInformation
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 4:0:1:0
}
.assembly extern System.Core
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Microsoft.DotNet.XUnitExtensions
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.ExtensionAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 36 2E 32 01   // ,Version=v4.6.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 36 2E 32 )          // amework 4.6.2
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 15 4D 69 63 72 6F 73 6F 66 74 20 43 6F 72   // ...Microsoft Cor
                                                                                                70 6F 72 61 74 69 6F 6E 00 00 )                   // poration..
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 07 52 65 6C 65 61 73 65 00 00 )             // ...Release..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 2E C2 A9 20 4D 69 63 72 6F 73 6F 66 74 20   // ..... Microsoft 
                                                                                                  43 6F 72 70 6F 72 61 74 69 6F 6E 2E 20 41 6C 6C   // Corporation. All
                                                                                                  20 72 69 67 68 74 73 20 72 65 73 65 72 76 65 64   //  rights reserved
                                                                                                  2E 00 00 )                                        // ...
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 7E 54 68 69 73 20 70 61 63 6B 61 67 65 20   // ..~This package 
                                                                                                    70 72 6F 76 69 64 65 73 20 74 68 69 6E 67 73 20   // provides things 
                                                                                                    6C 69 6B 65 20 76 61 72 69 6F 75 73 20 74 72 61   // like various tra
                                                                                                    69 74 73 20 61 6E 64 20 64 69 73 63 6F 76 65 72   // its and discover
                                                                                                    73 20 6C 69 6B 65 20 4F 75 74 65 72 4C 6F 6F 70   // s like OuterLoop
                                                                                                    2F 41 63 74 69 76 65 49 73 73 75 65 20 74 68 61   // /ActiveIssue tha
                                                                                                    74 20 61 72 65 20 75 73 65 64 20 62 79 20 2E 4E   // t are used by .N
                                                                                                    45 54 20 74 65 73 74 20 70 72 6F 6A 65 63 74 73   // ET test projects
                                                                                                    2E 00 00 )                                        // ...
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 0D 31 30 2E 30 2E 32 34 2E 34 36 33 30 36   // ...10.0.24.46306
                                                                                                    00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 3C 31 30 2E 30 2E 30 2D 62 65 74 61 2E 32   // ..<10.0.0-beta.2
                                                                                                             34 34 36 33 2E 36 2B 62 64 37 34 39 61 31 38 64   // 4463.6+bd749a18d
                                                                                                             64 37 32 62 38 66 63 62 35 32 35 37 61 65 30 31   // d72b8fcb5257ae01
                                                                                                             61 34 66 61 66 36 64 64 34 38 37 63 63 35 66 00   // a4faf6dd487cc5f.
                                                                                                             00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 20 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // .. Microsoft.Dot
                                                                                                4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                                6F 6E 73 00 00 )                                  // ons..
  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 20 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // .. Microsoft.Dot
                                                                                              4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                              6F 6E 73 00 00 )                                  // ons..
  .custom instance void [mscorlib]System.Reflection.AssemblyMetadataAttribute::.ctor(string,
                                                                                     string) = ( 01 00 0D 52 65 70 6F 73 69 74 6F 72 79 55 72 6C   // ...RepositoryUrl
                                                                                                 20 68 74 74 70 73 3A 2F 2F 67 69 74 68 75 62 2E   //  https://github.
                                                                                                 63 6F 6D 2F 64 6F 74 6E 65 74 2F 61 72 63 61 64   // com/dotnet/arcad
                                                                                                 65 00 00 )                                        // e..
  .custom instance void [mscorlib]System.Resources.NeutralResourcesLanguageAttribute::.ctor(string) = ( 01 00 05 65 6E 2D 55 53 00 00 )                   // ...en-US..
  .publickey = (00 24 00 00 04 80 00 00 94 00 00 00 06 02 00 00   // .$..............
                00 24 00 00 52 53 41 31 00 04 00 00 01 00 01 00   // .$..RSA1........
                B5 FC 90 E7 02 7F 67 87 1E 77 3A 8F DE 89 38 C8   // ......g..w:...8.
                1D D4 02 BA 65 B9 20 1D 60 59 3E 96 C4 92 65 1E   // ....e. .`Y>...e.
                88 9C C1 3F 14 15 EB B5 3F AC 11 31 AE 0B D3 33   // ...?....?..1...3
                C5 EE 60 21 67 2D 97 18 EA 31 A8 AE BD 0D A0 07   // ..`!g-...1......
                2F 25 D8 7D BA 6F C9 0F FD 59 8E D4 DA 35 E4 4C   // /%.}.o...Y...5.L
                39 8C 45 43 07 E8 E3 3B 84 26 14 3D AE C9 F5 96   // 9.EC...;.&.=....
                83 6F 97 C8 F7 47 50 E5 97 5C 64 E2 18 9F 45 DE   // .o...GP..\d...E.
                F4 6B 2A 2B 12 47 AD C3 65 2B F5 C3 08 05 5D A9 ) // .k*+.G..e+....].
  .hash algorithm 0x00008004
  .ver 10:0:0:0
}
.module Microsoft.DotNet.XUnitExtensions.dll
// MVID: {93626FC4-9B0A-4B23-8E41-DC0130820EDB}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000009    //  ILONLY
// Image base: 0x054C0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.NullableAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 84 6B 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ...k....T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly uint8[] NullableFlags
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(uint8 A_1) cil managed
  {
    // Code size       23 (0x17)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldc.i4.1
    IL_0008:  newarr     [mscorlib]System.Byte
    IL_000d:  dup
    IL_000e:  ldc.i4.0
    IL_000f:  ldarg.1
    IL_0010:  stelem.i1
    IL_0011:  stfld      uint8[] System.Runtime.CompilerServices.NullableAttribute::NullableFlags
    IL_0016:  ret
  } // end of method NullableAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(uint8[] A_1) cil managed
  {
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldarg.1
    IL_0008:  stfld      uint8[] System.Runtime.CompilerServices.NullableAttribute::NullableFlags
    IL_000d:  ret
  } // end of method NullableAttribute::.ctor

} // end of class System.Runtime.CompilerServices.NullableAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.NullableContextAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 4C 14 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ..L.....T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly uint8 Flag
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(uint8 A_1) cil managed
  {
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldarg.1
    IL_0008:  stfld      uint8 System.Runtime.CompilerServices.NullableContextAttribute::Flag
    IL_000d:  ret
  } // end of method NullableContextAttribute::.ctor

} // end of class System.Runtime.CompilerServices.NullableContextAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldarg.1
    IL_0008:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000d:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class private auto ansi sealed beforefieldinit System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembersAttribute
       extends [mscorlib]System.Attribute
{
  .field private initonly valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes '<MemberTypes>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes memberTypes) cil managed
  {
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldarg.1
    IL_0008:  stfld      valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembersAttribute::'<MemberTypes>k__BackingField'
    IL_000d:  ret
  } // end of method DynamicallyAccessedMembersAttribute::.ctor

  .method public hidebysig specialname instance valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes 
          get_MemberTypes() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembersAttribute::'<MemberTypes>k__BackingField'
    IL_0006:  ret
  } // end of method DynamicallyAccessedMembersAttribute::get_MemberTypes

  .property instance valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes
          MemberTypes()
  {
    .get instance valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembersAttribute::get_MemberTypes()
  } // end of property DynamicallyAccessedMembersAttribute::MemberTypes
} // end of class System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembersAttribute

.class private auto ansi sealed System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes
       extends [mscorlib]System.Enum
{
  .field public specialname rtspecialname int32 value__
  .field public static literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes None = int32(0x00000000)
  .field public static literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicParameterlessConstructor = int32(0x00000001)
  .field public static literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicConstructors = int32(0x00000003)
  .field public static literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicConstructors = int32(0x00000004)
  .field public static literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicMethods = int32(0x00000008)
  .field public static literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicMethods = int32(0x00000010)
  .field public static literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicFields = int32(0x00000020)
  .field public static literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicFields = int32(0x00000040)
  .field public static literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicNestedTypes = int32(0x00000080)
  .field public static literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicNestedTypes = int32(0x00000100)
  .field public static literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicProperties = int32(0x00000200)
  .field public static literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicProperties = int32(0x00000400)
  .field public static literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicEvents = int32(0x00000800)
  .field public static literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicEvents = int32(0x00001000)
  .field public static literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes Interfaces = int32(0x00002000)
  .field public static literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes All = int32(0xFFFFFFFF)
} // end of class System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes

.class private auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.ConditionalDiscovererException
       extends [mscorlib]System.Exception
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string message) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       instance void [mscorlib]System.Exception::.ctor(string)
    IL_0007:  ret
  } // end of method ConditionalDiscovererException::.ctor

} // end of class Microsoft.DotNet.XUnitExtensions.ConditionalDiscovererException

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.DesktopTestTraceListener
       extends [System]System.Diagnostics.DefaultTraceListener
{
  .class auto ansi sealed nested private beforefieldinit DebugAssertException
         extends [mscorlib]System.Exception
  {
    .method assembly hidebysig specialname rtspecialname 
            instance void  .ctor(string message,
                                 string detailMessage) cil managed
    {
      // Code size       19 (0x13)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldarg.1
      IL_0002:  call       string [mscorlib]System.Environment::get_NewLine()
      IL_0007:  ldarg.2
      IL_0008:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_000d:  call       instance void [mscorlib]System.Exception::.ctor(string)
      IL_0012:  ret
    } // end of method DebugAssertException::.ctor

  } // end of class DebugAssertException

  .method public hidebysig virtual instance void 
          Fail(string message,
               string detailMessage) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.1
    IL_0001:  ldarg.2
    IL_0002:  newobj     instance void Microsoft.DotNet.XUnitExtensions.DesktopTestTraceListener/DebugAssertException::.ctor(string,
                                                                                                                             string)
    IL_0007:  throw
  } // end of method DesktopTestTraceListener::Fail

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System]System.Diagnostics.DefaultTraceListener::.ctor()
    IL_0006:  ret
  } // end of method DesktopTestTraceListener::.ctor

} // end of class Microsoft.DotNet.XUnitExtensions.DesktopTestTraceListener

.class private abstract auto ansi sealed beforefieldinit Microsoft.DotNet.XUnitExtensions.DiscovererHelpers
       extends [mscorlib]System.Object
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.ExtensionAttribute::.ctor() = ( 01 00 00 00 ) 
  .class auto ansi serializable sealed nested private beforefieldinit '<>c'
         extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field public static initonly class Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<>c' '<>9'
    .method private hidebysig specialname rtspecialname static 
            void  .cctor() cil managed
    {
      // Code size       11 (0xb)
      .maxstack  8
      IL_0000:  newobj     instance void Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<>c'::.ctor()
      IL_0005:  stsfld     class Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<>c' Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<>c'::'<>9'
      IL_000a:  ret
    } // end of method '<>c'::.cctor

    .method public hidebysig specialname rtspecialname 
            instance void  .ctor() cil managed
    {
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ret
    } // end of method '<>c'::.ctor

    .method assembly hidebysig instance bool 
            '<.cctor>b__15_0'() cil managed
    {
      // Code size       17 (0x11)
      .maxstack  8
      IL_0000:  ldstr      "Mono.RuntimeStructs"
      IL_0005:  call       class [mscorlib]System.Type [mscorlib]System.Type::GetType(string)
      IL_000a:  ldnull
      IL_000b:  call       bool [mscorlib]System.Type::op_Inequality(class [mscorlib]System.Type,
                                                                     class [mscorlib]System.Type)
      IL_0010:  ret
    } // end of method '<>c'::'<.cctor>b__15_0'

  } // end of class '<>c'

  .class auto ansi sealed nested private beforefieldinit '<EvaluateArguments>d__13'
         extends [mscorlib]System.Object
         implements class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>,
                    [mscorlib]System.Collections.IEnumerable,
                    class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>,
                    [mscorlib]System.IDisposable,
                    [mscorlib]System.Collections.IEnumerator
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field private int32 '<>1__state'
    .field private valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> '<>2__current'
    .field private int32 '<>l__initialThreadId'
    .field private class [mscorlib]System.Collections.Generic.IEnumerable`1<object> ctorArgs
    .field public class [mscorlib]System.Collections.Generic.IEnumerable`1<object> '<>3__ctorArgs'
    .field private int32 skipFirst
    .field public int32 '<>3__skipFirst'
    .field private string category
    .field public string '<>3__category'
    .method public hidebysig specialname rtspecialname 
            instance void  .ctor(int32 '<>1__state') cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      // Code size       25 (0x19)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ldarg.0
      IL_0007:  ldarg.1
      IL_0008:  stfld      int32 Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>1__state'
      IL_000d:  ldarg.0
      IL_000e:  call       int32 [mscorlib]System.Environment::get_CurrentManagedThreadId()
      IL_0013:  stfld      int32 Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>l__initialThreadId'
      IL_0018:  ret
    } // end of method '<EvaluateArguments>d__13'::.ctor

    .method private hidebysig newslot virtual final 
            instance void  System.IDisposable.Dispose() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.IDisposable::Dispose
      // Code size       1 (0x1)
      .maxstack  8
      IL_0000:  ret
    } // end of method '<EvaluateArguments>d__13'::System.IDisposable.Dispose

    .method private hidebysig newslot virtual final 
            instance bool  MoveNext() cil managed
    {
      .override [mscorlib]System.Collections.IEnumerator::MoveNext
      // Code size       328 (0x148)
      .maxstack  3
      .locals init (int32 V_0,
               valuetype Xunit.TestPlatforms V_1,
               valuetype Xunit.TargetFrameworkMonikers V_2,
               valuetype Xunit.TestRuntimes V_3,
               class [mscorlib]System.Type V_4,
               string[] V_5,
               class [mscorlib]System.Collections.Generic.IEnumerator`1<object> V_6,
               object V_7)
      IL_0000:  ldarg.0
      IL_0001:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>1__state'
      IL_0006:  stloc.0
      IL_0007:  ldloc.0
      IL_0008:  switch     ( 
                            IL_001b,
                            IL_00ff,
                            IL_013f)
      IL_0019:  ldc.i4.0
      IL_001a:  ret

      IL_001b:  ldarg.0
      IL_001c:  ldc.i4.m1
      IL_001d:  stfld      int32 Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>1__state'
      IL_0022:  ldc.i4.m1
      IL_0023:  stloc.1
      IL_0024:  ldc.i4.m1
      IL_0025:  stloc.2
      IL_0026:  ldc.i4.m1
      IL_0027:  stloc.3
      IL_0028:  ldnull
      IL_0029:  stloc.s    V_4
      IL_002b:  ldnull
      IL_002c:  stloc.s    V_5
      IL_002e:  ldarg.0
      IL_002f:  ldfld      class [mscorlib]System.Collections.Generic.IEnumerable`1<object> Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::ctorArgs
      IL_0034:  ldarg.0
      IL_0035:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::skipFirst
      IL_003a:  call       class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0> [System.Core]System.Linq.Enumerable::Skip<object>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>,
                                                                                                                                           int32)
      IL_003f:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerator`1<!0> class [mscorlib]System.Collections.Generic.IEnumerable`1<object>::GetEnumerator()
      IL_0044:  stloc.s    V_6
      .try
      {
        IL_0046:  br.s       IL_00b0

        IL_0048:  ldloc.s    V_6
        IL_004a:  callvirt   instance !0 class [mscorlib]System.Collections.Generic.IEnumerator`1<object>::get_Current()
        IL_004f:  stloc.s    V_7
        IL_0051:  ldloc.s    V_7
        IL_0053:  isinst     Xunit.TestPlatforms
        IL_0058:  brfalse.s  IL_0064

        IL_005a:  ldloc.s    V_7
        IL_005c:  unbox.any  Xunit.TestPlatforms
        IL_0061:  stloc.1
        IL_0062:  br.s       IL_00b0

        IL_0064:  ldloc.s    V_7
        IL_0066:  isinst     Xunit.TargetFrameworkMonikers
        IL_006b:  brfalse.s  IL_0077

        IL_006d:  ldloc.s    V_7
        IL_006f:  unbox.any  Xunit.TargetFrameworkMonikers
        IL_0074:  stloc.2
        IL_0075:  br.s       IL_00b0

        IL_0077:  ldloc.s    V_7
        IL_0079:  isinst     Xunit.TestRuntimes
        IL_007e:  brfalse.s  IL_008a

        IL_0080:  ldloc.s    V_7
        IL_0082:  unbox.any  Xunit.TestRuntimes
        IL_0087:  stloc.3
        IL_0088:  br.s       IL_00b0

        IL_008a:  ldloc.s    V_7
        IL_008c:  isinst     [mscorlib]System.Type
        IL_0091:  brfalse.s  IL_009e

        IL_0093:  ldloc.s    V_7
        IL_0095:  castclass  [mscorlib]System.Type
        IL_009a:  stloc.s    V_4
        IL_009c:  br.s       IL_00b0

        IL_009e:  ldloc.s    V_7
        IL_00a0:  isinst     string[]
        IL_00a5:  brfalse.s  IL_00b0

        IL_00a7:  ldloc.s    V_7
        IL_00a9:  castclass  string[]
        IL_00ae:  stloc.s    V_5
        IL_00b0:  ldloc.s    V_6
        IL_00b2:  callvirt   instance bool [mscorlib]System.Collections.IEnumerator::MoveNext()
        IL_00b7:  brtrue.s   IL_0048

        IL_00b9:  leave.s    IL_00c7

      }  // end .try
      finally
      {
        IL_00bb:  ldloc.s    V_6
        IL_00bd:  brfalse.s  IL_00c6

        IL_00bf:  ldloc.s    V_6
        IL_00c1:  callvirt   instance void [mscorlib]System.IDisposable::Dispose()
        IL_00c6:  endfinally
      }  // end handler
      IL_00c7:  ldloc.s    V_4
      IL_00c9:  ldnull
      IL_00ca:  call       bool [mscorlib]System.Type::op_Inequality(class [mscorlib]System.Type,
                                                                     class [mscorlib]System.Type)
      IL_00cf:  brfalse.s  IL_0108

      IL_00d1:  ldloc.s    V_5
      IL_00d3:  brfalse.s  IL_0108

      IL_00d5:  ldloc.s    V_4
      IL_00d7:  ldloc.s    V_5
      IL_00d9:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::Evaluate(class [mscorlib]System.Type,
                                                                                             string[])
      IL_00de:  brfalse.s  IL_0146

      IL_00e0:  ldarg.0
      IL_00e1:  ldstr      "category"
      IL_00e6:  ldarg.0
      IL_00e7:  ldfld      string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::category
      IL_00ec:  newobj     instance void valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>::.ctor(!0,
                                                                                                                             !1)
      IL_00f1:  stfld      valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>2__current'
      IL_00f6:  ldarg.0
      IL_00f7:  ldc.i4.1
      IL_00f8:  stfld      int32 Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>1__state'
      IL_00fd:  ldc.i4.1
      IL_00fe:  ret

      IL_00ff:  ldarg.0
      IL_0100:  ldc.i4.m1
      IL_0101:  stfld      int32 Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>1__state'
      IL_0106:  br.s       IL_0146

      IL_0108:  ldloc.1
      IL_0109:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::TestPlatformApplies(valuetype Xunit.TestPlatforms)
      IL_010e:  brfalse.s  IL_0146

      IL_0110:  ldloc.3
      IL_0111:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::TestRuntimeApplies(valuetype Xunit.TestRuntimes)
      IL_0116:  brfalse.s  IL_0146

      IL_0118:  ldloc.2
      IL_0119:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::TestFrameworkApplies(valuetype Xunit.TargetFrameworkMonikers)
      IL_011e:  brfalse.s  IL_0146

      IL_0120:  ldarg.0
      IL_0121:  ldstr      "category"
      IL_0126:  ldarg.0
      IL_0127:  ldfld      string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::category
      IL_012c:  newobj     instance void valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>::.ctor(!0,
                                                                                                                             !1)
      IL_0131:  stfld      valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>2__current'
      IL_0136:  ldarg.0
      IL_0137:  ldc.i4.2
      IL_0138:  stfld      int32 Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>1__state'
      IL_013d:  ldc.i4.1
      IL_013e:  ret

      IL_013f:  ldarg.0
      IL_0140:  ldc.i4.m1
      IL_0141:  stfld      int32 Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>1__state'
      IL_0146:  ldc.i4.0
      IL_0147:  ret
    } // end of method '<EvaluateArguments>d__13'::MoveNext

    .method private hidebysig newslot specialname virtual final 
            instance valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> 
            'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current'() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override  method instance !0 class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>::get_Current()
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldfld      valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>2__current'
      IL_0006:  ret
    } // end of method '<EvaluateArguments>d__13'::'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current'

    .method private hidebysig newslot virtual final 
            instance void  System.Collections.IEnumerator.Reset() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.Collections.IEnumerator::Reset
      // Code size       6 (0x6)
      .maxstack  8
      IL_0000:  newobj     instance void [mscorlib]System.NotSupportedException::.ctor()
      IL_0005:  throw
    } // end of method '<EvaluateArguments>d__13'::System.Collections.IEnumerator.Reset

    .method private hidebysig newslot specialname virtual final 
            instance object  System.Collections.IEnumerator.get_Current() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.Collections.IEnumerator::get_Current
      // Code size       12 (0xc)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldfld      valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>2__current'
      IL_0006:  box        valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
      IL_000b:  ret
    } // end of method '<EvaluateArguments>d__13'::System.Collections.IEnumerator.get_Current

    .method private hidebysig newslot virtual final 
            instance class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> 
            'System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator'() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override  method instance class [mscorlib]System.Collections.Generic.IEnumerator`1<!0> class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>::GetEnumerator()
      // Code size       79 (0x4f)
      .maxstack  2
      .locals init (class Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13' V_0)
      IL_0000:  ldarg.0
      IL_0001:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>1__state'
      IL_0006:  ldc.i4.s   -2
      IL_0008:  bne.un.s   IL_0022

      IL_000a:  ldarg.0
      IL_000b:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>l__initialThreadId'
      IL_0010:  call       int32 [mscorlib]System.Environment::get_CurrentManagedThreadId()
      IL_0015:  bne.un.s   IL_0022

      IL_0017:  ldarg.0
      IL_0018:  ldc.i4.0
      IL_0019:  stfld      int32 Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>1__state'
      IL_001e:  ldarg.0
      IL_001f:  stloc.0
      IL_0020:  br.s       IL_0029

      IL_0022:  ldc.i4.0
      IL_0023:  newobj     instance void Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::.ctor(int32)
      IL_0028:  stloc.0
      IL_0029:  ldloc.0
      IL_002a:  ldarg.0
      IL_002b:  ldfld      class [mscorlib]System.Collections.Generic.IEnumerable`1<object> Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>3__ctorArgs'
      IL_0030:  stfld      class [mscorlib]System.Collections.Generic.IEnumerable`1<object> Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::ctorArgs
      IL_0035:  ldloc.0
      IL_0036:  ldarg.0
      IL_0037:  ldfld      string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>3__category'
      IL_003c:  stfld      string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::category
      IL_0041:  ldloc.0
      IL_0042:  ldarg.0
      IL_0043:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>3__skipFirst'
      IL_0048:  stfld      int32 Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::skipFirst
      IL_004d:  ldloc.0
      IL_004e:  ret
    } // end of method '<EvaluateArguments>d__13'::'System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator'

    .method private hidebysig newslot virtual final 
            instance class [mscorlib]System.Collections.IEnumerator 
            System.Collections.IEnumerable.GetEnumerator() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.Collections.IEnumerable::GetEnumerator
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator'()
      IL_0006:  ret
    } // end of method '<EvaluateArguments>d__13'::System.Collections.IEnumerable.GetEnumerator

    .property instance valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
            'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current'()
    {
      .get instance valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current'()
    } // end of property '<EvaluateArguments>d__13'::'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current'
    .property instance object System.Collections.IEnumerator.Current()
    {
      .get instance object Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::System.Collections.IEnumerator.get_Current()
    } // end of property '<EvaluateArguments>d__13'::System.Collections.IEnumerator.Current
  } // end of class '<EvaluateArguments>d__13'

  .field private static initonly class [mscorlib]System.Lazy`1<bool> s_isMonoRuntime
  .field private static initonly bool '<IsRunningOnNetCoreApp>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .field private static initonly bool '<IsRunningOnNetFramework>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname static 
          bool  get_IsMonoRuntime() cil managed
  {
    // Code size       11 (0xb)
    .maxstack  8
    IL_0000:  ldsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::s_isMonoRuntime
    IL_0005:  callvirt   instance !0 class [mscorlib]System.Lazy`1<bool>::get_Value()
    IL_000a:  ret
  } // end of method DiscovererHelpers::get_IsMonoRuntime

  .method public hidebysig specialname static 
          bool  get_IsRunningOnNetCoreApp() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  ldsfld     bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::'<IsRunningOnNetCoreApp>k__BackingField'
    IL_0005:  ret
  } // end of method DiscovererHelpers::get_IsRunningOnNetCoreApp

  .method public hidebysig specialname static 
          bool  get_IsRunningOnNetFramework() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  ldsfld     bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::'<IsRunningOnNetFramework>k__BackingField'
    IL_0005:  ret
  } // end of method DiscovererHelpers::get_IsRunningOnNetFramework

  .method public hidebysig static bool  TestPlatformApplies(valuetype Xunit.TestPlatforms platforms) cil managed
  {
    // Code size       647 (0x287)
    .maxstack  2
    IL_0000:  ldarg.0
    IL_0001:  box        Xunit.TestPlatforms
    IL_0006:  ldc.i4.m1
    IL_0007:  box        Xunit.TestPlatforms
    IL_000c:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_0011:  brtrue     IL_0285

    IL_0016:  ldarg.0
    IL_0017:  box        Xunit.TestPlatforms
    IL_001c:  ldc.i4.8
    IL_001d:  box        Xunit.TestPlatforms
    IL_0022:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_0027:  brfalse.s  IL_003d

    IL_0029:  ldstr      "FREEBSD"
    IL_002e:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::Create(string)
    IL_0033:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0038:  brtrue     IL_0285

    IL_003d:  ldarg.0
    IL_003e:  box        Xunit.TestPlatforms
    IL_0043:  ldc.i4.2
    IL_0044:  box        Xunit.TestPlatforms
    IL_0049:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_004e:  brfalse.s  IL_005f

    IL_0050:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::get_Linux()
    IL_0055:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_005a:  brtrue     IL_0285

    IL_005f:  ldarg.0
    IL_0060:  box        Xunit.TestPlatforms
    IL_0065:  ldc.i4.s   16
    IL_0067:  box        Xunit.TestPlatforms
    IL_006c:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_0071:  brfalse.s  IL_0087

    IL_0073:  ldstr      "NETBSD"
    IL_0078:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::Create(string)
    IL_007d:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0082:  brtrue     IL_0285

    IL_0087:  ldarg.0
    IL_0088:  box        Xunit.TestPlatforms
    IL_008d:  ldc.i4.4
    IL_008e:  box        Xunit.TestPlatforms
    IL_0093:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_0098:  brfalse.s  IL_00a9

    IL_009a:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::get_OSX()
    IL_009f:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_00a4:  brtrue     IL_0285

    IL_00a9:  ldarg.0
    IL_00aa:  box        Xunit.TestPlatforms
    IL_00af:  ldc.i4.s   32
    IL_00b1:  box        Xunit.TestPlatforms
    IL_00b6:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_00bb:  brfalse.s  IL_00d1

    IL_00bd:  ldstr      "ILLUMOS"
    IL_00c2:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::Create(string)
    IL_00c7:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_00cc:  brtrue     IL_0285

    IL_00d1:  ldarg.0
    IL_00d2:  box        Xunit.TestPlatforms
    IL_00d7:  ldc.i4.s   64
    IL_00d9:  box        Xunit.TestPlatforms
    IL_00de:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_00e3:  brfalse.s  IL_00f9

    IL_00e5:  ldstr      "SOLARIS"
    IL_00ea:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::Create(string)
    IL_00ef:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_00f4:  brtrue     IL_0285

    IL_00f9:  ldarg.0
    IL_00fa:  box        Xunit.TestPlatforms
    IL_00ff:  ldc.i4     0x80
    IL_0104:  box        Xunit.TestPlatforms
    IL_0109:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_010e:  brfalse.s  IL_0135

    IL_0110:  ldstr      "IOS"
    IL_0115:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::Create(string)
    IL_011a:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_011f:  brfalse.s  IL_0135

    IL_0121:  ldstr      "MACCATALYST"
    IL_0126:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::Create(string)
    IL_012b:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0130:  brfalse    IL_0285

    IL_0135:  ldarg.0
    IL_0136:  box        Xunit.TestPlatforms
    IL_013b:  ldc.i4     0x100
    IL_0140:  box        Xunit.TestPlatforms
    IL_0145:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_014a:  brfalse.s  IL_0160

    IL_014c:  ldstr      "TVOS"
    IL_0151:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::Create(string)
    IL_0156:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_015b:  brtrue     IL_0285

    IL_0160:  ldarg.0
    IL_0161:  box        Xunit.TestPlatforms
    IL_0166:  ldc.i4     0x800
    IL_016b:  box        Xunit.TestPlatforms
    IL_0170:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_0175:  brfalse.s  IL_018b

    IL_0177:  ldstr      "MACCATALYST"
    IL_017c:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::Create(string)
    IL_0181:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0186:  brtrue     IL_0285

    IL_018b:  ldarg.0
    IL_018c:  box        Xunit.TestPlatforms
    IL_0191:  ldc.i4     0x1000
    IL_0196:  box        Xunit.TestPlatforms
    IL_019b:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_01a0:  brfalse.s  IL_01c2

    IL_01a2:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::get_Linux()
    IL_01a7:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_01ac:  brfalse.s  IL_01c2

    IL_01ae:  ldstr      "ANDROID_STORAGE"
    IL_01b3:  call       string [mscorlib]System.Environment::GetEnvironmentVariable(string)
    IL_01b8:  call       bool [mscorlib]System.String::IsNullOrEmpty(string)
    IL_01bd:  brfalse    IL_0285

    IL_01c2:  ldarg.0
    IL_01c3:  box        Xunit.TestPlatforms
    IL_01c8:  ldc.i4     0x200
    IL_01cd:  box        Xunit.TestPlatforms
    IL_01d2:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_01d7:  brfalse.s  IL_01ed

    IL_01d9:  ldstr      "ANDROID"
    IL_01de:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::Create(string)
    IL_01e3:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_01e8:  brtrue     IL_0285

    IL_01ed:  ldarg.0
    IL_01ee:  box        Xunit.TestPlatforms
    IL_01f3:  ldc.i4     0x400
    IL_01f8:  box        Xunit.TestPlatforms
    IL_01fd:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_0202:  brfalse.s  IL_0215

    IL_0204:  ldstr      "BROWSER"
    IL_0209:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::Create(string)
    IL_020e:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0213:  brtrue.s   IL_0285

    IL_0215:  ldarg.0
    IL_0216:  box        Xunit.TestPlatforms
    IL_021b:  ldc.i4     0x2000
    IL_0220:  box        Xunit.TestPlatforms
    IL_0225:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_022a:  brfalse.s  IL_023d

    IL_022c:  ldstr      "WASI"
    IL_0231:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::Create(string)
    IL_0236:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_023b:  brtrue.s   IL_0285

    IL_023d:  ldarg.0
    IL_023e:  box        Xunit.TestPlatforms
    IL_0243:  ldc.i4     0x4000
    IL_0248:  box        Xunit.TestPlatforms
    IL_024d:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_0252:  brfalse.s  IL_0265

    IL_0254:  ldstr      "HAIKU"
    IL_0259:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::Create(string)
    IL_025e:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0263:  brtrue.s   IL_0285

    IL_0265:  ldarg.0
    IL_0266:  box        Xunit.TestPlatforms
    IL_026b:  ldc.i4.1
    IL_026c:  box        Xunit.TestPlatforms
    IL_0271:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_0276:  brfalse.s  IL_0283

    IL_0278:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::get_Windows()
    IL_027d:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0282:  ret

    IL_0283:  ldc.i4.0
    IL_0284:  ret

    IL_0285:  ldc.i4.1
    IL_0286:  ret
  } // end of method DiscovererHelpers::TestPlatformApplies

  .method public hidebysig static bool  TestRuntimeApplies(valuetype Xunit.TestRuntimes runtimes) cil managed
  {
    // Code size       58 (0x3a)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  box        Xunit.TestRuntimes
    IL_0006:  ldc.i4.2
    IL_0007:  box        Xunit.TestRuntimes
    IL_000c:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_0011:  brfalse.s  IL_001a

    IL_0013:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::get_IsMonoRuntime()
    IL_0018:  brtrue.s   IL_0038

    IL_001a:  ldarg.0
    IL_001b:  box        Xunit.TestRuntimes
    IL_0020:  ldc.i4.1
    IL_0021:  box        Xunit.TestRuntimes
    IL_0026:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_002b:  brfalse.s  IL_0036

    IL_002d:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::get_IsMonoRuntime()
    IL_0032:  ldc.i4.0
    IL_0033:  ceq
    IL_0035:  ret

    IL_0036:  ldc.i4.0
    IL_0037:  ret

    IL_0038:  ldc.i4.1
    IL_0039:  ret
  } // end of method DiscovererHelpers::TestRuntimeApplies

  .method public hidebysig static bool  TestFrameworkApplies(valuetype Xunit.TargetFrameworkMonikers frameworks) cil managed
  {
    // Code size       55 (0x37)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  box        Xunit.TargetFrameworkMonikers
    IL_0006:  ldc.i4.1
    IL_0007:  box        Xunit.TargetFrameworkMonikers
    IL_000c:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_0011:  brfalse.s  IL_001a

    IL_0013:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::get_IsRunningOnNetCoreApp()
    IL_0018:  brtrue.s   IL_0035

    IL_001a:  ldarg.0
    IL_001b:  box        Xunit.TargetFrameworkMonikers
    IL_0020:  ldc.i4.2
    IL_0021:  box        Xunit.TargetFrameworkMonikers
    IL_0026:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_002b:  brfalse.s  IL_0033

    IL_002d:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::get_IsRunningOnNetFramework()
    IL_0032:  ret

    IL_0033:  ldc.i4.0
    IL_0034:  ret

    IL_0035:  ldc.i4.1
    IL_0036:  ret
  } // end of method DiscovererHelpers::TestFrameworkApplies

  .method assembly hidebysig static bool 
          Evaluate(class [mscorlib]System.Type calleeType,
                   string[] conditionMemberNames) cil managed
  {
    // Code size       73 (0x49)
    .maxstack  3
    .locals init (string[] V_0,
             int32 V_1,
             string V_2,
             class [mscorlib]System.Func`1<bool> V_3)
    IL_0000:  ldarg.1
    IL_0001:  stloc.0
    IL_0002:  ldc.i4.0
    IL_0003:  stloc.1
    IL_0004:  br.s       IL_0041

    IL_0006:  ldloc.0
    IL_0007:  ldloc.1
    IL_0008:  ldelem.ref
    IL_0009:  stloc.2
    IL_000a:  ldloc.2
    IL_000b:  call       bool [mscorlib]System.String::IsNullOrWhiteSpace(string)
    IL_0010:  brtrue.s   IL_003d

    IL_0012:  ldarg.0
    IL_0013:  ldloc.2
    IL_0014:  call       class [mscorlib]System.Func`1<bool> Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer::LookupConditionalMember(class [mscorlib]System.Type,
                                                                                                                                                 string)
    IL_0019:  stloc.3
    IL_001a:  ldloc.3
    IL_001b:  brtrue.s   IL_0033

    IL_001d:  ldstr      "Unable to get member, please check input for "
    IL_0022:  ldloc.2
    IL_0023:  ldstr      "."
    IL_0028:  call       string [mscorlib]System.String::Concat(string,
                                                                string,
                                                                string)
    IL_002d:  newobj     instance void [mscorlib]System.InvalidOperationException::.ctor(string)
    IL_0032:  throw

    IL_0033:  ldloc.3
    IL_0034:  callvirt   instance !0 class [mscorlib]System.Func`1<bool>::Invoke()
    IL_0039:  brtrue.s   IL_003d

    IL_003b:  ldc.i4.0
    IL_003c:  ret

    IL_003d:  ldloc.1
    IL_003e:  ldc.i4.1
    IL_003f:  add
    IL_0040:  stloc.1
    IL_0041:  ldloc.1
    IL_0042:  ldloc.0
    IL_0043:  ldlen
    IL_0044:  conv.i4
    IL_0045:  blt.s      IL_0006

    IL_0047:  ldc.i4.1
    IL_0048:  ret
  } // end of method DiscovererHelpers::Evaluate

  .method assembly hidebysig static class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> 
          EvaluateArguments(class [mscorlib]System.Collections.Generic.IEnumerable`1<object> ctorArgs,
                            string category,
                            [opt] int32 skipFirst) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.IteratorStateMachineAttribute::.ctor(class [mscorlib]System.Type) = ( 01 00 4B 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..KMicrosoft.Dot
                                                                                                                                          4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                                                                          6F 6E 73 2E 44 69 73 63 6F 76 65 72 65 72 48 65   // ons.DiscovererHe
                                                                                                                                          6C 70 65 72 73 2B 3C 45 76 61 6C 75 61 74 65 41   // lpers+<EvaluateA
                                                                                                                                          72 67 75 6D 65 6E 74 73 3E 64 5F 5F 31 33 00 00 ) // rguments>d__13..
    .param [3] = int32(0x00000001)
    // Code size       29 (0x1d)
    .maxstack  8
    IL_0000:  ldc.i4.s   -2
    IL_0002:  newobj     instance void Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::.ctor(int32)
    IL_0007:  dup
    IL_0008:  ldarg.0
    IL_0009:  stfld      class [mscorlib]System.Collections.Generic.IEnumerable`1<object> Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>3__ctorArgs'
    IL_000e:  dup
    IL_000f:  ldarg.1
    IL_0010:  stfld      string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>3__category'
    IL_0015:  dup
    IL_0016:  ldarg.2
    IL_0017:  stfld      int32 Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<EvaluateArguments>d__13'::'<>3__skipFirst'
    IL_001c:  ret
  } // end of method DiscovererHelpers::EvaluateArguments

  .method assembly hidebysig static string 
          AppendAdditionalMessage(string message,
                                  string additionalMessage) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.ExtensionAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       23 (0x17)
    .maxstack  8
    IL_0000:  ldarg.1
    IL_0001:  call       bool [mscorlib]System.String::IsNullOrWhiteSpace(string)
    IL_0006:  brfalse.s  IL_000a

    IL_0008:  ldarg.0
    IL_0009:  ret

    IL_000a:  ldarg.0
    IL_000b:  ldstr      " "
    IL_0010:  ldarg.1
    IL_0011:  call       string [mscorlib]System.String::Concat(string,
                                                                string,
                                                                string)
    IL_0016:  ret
  } // end of method DiscovererHelpers::AppendAdditionalMessage

  .method private hidebysig specialname rtspecialname static 
          void  .cctor() cil managed
  {
    // Code size       88 (0x58)
    .maxstack  3
    IL_0000:  ldsfld     class Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<>c' Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<>c'::'<>9'
    IL_0005:  ldftn      instance bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers/'<>c'::'<.cctor>b__15_0'()
    IL_000b:  newobj     instance void class [mscorlib]System.Func`1<bool>::.ctor(object,
                                                                                  native int)
    IL_0010:  newobj     instance void class [mscorlib]System.Lazy`1<bool>::.ctor(class [mscorlib]System.Func`1<!0>)
    IL_0015:  stsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::s_isMonoRuntime
    IL_001a:  call       class [mscorlib]System.Version [mscorlib]System.Environment::get_Version()
    IL_001f:  callvirt   instance int32 [mscorlib]System.Version::get_Major()
    IL_0024:  ldc.i4.5
    IL_0025:  bge.s      IL_003c

    IL_0027:  call       string [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::get_FrameworkDescription()
    IL_002c:  ldstr      ".NET Framework"
    IL_0031:  ldc.i4.5
    IL_0032:  callvirt   instance bool [mscorlib]System.String::StartsWith(string,
                                                                           valuetype [mscorlib]System.StringComparison)
    IL_0037:  ldc.i4.0
    IL_0038:  ceq
    IL_003a:  br.s       IL_003d

    IL_003c:  ldc.i4.1
    IL_003d:  stsfld     bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::'<IsRunningOnNetCoreApp>k__BackingField'
    IL_0042:  call       string [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::get_FrameworkDescription()
    IL_0047:  ldstr      ".NET Framework"
    IL_004c:  ldc.i4.5
    IL_004d:  callvirt   instance bool [mscorlib]System.String::StartsWith(string,
                                                                           valuetype [mscorlib]System.StringComparison)
    IL_0052:  stsfld     bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::'<IsRunningOnNetFramework>k__BackingField'
    IL_0057:  ret
  } // end of method DiscovererHelpers::.cctor

  .property bool IsMonoRuntime()
  {
    .get bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::get_IsMonoRuntime()
  } // end of property DiscovererHelpers::IsMonoRuntime
  .property bool IsRunningOnNetCoreApp()
  {
    .get bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::get_IsRunningOnNetCoreApp()
  } // end of property DiscovererHelpers::IsRunningOnNetCoreApp
  .property bool IsRunningOnNetFramework()
  {
    .get bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::get_IsRunningOnNetFramework()
  } // end of property DiscovererHelpers::IsRunningOnNetFramework
} // end of class Microsoft.DotNet.XUnitExtensions.DiscovererHelpers

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.ActiveIssueDiscoverer
       extends [mscorlib]System.Object
       implements [xunit.core]Xunit.Sdk.ITraitDiscoverer
{
  .method public hidebysig newslot virtual final 
          instance class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> 
          GetTraits(class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo traitAttribute) cil managed
  {
    // Code size       20 (0x14)
    .maxstack  3
    .locals init (class [mscorlib]System.Collections.Generic.IEnumerable`1<object> V_0)
    IL_0000:  ldarg.1
    IL_0001:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerable`1<object> [xunit.abstractions]Xunit.Abstractions.IAttributeInfo::GetConstructorArguments()
    IL_0006:  stloc.0
    IL_0007:  ldloc.0
    IL_0008:  ldstr      "failing"
    IL_000d:  ldc.i4.1
    IL_000e:  call       class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::EvaluateArguments(class [mscorlib]System.Collections.Generic.IEnumerable`1<object>,
                                                                                                                                                                                                                                      string,
                                                                                                                                                                                                                                      int32)
    IL_0013:  ret
  } // end of method ActiveIssueDiscoverer::GetTraits

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method ActiveIssueDiscoverer::.ctor

} // end of class Microsoft.DotNet.XUnitExtensions.ActiveIssueDiscoverer

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer
       extends [mscorlib]System.Object
       implements [xunit.core]Xunit.Sdk.ITraitDiscoverer
{
  .class auto ansi sealed nested private beforefieldinit '<GetTraits>d__0'
         extends [mscorlib]System.Object
         implements class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>,
                    [mscorlib]System.Collections.IEnumerable,
                    class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>,
                    [mscorlib]System.IDisposable,
                    [mscorlib]System.Collections.IEnumerator
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field private int32 '<>1__state'
    .field private valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> '<>2__current'
    .field private int32 '<>l__initialThreadId'
    .field private class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo traitAttribute
    .field public class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo '<>3__traitAttribute'
    .method public hidebysig specialname rtspecialname 
            instance void  .ctor(int32 '<>1__state') cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      // Code size       25 (0x19)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ldarg.0
      IL_0007:  ldarg.1
      IL_0008:  stfld      int32 Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_000d:  ldarg.0
      IL_000e:  call       int32 [mscorlib]System.Environment::get_CurrentManagedThreadId()
      IL_0013:  stfld      int32 Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::'<>l__initialThreadId'
      IL_0018:  ret
    } // end of method '<GetTraits>d__0'::.ctor

    .method private hidebysig newslot virtual final 
            instance void  System.IDisposable.Dispose() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.IDisposable::Dispose
      // Code size       1 (0x1)
      .maxstack  8
      IL_0000:  ret
    } // end of method '<GetTraits>d__0'::System.IDisposable.Dispose

    .method private hidebysig newslot virtual final 
            instance bool  MoveNext() cil managed
    {
      .override [mscorlib]System.Collections.IEnumerator::MoveNext
      // Code size       75 (0x4b)
      .maxstack  3
      .locals init (int32 V_0)
      IL_0000:  ldarg.0
      IL_0001:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_0006:  stloc.0
      IL_0007:  ldloc.0
      IL_0008:  brfalse.s  IL_0010

      IL_000a:  ldloc.0
      IL_000b:  ldc.i4.1
      IL_000c:  beq.s      IL_0042

      IL_000e:  ldc.i4.0
      IL_000f:  ret

      IL_0010:  ldarg.0
      IL_0011:  ldc.i4.m1
      IL_0012:  stfld      int32 Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_0017:  ldarg.0
      IL_0018:  ldfld      class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::traitAttribute
      IL_001d:  call       bool Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer::EvaluateParameterHelper(class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo)
      IL_0022:  brtrue.s   IL_0049

      IL_0024:  ldarg.0
      IL_0025:  ldstr      "category"
      IL_002a:  ldstr      "failing"
      IL_002f:  newobj     instance void valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>::.ctor(!0,
                                                                                                                             !1)
      IL_0034:  stfld      valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::'<>2__current'
      IL_0039:  ldarg.0
      IL_003a:  ldc.i4.1
      IL_003b:  stfld      int32 Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_0040:  ldc.i4.1
      IL_0041:  ret

      IL_0042:  ldarg.0
      IL_0043:  ldc.i4.m1
      IL_0044:  stfld      int32 Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_0049:  ldc.i4.0
      IL_004a:  ret
    } // end of method '<GetTraits>d__0'::MoveNext

    .method private hidebysig newslot specialname virtual final 
            instance valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> 
            'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current'() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override  method instance !0 class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>::get_Current()
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldfld      valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::'<>2__current'
      IL_0006:  ret
    } // end of method '<GetTraits>d__0'::'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current'

    .method private hidebysig newslot virtual final 
            instance void  System.Collections.IEnumerator.Reset() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.Collections.IEnumerator::Reset
      // Code size       6 (0x6)
      .maxstack  8
      IL_0000:  newobj     instance void [mscorlib]System.NotSupportedException::.ctor()
      IL_0005:  throw
    } // end of method '<GetTraits>d__0'::System.Collections.IEnumerator.Reset

    .method private hidebysig newslot specialname virtual final 
            instance object  System.Collections.IEnumerator.get_Current() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.Collections.IEnumerator::get_Current
      // Code size       12 (0xc)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldfld      valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::'<>2__current'
      IL_0006:  box        valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
      IL_000b:  ret
    } // end of method '<GetTraits>d__0'::System.Collections.IEnumerator.get_Current

    .method private hidebysig newslot virtual final 
            instance class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> 
            'System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator'() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override  method instance class [mscorlib]System.Collections.Generic.IEnumerator`1<!0> class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>::GetEnumerator()
      // Code size       55 (0x37)
      .maxstack  2
      .locals init (class Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0' V_0)
      IL_0000:  ldarg.0
      IL_0001:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_0006:  ldc.i4.s   -2
      IL_0008:  bne.un.s   IL_0022

      IL_000a:  ldarg.0
      IL_000b:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::'<>l__initialThreadId'
      IL_0010:  call       int32 [mscorlib]System.Environment::get_CurrentManagedThreadId()
      IL_0015:  bne.un.s   IL_0022

      IL_0017:  ldarg.0
      IL_0018:  ldc.i4.0
      IL_0019:  stfld      int32 Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_001e:  ldarg.0
      IL_001f:  stloc.0
      IL_0020:  br.s       IL_0029

      IL_0022:  ldc.i4.0
      IL_0023:  newobj     instance void Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::.ctor(int32)
      IL_0028:  stloc.0
      IL_0029:  ldloc.0
      IL_002a:  ldarg.0
      IL_002b:  ldfld      class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::'<>3__traitAttribute'
      IL_0030:  stfld      class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::traitAttribute
      IL_0035:  ldloc.0
      IL_0036:  ret
    } // end of method '<GetTraits>d__0'::'System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator'

    .method private hidebysig newslot virtual final 
            instance class [mscorlib]System.Collections.IEnumerator 
            System.Collections.IEnumerable.GetEnumerator() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.Collections.IEnumerable::GetEnumerator
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::'System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator'()
      IL_0006:  ret
    } // end of method '<GetTraits>d__0'::System.Collections.IEnumerable.GetEnumerator

    .property instance valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
            'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current'()
    {
      .get instance valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current'()
    } // end of property '<GetTraits>d__0'::'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current'
    .property instance object System.Collections.IEnumerator.Current()
    {
      .get instance object Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::System.Collections.IEnumerator.get_Current()
    } // end of property '<GetTraits>d__0'::System.Collections.IEnumerator.Current
  } // end of class '<GetTraits>d__0'

  .method public hidebysig newslot virtual final 
          instance class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> 
          GetTraits(class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo traitAttribute) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.IteratorStateMachineAttribute::.ctor(class [mscorlib]System.Type) = ( 01 00 4B 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..KMicrosoft.Dot
                                                                                                                                          4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                                                                          6F 6E 73 2E 43 6F 6E 64 69 74 69 6F 6E 61 6C 43   // ons.ConditionalC
                                                                                                                                          6C 61 73 73 44 69 73 63 6F 76 65 72 65 72 2B 3C   // lassDiscoverer+<
                                                                                                                                          47 65 74 54 72 61 69 74 73 3E 64 5F 5F 30 00 00 ) // GetTraits>d__0..
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldc.i4.s   -2
    IL_0002:  newobj     instance void Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::.ctor(int32)
    IL_0007:  dup
    IL_0008:  ldarg.1
    IL_0009:  stfld      class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer/'<GetTraits>d__0'::'<>3__traitAttribute'
    IL_000e:  ret
  } // end of method ConditionalClassDiscoverer::GetTraits

  .method assembly hidebysig static bool 
          EvaluateParameterHelper(class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo traitAttribute) cil managed
  {
    // Code size       39 (0x27)
    .maxstack  4
    .locals init (object[] V_0,
             class [mscorlib]System.Type V_1,
             string[] V_2)
    IL_0000:  ldarg.0
    IL_0001:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerable`1<object> [xunit.abstractions]Xunit.Abstractions.IAttributeInfo::GetConstructorArguments()
    IL_0006:  call       !!0[] [System.Core]System.Linq.Enumerable::ToArray<object>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_000b:  stloc.0
    IL_000c:  ldnull
    IL_000d:  stloc.1
    IL_000e:  ldnull
    IL_000f:  stloc.2
    IL_0010:  ldloc.0
    IL_0011:  ldloca.s   V_1
    IL_0013:  ldloca.s   V_2
    IL_0015:  ldnull
    IL_0016:  call       bool Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer::CheckInputToSkipExecution(object[],
                                                                                                                    class [mscorlib]System.Type&,
                                                                                                                    string[]&,
                                                                                                                    class [xunit.abstractions]Xunit.Abstractions.ITestMethod)
    IL_001b:  brfalse.s  IL_001f

    IL_001d:  ldc.i4.1
    IL_001e:  ret

    IL_001f:  ldloc.1
    IL_0020:  ldloc.2
    IL_0021:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::Evaluate(class [mscorlib]System.Type,
                                                                                           string[])
    IL_0026:  ret
  } // end of method ConditionalClassDiscoverer::EvaluateParameterHelper

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method ConditionalClassDiscoverer::.ctor

} // end of class Microsoft.DotNet.XUnitExtensions.ConditionalClassDiscoverer

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.ConditionalFactDiscoverer
       extends [xunit.execution.desktop]Xunit.Sdk.FactDiscoverer
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink diagnosticMessageSink) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       instance void [xunit.execution.desktop]Xunit.Sdk.FactDiscoverer::.ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink)
    IL_0007:  ret
  } // end of method ConditionalFactDiscoverer::.ctor

  .method family hidebysig virtual instance class [xunit.core]Xunit.Sdk.IXunitTestCase 
          CreateTestCase(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions,
                         class [xunit.abstractions]Xunit.Abstractions.ITestMethod testMethod,
                         class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo factAttribute) cil managed
  {
    // Code size       92 (0x5c)
    .maxstack  6
    .locals init (string V_0,
             class [xunit.execution.desktop]Xunit.Sdk.ExecutionErrorTestCase V_1,
             class [xunit.core]Xunit.Sdk.IXunitTestCase V_2)
    IL_0000:  ldarg.1
    IL_0001:  ldarg.0
    IL_0002:  call       instance class [xunit.abstractions]Xunit.Abstractions.IMessageSink [xunit.execution.desktop]Xunit.Sdk.FactDiscoverer::get_DiagnosticMessageSink()
    IL_0007:  ldarg.2
    IL_0008:  ldarg.3
    IL_0009:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerable`1<object> [xunit.abstractions]Xunit.Abstractions.IAttributeInfo::GetConstructorArguments()
    IL_000e:  call       !!0[] [System.Core]System.Linq.Enumerable::ToArray<object>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_0013:  ldloca.s   V_0
    IL_0015:  ldloca.s   V_1
    IL_0017:  call       bool Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer::TryEvaluateSkipConditions(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions,
                                                                                                                    class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                                                    class [xunit.abstractions]Xunit.Abstractions.ITestMethod,
                                                                                                                    object[],
                                                                                                                    string&,
                                                                                                                    class [xunit.execution.desktop]Xunit.Sdk.ExecutionErrorTestCase&)
    IL_001c:  brfalse.s  IL_005a

    IL_001e:  ldloc.0
    IL_001f:  brtrue.s   IL_003d

    IL_0021:  ldarg.0
    IL_0022:  call       instance class [xunit.abstractions]Xunit.Abstractions.IMessageSink [xunit.execution.desktop]Xunit.Sdk.FactDiscoverer::get_DiagnosticMessageSink()
    IL_0027:  ldarg.1
    IL_0028:  call       valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay [xunit.execution.desktop]TestFrameworkOptionsReadExtensions::MethodDisplayOrDefault(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions)
    IL_002d:  ldarg.1
    IL_002e:  call       valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions [xunit.execution.desktop]TestFrameworkOptionsReadExtensions::MethodDisplayOptionsOrDefault(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions)
    IL_0033:  ldarg.2
    IL_0034:  ldnull
    IL_0035:  newobj     instance void Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase::.ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                                   valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay,
                                                                                                   valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions,
                                                                                                   class [xunit.abstractions]Xunit.Abstractions.ITestMethod,
                                                                                                   object[])
    IL_003a:  stloc.2
    IL_003b:  ldloc.2
    IL_003c:  ret

    IL_003d:  ldloc.0
    IL_003e:  ldarg.0
    IL_003f:  call       instance class [xunit.abstractions]Xunit.Abstractions.IMessageSink [xunit.execution.desktop]Xunit.Sdk.FactDiscoverer::get_DiagnosticMessageSink()
    IL_0044:  ldarg.1
    IL_0045:  call       valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay [xunit.execution.desktop]TestFrameworkOptionsReadExtensions::MethodDisplayOrDefault(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions)
    IL_004a:  ldarg.1
    IL_004b:  call       valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions [xunit.execution.desktop]TestFrameworkOptionsReadExtensions::MethodDisplayOptionsOrDefault(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions)
    IL_0050:  ldarg.2
    IL_0051:  ldnull
    IL_0052:  newobj     instance void Microsoft.DotNet.XUnitExtensions.SkippedTestCase::.ctor(string,
                                                                                               class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay,
                                                                                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions,
                                                                                               class [xunit.abstractions]Xunit.Abstractions.ITestMethod,
                                                                                               object[])
    IL_0057:  stloc.2
    IL_0058:  ldloc.2
    IL_0059:  ret

    IL_005a:  ldloc.1
    IL_005b:  ret
  } // end of method ConditionalFactDiscoverer::CreateTestCase

} // end of class Microsoft.DotNet.XUnitExtensions.ConditionalFactDiscoverer

.class private abstract auto ansi sealed beforefieldinit Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer
       extends [mscorlib]System.Object
{
  .class auto ansi sealed nested private beforefieldinit '<>c__DisplayClass0_0'
         extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field public string[] symbols
    .method public hidebysig specialname rtspecialname 
            instance void  .ctor() cil managed
    {
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ret
    } // end of method '<>c__DisplayClass0_0'::.ctor

    .method assembly hidebysig instance bool 
            '<EvaluateSkipConditions>b__0'(class [xunit.abstractions]Xunit.Abstractions.ITypeInfo t) cil managed
    {
      // Code size       20 (0x14)
      .maxstack  8
      IL_0000:  ldarg.1
      IL_0001:  callvirt   instance string [xunit.abstractions]Xunit.Abstractions.ITypeInfo::get_Name()
      IL_0006:  ldarg.0
      IL_0007:  ldfld      string[] Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass0_0'::symbols
      IL_000c:  ldc.i4.0
      IL_000d:  ldelem.ref
      IL_000e:  callvirt   instance bool [mscorlib]System.String::Contains(string)
      IL_0013:  ret
    } // end of method '<>c__DisplayClass0_0'::'<EvaluateSkipConditions>b__0'

  } // end of class '<>c__DisplayClass0_0'

  .class auto ansi sealed nested private beforefieldinit '<>c__DisplayClass3_0'
         extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field public class [mscorlib]System.Reflection.MethodInfo mi
    .field public class [mscorlib]System.Reflection.PropertyInfo pi
    .field public class [mscorlib]System.Reflection.FieldInfo fi
    .method public hidebysig specialname rtspecialname 
            instance void  .ctor() cil managed
    {
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ret
    } // end of method '<>c__DisplayClass3_0'::.ctor

    .method assembly hidebysig instance bool 
            '<LookupConditionalMember>b__0'() cil managed
    {
      // Code size       19 (0x13)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldfld      class [mscorlib]System.Reflection.MethodInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::mi
      IL_0006:  ldnull
      IL_0007:  ldnull
      IL_0008:  callvirt   instance object [mscorlib]System.Reflection.MethodBase::Invoke(object,
                                                                                          object[])
      IL_000d:  unbox.any  [mscorlib]System.Boolean
      IL_0012:  ret
    } // end of method '<>c__DisplayClass3_0'::'<LookupConditionalMember>b__0'

    .method assembly hidebysig instance bool 
            '<LookupConditionalMember>b__1'() cil managed
    {
      // Code size       18 (0x12)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldfld      class [mscorlib]System.Reflection.PropertyInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::pi
      IL_0006:  ldnull
      IL_0007:  callvirt   instance object [mscorlib]System.Reflection.PropertyInfo::GetValue(object)
      IL_000c:  unbox.any  [mscorlib]System.Boolean
      IL_0011:  ret
    } // end of method '<>c__DisplayClass3_0'::'<LookupConditionalMember>b__1'

    .method assembly hidebysig instance bool 
            '<LookupConditionalMember>b__2'() cil managed
    {
      // Code size       18 (0x12)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldfld      class [mscorlib]System.Reflection.FieldInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::fi
      IL_0006:  ldnull
      IL_0007:  callvirt   instance object [mscorlib]System.Reflection.FieldInfo::GetValue(object)
      IL_000c:  unbox.any  [mscorlib]System.Boolean
      IL_0011:  ret
    } // end of method '<>c__DisplayClass3_0'::'<LookupConditionalMember>b__2'

  } // end of class '<>c__DisplayClass3_0'

  .method assembly hidebysig static string 
          EvaluateSkipConditions(class [xunit.abstractions]Xunit.Abstractions.ITestMethod testMethod,
                                 object[] conditionArguments) cil managed
  {
    // Code size       359 (0x167)
    .maxstack  6
    .locals init (class [mscorlib]System.Type V_0,
             string[] V_1,
             class [mscorlib]System.Reflection.MethodInfo V_2,
             class [mscorlib]System.Type V_3,
             class [mscorlib]System.Collections.Generic.List`1<string> V_4,
             string[] V_5,
             int32 V_6,
             string V_7,
             string V_8,
             class [mscorlib]System.Type V_9,
             class [mscorlib]System.Func`1<bool> V_10,
             class Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass0_0' V_11,
             class [xunit.abstractions]Xunit.Abstractions.ITypeInfo V_12,
             class [mscorlib]System.Exception V_13)
    IL_0000:  ldnull
    IL_0001:  stloc.0
    IL_0002:  ldnull
    IL_0003:  stloc.1
    IL_0004:  ldarg.1
    IL_0005:  ldloca.s   V_0
    IL_0007:  ldloca.s   V_1
    IL_0009:  ldarg.0
    IL_000a:  call       bool Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer::CheckInputToSkipExecution(object[],
                                                                                                                    class [mscorlib]System.Type&,
                                                                                                                    string[]&,
                                                                                                                    class [xunit.abstractions]Xunit.Abstractions.ITestMethod)
    IL_000f:  brfalse.s  IL_0013

    IL_0011:  ldnull
    IL_0012:  ret

    IL_0013:  ldarg.0
    IL_0014:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.IMethodInfo [xunit.abstractions]Xunit.Abstractions.ITestMethod::get_Method()
    IL_0019:  call       class [mscorlib]System.Reflection.MethodInfo [xunit.execution.desktop]ReflectionAbstractionExtensions::ToRuntimeMethod(class [xunit.abstractions]Xunit.Abstractions.IMethodInfo)
    IL_001e:  stloc.2
    IL_001f:  ldloc.2
    IL_0020:  callvirt   instance class [mscorlib]System.Type [mscorlib]System.Reflection.MemberInfo::get_DeclaringType()
    IL_0025:  stloc.3
    IL_0026:  ldloc.1
    IL_0027:  call       int32 [System.Core]System.Linq.Enumerable::Count<string>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_002c:  newobj     instance void class [mscorlib]System.Collections.Generic.List`1<string>::.ctor(int32)
    IL_0031:  stloc.s    V_4
    IL_0033:  ldloc.1
    IL_0034:  stloc.s    V_5
    IL_0036:  ldc.i4.0
    IL_0037:  stloc.s    V_6
    IL_0039:  br         IL_0139

    IL_003e:  ldloc.s    V_5
    IL_0040:  ldloc.s    V_6
    IL_0042:  ldelem.ref
    IL_0043:  stloc.s    V_7
    IL_0045:  ldloc.s    V_7
    IL_0047:  stloc.s    V_8
    IL_0049:  ldloc.s    V_8
    IL_004b:  call       bool [mscorlib]System.String::IsNullOrWhiteSpace(string)
    IL_0050:  brtrue     IL_0133

    IL_0055:  ldloc.0
    IL_0056:  ldnull
    IL_0057:  call       bool [mscorlib]System.Type::op_Inequality(class [mscorlib]System.Type,
                                                                   class [mscorlib]System.Type)
    IL_005c:  brfalse.s  IL_0063

    IL_005e:  ldloc.0
    IL_005f:  stloc.s    V_9
    IL_0061:  br.s       IL_00d9

    IL_0063:  newobj     instance void Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass0_0'::.ctor()
    IL_0068:  stloc.s    V_11
    IL_006a:  ldloc.3
    IL_006b:  stloc.s    V_9
    IL_006d:  ldloc.s    V_11
    IL_006f:  ldloc.s    V_8
    IL_0071:  ldc.i4.1
    IL_0072:  newarr     [mscorlib]System.Char
    IL_0077:  dup
    IL_0078:  ldc.i4.0
    IL_0079:  ldc.i4.s   46
    IL_007b:  stelem.i2
    IL_007c:  callvirt   instance string[] [mscorlib]System.String::Split(char[])
    IL_0081:  stfld      string[] Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass0_0'::symbols
    IL_0086:  ldloc.s    V_11
    IL_0088:  ldfld      string[] Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass0_0'::symbols
    IL_008d:  ldlen
    IL_008e:  conv.i4
    IL_008f:  ldc.i4.2
    IL_0090:  bne.un.s   IL_00d9

    IL_0092:  ldloc.s    V_11
    IL_0094:  ldfld      string[] Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass0_0'::symbols
    IL_0099:  ldc.i4.1
    IL_009a:  ldelem.ref
    IL_009b:  stloc.s    V_8
    IL_009d:  ldarg.0
    IL_009e:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITestClass [xunit.abstractions]Xunit.Abstractions.ITestMethod::get_TestClass()
    IL_00a3:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITypeInfo [xunit.abstractions]Xunit.Abstractions.ITestClass::get_Class()
    IL_00a8:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.IAssemblyInfo [xunit.abstractions]Xunit.Abstractions.ITypeInfo::get_Assembly()
    IL_00ad:  ldc.i4.0
    IL_00ae:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerable`1<class [xunit.abstractions]Xunit.Abstractions.ITypeInfo> [xunit.abstractions]Xunit.Abstractions.IAssemblyInfo::GetTypes(bool)
    IL_00b3:  ldloc.s    V_11
    IL_00b5:  ldftn      instance bool Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass0_0'::'<EvaluateSkipConditions>b__0'(class [xunit.abstractions]Xunit.Abstractions.ITypeInfo)
    IL_00bb:  newobj     instance void class [mscorlib]System.Func`2<class [xunit.abstractions]Xunit.Abstractions.ITypeInfo,bool>::.ctor(object,
                                                                                                                                         native int)
    IL_00c0:  call       class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0> [System.Core]System.Linq.Enumerable::Where<class [xunit.abstractions]Xunit.Abstractions.ITypeInfo>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>,
                                                                                                                                                                                          class [mscorlib]System.Func`2<!!0,bool>)
    IL_00c5:  call       !!0 [System.Core]System.Linq.Enumerable::FirstOrDefault<class [xunit.abstractions]Xunit.Abstractions.ITypeInfo>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_00ca:  stloc.s    V_12
    IL_00cc:  ldloc.s    V_12
    IL_00ce:  brfalse.s  IL_00d9

    IL_00d0:  ldloc.s    V_12
    IL_00d2:  call       class [mscorlib]System.Type [xunit.execution.desktop]ReflectionAbstractionExtensions::ToRuntimeType(class [xunit.abstractions]Xunit.Abstractions.ITypeInfo)
    IL_00d7:  stloc.s    V_9
    IL_00d9:  ldloc.s    V_9
    IL_00db:  ldloc.s    V_8
    IL_00dd:  call       class [mscorlib]System.Func`1<bool> Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer::LookupConditionalMember(class [mscorlib]System.Type,
                                                                                                                                                 string)
    IL_00e2:  dup
    IL_00e3:  stloc.s    V_10
    IL_00e5:  brtrue.s   IL_00f6

    IL_00e7:  ldloc.s    V_8
    IL_00e9:  ldloc.s    V_9
    IL_00eb:  call       string Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer::GetFailedLookupString(string,
                                                                                                                  class [mscorlib]System.Type)
    IL_00f0:  newobj     instance void Microsoft.DotNet.XUnitExtensions.ConditionalDiscovererException::.ctor(string)
    IL_00f5:  throw

    IL_00f6:  nop
    .try
    {
      IL_00f7:  ldloc.s    V_10
      IL_00f9:  callvirt   instance !0 class [mscorlib]System.Func`1<bool>::Invoke()
      IL_00fe:  brtrue.s   IL_0109

      IL_0100:  ldloc.s    V_4
      IL_0102:  ldloc.s    V_8
      IL_0104:  callvirt   instance void class [mscorlib]System.Collections.Generic.List`1<string>::Add(!0)
      IL_0109:  leave.s    IL_0133

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_010b:  stloc.s    V_13
      IL_010d:  ldloc.s    V_4
      IL_010f:  ldloc.s    V_8
      IL_0111:  ldstr      " ("
      IL_0116:  ldloc.s    V_13
      IL_0118:  callvirt   instance class [mscorlib]System.Type [mscorlib]System.Exception::GetType()
      IL_011d:  callvirt   instance string [mscorlib]System.Reflection.MemberInfo::get_Name()
      IL_0122:  ldstr      ")"
      IL_0127:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string,
                                                                  string)
      IL_012c:  callvirt   instance void class [mscorlib]System.Collections.Generic.List`1<string>::Add(!0)
      IL_0131:  leave.s    IL_0133

    }  // end handler
    IL_0133:  ldloc.s    V_6
    IL_0135:  ldc.i4.1
    IL_0136:  add
    IL_0137:  stloc.s    V_6
    IL_0139:  ldloc.s    V_6
    IL_013b:  ldloc.s    V_5
    IL_013d:  ldlen
    IL_013e:  conv.i4
    IL_013f:  blt        IL_003e

    IL_0144:  ldloc.s    V_4
    IL_0146:  callvirt   instance int32 class [mscorlib]System.Collections.Generic.List`1<string>::get_Count()
    IL_014b:  ldc.i4.0
    IL_014c:  ble.s      IL_0165

    IL_014e:  ldstr      "Condition(s) not met: \"{0}\""
    IL_0153:  ldstr      "\", \""
    IL_0158:  ldloc.s    V_4
    IL_015a:  call       string [mscorlib]System.String::Join(string,
                                                              class [mscorlib]System.Collections.Generic.IEnumerable`1<string>)
    IL_015f:  call       string [mscorlib]System.String::Format(string,
                                                                object)
    IL_0164:  ret

    IL_0165:  ldnull
    IL_0166:  ret
  } // end of method ConditionalTestDiscoverer::EvaluateSkipConditions

  .method assembly hidebysig static bool 
          TryEvaluateSkipConditions(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions,
                                    class [xunit.abstractions]Xunit.Abstractions.IMessageSink diagnosticMessageSink,
                                    class [xunit.abstractions]Xunit.Abstractions.ITestMethod testMethod,
                                    object[] conditionArguments,
                                    [out] string& skipReason,
                                    [out] class [xunit.execution.desktop]Xunit.Sdk.ExecutionErrorTestCase& errorTestCase) cil managed
  {
    // Code size       57 (0x39)
    .maxstack  6
    .locals init (bool V_0,
             class Microsoft.DotNet.XUnitExtensions.ConditionalDiscovererException V_1)
    IL_0000:  ldarg.s    skipReason
    IL_0002:  ldnull
    IL_0003:  stind.ref
    IL_0004:  ldarg.s    errorTestCase
    IL_0006:  ldnull
    IL_0007:  stind.ref
    .try
    {
      IL_0008:  ldarg.s    skipReason
      IL_000a:  ldarg.2
      IL_000b:  ldarg.3
      IL_000c:  call       string Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer::EvaluateSkipConditions(class [xunit.abstractions]Xunit.Abstractions.ITestMethod,
                                                                                                                     object[])
      IL_0011:  stind.ref
      IL_0012:  ldc.i4.1
      IL_0013:  stloc.0
      IL_0014:  leave.s    IL_0037

    }  // end .try
    catch Microsoft.DotNet.XUnitExtensions.ConditionalDiscovererException 
    {
      IL_0016:  stloc.1
      IL_0017:  ldarg.s    errorTestCase
      IL_0019:  ldarg.1
      IL_001a:  ldarg.0
      IL_001b:  call       valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay [xunit.execution.desktop]TestFrameworkOptionsReadExtensions::MethodDisplayOrDefault(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions)
      IL_0020:  ldarg.0
      IL_0021:  call       valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions [xunit.execution.desktop]TestFrameworkOptionsReadExtensions::MethodDisplayOptionsOrDefault(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions)
      IL_0026:  ldarg.2
      IL_0027:  ldloc.1
      IL_0028:  callvirt   instance string [mscorlib]System.Exception::get_Message()
      IL_002d:  newobj     instance void [xunit.execution.desktop]Xunit.Sdk.ExecutionErrorTestCase::.ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                                          valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay,
                                                                                                          valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions,
                                                                                                          class [xunit.abstractions]Xunit.Abstractions.ITestMethod,
                                                                                                          string)
      IL_0032:  stind.ref
      IL_0033:  ldc.i4.0
      IL_0034:  stloc.0
      IL_0035:  leave.s    IL_0037

    }  // end handler
    IL_0037:  ldloc.0
    IL_0038:  ret
  } // end of method ConditionalTestDiscoverer::TryEvaluateSkipConditions

  .method assembly hidebysig static string 
          GetFailedLookupString(string name,
                                class [mscorlib]System.Type 'type') cil managed
  {
    // Code size       54 (0x36)
    .maxstack  8
    IL_0000:  ldc.i4.5
    IL_0001:  newarr     [mscorlib]System.String
    IL_0006:  dup
    IL_0007:  ldc.i4.0
    IL_0008:  ldstr      "An appropriate member '"
    IL_000d:  stelem.ref
    IL_000e:  dup
    IL_000f:  ldc.i4.1
    IL_0010:  ldarg.0
    IL_0011:  stelem.ref
    IL_0012:  dup
    IL_0013:  ldc.i4.2
    IL_0014:  ldstr      "' could not be found. "
    IL_0019:  stelem.ref
    IL_001a:  dup
    IL_001b:  ldc.i4.3
    IL_001c:  ldstr      "The conditional method needs to be a static method"
    + ", property, or field on the type {0} or any ancestor, "
    IL_0021:  ldarg.1
    IL_0022:  call       string [mscorlib]System.String::Format(string,
                                                                object)
    IL_0027:  stelem.ref
    IL_0028:  dup
    IL_0029:  ldc.i4.4
    IL_002a:  ldstr      "of any visibility, accepting zero arguments, and h"
    + "aving a return type of Boolean."
    IL_002f:  stelem.ref
    IL_0030:  call       string [mscorlib]System.String::Concat(string[])
    IL_0035:  ret
  } // end of method ConditionalTestDiscoverer::GetFailedLookupString

  .method assembly hidebysig static class [mscorlib]System.Func`1<bool> 
          LookupConditionalMember(class [mscorlib]System.Type t,
                                  string name) cil managed
  {
    // Code size       340 (0x154)
    .maxstack  3
    .locals init (class Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0' V_0,
             class [mscorlib]System.Reflection.TypeInfo V_1)
    IL_0000:  newobj     instance void Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::.ctor()
    IL_0005:  stloc.0
    IL_0006:  ldarg.0
    IL_0007:  ldnull
    IL_0008:  call       bool [mscorlib]System.Type::op_Equality(class [mscorlib]System.Type,
                                                                 class [mscorlib]System.Type)
    IL_000d:  brtrue.s   IL_0012

    IL_000f:  ldarg.1
    IL_0010:  brtrue.s   IL_0014

    IL_0012:  ldnull
    IL_0013:  ret

    IL_0014:  ldarg.0
    IL_0015:  call       class [mscorlib]System.Reflection.TypeInfo [mscorlib]System.Reflection.IntrospectionExtensions::GetTypeInfo(class [mscorlib]System.Type)
    IL_001a:  stloc.1
    IL_001b:  ldloc.0
    IL_001c:  ldloc.1
    IL_001d:  ldarg.1
    IL_001e:  callvirt   instance class [mscorlib]System.Reflection.MethodInfo [mscorlib]System.Reflection.TypeInfo::GetDeclaredMethod(string)
    IL_0023:  stfld      class [mscorlib]System.Reflection.MethodInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::mi
    IL_0028:  ldloc.0
    IL_0029:  ldfld      class [mscorlib]System.Reflection.MethodInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::mi
    IL_002e:  ldnull
    IL_002f:  call       bool [mscorlib]System.Reflection.MethodInfo::op_Inequality(class [mscorlib]System.Reflection.MethodInfo,
                                                                                    class [mscorlib]System.Reflection.MethodInfo)
    IL_0034:  brfalse.s  IL_007a

    IL_0036:  ldloc.0
    IL_0037:  ldfld      class [mscorlib]System.Reflection.MethodInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::mi
    IL_003c:  callvirt   instance bool [mscorlib]System.Reflection.MethodBase::get_IsStatic()
    IL_0041:  brfalse.s  IL_007a

    IL_0043:  ldloc.0
    IL_0044:  ldfld      class [mscorlib]System.Reflection.MethodInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::mi
    IL_0049:  callvirt   instance class [mscorlib]System.Reflection.ParameterInfo[] [mscorlib]System.Reflection.MethodBase::GetParameters()
    IL_004e:  ldlen
    IL_004f:  brtrue.s   IL_007a

    IL_0051:  ldloc.0
    IL_0052:  ldfld      class [mscorlib]System.Reflection.MethodInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::mi
    IL_0057:  callvirt   instance class [mscorlib]System.Type [mscorlib]System.Reflection.MethodInfo::get_ReturnType()
    IL_005c:  ldtoken    [mscorlib]System.Boolean
    IL_0061:  call       class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)
    IL_0066:  call       bool [mscorlib]System.Type::op_Equality(class [mscorlib]System.Type,
                                                                 class [mscorlib]System.Type)
    IL_006b:  brfalse.s  IL_007a

    IL_006d:  ldloc.0
    IL_006e:  ldftn      instance bool Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::'<LookupConditionalMember>b__0'()
    IL_0074:  newobj     instance void class [mscorlib]System.Func`1<bool>::.ctor(object,
                                                                                  native int)
    IL_0079:  ret

    IL_007a:  ldloc.0
    IL_007b:  ldloc.1
    IL_007c:  ldarg.1
    IL_007d:  callvirt   instance class [mscorlib]System.Reflection.PropertyInfo [mscorlib]System.Reflection.TypeInfo::GetDeclaredProperty(string)
    IL_0082:  stfld      class [mscorlib]System.Reflection.PropertyInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::pi
    IL_0087:  ldloc.0
    IL_0088:  ldfld      class [mscorlib]System.Reflection.PropertyInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::pi
    IL_008d:  ldnull
    IL_008e:  call       bool [mscorlib]System.Reflection.PropertyInfo::op_Inequality(class [mscorlib]System.Reflection.PropertyInfo,
                                                                                      class [mscorlib]System.Reflection.PropertyInfo)
    IL_0093:  brfalse.s  IL_00f6

    IL_0095:  ldloc.0
    IL_0096:  ldfld      class [mscorlib]System.Reflection.PropertyInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::pi
    IL_009b:  callvirt   instance class [mscorlib]System.Type [mscorlib]System.Reflection.PropertyInfo::get_PropertyType()
    IL_00a0:  ldtoken    [mscorlib]System.Boolean
    IL_00a5:  call       class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)
    IL_00aa:  call       bool [mscorlib]System.Type::op_Equality(class [mscorlib]System.Type,
                                                                 class [mscorlib]System.Type)
    IL_00af:  brfalse.s  IL_00f6

    IL_00b1:  ldloc.0
    IL_00b2:  ldfld      class [mscorlib]System.Reflection.PropertyInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::pi
    IL_00b7:  callvirt   instance class [mscorlib]System.Reflection.MethodInfo [mscorlib]System.Reflection.PropertyInfo::get_GetMethod()
    IL_00bc:  ldnull
    IL_00bd:  call       bool [mscorlib]System.Reflection.MethodInfo::op_Inequality(class [mscorlib]System.Reflection.MethodInfo,
                                                                                    class [mscorlib]System.Reflection.MethodInfo)
    IL_00c2:  brfalse.s  IL_00f6

    IL_00c4:  ldloc.0
    IL_00c5:  ldfld      class [mscorlib]System.Reflection.PropertyInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::pi
    IL_00ca:  callvirt   instance class [mscorlib]System.Reflection.MethodInfo [mscorlib]System.Reflection.PropertyInfo::get_GetMethod()
    IL_00cf:  callvirt   instance bool [mscorlib]System.Reflection.MethodBase::get_IsStatic()
    IL_00d4:  brfalse.s  IL_00f6

    IL_00d6:  ldloc.0
    IL_00d7:  ldfld      class [mscorlib]System.Reflection.PropertyInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::pi
    IL_00dc:  callvirt   instance class [mscorlib]System.Reflection.MethodInfo [mscorlib]System.Reflection.PropertyInfo::get_GetMethod()
    IL_00e1:  callvirt   instance class [mscorlib]System.Reflection.ParameterInfo[] [mscorlib]System.Reflection.MethodBase::GetParameters()
    IL_00e6:  ldlen
    IL_00e7:  brtrue.s   IL_00f6

    IL_00e9:  ldloc.0
    IL_00ea:  ldftn      instance bool Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::'<LookupConditionalMember>b__1'()
    IL_00f0:  newobj     instance void class [mscorlib]System.Func`1<bool>::.ctor(object,
                                                                                  native int)
    IL_00f5:  ret

    IL_00f6:  ldloc.0
    IL_00f7:  ldloc.1
    IL_00f8:  ldarg.1
    IL_00f9:  callvirt   instance class [mscorlib]System.Reflection.FieldInfo [mscorlib]System.Reflection.TypeInfo::GetDeclaredField(string)
    IL_00fe:  stfld      class [mscorlib]System.Reflection.FieldInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::fi
    IL_0103:  ldloc.0
    IL_0104:  ldfld      class [mscorlib]System.Reflection.FieldInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::fi
    IL_0109:  ldnull
    IL_010a:  call       bool [mscorlib]System.Reflection.FieldInfo::op_Inequality(class [mscorlib]System.Reflection.FieldInfo,
                                                                                   class [mscorlib]System.Reflection.FieldInfo)
    IL_010f:  brfalse.s  IL_0147

    IL_0111:  ldloc.0
    IL_0112:  ldfld      class [mscorlib]System.Reflection.FieldInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::fi
    IL_0117:  callvirt   instance class [mscorlib]System.Type [mscorlib]System.Reflection.FieldInfo::get_FieldType()
    IL_011c:  ldtoken    [mscorlib]System.Boolean
    IL_0121:  call       class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)
    IL_0126:  call       bool [mscorlib]System.Type::op_Equality(class [mscorlib]System.Type,
                                                                 class [mscorlib]System.Type)
    IL_012b:  brfalse.s  IL_0147

    IL_012d:  ldloc.0
    IL_012e:  ldfld      class [mscorlib]System.Reflection.FieldInfo Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::fi
    IL_0133:  callvirt   instance bool [mscorlib]System.Reflection.FieldInfo::get_IsStatic()
    IL_0138:  brfalse.s  IL_0147

    IL_013a:  ldloc.0
    IL_013b:  ldftn      instance bool Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer/'<>c__DisplayClass3_0'::'<LookupConditionalMember>b__2'()
    IL_0141:  newobj     instance void class [mscorlib]System.Func`1<bool>::.ctor(object,
                                                                                  native int)
    IL_0146:  ret

    IL_0147:  ldloc.1
    IL_0148:  callvirt   instance class [mscorlib]System.Type [mscorlib]System.Type::get_BaseType()
    IL_014d:  ldarg.1
    IL_014e:  call       class [mscorlib]System.Func`1<bool> Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer::LookupConditionalMember(class [mscorlib]System.Type,
                                                                                                                                                 string)
    IL_0153:  ret
  } // end of method ConditionalTestDiscoverer::LookupConditionalMember

  .method assembly hidebysig static bool 
          CheckInputToSkipExecution(object[] conditionArguments,
                                    class [mscorlib]System.Type& calleeType,
                                    string[]& conditionMemberNames,
                                    [opt] class [xunit.abstractions]Xunit.Abstractions.ITestMethod testMethod) cil managed
  {
    .param [4] = nullref
    // Code size       81 (0x51)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  brfalse.s  IL_0007

    IL_0003:  ldarg.0
    IL_0004:  ldlen
    IL_0005:  brtrue.s   IL_0009

    IL_0007:  ldc.i4.1
    IL_0008:  ret

    IL_0009:  ldarg.1
    IL_000a:  ldarg.0
    IL_000b:  ldc.i4.0
    IL_000c:  ldelem.ref
    IL_000d:  isinst     [mscorlib]System.Type
    IL_0012:  stind.ref
    IL_0013:  ldarg.1
    IL_0014:  ldind.ref
    IL_0015:  ldnull
    IL_0016:  call       bool [mscorlib]System.Type::op_Inequality(class [mscorlib]System.Type,
                                                                   class [mscorlib]System.Type)
    IL_001b:  brfalse.s  IL_0031

    IL_001d:  ldarg.0
    IL_001e:  ldlen
    IL_001f:  conv.i4
    IL_0020:  ldc.i4.2
    IL_0021:  bge.s      IL_0025

    IL_0023:  ldc.i4.1
    IL_0024:  ret

    IL_0025:  ldarg.2
    IL_0026:  ldarg.0
    IL_0027:  ldc.i4.1
    IL_0028:  ldelem.ref
    IL_0029:  isinst     string[]
    IL_002e:  stind.ref
    IL_002f:  br.s       IL_0040

    IL_0031:  ldarg.3
    IL_0032:  brtrue.s   IL_0036

    IL_0034:  ldc.i4.1
    IL_0035:  ret

    IL_0036:  ldarg.2
    IL_0037:  ldarg.0
    IL_0038:  ldc.i4.0
    IL_0039:  ldelem.ref
    IL_003a:  isinst     string[]
    IL_003f:  stind.ref
    IL_0040:  ldarg.2
    IL_0041:  ldind.ref
    IL_0042:  brfalse.s  IL_004d

    IL_0044:  ldarg.2
    IL_0045:  ldind.ref
    IL_0046:  call       int32 [System.Core]System.Linq.Enumerable::Count<string>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_004b:  brtrue.s   IL_004f

    IL_004d:  ldc.i4.1
    IL_004e:  ret

    IL_004f:  ldc.i4.0
    IL_0050:  ret
  } // end of method ConditionalTestDiscoverer::CheckInputToSkipExecution

} // end of class Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.ConditionalTheoryDiscoverer
       extends [xunit.execution.desktop]Xunit.Sdk.TheoryDiscoverer
{
  .field private initonly class [mscorlib]System.Collections.Generic.Dictionary`2<class [xunit.abstractions]Xunit.Abstractions.IMethodInfo,string> _conditionCache
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink diagnosticMessageSink) cil managed
  {
    // Code size       19 (0x13)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       instance void [xunit.execution.desktop]Xunit.Sdk.TheoryDiscoverer::.ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink)
    IL_0007:  ldarg.0
    IL_0008:  newobj     instance void class [mscorlib]System.Collections.Generic.Dictionary`2<class [xunit.abstractions]Xunit.Abstractions.IMethodInfo,string>::.ctor()
    IL_000d:  stfld      class [mscorlib]System.Collections.Generic.Dictionary`2<class [xunit.abstractions]Xunit.Abstractions.IMethodInfo,string> Microsoft.DotNet.XUnitExtensions.ConditionalTheoryDiscoverer::_conditionCache
    IL_0012:  ret
  } // end of method ConditionalTheoryDiscoverer::.ctor

  .method family hidebysig virtual instance class [mscorlib]System.Collections.Generic.IEnumerable`1<class [xunit.core]Xunit.Sdk.IXunitTestCase> 
          CreateTestCasesForTheory(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions,
                                   class [xunit.abstractions]Xunit.Abstractions.ITestMethod testMethod,
                                   class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo theoryAttribute) cil managed
  {
    // Code size       116 (0x74)
    .maxstack  9
    .locals init (string V_0,
             class [xunit.execution.desktop]Xunit.Sdk.ExecutionErrorTestCase V_1,
             class [xunit.core]Xunit.Sdk.IXunitTestCase[] V_2)
    IL_0000:  ldarg.1
    IL_0001:  ldarg.0
    IL_0002:  call       instance class [xunit.abstractions]Xunit.Abstractions.IMessageSink [xunit.execution.desktop]Xunit.Sdk.TheoryDiscoverer::get_DiagnosticMessageSink()
    IL_0007:  ldarg.2
    IL_0008:  ldarg.3
    IL_0009:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerable`1<object> [xunit.abstractions]Xunit.Abstractions.IAttributeInfo::GetConstructorArguments()
    IL_000e:  call       !!0[] [System.Core]System.Linq.Enumerable::ToArray<object>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_0013:  ldloca.s   V_0
    IL_0015:  ldloca.s   V_1
    IL_0017:  call       bool Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer::TryEvaluateSkipConditions(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions,
                                                                                                                    class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                                                    class [xunit.abstractions]Xunit.Abstractions.ITestMethod,
                                                                                                                    object[],
                                                                                                                    string&,
                                                                                                                    class [xunit.execution.desktop]Xunit.Sdk.ExecutionErrorTestCase&)
    IL_001c:  brfalse.s  IL_0069

    IL_001e:  ldloc.0
    IL_001f:  brtrue.s   IL_0043

    IL_0021:  ldc.i4.1
    IL_0022:  newarr     [xunit.core]Xunit.Sdk.IXunitTestCase
    IL_0027:  dup
    IL_0028:  ldc.i4.0
    IL_0029:  ldarg.0
    IL_002a:  call       instance class [xunit.abstractions]Xunit.Abstractions.IMessageSink [xunit.execution.desktop]Xunit.Sdk.TheoryDiscoverer::get_DiagnosticMessageSink()
    IL_002f:  ldarg.1
    IL_0030:  call       valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay [xunit.execution.desktop]TestFrameworkOptionsReadExtensions::MethodDisplayOrDefault(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions)
    IL_0035:  ldarg.1
    IL_0036:  call       valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions [xunit.execution.desktop]TestFrameworkOptionsReadExtensions::MethodDisplayOptionsOrDefault(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions)
    IL_003b:  ldarg.2
    IL_003c:  newobj     instance void Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase::.ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                                     valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay,
                                                                                                     valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions,
                                                                                                     class [xunit.abstractions]Xunit.Abstractions.ITestMethod)
    IL_0041:  stelem.ref
    IL_0042:  ret

    IL_0043:  ldc.i4.1
    IL_0044:  newarr     Microsoft.DotNet.XUnitExtensions.SkippedTestCase
    IL_0049:  dup
    IL_004a:  ldc.i4.0
    IL_004b:  ldloc.0
    IL_004c:  ldarg.0
    IL_004d:  call       instance class [xunit.abstractions]Xunit.Abstractions.IMessageSink [xunit.execution.desktop]Xunit.Sdk.TheoryDiscoverer::get_DiagnosticMessageSink()
    IL_0052:  ldarg.1
    IL_0053:  call       valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay [xunit.execution.desktop]TestFrameworkOptionsReadExtensions::MethodDisplayOrDefault(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions)
    IL_0058:  ldarg.1
    IL_0059:  call       valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions [xunit.execution.desktop]TestFrameworkOptionsReadExtensions::MethodDisplayOptionsOrDefault(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions)
    IL_005e:  ldarg.2
    IL_005f:  ldnull
    IL_0060:  newobj     instance void Microsoft.DotNet.XUnitExtensions.SkippedTestCase::.ctor(string,
                                                                                               class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay,
                                                                                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions,
                                                                                               class [xunit.abstractions]Xunit.Abstractions.ITestMethod,
                                                                                               object[])
    IL_0065:  stelem.ref
    IL_0066:  stloc.2
    IL_0067:  ldloc.2
    IL_0068:  ret

    IL_0069:  ldc.i4.1
    IL_006a:  newarr     [xunit.core]Xunit.Sdk.IXunitTestCase
    IL_006f:  dup
    IL_0070:  ldc.i4.0
    IL_0071:  ldloc.1
    IL_0072:  stelem.ref
    IL_0073:  ret
  } // end of method ConditionalTheoryDiscoverer::CreateTestCasesForTheory

  .method family hidebysig virtual instance class [mscorlib]System.Collections.Generic.IEnumerable`1<class [xunit.core]Xunit.Sdk.IXunitTestCase> 
          CreateTestCasesForDataRow(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions,
                                    class [xunit.abstractions]Xunit.Abstractions.ITestMethod testMethod,
                                    class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo theoryAttribute,
                                    object[] dataRow) cil managed
  {
    // Code size       167 (0xa7)
    .maxstack  8
    .locals init (class [xunit.abstractions]Xunit.Abstractions.IMethodInfo V_0,
             class [mscorlib]System.Collections.Generic.List`1<class [xunit.core]Xunit.Sdk.IXunitTestCase> V_1,
             string V_2,
             class [xunit.execution.desktop]Xunit.Sdk.ExecutionErrorTestCase V_3,
             class [mscorlib]System.Collections.Generic.IEnumerable`1<class [xunit.core]Xunit.Sdk.IXunitTestCase> V_4)
    IL_0000:  ldarg.2
    IL_0001:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.IMethodInfo [xunit.abstractions]Xunit.Abstractions.ITestMethod::get_Method()
    IL_0006:  stloc.0
    IL_0007:  newobj     instance void class [mscorlib]System.Collections.Generic.List`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::.ctor()
    IL_000c:  stloc.1
    IL_000d:  ldarg.0
    IL_000e:  ldfld      class [mscorlib]System.Collections.Generic.Dictionary`2<class [xunit.abstractions]Xunit.Abstractions.IMethodInfo,string> Microsoft.DotNet.XUnitExtensions.ConditionalTheoryDiscoverer::_conditionCache
    IL_0013:  ldloc.0
    IL_0014:  ldloca.s   V_2
    IL_0016:  callvirt   instance bool class [mscorlib]System.Collections.Generic.Dictionary`2<class [xunit.abstractions]Xunit.Abstractions.IMethodInfo,string>::TryGetValue(!0,
                                                                                                                                                                             !1&)
    IL_001b:  brtrue.s   IL_0076

    IL_001d:  ldarg.1
    IL_001e:  ldarg.0
    IL_001f:  call       instance class [xunit.abstractions]Xunit.Abstractions.IMessageSink [xunit.execution.desktop]Xunit.Sdk.TheoryDiscoverer::get_DiagnosticMessageSink()
    IL_0024:  ldarg.2
    IL_0025:  ldarg.3
    IL_0026:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerable`1<object> [xunit.abstractions]Xunit.Abstractions.IAttributeInfo::GetConstructorArguments()
    IL_002b:  call       !!0[] [System.Core]System.Linq.Enumerable::ToArray<object>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_0030:  ldloca.s   V_2
    IL_0032:  ldloca.s   V_3
    IL_0034:  call       bool Microsoft.DotNet.XUnitExtensions.ConditionalTestDiscoverer::TryEvaluateSkipConditions(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions,
                                                                                                                    class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                                                    class [xunit.abstractions]Xunit.Abstractions.ITestMethod,
                                                                                                                    object[],
                                                                                                                    string&,
                                                                                                                    class [xunit.execution.desktop]Xunit.Sdk.ExecutionErrorTestCase&)
    IL_0039:  brtrue.s   IL_0046

    IL_003b:  ldc.i4.1
    IL_003c:  newarr     [xunit.core]Xunit.Sdk.IXunitTestCase
    IL_0041:  dup
    IL_0042:  ldc.i4.0
    IL_0043:  ldloc.3
    IL_0044:  stelem.ref
    IL_0045:  ret

    IL_0046:  ldarg.0
    IL_0047:  ldfld      class [mscorlib]System.Collections.Generic.Dictionary`2<class [xunit.abstractions]Xunit.Abstractions.IMethodInfo,string> Microsoft.DotNet.XUnitExtensions.ConditionalTheoryDiscoverer::_conditionCache
    IL_004c:  ldloc.0
    IL_004d:  ldloc.2
    IL_004e:  callvirt   instance void class [mscorlib]System.Collections.Generic.Dictionary`2<class [xunit.abstractions]Xunit.Abstractions.IMethodInfo,string>::Add(!0,
                                                                                                                                                                     !1)
    IL_0053:  ldloc.2
    IL_0054:  brfalse.s  IL_0076

    IL_0056:  ldloc.1
    IL_0057:  ldloc.2
    IL_0058:  ldarg.0
    IL_0059:  call       instance class [xunit.abstractions]Xunit.Abstractions.IMessageSink [xunit.execution.desktop]Xunit.Sdk.TheoryDiscoverer::get_DiagnosticMessageSink()
    IL_005e:  ldarg.1
    IL_005f:  call       valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay [xunit.execution.desktop]TestFrameworkOptionsReadExtensions::MethodDisplayOrDefault(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions)
    IL_0064:  ldarg.1
    IL_0065:  call       valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions [xunit.execution.desktop]TestFrameworkOptionsReadExtensions::MethodDisplayOptionsOrDefault(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions)
    IL_006a:  ldarg.2
    IL_006b:  ldnull
    IL_006c:  newobj     instance void Microsoft.DotNet.XUnitExtensions.SkippedTestCase::.ctor(string,
                                                                                               class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay,
                                                                                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions,
                                                                                               class [xunit.abstractions]Xunit.Abstractions.ITestMethod,
                                                                                               object[])
    IL_0071:  callvirt   instance void class [mscorlib]System.Collections.Generic.List`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::Add(!0)
    IL_0076:  ldloc.2
    IL_0077:  brtrue.s   IL_00a1

    IL_0079:  ldc.i4.1
    IL_007a:  newarr     Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase
    IL_007f:  dup
    IL_0080:  ldc.i4.0
    IL_0081:  ldarg.0
    IL_0082:  call       instance class [xunit.abstractions]Xunit.Abstractions.IMessageSink [xunit.execution.desktop]Xunit.Sdk.TheoryDiscoverer::get_DiagnosticMessageSink()
    IL_0087:  ldarg.1
    IL_0088:  call       valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay [xunit.execution.desktop]TestFrameworkOptionsReadExtensions::MethodDisplayOrDefault(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions)
    IL_008d:  ldarg.1
    IL_008e:  call       valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions [xunit.execution.desktop]TestFrameworkOptionsReadExtensions::MethodDisplayOptionsOrDefault(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions)
    IL_0093:  ldarg.2
    IL_0094:  ldarg.s    dataRow
    IL_0096:  newobj     instance void Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase::.ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                                   valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay,
                                                                                                   valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions,
                                                                                                   class [xunit.abstractions]Xunit.Abstractions.ITestMethod,
                                                                                                   object[])
    IL_009b:  stelem.ref
    IL_009c:  stloc.s    V_4
    IL_009e:  ldloc.s    V_4
    IL_00a0:  ret

    IL_00a1:  ldloc.1
    IL_00a2:  stloc.s    V_4
    IL_00a4:  ldloc.s    V_4
    IL_00a6:  ret
  } // end of method ConditionalTheoryDiscoverer::CreateTestCasesForDataRow

} // end of class Microsoft.DotNet.XUnitExtensions.ConditionalTheoryDiscoverer

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.OuterLoopTestsDiscoverer
       extends [mscorlib]System.Object
       implements [xunit.core]Xunit.Sdk.ITraitDiscoverer
{
  .method public hidebysig newslot virtual final 
          instance class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> 
          GetTraits(class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo traitAttribute) cil managed
  {
    // Code size       58 (0x3a)
    .maxstack  5
    .locals init (class [mscorlib]System.Collections.Generic.IEnumerable`1<object> V_0)
    IL_0000:  ldarg.1
    IL_0001:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerable`1<object> [xunit.abstractions]Xunit.Abstractions.IAttributeInfo::GetConstructorArguments()
    IL_0006:  stloc.0
    IL_0007:  ldloc.0
    IL_0008:  call       int32 [System.Core]System.Linq.Enumerable::Count<object>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_000d:  ldc.i4.2
    IL_000e:  bge.s      IL_002d

    IL_0010:  ldc.i4.1
    IL_0011:  newarr     valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
    IL_0016:  dup
    IL_0017:  ldc.i4.0
    IL_0018:  ldstr      "category"
    IL_001d:  ldstr      "outerloop"
    IL_0022:  newobj     instance void valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>::.ctor(!0,
                                                                                                                           !1)
    IL_0027:  stelem     valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
    IL_002c:  ret

    IL_002d:  ldloc.0
    IL_002e:  ldstr      "outerloop"
    IL_0033:  ldc.i4.1
    IL_0034:  call       class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::EvaluateArguments(class [mscorlib]System.Collections.Generic.IEnumerable`1<object>,
                                                                                                                                                                                                                                      string,
                                                                                                                                                                                                                                      int32)
    IL_0039:  ret
  } // end of method OuterLoopTestsDiscoverer::GetTraits

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method OuterLoopTestsDiscoverer::.ctor

} // end of class Microsoft.DotNet.XUnitExtensions.OuterLoopTestsDiscoverer

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.ParallelTheoryDiscoverer
       extends [xunit.execution.desktop]Xunit.Sdk.TheoryDiscoverer
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink diagnosticMessageSink) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       instance void [xunit.execution.desktop]Xunit.Sdk.TheoryDiscoverer::.ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink)
    IL_0007:  ret
  } // end of method ParallelTheoryDiscoverer::.ctor

  .method family hidebysig virtual instance class [mscorlib]System.Collections.Generic.IEnumerable`1<class [xunit.core]Xunit.Sdk.IXunitTestCase> 
          CreateTestCasesForTheory(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions,
                                   class [xunit.abstractions]Xunit.Abstractions.ITestMethod testMethod,
                                   class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo theoryAttribute) cil managed
  {
    // Code size       34 (0x22)
    .maxstack  8
    IL_0000:  ldc.i4.1
    IL_0001:  newarr     Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCase
    IL_0006:  dup
    IL_0007:  ldc.i4.0
    IL_0008:  ldarg.0
    IL_0009:  call       instance class [xunit.abstractions]Xunit.Abstractions.IMessageSink [xunit.execution.desktop]Xunit.Sdk.TheoryDiscoverer::get_DiagnosticMessageSink()
    IL_000e:  ldarg.1
    IL_000f:  call       valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay [xunit.execution.desktop]TestFrameworkOptionsReadExtensions::MethodDisplayOrDefault(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions)
    IL_0014:  ldarg.1
    IL_0015:  call       valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions [xunit.execution.desktop]TestFrameworkOptionsReadExtensions::MethodDisplayOptionsOrDefault(class [xunit.abstractions]Xunit.Abstractions.ITestFrameworkDiscoveryOptions)
    IL_001a:  ldarg.2
    IL_001b:  newobj     instance void Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCase::.ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                                           valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay,
                                                                                                           valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions,
                                                                                                           class [xunit.abstractions]Xunit.Abstractions.ITestMethod)
    IL_0020:  stelem.ref
    IL_0021:  ret
  } // end of method ParallelTheoryDiscoverer::CreateTestCasesForTheory

} // end of class Microsoft.DotNet.XUnitExtensions.ParallelTheoryDiscoverer

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.PlatformSpecificDiscoverer
       extends [mscorlib]System.Object
       implements [xunit.core]Xunit.Sdk.ITraitDiscoverer
{
  .method public hidebysig newslot virtual final 
          instance class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> 
          GetTraits(class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo traitAttribute) cil managed
  {
    // Code size       60 (0x3c)
    .maxstack  5
    .locals init (valuetype Xunit.TestPlatforms V_0)
    IL_0000:  ldarg.1
    IL_0001:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerable`1<object> [xunit.abstractions]Xunit.Abstractions.IAttributeInfo::GetConstructorArguments()
    IL_0006:  call       !!0 [System.Core]System.Linq.Enumerable::First<object>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_000b:  unbox.any  Xunit.TestPlatforms
    IL_0010:  stloc.0
    IL_0011:  ldloc.0
    IL_0012:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::TestPlatformApplies(valuetype Xunit.TestPlatforms)
    IL_0017:  brtrue.s   IL_0036

    IL_0019:  ldc.i4.1
    IL_001a:  newarr     valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
    IL_001f:  dup
    IL_0020:  ldc.i4.0
    IL_0021:  ldstr      "category"
    IL_0026:  ldstr      "failing"
    IL_002b:  newobj     instance void valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>::.ctor(!0,
                                                                                                                           !1)
    IL_0030:  stelem     valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
    IL_0035:  ret

    IL_0036:  call       !!0[] [mscorlib]System.Array::Empty<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>()
    IL_003b:  ret
  } // end of method PlatformSpecificDiscoverer::GetTraits

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method PlatformSpecificDiscoverer::.ctor

} // end of class Microsoft.DotNet.XUnitExtensions.PlatformSpecificDiscoverer

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer
       extends [mscorlib]System.Object
       implements [xunit.core]Xunit.Sdk.ITraitDiscoverer
{
  .class auto ansi sealed nested private beforefieldinit '<GetTraits>d__0'
         extends [mscorlib]System.Object
         implements class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>,
                    [mscorlib]System.Collections.IEnumerable,
                    class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>,
                    [mscorlib]System.IDisposable,
                    [mscorlib]System.Collections.IEnumerator
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field private int32 '<>1__state'
    .field private valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> '<>2__current'
    .field private int32 '<>l__initialThreadId'
    .method public hidebysig specialname rtspecialname 
            instance void  .ctor(int32 '<>1__state') cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      // Code size       25 (0x19)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ldarg.0
      IL_0007:  ldarg.1
      IL_0008:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_000d:  ldarg.0
      IL_000e:  call       int32 [mscorlib]System.Environment::get_CurrentManagedThreadId()
      IL_0013:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::'<>l__initialThreadId'
      IL_0018:  ret
    } // end of method '<GetTraits>d__0'::.ctor

    .method private hidebysig newslot virtual final 
            instance void  System.IDisposable.Dispose() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.IDisposable::Dispose
      // Code size       1 (0x1)
      .maxstack  8
      IL_0000:  ret
    } // end of method '<GetTraits>d__0'::System.IDisposable.Dispose

    .method private hidebysig newslot virtual final 
            instance bool  MoveNext() cil managed
    {
      .override [mscorlib]System.Collections.IEnumerator::MoveNext
      // Code size       113 (0x71)
      .maxstack  3
      .locals init (int32 V_0)
      IL_0000:  ldarg.0
      IL_0001:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_0006:  stloc.0
      IL_0007:  ldloc.0
      IL_0008:  brfalse.s  IL_0010

      IL_000a:  ldloc.0
      IL_000b:  ldc.i4.1
      IL_000c:  beq.s      IL_0068

      IL_000e:  ldc.i4.0
      IL_000f:  ret

      IL_0010:  ldarg.0
      IL_0011:  ldc.i4.m1
      IL_0012:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_0017:  ldstr      "DOTNET_CI"
      IL_001c:  call       string [mscorlib]System.Environment::GetEnvironmentVariable(string)
      IL_0021:  call       bool [mscorlib]System.String::IsNullOrEmpty(string)
      IL_0026:  brfalse.s  IL_004a

      IL_0028:  ldstr      "HELIX_WORKITEM_ROOT"
      IL_002d:  call       string [mscorlib]System.Environment::GetEnvironmentVariable(string)
      IL_0032:  call       bool [mscorlib]System.String::IsNullOrEmpty(string)
      IL_0037:  brfalse.s  IL_004a

      IL_0039:  ldstr      "AGENT_OS"
      IL_003e:  call       string [mscorlib]System.Environment::GetEnvironmentVariable(string)
      IL_0043:  call       bool [mscorlib]System.String::IsNullOrEmpty(string)
      IL_0048:  brtrue.s   IL_006f

      IL_004a:  ldarg.0
      IL_004b:  ldstr      "category"
      IL_0050:  ldstr      "failing"
      IL_0055:  newobj     instance void valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>::.ctor(!0,
                                                                                                                             !1)
      IL_005a:  stfld      valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::'<>2__current'
      IL_005f:  ldarg.0
      IL_0060:  ldc.i4.1
      IL_0061:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_0066:  ldc.i4.1
      IL_0067:  ret

      IL_0068:  ldarg.0
      IL_0069:  ldc.i4.m1
      IL_006a:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_006f:  ldc.i4.0
      IL_0070:  ret
    } // end of method '<GetTraits>d__0'::MoveNext

    .method private hidebysig newslot specialname virtual final 
            instance valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> 
            'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current'() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override  method instance !0 class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>::get_Current()
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldfld      valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::'<>2__current'
      IL_0006:  ret
    } // end of method '<GetTraits>d__0'::'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current'

    .method private hidebysig newslot virtual final 
            instance void  System.Collections.IEnumerator.Reset() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.Collections.IEnumerator::Reset
      // Code size       6 (0x6)
      .maxstack  8
      IL_0000:  newobj     instance void [mscorlib]System.NotSupportedException::.ctor()
      IL_0005:  throw
    } // end of method '<GetTraits>d__0'::System.Collections.IEnumerator.Reset

    .method private hidebysig newslot specialname virtual final 
            instance object  System.Collections.IEnumerator.get_Current() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.Collections.IEnumerator::get_Current
      // Code size       12 (0xc)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldfld      valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::'<>2__current'
      IL_0006:  box        valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
      IL_000b:  ret
    } // end of method '<GetTraits>d__0'::System.Collections.IEnumerator.get_Current

    .method private hidebysig newslot virtual final 
            instance class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> 
            'System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator'() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override  method instance class [mscorlib]System.Collections.Generic.IEnumerator`1<!0> class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>::GetEnumerator()
      // Code size       43 (0x2b)
      .maxstack  2
      .locals init (class Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0' V_0)
      IL_0000:  ldarg.0
      IL_0001:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_0006:  ldc.i4.s   -2
      IL_0008:  bne.un.s   IL_0022

      IL_000a:  ldarg.0
      IL_000b:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::'<>l__initialThreadId'
      IL_0010:  call       int32 [mscorlib]System.Environment::get_CurrentManagedThreadId()
      IL_0015:  bne.un.s   IL_0022

      IL_0017:  ldarg.0
      IL_0018:  ldc.i4.0
      IL_0019:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_001e:  ldarg.0
      IL_001f:  stloc.0
      IL_0020:  br.s       IL_0029

      IL_0022:  ldc.i4.0
      IL_0023:  newobj     instance void Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::.ctor(int32)
      IL_0028:  stloc.0
      IL_0029:  ldloc.0
      IL_002a:  ret
    } // end of method '<GetTraits>d__0'::'System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator'

    .method private hidebysig newslot virtual final 
            instance class [mscorlib]System.Collections.IEnumerator 
            System.Collections.IEnumerable.GetEnumerator() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.Collections.IEnumerable::GetEnumerator
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::'System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator'()
      IL_0006:  ret
    } // end of method '<GetTraits>d__0'::System.Collections.IEnumerable.GetEnumerator

    .property instance valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
            'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current'()
    {
      .get instance valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current'()
    } // end of property '<GetTraits>d__0'::'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current'
    .property instance object System.Collections.IEnumerator.Current()
    {
      .get instance object Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::System.Collections.IEnumerator.get_Current()
    } // end of property '<GetTraits>d__0'::System.Collections.IEnumerator.Current
  } // end of class '<GetTraits>d__0'

  .method public hidebysig newslot virtual final 
          instance class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> 
          GetTraits(class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo traitAttribute) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.IteratorStateMachineAttribute::.ctor(class [mscorlib]System.Type) = ( 01 00 43 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..CMicrosoft.Dot
                                                                                                                                          4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                                                                          6F 6E 73 2E 53 6B 69 70 4F 6E 43 49 44 69 73 63   // ons.SkipOnCIDisc
                                                                                                                                          6F 76 65 72 65 72 2B 3C 47 65 74 54 72 61 69 74   // overer+<GetTrait
                                                                                                                                          73 3E 64 5F 5F 30 00 00 )                         // s>d__0..
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldc.i4.s   -2
    IL_0002:  newobj     instance void Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer/'<GetTraits>d__0'::.ctor(int32)
    IL_0007:  ret
  } // end of method SkipOnCIDiscoverer::GetTraits

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method SkipOnCIDiscoverer::.ctor

} // end of class Microsoft.DotNet.XUnitExtensions.SkipOnCIDiscoverer

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer
       extends [mscorlib]System.Object
       implements [xunit.core]Xunit.Sdk.ITraitDiscoverer
{
  .class auto ansi serializable sealed nested private beforefieldinit '<>c'
         extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field public static initonly class Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c' '<>9'
    .method private hidebysig specialname rtspecialname static 
            void  .cctor() cil managed
    {
      // Code size       11 (0xb)
      .maxstack  8
      IL_0000:  newobj     instance void Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::.ctor()
      IL_0005:  stsfld     class Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c' Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<>9'
      IL_000a:  ret
    } // end of method '<>c'::.cctor

    .method public hidebysig specialname rtspecialname 
            instance void  .ctor() cil managed
    {
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ret
    } // end of method '<>c'::.ctor

    .method assembly hidebysig instance bool 
            '<.cctor>b__15_0'() cil managed
    {
      // Code size       6 (0x6)
      .maxstack  8
      IL_0000:  call       bool Xunit.CoreClrConfigurationDetection::get_IsJitStress()
      IL_0005:  ret
    } // end of method '<>c'::'<.cctor>b__15_0'

    .method assembly hidebysig instance bool 
            '<.cctor>b__15_1'() cil managed
    {
      // Code size       6 (0x6)
      .maxstack  8
      IL_0000:  call       bool Xunit.CoreClrConfigurationDetection::get_IsJitStressRegs()
      IL_0005:  ret
    } // end of method '<>c'::'<.cctor>b__15_1'

    .method assembly hidebysig instance bool 
            '<.cctor>b__15_2'() cil managed
    {
      // Code size       6 (0x6)
      .maxstack  8
      IL_0000:  call       bool Xunit.CoreClrConfigurationDetection::get_IsJitMinOpts()
      IL_0005:  ret
    } // end of method '<>c'::'<.cctor>b__15_2'

    .method assembly hidebysig instance bool 
            '<.cctor>b__15_3'() cil managed
    {
      // Code size       6 (0x6)
      .maxstack  8
      IL_0000:  call       bool Xunit.CoreClrConfigurationDetection::get_IsTailCallStress()
      IL_0005:  ret
    } // end of method '<>c'::'<.cctor>b__15_3'

    .method assembly hidebysig instance bool 
            '<.cctor>b__15_4'() cil managed
    {
      // Code size       6 (0x6)
      .maxstack  8
      IL_0000:  call       bool Xunit.CoreClrConfigurationDetection::get_IsZapDisable()
      IL_0005:  ret
    } // end of method '<>c'::'<.cctor>b__15_4'

    .method assembly hidebysig instance bool 
            '<.cctor>b__15_5'() cil managed
    {
      // Code size       6 (0x6)
      .maxstack  8
      IL_0000:  call       bool Xunit.CoreClrConfigurationDetection::get_IsGCStress3()
      IL_0005:  ret
    } // end of method '<>c'::'<.cctor>b__15_5'

    .method assembly hidebysig instance bool 
            '<.cctor>b__15_6'() cil managed
    {
      // Code size       6 (0x6)
      .maxstack  8
      IL_0000:  call       bool Xunit.CoreClrConfigurationDetection::get_IsGCStressC()
      IL_0005:  ret
    } // end of method '<>c'::'<.cctor>b__15_6'

    .method assembly hidebysig instance bool 
            '<.cctor>b__15_7'() cil managed
    {
      // Code size       6 (0x6)
      .maxstack  8
      IL_0000:  call       bool Xunit.CoreClrConfigurationDetection::get_IsCheckedRuntime()
      IL_0005:  ret
    } // end of method '<>c'::'<.cctor>b__15_7'

    .method assembly hidebysig instance bool 
            '<.cctor>b__15_8'() cil managed
    {
      // Code size       6 (0x6)
      .maxstack  8
      IL_0000:  call       bool Xunit.CoreClrConfigurationDetection::get_IsReleaseRuntime()
      IL_0005:  ret
    } // end of method '<>c'::'<.cctor>b__15_8'

    .method assembly hidebysig instance bool 
            '<.cctor>b__15_9'() cil managed
    {
      // Code size       6 (0x6)
      .maxstack  8
      IL_0000:  call       bool Xunit.CoreClrConfigurationDetection::get_IsDebugRuntime()
      IL_0005:  ret
    } // end of method '<>c'::'<.cctor>b__15_9'

    .method assembly hidebysig instance bool 
            '<.cctor>b__15_10'() cil managed
    {
      // Code size       6 (0x6)
      .maxstack  8
      IL_0000:  call       bool Xunit.CoreClrConfigurationDetection::get_IsStressTest()
      IL_0005:  ret
    } // end of method '<>c'::'<.cctor>b__15_10'

  } // end of class '<>c'

  .field private static initonly class [mscorlib]System.Lazy`1<bool> s_isJitStress
  .field private static initonly class [mscorlib]System.Lazy`1<bool> s_isJitStressRegs
  .field private static initonly class [mscorlib]System.Lazy`1<bool> s_isJitMinOpts
  .field private static initonly class [mscorlib]System.Lazy`1<bool> s_isTailCallStress
  .field private static initonly class [mscorlib]System.Lazy`1<bool> s_isZapDisable
  .field private static initonly class [mscorlib]System.Lazy`1<bool> s_isGCStress3
  .field private static initonly class [mscorlib]System.Lazy`1<bool> s_isGCStressC
  .field private static initonly class [mscorlib]System.Lazy`1<bool> s_isCheckedRuntime
  .field private static initonly class [mscorlib]System.Lazy`1<bool> s_isReleaseRuntime
  .field private static initonly class [mscorlib]System.Lazy`1<bool> s_isDebugRuntime
  .field private static initonly class [mscorlib]System.Lazy`1<bool> s_isStressTest
  .method public hidebysig newslot virtual final 
          instance class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> 
          GetTraits(class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo traitAttribute) cil managed
  {
    // Code size       190 (0xbe)
    .maxstack  5
    .locals init (valuetype Xunit.TestPlatforms V_0,
             valuetype Xunit.RuntimeTestModes V_1,
             valuetype Xunit.RuntimeConfiguration V_2,
             class [mscorlib]System.Collections.Generic.IEnumerator`1<object> V_3,
             object V_4,
             valuetype Xunit.TestPlatforms V_5,
             valuetype Xunit.RuntimeTestModes V_6,
             valuetype Xunit.RuntimeConfiguration V_7)
    IL_0000:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::get_IsMonoRuntime()
    IL_0005:  brtrue     IL_00b8

    IL_000a:  ldc.i4.m1
    IL_000b:  stloc.0
    IL_000c:  ldc.i4.m1
    IL_000d:  stloc.1
    IL_000e:  ldc.i4.m1
    IL_000f:  stloc.2
    IL_0010:  ldarg.1
    IL_0011:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerable`1<object> [xunit.abstractions]Xunit.Abstractions.IAttributeInfo::GetConstructorArguments()
    IL_0016:  ldc.i4.1
    IL_0017:  call       class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0> [System.Core]System.Linq.Enumerable::Skip<object>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>,
                                                                                                                                         int32)
    IL_001c:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerator`1<!0> class [mscorlib]System.Collections.Generic.IEnumerable`1<object>::GetEnumerator()
    IL_0021:  stloc.3
    .try
    {
      IL_0022:  br.s       IL_006f

      IL_0024:  ldloc.3
      IL_0025:  callvirt   instance !0 class [mscorlib]System.Collections.Generic.IEnumerator`1<object>::get_Current()
      IL_002a:  stloc.s    V_4
      IL_002c:  ldloc.s    V_4
      IL_002e:  isinst     Xunit.TestPlatforms
      IL_0033:  brfalse.s  IL_0043

      IL_0035:  ldloc.s    V_4
      IL_0037:  unbox.any  Xunit.TestPlatforms
      IL_003c:  stloc.s    V_5
      IL_003e:  ldloc.s    V_5
      IL_0040:  stloc.0
      IL_0041:  br.s       IL_006f

      IL_0043:  ldloc.s    V_4
      IL_0045:  isinst     Xunit.RuntimeTestModes
      IL_004a:  brfalse.s  IL_005a

      IL_004c:  ldloc.s    V_4
      IL_004e:  unbox.any  Xunit.RuntimeTestModes
      IL_0053:  stloc.s    V_6
      IL_0055:  ldloc.s    V_6
      IL_0057:  stloc.1
      IL_0058:  br.s       IL_006f

      IL_005a:  ldloc.s    V_4
      IL_005c:  isinst     Xunit.RuntimeConfiguration
      IL_0061:  brfalse.s  IL_006f

      IL_0063:  ldloc.s    V_4
      IL_0065:  unbox.any  Xunit.RuntimeConfiguration
      IL_006a:  stloc.s    V_7
      IL_006c:  ldloc.s    V_7
      IL_006e:  stloc.2
      IL_006f:  ldloc.3
      IL_0070:  callvirt   instance bool [mscorlib]System.Collections.IEnumerator::MoveNext()
      IL_0075:  brtrue.s   IL_0024

      IL_0077:  leave.s    IL_0083

    }  // end .try
    finally
    {
      IL_0079:  ldloc.3
      IL_007a:  brfalse.s  IL_0082

      IL_007c:  ldloc.3
      IL_007d:  callvirt   instance void [mscorlib]System.IDisposable::Dispose()
      IL_0082:  endfinally
    }  // end handler
    IL_0083:  ldloc.0
    IL_0084:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::TestPlatformApplies(valuetype Xunit.TestPlatforms)
    IL_0089:  brfalse.s  IL_00b8

    IL_008b:  ldloc.2
    IL_008c:  call       bool Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::RuntimeConfigurationApplies(valuetype Xunit.RuntimeConfiguration)
    IL_0091:  brfalse.s  IL_00b8

    IL_0093:  ldloc.1
    IL_0094:  call       bool Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::StressModeApplies(valuetype Xunit.RuntimeTestModes)
    IL_0099:  brfalse.s  IL_00b8

    IL_009b:  ldc.i4.1
    IL_009c:  newarr     valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
    IL_00a1:  dup
    IL_00a2:  ldc.i4.0
    IL_00a3:  ldstr      "category"
    IL_00a8:  ldstr      "failing"
    IL_00ad:  newobj     instance void valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>::.ctor(!0,
                                                                                                                           !1)
    IL_00b2:  stelem     valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
    IL_00b7:  ret

    IL_00b8:  call       !!0[] [mscorlib]System.Array::Empty<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>()
    IL_00bd:  ret
  } // end of method SkipOnCoreClrDiscoverer::GetTraits

  .method private hidebysig static bool  RuntimeConfigurationApplies(valuetype Xunit.RuntimeConfiguration runtimeConfigurations) cil managed
  {
    // Code size       96 (0x60)
    .maxstack  2
    IL_0000:  ldarg.0
    IL_0001:  box        Xunit.RuntimeConfiguration
    IL_0006:  ldc.i4.1
    IL_0007:  box        Xunit.RuntimeConfiguration
    IL_000c:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_0011:  brfalse.s  IL_001f

    IL_0013:  ldsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isCheckedRuntime
    IL_0018:  callvirt   instance !0 class [mscorlib]System.Lazy`1<bool>::get_Value()
    IL_001d:  brtrue.s   IL_005e

    IL_001f:  ldarg.0
    IL_0020:  box        Xunit.RuntimeConfiguration
    IL_0025:  ldc.i4.4
    IL_0026:  box        Xunit.RuntimeConfiguration
    IL_002b:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_0030:  brfalse.s  IL_003e

    IL_0032:  ldsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isReleaseRuntime
    IL_0037:  callvirt   instance !0 class [mscorlib]System.Lazy`1<bool>::get_Value()
    IL_003c:  brtrue.s   IL_005e

    IL_003e:  ldarg.0
    IL_003f:  box        Xunit.RuntimeConfiguration
    IL_0044:  ldc.i4.2
    IL_0045:  box        Xunit.RuntimeConfiguration
    IL_004a:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_004f:  brfalse.s  IL_005c

    IL_0051:  ldsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isDebugRuntime
    IL_0056:  callvirt   instance !0 class [mscorlib]System.Lazy`1<bool>::get_Value()
    IL_005b:  ret

    IL_005c:  ldc.i4.0
    IL_005d:  ret

    IL_005e:  ldc.i4.1
    IL_005f:  ret
  } // end of method SkipOnCoreClrDiscoverer::RuntimeConfigurationApplies

  .method private hidebysig static bool  StressModeApplies(valuetype Xunit.RuntimeTestModes stressMode) cil managed
  {
    // Code size       267 (0x10b)
    .maxstack  2
    IL_0000:  ldarg.0
    IL_0001:  box        Xunit.RuntimeTestModes
    IL_0006:  ldc.i4.1
    IL_0007:  box        Xunit.RuntimeTestModes
    IL_000c:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_0011:  brfalse.s  IL_0022

    IL_0013:  ldsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isStressTest
    IL_0018:  callvirt   instance !0 class [mscorlib]System.Lazy`1<bool>::get_Value()
    IL_001d:  brfalse    IL_0109

    IL_0022:  ldarg.0
    IL_0023:  box        Xunit.RuntimeTestModes
    IL_0028:  ldc.i4.s   64
    IL_002a:  box        Xunit.RuntimeTestModes
    IL_002f:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_0034:  brfalse.s  IL_0045

    IL_0036:  ldsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isGCStress3
    IL_003b:  callvirt   instance !0 class [mscorlib]System.Lazy`1<bool>::get_Value()
    IL_0040:  brtrue     IL_0109

    IL_0045:  ldarg.0
    IL_0046:  box        Xunit.RuntimeTestModes
    IL_004b:  ldc.i4     0x80
    IL_0050:  box        Xunit.RuntimeTestModes
    IL_0055:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_005a:  brfalse.s  IL_006b

    IL_005c:  ldsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isGCStressC
    IL_0061:  callvirt   instance !0 class [mscorlib]System.Lazy`1<bool>::get_Value()
    IL_0066:  brtrue     IL_0109

    IL_006b:  ldarg.0
    IL_006c:  box        Xunit.RuntimeTestModes
    IL_0071:  ldc.i4.s   32
    IL_0073:  box        Xunit.RuntimeTestModes
    IL_0078:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_007d:  brfalse.s  IL_008b

    IL_007f:  ldsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isZapDisable
    IL_0084:  callvirt   instance !0 class [mscorlib]System.Lazy`1<bool>::get_Value()
    IL_0089:  brtrue.s   IL_0109

    IL_008b:  ldarg.0
    IL_008c:  box        Xunit.RuntimeTestModes
    IL_0091:  ldc.i4.s   16
    IL_0093:  box        Xunit.RuntimeTestModes
    IL_0098:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_009d:  brfalse.s  IL_00ab

    IL_009f:  ldsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isTailCallStress
    IL_00a4:  callvirt   instance !0 class [mscorlib]System.Lazy`1<bool>::get_Value()
    IL_00a9:  brtrue.s   IL_0109

    IL_00ab:  ldarg.0
    IL_00ac:  box        Xunit.RuntimeTestModes
    IL_00b1:  ldc.i4.4
    IL_00b2:  box        Xunit.RuntimeTestModes
    IL_00b7:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_00bc:  brfalse.s  IL_00ca

    IL_00be:  ldsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isJitStressRegs
    IL_00c3:  callvirt   instance !0 class [mscorlib]System.Lazy`1<bool>::get_Value()
    IL_00c8:  brtrue.s   IL_0109

    IL_00ca:  ldarg.0
    IL_00cb:  box        Xunit.RuntimeTestModes
    IL_00d0:  ldc.i4.2
    IL_00d1:  box        Xunit.RuntimeTestModes
    IL_00d6:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_00db:  brfalse.s  IL_00e9

    IL_00dd:  ldsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isJitStress
    IL_00e2:  callvirt   instance !0 class [mscorlib]System.Lazy`1<bool>::get_Value()
    IL_00e7:  brtrue.s   IL_0109

    IL_00e9:  ldarg.0
    IL_00ea:  box        Xunit.RuntimeTestModes
    IL_00ef:  ldc.i4.8
    IL_00f0:  box        Xunit.RuntimeTestModes
    IL_00f5:  call       instance bool [mscorlib]System.Enum::HasFlag(class [mscorlib]System.Enum)
    IL_00fa:  brfalse.s  IL_0107

    IL_00fc:  ldsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isJitMinOpts
    IL_0101:  callvirt   instance !0 class [mscorlib]System.Lazy`1<bool>::get_Value()
    IL_0106:  ret

    IL_0107:  ldc.i4.0
    IL_0108:  ret

    IL_0109:  ldc.i4.1
    IL_010a:  ret
  } // end of method SkipOnCoreClrDiscoverer::StressModeApplies

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method SkipOnCoreClrDiscoverer::.ctor

  .method private hidebysig specialname rtspecialname static 
          void  .cctor() cil managed
  {
    // Code size       287 (0x11f)
    .maxstack  2
    IL_0000:  ldsfld     class Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c' Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<>9'
    IL_0005:  ldftn      instance bool Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<.cctor>b__15_0'()
    IL_000b:  newobj     instance void class [mscorlib]System.Func`1<bool>::.ctor(object,
                                                                                  native int)
    IL_0010:  newobj     instance void class [mscorlib]System.Lazy`1<bool>::.ctor(class [mscorlib]System.Func`1<!0>)
    IL_0015:  stsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isJitStress
    IL_001a:  ldsfld     class Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c' Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<>9'
    IL_001f:  ldftn      instance bool Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<.cctor>b__15_1'()
    IL_0025:  newobj     instance void class [mscorlib]System.Func`1<bool>::.ctor(object,
                                                                                  native int)
    IL_002a:  newobj     instance void class [mscorlib]System.Lazy`1<bool>::.ctor(class [mscorlib]System.Func`1<!0>)
    IL_002f:  stsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isJitStressRegs
    IL_0034:  ldsfld     class Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c' Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<>9'
    IL_0039:  ldftn      instance bool Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<.cctor>b__15_2'()
    IL_003f:  newobj     instance void class [mscorlib]System.Func`1<bool>::.ctor(object,
                                                                                  native int)
    IL_0044:  newobj     instance void class [mscorlib]System.Lazy`1<bool>::.ctor(class [mscorlib]System.Func`1<!0>)
    IL_0049:  stsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isJitMinOpts
    IL_004e:  ldsfld     class Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c' Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<>9'
    IL_0053:  ldftn      instance bool Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<.cctor>b__15_3'()
    IL_0059:  newobj     instance void class [mscorlib]System.Func`1<bool>::.ctor(object,
                                                                                  native int)
    IL_005e:  newobj     instance void class [mscorlib]System.Lazy`1<bool>::.ctor(class [mscorlib]System.Func`1<!0>)
    IL_0063:  stsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isTailCallStress
    IL_0068:  ldsfld     class Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c' Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<>9'
    IL_006d:  ldftn      instance bool Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<.cctor>b__15_4'()
    IL_0073:  newobj     instance void class [mscorlib]System.Func`1<bool>::.ctor(object,
                                                                                  native int)
    IL_0078:  newobj     instance void class [mscorlib]System.Lazy`1<bool>::.ctor(class [mscorlib]System.Func`1<!0>)
    IL_007d:  stsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isZapDisable
    IL_0082:  ldsfld     class Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c' Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<>9'
    IL_0087:  ldftn      instance bool Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<.cctor>b__15_5'()
    IL_008d:  newobj     instance void class [mscorlib]System.Func`1<bool>::.ctor(object,
                                                                                  native int)
    IL_0092:  newobj     instance void class [mscorlib]System.Lazy`1<bool>::.ctor(class [mscorlib]System.Func`1<!0>)
    IL_0097:  stsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isGCStress3
    IL_009c:  ldsfld     class Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c' Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<>9'
    IL_00a1:  ldftn      instance bool Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<.cctor>b__15_6'()
    IL_00a7:  newobj     instance void class [mscorlib]System.Func`1<bool>::.ctor(object,
                                                                                  native int)
    IL_00ac:  newobj     instance void class [mscorlib]System.Lazy`1<bool>::.ctor(class [mscorlib]System.Func`1<!0>)
    IL_00b1:  stsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isGCStressC
    IL_00b6:  ldsfld     class Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c' Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<>9'
    IL_00bb:  ldftn      instance bool Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<.cctor>b__15_7'()
    IL_00c1:  newobj     instance void class [mscorlib]System.Func`1<bool>::.ctor(object,
                                                                                  native int)
    IL_00c6:  newobj     instance void class [mscorlib]System.Lazy`1<bool>::.ctor(class [mscorlib]System.Func`1<!0>)
    IL_00cb:  stsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isCheckedRuntime
    IL_00d0:  ldsfld     class Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c' Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<>9'
    IL_00d5:  ldftn      instance bool Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<.cctor>b__15_8'()
    IL_00db:  newobj     instance void class [mscorlib]System.Func`1<bool>::.ctor(object,
                                                                                  native int)
    IL_00e0:  newobj     instance void class [mscorlib]System.Lazy`1<bool>::.ctor(class [mscorlib]System.Func`1<!0>)
    IL_00e5:  stsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isReleaseRuntime
    IL_00ea:  ldsfld     class Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c' Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<>9'
    IL_00ef:  ldftn      instance bool Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<.cctor>b__15_9'()
    IL_00f5:  newobj     instance void class [mscorlib]System.Func`1<bool>::.ctor(object,
                                                                                  native int)
    IL_00fa:  newobj     instance void class [mscorlib]System.Lazy`1<bool>::.ctor(class [mscorlib]System.Func`1<!0>)
    IL_00ff:  stsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isDebugRuntime
    IL_0104:  ldsfld     class Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c' Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<>9'
    IL_0109:  ldftn      instance bool Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer/'<>c'::'<.cctor>b__15_10'()
    IL_010f:  newobj     instance void class [mscorlib]System.Func`1<bool>::.ctor(object,
                                                                                  native int)
    IL_0114:  newobj     instance void class [mscorlib]System.Lazy`1<bool>::.ctor(class [mscorlib]System.Func`1<!0>)
    IL_0119:  stsfld     class [mscorlib]System.Lazy`1<bool> Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer::s_isStressTest
    IL_011e:  ret
  } // end of method SkipOnCoreClrDiscoverer::.cctor

} // end of class Microsoft.DotNet.XUnitExtensions.SkipOnCoreClrDiscoverer

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.SkipOnMonoDiscoverer
       extends [mscorlib]System.Object
       implements [xunit.core]Xunit.Sdk.ITraitDiscoverer
{
  .method public hidebysig newslot virtual final 
          instance class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> 
          GetTraits(class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo traitAttribute) cil managed
  {
    // Code size       81 (0x51)
    .maxstack  5
    .locals init (valuetype Xunit.TestPlatforms V_0,
             valuetype Xunit.TestPlatforms V_1,
             object V_2)
    IL_0000:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::get_IsMonoRuntime()
    IL_0005:  brfalse.s  IL_004b

    IL_0007:  ldc.i4.m1
    IL_0008:  stloc.0
    IL_0009:  ldarg.1
    IL_000a:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerable`1<object> [xunit.abstractions]Xunit.Abstractions.IAttributeInfo::GetConstructorArguments()
    IL_000f:  call       !!0 [System.Core]System.Linq.Enumerable::LastOrDefault<object>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_0014:  stloc.2
    IL_0015:  ldloc.2
    IL_0016:  isinst     Xunit.TestPlatforms
    IL_001b:  brfalse.s  IL_0026

    IL_001d:  ldloc.2
    IL_001e:  unbox.any  Xunit.TestPlatforms
    IL_0023:  stloc.1
    IL_0024:  ldloc.1
    IL_0025:  stloc.0
    IL_0026:  ldloc.0
    IL_0027:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::TestPlatformApplies(valuetype Xunit.TestPlatforms)
    IL_002c:  brfalse.s  IL_004b

    IL_002e:  ldc.i4.1
    IL_002f:  newarr     valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
    IL_0034:  dup
    IL_0035:  ldc.i4.0
    IL_0036:  ldstr      "category"
    IL_003b:  ldstr      "failing"
    IL_0040:  newobj     instance void valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>::.ctor(!0,
                                                                                                                           !1)
    IL_0045:  stelem     valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
    IL_004a:  ret

    IL_004b:  call       !!0[] [mscorlib]System.Array::Empty<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>()
    IL_0050:  ret
  } // end of method SkipOnMonoDiscoverer::GetTraits

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method SkipOnMonoDiscoverer::.ctor

} // end of class Microsoft.DotNet.XUnitExtensions.SkipOnMonoDiscoverer

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.SkipOnPlatformDiscoverer
       extends [mscorlib]System.Object
       implements [xunit.core]Xunit.Sdk.ITraitDiscoverer
{
  .method public hidebysig newslot virtual final 
          instance class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> 
          GetTraits(class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo traitAttribute) cil managed
  {
    // Code size       74 (0x4a)
    .maxstack  5
    .locals init (valuetype Xunit.TestPlatforms V_0,
             valuetype Xunit.TestPlatforms V_1,
             object V_2)
    IL_0000:  ldc.i4.0
    IL_0001:  stloc.0
    IL_0002:  ldarg.1
    IL_0003:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerable`1<object> [xunit.abstractions]Xunit.Abstractions.IAttributeInfo::GetConstructorArguments()
    IL_0008:  call       !!0 [System.Core]System.Linq.Enumerable::FirstOrDefault<object>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_000d:  stloc.2
    IL_000e:  ldloc.2
    IL_000f:  isinst     Xunit.TestPlatforms
    IL_0014:  brfalse.s  IL_001f

    IL_0016:  ldloc.2
    IL_0017:  unbox.any  Xunit.TestPlatforms
    IL_001c:  stloc.1
    IL_001d:  ldloc.1
    IL_001e:  stloc.0
    IL_001f:  ldloc.0
    IL_0020:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::TestPlatformApplies(valuetype Xunit.TestPlatforms)
    IL_0025:  brfalse.s  IL_0044

    IL_0027:  ldc.i4.1
    IL_0028:  newarr     valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
    IL_002d:  dup
    IL_002e:  ldc.i4.0
    IL_002f:  ldstr      "category"
    IL_0034:  ldstr      "failing"
    IL_0039:  newobj     instance void valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>::.ctor(!0,
                                                                                                                           !1)
    IL_003e:  stelem     valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
    IL_0043:  ret

    IL_0044:  call       !!0[] [mscorlib]System.Array::Empty<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>()
    IL_0049:  ret
  } // end of method SkipOnPlatformDiscoverer::GetTraits

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method SkipOnPlatformDiscoverer::.ctor

} // end of class Microsoft.DotNet.XUnitExtensions.SkipOnPlatformDiscoverer

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.SkipOnTargetFrameworkDiscoverer
       extends [mscorlib]System.Object
       implements [xunit.core]Xunit.Sdk.ITraitDiscoverer
{
  .method public hidebysig newslot virtual final 
          instance class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> 
          GetTraits(class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo traitAttribute) cil managed
  {
    // Code size       60 (0x3c)
    .maxstack  5
    .locals init (valuetype Xunit.TargetFrameworkMonikers V_0)
    IL_0000:  ldarg.1
    IL_0001:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerable`1<object> [xunit.abstractions]Xunit.Abstractions.IAttributeInfo::GetConstructorArguments()
    IL_0006:  call       !!0 [System.Core]System.Linq.Enumerable::First<object>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_000b:  unbox.any  Xunit.TargetFrameworkMonikers
    IL_0010:  stloc.0
    IL_0011:  ldloc.0
    IL_0012:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::TestFrameworkApplies(valuetype Xunit.TargetFrameworkMonikers)
    IL_0017:  brtrue.s   IL_001f

    IL_0019:  call       !!0[] [mscorlib]System.Array::Empty<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>()
    IL_001e:  ret

    IL_001f:  ldc.i4.1
    IL_0020:  newarr     valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
    IL_0025:  dup
    IL_0026:  ldc.i4.0
    IL_0027:  ldstr      "category"
    IL_002c:  ldstr      "failing"
    IL_0031:  newobj     instance void valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>::.ctor(!0,
                                                                                                                           !1)
    IL_0036:  stelem     valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
    IL_003b:  ret
  } // end of method SkipOnTargetFrameworkDiscoverer::GetTraits

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method SkipOnTargetFrameworkDiscoverer::.ctor

} // end of class Microsoft.DotNet.XUnitExtensions.SkipOnTargetFrameworkDiscoverer

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer
       extends [mscorlib]System.Object
       implements [xunit.core]Xunit.Sdk.ITraitDiscoverer
{
  .class auto ansi sealed nested private beforefieldinit '<GetTraits>d__0'
         extends [mscorlib]System.Object
         implements class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>,
                    [mscorlib]System.Collections.IEnumerable,
                    class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>,
                    [mscorlib]System.IDisposable,
                    [mscorlib]System.Collections.IEnumerator
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field private int32 '<>1__state'
    .field private valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> '<>2__current'
    .field private int32 '<>l__initialThreadId'
    .field private class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo traitAttribute
    .field public class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo '<>3__traitAttribute'
    .method public hidebysig specialname rtspecialname 
            instance void  .ctor(int32 '<>1__state') cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      // Code size       25 (0x19)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ldarg.0
      IL_0007:  ldarg.1
      IL_0008:  stfld      int32 Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_000d:  ldarg.0
      IL_000e:  call       int32 [mscorlib]System.Environment::get_CurrentManagedThreadId()
      IL_0013:  stfld      int32 Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::'<>l__initialThreadId'
      IL_0018:  ret
    } // end of method '<GetTraits>d__0'::.ctor

    .method private hidebysig newslot virtual final 
            instance void  System.IDisposable.Dispose() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.IDisposable::Dispose
      // Code size       1 (0x1)
      .maxstack  8
      IL_0000:  ret
    } // end of method '<GetTraits>d__0'::System.IDisposable.Dispose

    .method private hidebysig newslot virtual final 
            instance bool  MoveNext() cil managed
    {
      .override [mscorlib]System.Collections.IEnumerator::MoveNext
      // Code size       86 (0x56)
      .maxstack  4
      .locals init (int32 V_0,
               class [mscorlib]System.Collections.Generic.List`1<object> V_1)
      IL_0000:  ldarg.0
      IL_0001:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_0006:  stloc.0
      IL_0007:  ldloc.0
      IL_0008:  brfalse.s  IL_0010

      IL_000a:  ldloc.0
      IL_000b:  ldc.i4.1
      IL_000c:  beq.s      IL_004d

      IL_000e:  ldc.i4.0
      IL_000f:  ret

      IL_0010:  ldarg.0
      IL_0011:  ldc.i4.m1
      IL_0012:  stfld      int32 Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_0017:  ldarg.0
      IL_0018:  ldfld      class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::traitAttribute
      IL_001d:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerable`1<object> [xunit.abstractions]Xunit.Abstractions.IAttributeInfo::GetConstructorArguments()
      IL_0022:  call       class [mscorlib]System.Collections.Generic.List`1<!!0> [System.Core]System.Linq.Enumerable::ToList<object>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
      IL_0027:  stloc.1
      IL_0028:  ldarg.0
      IL_0029:  ldstr      "Category"
      IL_002e:  ldloc.1
      IL_002f:  ldc.i4.0
      IL_0030:  callvirt   instance !0 class [mscorlib]System.Collections.Generic.List`1<object>::get_Item(int32)
      IL_0035:  callvirt   instance string [mscorlib]System.Object::ToString()
      IL_003a:  newobj     instance void valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>::.ctor(!0,
                                                                                                                             !1)
      IL_003f:  stfld      valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::'<>2__current'
      IL_0044:  ldarg.0
      IL_0045:  ldc.i4.1
      IL_0046:  stfld      int32 Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_004b:  ldc.i4.1
      IL_004c:  ret

      IL_004d:  ldarg.0
      IL_004e:  ldc.i4.m1
      IL_004f:  stfld      int32 Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_0054:  ldc.i4.0
      IL_0055:  ret
    } // end of method '<GetTraits>d__0'::MoveNext

    .method private hidebysig newslot specialname virtual final 
            instance valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> 
            'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current'() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override  method instance !0 class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>::get_Current()
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldfld      valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::'<>2__current'
      IL_0006:  ret
    } // end of method '<GetTraits>d__0'::'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current'

    .method private hidebysig newslot virtual final 
            instance void  System.Collections.IEnumerator.Reset() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.Collections.IEnumerator::Reset
      // Code size       6 (0x6)
      .maxstack  8
      IL_0000:  newobj     instance void [mscorlib]System.NotSupportedException::.ctor()
      IL_0005:  throw
    } // end of method '<GetTraits>d__0'::System.Collections.IEnumerator.Reset

    .method private hidebysig newslot specialname virtual final 
            instance object  System.Collections.IEnumerator.get_Current() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.Collections.IEnumerator::get_Current
      // Code size       12 (0xc)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldfld      valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::'<>2__current'
      IL_0006:  box        valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
      IL_000b:  ret
    } // end of method '<GetTraits>d__0'::System.Collections.IEnumerator.get_Current

    .method private hidebysig newslot virtual final 
            instance class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> 
            'System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator'() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override  method instance class [mscorlib]System.Collections.Generic.IEnumerator`1<!0> class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>>::GetEnumerator()
      // Code size       55 (0x37)
      .maxstack  2
      .locals init (class Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0' V_0)
      IL_0000:  ldarg.0
      IL_0001:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_0006:  ldc.i4.s   -2
      IL_0008:  bne.un.s   IL_0022

      IL_000a:  ldarg.0
      IL_000b:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::'<>l__initialThreadId'
      IL_0010:  call       int32 [mscorlib]System.Environment::get_CurrentManagedThreadId()
      IL_0015:  bne.un.s   IL_0022

      IL_0017:  ldarg.0
      IL_0018:  ldc.i4.0
      IL_0019:  stfld      int32 Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::'<>1__state'
      IL_001e:  ldarg.0
      IL_001f:  stloc.0
      IL_0020:  br.s       IL_0029

      IL_0022:  ldc.i4.0
      IL_0023:  newobj     instance void Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::.ctor(int32)
      IL_0028:  stloc.0
      IL_0029:  ldloc.0
      IL_002a:  ldarg.0
      IL_002b:  ldfld      class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::'<>3__traitAttribute'
      IL_0030:  stfld      class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::traitAttribute
      IL_0035:  ldloc.0
      IL_0036:  ret
    } // end of method '<GetTraits>d__0'::'System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator'

    .method private hidebysig newslot virtual final 
            instance class [mscorlib]System.Collections.IEnumerator 
            System.Collections.IEnumerable.GetEnumerator() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.Collections.IEnumerable::GetEnumerator
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::'System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator'()
      IL_0006:  ret
    } // end of method '<GetTraits>d__0'::System.Collections.IEnumerable.GetEnumerator

    .property instance valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>
            'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current'()
    {
      .get instance valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string> Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current'()
    } // end of property '<GetTraits>d__0'::'System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current'
    .property instance object System.Collections.IEnumerator.Current()
    {
      .get instance object Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::System.Collections.IEnumerator.get_Current()
    } // end of property '<GetTraits>d__0'::System.Collections.IEnumerator.Current
  } // end of class '<GetTraits>d__0'

  .method public hidebysig newslot virtual final 
          instance class [mscorlib]System.Collections.Generic.IEnumerable`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string,string>> 
          GetTraits(class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo traitAttribute) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.IteratorStateMachineAttribute::.ctor(class [mscorlib]System.Type) = ( 01 00 47 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..GMicrosoft.Dot
                                                                                                                                          4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                                                                          6F 6E 73 2E 54 65 73 74 43 61 74 65 67 6F 72 79   // ons.TestCategory
                                                                                                                                          44 69 73 63 6F 76 65 72 65 72 2B 3C 47 65 74 54   // Discoverer+<GetT
                                                                                                                                          72 61 69 74 73 3E 64 5F 5F 30 00 00 )             // raits>d__0..
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldc.i4.s   -2
    IL_0002:  newobj     instance void Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::.ctor(int32)
    IL_0007:  dup
    IL_0008:  ldarg.1
    IL_0009:  stfld      class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer/'<GetTraits>d__0'::'<>3__traitAttribute'
    IL_000e:  ret
  } // end of method TestCategoryDiscoverer::GetTraits

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method TestCategoryDiscoverer::.ctor

} // end of class Microsoft.DotNet.XUnitExtensions.TestCategoryDiscoverer

.class public abstract auto ansi sealed beforefieldinit Microsoft.DotNet.XUnitExtensions.TheoryExtensions
       extends [mscorlib]System.Object
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.ExtensionAttribute::.ctor() = ( 01 00 00 00 ) 
  .class auto ansi nested private beforefieldinit TheoryDataAdapter
         extends [xunit.core]Xunit.TheoryData
         implements class [mscorlib]System.Collections.Generic.IEnumerable`1<object[]>,
                    [mscorlib]System.Collections.IEnumerable
  {
    .field private class [mscorlib]System.Collections.Generic.IEnumerable`1<object[]> _data
    .method public hidebysig specialname rtspecialname 
            instance void  .ctor(class [mscorlib]System.Collections.Generic.IEnumerable`1<object[]> data) cil managed
    {
      // Code size       14 (0xe)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [xunit.core]Xunit.TheoryData::.ctor()
      IL_0006:  ldarg.0
      IL_0007:  ldarg.1
      IL_0008:  stfld      class [mscorlib]System.Collections.Generic.IEnumerable`1<object[]> Microsoft.DotNet.XUnitExtensions.TheoryExtensions/TheoryDataAdapter::_data
      IL_000d:  ret
    } // end of method TheoryDataAdapter::.ctor

    .method public hidebysig newslot virtual final 
            instance class [mscorlib]System.Collections.Generic.IEnumerator`1<object[]> 
            GetEnumerator() cil managed
    {
      // Code size       12 (0xc)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldfld      class [mscorlib]System.Collections.Generic.IEnumerable`1<object[]> Microsoft.DotNet.XUnitExtensions.TheoryExtensions/TheoryDataAdapter::_data
      IL_0006:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerator`1<!0> class [mscorlib]System.Collections.Generic.IEnumerable`1<object[]>::GetEnumerator()
      IL_000b:  ret
    } // end of method TheoryDataAdapter::GetEnumerator

    .method private hidebysig newslot virtual final 
            instance class [mscorlib]System.Collections.IEnumerator 
            System.Collections.IEnumerable.GetEnumerator() cil managed
    {
      .override [mscorlib]System.Collections.IEnumerable::GetEnumerator
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance class [mscorlib]System.Collections.Generic.IEnumerator`1<object[]> Microsoft.DotNet.XUnitExtensions.TheoryExtensions/TheoryDataAdapter::GetEnumerator()
      IL_0006:  ret
    } // end of method TheoryDataAdapter::System.Collections.IEnumerable.GetEnumerator

  } // end of class TheoryDataAdapter

  .class auto ansi serializable sealed nested private beforefieldinit '<>c__0`1'<T>
         extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field public static initonly class Microsoft.DotNet.XUnitExtensions.TheoryExtensions/'<>c__0`1'<!T> '<>9'
    .field public static class [mscorlib]System.Func`2<!T,object[]> '<>9__0_0'
    .method private hidebysig specialname rtspecialname static 
            void  .cctor() cil managed
    {
      // Code size       11 (0xb)
      .maxstack  8
      IL_0000:  newobj     instance void class Microsoft.DotNet.XUnitExtensions.TheoryExtensions/'<>c__0`1'<!T>::.ctor()
      IL_0005:  stsfld     class Microsoft.DotNet.XUnitExtensions.TheoryExtensions/'<>c__0`1'<!0> class Microsoft.DotNet.XUnitExtensions.TheoryExtensions/'<>c__0`1'<!T>::'<>9'
      IL_000a:  ret
    } // end of method '<>c__0`1'::.cctor

    .method public hidebysig specialname rtspecialname 
            instance void  .ctor() cil managed
    {
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ret
    } // end of method '<>c__0`1'::.ctor

    .method assembly hidebysig instance object[] 
            '<ToTheoryData>b__0_0'(!T d) cil managed
    {
      // Code size       16 (0x10)
      .maxstack  8
      IL_0000:  ldc.i4.1
      IL_0001:  newarr     [mscorlib]System.Object
      IL_0006:  dup
      IL_0007:  ldc.i4.0
      IL_0008:  ldarg.1
      IL_0009:  box        !T
      IL_000e:  stelem.ref
      IL_000f:  ret
    } // end of method '<>c__0`1'::'<ToTheoryData>b__0_0'

  } // end of class '<>c__0`1'

  .method public hidebysig static class [xunit.core]Xunit.TheoryData 
          ToTheoryData<T>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!T> data) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.ExtensionAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       43 (0x2b)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldsfld     class [mscorlib]System.Func`2<!0,object[]> class Microsoft.DotNet.XUnitExtensions.TheoryExtensions/'<>c__0`1'<!!T>::'<>9__0_0'
    IL_0006:  dup
    IL_0007:  brtrue.s   IL_0020

    IL_0009:  pop
    IL_000a:  ldsfld     class Microsoft.DotNet.XUnitExtensions.TheoryExtensions/'<>c__0`1'<!0> class Microsoft.DotNet.XUnitExtensions.TheoryExtensions/'<>c__0`1'<!!T>::'<>9'
    IL_000f:  ldftn      instance object[] class Microsoft.DotNet.XUnitExtensions.TheoryExtensions/'<>c__0`1'<!!T>::'<ToTheoryData>b__0_0'(!0)
    IL_0015:  newobj     instance void class [mscorlib]System.Func`2<!!T,object[]>::.ctor(object,
                                                                                          native int)
    IL_001a:  dup
    IL_001b:  stsfld     class [mscorlib]System.Func`2<!0,object[]> class Microsoft.DotNet.XUnitExtensions.TheoryExtensions/'<>c__0`1'<!!T>::'<>9__0_0'
    IL_0020:  call       class [mscorlib]System.Collections.Generic.IEnumerable`1<!!1> [System.Core]System.Linq.Enumerable::Select<!!0,object[]>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>,
                                                                                                                                                 class [mscorlib]System.Func`2<!!0,!!1>)
    IL_0025:  newobj     instance void Microsoft.DotNet.XUnitExtensions.TheoryExtensions/TheoryDataAdapter::.ctor(class [mscorlib]System.Collections.Generic.IEnumerable`1<object[]>)
    IL_002a:  ret
  } // end of method TheoryExtensions::ToTheoryData

} // end of class Microsoft.DotNet.XUnitExtensions.TheoryExtensions

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase
       extends [xunit.execution.desktop]Xunit.Sdk.XunitTestCase
{
  .class auto ansi sealed nested private beforefieldinit '<RunAsync>d__2'
         extends [mscorlib]System.ValueType
         implements [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field public int32 '<>1__state'
    .field public valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> '<>t__builder'
    .field public class [xunit.core]Xunit.Sdk.IMessageBus messageBus
    .field public class Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase '<>4__this'
    .field public class [xunit.abstractions]Xunit.Abstractions.IMessageSink diagnosticMessageSink
    .field public object[] constructorArguments
    .field public class [xunit.core]Xunit.Sdk.ExceptionAggregator aggregator
    .field public class [mscorlib]System.Threading.CancellationTokenSource cancellationTokenSource
    .field private class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus '<skipMessageBus>5__2'
    .field private valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary> '<>u__1'
    .method private hidebysig newslot virtual final 
            instance void  MoveNext() cil managed
    {
      .override [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine::MoveNext
      // Code size       289 (0x121)
      .maxstack  6
      .locals init (int32 V_0,
               class Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase V_1,
               class [xunit.core]Xunit.Sdk.RunSummary V_2,
               class [xunit.core]Xunit.Sdk.RunSummary V_3,
               class [xunit.core]Xunit.Sdk.RunSummary V_4,
               valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary> V_5,
               class [mscorlib]System.Exception V_6)
      IL_0000:  ldarg.0
      IL_0001:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>1__state'
      IL_0006:  stloc.0
      IL_0007:  ldarg.0
      IL_0008:  ldfld      class Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>4__this'
      IL_000d:  stloc.1
      .try
      {
        IL_000e:  ldloc.0
        IL_000f:  brfalse.s  IL_007a

        IL_0011:  ldarg.0
        IL_0012:  ldarg.0
        IL_0013:  ldfld      class [xunit.core]Xunit.Sdk.IMessageBus Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::messageBus
        IL_0018:  newobj     instance void Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::.ctor(class [xunit.core]Xunit.Sdk.IMessageBus)
        IL_001d:  stfld      class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<skipMessageBus>5__2'
        IL_0022:  ldloc.1
        IL_0023:  ldarg.0
        IL_0024:  ldfld      class [xunit.abstractions]Xunit.Abstractions.IMessageSink Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::diagnosticMessageSink
        IL_0029:  ldarg.0
        IL_002a:  ldfld      class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<skipMessageBus>5__2'
        IL_002f:  ldarg.0
        IL_0030:  ldfld      object[] Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::constructorArguments
        IL_0035:  ldarg.0
        IL_0036:  ldfld      class [xunit.core]Xunit.Sdk.ExceptionAggregator Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::aggregator
        IL_003b:  ldarg.0
        IL_003c:  ldfld      class [mscorlib]System.Threading.CancellationTokenSource Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::cancellationTokenSource
        IL_0041:  call       instance class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase::'<>n__0'(class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                                                                                                                           class [xunit.core]Xunit.Sdk.IMessageBus,
                                                                                                                                                                                           object[],
                                                                                                                                                                                           class [xunit.core]Xunit.Sdk.ExceptionAggregator,
                                                                                                                                                                                           class [mscorlib]System.Threading.CancellationTokenSource)
        IL_0046:  callvirt   instance valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<!0> class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary>::GetAwaiter()
        IL_004b:  stloc.s    V_5
        IL_004d:  ldloca.s   V_5
        IL_004f:  call       instance bool valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary>::get_IsCompleted()
        IL_0054:  brtrue.s   IL_0097

        IL_0056:  ldarg.0
        IL_0057:  ldc.i4.0
        IL_0058:  dup
        IL_0059:  stloc.0
        IL_005a:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>1__state'
        IL_005f:  ldarg.0
        IL_0060:  ldloc.s    V_5
        IL_0062:  stfld      valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>u__1'
        IL_0067:  ldarg.0
        IL_0068:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>t__builder'
        IL_006d:  ldloca.s   V_5
        IL_006f:  ldarg.0
        IL_0070:  call       instance void valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::AwaitUnsafeOnCompleted<valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary>,valuetype Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'>(!!0&,
                                                                                                                                                                                                                                                                                                                                                                                   !!1&)
        IL_0075:  leave      IL_0120

        IL_007a:  ldarg.0
        IL_007b:  ldfld      valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>u__1'
        IL_0080:  stloc.s    V_5
        IL_0082:  ldarg.0
        IL_0083:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>u__1'
        IL_0088:  initobj    valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary>
        IL_008e:  ldarg.0
        IL_008f:  ldc.i4.m1
        IL_0090:  dup
        IL_0091:  stloc.0
        IL_0092:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>1__state'
        IL_0097:  ldloca.s   V_5
        IL_0099:  call       instance !0 valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary>::GetResult()
        IL_009e:  stloc.s    V_4
        IL_00a0:  ldloc.s    V_4
        IL_00a2:  stloc.3
        IL_00a3:  ldarg.0
        IL_00a4:  ldfld      class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<skipMessageBus>5__2'
        IL_00a9:  callvirt   instance int32 Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::get_SkippedTestCount()
        IL_00ae:  ldc.i4.0
        IL_00af:  ble.s      IL_00e1

        IL_00b1:  ldloc.3
        IL_00b2:  dup
        IL_00b3:  ldfld      int32 [xunit.core]Xunit.Sdk.RunSummary::Failed
        IL_00b8:  ldarg.0
        IL_00b9:  ldfld      class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<skipMessageBus>5__2'
        IL_00be:  callvirt   instance int32 Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::get_SkippedTestCount()
        IL_00c3:  sub
        IL_00c4:  stfld      int32 [xunit.core]Xunit.Sdk.RunSummary::Failed
        IL_00c9:  ldloc.3
        IL_00ca:  dup
        IL_00cb:  ldfld      int32 [xunit.core]Xunit.Sdk.RunSummary::Skipped
        IL_00d0:  ldarg.0
        IL_00d1:  ldfld      class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<skipMessageBus>5__2'
        IL_00d6:  callvirt   instance int32 Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::get_SkippedTestCount()
        IL_00db:  add
        IL_00dc:  stfld      int32 [xunit.core]Xunit.Sdk.RunSummary::Skipped
        IL_00e1:  ldloc.3
        IL_00e2:  stloc.2
        IL_00e3:  leave.s    IL_0105

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_00e5:  stloc.s    V_6
        IL_00e7:  ldarg.0
        IL_00e8:  ldc.i4.s   -2
        IL_00ea:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>1__state'
        IL_00ef:  ldarg.0
        IL_00f0:  ldnull
        IL_00f1:  stfld      class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<skipMessageBus>5__2'
        IL_00f6:  ldarg.0
        IL_00f7:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>t__builder'
        IL_00fc:  ldloc.s    V_6
        IL_00fe:  call       instance void valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::SetException(class [mscorlib]System.Exception)
        IL_0103:  leave.s    IL_0120

      }  // end handler
      IL_0105:  ldarg.0
      IL_0106:  ldc.i4.s   -2
      IL_0108:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>1__state'
      IL_010d:  ldarg.0
      IL_010e:  ldnull
      IL_010f:  stfld      class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<skipMessageBus>5__2'
      IL_0114:  ldarg.0
      IL_0115:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>t__builder'
      IL_011a:  ldloc.2
      IL_011b:  call       instance void valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::SetResult(!0)
      IL_0120:  ret
    } // end of method '<RunAsync>d__2'::MoveNext

    .method private hidebysig newslot virtual final 
            instance void  SetStateMachine(class [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine::SetStateMachine
      // Code size       13 (0xd)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>t__builder'
      IL_0006:  ldarg.1
      IL_0007:  call       instance void valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::SetStateMachine(class [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine)
      IL_000c:  ret
    } // end of method '<RunAsync>d__2'::SetStateMachine

  } // end of class '<RunAsync>d__2'

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    .custom instance void [mscorlib]System.ObsoleteAttribute::.ctor(string,
                                                                    bool) = ( 01 00 64 43 61 6C 6C 65 64 20 62 79 20 74 68 65   // ..dCalled by the
                                                                              20 64 65 2D 73 65 72 69 61 6C 69 7A 65 72 3B 20   //  de-serializer; 
                                                                              73 68 6F 75 6C 64 20 6F 6E 6C 79 20 62 65 20 63   // should only be c
                                                                              61 6C 6C 65 64 20 62 79 20 64 65 72 69 76 69 6E   // alled by derivin
                                                                              67 20 63 6C 61 73 73 65 73 20 66 6F 72 20 64 65   // g classes for de
                                                                              2D 73 65 72 69 61 6C 69 7A 61 74 69 6F 6E 20 70   // -serialization p
                                                                              75 72 70 6F 73 65 73 01 00 00 )                   // urposes...
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.execution.desktop]Xunit.Sdk.XunitTestCase::.ctor()
    IL_0006:  ret
  } // end of method SkippedFactTestCase::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink diagnosticMessageSink,
                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay defaultMethodDisplay,
                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions defaultMethodDisplayOptions,
                               class [xunit.abstractions]Xunit.Abstractions.ITestMethod testMethod,
                               [opt] object[] testMethodArguments) cil managed
  {
    .param [5] = nullref
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  ldarg.s    testMethod
    IL_0006:  ldarg.s    testMethodArguments
    IL_0008:  call       instance void [xunit.execution.desktop]Xunit.Sdk.XunitTestCase::.ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay,
                                                                                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions,
                                                                                               class [xunit.abstractions]Xunit.Abstractions.ITestMethod,
                                                                                               object[])
    IL_000d:  ret
  } // end of method SkippedFactTestCase::.ctor

  .method public hidebysig virtual instance class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary> 
          RunAsync(class [xunit.abstractions]Xunit.Abstractions.IMessageSink diagnosticMessageSink,
                   class [xunit.core]Xunit.Sdk.IMessageBus messageBus,
                   object[] constructorArguments,
                   class [xunit.core]Xunit.Sdk.ExceptionAggregator aggregator,
                   class [mscorlib]System.Threading.CancellationTokenSource cancellationTokenSource) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [mscorlib]System.Type) = ( 01 00 43 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..CMicrosoft.Dot
                                                                                                                                       4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                                                                       6F 6E 73 2E 53 6B 69 70 70 65 64 46 61 63 74 54   // ons.SkippedFactT
                                                                                                                                       65 73 74 43 61 73 65 2B 3C 52 75 6E 41 73 79 6E   // estCase+<RunAsyn
                                                                                                                                       63 3E 64 5F 5F 32 00 00 )                         // c>d__2..
    // Code size       97 (0x61)
    .maxstack  2
    .locals init (valuetype Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2' V_0)
    IL_0000:  ldloca.s   V_0
    IL_0002:  call       valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<!0> valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::Create()
    IL_0007:  stfld      valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>t__builder'
    IL_000c:  ldloca.s   V_0
    IL_000e:  ldarg.0
    IL_000f:  stfld      class Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>4__this'
    IL_0014:  ldloca.s   V_0
    IL_0016:  ldarg.1
    IL_0017:  stfld      class [xunit.abstractions]Xunit.Abstractions.IMessageSink Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::diagnosticMessageSink
    IL_001c:  ldloca.s   V_0
    IL_001e:  ldarg.2
    IL_001f:  stfld      class [xunit.core]Xunit.Sdk.IMessageBus Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::messageBus
    IL_0024:  ldloca.s   V_0
    IL_0026:  ldarg.3
    IL_0027:  stfld      object[] Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::constructorArguments
    IL_002c:  ldloca.s   V_0
    IL_002e:  ldarg.s    aggregator
    IL_0030:  stfld      class [xunit.core]Xunit.Sdk.ExceptionAggregator Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::aggregator
    IL_0035:  ldloca.s   V_0
    IL_0037:  ldarg.s    cancellationTokenSource
    IL_0039:  stfld      class [mscorlib]System.Threading.CancellationTokenSource Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::cancellationTokenSource
    IL_003e:  ldloca.s   V_0
    IL_0040:  ldc.i4.m1
    IL_0041:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>1__state'
    IL_0046:  ldloca.s   V_0
    IL_0048:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>t__builder'
    IL_004d:  ldloca.s   V_0
    IL_004f:  call       instance void valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::Start<valuetype Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'>(!!0&)
    IL_0054:  ldloca.s   V_0
    IL_0056:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase/'<RunAsync>d__2'::'<>t__builder'
    IL_005b:  call       instance class [mscorlib]System.Threading.Tasks.Task`1<!0> valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::get_Task()
    IL_0060:  ret
  } // end of method SkippedFactTestCase::RunAsync

  .method private hidebysig instance class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary> 
          '<>n__0'(class [xunit.abstractions]Xunit.Abstractions.IMessageSink diagnosticMessageSink,
                   class [xunit.core]Xunit.Sdk.IMessageBus messageBus,
                   object[] constructorArguments,
                   class [xunit.core]Xunit.Sdk.ExceptionAggregator aggregator,
                   class [mscorlib]System.Threading.CancellationTokenSource cancellationTokenSource) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  ldarg.s    aggregator
    IL_0006:  ldarg.s    cancellationTokenSource
    IL_0008:  call       instance class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary> [xunit.execution.desktop]Xunit.Sdk.XunitTestCase::RunAsync(class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                                                                                                                   class [xunit.core]Xunit.Sdk.IMessageBus,
                                                                                                                                                                                   object[],
                                                                                                                                                                                   class [xunit.core]Xunit.Sdk.ExceptionAggregator,
                                                                                                                                                                                   class [mscorlib]System.Threading.CancellationTokenSource)
    IL_000d:  ret
  } // end of method SkippedFactTestCase::'<>n__0'

} // end of class Microsoft.DotNet.XUnitExtensions.SkippedFactTestCase

.class private auto ansi sealed beforefieldinit Microsoft.DotNet.XUnitExtensions.SkippedTestCase
       extends [xunit.execution.desktop]Xunit.Sdk.XunitTestCase
{
  .field private string _skipReason
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    .custom instance void [mscorlib]System.ObsoleteAttribute::.ctor(string) = ( 01 00 64 43 61 6C 6C 65 64 20 62 79 20 74 68 65   // ..dCalled by the
                                                                                20 64 65 2D 73 65 72 69 61 6C 69 7A 65 72 3B 20   //  de-serializer; 
                                                                                73 68 6F 75 6C 64 20 6F 6E 6C 79 20 62 65 20 63   // should only be c
                                                                                61 6C 6C 65 64 20 62 79 20 64 65 72 69 76 69 6E   // alled by derivin
                                                                                67 20 63 6C 61 73 73 65 73 20 66 6F 72 20 64 65   // g classes for de
                                                                                2D 73 65 72 69 61 6C 69 7A 61 74 69 6F 6E 20 70   // -serialization p
                                                                                75 72 70 6F 73 65 73 00 00 )                      // urposes..
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.execution.desktop]Xunit.Sdk.XunitTestCase::.ctor()
    IL_0006:  ret
  } // end of method SkippedTestCase::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string skipReason,
                               class [xunit.abstractions]Xunit.Abstractions.IMessageSink diagnosticMessageSink,
                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay defaultMethodDisplay,
                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions defaultMethodDisplayOptions,
                               class [xunit.abstractions]Xunit.Abstractions.ITestMethod testMethod,
                               [opt] object[] testMethodArguments) cil managed
  {
    .param [6] = nullref
    // Code size       22 (0x16)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.2
    IL_0002:  ldarg.3
    IL_0003:  ldarg.s    defaultMethodDisplayOptions
    IL_0005:  ldarg.s    testMethod
    IL_0007:  ldarg.s    testMethodArguments
    IL_0009:  call       instance void [xunit.execution.desktop]Xunit.Sdk.XunitTestCase::.ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay,
                                                                                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions,
                                                                                               class [xunit.abstractions]Xunit.Abstractions.ITestMethod,
                                                                                               object[])
    IL_000e:  ldarg.0
    IL_000f:  ldarg.1
    IL_0010:  stfld      string Microsoft.DotNet.XUnitExtensions.SkippedTestCase::_skipReason
    IL_0015:  ret
  } // end of method SkippedTestCase::.ctor

  .method family hidebysig virtual instance string 
          GetSkipReason(class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo factAttribute) cil managed
  {
    // Code size       18 (0x12)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      string Microsoft.DotNet.XUnitExtensions.SkippedTestCase::_skipReason
    IL_0006:  dup
    IL_0007:  brtrue.s   IL_0011

    IL_0009:  pop
    IL_000a:  ldarg.0
    IL_000b:  ldarg.1
    IL_000c:  call       instance string [xunit.execution.desktop]Xunit.Sdk.XunitTestCase::GetSkipReason(class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo)
    IL_0011:  ret
  } // end of method SkippedTestCase::GetSkipReason

  .method public hidebysig virtual instance void 
          Deserialize(class [xunit.abstractions]Xunit.Abstractions.IXunitSerializationInfo data) cil managed
  {
    // Code size       25 (0x19)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       instance void [xunit.execution.desktop]Xunit.Sdk.XunitTestCase::Deserialize(class [xunit.abstractions]Xunit.Abstractions.IXunitSerializationInfo)
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  ldstr      "_skipReason"
    IL_000e:  callvirt   instance !!0 [xunit.abstractions]Xunit.Abstractions.IXunitSerializationInfo::GetValue<string>(string)
    IL_0013:  stfld      string Microsoft.DotNet.XUnitExtensions.SkippedTestCase::_skipReason
    IL_0018:  ret
  } // end of method SkippedTestCase::Deserialize

  .method public hidebysig virtual instance void 
          Serialize(class [xunit.abstractions]Xunit.Abstractions.IXunitSerializationInfo data) cil managed
  {
    // Code size       26 (0x1a)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       instance void [xunit.execution.desktop]Xunit.Sdk.XunitTestCase::Serialize(class [xunit.abstractions]Xunit.Abstractions.IXunitSerializationInfo)
    IL_0007:  ldarg.1
    IL_0008:  ldstr      "_skipReason"
    IL_000d:  ldarg.0
    IL_000e:  ldfld      string Microsoft.DotNet.XUnitExtensions.SkippedTestCase::_skipReason
    IL_0013:  ldnull
    IL_0014:  callvirt   instance void [xunit.abstractions]Xunit.Abstractions.IXunitSerializationInfo::AddValue(string,
                                                                                                                object,
                                                                                                                class [mscorlib]System.Type)
    IL_0019:  ret
  } // end of method SkippedTestCase::Serialize

} // end of class Microsoft.DotNet.XUnitExtensions.SkippedTestCase

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.SkipTestException
       extends [mscorlib]System.Exception
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       instance void [mscorlib]System.Exception::.ctor(string)
    IL_0007:  ret
  } // end of method SkipTestException::.ctor

} // end of class Microsoft.DotNet.XUnitExtensions.SkipTestException

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus
       extends [mscorlib]System.Object
       implements [xunit.core]Xunit.Sdk.IMessageBus,
                  [mscorlib]System.IDisposable
{
  .field private initonly class [xunit.core]Xunit.Sdk.IMessageBus innerBus
  .field private int32 '<SkippedTestCount>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(class [xunit.core]Xunit.Sdk.IMessageBus innerBus) cil managed
  {
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldarg.1
    IL_0008:  stfld      class [xunit.core]Xunit.Sdk.IMessageBus Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::innerBus
    IL_000d:  ret
  } // end of method SkippedTestMessageBus::.ctor

  .method public hidebysig specialname instance int32 
          get_SkippedTestCount() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::'<SkippedTestCount>k__BackingField'
    IL_0006:  ret
  } // end of method SkippedTestMessageBus::get_SkippedTestCount

  .method private hidebysig specialname instance void 
          set_SkippedTestCount(int32 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::'<SkippedTestCount>k__BackingField'
    IL_0007:  ret
  } // end of method SkippedTestMessageBus::set_SkippedTestCount

  .method public hidebysig newslot virtual final 
          instance void  Dispose() cil managed
  {
    // Code size       1 (0x1)
    .maxstack  8
    IL_0000:  ret
  } // end of method SkippedTestMessageBus::Dispose

  .method public hidebysig newslot virtual final 
          instance bool  QueueMessage(class [xunit.abstractions]Xunit.Abstractions.IMessageSinkMessage message) cil managed
  {
    // Code size       108 (0x6c)
    .maxstack  3
    .locals init (class [xunit.abstractions]Xunit.Abstractions.ITestFailed V_0,
             string V_1,
             int32 V_2)
    IL_0000:  ldarg.1
    IL_0001:  isinst     [xunit.abstractions]Xunit.Abstractions.ITestFailed
    IL_0006:  stloc.0
    IL_0007:  ldloc.0
    IL_0008:  brfalse.s  IL_005f

    IL_000a:  ldloc.0
    IL_000b:  callvirt   instance string[] [xunit.abstractions]Xunit.Abstractions.IFailureInformation::get_ExceptionTypes()
    IL_0010:  call       !!0 [System.Core]System.Linq.Enumerable::FirstOrDefault<string>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_0015:  stloc.1
    IL_0016:  ldloc.1
    IL_0017:  ldtoken    Microsoft.DotNet.XUnitExtensions.SkipTestException
    IL_001c:  call       class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)
    IL_0021:  callvirt   instance string [mscorlib]System.Type::get_FullName()
    IL_0026:  call       bool [mscorlib]System.String::op_Equality(string,
                                                                   string)
    IL_002b:  brfalse.s  IL_005f

    IL_002d:  ldarg.0
    IL_002e:  call       instance int32 Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::get_SkippedTestCount()
    IL_0033:  stloc.2
    IL_0034:  ldarg.0
    IL_0035:  ldloc.2
    IL_0036:  ldc.i4.1
    IL_0037:  add
    IL_0038:  call       instance void Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::set_SkippedTestCount(int32)
    IL_003d:  ldarg.0
    IL_003e:  ldfld      class [xunit.core]Xunit.Sdk.IMessageBus Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::innerBus
    IL_0043:  ldloc.0
    IL_0044:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITest [xunit.abstractions]Xunit.Abstractions.ITestMessage::get_Test()
    IL_0049:  ldloc.0
    IL_004a:  callvirt   instance string[] [xunit.abstractions]Xunit.Abstractions.IFailureInformation::get_Messages()
    IL_004f:  call       !!0 [System.Core]System.Linq.Enumerable::FirstOrDefault<string>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_0054:  newobj     instance void [xunit.execution.desktop]Xunit.Sdk.TestSkipped::.ctor(class [xunit.abstractions]Xunit.Abstractions.ITest,
                                                                                             string)
    IL_0059:  callvirt   instance bool [xunit.core]Xunit.Sdk.IMessageBus::QueueMessage(class [xunit.abstractions]Xunit.Abstractions.IMessageSinkMessage)
    IL_005e:  ret

    IL_005f:  ldarg.0
    IL_0060:  ldfld      class [xunit.core]Xunit.Sdk.IMessageBus Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::innerBus
    IL_0065:  ldarg.1
    IL_0066:  callvirt   instance bool [xunit.core]Xunit.Sdk.IMessageBus::QueueMessage(class [xunit.abstractions]Xunit.Abstractions.IMessageSinkMessage)
    IL_006b:  ret
  } // end of method SkippedTestMessageBus::QueueMessage

  .property instance int32 SkippedTestCount()
  {
    .get instance int32 Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::get_SkippedTestCount()
    .set instance void Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::set_SkippedTestCount(int32)
  } // end of property SkippedTestMessageBus::SkippedTestCount
} // end of class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus

.class public auto ansi beforefieldinit Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase
       extends [xunit.execution.desktop]Xunit.Sdk.XunitTheoryTestCase
{
  .class auto ansi sealed nested private beforefieldinit '<RunAsync>d__2'
         extends [mscorlib]System.ValueType
         implements [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field public int32 '<>1__state'
    .field public valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> '<>t__builder'
    .field public class [xunit.core]Xunit.Sdk.IMessageBus messageBus
    .field public class Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase '<>4__this'
    .field public class [xunit.abstractions]Xunit.Abstractions.IMessageSink diagnosticMessageSink
    .field public object[] constructorArguments
    .field public class [xunit.core]Xunit.Sdk.ExceptionAggregator aggregator
    .field public class [mscorlib]System.Threading.CancellationTokenSource cancellationTokenSource
    .field private class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus '<skipMessageBus>5__2'
    .field private valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary> '<>u__1'
    .method private hidebysig newslot virtual final 
            instance void  MoveNext() cil managed
    {
      .override [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine::MoveNext
      // Code size       289 (0x121)
      .maxstack  6
      .locals init (int32 V_0,
               class Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase V_1,
               class [xunit.core]Xunit.Sdk.RunSummary V_2,
               class [xunit.core]Xunit.Sdk.RunSummary V_3,
               class [xunit.core]Xunit.Sdk.RunSummary V_4,
               valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary> V_5,
               class [mscorlib]System.Exception V_6)
      IL_0000:  ldarg.0
      IL_0001:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>1__state'
      IL_0006:  stloc.0
      IL_0007:  ldarg.0
      IL_0008:  ldfld      class Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>4__this'
      IL_000d:  stloc.1
      .try
      {
        IL_000e:  ldloc.0
        IL_000f:  brfalse.s  IL_007a

        IL_0011:  ldarg.0
        IL_0012:  ldarg.0
        IL_0013:  ldfld      class [xunit.core]Xunit.Sdk.IMessageBus Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::messageBus
        IL_0018:  newobj     instance void Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::.ctor(class [xunit.core]Xunit.Sdk.IMessageBus)
        IL_001d:  stfld      class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<skipMessageBus>5__2'
        IL_0022:  ldloc.1
        IL_0023:  ldarg.0
        IL_0024:  ldfld      class [xunit.abstractions]Xunit.Abstractions.IMessageSink Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::diagnosticMessageSink
        IL_0029:  ldarg.0
        IL_002a:  ldfld      class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<skipMessageBus>5__2'
        IL_002f:  ldarg.0
        IL_0030:  ldfld      object[] Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::constructorArguments
        IL_0035:  ldarg.0
        IL_0036:  ldfld      class [xunit.core]Xunit.Sdk.ExceptionAggregator Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::aggregator
        IL_003b:  ldarg.0
        IL_003c:  ldfld      class [mscorlib]System.Threading.CancellationTokenSource Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::cancellationTokenSource
        IL_0041:  call       instance class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase::'<>n__0'(class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                                                                                                                             class [xunit.core]Xunit.Sdk.IMessageBus,
                                                                                                                                                                                             object[],
                                                                                                                                                                                             class [xunit.core]Xunit.Sdk.ExceptionAggregator,
                                                                                                                                                                                             class [mscorlib]System.Threading.CancellationTokenSource)
        IL_0046:  callvirt   instance valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<!0> class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary>::GetAwaiter()
        IL_004b:  stloc.s    V_5
        IL_004d:  ldloca.s   V_5
        IL_004f:  call       instance bool valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary>::get_IsCompleted()
        IL_0054:  brtrue.s   IL_0097

        IL_0056:  ldarg.0
        IL_0057:  ldc.i4.0
        IL_0058:  dup
        IL_0059:  stloc.0
        IL_005a:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>1__state'
        IL_005f:  ldarg.0
        IL_0060:  ldloc.s    V_5
        IL_0062:  stfld      valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>u__1'
        IL_0067:  ldarg.0
        IL_0068:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>t__builder'
        IL_006d:  ldloca.s   V_5
        IL_006f:  ldarg.0
        IL_0070:  call       instance void valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::AwaitUnsafeOnCompleted<valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary>,valuetype Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'>(!!0&,
                                                                                                                                                                                                                                                                                                                                                                                     !!1&)
        IL_0075:  leave      IL_0120

        IL_007a:  ldarg.0
        IL_007b:  ldfld      valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>u__1'
        IL_0080:  stloc.s    V_5
        IL_0082:  ldarg.0
        IL_0083:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>u__1'
        IL_0088:  initobj    valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary>
        IL_008e:  ldarg.0
        IL_008f:  ldc.i4.m1
        IL_0090:  dup
        IL_0091:  stloc.0
        IL_0092:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>1__state'
        IL_0097:  ldloca.s   V_5
        IL_0099:  call       instance !0 valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary>::GetResult()
        IL_009e:  stloc.s    V_4
        IL_00a0:  ldloc.s    V_4
        IL_00a2:  stloc.3
        IL_00a3:  ldarg.0
        IL_00a4:  ldfld      class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<skipMessageBus>5__2'
        IL_00a9:  callvirt   instance int32 Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::get_SkippedTestCount()
        IL_00ae:  ldc.i4.0
        IL_00af:  ble.s      IL_00e1

        IL_00b1:  ldloc.3
        IL_00b2:  dup
        IL_00b3:  ldfld      int32 [xunit.core]Xunit.Sdk.RunSummary::Failed
        IL_00b8:  ldarg.0
        IL_00b9:  ldfld      class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<skipMessageBus>5__2'
        IL_00be:  callvirt   instance int32 Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::get_SkippedTestCount()
        IL_00c3:  sub
        IL_00c4:  stfld      int32 [xunit.core]Xunit.Sdk.RunSummary::Failed
        IL_00c9:  ldloc.3
        IL_00ca:  dup
        IL_00cb:  ldfld      int32 [xunit.core]Xunit.Sdk.RunSummary::Skipped
        IL_00d0:  ldarg.0
        IL_00d1:  ldfld      class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<skipMessageBus>5__2'
        IL_00d6:  callvirt   instance int32 Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus::get_SkippedTestCount()
        IL_00db:  add
        IL_00dc:  stfld      int32 [xunit.core]Xunit.Sdk.RunSummary::Skipped
        IL_00e1:  ldloc.3
        IL_00e2:  stloc.2
        IL_00e3:  leave.s    IL_0105

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_00e5:  stloc.s    V_6
        IL_00e7:  ldarg.0
        IL_00e8:  ldc.i4.s   -2
        IL_00ea:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>1__state'
        IL_00ef:  ldarg.0
        IL_00f0:  ldnull
        IL_00f1:  stfld      class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<skipMessageBus>5__2'
        IL_00f6:  ldarg.0
        IL_00f7:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>t__builder'
        IL_00fc:  ldloc.s    V_6
        IL_00fe:  call       instance void valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::SetException(class [mscorlib]System.Exception)
        IL_0103:  leave.s    IL_0120

      }  // end handler
      IL_0105:  ldarg.0
      IL_0106:  ldc.i4.s   -2
      IL_0108:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>1__state'
      IL_010d:  ldarg.0
      IL_010e:  ldnull
      IL_010f:  stfld      class Microsoft.DotNet.XUnitExtensions.SkippedTestMessageBus Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<skipMessageBus>5__2'
      IL_0114:  ldarg.0
      IL_0115:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>t__builder'
      IL_011a:  ldloc.2
      IL_011b:  call       instance void valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::SetResult(!0)
      IL_0120:  ret
    } // end of method '<RunAsync>d__2'::MoveNext

    .method private hidebysig newslot virtual final 
            instance void  SetStateMachine(class [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine::SetStateMachine
      // Code size       13 (0xd)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>t__builder'
      IL_0006:  ldarg.1
      IL_0007:  call       instance void valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::SetStateMachine(class [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine)
      IL_000c:  ret
    } // end of method '<RunAsync>d__2'::SetStateMachine

  } // end of class '<RunAsync>d__2'

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    .custom instance void [mscorlib]System.ObsoleteAttribute::.ctor(string,
                                                                    bool) = ( 01 00 64 43 61 6C 6C 65 64 20 62 79 20 74 68 65   // ..dCalled by the
                                                                              20 64 65 2D 73 65 72 69 61 6C 69 7A 65 72 3B 20   //  de-serializer; 
                                                                              73 68 6F 75 6C 64 20 6F 6E 6C 79 20 62 65 20 63   // should only be c
                                                                              61 6C 6C 65 64 20 62 79 20 64 65 72 69 76 69 6E   // alled by derivin
                                                                              67 20 63 6C 61 73 73 65 73 20 66 6F 72 20 64 65   // g classes for de
                                                                              2D 73 65 72 69 61 6C 69 7A 61 74 69 6F 6E 20 70   // -serialization p
                                                                              75 72 70 6F 73 65 73 01 00 00 )                   // urposes...
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.execution.desktop]Xunit.Sdk.XunitTheoryTestCase::.ctor()
    IL_0006:  ret
  } // end of method SkippedTheoryTestCase::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink diagnosticMessageSink,
                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay defaultMethodDisplay,
                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions defaultMethodDisplayOptions,
                               class [xunit.abstractions]Xunit.Abstractions.ITestMethod testMethod) cil managed
  {
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  ldarg.s    testMethod
    IL_0006:  call       instance void [xunit.execution.desktop]Xunit.Sdk.XunitTheoryTestCase::.ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                                     valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay,
                                                                                                     valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions,
                                                                                                     class [xunit.abstractions]Xunit.Abstractions.ITestMethod)
    IL_000b:  ret
  } // end of method SkippedTheoryTestCase::.ctor

  .method public hidebysig virtual instance class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary> 
          RunAsync(class [xunit.abstractions]Xunit.Abstractions.IMessageSink diagnosticMessageSink,
                   class [xunit.core]Xunit.Sdk.IMessageBus messageBus,
                   object[] constructorArguments,
                   class [xunit.core]Xunit.Sdk.ExceptionAggregator aggregator,
                   class [mscorlib]System.Threading.CancellationTokenSource cancellationTokenSource) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [mscorlib]System.Type) = ( 01 00 45 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..EMicrosoft.Dot
                                                                                                                                       4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                                                                       6F 6E 73 2E 53 6B 69 70 70 65 64 54 68 65 6F 72   // ons.SkippedTheor
                                                                                                                                       79 54 65 73 74 43 61 73 65 2B 3C 52 75 6E 41 73   // yTestCase+<RunAs
                                                                                                                                       79 6E 63 3E 64 5F 5F 32 00 00 )                   // ync>d__2..
    // Code size       97 (0x61)
    .maxstack  2
    .locals init (valuetype Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2' V_0)
    IL_0000:  ldloca.s   V_0
    IL_0002:  call       valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<!0> valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::Create()
    IL_0007:  stfld      valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>t__builder'
    IL_000c:  ldloca.s   V_0
    IL_000e:  ldarg.0
    IL_000f:  stfld      class Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>4__this'
    IL_0014:  ldloca.s   V_0
    IL_0016:  ldarg.1
    IL_0017:  stfld      class [xunit.abstractions]Xunit.Abstractions.IMessageSink Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::diagnosticMessageSink
    IL_001c:  ldloca.s   V_0
    IL_001e:  ldarg.2
    IL_001f:  stfld      class [xunit.core]Xunit.Sdk.IMessageBus Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::messageBus
    IL_0024:  ldloca.s   V_0
    IL_0026:  ldarg.3
    IL_0027:  stfld      object[] Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::constructorArguments
    IL_002c:  ldloca.s   V_0
    IL_002e:  ldarg.s    aggregator
    IL_0030:  stfld      class [xunit.core]Xunit.Sdk.ExceptionAggregator Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::aggregator
    IL_0035:  ldloca.s   V_0
    IL_0037:  ldarg.s    cancellationTokenSource
    IL_0039:  stfld      class [mscorlib]System.Threading.CancellationTokenSource Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::cancellationTokenSource
    IL_003e:  ldloca.s   V_0
    IL_0040:  ldc.i4.m1
    IL_0041:  stfld      int32 Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>1__state'
    IL_0046:  ldloca.s   V_0
    IL_0048:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>t__builder'
    IL_004d:  ldloca.s   V_0
    IL_004f:  call       instance void valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::Start<valuetype Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'>(!!0&)
    IL_0054:  ldloca.s   V_0
    IL_0056:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase/'<RunAsync>d__2'::'<>t__builder'
    IL_005b:  call       instance class [mscorlib]System.Threading.Tasks.Task`1<!0> valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::get_Task()
    IL_0060:  ret
  } // end of method SkippedTheoryTestCase::RunAsync

  .method private hidebysig instance class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary> 
          '<>n__0'(class [xunit.abstractions]Xunit.Abstractions.IMessageSink diagnosticMessageSink,
                   class [xunit.core]Xunit.Sdk.IMessageBus messageBus,
                   object[] constructorArguments,
                   class [xunit.core]Xunit.Sdk.ExceptionAggregator aggregator,
                   class [mscorlib]System.Threading.CancellationTokenSource cancellationTokenSource) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  ldarg.s    aggregator
    IL_0006:  ldarg.s    cancellationTokenSource
    IL_0008:  call       instance class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary> [xunit.execution.desktop]Xunit.Sdk.XunitTheoryTestCase::RunAsync(class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                                                                                                                         class [xunit.core]Xunit.Sdk.IMessageBus,
                                                                                                                                                                                         object[],
                                                                                                                                                                                         class [xunit.core]Xunit.Sdk.ExceptionAggregator,
                                                                                                                                                                                         class [mscorlib]System.Threading.CancellationTokenSource)
    IL_000d:  ret
  } // end of method SkippedTheoryTestCase::'<>n__0'

} // end of class Microsoft.DotNet.XUnitExtensions.SkippedTheoryTestCase

.class public sequential ansi sealed beforefieldinit Microsoft.DotNet.XUnitExtensions.XunitConstants
       extends [mscorlib]System.ValueType
{
  .pack 0
  .size 1
  .field static assembly literal string Failing = "failing"
  .field static assembly literal string OuterLoop = "outerloop"
  .field public static literal string Category = "category"
  .field public static literal string IgnoreForCI = "ignoreforci"
  .field public static literal string RequiresElevation = "requireselevation"
} // end of class Microsoft.DotNet.XUnitExtensions.XunitConstants

.class private auto ansi sealed beforefieldinit Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCase
       extends [xunit.execution.desktop]Xunit.Sdk.XunitTheoryTestCase
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    .custom instance void [mscorlib]System.ObsoleteAttribute::.ctor(string) = ( 01 00 1C 52 65 71 75 72 69 65 64 20 66 6F 72 20   // ...Requried for 
                                                                                64 65 73 65 72 69 61 6C 69 7A 61 74 69 6F 6E 00   // deserialization.
                                                                                00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.execution.desktop]Xunit.Sdk.XunitTheoryTestCase::.ctor()
    IL_0006:  ret
  } // end of method XunitParallelTheoryTestCase::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink diagnosticMessageSink,
                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay defaultMethodDisplay,
                               valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions defaultMethodDisplayOptions,
                               class [xunit.abstractions]Xunit.Abstractions.ITestMethod testMethod) cil managed
  {
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  ldarg.s    testMethod
    IL_0006:  call       instance void [xunit.execution.desktop]Xunit.Sdk.XunitTheoryTestCase::.ctor(class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                                     valuetype [xunit.core]Xunit.Sdk.TestMethodDisplay,
                                                                                                     valuetype [xunit.core]Xunit.Sdk.TestMethodDisplayOptions,
                                                                                                     class [xunit.abstractions]Xunit.Abstractions.ITestMethod)
    IL_000b:  ret
  } // end of method XunitParallelTheoryTestCase::.ctor

  .method public hidebysig virtual instance class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary> 
          RunAsync(class [xunit.abstractions]Xunit.Abstractions.IMessageSink diagnosticMessageSink,
                   class [xunit.core]Xunit.Sdk.IMessageBus messageBus,
                   object[] constructorArguments,
                   class [xunit.core]Xunit.Sdk.ExceptionAggregator aggregator,
                   class [mscorlib]System.Threading.CancellationTokenSource cancellationTokenSource) cil managed
  {
    // Code size       31 (0x1f)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.0
    IL_0002:  call       instance string [xunit.execution.desktop]Xunit.Sdk.TestMethodTestCase::get_DisplayName()
    IL_0007:  ldarg.0
    IL_0008:  call       instance string [xunit.execution.desktop]Xunit.Sdk.TestMethodTestCase::get_SkipReason()
    IL_000d:  ldarg.3
    IL_000e:  ldarg.1
    IL_000f:  ldarg.2
    IL_0010:  ldarg.s    aggregator
    IL_0012:  ldarg.s    cancellationTokenSource
    IL_0014:  newobj     instance void Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::.ctor(class [xunit.core]Xunit.Sdk.IXunitTestCase,
                                                                                                                 string,
                                                                                                                 string,
                                                                                                                 object[],
                                                                                                                 class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                                                 class [xunit.core]Xunit.Sdk.IMessageBus,
                                                                                                                 class [xunit.core]Xunit.Sdk.ExceptionAggregator,
                                                                                                                 class [mscorlib]System.Threading.CancellationTokenSource)
    IL_0019:  call       instance class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary> class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::RunAsync()
    IL_001e:  ret
  } // end of method XunitParallelTheoryTestCase::RunAsync

} // end of class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCase

.class private auto ansi sealed beforefieldinit Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner
       extends [xunit.execution.desktop]Xunit.Sdk.XunitTestCaseRunner
{
  .class auto ansi serializable sealed nested private beforefieldinit '<>c'
         extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field public static initonly class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c' '<>9'
    .field public static class [mscorlib]System.Func`2<class [xunit.abstractions]Xunit.Abstractions.ITypeInfo,class [mscorlib]System.Type> '<>9__9_0'
    .field public static class [mscorlib]System.Func`2<class [mscorlib]System.Reflection.ParameterInfo,class [mscorlib]System.Type> '<>9__9_1'
    .method private hidebysig specialname rtspecialname static 
            void  .cctor() cil managed
    {
      // Code size       11 (0xb)
      .maxstack  8
      IL_0000:  newobj     instance void Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c'::.ctor()
      IL_0005:  stsfld     class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c' Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c'::'<>9'
      IL_000a:  ret
    } // end of method '<>c'::.cctor

    .method public hidebysig specialname rtspecialname 
            instance void  .ctor() cil managed
    {
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ret
    } // end of method '<>c'::.ctor

    .method assembly hidebysig instance class [mscorlib]System.Type 
            '<AfterTestCaseStartingAsync>b__9_0'(class [xunit.abstractions]Xunit.Abstractions.ITypeInfo t) cil managed
    {
      // Code size       12 (0xc)
      .maxstack  8
      IL_0000:  ldarg.1
      IL_0001:  castclass  [xunit.abstractions]Xunit.Abstractions.IReflectionTypeInfo
      IL_0006:  callvirt   instance class [mscorlib]System.Type [xunit.abstractions]Xunit.Abstractions.IReflectionTypeInfo::get_Type()
      IL_000b:  ret
    } // end of method '<>c'::'<AfterTestCaseStartingAsync>b__9_0'

    .method assembly hidebysig instance class [mscorlib]System.Type 
            '<AfterTestCaseStartingAsync>b__9_1'(class [mscorlib]System.Reflection.ParameterInfo p) cil managed
    {
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.1
      IL_0001:  callvirt   instance class [mscorlib]System.Type [mscorlib]System.Reflection.ParameterInfo::get_ParameterType()
      IL_0006:  ret
    } // end of method '<>c'::'<AfterTestCaseStartingAsync>b__9_1'

  } // end of class '<>c'

  .class auto ansi sealed nested private beforefieldinit '<>c__DisplayClass11_0'
         extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field public class [mscorlib]System.IDisposable disposable
    .field public class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner '<>4__this'
    .method public hidebysig specialname rtspecialname 
            instance void  .ctor() cil managed
    {
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ret
    } // end of method '<>c__DisplayClass11_0'::.ctor

    .method assembly hidebysig instance void 
            '<RunTestAsync>b__0'() cil managed
    {
      // Code size       35 (0x23)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldfld      class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c__DisplayClass11_0'::'<>4__this'
      IL_0006:  ldfld      class [xunit.core]Xunit.Sdk.ExceptionAggregator Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::_cleanupAggregator
      IL_000b:  ldarg.0
      IL_000c:  ldfld      class [mscorlib]System.IDisposable Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c__DisplayClass11_0'::disposable
      IL_0011:  dup
      IL_0012:  ldvirtftn  instance void [mscorlib]System.IDisposable::Dispose()
      IL_0018:  newobj     instance void [mscorlib]System.Action::.ctor(object,
                                                                        native int)
      IL_001d:  callvirt   instance void [xunit.core]Xunit.Sdk.ExceptionAggregator::Run(class [mscorlib]System.Action)
      IL_0022:  ret
    } // end of method '<>c__DisplayClass11_0'::'<RunTestAsync>b__0'

  } // end of class '<>c__DisplayClass11_0'

  .class auto ansi sealed nested private beforefieldinit '<AfterTestCaseStartingAsync>d__9'
         extends [mscorlib]System.ValueType
         implements [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field public int32 '<>1__state'
    .field public valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '<>t__builder'
    .field public class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner '<>4__this'
    .field private valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter '<>u__1'
    .method private hidebysig newslot virtual final 
            instance void  MoveNext() cil managed
    {
      .override [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine::MoveNext
      // Code size       1021 (0x3fd)
      .maxstack  12
      .locals init (int32 V_0,
               class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner V_1,
               valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter V_2,
               class [mscorlib]System.Collections.Generic.IEnumerable`1<class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo> V_3,
               class [mscorlib]System.Collections.Generic.IEnumerator`1<class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo> V_4,
               class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo V_5,
               class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo V_6,
               class [xunit.core]Xunit.Sdk.IDataDiscoverer V_7,
               class [mscorlib]System.Collections.Generic.IEnumerable`1<object[]> V_8,
               class [xunit.abstractions]Xunit.Abstractions.IReflectionAttributeInfo V_9,
               class [mscorlib]System.Collections.Generic.IEnumerator`1<object[]> V_10,
               object[] V_11,
               class [xunit.abstractions]Xunit.Abstractions.ITypeInfo[] V_12,
               class [mscorlib]System.Reflection.MethodInfo V_13,
               object[] V_14,
               class [mscorlib]System.Type[] V_15,
               string V_16,
               class [xunit.abstractions]Xunit.Abstractions.ITest V_17,
               string V_18,
               class [mscorlib]System.Exception V_19,
               class [mscorlib]System.Exception V_20)
      IL_0000:  ldarg.0
      IL_0001:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>1__state'
      IL_0006:  stloc.0
      IL_0007:  ldarg.0
      IL_0008:  ldfld      class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>4__this'
      IL_000d:  stloc.1
      .try
      {
        IL_000e:  ldloc.0
        IL_000f:  brfalse.s  IL_0049

        IL_0011:  ldloc.1
        IL_0012:  call       instance class [mscorlib]System.Threading.Tasks.Task Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::'<>n__0'()
        IL_0017:  callvirt   instance valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter [mscorlib]System.Threading.Tasks.Task::GetAwaiter()
        IL_001c:  stloc.2
        IL_001d:  ldloca.s   V_2
        IL_001f:  call       instance bool [mscorlib]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
        IL_0024:  brtrue.s   IL_0065

        IL_0026:  ldarg.0
        IL_0027:  ldc.i4.0
        IL_0028:  dup
        IL_0029:  stloc.0
        IL_002a:  stfld      int32 Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>1__state'
        IL_002f:  ldarg.0
        IL_0030:  ldloc.2
        IL_0031:  stfld      valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>u__1'
        IL_0036:  ldarg.0
        IL_0037:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>t__builder'
        IL_003c:  ldloca.s   V_2
        IL_003e:  ldarg.0
        IL_003f:  call       instance void [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter,valuetype Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'>(!!0&,
                                                                                                                                                                                                                                                                                                                     !!1&)
        IL_0044:  leave      IL_03fc

        IL_0049:  ldarg.0
        IL_004a:  ldfld      valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>u__1'
        IL_004f:  stloc.2
        IL_0050:  ldarg.0
        IL_0051:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>u__1'
        IL_0056:  initobj    [mscorlib]System.Runtime.CompilerServices.TaskAwaiter
        IL_005c:  ldarg.0
        IL_005d:  ldc.i4.m1
        IL_005e:  dup
        IL_005f:  stloc.0
        IL_0060:  stfld      int32 Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>1__state'
        IL_0065:  ldloca.s   V_2
        IL_0067:  call       instance void [mscorlib]System.Runtime.CompilerServices.TaskAwaiter::GetResult()
        .try
        {
          IL_006c:  ldloc.1
          IL_006d:  call       instance !0 class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_TestCase()
          IL_0072:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITestMethod [xunit.abstractions]Xunit.Abstractions.ITestCase::get_TestMethod()
          IL_0077:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.IMethodInfo [xunit.abstractions]Xunit.Abstractions.ITestMethod::get_Method()
          IL_007c:  ldtoken    [xunit.core]Xunit.Sdk.DataAttribute
          IL_0081:  call       class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)
          IL_0086:  call       class [mscorlib]System.Collections.Generic.IEnumerable`1<class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo> [xunit.execution.desktop]ReflectionAbstractionExtensions::GetCustomAttributes(class [xunit.abstractions]Xunit.Abstractions.IMethodInfo,
                                                                                                                                                                                                                                   class [mscorlib]System.Type)
          IL_008b:  stloc.3
          IL_008c:  ldloc.3
          IL_008d:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerator`1<!0> class [mscorlib]System.Collections.Generic.IEnumerable`1<class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo>::GetEnumerator()
          IL_0092:  stloc.s    V_4
          .try
          {
            IL_0094:  br         IL_03a2

            IL_0099:  ldloc.s    V_4
            IL_009b:  callvirt   instance !0 class [mscorlib]System.Collections.Generic.IEnumerator`1<class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo>::get_Current()
            IL_00a0:  stloc.s    V_5
            IL_00a2:  ldloc.s    V_5
            IL_00a4:  ldtoken    [xunit.core]Xunit.Sdk.DataDiscovererAttribute
            IL_00a9:  call       class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)
            IL_00ae:  call       class [mscorlib]System.Collections.Generic.IEnumerable`1<class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo> [xunit.execution.desktop]ReflectionAbstractionExtensions::GetCustomAttributes(class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo,
                                                                                                                                                                                                                                     class [mscorlib]System.Type)
            IL_00b3:  call       !!0 [System.Core]System.Linq.Enumerable::First<class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
            IL_00b8:  stloc.s    V_6
            .try
            {
              IL_00ba:  ldloc.1
              IL_00bb:  call       instance class [xunit.abstractions]Xunit.Abstractions.IMessageSink Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::get_DiagnosticMessageSink()
              IL_00c0:  ldloc.s    V_6
              IL_00c2:  call       class [xunit.core]Xunit.Sdk.IDataDiscoverer [xunit.execution.desktop]Xunit.Sdk.ExtensibilityPointFactory::GetDataDiscoverer(class [xunit.abstractions]Xunit.Abstractions.IMessageSink,
                                                                                                                                                               class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo)
              IL_00c7:  stloc.s    V_7
              IL_00c9:  leave      IL_01a0

            }  // end .try
            catch [mscorlib]System.InvalidCastException 
            {
              IL_00ce:  pop
              IL_00cf:  ldloc.s    V_5
              IL_00d1:  isinst     [xunit.abstractions]Xunit.Abstractions.IReflectionAttributeInfo
              IL_00d6:  stloc.s    V_9
              IL_00d8:  ldloc.s    V_9
              IL_00da:  brfalse.s  IL_0133

              IL_00dc:  ldloc.1
              IL_00dd:  call       instance class [xunit.core]Xunit.Sdk.ExceptionAggregator class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_Aggregator()
              IL_00e2:  ldstr      "Data discoverer specified for {0} on {1}.{2} does "
              + "not implement IDataDiscoverer."
              IL_00e7:  ldloc.s    V_9
              IL_00e9:  callvirt   instance class [mscorlib]System.Attribute [xunit.abstractions]Xunit.Abstractions.IReflectionAttributeInfo::get_Attribute()
              IL_00ee:  callvirt   instance class [mscorlib]System.Type [mscorlib]System.Object::GetType()
              IL_00f3:  ldloc.1
              IL_00f4:  call       instance !0 class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_TestCase()
              IL_00f9:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITestMethod [xunit.abstractions]Xunit.Abstractions.ITestCase::get_TestMethod()
              IL_00fe:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITestClass [xunit.abstractions]Xunit.Abstractions.ITestMethod::get_TestClass()
              IL_0103:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITypeInfo [xunit.abstractions]Xunit.Abstractions.ITestClass::get_Class()
              IL_0108:  callvirt   instance string [xunit.abstractions]Xunit.Abstractions.ITypeInfo::get_Name()
              IL_010d:  ldloc.1
              IL_010e:  call       instance !0 class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_TestCase()
              IL_0113:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITestMethod [xunit.abstractions]Xunit.Abstractions.ITestCase::get_TestMethod()
              IL_0118:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.IMethodInfo [xunit.abstractions]Xunit.Abstractions.ITestMethod::get_Method()
              IL_011d:  callvirt   instance string [xunit.abstractions]Xunit.Abstractions.IMethodInfo::get_Name()
              IL_0122:  call       string [mscorlib]System.String::Format(string,
                                                                          object,
                                                                          object,
                                                                          object)
              IL_0127:  newobj     instance void [mscorlib]System.InvalidOperationException::.ctor(string)
              IL_012c:  callvirt   instance void [xunit.core]Xunit.Sdk.ExceptionAggregator::Add(class [mscorlib]System.Exception)
              IL_0131:  br.s       IL_019b

              IL_0133:  ldloc.1
              IL_0134:  call       instance class [xunit.core]Xunit.Sdk.ExceptionAggregator class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_Aggregator()
              IL_0139:  ldc.i4.5
              IL_013a:  newarr     [mscorlib]System.String
              IL_013f:  dup
              IL_0140:  ldc.i4.0
              IL_0141:  ldstr      "A data discoverer specified on "
              IL_0146:  stelem.ref
              IL_0147:  dup
              IL_0148:  ldc.i4.1
              IL_0149:  ldloc.1
              IL_014a:  call       instance !0 class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_TestCase()
              IL_014f:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITestMethod [xunit.abstractions]Xunit.Abstractions.ITestCase::get_TestMethod()
              IL_0154:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITestClass [xunit.abstractions]Xunit.Abstractions.ITestMethod::get_TestClass()
              IL_0159:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITypeInfo [xunit.abstractions]Xunit.Abstractions.ITestClass::get_Class()
              IL_015e:  callvirt   instance string [xunit.abstractions]Xunit.Abstractions.ITypeInfo::get_Name()
              IL_0163:  stelem.ref
              IL_0164:  dup
              IL_0165:  ldc.i4.2
              IL_0166:  ldstr      "."
              IL_016b:  stelem.ref
              IL_016c:  dup
              IL_016d:  ldc.i4.3
              IL_016e:  ldloc.1
              IL_016f:  call       instance !0 class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_TestCase()
              IL_0174:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITestMethod [xunit.abstractions]Xunit.Abstractions.ITestCase::get_TestMethod()
              IL_0179:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.IMethodInfo [xunit.abstractions]Xunit.Abstractions.ITestMethod::get_Method()
              IL_017e:  callvirt   instance string [xunit.abstractions]Xunit.Abstractions.IMethodInfo::get_Name()
              IL_0183:  stelem.ref
              IL_0184:  dup
              IL_0185:  ldc.i4.4
              IL_0186:  ldstr      " does not implement IDataDiscoverer."
              IL_018b:  stelem.ref
              IL_018c:  call       string [mscorlib]System.String::Concat(string[])
              IL_0191:  newobj     instance void [mscorlib]System.InvalidOperationException::.ctor(string)
              IL_0196:  callvirt   instance void [xunit.core]Xunit.Sdk.ExceptionAggregator::Add(class [mscorlib]System.Exception)
              IL_019b:  leave      IL_03a2

            }  // end handler
            IL_01a0:  ldloc.s    V_7
            IL_01a2:  ldloc.s    V_5
            IL_01a4:  ldloc.1
            IL_01a5:  call       instance !0 class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_TestCase()
            IL_01aa:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITestMethod [xunit.abstractions]Xunit.Abstractions.ITestCase::get_TestMethod()
            IL_01af:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.IMethodInfo [xunit.abstractions]Xunit.Abstractions.ITestMethod::get_Method()
            IL_01b4:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerable`1<object[]> [xunit.core]Xunit.Sdk.IDataDiscoverer::GetData(class [xunit.abstractions]Xunit.Abstractions.IAttributeInfo,
                                                                                                                                                            class [xunit.abstractions]Xunit.Abstractions.IMethodInfo)
            IL_01b9:  stloc.s    V_8
            IL_01bb:  ldloc.s    V_8
            IL_01bd:  brtrue.s   IL_022c

            IL_01bf:  ldloc.1
            IL_01c0:  call       instance class [xunit.core]Xunit.Sdk.ExceptionAggregator class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_Aggregator()
            IL_01c5:  ldc.i4.5
            IL_01c6:  newarr     [mscorlib]System.String
            IL_01cb:  dup
            IL_01cc:  ldc.i4.0
            IL_01cd:  ldstr      "Test data returned null for "
            IL_01d2:  stelem.ref
            IL_01d3:  dup
            IL_01d4:  ldc.i4.1
            IL_01d5:  ldloc.1
            IL_01d6:  call       instance !0 class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_TestCase()
            IL_01db:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITestMethod [xunit.abstractions]Xunit.Abstractions.ITestCase::get_TestMethod()
            IL_01e0:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITestClass [xunit.abstractions]Xunit.Abstractions.ITestMethod::get_TestClass()
            IL_01e5:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITypeInfo [xunit.abstractions]Xunit.Abstractions.ITestClass::get_Class()
            IL_01ea:  callvirt   instance string [xunit.abstractions]Xunit.Abstractions.ITypeInfo::get_Name()
            IL_01ef:  stelem.ref
            IL_01f0:  dup
            IL_01f1:  ldc.i4.2
            IL_01f2:  ldstr      "."
            IL_01f7:  stelem.ref
            IL_01f8:  dup
            IL_01f9:  ldc.i4.3
            IL_01fa:  ldloc.1
            IL_01fb:  call       instance !0 class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_TestCase()
            IL_0200:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITestMethod [xunit.abstractions]Xunit.Abstractions.ITestCase::get_TestMethod()
            IL_0205:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.IMethodInfo [xunit.abstractions]Xunit.Abstractions.ITestMethod::get_Method()
            IL_020a:  callvirt   instance string [xunit.abstractions]Xunit.Abstractions.IMethodInfo::get_Name()
            IL_020f:  stelem.ref
            IL_0210:  dup
            IL_0211:  ldc.i4.4
            IL_0212:  ldstr      ". Make sure it is statically initialized before th"
            + "is test method is called."
            IL_0217:  stelem.ref
            IL_0218:  call       string [mscorlib]System.String::Concat(string[])
            IL_021d:  newobj     instance void [mscorlib]System.InvalidOperationException::.ctor(string)
            IL_0222:  callvirt   instance void [xunit.core]Xunit.Sdk.ExceptionAggregator::Add(class [mscorlib]System.Exception)
            IL_0227:  br         IL_03a2

            IL_022c:  ldloc.s    V_8
            IL_022e:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerator`1<!0> class [mscorlib]System.Collections.Generic.IEnumerable`1<object[]>::GetEnumerator()
            IL_0233:  stloc.s    V_10
            .try
            {
              IL_0235:  br         IL_0384

              IL_023a:  ldloc.s    V_10
              IL_023c:  callvirt   instance !0 class [mscorlib]System.Collections.Generic.IEnumerator`1<object[]>::get_Current()
              IL_0241:  stloc.s    V_11
              IL_0243:  ldloc.1
              IL_0244:  ldfld      class [mscorlib]System.Collections.Generic.List`1<class [mscorlib]System.IDisposable> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::_toDispose
              IL_0249:  ldloc.s    V_11
              IL_024b:  call       class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0> [System.Core]System.Linq.Enumerable::OfType<class [mscorlib]System.IDisposable>(class [mscorlib]System.Collections.IEnumerable)
              IL_0250:  callvirt   instance void class [mscorlib]System.Collections.Generic.List`1<class [mscorlib]System.IDisposable>::AddRange(class [mscorlib]System.Collections.Generic.IEnumerable`1<!0>)
              IL_0255:  ldnull
              IL_0256:  stloc.s    V_12
              IL_0258:  ldloc.1
              IL_0259:  call       instance class [mscorlib]System.Reflection.MethodInfo [xunit.execution.desktop]Xunit.Sdk.XunitTestCaseRunner::get_TestMethod()
              IL_025e:  stloc.s    V_13
              IL_0260:  ldloc.s    V_13
              IL_0262:  ldloc.s    V_11
              IL_0264:  call       object[] [xunit.execution.desktop]Xunit.Sdk.TypeUtility::ResolveMethodArguments(class [mscorlib]System.Reflection.MethodBase,
                                                                                                                   object[])
              IL_0269:  stloc.s    V_14
              IL_026b:  ldloc.s    V_13
              IL_026d:  callvirt   instance bool [mscorlib]System.Reflection.MethodBase::get_IsGenericMethodDefinition()
              IL_0272:  brfalse.s  IL_02c1

              IL_0274:  ldloc.1
              IL_0275:  call       instance !0 class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_TestCase()
              IL_027a:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITestMethod [xunit.abstractions]Xunit.Abstractions.ITestCase::get_TestMethod()
              IL_027f:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.IMethodInfo [xunit.abstractions]Xunit.Abstractions.ITestMethod::get_Method()
              IL_0284:  ldloc.s    V_14
              IL_0286:  call       class [xunit.abstractions]Xunit.Abstractions.ITypeInfo[] [xunit.execution.desktop]Xunit.Sdk.TypeUtility::ResolveGenericTypes(class [xunit.abstractions]Xunit.Abstractions.IMethodInfo,
                                                                                                                                                                object[])
              IL_028b:  stloc.s    V_12
              IL_028d:  ldloc.s    V_13
              IL_028f:  ldloc.s    V_12
              IL_0291:  ldsfld     class [mscorlib]System.Func`2<class [xunit.abstractions]Xunit.Abstractions.ITypeInfo,class [mscorlib]System.Type> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c'::'<>9__9_0'
              IL_0296:  dup
              IL_0297:  brtrue.s   IL_02b0

              IL_0299:  pop
              IL_029a:  ldsfld     class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c' Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c'::'<>9'
              IL_029f:  ldftn      instance class [mscorlib]System.Type Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c'::'<AfterTestCaseStartingAsync>b__9_0'(class [xunit.abstractions]Xunit.Abstractions.ITypeInfo)
              IL_02a5:  newobj     instance void class [mscorlib]System.Func`2<class [xunit.abstractions]Xunit.Abstractions.ITypeInfo,class [mscorlib]System.Type>::.ctor(object,
                                                                                                                                                                          native int)
              IL_02aa:  dup
              IL_02ab:  stsfld     class [mscorlib]System.Func`2<class [xunit.abstractions]Xunit.Abstractions.ITypeInfo,class [mscorlib]System.Type> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c'::'<>9__9_0'
              IL_02b0:  call       class [mscorlib]System.Collections.Generic.IEnumerable`1<!!1> [System.Core]System.Linq.Enumerable::Select<class [xunit.abstractions]Xunit.Abstractions.ITypeInfo,class [mscorlib]System.Type>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>,
                                                                                                                                                                                                                                 class [mscorlib]System.Func`2<!!0,!!1>)
              IL_02b5:  call       !!0[] [System.Core]System.Linq.Enumerable::ToArray<class [mscorlib]System.Type>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
              IL_02ba:  callvirt   instance class [mscorlib]System.Reflection.MethodInfo [mscorlib]System.Reflection.MethodInfo::MakeGenericMethod(class [mscorlib]System.Type[])
              IL_02bf:  stloc.s    V_13
              IL_02c1:  ldloc.s    V_13
              IL_02c3:  callvirt   instance class [mscorlib]System.Reflection.ParameterInfo[] [mscorlib]System.Reflection.MethodBase::GetParameters()
              IL_02c8:  ldsfld     class [mscorlib]System.Func`2<class [mscorlib]System.Reflection.ParameterInfo,class [mscorlib]System.Type> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c'::'<>9__9_1'
              IL_02cd:  dup
              IL_02ce:  brtrue.s   IL_02e7

              IL_02d0:  pop
              IL_02d1:  ldsfld     class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c' Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c'::'<>9'
              IL_02d6:  ldftn      instance class [mscorlib]System.Type Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c'::'<AfterTestCaseStartingAsync>b__9_1'(class [mscorlib]System.Reflection.ParameterInfo)
              IL_02dc:  newobj     instance void class [mscorlib]System.Func`2<class [mscorlib]System.Reflection.ParameterInfo,class [mscorlib]System.Type>::.ctor(object,
                                                                                                                                                                   native int)
              IL_02e1:  dup
              IL_02e2:  stsfld     class [mscorlib]System.Func`2<class [mscorlib]System.Reflection.ParameterInfo,class [mscorlib]System.Type> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c'::'<>9__9_1'
              IL_02e7:  call       class [mscorlib]System.Collections.Generic.IEnumerable`1<!!1> [System.Core]System.Linq.Enumerable::Select<class [mscorlib]System.Reflection.ParameterInfo,class [mscorlib]System.Type>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>,
                                                                                                                                                                                                                          class [mscorlib]System.Func`2<!!0,!!1>)
              IL_02ec:  call       !!0[] [System.Core]System.Linq.Enumerable::ToArray<class [mscorlib]System.Type>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
              IL_02f1:  stloc.s    V_15
              IL_02f3:  ldloc.s    V_14
              IL_02f5:  ldloc.s    V_15
              IL_02f7:  call       object[] [xunit.execution.desktop]Xunit.Sdk.Reflector::ConvertArguments(object[],
                                                                                                           class [mscorlib]System.Type[])
              IL_02fc:  stloc.s    V_14
              IL_02fe:  ldloc.1
              IL_02ff:  call       instance !0 class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_TestCase()
              IL_0304:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITestMethod [xunit.abstractions]Xunit.Abstractions.ITestCase::get_TestMethod()
              IL_0309:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.IMethodInfo [xunit.abstractions]Xunit.Abstractions.ITestMethod::get_Method()
              IL_030e:  ldloc.1
              IL_030f:  call       instance string [xunit.execution.desktop]Xunit.Sdk.XunitTestCaseRunner::get_DisplayName()
              IL_0314:  ldloc.s    V_14
              IL_0316:  ldloc.s    V_12
              IL_0318:  call       string [xunit.execution.desktop]Xunit.Sdk.TypeUtility::GetDisplayNameWithArguments(class [xunit.abstractions]Xunit.Abstractions.IMethodInfo,
                                                                                                                      string,
                                                                                                                      object[],
                                                                                                                      class [xunit.abstractions]Xunit.Abstractions.ITypeInfo[])
              IL_031d:  stloc.s    V_16
              IL_031f:  ldloc.1
              IL_0320:  ldloc.1
              IL_0321:  call       instance !0 class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_TestCase()
              IL_0326:  ldloc.s    V_16
              IL_0328:  callvirt   instance class [xunit.abstractions]Xunit.Abstractions.ITest [xunit.execution.desktop]Xunit.Sdk.XunitTestCaseRunner::CreateTest(class [xunit.core]Xunit.Sdk.IXunitTestCase,
                                                                                                                                                                  string)
              IL_032d:  stloc.s    V_17
              IL_032f:  ldloc.1
              IL_0330:  call       instance string [xunit.execution.desktop]Xunit.Sdk.XunitTestCaseRunner::get_SkipReason()
              IL_0335:  dup
              IL_0336:  brtrue.s   IL_0345

              IL_0338:  pop
              IL_0339:  ldloc.s    V_5
              IL_033b:  ldstr      "Skip"
              IL_0340:  callvirt   instance !!0 [xunit.abstractions]Xunit.Abstractions.IAttributeInfo::GetNamedArgument<string>(string)
              IL_0345:  stloc.s    V_18
              IL_0347:  ldloc.1
              IL_0348:  ldfld      class [mscorlib]System.Collections.Generic.List`1<class [xunit.execution.desktop]Xunit.Sdk.XunitTestRunner> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::_testRunners
              IL_034d:  ldloc.1
              IL_034e:  ldloc.s    V_17
              IL_0350:  ldloc.1
              IL_0351:  call       instance class [xunit.core]Xunit.Sdk.IMessageBus class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_MessageBus()
              IL_0356:  ldloc.1
              IL_0357:  call       instance class [mscorlib]System.Type [xunit.execution.desktop]Xunit.Sdk.XunitTestCaseRunner::get_TestClass()
              IL_035c:  ldloc.1
              IL_035d:  call       instance object[] [xunit.execution.desktop]Xunit.Sdk.XunitTestCaseRunner::get_ConstructorArguments()
              IL_0362:  ldloc.s    V_13
              IL_0364:  ldloc.s    V_14
              IL_0366:  ldloc.s    V_18
              IL_0368:  ldloc.1
              IL_0369:  call       instance class [mscorlib]System.Collections.Generic.IReadOnlyList`1<class [xunit.core]Xunit.Sdk.BeforeAfterTestAttribute> [xunit.execution.desktop]Xunit.Sdk.XunitTestCaseRunner::get_BeforeAfterAttributes()
              IL_036e:  ldloc.1
              IL_036f:  call       instance class [xunit.core]Xunit.Sdk.ExceptionAggregator class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_Aggregator()
              IL_0374:  ldloc.1
              IL_0375:  call       instance class [mscorlib]System.Threading.CancellationTokenSource class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_CancellationTokenSource()
              IL_037a:  callvirt   instance class [xunit.execution.desktop]Xunit.Sdk.XunitTestRunner [xunit.execution.desktop]Xunit.Sdk.XunitTestCaseRunner::CreateTestRunner(class [xunit.abstractions]Xunit.Abstractions.ITest,
                                                                                                                                                                              class [xunit.core]Xunit.Sdk.IMessageBus,
                                                                                                                                                                              class [mscorlib]System.Type,
                                                                                                                                                                              object[],
                                                                                                                                                                              class [mscorlib]System.Reflection.MethodInfo,
                                                                                                                                                                              object[],
                                                                                                                                                                              string,
                                                                                                                                                                              class [mscorlib]System.Collections.Generic.IReadOnlyList`1<class [xunit.core]Xunit.Sdk.BeforeAfterTestAttribute>,
                                                                                                                                                                              class [xunit.core]Xunit.Sdk.ExceptionAggregator,
                                                                                                                                                                              class [mscorlib]System.Threading.CancellationTokenSource)
              IL_037f:  callvirt   instance void class [mscorlib]System.Collections.Generic.List`1<class [xunit.execution.desktop]Xunit.Sdk.XunitTestRunner>::Add(!0)
              IL_0384:  ldloc.s    V_10
              IL_0386:  callvirt   instance bool [mscorlib]System.Collections.IEnumerator::MoveNext()
              IL_038b:  brtrue     IL_023a

              IL_0390:  leave.s    IL_03a2

            }  // end .try
            finally
            {
              IL_0392:  ldloc.0
              IL_0393:  ldc.i4.0
              IL_0394:  bge.s      IL_03a1

              IL_0396:  ldloc.s    V_10
              IL_0398:  brfalse.s  IL_03a1

              IL_039a:  ldloc.s    V_10
              IL_039c:  callvirt   instance void [mscorlib]System.IDisposable::Dispose()
              IL_03a1:  endfinally
            }  // end handler
            IL_03a2:  ldloc.s    V_4
            IL_03a4:  callvirt   instance bool [mscorlib]System.Collections.IEnumerator::MoveNext()
            IL_03a9:  brtrue     IL_0099

            IL_03ae:  leave.s    IL_03c0

          }  // end .try
          finally
          {
            IL_03b0:  ldloc.0
            IL_03b1:  ldc.i4.0
            IL_03b2:  bge.s      IL_03bf

            IL_03b4:  ldloc.s    V_4
            IL_03b6:  brfalse.s  IL_03bf

            IL_03b8:  ldloc.s    V_4
            IL_03ba:  callvirt   instance void [mscorlib]System.IDisposable::Dispose()
            IL_03bf:  endfinally
          }  // end handler
          IL_03c0:  leave.s    IL_03ce

        }  // end .try
        catch [mscorlib]System.Exception 
        {
          IL_03c2:  stloc.s    V_19
          IL_03c4:  ldloc.1
          IL_03c5:  ldloc.s    V_19
          IL_03c7:  stfld      class [mscorlib]System.Exception Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::_dataDiscoveryException
          IL_03cc:  leave.s    IL_03ce

        }  // end handler
        IL_03ce:  leave.s    IL_03e9

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_03d0:  stloc.s    V_20
        IL_03d2:  ldarg.0
        IL_03d3:  ldc.i4.s   -2
        IL_03d5:  stfld      int32 Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>1__state'
        IL_03da:  ldarg.0
        IL_03db:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>t__builder'
        IL_03e0:  ldloc.s    V_20
        IL_03e2:  call       instance void [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(class [mscorlib]System.Exception)
        IL_03e7:  leave.s    IL_03fc

      }  // end handler
      IL_03e9:  ldarg.0
      IL_03ea:  ldc.i4.s   -2
      IL_03ec:  stfld      int32 Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>1__state'
      IL_03f1:  ldarg.0
      IL_03f2:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>t__builder'
      IL_03f7:  call       instance void [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()
      IL_03fc:  ret
    } // end of method '<AfterTestCaseStartingAsync>d__9'::MoveNext

    .method private hidebysig newslot virtual final 
            instance void  SetStateMachine(class [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine::SetStateMachine
      // Code size       13 (0xd)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>t__builder'
      IL_0006:  ldarg.1
      IL_0007:  call       instance void [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(class [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine)
      IL_000c:  ret
    } // end of method '<AfterTestCaseStartingAsync>d__9'::SetStateMachine

  } // end of class '<AfterTestCaseStartingAsync>d__9'

  .class auto ansi sealed nested private beforefieldinit '<RunTestAsync>d__11'
         extends [mscorlib]System.ValueType
         implements [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field public int32 '<>1__state'
    .field public valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> '<>t__builder'
    .field public class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner '<>4__this'
    .field private valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary[]> '<>u__1'
    .method private hidebysig newslot virtual final 
            instance void  MoveNext() cil managed
    {
      .override [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine::MoveNext
      // Code size       445 (0x1bd)
      .maxstack  3
      .locals init (int32 V_0,
               class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner V_1,
               class [xunit.core]Xunit.Sdk.RunSummary V_2,
               class [mscorlib]System.Collections.Generic.List`1<class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary>> V_3,
               class [xunit.core]Xunit.Sdk.RunSummary[] V_4,
               class [xunit.core]Xunit.Sdk.RunSummary V_5,
               class [xunit.execution.desktop]Xunit.Sdk.ExecutionTimer V_6,
               valuetype [mscorlib]System.Collections.Generic.List`1/Enumerator<class [xunit.execution.desktop]Xunit.Sdk.XunitTestRunner> V_7,
               class [xunit.execution.desktop]Xunit.Sdk.XunitTestRunner V_8,
               class [xunit.core]Xunit.Sdk.RunSummary[] V_9,
               valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary[]> V_10,
               class [xunit.core]Xunit.Sdk.RunSummary[] V_11,
               int32 V_12,
               class [xunit.core]Xunit.Sdk.RunSummary V_13,
               valuetype [mscorlib]System.Collections.Generic.List`1/Enumerator<class [mscorlib]System.IDisposable> V_14,
               class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c__DisplayClass11_0' V_15,
               class [mscorlib]System.Exception V_16)
      IL_0000:  ldarg.0
      IL_0001:  ldfld      int32 Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>1__state'
      IL_0006:  stloc.0
      IL_0007:  ldarg.0
      IL_0008:  ldfld      class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>4__this'
      IL_000d:  stloc.1
      .try
      {
        IL_000e:  ldloc.0
        IL_000f:  brfalse    IL_00b5

        IL_0014:  ldloc.1
        IL_0015:  ldfld      class [mscorlib]System.Exception Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::_dataDiscoveryException
        IL_001a:  brfalse.s  IL_0028

        IL_001c:  ldloc.1
        IL_001d:  call       instance class [xunit.core]Xunit.Sdk.RunSummary Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::RunTest_DataDiscoveryException()
        IL_0022:  stloc.2
        IL_0023:  leave      IL_01a8

        IL_0028:  ldloc.1
        IL_0029:  ldfld      class [mscorlib]System.Collections.Generic.List`1<class [xunit.execution.desktop]Xunit.Sdk.XunitTestRunner> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::_testRunners
        IL_002e:  callvirt   instance int32 class [mscorlib]System.Collections.Generic.List`1<class [xunit.execution.desktop]Xunit.Sdk.XunitTestRunner>::get_Count()
        IL_0033:  newobj     instance void class [mscorlib]System.Collections.Generic.List`1<class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary>>::.ctor(int32)
        IL_0038:  stloc.3
        IL_0039:  ldloc.1
        IL_003a:  ldfld      class [mscorlib]System.Collections.Generic.List`1<class [xunit.execution.desktop]Xunit.Sdk.XunitTestRunner> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::_testRunners
        IL_003f:  callvirt   instance valuetype [mscorlib]System.Collections.Generic.List`1/Enumerator<!0> class [mscorlib]System.Collections.Generic.List`1<class [xunit.execution.desktop]Xunit.Sdk.XunitTestRunner>::GetEnumerator()
        IL_0044:  stloc.s    V_7
        .try
        {
          IL_0046:  br.s       IL_005e

          IL_0048:  ldloca.s   V_7
          IL_004a:  call       instance !0 valuetype [mscorlib]System.Collections.Generic.List`1/Enumerator<class [xunit.execution.desktop]Xunit.Sdk.XunitTestRunner>::get_Current()
          IL_004f:  stloc.s    V_8
          IL_0051:  ldloc.3
          IL_0052:  ldloc.s    V_8
          IL_0054:  callvirt   instance class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary> class [xunit.execution.desktop]Xunit.Sdk.TestRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::RunAsync()
          IL_0059:  callvirt   instance void class [mscorlib]System.Collections.Generic.List`1<class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary>>::Add(!0)
          IL_005e:  ldloca.s   V_7
          IL_0060:  call       instance bool valuetype [mscorlib]System.Collections.Generic.List`1/Enumerator<class [xunit.execution.desktop]Xunit.Sdk.XunitTestRunner>::MoveNext()
          IL_0065:  brtrue.s   IL_0048

          IL_0067:  leave.s    IL_007b

        }  // end .try
        finally
        {
          IL_0069:  ldloc.0
          IL_006a:  ldc.i4.0
          IL_006b:  bge.s      IL_007a

          IL_006d:  ldloca.s   V_7
          IL_006f:  constrained. valuetype [mscorlib]System.Collections.Generic.List`1/Enumerator<class [xunit.execution.desktop]Xunit.Sdk.XunitTestRunner>
          IL_0075:  callvirt   instance void [mscorlib]System.IDisposable::Dispose()
          IL_007a:  endfinally
        }  // end handler
        IL_007b:  ldloc.3
        IL_007c:  call       class [mscorlib]System.Threading.Tasks.Task`1<!!0[]> [mscorlib]System.Threading.Tasks.Task::WhenAll<class [xunit.core]Xunit.Sdk.RunSummary>(class [mscorlib]System.Collections.Generic.IEnumerable`1<class [mscorlib]System.Threading.Tasks.Task`1<!!0>>)
        IL_0081:  callvirt   instance valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<!0> class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary[]>::GetAwaiter()
        IL_0086:  stloc.s    V_10
        IL_0088:  ldloca.s   V_10
        IL_008a:  call       instance bool valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary[]>::get_IsCompleted()
        IL_008f:  brtrue.s   IL_00d2

        IL_0091:  ldarg.0
        IL_0092:  ldc.i4.0
        IL_0093:  dup
        IL_0094:  stloc.0
        IL_0095:  stfld      int32 Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>1__state'
        IL_009a:  ldarg.0
        IL_009b:  ldloc.s    V_10
        IL_009d:  stfld      valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary[]> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>u__1'
        IL_00a2:  ldarg.0
        IL_00a3:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>t__builder'
        IL_00a8:  ldloca.s   V_10
        IL_00aa:  ldarg.0
        IL_00ab:  call       instance void valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::AwaitUnsafeOnCompleted<valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary[]>,valuetype Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'>(!!0&,
                                                                                                                                                                                                                                                                                                                                                                                                        !!1&)
        IL_00b0:  leave      IL_01bc

        IL_00b5:  ldarg.0
        IL_00b6:  ldfld      valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary[]> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>u__1'
        IL_00bb:  stloc.s    V_10
        IL_00bd:  ldarg.0
        IL_00be:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary[]> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>u__1'
        IL_00c3:  initobj    valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary[]>
        IL_00c9:  ldarg.0
        IL_00ca:  ldc.i4.m1
        IL_00cb:  dup
        IL_00cc:  stloc.0
        IL_00cd:  stfld      int32 Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>1__state'
        IL_00d2:  ldloca.s   V_10
        IL_00d4:  call       instance !0 valuetype [mscorlib]System.Runtime.CompilerServices.TaskAwaiter`1<class [xunit.core]Xunit.Sdk.RunSummary[]>::GetResult()
        IL_00d9:  stloc.s    V_9
        IL_00db:  ldloc.s    V_9
        IL_00dd:  stloc.s    V_4
        IL_00df:  newobj     instance void [xunit.core]Xunit.Sdk.RunSummary::.ctor()
        IL_00e4:  stloc.s    V_5
        IL_00e6:  ldloc.s    V_4
        IL_00e8:  stloc.s    V_11
        IL_00ea:  ldc.i4.0
        IL_00eb:  stloc.s    V_12
        IL_00ed:  br.s       IL_0105

        IL_00ef:  ldloc.s    V_11
        IL_00f1:  ldloc.s    V_12
        IL_00f3:  ldelem.ref
        IL_00f4:  stloc.s    V_13
        IL_00f6:  ldloc.s    V_5
        IL_00f8:  ldloc.s    V_13
        IL_00fa:  callvirt   instance void [xunit.core]Xunit.Sdk.RunSummary::Aggregate(class [xunit.core]Xunit.Sdk.RunSummary)
        IL_00ff:  ldloc.s    V_12
        IL_0101:  ldc.i4.1
        IL_0102:  add
        IL_0103:  stloc.s    V_12
        IL_0105:  ldloc.s    V_12
        IL_0107:  ldloc.s    V_11
        IL_0109:  ldlen
        IL_010a:  conv.i4
        IL_010b:  blt.s      IL_00ef

        IL_010d:  newobj     instance void [xunit.execution.desktop]Xunit.Sdk.ExecutionTimer::.ctor()
        IL_0112:  stloc.s    V_6
        IL_0114:  ldloc.1
        IL_0115:  ldfld      class [mscorlib]System.Collections.Generic.List`1<class [mscorlib]System.IDisposable> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::_toDispose
        IL_011a:  callvirt   instance valuetype [mscorlib]System.Collections.Generic.List`1/Enumerator<!0> class [mscorlib]System.Collections.Generic.List`1<class [mscorlib]System.IDisposable>::GetEnumerator()
        IL_011f:  stloc.s    V_14
        .try
        {
          IL_0121:  br.s       IL_0154

          IL_0123:  newobj     instance void Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c__DisplayClass11_0'::.ctor()
          IL_0128:  stloc.s    V_15
          IL_012a:  ldloc.s    V_15
          IL_012c:  ldloc.1
          IL_012d:  stfld      class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c__DisplayClass11_0'::'<>4__this'
          IL_0132:  ldloc.s    V_15
          IL_0134:  ldloca.s   V_14
          IL_0136:  call       instance !0 valuetype [mscorlib]System.Collections.Generic.List`1/Enumerator<class [mscorlib]System.IDisposable>::get_Current()
          IL_013b:  stfld      class [mscorlib]System.IDisposable Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c__DisplayClass11_0'::disposable
          IL_0140:  ldloc.s    V_6
          IL_0142:  ldloc.s    V_15
          IL_0144:  ldftn      instance void Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<>c__DisplayClass11_0'::'<RunTestAsync>b__0'()
          IL_014a:  newobj     instance void [mscorlib]System.Action::.ctor(object,
                                                                            native int)
          IL_014f:  callvirt   instance void [xunit.execution.desktop]Xunit.Sdk.ExecutionTimer::Aggregate(class [mscorlib]System.Action)
          IL_0154:  ldloca.s   V_14
          IL_0156:  call       instance bool valuetype [mscorlib]System.Collections.Generic.List`1/Enumerator<class [mscorlib]System.IDisposable>::MoveNext()
          IL_015b:  brtrue.s   IL_0123

          IL_015d:  leave.s    IL_0171

        }  // end .try
        finally
        {
          IL_015f:  ldloc.0
          IL_0160:  ldc.i4.0
          IL_0161:  bge.s      IL_0170

          IL_0163:  ldloca.s   V_14
          IL_0165:  constrained. valuetype [mscorlib]System.Collections.Generic.List`1/Enumerator<class [mscorlib]System.IDisposable>
          IL_016b:  callvirt   instance void [mscorlib]System.IDisposable::Dispose()
          IL_0170:  endfinally
        }  // end handler
        IL_0171:  ldloc.s    V_5
        IL_0173:  dup
        IL_0174:  ldfld      valuetype [mscorlib]System.Decimal [xunit.core]Xunit.Sdk.RunSummary::Time
        IL_0179:  ldloc.s    V_6
        IL_017b:  callvirt   instance valuetype [mscorlib]System.Decimal [xunit.execution.desktop]Xunit.Sdk.ExecutionTimer::get_Total()
        IL_0180:  call       valuetype [mscorlib]System.Decimal [mscorlib]System.Decimal::op_Addition(valuetype [mscorlib]System.Decimal,
                                                                                                      valuetype [mscorlib]System.Decimal)
        IL_0185:  stfld      valuetype [mscorlib]System.Decimal [xunit.core]Xunit.Sdk.RunSummary::Time
        IL_018a:  ldloc.s    V_5
        IL_018c:  stloc.2
        IL_018d:  leave.s    IL_01a8

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_018f:  stloc.s    V_16
        IL_0191:  ldarg.0
        IL_0192:  ldc.i4.s   -2
        IL_0194:  stfld      int32 Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>1__state'
        IL_0199:  ldarg.0
        IL_019a:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>t__builder'
        IL_019f:  ldloc.s    V_16
        IL_01a1:  call       instance void valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::SetException(class [mscorlib]System.Exception)
        IL_01a6:  leave.s    IL_01bc

      }  // end handler
      IL_01a8:  ldarg.0
      IL_01a9:  ldc.i4.s   -2
      IL_01ab:  stfld      int32 Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>1__state'
      IL_01b0:  ldarg.0
      IL_01b1:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>t__builder'
      IL_01b6:  ldloc.2
      IL_01b7:  call       instance void valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::SetResult(!0)
      IL_01bc:  ret
    } // end of method '<RunTestAsync>d__11'::MoveNext

    .method private hidebysig newslot virtual final 
            instance void  SetStateMachine(class [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .override [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine::SetStateMachine
      // Code size       13 (0xd)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>t__builder'
      IL_0006:  ldarg.1
      IL_0007:  call       instance void valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::SetStateMachine(class [mscorlib]System.Runtime.CompilerServices.IAsyncStateMachine)
      IL_000c:  ret
    } // end of method '<RunTestAsync>d__11'::SetStateMachine

  } // end of class '<RunTestAsync>d__11'

  .field private static initonly object[] s_noArguments
  .field private initonly class [xunit.core]Xunit.Sdk.ExceptionAggregator _cleanupAggregator
  .field private class [mscorlib]System.Exception _dataDiscoveryException
  .field private initonly class [mscorlib]System.Collections.Generic.List`1<class [xunit.execution.desktop]Xunit.Sdk.XunitTestRunner> _testRunners
  .field private initonly class [mscorlib]System.Collections.Generic.List`1<class [mscorlib]System.IDisposable> _toDispose
  .field private initonly class [xunit.abstractions]Xunit.Abstractions.IMessageSink '<DiagnosticMessageSink>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(class [xunit.core]Xunit.Sdk.IXunitTestCase testCase,
                               string displayName,
                               string skipReason,
                               object[] constructorArguments,
                               class [xunit.abstractions]Xunit.Abstractions.IMessageSink diagnosticMessageSink,
                               class [xunit.core]Xunit.Sdk.IMessageBus messageBus,
                               class [xunit.core]Xunit.Sdk.ExceptionAggregator aggregator,
                               class [mscorlib]System.Threading.CancellationTokenSource cancellationTokenSource) cil managed
  {
    // Code size       64 (0x40)
    .maxstack  9
    IL_0000:  ldarg.0
    IL_0001:  newobj     instance void [xunit.core]Xunit.Sdk.ExceptionAggregator::.ctor()
    IL_0006:  stfld      class [xunit.core]Xunit.Sdk.ExceptionAggregator Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::_cleanupAggregator
    IL_000b:  ldarg.0
    IL_000c:  newobj     instance void class [mscorlib]System.Collections.Generic.List`1<class [xunit.execution.desktop]Xunit.Sdk.XunitTestRunner>::.ctor()
    IL_0011:  stfld      class [mscorlib]System.Collections.Generic.List`1<class [xunit.execution.desktop]Xunit.Sdk.XunitTestRunner> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::_testRunners
    IL_0016:  ldarg.0
    IL_0017:  newobj     instance void class [mscorlib]System.Collections.Generic.List`1<class [mscorlib]System.IDisposable>::.ctor()
    IL_001c:  stfld      class [mscorlib]System.Collections.Generic.List`1<class [mscorlib]System.IDisposable> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::_toDispose
    IL_0021:  ldarg.0
    IL_0022:  ldarg.1
    IL_0023:  ldarg.2
    IL_0024:  ldarg.3
    IL_0025:  ldarg.s    constructorArguments
    IL_0027:  ldsfld     object[] Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::s_noArguments
    IL_002c:  ldarg.s    messageBus
    IL_002e:  ldarg.s    aggregator
    IL_0030:  ldarg.s    cancellationTokenSource
    IL_0032:  call       instance void [xunit.execution.desktop]Xunit.Sdk.XunitTestCaseRunner::.ctor(class [xunit.core]Xunit.Sdk.IXunitTestCase,
                                                                                                     string,
                                                                                                     string,
                                                                                                     object[],
                                                                                                     object[],
                                                                                                     class [xunit.core]Xunit.Sdk.IMessageBus,
                                                                                                     class [xunit.core]Xunit.Sdk.ExceptionAggregator,
                                                                                                     class [mscorlib]System.Threading.CancellationTokenSource)
    IL_0037:  ldarg.0
    IL_0038:  ldarg.s    diagnosticMessageSink
    IL_003a:  stfld      class [xunit.abstractions]Xunit.Abstractions.IMessageSink Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::'<DiagnosticMessageSink>k__BackingField'
    IL_003f:  ret
  } // end of method XunitParallelTheoryTestCaseRunner::.ctor

  .method private hidebysig specialname instance class [xunit.abstractions]Xunit.Abstractions.IMessageSink 
          get_DiagnosticMessageSink() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      class [xunit.abstractions]Xunit.Abstractions.IMessageSink Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::'<DiagnosticMessageSink>k__BackingField'
    IL_0006:  ret
  } // end of method XunitParallelTheoryTestCaseRunner::get_DiagnosticMessageSink

  .method family hidebysig virtual instance class [mscorlib]System.Threading.Tasks.Task 
          AfterTestCaseStartingAsync() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [mscorlib]System.Type) = ( 01 00 63 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..cMicrosoft.Dot
                                                                                                                                       4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                                                                       6F 6E 73 2E 58 75 6E 69 74 50 61 72 61 6C 6C 65   // ons.XunitParalle
                                                                                                                                       6C 54 68 65 6F 72 79 54 65 73 74 43 61 73 65 52   // lTheoryTestCaseR
                                                                                                                                       75 6E 6E 65 72 2B 3C 41 66 74 65 72 54 65 73 74   // unner+<AfterTest
                                                                                                                                       43 61 73 65 53 74 61 72 74 69 6E 67 41 73 79 6E   // CaseStartingAsyn
                                                                                                                                       63 3E 64 5F 5F 39 00 00 )                         // c>d__9..
    // Code size       55 (0x37)
    .maxstack  2
    .locals init (valuetype Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9' V_0)
    IL_0000:  ldloca.s   V_0
    IL_0002:  call       valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create()
    IL_0007:  stfld      valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>t__builder'
    IL_000c:  ldloca.s   V_0
    IL_000e:  ldarg.0
    IL_000f:  stfld      class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>4__this'
    IL_0014:  ldloca.s   V_0
    IL_0016:  ldc.i4.m1
    IL_0017:  stfld      int32 Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>1__state'
    IL_001c:  ldloca.s   V_0
    IL_001e:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>t__builder'
    IL_0023:  ldloca.s   V_0
    IL_0025:  call       instance void [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'>(!!0&)
    IL_002a:  ldloca.s   V_0
    IL_002c:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<AfterTestCaseStartingAsync>d__9'::'<>t__builder'
    IL_0031:  call       instance class [mscorlib]System.Threading.Tasks.Task [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task()
    IL_0036:  ret
  } // end of method XunitParallelTheoryTestCaseRunner::AfterTestCaseStartingAsync

  .method family hidebysig virtual instance class [mscorlib]System.Threading.Tasks.Task 
          BeforeTestCaseFinishedAsync() cil managed
  {
    // Code size       24 (0x18)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance class [xunit.core]Xunit.Sdk.ExceptionAggregator class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_Aggregator()
    IL_0006:  ldarg.0
    IL_0007:  ldfld      class [xunit.core]Xunit.Sdk.ExceptionAggregator Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::_cleanupAggregator
    IL_000c:  callvirt   instance void [xunit.core]Xunit.Sdk.ExceptionAggregator::Aggregate(class [xunit.core]Xunit.Sdk.ExceptionAggregator)
    IL_0011:  ldarg.0
    IL_0012:  call       instance class [mscorlib]System.Threading.Tasks.Task class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::BeforeTestCaseFinishedAsync()
    IL_0017:  ret
  } // end of method XunitParallelTheoryTestCaseRunner::BeforeTestCaseFinishedAsync

  .method family hidebysig virtual instance class [mscorlib]System.Threading.Tasks.Task`1<class [xunit.core]Xunit.Sdk.RunSummary> 
          RunTestAsync() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [mscorlib]System.Type) = ( 01 00 56 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..VMicrosoft.Dot
                                                                                                                                       4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                                                                       6F 6E 73 2E 58 75 6E 69 74 50 61 72 61 6C 6C 65   // ons.XunitParalle
                                                                                                                                       6C 54 68 65 6F 72 79 54 65 73 74 43 61 73 65 52   // lTheoryTestCaseR
                                                                                                                                       75 6E 6E 65 72 2B 3C 52 75 6E 54 65 73 74 41 73   // unner+<RunTestAs
                                                                                                                                       79 6E 63 3E 64 5F 5F 31 31 00 00 )                // ync>d__11..
    // Code size       55 (0x37)
    .maxstack  2
    .locals init (valuetype Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11' V_0)
    IL_0000:  ldloca.s   V_0
    IL_0002:  call       valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<!0> valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::Create()
    IL_0007:  stfld      valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>t__builder'
    IL_000c:  ldloca.s   V_0
    IL_000e:  ldarg.0
    IL_000f:  stfld      class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>4__this'
    IL_0014:  ldloca.s   V_0
    IL_0016:  ldc.i4.m1
    IL_0017:  stfld      int32 Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>1__state'
    IL_001c:  ldloca.s   V_0
    IL_001e:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>t__builder'
    IL_0023:  ldloca.s   V_0
    IL_0025:  call       instance void valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::Start<valuetype Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'>(!!0&)
    IL_002a:  ldloca.s   V_0
    IL_002c:  ldflda     valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary> Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner/'<RunTestAsync>d__11'::'<>t__builder'
    IL_0031:  call       instance class [mscorlib]System.Threading.Tasks.Task`1<!0> valuetype [mscorlib]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<class [xunit.core]Xunit.Sdk.RunSummary>::get_Task()
    IL_0036:  ret
  } // end of method XunitParallelTheoryTestCaseRunner::RunTestAsync

  .method private hidebysig instance class [xunit.core]Xunit.Sdk.RunSummary 
          RunTest_DataDiscoveryException() cil managed
  {
    // Code size       153 (0x99)
    .maxstack  5
    .locals init (class [xunit.execution.desktop]Xunit.Sdk.XunitTest V_0)
    IL_0000:  ldarg.0
    IL_0001:  call       instance !0 class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_TestCase()
    IL_0006:  ldarg.0
    IL_0007:  call       instance string [xunit.execution.desktop]Xunit.Sdk.XunitTestCaseRunner::get_DisplayName()
    IL_000c:  newobj     instance void [xunit.execution.desktop]Xunit.Sdk.XunitTest::.ctor(class [xunit.core]Xunit.Sdk.IXunitTestCase,
                                                                                           string)
    IL_0011:  stloc.0
    IL_0012:  ldarg.0
    IL_0013:  call       instance class [xunit.core]Xunit.Sdk.IMessageBus class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_MessageBus()
    IL_0018:  ldloc.0
    IL_0019:  newobj     instance void [xunit.execution.desktop]Xunit.Sdk.TestStarting::.ctor(class [xunit.abstractions]Xunit.Abstractions.ITest)
    IL_001e:  callvirt   instance bool [xunit.core]Xunit.Sdk.IMessageBus::QueueMessage(class [xunit.abstractions]Xunit.Abstractions.IMessageSinkMessage)
    IL_0023:  brtrue.s   IL_0032

    IL_0025:  ldarg.0
    IL_0026:  call       instance class [mscorlib]System.Threading.CancellationTokenSource class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_CancellationTokenSource()
    IL_002b:  callvirt   instance void [mscorlib]System.Threading.CancellationTokenSource::Cancel()
    IL_0030:  br.s       IL_0061

    IL_0032:  ldarg.0
    IL_0033:  call       instance class [xunit.core]Xunit.Sdk.IMessageBus class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_MessageBus()
    IL_0038:  ldloc.0
    IL_0039:  ldsfld     valuetype [mscorlib]System.Decimal [mscorlib]System.Decimal::Zero
    IL_003e:  ldnull
    IL_003f:  ldarg.0
    IL_0040:  ldfld      class [mscorlib]System.Exception Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::_dataDiscoveryException
    IL_0045:  call       class [mscorlib]System.Exception Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::Unwrap(class [mscorlib]System.Exception)
    IL_004a:  newobj     instance void [xunit.execution.desktop]Xunit.Sdk.TestFailed::.ctor(class [xunit.abstractions]Xunit.Abstractions.ITest,
                                                                                            valuetype [mscorlib]System.Decimal,
                                                                                            string,
                                                                                            class [mscorlib]System.Exception)
    IL_004f:  callvirt   instance bool [xunit.core]Xunit.Sdk.IMessageBus::QueueMessage(class [xunit.abstractions]Xunit.Abstractions.IMessageSinkMessage)
    IL_0054:  brtrue.s   IL_0061

    IL_0056:  ldarg.0
    IL_0057:  call       instance class [mscorlib]System.Threading.CancellationTokenSource class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_CancellationTokenSource()
    IL_005c:  callvirt   instance void [mscorlib]System.Threading.CancellationTokenSource::Cancel()
    IL_0061:  ldarg.0
    IL_0062:  call       instance class [xunit.core]Xunit.Sdk.IMessageBus class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_MessageBus()
    IL_0067:  ldloc.0
    IL_0068:  ldsfld     valuetype [mscorlib]System.Decimal [mscorlib]System.Decimal::Zero
    IL_006d:  ldnull
    IL_006e:  newobj     instance void [xunit.execution.desktop]Xunit.Sdk.TestFinished::.ctor(class [xunit.abstractions]Xunit.Abstractions.ITest,
                                                                                              valuetype [mscorlib]System.Decimal,
                                                                                              string)
    IL_0073:  callvirt   instance bool [xunit.core]Xunit.Sdk.IMessageBus::QueueMessage(class [xunit.abstractions]Xunit.Abstractions.IMessageSinkMessage)
    IL_0078:  brtrue.s   IL_0085

    IL_007a:  ldarg.0
    IL_007b:  call       instance class [mscorlib]System.Threading.CancellationTokenSource class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::get_CancellationTokenSource()
    IL_0080:  callvirt   instance void [mscorlib]System.Threading.CancellationTokenSource::Cancel()
    IL_0085:  newobj     instance void [xunit.core]Xunit.Sdk.RunSummary::.ctor()
    IL_008a:  dup
    IL_008b:  ldc.i4.1
    IL_008c:  stfld      int32 [xunit.core]Xunit.Sdk.RunSummary::Total
    IL_0091:  dup
    IL_0092:  ldc.i4.1
    IL_0093:  stfld      int32 [xunit.core]Xunit.Sdk.RunSummary::Failed
    IL_0098:  ret
  } // end of method XunitParallelTheoryTestCaseRunner::RunTest_DataDiscoveryException

  .method private hidebysig static class [mscorlib]System.Exception 
          Unwrap(class [mscorlib]System.Exception ex) cil managed
  {
    // Code size       22 (0x16)
    .maxstack  1
    .locals init (class [mscorlib]System.Reflection.TargetInvocationException V_0)
    IL_0000:  ldarg.0
    IL_0001:  isinst     [mscorlib]System.Reflection.TargetInvocationException
    IL_0006:  stloc.0
    IL_0007:  ldloc.0
    IL_0008:  brtrue.s   IL_000c

    IL_000a:  ldarg.0
    IL_000b:  ret

    IL_000c:  ldloc.0
    IL_000d:  callvirt   instance class [mscorlib]System.Exception [mscorlib]System.Exception::get_InnerException()
    IL_0012:  starg.s    ex
    IL_0014:  br.s       IL_0000
  } // end of method XunitParallelTheoryTestCaseRunner::Unwrap

  .method private hidebysig specialname rtspecialname static 
          void  .cctor() cil managed
  {
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  ldc.i4.0
    IL_0001:  newarr     [mscorlib]System.Object
    IL_0006:  stsfld     object[] Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::s_noArguments
    IL_000b:  ret
  } // end of method XunitParallelTheoryTestCaseRunner::.cctor

  .method private hidebysig instance class [mscorlib]System.Threading.Tasks.Task 
          '<>n__0'() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance class [mscorlib]System.Threading.Tasks.Task class [xunit.execution.desktop]Xunit.Sdk.TestCaseRunner`1<class [xunit.core]Xunit.Sdk.IXunitTestCase>::AfterTestCaseStartingAsync()
    IL_0006:  ret
  } // end of method XunitParallelTheoryTestCaseRunner::'<>n__0'

  .property instance class [xunit.abstractions]Xunit.Abstractions.IMessageSink
          DiagnosticMessageSink()
  {
    .get instance class [xunit.abstractions]Xunit.Abstractions.IMessageSink Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner::get_DiagnosticMessageSink()
  } // end of property XunitParallelTheoryTestCaseRunner::DiagnosticMessageSink
} // end of class Microsoft.DotNet.XUnitExtensions.XunitParallelTheoryTestCaseRunner

.class public auto ansi sealed beforefieldinit Microsoft.DotNet.XUnitExtensions.Attributes.ParallelTheoryAttribute
       extends [xunit.core]Xunit.TheoryAttribute
{
  .custom instance void [xunit.core]Xunit.Sdk.XunitTestCaseDiscovererAttribute::.ctor(string,
                                                                                      string) = ( 01 00 39 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..9Microsoft.Dot
                                                                                                  4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                                  6F 6E 73 2E 50 61 72 61 6C 6C 65 6C 54 68 65 6F   // ons.ParallelTheo
                                                                                                  72 79 44 69 73 63 6F 76 65 72 65 72 20 4D 69 63   // ryDiscoverer Mic
                                                                                                  72 6F 73 6F 66 74 2E 44 6F 74 4E 65 74 2E 58 55   // rosoft.DotNet.XU
                                                                                                  6E 69 74 45 78 74 65 6E 73 69 6F 6E 73 00 00 )    // nitExtensions..
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 40 00 00 00 01 00 54 02 0D 41 6C 6C 6F 77   // ..@.....T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 )                      // Multiple.
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.TheoryAttribute::.ctor()
    IL_0006:  ret
  } // end of method ParallelTheoryAttribute::.ctor

} // end of class Microsoft.DotNet.XUnitExtensions.Attributes.ParallelTheoryAttribute

.class public auto ansi beforefieldinit Xunit.ActiveIssueAttribute
       extends [mscorlib]System.Attribute
       implements [xunit.core]Xunit.Sdk.ITraitAttribute
{
  .custom instance void [xunit.core]Xunit.Sdk.TraitDiscovererAttribute::.ctor(string,
                                                                              string) = ( 01 00 36 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..6Microsoft.Dot
                                                                                          4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                          6F 6E 73 2E 41 63 74 69 76 65 49 73 73 75 65 44   // ons.ActiveIssueD
                                                                                          69 73 63 6F 76 65 72 65 72 20 4D 69 63 72 6F 73   // iscoverer Micros
                                                                                          6F 66 74 2E 44 6F 74 4E 65 74 2E 58 55 6E 69 74   // oft.DotNet.XUnit
                                                                                          45 78 74 65 6E 73 69 6F 6E 73 00 00 )             // Extensions..
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 45 00 00 00 01 00 54 02 0D 41 6C 6C 6F 77   // ..E.....T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 01 )                      // Multiple.
  .field private class [mscorlib]System.Type '<CalleeType>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .field private string[] '<ConditionMemberNames>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname instance class [mscorlib]System.Type 
          get_CalleeType() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      class [mscorlib]System.Type Xunit.ActiveIssueAttribute::'<CalleeType>k__BackingField'
    IL_0006:  ret
  } // end of method ActiveIssueAttribute::get_CalleeType

  .method private hidebysig specialname instance void 
          set_CalleeType(class [mscorlib]System.Type 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      class [mscorlib]System.Type Xunit.ActiveIssueAttribute::'<CalleeType>k__BackingField'
    IL_0007:  ret
  } // end of method ActiveIssueAttribute::set_CalleeType

  .method public hidebysig specialname instance string[] 
          get_ConditionMemberNames() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      string[] Xunit.ActiveIssueAttribute::'<ConditionMemberNames>k__BackingField'
    IL_0006:  ret
  } // end of method ActiveIssueAttribute::get_ConditionMemberNames

  .method private hidebysig specialname instance void 
          set_ConditionMemberNames(string[] 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      string[] Xunit.ActiveIssueAttribute::'<ConditionMemberNames>k__BackingField'
    IL_0007:  ret
  } // end of method ActiveIssueAttribute::set_ConditionMemberNames

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string issue,
                               valuetype Xunit.TestPlatforms platforms) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method ActiveIssueAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string issue,
                               valuetype Xunit.TargetFrameworkMonikers framework) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method ActiveIssueAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string issue,
                               valuetype Xunit.TestRuntimes runtimes) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method ActiveIssueAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string issue,
                               [opt] valuetype Xunit.TestPlatforms platforms,
                               [opt] valuetype Xunit.TargetFrameworkMonikers framework,
                               [opt] valuetype Xunit.TestRuntimes runtimes) cil managed
  {
    .param [2] = int32(0xFFFFFFFF)
    .param [3] = int32(0xFFFFFFFF)
    .param [4] = int32(0xFFFFFFFF)
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method ActiveIssueAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string issue,
                               class [mscorlib]System.Type calleeType,
                               string[] conditionMemberNames) cil managed
  {
    .param [3]
    .custom instance void [mscorlib]System.ParamArrayAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       21 (0x15)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldarg.2
    IL_0008:  call       instance void Xunit.ActiveIssueAttribute::set_CalleeType(class [mscorlib]System.Type)
    IL_000d:  ldarg.0
    IL_000e:  ldarg.3
    IL_000f:  call       instance void Xunit.ActiveIssueAttribute::set_ConditionMemberNames(string[])
    IL_0014:  ret
  } // end of method ActiveIssueAttribute::.ctor

  .property instance class [mscorlib]System.Type
          CalleeType()
  {
    .get instance class [mscorlib]System.Type Xunit.ActiveIssueAttribute::get_CalleeType()
    .set instance void Xunit.ActiveIssueAttribute::set_CalleeType(class [mscorlib]System.Type)
  } // end of property ActiveIssueAttribute::CalleeType
  .property instance string[] ConditionMemberNames()
  {
    .get instance string[] Xunit.ActiveIssueAttribute::get_ConditionMemberNames()
    .set instance void Xunit.ActiveIssueAttribute::set_ConditionMemberNames(string[])
  } // end of property ActiveIssueAttribute::ConditionMemberNames
} // end of class Xunit.ActiveIssueAttribute

.class public auto ansi sealed beforefieldinit Xunit.ConditionalClassAttribute
       extends [mscorlib]System.Attribute
       implements [xunit.core]Xunit.Sdk.ITraitAttribute
{
  .custom instance void [xunit.core]Xunit.Sdk.TraitDiscovererAttribute::.ctor(string,
                                                                              string) = ( 01 00 3B 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..;Microsoft.Dot
                                                                                          4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                          6F 6E 73 2E 43 6F 6E 64 69 74 69 6F 6E 61 6C 43   // ons.ConditionalC
                                                                                          6C 61 73 73 44 69 73 63 6F 76 65 72 65 72 20 4D   // lassDiscoverer M
                                                                                          69 63 72 6F 73 6F 66 74 2E 44 6F 74 4E 65 74 2E   // icrosoft.DotNet.
                                                                                          58 55 6E 69 74 45 78 74 65 6E 73 69 6F 6E 73 00   // XUnitExtensions.
                                                                                          00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 04 00 00 00 01 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 )                      // Multiple.
  .field private class [mscorlib]System.Type '<CalleeType>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .field private string[] '<ConditionMemberNames>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname instance class [mscorlib]System.Type 
          get_CalleeType() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      class [mscorlib]System.Type Xunit.ConditionalClassAttribute::'<CalleeType>k__BackingField'
    IL_0006:  ret
  } // end of method ConditionalClassAttribute::get_CalleeType

  .method private hidebysig specialname instance void 
          set_CalleeType(class [mscorlib]System.Type 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      class [mscorlib]System.Type Xunit.ConditionalClassAttribute::'<CalleeType>k__BackingField'
    IL_0007:  ret
  } // end of method ConditionalClassAttribute::set_CalleeType

  .method public hidebysig specialname instance string[] 
          get_ConditionMemberNames() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      string[] Xunit.ConditionalClassAttribute::'<ConditionMemberNames>k__BackingField'
    IL_0006:  ret
  } // end of method ConditionalClassAttribute::get_ConditionMemberNames

  .method private hidebysig specialname instance void 
          set_ConditionMemberNames(string[] 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      string[] Xunit.ConditionalClassAttribute::'<ConditionMemberNames>k__BackingField'
    IL_0007:  ret
  } // end of method ConditionalClassAttribute::set_ConditionMemberNames

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(class [mscorlib]System.Type calleeType,
                               string[] conditionMemberNames) cil managed
  {
    .param [1]
    .custom instance void System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembersAttribute::.ctor(valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes) = ( 01 00 FF FF FF FF 00 00 ) 
    .param [2]
    .custom instance void [mscorlib]System.ParamArrayAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       21 (0x15)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldarg.1
    IL_0008:  call       instance void Xunit.ConditionalClassAttribute::set_CalleeType(class [mscorlib]System.Type)
    IL_000d:  ldarg.0
    IL_000e:  ldarg.2
    IL_000f:  call       instance void Xunit.ConditionalClassAttribute::set_ConditionMemberNames(string[])
    IL_0014:  ret
  } // end of method ConditionalClassAttribute::.ctor

  .property instance class [mscorlib]System.Type
          CalleeType()
  {
    .custom instance void System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembersAttribute::.ctor(valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes) = ( 01 00 FF FF FF FF 00 00 ) 
    .get instance class [mscorlib]System.Type Xunit.ConditionalClassAttribute::get_CalleeType()
    .set instance void Xunit.ConditionalClassAttribute::set_CalleeType(class [mscorlib]System.Type)
  } // end of property ConditionalClassAttribute::CalleeType
  .property instance string[] ConditionMemberNames()
  {
    .get instance string[] Xunit.ConditionalClassAttribute::get_ConditionMemberNames()
    .set instance void Xunit.ConditionalClassAttribute::set_ConditionMemberNames(string[])
  } // end of property ConditionalClassAttribute::ConditionMemberNames
} // end of class Xunit.ConditionalClassAttribute

.class public auto ansi sealed beforefieldinit Xunit.ConditionalFactAttribute
       extends [xunit.core]Xunit.FactAttribute
{
  .custom instance void [xunit.core]Xunit.Sdk.XunitTestCaseDiscovererAttribute::.ctor(string,
                                                                                      string) = ( 01 00 3A 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..:Microsoft.Dot
                                                                                                  4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                                  6F 6E 73 2E 43 6F 6E 64 69 74 69 6F 6E 61 6C 46   // ons.ConditionalF
                                                                                                  61 63 74 44 69 73 63 6F 76 65 72 65 72 20 4D 69   // actDiscoverer Mi
                                                                                                  63 72 6F 73 6F 66 74 2E 44 6F 74 4E 65 74 2E 58   // crosoft.DotNet.X
                                                                                                  55 6E 69 74 45 78 74 65 6E 73 69 6F 6E 73 00 00 ) // UnitExtensions..
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 40 00 00 00 01 00 54 02 0D 41 6C 6C 6F 77   // ..@.....T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 )                      // Multiple.
  .field private class [mscorlib]System.Type '<CalleeType>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .field private string[] '<ConditionMemberNames>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname instance class [mscorlib]System.Type 
          get_CalleeType() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      class [mscorlib]System.Type Xunit.ConditionalFactAttribute::'<CalleeType>k__BackingField'
    IL_0006:  ret
  } // end of method ConditionalFactAttribute::get_CalleeType

  .method private hidebysig specialname instance void 
          set_CalleeType(class [mscorlib]System.Type 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      class [mscorlib]System.Type Xunit.ConditionalFactAttribute::'<CalleeType>k__BackingField'
    IL_0007:  ret
  } // end of method ConditionalFactAttribute::set_CalleeType

  .method public hidebysig specialname instance string[] 
          get_ConditionMemberNames() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      string[] Xunit.ConditionalFactAttribute::'<ConditionMemberNames>k__BackingField'
    IL_0006:  ret
  } // end of method ConditionalFactAttribute::get_ConditionMemberNames

  .method private hidebysig specialname instance void 
          set_ConditionMemberNames(string[] 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      string[] Xunit.ConditionalFactAttribute::'<ConditionMemberNames>k__BackingField'
    IL_0007:  ret
  } // end of method ConditionalFactAttribute::set_ConditionMemberNames

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(class [mscorlib]System.Type calleeType,
                               string[] conditionMemberNames) cil managed
  {
    .param [1]
    .custom instance void System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembersAttribute::.ctor(valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes) = ( 01 00 FF FF FF FF 00 00 ) 
    .param [2]
    .custom instance void [mscorlib]System.ParamArrayAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       21 (0x15)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.FactAttribute::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldarg.1
    IL_0008:  call       instance void Xunit.ConditionalFactAttribute::set_CalleeType(class [mscorlib]System.Type)
    IL_000d:  ldarg.0
    IL_000e:  ldarg.2
    IL_000f:  call       instance void Xunit.ConditionalFactAttribute::set_ConditionMemberNames(string[])
    IL_0014:  ret
  } // end of method ConditionalFactAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string[] conditionMemberNames) cil managed
  {
    .param [1]
    .custom instance void [mscorlib]System.ParamArrayAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.FactAttribute::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldarg.1
    IL_0008:  call       instance void Xunit.ConditionalFactAttribute::set_ConditionMemberNames(string[])
    IL_000d:  ret
  } // end of method ConditionalFactAttribute::.ctor

  .property instance class [mscorlib]System.Type
          CalleeType()
  {
    .custom instance void System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembersAttribute::.ctor(valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes) = ( 01 00 FF FF FF FF 00 00 ) 
    .get instance class [mscorlib]System.Type Xunit.ConditionalFactAttribute::get_CalleeType()
    .set instance void Xunit.ConditionalFactAttribute::set_CalleeType(class [mscorlib]System.Type)
  } // end of property ConditionalFactAttribute::CalleeType
  .property instance string[] ConditionMemberNames()
  {
    .get instance string[] Xunit.ConditionalFactAttribute::get_ConditionMemberNames()
    .set instance void Xunit.ConditionalFactAttribute::set_ConditionMemberNames(string[])
  } // end of property ConditionalFactAttribute::ConditionMemberNames
} // end of class Xunit.ConditionalFactAttribute

.class public auto ansi sealed beforefieldinit Xunit.ConditionalTheoryAttribute
       extends [xunit.core]Xunit.TheoryAttribute
{
  .custom instance void [xunit.core]Xunit.Sdk.XunitTestCaseDiscovererAttribute::.ctor(string,
                                                                                      string) = ( 01 00 3C 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..<Microsoft.Dot
                                                                                                  4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                                  6F 6E 73 2E 43 6F 6E 64 69 74 69 6F 6E 61 6C 54   // ons.ConditionalT
                                                                                                  68 65 6F 72 79 44 69 73 63 6F 76 65 72 65 72 20   // heoryDiscoverer 
                                                                                                  4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74 4E 65 74   // Microsoft.DotNet
                                                                                                  2E 58 55 6E 69 74 45 78 74 65 6E 73 69 6F 6E 73   // .XUnitExtensions
                                                                                                  00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 40 00 00 00 01 00 54 02 0D 41 6C 6C 6F 77   // ..@.....T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 )                      // Multiple.
  .field private class [mscorlib]System.Type '<CalleeType>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .field private string[] '<ConditionMemberNames>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname instance class [mscorlib]System.Type 
          get_CalleeType() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      class [mscorlib]System.Type Xunit.ConditionalTheoryAttribute::'<CalleeType>k__BackingField'
    IL_0006:  ret
  } // end of method ConditionalTheoryAttribute::get_CalleeType

  .method private hidebysig specialname instance void 
          set_CalleeType(class [mscorlib]System.Type 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      class [mscorlib]System.Type Xunit.ConditionalTheoryAttribute::'<CalleeType>k__BackingField'
    IL_0007:  ret
  } // end of method ConditionalTheoryAttribute::set_CalleeType

  .method public hidebysig specialname instance string[] 
          get_ConditionMemberNames() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      string[] Xunit.ConditionalTheoryAttribute::'<ConditionMemberNames>k__BackingField'
    IL_0006:  ret
  } // end of method ConditionalTheoryAttribute::get_ConditionMemberNames

  .method private hidebysig specialname instance void 
          set_ConditionMemberNames(string[] 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      string[] Xunit.ConditionalTheoryAttribute::'<ConditionMemberNames>k__BackingField'
    IL_0007:  ret
  } // end of method ConditionalTheoryAttribute::set_ConditionMemberNames

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(class [mscorlib]System.Type calleeType,
                               string[] conditionMemberNames) cil managed
  {
    .param [1]
    .custom instance void System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembersAttribute::.ctor(valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes) = ( 01 00 FF FF FF FF 00 00 ) 
    .param [2]
    .custom instance void [mscorlib]System.ParamArrayAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       21 (0x15)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.TheoryAttribute::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldarg.1
    IL_0008:  call       instance void Xunit.ConditionalTheoryAttribute::set_CalleeType(class [mscorlib]System.Type)
    IL_000d:  ldarg.0
    IL_000e:  ldarg.2
    IL_000f:  call       instance void Xunit.ConditionalTheoryAttribute::set_ConditionMemberNames(string[])
    IL_0014:  ret
  } // end of method ConditionalTheoryAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string[] conditionMemberNames) cil managed
  {
    .param [1]
    .custom instance void [mscorlib]System.ParamArrayAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.TheoryAttribute::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldarg.1
    IL_0008:  call       instance void Xunit.ConditionalTheoryAttribute::set_ConditionMemberNames(string[])
    IL_000d:  ret
  } // end of method ConditionalTheoryAttribute::.ctor

  .property instance class [mscorlib]System.Type
          CalleeType()
  {
    .custom instance void System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembersAttribute::.ctor(valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes) = ( 01 00 FF FF FF FF 00 00 ) 
    .get instance class [mscorlib]System.Type Xunit.ConditionalTheoryAttribute::get_CalleeType()
    .set instance void Xunit.ConditionalTheoryAttribute::set_CalleeType(class [mscorlib]System.Type)
  } // end of property ConditionalTheoryAttribute::CalleeType
  .property instance string[] ConditionMemberNames()
  {
    .get instance string[] Xunit.ConditionalTheoryAttribute::get_ConditionMemberNames()
    .set instance void Xunit.ConditionalTheoryAttribute::set_ConditionMemberNames(string[])
  } // end of property ConditionalTheoryAttribute::ConditionMemberNames
} // end of class Xunit.ConditionalTheoryAttribute

.class public auto ansi beforefieldinit Xunit.DotNetOnlyFactAttribute
       extends [xunit.core]Xunit.FactAttribute
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor([opt] string additionalMessage) cil managed
  {
    .custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 02 00 00 ) 
    .param [1] = nullref
    // Code size       31 (0x1f)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.FactAttribute::.ctor()
    IL_0006:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::get_IsRunningOnNetCoreApp()
    IL_000b:  brtrue.s   IL_001e

    IL_000d:  ldarg.0
    IL_000e:  ldstr      "This test only runs on .NET."
    IL_0013:  ldarg.1
    IL_0014:  call       string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::AppendAdditionalMessage(string,
                                                                                                            string)
    IL_0019:  callvirt   instance void [xunit.core]Xunit.FactAttribute::set_Skip(string)
    IL_001e:  ret
  } // end of method DotNetOnlyFactAttribute::.ctor

} // end of class Xunit.DotNetOnlyFactAttribute

.class public auto ansi beforefieldinit Xunit.DotNetOnlyTheoryAttribute
       extends [xunit.core]Xunit.TheoryAttribute
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor([opt] string additionalMessage) cil managed
  {
    .custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 02 00 00 ) 
    .param [1] = nullref
    // Code size       31 (0x1f)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.TheoryAttribute::.ctor()
    IL_0006:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::get_IsRunningOnNetCoreApp()
    IL_000b:  brtrue.s   IL_001e

    IL_000d:  ldarg.0
    IL_000e:  ldstr      "This test only runs on .NET."
    IL_0013:  ldarg.1
    IL_0014:  call       string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::AppendAdditionalMessage(string,
                                                                                                            string)
    IL_0019:  callvirt   instance void [xunit.core]Xunit.FactAttribute::set_Skip(string)
    IL_001e:  ret
  } // end of method DotNetOnlyTheoryAttribute::.ctor

} // end of class Xunit.DotNetOnlyTheoryAttribute

.class public auto ansi beforefieldinit Xunit.LinuxOnlyFactAttribute
       extends [xunit.core]Xunit.FactAttribute
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor([opt] string additionalMessage) cil managed
  {
    .custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 02 00 00 ) 
    .param [1] = nullref
    // Code size       36 (0x24)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.FactAttribute::.ctor()
    IL_0006:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::get_Linux()
    IL_000b:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0010:  brtrue.s   IL_0023

    IL_0012:  ldarg.0
    IL_0013:  ldstr      "This test requires Linux to run."
    IL_0018:  ldarg.1
    IL_0019:  call       string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::AppendAdditionalMessage(string,
                                                                                                            string)
    IL_001e:  callvirt   instance void [xunit.core]Xunit.FactAttribute::set_Skip(string)
    IL_0023:  ret
  } // end of method LinuxOnlyFactAttribute::.ctor

} // end of class Xunit.LinuxOnlyFactAttribute

.class public auto ansi beforefieldinit Xunit.LinuxOnlyTheoryAttribute
       extends [xunit.core]Xunit.TheoryAttribute
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor([opt] string additionalMessage) cil managed
  {
    .custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 02 00 00 ) 
    .param [1] = nullref
    // Code size       36 (0x24)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.TheoryAttribute::.ctor()
    IL_0006:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::get_Linux()
    IL_000b:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0010:  brtrue.s   IL_0023

    IL_0012:  ldarg.0
    IL_0013:  ldstr      "This test requires Linux to run."
    IL_0018:  ldarg.1
    IL_0019:  call       string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::AppendAdditionalMessage(string,
                                                                                                            string)
    IL_001e:  callvirt   instance void [xunit.core]Xunit.FactAttribute::set_Skip(string)
    IL_0023:  ret
  } // end of method LinuxOnlyTheoryAttribute::.ctor

} // end of class Xunit.LinuxOnlyTheoryAttribute

.class public auto ansi beforefieldinit Xunit.MacOSOnlyFactAttribute
       extends [xunit.core]Xunit.FactAttribute
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor([opt] string additionalMessage) cil managed
  {
    .custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 02 00 00 ) 
    .param [1] = nullref
    // Code size       36 (0x24)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.FactAttribute::.ctor()
    IL_0006:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::get_OSX()
    IL_000b:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0010:  brtrue.s   IL_0023

    IL_0012:  ldarg.0
    IL_0013:  ldstr      "This test requires macOS to run."
    IL_0018:  ldarg.1
    IL_0019:  call       string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::AppendAdditionalMessage(string,
                                                                                                            string)
    IL_001e:  callvirt   instance void [xunit.core]Xunit.FactAttribute::set_Skip(string)
    IL_0023:  ret
  } // end of method MacOSOnlyFactAttribute::.ctor

} // end of class Xunit.MacOSOnlyFactAttribute

.class public auto ansi beforefieldinit Xunit.MacOSOnlyTheoryAttribute
       extends [xunit.core]Xunit.TheoryAttribute
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor([opt] string additionalMessage) cil managed
  {
    .custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 02 00 00 ) 
    .param [1] = nullref
    // Code size       36 (0x24)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.TheoryAttribute::.ctor()
    IL_0006:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::get_OSX()
    IL_000b:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0010:  brtrue.s   IL_0023

    IL_0012:  ldarg.0
    IL_0013:  ldstr      "This test requires macOS to run."
    IL_0018:  ldarg.1
    IL_0019:  call       string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::AppendAdditionalMessage(string,
                                                                                                            string)
    IL_001e:  callvirt   instance void [xunit.core]Xunit.FactAttribute::set_Skip(string)
    IL_0023:  ret
  } // end of method MacOSOnlyTheoryAttribute::.ctor

} // end of class Xunit.MacOSOnlyTheoryAttribute

.class public auto ansi beforefieldinit Xunit.OuterLoopAttribute
       extends [mscorlib]System.Attribute
       implements [xunit.core]Xunit.Sdk.ITraitAttribute
{
  .custom instance void [xunit.core]Xunit.Sdk.TraitDiscovererAttribute::.ctor(string,
                                                                              string) = ( 01 00 39 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..9Microsoft.Dot
                                                                                          4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                          6F 6E 73 2E 4F 75 74 65 72 4C 6F 6F 70 54 65 73   // ons.OuterLoopTes
                                                                                          74 73 44 69 73 63 6F 76 65 72 65 72 20 4D 69 63   // tsDiscoverer Mic
                                                                                          72 6F 73 6F 66 74 2E 44 6F 74 4E 65 74 2E 58 55   // rosoft.DotNet.XU
                                                                                          6E 69 74 45 78 74 65 6E 73 69 6F 6E 73 00 00 )    // nitExtensions..
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 44 00 00 00 01 00 54 02 0D 41 6C 6C 6F 77   // ..D.....T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 01 )                      // Multiple.
  .field private class [mscorlib]System.Type '<CalleeType>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .field private string[] '<ConditionMemberNames>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname instance class [mscorlib]System.Type 
          get_CalleeType() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      class [mscorlib]System.Type Xunit.OuterLoopAttribute::'<CalleeType>k__BackingField'
    IL_0006:  ret
  } // end of method OuterLoopAttribute::get_CalleeType

  .method private hidebysig specialname instance void 
          set_CalleeType(class [mscorlib]System.Type 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      class [mscorlib]System.Type Xunit.OuterLoopAttribute::'<CalleeType>k__BackingField'
    IL_0007:  ret
  } // end of method OuterLoopAttribute::set_CalleeType

  .method public hidebysig specialname instance string[] 
          get_ConditionMemberNames() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      string[] Xunit.OuterLoopAttribute::'<ConditionMemberNames>k__BackingField'
    IL_0006:  ret
  } // end of method OuterLoopAttribute::get_ConditionMemberNames

  .method private hidebysig specialname instance void 
          set_ConditionMemberNames(string[] 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      string[] Xunit.OuterLoopAttribute::'<ConditionMemberNames>k__BackingField'
    IL_0007:  ret
  } // end of method OuterLoopAttribute::set_ConditionMemberNames

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method OuterLoopAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method OuterLoopAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason,
                               valuetype Xunit.TestPlatforms platforms) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method OuterLoopAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason,
                               valuetype Xunit.TargetFrameworkMonikers framework) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method OuterLoopAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason,
                               valuetype Xunit.TestRuntimes runtimes) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method OuterLoopAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason,
                               [opt] valuetype Xunit.TestPlatforms platforms,
                               [opt] valuetype Xunit.TargetFrameworkMonikers framework,
                               [opt] valuetype Xunit.TestRuntimes runtimes) cil managed
  {
    .param [2] = int32(0xFFFFFFFF)
    .param [3] = int32(0xFFFFFFFF)
    .param [4] = int32(0xFFFFFFFF)
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method OuterLoopAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason,
                               class [mscorlib]System.Type calleeType,
                               string[] conditionMemberNames) cil managed
  {
    .param [3]
    .custom instance void [mscorlib]System.ParamArrayAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       21 (0x15)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldarg.2
    IL_0008:  call       instance void Xunit.OuterLoopAttribute::set_CalleeType(class [mscorlib]System.Type)
    IL_000d:  ldarg.0
    IL_000e:  ldarg.3
    IL_000f:  call       instance void Xunit.OuterLoopAttribute::set_ConditionMemberNames(string[])
    IL_0014:  ret
  } // end of method OuterLoopAttribute::.ctor

  .property instance class [mscorlib]System.Type
          CalleeType()
  {
    .get instance class [mscorlib]System.Type Xunit.OuterLoopAttribute::get_CalleeType()
    .set instance void Xunit.OuterLoopAttribute::set_CalleeType(class [mscorlib]System.Type)
  } // end of property OuterLoopAttribute::CalleeType
  .property instance string[] ConditionMemberNames()
  {
    .get instance string[] Xunit.OuterLoopAttribute::get_ConditionMemberNames()
    .set instance void Xunit.OuterLoopAttribute::set_ConditionMemberNames(string[])
  } // end of property OuterLoopAttribute::ConditionMemberNames
} // end of class Xunit.OuterLoopAttribute

.class public auto ansi beforefieldinit Xunit.PlatformSpecificAttribute
       extends [mscorlib]System.Attribute
       implements [xunit.core]Xunit.Sdk.ITraitAttribute
{
  .custom instance void [xunit.core]Xunit.Sdk.TraitDiscovererAttribute::.ctor(string,
                                                                              string) = ( 01 00 3B 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..;Microsoft.Dot
                                                                                          4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                          6F 6E 73 2E 50 6C 61 74 66 6F 72 6D 53 70 65 63   // ons.PlatformSpec
                                                                                          69 66 69 63 44 69 73 63 6F 76 65 72 65 72 20 4D   // ificDiscoverer M
                                                                                          69 63 72 6F 73 6F 66 74 2E 44 6F 74 4E 65 74 2E   // icrosoft.DotNet.
                                                                                          58 55 6E 69 74 45 78 74 65 6E 73 69 6F 6E 73 00   // XUnitExtensions.
                                                                                          00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 44 00 00 00 01 00 54 02 0D 41 6C 6C 6F 77   // ..D.....T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 )                      // Multiple.
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(valuetype Xunit.TestPlatforms platforms) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method PlatformSpecificAttribute::.ctor

} // end of class Xunit.PlatformSpecificAttribute

.class public auto ansi sealed beforefieldinit Xunit.SkipOnCIAttribute
       extends [mscorlib]System.Attribute
       implements [xunit.core]Xunit.Sdk.ITraitAttribute
{
  .custom instance void [xunit.core]Xunit.Sdk.TraitDiscovererAttribute::.ctor(string,
                                                                              string) = ( 01 00 33 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..3Microsoft.Dot
                                                                                          4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                          6F 6E 73 2E 53 6B 69 70 4F 6E 43 49 44 69 73 63   // ons.SkipOnCIDisc
                                                                                          6F 76 65 72 65 72 20 4D 69 63 72 6F 73 6F 66 74   // overer Microsoft
                                                                                          2E 44 6F 74 4E 65 74 2E 58 55 6E 69 74 45 78 74   // .DotNet.XUnitExt
                                                                                          65 6E 73 69 6F 6E 73 00 00 )                      // ensions..
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 45 00 00 00 01 00 54 02 0D 41 6C 6C 6F 77   // ..E.....T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 )                      // Multiple.
  .field private string '<Reason>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname instance string 
          get_Reason() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      string Xunit.SkipOnCIAttribute::'<Reason>k__BackingField'
    IL_0006:  ret
  } // end of method SkipOnCIAttribute::get_Reason

  .method private hidebysig specialname instance void 
          set_Reason(string 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      string Xunit.SkipOnCIAttribute::'<Reason>k__BackingField'
    IL_0007:  ret
  } // end of method SkipOnCIAttribute::set_Reason

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason) cil managed
  {
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldarg.1
    IL_0008:  call       instance void Xunit.SkipOnCIAttribute::set_Reason(string)
    IL_000d:  ret
  } // end of method SkipOnCIAttribute::.ctor

  .property instance string Reason()
  {
    .get instance string Xunit.SkipOnCIAttribute::get_Reason()
    .set instance void Xunit.SkipOnCIAttribute::set_Reason(string)
  } // end of property SkipOnCIAttribute::Reason
} // end of class Xunit.SkipOnCIAttribute

.class public auto ansi beforefieldinit Xunit.SkipOnCoreClrAttribute
       extends [mscorlib]System.Attribute
       implements [xunit.core]Xunit.Sdk.ITraitAttribute
{
  .custom instance void [xunit.core]Xunit.Sdk.TraitDiscovererAttribute::.ctor(string,
                                                                              string) = ( 01 00 38 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..8Microsoft.Dot
                                                                                          4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                          6F 6E 73 2E 53 6B 69 70 4F 6E 43 6F 72 65 43 6C   // ons.SkipOnCoreCl
                                                                                          72 44 69 73 63 6F 76 65 72 65 72 20 4D 69 63 72   // rDiscoverer Micr
                                                                                          6F 73 6F 66 74 2E 44 6F 74 4E 65 74 2E 58 55 6E   // osoft.DotNet.XUn
                                                                                          69 74 45 78 74 65 6E 73 69 6F 6E 73 00 00 )       // itExtensions..
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 45 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ..E.....T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 01 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 01 )                               // rited.
  .method assembly hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method SkipOnCoreClrAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason,
                               valuetype Xunit.TestPlatforms testPlatforms) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method SkipOnCoreClrAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason,
                               valuetype Xunit.RuntimeTestModes testMode) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method SkipOnCoreClrAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason,
                               valuetype Xunit.RuntimeConfiguration runtimeConfigurations) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method SkipOnCoreClrAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason,
                               valuetype Xunit.RuntimeConfiguration runtimeConfigurations,
                               valuetype Xunit.RuntimeTestModes testModes) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method SkipOnCoreClrAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason,
                               valuetype Xunit.TestPlatforms testPlatforms,
                               valuetype Xunit.RuntimeConfiguration runtimeConfigurations) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method SkipOnCoreClrAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason,
                               valuetype Xunit.TestPlatforms testPlatforms,
                               valuetype Xunit.RuntimeTestModes testMode) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method SkipOnCoreClrAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason,
                               valuetype Xunit.TestPlatforms testPlatforms,
                               valuetype Xunit.RuntimeConfiguration runtimeConfigurations,
                               valuetype Xunit.RuntimeTestModes testModes) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method SkipOnCoreClrAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method SkipOnCoreClrAttribute::.ctor

} // end of class Xunit.SkipOnCoreClrAttribute

.class public auto ansi beforefieldinit Xunit.SkipOnMonoAttribute
       extends [mscorlib]System.Attribute
       implements [xunit.core]Xunit.Sdk.ITraitAttribute
{
  .custom instance void [xunit.core]Xunit.Sdk.TraitDiscovererAttribute::.ctor(string,
                                                                              string) = ( 01 00 35 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..5Microsoft.Dot
                                                                                          4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                          6F 6E 73 2E 53 6B 69 70 4F 6E 4D 6F 6E 6F 44 69   // ons.SkipOnMonoDi
                                                                                          73 63 6F 76 65 72 65 72 20 4D 69 63 72 6F 73 6F   // scoverer Microso
                                                                                          66 74 2E 44 6F 74 4E 65 74 2E 58 55 6E 69 74 45   // ft.DotNet.XUnitE
                                                                                          78 74 65 6E 73 69 6F 6E 73 00 00 )                // xtensions..
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 45 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ..E.....T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 01 )                               // rited.
  .method assembly hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method SkipOnMonoAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string reason,
                               [opt] valuetype Xunit.TestPlatforms testPlatforms) cil managed
  {
    .param [2] = int32(0xFFFFFFFF)
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method SkipOnMonoAttribute::.ctor

} // end of class Xunit.SkipOnMonoAttribute

.class public auto ansi beforefieldinit Xunit.SkipOnPlatformAttribute
       extends [mscorlib]System.Attribute
       implements [xunit.core]Xunit.Sdk.ITraitAttribute
{
  .custom instance void [xunit.core]Xunit.Sdk.TraitDiscovererAttribute::.ctor(string,
                                                                              string) = ( 01 00 39 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..9Microsoft.Dot
                                                                                          4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                          6F 6E 73 2E 53 6B 69 70 4F 6E 50 6C 61 74 66 6F   // ons.SkipOnPlatfo
                                                                                          72 6D 44 69 73 63 6F 76 65 72 65 72 20 4D 69 63   // rmDiscoverer Mic
                                                                                          72 6F 73 6F 66 74 2E 44 6F 74 4E 65 74 2E 58 55   // rosoft.DotNet.XU
                                                                                          6E 69 74 45 78 74 65 6E 73 69 6F 6E 73 00 00 )    // nitExtensions..
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 45 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ..E.....T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 01 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 01 )                               // rited.
  .method assembly hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method SkipOnPlatformAttribute::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(valuetype Xunit.TestPlatforms testPlatforms,
                               string reason) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method SkipOnPlatformAttribute::.ctor

} // end of class Xunit.SkipOnPlatformAttribute

.class public auto ansi beforefieldinit Xunit.SkipOnTargetFrameworkAttribute
       extends [mscorlib]System.Attribute
       implements [xunit.core]Xunit.Sdk.ITraitAttribute
{
  .custom instance void [xunit.core]Xunit.Sdk.TraitDiscovererAttribute::.ctor(string,
                                                                              string) = ( 01 00 40 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..@Microsoft.Dot
                                                                                          4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                          6F 6E 73 2E 53 6B 69 70 4F 6E 54 61 72 67 65 74   // ons.SkipOnTarget
                                                                                          46 72 61 6D 65 77 6F 72 6B 44 69 73 63 6F 76 65   // FrameworkDiscove
                                                                                          72 65 72 20 4D 69 63 72 6F 73 6F 66 74 2E 44 6F   // rer Microsoft.Do
                                                                                          74 4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73   // tNet.XUnitExtens
                                                                                          69 6F 6E 73 00 00 )                               // ions..
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 44 00 00 00 01 00 54 02 0D 41 6C 6C 6F 77   // ..D.....T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 01 )                      // Multiple.
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(valuetype Xunit.TargetFrameworkMonikers platform,
                               [opt] string reason) cil managed
  {
    .param [2] = nullref
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method SkipOnTargetFrameworkAttribute::.ctor

} // end of class Xunit.SkipOnTargetFrameworkAttribute

.class public auto ansi beforefieldinit Xunit.TestCategoryAttribute
       extends [mscorlib]System.Attribute
       implements [xunit.core]Xunit.Sdk.ITraitAttribute
{
  .custom instance void [xunit.core]Xunit.Sdk.TraitDiscovererAttribute::.ctor(string,
                                                                              string) = ( 01 00 37 4D 69 63 72 6F 73 6F 66 74 2E 44 6F 74   // ..7Microsoft.Dot
                                                                                          4E 65 74 2E 58 55 6E 69 74 45 78 74 65 6E 73 69   // Net.XUnitExtensi
                                                                                          6F 6E 73 2E 54 65 73 74 43 61 74 65 67 6F 72 79   // ons.TestCategory
                                                                                          44 69 73 63 6F 76 65 72 65 72 20 4D 69 63 72 6F   // Discoverer Micro
                                                                                          73 6F 66 74 2E 44 6F 74 4E 65 74 2E 58 55 6E 69   // soft.DotNet.XUni
                                                                                          74 45 78 74 65 6E 73 69 6F 6E 73 00 00 )          // tExtensions..
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 44 00 00 00 01 00 54 02 0D 41 6C 6C 6F 77   // ..D.....T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 01 )                      // Multiple.
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string category) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method TestCategoryAttribute::.ctor

} // end of class Xunit.TestCategoryAttribute

.class public auto ansi beforefieldinit Xunit.UnixOnlyFactAttribute
       extends [xunit.core]Xunit.FactAttribute
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor([opt] string additionalMessage) cil managed
  {
    .custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 02 00 00 ) 
    .param [1] = nullref
    // Code size       36 (0x24)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.FactAttribute::.ctor()
    IL_0006:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::get_Windows()
    IL_000b:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0010:  brfalse.s  IL_0023

    IL_0012:  ldarg.0
    IL_0013:  ldstr      "This test requires Unix to run."
    IL_0018:  ldarg.1
    IL_0019:  call       string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::AppendAdditionalMessage(string,
                                                                                                            string)
    IL_001e:  callvirt   instance void [xunit.core]Xunit.FactAttribute::set_Skip(string)
    IL_0023:  ret
  } // end of method UnixOnlyFactAttribute::.ctor

} // end of class Xunit.UnixOnlyFactAttribute

.class public auto ansi beforefieldinit Xunit.UnixOnlyTheoryAttribute
       extends [xunit.core]Xunit.TheoryAttribute
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor([opt] string additionalMessage) cil managed
  {
    .custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 02 00 00 ) 
    .param [1] = nullref
    // Code size       36 (0x24)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.TheoryAttribute::.ctor()
    IL_0006:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::get_Windows()
    IL_000b:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0010:  brfalse.s  IL_0023

    IL_0012:  ldarg.0
    IL_0013:  ldstr      "This test requires Unix to run."
    IL_0018:  ldarg.1
    IL_0019:  call       string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::AppendAdditionalMessage(string,
                                                                                                            string)
    IL_001e:  callvirt   instance void [xunit.core]Xunit.FactAttribute::set_Skip(string)
    IL_0023:  ret
  } // end of method UnixOnlyTheoryAttribute::.ctor

} // end of class Xunit.UnixOnlyTheoryAttribute

.class public auto ansi beforefieldinit Xunit.WindowsFullFrameworkOnlyFactAttribute
       extends [xunit.core]Xunit.FactAttribute
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor([opt] string additionalMessage) cil managed
  {
    .custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 02 00 00 ) 
    .param [1] = nullref
    // Code size       61 (0x3d)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.FactAttribute::.ctor()
    IL_0006:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::get_Windows()
    IL_000b:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0010:  brtrue.s   IL_0024

    IL_0012:  ldarg.0
    IL_0013:  ldstr      "This test only runs on Windows on .NET Framework."
    IL_0018:  ldarg.1
    IL_0019:  call       string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::AppendAdditionalMessage(string,
                                                                                                            string)
    IL_001e:  callvirt   instance void [xunit.core]Xunit.FactAttribute::set_Skip(string)
    IL_0023:  ret

    IL_0024:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::get_IsRunningOnNetFramework()
    IL_0029:  brtrue.s   IL_003c

    IL_002b:  ldarg.0
    IL_002c:  ldstr      "This test only runs on .NET Framework."
    IL_0031:  ldarg.1
    IL_0032:  call       string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::AppendAdditionalMessage(string,
                                                                                                            string)
    IL_0037:  callvirt   instance void [xunit.core]Xunit.FactAttribute::set_Skip(string)
    IL_003c:  ret
  } // end of method WindowsFullFrameworkOnlyFactAttribute::.ctor

} // end of class Xunit.WindowsFullFrameworkOnlyFactAttribute

.class public auto ansi beforefieldinit Xunit.WindowsFullFrameworkOnlyTheoryAttribute
       extends [xunit.core]Xunit.TheoryAttribute
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor([opt] string additionalMessage) cil managed
  {
    .custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 02 00 00 ) 
    .param [1] = nullref
    // Code size       61 (0x3d)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.TheoryAttribute::.ctor()
    IL_0006:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::get_Windows()
    IL_000b:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0010:  brtrue.s   IL_0024

    IL_0012:  ldarg.0
    IL_0013:  ldstr      "This test only runs on Windows on full framework."
    IL_0018:  ldarg.1
    IL_0019:  call       string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::AppendAdditionalMessage(string,
                                                                                                            string)
    IL_001e:  callvirt   instance void [xunit.core]Xunit.FactAttribute::set_Skip(string)
    IL_0023:  ret

    IL_0024:  call       bool Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::get_IsRunningOnNetFramework()
    IL_0029:  brtrue.s   IL_003c

    IL_002b:  ldarg.0
    IL_002c:  ldstr      "This test only runs on full framework."
    IL_0031:  ldarg.1
    IL_0032:  call       string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::AppendAdditionalMessage(string,
                                                                                                            string)
    IL_0037:  callvirt   instance void [xunit.core]Xunit.FactAttribute::set_Skip(string)
    IL_003c:  ret
  } // end of method WindowsFullFrameworkOnlyTheoryAttribute::.ctor

} // end of class Xunit.WindowsFullFrameworkOnlyTheoryAttribute

.class public auto ansi beforefieldinit Xunit.WindowsOnlyFactAttribute
       extends [xunit.core]Xunit.FactAttribute
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor([opt] string additionalMessage) cil managed
  {
    .custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 02 00 00 ) 
    .param [1] = nullref
    // Code size       36 (0x24)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.FactAttribute::.ctor()
    IL_0006:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::get_Windows()
    IL_000b:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0010:  brtrue.s   IL_0023

    IL_0012:  ldarg.0
    IL_0013:  ldstr      "This test requires Windows to run."
    IL_0018:  ldarg.1
    IL_0019:  call       string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::AppendAdditionalMessage(string,
                                                                                                            string)
    IL_001e:  callvirt   instance void [xunit.core]Xunit.FactAttribute::set_Skip(string)
    IL_0023:  ret
  } // end of method WindowsOnlyFactAttribute::.ctor

} // end of class Xunit.WindowsOnlyFactAttribute

.class public auto ansi beforefieldinit Xunit.WindowsOnlyTheoryAttribute
       extends [xunit.core]Xunit.TheoryAttribute
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor([opt] string additionalMessage) cil managed
  {
    .custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 02 00 00 ) 
    .param [1] = nullref
    // Code size       36 (0x24)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [xunit.core]Xunit.TheoryAttribute::.ctor()
    IL_0006:  call       valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform::get_Windows()
    IL_000b:  call       bool [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.RuntimeInformation::IsOSPlatform(valuetype [System.Runtime.InteropServices.RuntimeInformation]System.Runtime.InteropServices.OSPlatform)
    IL_0010:  brtrue.s   IL_0023

    IL_0012:  ldarg.0
    IL_0013:  ldstr      "This test requires Windows to run."
    IL_0018:  ldarg.1
    IL_0019:  call       string Microsoft.DotNet.XUnitExtensions.DiscovererHelpers::AppendAdditionalMessage(string,
                                                                                                            string)
    IL_001e:  callvirt   instance void [xunit.core]Xunit.FactAttribute::set_Skip(string)
    IL_0023:  ret
  } // end of method WindowsOnlyTheoryAttribute::.ctor

} // end of class Xunit.WindowsOnlyTheoryAttribute

.class public abstract auto ansi sealed beforefieldinit Xunit.CoreClrConfigurationDetection
       extends [mscorlib]System.Object
{
  .method public hidebysig specialname static 
          bool  get_IsJitStress() cil managed
  {
    // Code size       30 (0x1e)
    .maxstack  8
    IL_0000:  ldstr      "JitStress"
    IL_0005:  ldstr      "0"
    IL_000a:  call       string Xunit.CoreClrConfigurationDetection::GetEnvironmentVariableValue(string,
                                                                                                 string)
    IL_000f:  ldstr      "0"
    IL_0014:  ldc.i4.2
    IL_0015:  call       bool [mscorlib]System.String::Equals(string,
                                                              string,
                                                              valuetype [mscorlib]System.StringComparison)
    IL_001a:  ldc.i4.0
    IL_001b:  ceq
    IL_001d:  ret
  } // end of method CoreClrConfigurationDetection::get_IsJitStress

  .method public hidebysig specialname static 
          bool  get_IsJitStressRegs() cil managed
  {
    // Code size       30 (0x1e)
    .maxstack  8
    IL_0000:  ldstr      "JitStressRegs"
    IL_0005:  ldstr      "0"
    IL_000a:  call       string Xunit.CoreClrConfigurationDetection::GetEnvironmentVariableValue(string,
                                                                                                 string)
    IL_000f:  ldstr      "0"
    IL_0014:  ldc.i4.2
    IL_0015:  call       bool [mscorlib]System.String::Equals(string,
                                                              string,
                                                              valuetype [mscorlib]System.StringComparison)
    IL_001a:  ldc.i4.0
    IL_001b:  ceq
    IL_001d:  ret
  } // end of method CoreClrConfigurationDetection::get_IsJitStressRegs

  .method public hidebysig specialname static 
          bool  get_IsJitMinOpts() cil managed
  {
    // Code size       27 (0x1b)
    .maxstack  8
    IL_0000:  ldstr      "JITMinOpts"
    IL_0005:  ldstr      "0"
    IL_000a:  call       string Xunit.CoreClrConfigurationDetection::GetEnvironmentVariableValue(string,
                                                                                                 string)
    IL_000f:  ldstr      "1"
    IL_0014:  ldc.i4.2
    IL_0015:  call       bool [mscorlib]System.String::Equals(string,
                                                              string,
                                                              valuetype [mscorlib]System.StringComparison)
    IL_001a:  ret
  } // end of method CoreClrConfigurationDetection::get_IsJitMinOpts

  .method public hidebysig specialname static 
          bool  get_IsTailCallStress() cil managed
  {
    // Code size       27 (0x1b)
    .maxstack  8
    IL_0000:  ldstr      "TailcallStress"
    IL_0005:  ldstr      "0"
    IL_000a:  call       string Xunit.CoreClrConfigurationDetection::GetEnvironmentVariableValue(string,
                                                                                                 string)
    IL_000f:  ldstr      "1"
    IL_0014:  ldc.i4.2
    IL_0015:  call       bool [mscorlib]System.String::Equals(string,
                                                              string,
                                                              valuetype [mscorlib]System.StringComparison)
    IL_001a:  ret
  } // end of method CoreClrConfigurationDetection::get_IsTailCallStress

  .method public hidebysig specialname static 
          bool  get_IsZapDisable() cil managed
  {
    // Code size       27 (0x1b)
    .maxstack  8
    IL_0000:  ldstr      "ZapDisable"
    IL_0005:  ldstr      "0"
    IL_000a:  call       string Xunit.CoreClrConfigurationDetection::GetEnvironmentVariableValue(string,
                                                                                                 string)
    IL_000f:  ldstr      "1"
    IL_0014:  ldc.i4.2
    IL_0015:  call       bool [mscorlib]System.String::Equals(string,
                                                              string,
                                                              valuetype [mscorlib]System.StringComparison)
    IL_001a:  ret
  } // end of method CoreClrConfigurationDetection::get_IsZapDisable

  .method public hidebysig specialname static 
          bool  get_IsGCStress3() cil managed
  {
    // Code size       31 (0x1f)
    .maxstack  8
    IL_0000:  ldstr      "GCStress"
    IL_0005:  ldstr      "0"
    IL_000a:  call       string Xunit.CoreClrConfigurationDetection::GetEnvironmentVariableValue(string,
                                                                                                 string)
    IL_000f:  ldstr      "0x3"
    IL_0014:  ldstr      "3"
    IL_0019:  call       bool Xunit.CoreClrConfigurationDetection::CompareGCStressModeAsLower(string,
                                                                                              string,
                                                                                              string)
    IL_001e:  ret
  } // end of method CoreClrConfigurationDetection::get_IsGCStress3

  .method public hidebysig specialname static 
          bool  get_IsGCStressC() cil managed
  {
    // Code size       31 (0x1f)
    .maxstack  8
    IL_0000:  ldstr      "GCStress"
    IL_0005:  ldstr      "0"
    IL_000a:  call       string Xunit.CoreClrConfigurationDetection::GetEnvironmentVariableValue(string,
                                                                                                 string)
    IL_000f:  ldstr      "0xC"
    IL_0014:  ldstr      "C"
    IL_0019:  call       bool Xunit.CoreClrConfigurationDetection::CompareGCStressModeAsLower(string,
                                                                                              string,
                                                                                              string)
    IL_001e:  ret
  } // end of method CoreClrConfigurationDetection::get_IsGCStressC

  .method public hidebysig specialname static 
          bool  get_IsTieredCompilation() cil managed
  {
    // Code size       27 (0x1b)
    .maxstack  8
    IL_0000:  ldstr      "TieredCompilation"
    IL_0005:  ldstr      "1"
    IL_000a:  call       string Xunit.CoreClrConfigurationDetection::GetEnvironmentVariableValue(string,
                                                                                                 string)
    IL_000f:  ldstr      "1"
    IL_0014:  ldc.i4.2
    IL_0015:  call       bool [mscorlib]System.String::Equals(string,
                                                              string,
                                                              valuetype [mscorlib]System.StringComparison)
    IL_001a:  ret
  } // end of method CoreClrConfigurationDetection::get_IsTieredCompilation

  .method public hidebysig specialname static 
          bool  get_IsHeapVerify() cil managed
  {
    // Code size       27 (0x1b)
    .maxstack  8
    IL_0000:  ldstr      "HeapVerify"
    IL_0005:  ldstr      "0"
    IL_000a:  call       string Xunit.CoreClrConfigurationDetection::GetEnvironmentVariableValue(string,
                                                                                                 string)
    IL_000f:  ldstr      "1"
    IL_0014:  ldc.i4.2
    IL_0015:  call       bool [mscorlib]System.String::Equals(string,
                                                              string,
                                                              valuetype [mscorlib]System.StringComparison)
    IL_001a:  ret
  } // end of method CoreClrConfigurationDetection::get_IsHeapVerify

  .method public hidebysig specialname static 
          bool  get_IsGCStress() cil managed
  {
    // Code size       30 (0x1e)
    .maxstack  8
    IL_0000:  ldstr      "GCStress"
    IL_0005:  ldstr      "0"
    IL_000a:  call       string Xunit.CoreClrConfigurationDetection::GetEnvironmentVariableValue(string,
                                                                                                 string)
    IL_000f:  ldstr      "0"
    IL_0014:  ldc.i4.2
    IL_0015:  call       bool [mscorlib]System.String::Equals(string,
                                                              string,
                                                              valuetype [mscorlib]System.StringComparison)
    IL_001a:  ldc.i4.0
    IL_001b:  ceq
    IL_001d:  ret
  } // end of method CoreClrConfigurationDetection::get_IsGCStress

  .method public hidebysig specialname static 
          bool  get_IsAnyJitStress() cil managed
  {
    // Code size       29 (0x1d)
    .maxstack  8
    IL_0000:  call       bool Xunit.CoreClrConfigurationDetection::get_IsJitStress()
    IL_0005:  brtrue.s   IL_001b

    IL_0007:  call       bool Xunit.CoreClrConfigurationDetection::get_IsJitStressRegs()
    IL_000c:  brtrue.s   IL_001b

    IL_000e:  call       bool Xunit.CoreClrConfigurationDetection::get_IsJitMinOpts()
    IL_0013:  brtrue.s   IL_001b

    IL_0015:  call       bool Xunit.CoreClrConfigurationDetection::get_IsTailCallStress()
    IL_001a:  ret

    IL_001b:  ldc.i4.1
    IL_001c:  ret
  } // end of method CoreClrConfigurationDetection::get_IsAnyJitStress

  .method public hidebysig specialname static 
          bool  get_IsAnyJitOptimizationStress() cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  call       bool Xunit.CoreClrConfigurationDetection::get_IsAnyJitStress()
    IL_0005:  brtrue.s   IL_000d

    IL_0007:  call       bool Xunit.CoreClrConfigurationDetection::get_IsTieredCompilation()
    IL_000c:  ret

    IL_000d:  ldc.i4.1
    IL_000e:  ret
  } // end of method CoreClrConfigurationDetection::get_IsAnyJitOptimizationStress

  .method public hidebysig specialname static 
          bool  get_IsCheckedRuntime() cil managed
  {
    // Code size       11 (0xb)
    .maxstack  8
    IL_0000:  ldstr      "Checked"
    IL_0005:  call       bool Xunit.CoreClrConfigurationDetection::AssemblyConfigurationEquals(string)
    IL_000a:  ret
  } // end of method CoreClrConfigurationDetection::get_IsCheckedRuntime

  .method public hidebysig specialname static 
          bool  get_IsReleaseRuntime() cil managed
  {
    // Code size       11 (0xb)
    .maxstack  8
    IL_0000:  ldstr      "Release"
    IL_0005:  call       bool Xunit.CoreClrConfigurationDetection::AssemblyConfigurationEquals(string)
    IL_000a:  ret
  } // end of method CoreClrConfigurationDetection::get_IsReleaseRuntime

  .method public hidebysig specialname static 
          bool  get_IsDebugRuntime() cil managed
  {
    // Code size       11 (0xb)
    .maxstack  8
    IL_0000:  ldstr      "Debug"
    IL_0005:  call       bool Xunit.CoreClrConfigurationDetection::AssemblyConfigurationEquals(string)
    IL_000a:  ret
  } // end of method CoreClrConfigurationDetection::get_IsDebugRuntime

  .method public hidebysig specialname static 
          bool  get_IsStressTest() cil managed
  {
    // Code size       29 (0x1d)
    .maxstack  8
    IL_0000:  call       bool Xunit.CoreClrConfigurationDetection::get_IsGCStress()
    IL_0005:  brtrue.s   IL_001b

    IL_0007:  call       bool Xunit.CoreClrConfigurationDetection::get_IsZapDisable()
    IL_000c:  brtrue.s   IL_001b

    IL_000e:  call       bool Xunit.CoreClrConfigurationDetection::get_IsAnyJitStress()
    IL_0013:  brtrue.s   IL_001b

    IL_0015:  call       bool Xunit.CoreClrConfigurationDetection::get_IsHeapVerify()
    IL_001a:  ret

    IL_001b:  ldc.i4.1
    IL_001c:  ret
  } // end of method CoreClrConfigurationDetection::get_IsStressTest

  .method private hidebysig static string 
          GetEnvironmentVariableValue(string name,
                                      [opt] string defaultValue) cil managed
  {
    .param [2] = "0"
    // Code size       42 (0x2a)
    .maxstack  8
    IL_0000:  ldstr      "DOTNET_"
    IL_0005:  ldarg.0
    IL_0006:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_000b:  call       string [mscorlib]System.Environment::GetEnvironmentVariable(string)
    IL_0010:  dup
    IL_0011:  brtrue.s   IL_0029

    IL_0013:  pop
    IL_0014:  ldstr      "COMPlus_"
    IL_0019:  ldarg.0
    IL_001a:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_001f:  call       string [mscorlib]System.Environment::GetEnvironmentVariable(string)
    IL_0024:  dup
    IL_0025:  brtrue.s   IL_0029

    IL_0027:  pop
    IL_0028:  ldarg.1
    IL_0029:  ret
  } // end of method CoreClrConfigurationDetection::GetEnvironmentVariableValue

  .method private hidebysig static bool  AssemblyConfigurationEquals(string configuration) cil managed
  {
    // Code size       40 (0x28)
    .maxstack  3
    .locals init (class [mscorlib]System.Reflection.AssemblyConfigurationAttribute V_0)
    IL_0000:  ldtoken    [mscorlib]System.String
    IL_0005:  call       class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)
    IL_000a:  callvirt   instance class [mscorlib]System.Reflection.Assembly [mscorlib]System.Type::get_Assembly()
    IL_000f:  call       !!0 [mscorlib]System.Reflection.CustomAttributeExtensions::GetCustomAttribute<class [mscorlib]System.Reflection.AssemblyConfigurationAttribute>(class [mscorlib]System.Reflection.Assembly)
    IL_0014:  stloc.0
    IL_0015:  ldloc.0
    IL_0016:  brfalse.s  IL_0026

    IL_0018:  ldloc.0
    IL_0019:  callvirt   instance string [mscorlib]System.Reflection.AssemblyConfigurationAttribute::get_Configuration()
    IL_001e:  ldarg.0
    IL_001f:  ldc.i4.2
    IL_0020:  call       bool [mscorlib]System.String::Equals(string,
                                                              string,
                                                              valuetype [mscorlib]System.StringComparison)
    IL_0025:  ret

    IL_0026:  ldc.i4.0
    IL_0027:  ret
  } // end of method CoreClrConfigurationDetection::AssemblyConfigurationEquals

  .method private hidebysig static bool  CompareGCStressModeAsLower(string 'value',
                                                                    string first,
                                                                    string second) cil managed
  {
    // Code size       67 (0x43)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  callvirt   instance string [mscorlib]System.String::ToLowerInvariant()
    IL_0006:  starg.s    'value'
    IL_0008:  ldarg.0
    IL_0009:  ldarg.1
    IL_000a:  callvirt   instance string [mscorlib]System.String::ToLowerInvariant()
    IL_000f:  ldc.i4.2
    IL_0010:  call       bool [mscorlib]System.String::Equals(string,
                                                              string,
                                                              valuetype [mscorlib]System.StringComparison)
    IL_0015:  brtrue.s   IL_0041

    IL_0017:  ldarg.0
    IL_0018:  ldarg.2
    IL_0019:  callvirt   instance string [mscorlib]System.String::ToLowerInvariant()
    IL_001e:  ldc.i4.2
    IL_001f:  call       bool [mscorlib]System.String::Equals(string,
                                                              string,
                                                              valuetype [mscorlib]System.StringComparison)
    IL_0024:  brtrue.s   IL_0041

    IL_0026:  ldarg.0
    IL_0027:  ldstr      "0xf"
    IL_002c:  ldc.i4.2
    IL_002d:  call       bool [mscorlib]System.String::Equals(string,
                                                              string,
                                                              valuetype [mscorlib]System.StringComparison)
    IL_0032:  brtrue.s   IL_0041

    IL_0034:  ldarg.0
    IL_0035:  ldstr      "f"
    IL_003a:  ldc.i4.2
    IL_003b:  call       bool [mscorlib]System.String::Equals(string,
                                                              string,
                                                              valuetype [mscorlib]System.StringComparison)
    IL_0040:  ret

    IL_0041:  ldc.i4.1
    IL_0042:  ret
  } // end of method CoreClrConfigurationDetection::CompareGCStressModeAsLower

  .property bool IsJitStress()
  {
    .get bool Xunit.CoreClrConfigurationDetection::get_IsJitStress()
  } // end of property CoreClrConfigurationDetection::IsJitStress
  .property bool IsJitStressRegs()
  {
    .get bool Xunit.CoreClrConfigurationDetection::get_IsJitStressRegs()
  } // end of property CoreClrConfigurationDetection::IsJitStressRegs
  .property bool IsJitMinOpts()
  {
    .get bool Xunit.CoreClrConfigurationDetection::get_IsJitMinOpts()
  } // end of property CoreClrConfigurationDetection::IsJitMinOpts
  .property bool IsTailCallStress()
  {
    .get bool Xunit.CoreClrConfigurationDetection::get_IsTailCallStress()
  } // end of property CoreClrConfigurationDetection::IsTailCallStress
  .property bool IsZapDisable()
  {
    .get bool Xunit.CoreClrConfigurationDetection::get_IsZapDisable()
  } // end of property CoreClrConfigurationDetection::IsZapDisable
  .property bool IsGCStress3()
  {
    .get bool Xunit.CoreClrConfigurationDetection::get_IsGCStress3()
  } // end of property CoreClrConfigurationDetection::IsGCStress3
  .property bool IsGCStressC()
  {
    .get bool Xunit.CoreClrConfigurationDetection::get_IsGCStressC()
  } // end of property CoreClrConfigurationDetection::IsGCStressC
  .property bool IsTieredCompilation()
  {
    .get bool Xunit.CoreClrConfigurationDetection::get_IsTieredCompilation()
  } // end of property CoreClrConfigurationDetection::IsTieredCompilation
  .property bool IsHeapVerify()
  {
    .get bool Xunit.CoreClrConfigurationDetection::get_IsHeapVerify()
  } // end of property CoreClrConfigurationDetection::IsHeapVerify
  .property bool IsGCStress()
  {
    .get bool Xunit.CoreClrConfigurationDetection::get_IsGCStress()
  } // end of property CoreClrConfigurationDetection::IsGCStress
  .property bool IsAnyJitStress()
  {
    .get bool Xunit.CoreClrConfigurationDetection::get_IsAnyJitStress()
  } // end of property CoreClrConfigurationDetection::IsAnyJitStress
  .property bool IsAnyJitOptimizationStress()
  {
    .get bool Xunit.CoreClrConfigurationDetection::get_IsAnyJitOptimizationStress()
  } // end of property CoreClrConfigurationDetection::IsAnyJitOptimizationStress
  .property bool IsCheckedRuntime()
  {
    .get bool Xunit.CoreClrConfigurationDetection::get_IsCheckedRuntime()
  } // end of property CoreClrConfigurationDetection::IsCheckedRuntime
  .property bool IsReleaseRuntime()
  {
    .get bool Xunit.CoreClrConfigurationDetection::get_IsReleaseRuntime()
  } // end of property CoreClrConfigurationDetection::IsReleaseRuntime
  .property bool IsDebugRuntime()
  {
    .get bool Xunit.CoreClrConfigurationDetection::get_IsDebugRuntime()
  } // end of property CoreClrConfigurationDetection::IsDebugRuntime
  .property bool IsStressTest()
  {
    .get bool Xunit.CoreClrConfigurationDetection::get_IsStressTest()
  } // end of property CoreClrConfigurationDetection::IsStressTest
} // end of class Xunit.CoreClrConfigurationDetection

.class public auto ansi sealed Xunit.RuntimeConfiguration
       extends [mscorlib]System.Enum
{
  .custom instance void [mscorlib]System.FlagsAttribute::.ctor() = ( 01 00 00 00 ) 
  .field public specialname rtspecialname int32 value__
  .field public static literal valuetype Xunit.RuntimeConfiguration Any = int32(0xFFFFFFFF)
  .field public static literal valuetype Xunit.RuntimeConfiguration Checked = int32(0x00000001)
  .field public static literal valuetype Xunit.RuntimeConfiguration Debug = int32(0x00000002)
  .field public static literal valuetype Xunit.RuntimeConfiguration Release = int32(0x00000004)
} // end of class Xunit.RuntimeConfiguration

.class public auto ansi sealed Xunit.RuntimeTestModes
       extends [mscorlib]System.Enum
{
  .custom instance void [mscorlib]System.FlagsAttribute::.ctor() = ( 01 00 00 00 ) 
  .field public specialname rtspecialname int32 value__
  .field public static literal valuetype Xunit.RuntimeTestModes Any = int32(0xFFFFFFFF)
  .field public static literal valuetype Xunit.RuntimeTestModes RegularRun = int32(0x00000001)
  .field public static literal valuetype Xunit.RuntimeTestModes JitStress = int32(0x00000002)
  .field public static literal valuetype Xunit.RuntimeTestModes JitStressRegs = int32(0x00000004)
  .field public static literal valuetype Xunit.RuntimeTestModes JitMinOpts = int32(0x00000008)
  .field public static literal valuetype Xunit.RuntimeTestModes TailcallStress = int32(0x00000010)
  .field public static literal valuetype Xunit.RuntimeTestModes ZapDisable = int32(0x00000020)
  .field public static literal valuetype Xunit.RuntimeTestModes GCStress3 = int32(0x00000040)
  .field public static literal valuetype Xunit.RuntimeTestModes GCStressC = int32(0x00000080)
  .field public static literal valuetype Xunit.RuntimeTestModes AnyGCStress = int32(0x000000C0)
  .field public static literal valuetype Xunit.RuntimeTestModes TieredCompilation = int32(0x00000100)
  .field public static literal valuetype Xunit.RuntimeTestModes AnyJitStress = int32(0x0000001E)
  .field public static literal valuetype Xunit.RuntimeTestModes AnyJitOptimizationStress = int32(0x0000011E)
  .field public static literal valuetype Xunit.RuntimeTestModes HeapVerify = int32(0x00000200)
} // end of class Xunit.RuntimeTestModes

.class private abstract auto ansi sealed beforefieldinit Xunit.StaticReflectionConstants
       extends [mscorlib]System.Object
{
  .field static assembly literal valuetype System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes ConditionalMemberKinds = int32(0xFFFFFFFF)
} // end of class Xunit.StaticReflectionConstants

.class public auto ansi sealed Xunit.TargetFrameworkMonikers
       extends [mscorlib]System.Enum
{
  .custom instance void [mscorlib]System.FlagsAttribute::.ctor() = ( 01 00 00 00 ) 
  .field public specialname rtspecialname int32 value__
  .field public static literal valuetype Xunit.TargetFrameworkMonikers Netcoreapp = int32(0x00000001)
  .field public static literal valuetype Xunit.TargetFrameworkMonikers NetFramework = int32(0x00000002)
  .field public static literal valuetype Xunit.TargetFrameworkMonikers Any = int32(0xFFFFFFFF)
} // end of class Xunit.TargetFrameworkMonikers

.class public auto ansi sealed Xunit.TestPlatforms
       extends [mscorlib]System.Enum
{
  .custom instance void [mscorlib]System.FlagsAttribute::.ctor() = ( 01 00 00 00 ) 
  .field public specialname rtspecialname int32 value__
  .field public static literal valuetype Xunit.TestPlatforms Windows = int32(0x00000001)
  .field public static literal valuetype Xunit.TestPlatforms Linux = int32(0x00000002)
  .field public static literal valuetype Xunit.TestPlatforms OSX = int32(0x00000004)
  .field public static literal valuetype Xunit.TestPlatforms FreeBSD = int32(0x00000008)
  .field public static literal valuetype Xunit.TestPlatforms NetBSD = int32(0x00000010)
  .field public static literal valuetype Xunit.TestPlatforms illumos = int32(0x00000020)
  .field public static literal valuetype Xunit.TestPlatforms Solaris = int32(0x00000040)
  .field public static literal valuetype Xunit.TestPlatforms iOS = int32(0x00000080)
  .field public static literal valuetype Xunit.TestPlatforms tvOS = int32(0x00000100)
  .field public static literal valuetype Xunit.TestPlatforms Android = int32(0x00000200)
  .field public static literal valuetype Xunit.TestPlatforms Browser = int32(0x00000400)
  .field public static literal valuetype Xunit.TestPlatforms MacCatalyst = int32(0x00000800)
  .field public static literal valuetype Xunit.TestPlatforms LinuxBionic = int32(0x00001000)
  .field public static literal valuetype Xunit.TestPlatforms Wasi = int32(0x00002000)
  .field public static literal valuetype Xunit.TestPlatforms Haiku = int32(0x00004000)
  .field public static literal valuetype Xunit.TestPlatforms AnyUnix = int32(0x00007FFE)
  .field public static literal valuetype Xunit.TestPlatforms Any = int32(0xFFFFFFFF)
} // end of class Xunit.TestPlatforms

.class public auto ansi sealed Xunit.TestRuntimes
       extends [mscorlib]System.Enum
{
  .custom instance void [mscorlib]System.FlagsAttribute::.ctor() = ( 01 00 00 00 ) 
  .field public specialname rtspecialname int32 value__
  .field public static literal valuetype Xunit.TestRuntimes CoreCLR = int32(0x00000001)
  .field public static literal valuetype Xunit.TestRuntimes Mono = int32(0x00000002)
  .field public static literal valuetype Xunit.TestRuntimes Any = int32(0xFFFFFFFF)
} // end of class Xunit.TestRuntimes


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// AVVISO: creato file di risorse Win32 .\Microsoft.DotNet.XUnitExtensions.res.

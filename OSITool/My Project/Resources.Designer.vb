﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("OSITool.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to sage-js res:osi:asm:sa &quot;%ProgramFiles(x86)%\LEGO Media\LEGO Bionicle (Beta)\data\Base.osi&quot; &quot;%UserProfile%\Documents\GitHub\Optional-OSIProject\OSIProject&quot;.
        '''</summary>
        Friend ReadOnly Property ASSEMBLE() As String
            Get
                Return ResourceManager.GetString("ASSEMBLE", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to sage-js res:osi:asm:sa &quot;%ProgramFiles(x86)%\LEGO Media\LEGO Bionicle\data\Base.osi&quot; &quot;%UserProfile%\Documents\GitHub\Alpha-OSIProject\OSIProject (Alpha)&quot;.
        '''</summary>
        Friend ReadOnly Property ASSEMBLE__ALPHA_() As String
            Get
                Return ResourceManager.GetString("ASSEMBLE__ALPHA_", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to sage-js res:osi:asm:sa &quot;%ProgramFiles(x86)%\LEGO Media\LEGO Bionicle (Beta [MAIN])\data\Base.osi&quot; &quot;%UserProfile%\Documents\GitHub\Main-OSIProject\OSIProject (Legacy)&quot;.
        '''</summary>
        Friend ReadOnly Property ASSEMBLE__LEGACY_() As String
            Get
                Return ResourceManager.GetString("ASSEMBLE__LEGACY_", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to sage-js res:osi:asm:sd &quot;%ProgramFiles(x86)%\LEGO Media\LEGO Bionicle (Beta)\data\Base.osi&quot; &quot;%UserProfile%\Documents\GitHub\Optional-OSIProject\OSIProject&quot; -p.
        '''</summary>
        Friend ReadOnly Property DISASSEMBLE() As String
            Get
                Return ResourceManager.GetString("DISASSEMBLE", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to sage-js res:osi:asm:sd &quot;%ProgramFiles(x86)%\LEGO Media\LEGO Bionicle\data\Base.osi&quot; &quot;%UserProfile%\Documents\GitHub\Alpha-OSIProject\OSIProject (Alpha)&quot; -p.
        '''</summary>
        Friend ReadOnly Property DISASSEMBLE__ALPHA_() As String
            Get
                Return ResourceManager.GetString("DISASSEMBLE__ALPHA_", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to sage-js res:osi:asm:sd &quot;%ProgramFiles(x86)%\LEGO Media\LEGO Bionicle (Beta [MAIN])\data\Base.osi&quot; &quot;%UserProfile%\Documents\GitHub\Main-OSIProject\OSIProject (Legacy)&quot; -p.
        '''</summary>
        Friend ReadOnly Property DISASSEMBLE__LEGACY_() As String
            Get
                Return ResourceManager.GetString("DISASSEMBLE__LEGACY_", resourceCulture)
            End Get
        End Property
    End Module
End Namespace

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RecompileButton{
	
	[MenuItem("Recompile/All")]
	public static void Recompile(){
		UnityEditor.Compilation.CompilationPipeline.RequestScriptCompilation();
	}


}

using System.Collections.Generic;

namespace YCode.Core.CSharpCodeGeneration;

public abstract class CSharpCodeGenerator
{
  public abstract void Generate(string fileName, string content);
}
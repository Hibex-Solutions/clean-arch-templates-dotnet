// Copyright (c) Time CleanArch.Templates.Solution. Todos os direitos reservados.
// Este arquivo é parte de CleanArch.Templates.Solution.
// Veja o arquivo LICENSE para informações de licenciamento.

namespace CleanArch.Templates.Solution.DomainTests;

/// <summary>
/// É uma boa prática usar o "Trait target" apontando para a classe testada
/// </summary>
[Trait("target", nameof(Class1))]
public class UnitTest1
{
    // Boa prática usar o "Trait target" apontando para a classe testada

    [Fact(DisplayName = "Sempre use um DisplayName")]
    public void Test1()
    {
    }
}
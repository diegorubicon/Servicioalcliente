Imports SFC.DependencyInjector

Module Bootstrapper
    Public Sub Init()


        DependencyInjector.AddExtension(Of DependencyOfDependencyExtension)()
    End Sub

End Module

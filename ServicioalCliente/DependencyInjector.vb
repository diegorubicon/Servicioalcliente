Imports Unity
Imports Unity.Extension
Imports Unity.Lifetime
Module DependencyInjector
    Private UnityContainer As UnityContainer = New UnityContainer()

    Sub Register(Of I, T As I)()

        UnityContainer.RegisterType(Of I, T)(New ContainerControlledLifetimeManager())
    End Sub

    Sub InjectStub(Of I)(ByVal instance As I)
        UnityContainer.RegisterInstance(instance, New ContainerControlledLifetimeManager())
    End Sub
    Function Retrieve(Of T)() As T
        Return UnityContainer.Resolve(Of T)()
    End Function
    Sub AddExtension(Of T As UnityContainerExtension)()
        UnityContainer.AddNewExtension(Of T)()
    End Sub
End Module

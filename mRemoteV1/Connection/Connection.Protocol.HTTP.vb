Namespace Connection
    Namespace Protocol
        Public Class HTTP
            Inherits Connection.Protocol.HTTPBase

            Public Sub New(ByVal RenderingEngine As RenderingEngine, ByVal i As Connection.Info)
                MyBase.New(RenderingEngine, i)
            End Sub

            Public Overrides Sub NewExtended()
                MyBase.NewExtended()

                httpOrS = "http"
                defaultPort = Defaults.Port
            End Sub

            Public Enum Defaults
                Port = 80
            End Enum
        End Class
    End Namespace
End Namespace

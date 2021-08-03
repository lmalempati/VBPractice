﻿Imports System.Runtime.CompilerServices
Imports Newtonsoft.Json
Public Module modSerialize
    Public Class NACSProductdtls
        Public Property xNACSProductCode As String
        Public Property xUnitOfMeasure As String
        Public Property xQuantity As String
        Public Property xUnitPrice As String
        Public Property xProductAmount As String
    End Class

    Public Class ProdCodeDetGrp
        'Public Property Products As Dictionary(Of String, NACSProductdtls)
        Private _Products As List(Of NACSProductdtls)
        Public Property Products As List(Of NACSProductdtls)
            Get
                Return _Products
            End Get
            Set(value As List(Of NACSProductdtls))
                _Products = Value
            End Set
        End Property
    End Class

    Public Function SerializeNACSProducts() As String
        Dim list As New List(Of NACSProductdtls)
        Dim dict As New Dictionary(Of String, NACSProductdtls)
        Dim obj As New NACSProductdtls()
        obj.xNACSProductCode = "001"
        obj.xUnitOfMeasure = "G"
        obj.xQuantity = "01"
        obj.xProductAmount = "1023"
        obj.xUnitPrice = "21023"
        list.Add(obj)
        Return SerializeJSON(list)
    End Function
    Public Function DeserializeJSONToNACSProducts(Json As String) As List(Of NACSProductdtls)

        Return Json.DeserializeJSON(Of List(Of NACSProductdtls))
    End Function

    <Extension> Public Function DeserializeJSON(Of T)(value As String) As T
        Try
            'Logger.Log("Enter")
            'Return JsonConvert.DeserializeObject(Of T)(value)
            Return JsonConvert.DeserializeObject(Of T)(value)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            'Logger.Log("Exit")
        End Try
    End Function

    <Extension> Public Function SerializeJSON(value As List(Of NACSProductdtls)) As String
        Try
            'Logger.Log("Enter")
            Return JsonConvert.SerializeObject(value)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            'Logger.Log("Exit")
        End Try
    End Function
End Module

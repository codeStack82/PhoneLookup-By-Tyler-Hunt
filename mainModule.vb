Module mainModule

    Public str_People() As String = {"Bill Bryan", "Jake O'Connel",
                                    "Devin Grey", "Jared Russel", "Colby Holmes",
                                    "Drewes Versman", "Augstin Vera"}

    Public str_PhoneNumbers() As String = {"1-405-555-1234", "1-405-555-2345", "1-405-555-3456",
                                        "1-405-555-4567", "1-405-555-5678", "1-405-555-6789", 
                                        "1-405-555-7891"}

    Public list_people As New List(Of String)(str_People)
    Public list_phoneNumber As New List(Of String)(str_PhoneNumbers)



End Module

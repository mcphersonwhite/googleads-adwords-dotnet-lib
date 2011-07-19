' Copyright 2011, Google Inc. All Rights Reserved.
'
' Licensed under the Apache License, Version 2.0 (the "License");
' you may not use this file except in compliance with the License.
' You may obtain a copy of the License at
'
'     http://www.apache.org/licenses/LICENSE-2.0
'
' Unless required by applicable law or agreed to in writing, software
' distributed under the License is distributed on an "AS IS" BASIS,
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
' See the License for the specific language governing permissions and
' limitations under the License.

' Author: api.anash@gmail.com (Anash P. Oommen)

Imports Google.Api.Ads.AdWords.Lib
Imports Google.Api.Ads.AdWords.v201008

Imports System

Namespace Google.Api.Ads.AdWords.Examples.VB.v201008
  ''' <summary>
  ''' This code example gets all videos. To upload video, see
  ''' http://adwords.google.com/support/aw/bin/answer.py?hl=en&amp;answer=39454.
  '''
  ''' Tags: MediaService.get
  ''' </summary>
  Class GetAllVideos
    Inherits SampleBase
    ''' <summary>
    ''' Returns a description about the code example.
    ''' </summary>
    Public Overrides ReadOnly Property Description() As String
      Get
        Return "This code example gets all videos. To upload video, see " & _
            "http://adwords.google.com/support/aw/bin/answer.py?hl=en&answer=39454."
      End Get
    End Property

    ''' <summary>
    ''' Main method, to run this code example as a standalone application.
    ''' </summary>
    ''' <param name="args">The command line arguments.</param>
    Public Shared Sub Main(ByVal args As String())
      Dim codeExample As SampleBase = New GetAllVideos
      Console.WriteLine(codeExample.Description)
      codeExample.Run(New AdWordsUser)
    End Sub

    ''' <summary>
    ''' Run the code example.
    ''' </summary>
    ''' <param name="user">AdWords user running the code example.</param>
    Public Overrides Sub Run(ByVal user As AdWordsUser)
      ' Get the MediaService.
      Dim mediaService As MediaService = user.GetService(AdWordsService.v201008.MediaService)

      ' Create selector.
      Dim selector As New MediaSelector
      selector.mediaType = MediaMediaType.VIDEO

      Try
        ' Get all images.
        Dim page As MediaPage = mediaService.get(selector)

        ' Display images.
        If ((Not page Is Nothing) AndAlso (Not page.entries Is Nothing) _
            AndAlso (page.entries.Length > 0)) Then
          For Each video As Video In page.entries
            Console.WriteLine("Video with id ""{0}"" and name ""{1}"" was found.", _
                video.mediaId, video.name)
          Next
        Else
          Console.WriteLine("No images were found.")
        End If
      Catch ex As Exception
        Console.WriteLine("Failed to get all images. Exception says ""{0}""", _
            ex.Message)
      End Try
    End Sub
  End Class
End Namespace
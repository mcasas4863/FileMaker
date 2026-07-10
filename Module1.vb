'TODO:1. Change Procedure name to your own procedure name

'TODO:2.  Add Json package to the resources

'TODO:3. Create A Project Class

'TODO:4.  Create A Json file for the Project Class

'TODO:5.  Refactor writeFile procedure to take a string for data input

'TODO:6.  move the input variable up to the global class variable access

'TODO:7.  Seralize Project Class

'TODO:8.  Deseralize The Project json Class

'TODO:9.  Use snippets (insert comment) to add comments to procedures and functions

'TODO:10.Refactor your code to create subfolders in a separate procedure

'TODO:11.Remove reference comments

Module Module1

    'READ: 'More information on file reading and writing in the coursebook: pg 68: FileRead

    'https://drive.google.com/file/d/1qwb9Sq3bf9sWPdAUeiFX_xM1Knb4Ikpp/view

    Dim ProjectName As String

    Dim FullDirectory As String

    Sub Main()

        Dim input As String = 0

        While input <> "exit"

            Console.WriteLine("please enter product name.")

            ProjectName = Console.ReadLine

            Console.WriteLine("Please enter a command  Exit | create")

            input = Console.ReadLine.ToString()

            If input = "create" Then

                MakeP2PProjectFolders()

            End If

        End While

    End Sub

    Private Sub MakeP2PProjectFolders()

        'TODO: Add Json database to store project information

        'TODO: Change MakeP2PProjectFolders to MakeProjectFolders

        Dim newFolderPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        If ProjectName = "" Then

            ProjectName = " Not Set\"

        End If

        '  My.Computer.FileSystem.CreateDirectory(newFolderPath + ProjectName)

        CreateProjectFolder(newFolderPath, ProjectName)

        newFolderPath += "\" + ProjectName

        FullDirectory = newFolderPath
        'TODO:Adjust the folder to organize playlist data if needed
        CreateProjectFolder(newFolderPath, "\Docs")
        CreateProjectFolder($"{newFolderPath}\Docs", "Refs")
        CreateProjectFolder($"{newFolderPath}\Docs", "Word")
        CreateProjectFolder($"{newFolderPath}\Docs", "PDF")


        CreateProjectFolder(newFolderPath, "\Assets")
        CreateProjectFolder($"{newFolderPath}\Assets", "Art")
        CreateProjectFolder($"{newFolderPath}\Assets", "Images")

        WriteFile("ReadMe.txt", newFolderPath)
        WriteFile("ReadMe.txt", $"{newFolderPath}\Docs")


        Console.WriteLine("Project created in: " + FullDirectory)

    End Sub
    Private Sub WriteFile(fileName As String, location As String)

        'Ref:https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/drives-directories-files/how-to-write-text-to-files-with-a-streamwriter

        If fileName <> "" Then

            Dim file As System.IO.StreamWriter

            file = My.Computer.FileSystem.OpenTextFileWriter(location + "\" + fileName + ".txt", True)

            file.WriteLine("Week 6 Folder Maker App
Purpose
Midnight Mix is a music playlist planning app that helps users organize and discover songs based on different genres and moods. The app creates playlits by allowing users to explore different music worlds and save songs that match their preffered style.

How To Run
Open the VB.NET Project in Visual Studio
Press the Start Button Or run the project useing the Debug Menu
Follow the instructions Shown in the console window
Enter playlist information and use the available commands.
Folder Structure Created
-Playlist folder songs genres covers data -Files created README.md Playlist data files

Story to App Connection
The idea for Midnight Mix came from the concept of exploring different worlds, inspired by the style of The Midnight Gospel. Instead of traveling to random planets, users explore different music worlds based on genres. The app turns playlist creation into a creative journey where users can discover songs and organize their music.

Team Members
Martha Casas Individual project.

Screenshots
App running in Visual Studio Console showing playlist creation README file created by the app Git repository page Discord submission ")

            file.Close()

        End If

    End Sub

    Sub CreateProjectFolder(newFolderPath As String, ProjectName As String)

        My.Computer.FileSystem.CreateDirectory(newFolderPath + "\" + ProjectName)

    End Sub

End Module

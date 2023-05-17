C# - Hello, World

I did my work in bash but the checker would not accept it. 
This is what I did
In bash
use this to create a .sh file
#! initializes, builds, and runs a C# project in a folder
dotnet new console -o filename
dotnet build "filename"

whatever you name the .sh file will be used to run your projects. This project I used uwu.sh. future projects I used main.sh

then you go to your .sh file and change part of the code to the current project. 
for example 

dotnet new console -o filename
dotnet build "filename'

instead put 
dotnet new console -o taskone
dotnet build "taskone"

run it by using ./uwu.sh
it will create a couple of folders.
change the dotnet folder to curret file name
leave the csproj file alone.
 once files have been created you can adjust your code as needed in cs file
 save work
 push
 
 go to ssh and pull from github
 go into current project and chmod all files
 then push

 the checker should be happy. 

 make sure to pull work when going back into the bash to make a new file. 
 Do everything all over again.

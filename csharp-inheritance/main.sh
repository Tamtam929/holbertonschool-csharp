#!/usr/bin/env bash
# initializes, builds, and runs a C# project in a folder
dotnet new console -o 1-instance
dotnet build "1-instance"
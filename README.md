# AmlEngineImportBug

## EDIT
ISSUE SOLVED with implementation of ``CAEXDocument.IDisposable`` in version ``1.7.4``.

This repo is now archived.

## Original issue description
Repository describing an issue encountered with `Aml.Engine` NuGet package `v1.7.2` on Linux in Release mode.

```
System.NullReferenceException: Object reference not set to an instance of an object.
  Stack Trace:
      at Aml.Engine.CAEX.Extensions.CAEXFileTypeExtensions.ImportLibrary[T](CAEXFileType caexFile, T library)
```

thrown when running multiple calls to `CAEXFile.InstanceHierarchy.Insert` or to `CAEXFile.Import_InstanceHierarchy`.

Only happens with Linux in Release mode.

### Steps to reproduce

- Clone the repo
- Run tests on Windows: all test pass in Debug and Release mode
- Build the Docker image using provided `Dockerfile`
- Run tests in container with `dotnet test -c Debug`: all tests pass
- Run tests in container with `dotnet test -c Release`: not all tests pass

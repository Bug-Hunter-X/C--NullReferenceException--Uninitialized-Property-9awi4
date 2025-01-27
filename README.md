# C# NullReferenceException: Uninitialized Property

This repository demonstrates a common C# error: a `NullReferenceException` occurring when accessing a property that hasn't been initialized. The `bug.cs` file contains the faulty code, while `bugSolution.cs` shows the corrected version.

**Problem:**

The `MyProperty` in `MyClass` is not initialized before being used in `MyMethod`. This leads to a `NullReferenceException` if the property is accessed before it's assigned a value.

**Solution:**

Initialize `MyProperty` either in the constructor, or explicitly assign a value before using it.  This ensures that the property always has a valid value.
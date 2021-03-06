// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Reflection
{
    public static class ModuleExtensions
    {
        public static bool HasModuleVersionId(this Module module)
        {
            Requires.NotNull(module, "module");
            return false; // never available on .NET Native
        }
        
        public static Guid GetModuleVersionId(this Module module)
        {
            Requires.NotNull(module, "module");
            throw new InvalidOperationException(SR.ModuleVersionIdNotSupported);
        }
    }
}

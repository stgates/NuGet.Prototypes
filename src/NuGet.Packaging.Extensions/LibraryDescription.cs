// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace NuGet.Packaging.Extensions
{
    public class LibraryDescription
    {
        public LibraryRange LibraryRange { get; set; }
        public Library Identity { get; set; }
        public IEnumerable<LibraryDependency> Dependencies { get; set; }
        public bool Resolved { get; set; } = true;

        public string Path { get; set; }

        public override string ToString()
        {
            if (Identity == null)
            {
                return LibraryRange?.ToString();
            }

            return Identity + " (" + LibraryRange + ")";
        }
    }
}

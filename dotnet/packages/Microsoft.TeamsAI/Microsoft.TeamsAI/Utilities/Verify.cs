﻿
namespace Microsoft.TeamsAI.Utilities
{
    public class Verify
    {
        public static void ParamNotNull(object? argument, string? parameterName = default)
        {
            if (argument == null)
            {
                throw new ArgumentNullException(parameterName);
            }
        }
    }
}

﻿
using Microsoft.TeamsAI.Utilities;

namespace Microsoft.TeamsAI.AI.Prompt
{
    public class PromptTemplate
    {
        public string Text { get; set; }
        public PromptTemplateConfiguration Configuration { get; set; }

        public PromptTemplate(string text, PromptTemplateConfiguration configuration)
        {
            Verify.ParamNotNull(text, nameof(text));
            Verify.ParamNotNull(configuration, nameof(configuration));

            Text = text;
            Configuration = configuration;
        }
    }
}

using System;
namespace Severino.Validators.Env.Models
{
	public class EnvVarValidation
	{
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string ExpectedValue { get; set; } = string.Empty;
    }
}


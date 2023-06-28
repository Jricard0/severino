using System;
using System.Collections;
using System.Reflection;
using Severino.Validators.Env.Models;

namespace Severino.Validators.Env
{
	public class EnvironmentVarsValidator
	{
        public static Boolean AreEnvironmentVariablesDefined(List<string> desiredVariables)
        {
            if (desiredVariables.Count == 0)
                return true;

            var currentEnvVars = Environment.GetEnvironmentVariables().Cast<DictionaryEntry>().ToDictionary(entry => (string)entry.Key, entry => (string)entry.Value);
            var varNames = currentEnvVars.Keys.ToList();

            return desiredVariables.All(v => varNames.Contains(v));
        }

        public static List<EnvVarValidation> AreEnvironmentVariablesDefinedWithValue(List<string> desiredVariables)
        {
            if (desiredVariables.Count == 0)
                throw new ArgumentException("Parameter 'desiredVariables' must have at least 1 element.");

            var envVars = Environment.GetEnvironmentVariables().Cast<DictionaryEntry>().ToDictionary(entry => (string)entry.Key, entry => (string?)entry.Value).ToList();

            var wrongValues = new List<EnvVarValidation>();

            foreach (var desiredVar in desiredVariables)
            {
                string[] parts = desiredVar.Split("=");
                string key = parts[0];
                string value = parts[1];

                var element = envVars.Find(v => v.Key.Equals(key));
                if (element.Value != value)
                {
                    wrongValues.Add(new EnvVarValidation
                    {
                        Key = key,
                        Value = element.Value,
                        ExpectedValue = value
                    });
                }
            }

            return wrongValues;
        }
    }
}


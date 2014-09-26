namespace _11.VersionAtributes
{
    using System;

    class VersionAttributes
    {

        static void Main()
        {
            Type type = typeof(SampleClass);

            foreach (var attr in type.GetCustomAttributes(false))
            {
                if (attr is VersionAttribute)
                {
                    Console.WriteLine("This is version {0} of the {1} class.",
                        (attr as VersionAttribute).Version, typeof(SampleClass).FullName);
                }
            }
        }
    }

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
        AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
        AllowMultiple = false)]
    public class VersionAttribute : Attribute
    {
        public string Version { get; set; }

        public VersionAttribute(string version)
        {
            Version = version;
        }
    }

    [Version("2.11")]
    public class SampleClass
    {

    }
}

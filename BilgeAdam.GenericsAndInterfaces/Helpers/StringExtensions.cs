namespace BilgeAdam.GenericsAndInterfaces.Helpers
{
    public static class StringExtensions
    {
        public static string MakeFormal(this string name)
        {
            var startOfLastname = name.Trim().LastIndexOf(' ') + 1;
            var lastname = name.Substring(startOfLastname).ToUpper();
            var firstName = name.Substring(0, name.Length - startOfLastname).Trim();
            return $"{firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower()} {lastname}";
        }
    }
}

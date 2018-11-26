namespace OrchardCore.Setup.Annotations
{
    public class SiteNameValidAttribute : System.ComponentModel.DataAnnotations.RangeAttribute
    {
        private string _value;

        public SiteNameValidAttribute(int maximumLength)
            : base(1, maximumLength)
        {
        }

        public override bool IsValid(object value)
        {
            _value = (value as string) ?? "";
            return base.IsValid(_value.Trim().Length);
        }

        public override string FormatErrorMessage(string name)
        {
            if (string.IsNullOrWhiteSpace(_value))
                return "必须输入站点名称。";

            return $"站点名称不能大于{Maximum}个字符。";
        }
    }
}
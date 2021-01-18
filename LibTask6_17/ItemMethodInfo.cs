using System.Reflection;

namespace LIbTask6_17
{
    public class ItemMethodInfo
    {
        public ItemMethodInfo(MethodInfo Value, string Text)
        {
            this.Value = Value;
            this.Text = Text;
        }

        public MethodInfo Value { set; get; }
        public string Text { set; get; }
    }
}
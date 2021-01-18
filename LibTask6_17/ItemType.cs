using System;

namespace LIbTask6_17
{
    public class ItemType
    {
        public ItemType(Type Value, string Text)
        {
            this.Value = Value;
            this.Text = Text;
        }

        public Type Value { set; get; }
        public string Text { set; get; }
    }
}
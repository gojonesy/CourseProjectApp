
namespace CourseProjectApp.Models
{
    public class FirstClass
    {
        public string Value;
        private string _value = "Hello";

        //Properties
        public string MainValue
        {
            get
            {
                return _value;
            }
            set { _value = value; }
        }

        public FirstClass(string value)
        {
            Value = value;
        }
        public FirstClass()
        {

        }
    }
}

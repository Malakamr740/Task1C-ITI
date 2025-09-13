
namespace Task3CSharp
{
    internal class Question
    {
        public  string Header { get; set; }
        public  string Body { get; set; }
        public  double Mark { get; set; }
        public Question(string _header, string _body)
        {
            Header = _header;
            Body = _body;

        }
        public Question(string _header , string _body , double _mark):this( _header ,_body)
        {
  
            Mark = _mark ;
        }
               
        public virtual void show() {
            Console.WriteLine($"Header : {Header} , Body : {Body} , Mark : {Mark}");
        
        }
    }
}

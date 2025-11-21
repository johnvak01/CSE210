public class Comment{
    string _name, _content;
    public Comment(string name, string content){
        _name = name;
        _content = content;
    }
    public string Display(){
        return $"{_name}: {_content}";
    }
}